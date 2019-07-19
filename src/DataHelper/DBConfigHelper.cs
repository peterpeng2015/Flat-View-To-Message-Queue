using DBHelper;
using IOHelper;
using System.Data;
using System.IO;
using System.Reflection;

namespace DataHelper
{
    public class DBConfigHelper
    {
        private string _insertSourceDatabaseConfig = @"
INSERT INTO [dbo].[SourceDatabaseConfig]
           ([SourceName]
           ,[SourceType]
           ,[SourceHost]
           ,[SourcePort]
           ,[SourceDBName]
           ,[SourceDBUserName]
           ,[SourceDBPassword]
           ,[SourceStatus]
           ,[SourceAddTime]
           ,[SourceConnString])
     VALUES
           ('{0}'
           ,{1}
           ,'{2}'
           ,'{3}'
           ,'{4}'
           ,'{5}'
           ,'{6}'
           ,'{7}'
           ,'{8}'
           ,'{9}')";
        private string _updateSourceDatabaseConfig = @"
UPDATE [dbo].[SourceDatabaseConfig]
   SET [SourceName] = '{0}'
      ,[SourceType] = {1}
      ,[SourceHost] = '{2}'
      ,[SourcePort] = '{3}'
      ,[SourceDBName] = '{4}'
      ,[SourceDBUserName] = '{5}'
      ,[SourceDBPassword] = '{6}'
      ,[SourceStatus] = '{7}'
      ,[SourceAddTime] = '{8}'
      ,[SourceConnString]='{10}'
 WHERE SourceID={9}";
        private string _deleteSourceDatabaseConfig = @"
DELETE FROM [dbo].[SourceDatabaseConfig]
      WHERE SourceID={0}";
        private string _getSourceDatabaseConfig = @"
SELECT [SourceID] 数据源代码
      ,[SourceName] 数据源名称
      ,[SourceType] 数据源类型
      ,[SourceHost] 主机名
      ,[SourcePort] 端口号
      ,[SourceDBName] 数据库名
      ,[SourceDBUserName] 用户名
      ,[SourceDBPassword] 密码
      ,[SourceStatus] 数据源状态
      ,[SourceAddTime] 数据源添加时间
      ,[SourceConnString] 连接字符串
  FROM [dbo].[SourceDatabaseConfig]";

        private string _insertFlatViewPollConfig = @"
INSERT INTO [dbo].[FlatViewPollConfig]
           ([SourceID]
           ,[ViewName]
           ,[SyncInterval]
           ,[BatchCount]
           ,[ReTryCount]
           ,[ReTryInterval]
           ,[Status]
           ,[AddTime]
           ,[ConstraintColumnName]
           ,[ConstraintInitValue]
           ,[ConstraintType])
     VALUES
           ({0}
           ,'{1}'
           ,{2}
           ,{3}
           ,{4}
           ,{5}
           ,{6}
           ,'{7}'
           ,'{8}'
           ,'{9}'
           ,{10})";
        private string _updateFlatViewPollConfig = @"
UPDATE [dbo].[FlatViewPollConfig]
   SET [SourceID] = {0}
      ,[ViewName] = '{1}'
      ,[SyncInterval] = {2}
      ,[BatchCount] = {3}
      ,[ReTryCount] = {4}
      ,[ReTryInterval] = {5}
      ,[ConstraintColumnName]='{6}'
      ,[ConstraintInitValue]='{7}'
      ,[ConstraintType]={8}
 WHERE PollConfigID={9}";
        private string _deleteFlatViewPollConfig = @"
DELETE FROM [dbo].[FlatViewPollConfig]
      WHERE PollConfigID={0}";
        private string _getFlatViewPollConfig = @"
SELECT [PollConfigID] 编号
      ,[SourceID] 数据源代码
      ,[ViewName] 视图名
      ,[SyncInterval] 同步时长
      ,[BatchCount] 同步记录数
      ,[ReTryCount] 重试次数
      ,[ReTryInterval] 重试时长
      ,[ConstraintType] 约束列类型
      ,[ConstraintColumnName] 约束列
      ,[ConstraintInitValue] 初始值
      ,[Status] 状态
      ,[AddTime] 新增时间
  FROM [dbo].[FlatViewPollConfig]";
        private string _updateLastSyncNo = @"
UPDATE [dbo].[SyncTask]
   SET
      [LastSyncNo]='{0}'
 WHERE TaskID={1}";

        private string _insertSyncTask = @"
INSERT INTO [dbo].[SyncTask]
           ([PollConfigID]
           ,[LastSyncNo]
           ,[AddTime]
           ,[TaskType]
           ,[TaskResult]
)
     VALUES
           ({0}
           ,'{1}'
           ,'{2}'
           ,{3}
           ,{4})";
        private string _updateSyncTask = @"
UPDATE [dbo].[SyncTask]
   SET [PollConfigID] = {0}
      ,[LastSyncNo] = {1}
      ,[AddTime] = '{2}'
 WHERE TaskID={3}";
        private string _deleteSyncTask = @"
DELETE FROM [dbo].[SyncTask]
      WHERE TaskID={0}";
        private string _getSyncTask = @"
SELECT [TaskID] 任务编号
      ,[PollConfigID] 配置编号
      ,[LastSyncNo] 最新序号
      ,[AddTime] 添加时间
      ,[TaskType] 任务类型
      ,[TaskResult] 执行结果
  FROM [dbo].[SyncTask]";

