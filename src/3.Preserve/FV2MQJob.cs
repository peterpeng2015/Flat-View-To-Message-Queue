using DataHelper;
using DBHelper;
using IOHelper;
using Quartz;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Preserve
{
    public class FV2MQJob : IJob
    {
        private string _jobName;//任务名称
        private string _endSyncNo;//最新时间或者序号
        private log4net.ILog log = log4net.LogManager.GetLogger("testApp.Logging");//获取一个日志记录器
        private DateTime startDateTime;//任务开始时间
        private DateTime endDateTime;//任务结束时间

        Task IJob.Execute(IJobExecutionContext context)
        {
            JobDataMap dataMap = context.JobDetail.JobDataMap;
            int taskId = dataMap.GetInt("taskId");

            DataRow[] array = Engine._taskList.Select($"TaskID={taskId}");
            if (array.Length == 0)
            {
                return null;
            }
            DataRow dr = array[0];
            _jobName = $"TaskID:{taskId}的任务";
            //上次任务没有执行完成，等执行完成后再执行0未执行1执行中2执行成功
            if (dr != null && dr["Status"].ToString().Equals("1"))
            {
                return null;
            }

            dr["Status"] = 1;//执行中

            RunSingleTask(dr);

            Console.WriteLine("===============================");
            return null;
        }

        /// <summary>
        /// 判断任务有无执行完成
        /// </summary>
        /// <param name="dr"></param>
        public void RunSingleTask(DataRow dr)
        {
            if (dr == null)
            {
                return;
            }
            string constraintValue = new DBConfigHelper().GetLastSyncNo(dr["TaskID"].ToString());//最新的时间或者序号
            object obj = GetMaxConstraintValue(dr, constraintValue);//当前要取数据的最大值

            int seqNo = 0;
            if (obj == null || string.IsNullOrEmpty(obj.ToString()) || (int.TryParse(constraintValue, out seqNo) && Convert.ToInt32(obj) <= Convert.ToInt32(constraintValue)))
            {
                Console.WriteLine($"{_jobName}暂时没有需要同步的记录！当前时间{DateTime.Now}");
                log.Info($"{_jobName}暂时没有需要同步的记录！当前时间{DateTime.Now}");
                dr["Status"] = 0;
                return;
            }
            startDateTime = DateTime.Now;
            Console.WriteLine($"{_jobName}开始执行，当前时间{startDateTime}");
            log.Info($"{_jobName}开始执行，当前时间{startDateTime}");
            ConstraintColumnType constrainType = (ConstraintColumnType)Convert.ToInt32(dr["ConstraintType"]);
            string viewName = dr["ViewName"].ToString();//源数据库视图名称
            string constraintColumnName = dr["ConstraintColumnName"].ToString();//约束列名称
            string conn = dr["SourceConnString"].ToString();//源数据库连接字符串
            string batchCount = dr["BatchCount"].ToString();//批量处理记录数或者间隔
            int reTryCount = Convert.ToInt32(dr["ReTryCount"]);//重试次数
            int reTryInterval = Convert.ToInt32(dr["ReTryInterval"]);//重试间隔
            DataBaseClass databaseClass = (DataBaseClass)Convert.ToInt32(dr["SourceType"]);

            StringBuilder builder = new StringBuilder();
            builder.Append("select * from ");
            builder.Append(viewName);

            switch (constrainType)
            {
                case ConstraintColumnType.日期时间列:
                    builder.Append(" where ");
                    builder.Append(constraintColumnName);
                    builder.Append(">");
                    builder.Append(FillStringBuilder(databaseClass, constraintValue));
                    builder.Append(" and ");
                    builder.Append(constraintColumnName);
                    builder.Append("<=");
                    _endSyncNo = Convert.ToDateTime(obj).ToString("yyyy-MM-dd HH:mm:ss:fff");
                    builder.Append(FillStringBuilder(databaseClass, _endSyncNo));
                    break;
                case ConstraintColumnType.自增长列:
                    builder.Append(" where ");
                    builder.Append(constraintColumnName);
                    builder.Append(">");
                    builder.Append(constraintValue);
                    builder.Append(" and ");
                    builder.Append(constraintColumnName);
                    builder.Append("<=");
                    int count = Convert.ToInt32(constraintValue) + Convert.ToInt32(batchCount);
                    if (count > Convert.ToInt32(obj))
                    {
                        count = Convert.ToInt32(obj);
                    }
                    _endSyncNo = count.ToString();
                    builder.Append(count);
                    break;
                default:
                    break;
            }

            string sql = builder.ToString();
            log.Info($"获取数据源的SQL语句：{sql}");

            SqlHelper helper = new SqlHelper(conn, databaseClass);

            DataTable dt = null;

            for (int i = 0; i < reTryCount; i++)
            {
                if (dt == null)
                {
                    try
                    {
                        dt = helper.GetData(sql);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Thread.Sleep(reTryInterval);
                    }
                }
            }

            BulkCopy(dt);

            UpdateConfig(dr);

            //修改为未执行状态
            dr["Status"] = 0;
            endDateTime = DateTime.Now;
            log.Info($"{_jobName}执行结束，当前时间{endDateTime}");
            Console.WriteLine($"{_jobName}执行结束，当前时间{endDateTime}");

            //同步记录总数
            int total = dt.Rows.Count;

            string[] array = { dr["TaskID"].ToString(), startDateTime.ToString("yyyy-MM-dd HH:mm:ss:fff"), endDateTime.ToString("yyyy-MM-dd HH:mm:ss:fff"), constraintValue, _endSyncNo, total.ToString(), total.ToString(), "0" };

            try
            {
                new DBConfigHelper().InsertTaskLog(array);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                log.Error(ex.Message);
            }
        }

        private string FillStringBuilder(DataBaseClass dataBaseClass, object initValue)
        {
            StringBuilder sb = new StringBuilder();
            switch (dataBaseClass)
            {
                case DataBaseClass.SqlServer:
                    sb.Append("'");
                    sb.Append(initValue);
                    sb.Append("' ");
                    break;
                case DataBaseClass.Oracle:
                    sb.Append("to_date('");
                    sb.Append(initValue);
                    sb.Append("','yyyy-mm-dd hh24:mi:ss') ");
                    break;
                case DataBaseClass.Mysql:
                    sb.Append("'");
                    sb.Append(initValue);
                    sb.Append("' ");
                    break;
                case DataBaseClass.MongoDB:
                    break;
                case DataBaseClass.DB2:
                    break;
                default:
                    break;
            }

            return sb.ToString();
        }

        //获取最大的约束值假设A，要轮询得区间为(B,C]
        //如果A<C，则轮询得空间缩小为(B,A]
        public object GetMaxConstraintValue(DataRow dr, string constraintValue)
        {
            if (dr == null)
            {
                return null;
            }

            string viewName = dr["ViewName"].ToString();
            string constraintColumnName = dr["ConstraintColumnName"].ToString();
            int batchCount = Convert.ToInt32(dr["BatchCount"]);
            int reTryCount = Convert.ToInt32(dr["ReTryCount"]);//重试次数
            int reTryInterval = Convert.ToInt32(dr["ReTryInterval"]);//重试间隔
            ConstraintColumnType constrainType = (ConstraintColumnType)Convert.ToInt32(dr["ConstraintType"]);
            DataBaseClass databaseClass = (DataBaseClass)Convert.ToInt32(dr["SourceType"]);
            StringBuilder sb = new StringBuilder();
            sb.Append("select max(");
            sb.Append(constraintColumnName);
            sb.Append(") from ");

            switch (constrainType)
            {
                case ConstraintColumnType.日期时间列:
                    sb.Append(" (select top ");
                    sb.Append(batchCount);
                    sb.Append(" ");
                    sb.Append(constraintColumnName);
                    sb.Append("  from ");
                    sb.Append(viewName);
                    sb.Append(" where ");
                    sb.Append(constraintColumnName);
                    sb.Append(">");
                    sb.Append(FillStringBuilder(databaseClass, constraintValue));
                    sb.Append(" order by ");
                    sb.Append(constraintColumnName);
                    sb.Append(" ) as TempTable");
                    break;
                case ConstraintColumnType.自增长列:
                    sb.Append(viewName);
                    sb.Append(" where ");
                    sb.Append(constraintColumnName);
                    sb.Append(">");
                    sb.Append(constraintValue);
                    break;
                default:
                    sb.Append(" 1=1 ");
                    break;
            }
            string sql = sb.ToString();
            log.Info($"GetMaxConstraintValue的SQL语句：{sql}");

            string conn = dr["SourceConnString"].ToString();

            SqlHelper helper = new SqlHelper(conn, databaseClass);

            object max = null;

            for (int i = 0; i < reTryCount; i++)
            {
                if (max == null)
                {
                    try
                    {
                        max = helper.GetMax(sql);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        log.Error(ex.Message);
                        Thread.Sleep(reTryInterval);
                    }
                }
            }

            return max;
        }

        //更新状态
        public void UpdateConfig(DataRow dr)
        {
            if (dr == null)
            {
                return;
            }
            string[] array = { _endSyncNo, dr["TaskID"].ToString() };

            try
            {

                if (new DBConfigHelper().UpdateLastSyncNo(array) > 0)
                {
                    Console.WriteLine("@更新最新时间或序列号成功！@");
                }
                else
                {
                    Console.WriteLine("#更新最新时间或序列号失败！#");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                log.Error(ex.Message);
            }
        }

        private void BulkCopy(DataTable dt)
        {
            string assemblyFilePath = Assembly.GetExecutingAssembly().Location;
            string configFilePath = Path.GetDirectoryName(assemblyFilePath);
            string strConn = ConfigHelper.GetOtherConfig(configFilePath + "\\services.config", "TargetConnectionString");
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlBulkCopy copy = new SqlBulkCopy(conn))
                {
                    //目标表
                    copy.DestinationTableName = "dbo.[MessageViewerData]";

                    //字段映射
                    copy.ColumnMappings.Add("MsgID", "MsgID");
                    copy.ColumnMappings.Add("RetrieverID", "RetrieverID");
                    copy.ColumnMappings.Add("MsgType", "MsgType");
                    copy.ColumnMappings.Add("SeqNo", "SeqNo");
                    copy.ColumnMappings.Add("MsgDtTmPosted", "MsgDtTmPosted");
                    copy.ColumnMappings.Add("MsgData", "MsgData");
                    copy.ColumnMappings.Add("MsgInfo", "MsgInfo");
                    copy.ColumnMappings.Add("status", "status");
                    //正式写入数据源
                    copy.WriteToServer(dt);
                }
            }
        }
    }
}
