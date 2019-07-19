using DataHelper;
using IOHelper;
using Quartz;
using Quartz.Impl;
using System;
using System.Data;
using System.IO;
using System.Reflection;

namespace Preserve
{
    /// <summary>
    /// 获取所有任务
    /// </summary>
    public class Engine
    {
        private static readonly string tiggerName = "FV2MQJobTrigger";
        private static readonly string gropName = "FV2MQJobGroup";
        private static readonly string jobName = "FV2MQJob";
        //从工厂中获取一个调度器实例化
        private static IScheduler scheduler = null;
        private static int mainTaskInterval = 60;

        public static DataTable _taskList;

        //获取任务列表
        public static void GetTaskList()
        {
            _taskList = new DBConfigHelper().GetSyncTaskConfig();
        }

        //主任务
        public static async void Start()
        {
            string assemblyFilePath = Assembly.GetExecutingAssembly().Location;
            string configFilePath = Path.GetDirectoryName(assemblyFilePath);
            mainTaskInterval = Convert.ToInt32(ConfigHelper.GetOtherConfig(configFilePath + "\\services.config", "MainTaskInterval"));

            //从工厂中获取一个调度器实例化
            scheduler = await StdSchedulerFactory.GetDefaultScheduler();
            await scheduler.Start();

            //创建一个作业
            IJobDetail mainJob = JobBuilder.Create<LoopTaskListJob>()
             .WithIdentity("mainJob", gropName)
             .Build();

            ITrigger mainTrigger = TriggerBuilder.Create()
                                           .WithIdentity("mainTrigger", gropName)
                                           .StartNow()                        //现在开始
                                           .WithSimpleSchedule(x => x
                                               .WithIntervalInSeconds(mainTaskInterval)   //触发时间，10秒一次。
                                               .RepeatForever())
                                           .Build();

            await scheduler.ScheduleJob(mainJob, mainTrigger); //把作业，触发器加入调度器。
        }

        /// <summary>
        /// 清除任务和触发器
        /// </summary>
        public static void ClearJobTrigger()
        {
            for (int i = 0; i < _taskList.Rows.Count; i++)
            {
                string taskId = _taskList.Rows[i]["TaskID"].ToString();
                TriggerKey triggerKey = new TriggerKey(tiggerName + taskId, gropName);
                JobKey jobKey = new JobKey(jobName + taskId, gropName);
                if (scheduler != null)
                {
                    scheduler.PauseTrigger(triggerKey);
                    scheduler.UnscheduleJob(triggerKey);
                    scheduler.DeleteJob(jobKey);
                    scheduler.Shutdown();// 关闭
                }
            }
        }
    }
}