        private string _insertTaskLog = @"
INSERT INTO [dbo].[TaskLog]
           ([TaskID]
           ,[StartTime]
           ,[EndTime]
           ,[StartSyncNo]
           ,[LastSyncNo]
           ,[ExecCount]
           ,[SuccCount]
           ,[FaliCount])
     VALUES
           ({0}
           ,'{1}'
           ,'{2}'
           ,'{3}'
           ,'{4}'
           ,{5}
           ,{6}
           ,{7})";
        private string _getTaskLog = @"
SELECT [LogID]
      ,[TaskID]
      ,[StartTime]
      ,[EndTime]
      ,[LastSyncNo]
      ,[ExecCount]
      ,[SuccCount]
      ,[FaliCount]
  FROM [dbo].[TaskLog]";
        private string _syncTask = @"
select 
    a.TaskID,
	a.TaskType,
	a.TaskResult,
	b.PollConfigID,
	b.ViewName,
	b.SyncInterval,
	b.BatchCount,
	b.ReTryCount,
	b.ReTryInterval,
    b.ConstraintColumnName,
	b.ConstraintType,
	c.SourceID,
	c.SourceType,
	c.SourceConnString,
    0 Status
from [dbo].[SyncTask] a
left join [dbo].[FlatViewPollConfig] b on a.PollConfigID=b.PollConfigID
left join[dbo].[SourceDatabaseConfig] c on c.SourceID=b.SourceID";

        private string _getLastSyncNo = "select LastSyncNo from SyncTask where TaskID={0}";
        static string assemblyFilePath = Assembly.GetExecutingAssembly().Location;
        static string configFilePath = Path.GetDirectoryName(assemblyFilePath);
        private static string _connectionString = ConfigHelper.GetOtherConfig(configFilePath + "\\services.config", "ConfigConnectionString");
        private SqlServerHelper _helper;

        public DBConfigHelper()
        {
            if (_helper == null)
                _helper = new SqlServerHelper(_connectionString);
        }

        public int InsertSourceDatabaseConfig(params string[] array)
        {
            string sql = string.Format(_insertSourceDatabaseConfig, array);

            return _helper.ExecuteNoQuery(sql);
        }

        public int UpdateSourceDatabaseConfig(params string[] array)
        {
            string sql = string.Format(_updateSourceDatabaseConfig, array);

            return _helper.ExecuteNoQuery(sql);
        }

        public int DeleteSourceDatabaseConfig(params string[] array)
        {
            string sql = string.Format(_deleteSourceDatabaseConfig, array);

            return _helper.ExecuteNoQuery(sql);
        }

        public int InsertFlatViewPollConfig(params string[] array)
        {
            string sql = string.Format(_insertFlatViewPollConfig, array);

            return _helper.ExecuteNoQuery(sql);
        }

        public int UpdateFlatViewPollConfig(params string[] array)
        {
            string sql = string.Format(_updateFlatViewPollConfig, array);

            return _helper.ExecuteNoQuery(sql);
        }

        public int DeleteFlatViewPollConfig(params string[] array)
        {
            string sql = string.Format(_deleteFlatViewPollConfig, array);

            return _helper.ExecuteNoQuery(sql);
        }

        public DataTable GetFlatViewPollConfig()
        {
            return _helper.Execute(_getFlatViewPollConfig);
        }

        public DataTable GetTaskList()
        {
            return _helper.Execute(_getSyncTask);
        }

        public int InsertSyncTask(params string[] array)
        {
            string sql = string.Format(_insertSyncTask, array);

            return _helper.ExecuteNoQuery(sql);
        }

        public int UpdateSyncTask(params string[] array)
        {
            string sql = string.Format(_updateSyncTask, array);

            return _helper.ExecuteNoQuery(sql);
        }

        public int DeleteSyncTask(params string[] array)
        {
            string sql = string.Format(_deleteSyncTask, array);

            return _helper.ExecuteNoQuery(sql);
        }

        public DataTable GetSourceDatabaseConfig()
        {
            return _helper.Execute(_getSourceDatabaseConfig);
        }

        public DataTable GetSyncTaskConfig()
        {
            return _helper.Execute(_syncTask);
        }

        public int UpdateLastSyncNo(params string[] array)
        {
            string sql = string.Format(_updateLastSyncNo, array);

            return _helper.ExecuteNoQuery(sql);
        }

        public string GetLastSyncNo(string taskId)
        {
            string sql = string.Format(_getLastSyncNo, taskId);

            return _helper.ExecuteScalar(sql).ToString();
        }

        public int InsertTaskLog(params string[] array)
        {
            string sql = string.Format(_insertTaskLog, array);

            return _helper.ExecuteNoQuery(sql);
        }
    }
}
