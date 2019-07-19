using DataHelper;
using Polling;
using Quartz;
using Quartz.Impl;
using System;
using System.Data;

namespace QuartzJob
{
    class Program
    {
        private static readonly string tiggerName = "FV2MQJobTrigger";
        private static readonly string gropName = "FV2MQJobGroup";
        private static readonly string jobName = "FV2MQJob";
        //从工厂中获取一个调度器实例化
        private static IScheduler scheduler = null;

        static void Main(string[] args)
        {
            Console.WriteLine("开始任务....");
            Start();
        }

        public static DataTable _taskList;

        //获取任务列表
        public static void GetTaskList()
        {
            _taskList = new DBConfigHelper().GetSyncTaskConfig();
        }

        private static async void Start()
        {
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
                                               .WithIntervalInSeconds(60)   //触发时间，10秒一次。
                                               .RepeatForever())
                                           .Build();

            await scheduler.ScheduleJob(mainJob, mainTrigger);      //把作业，触发器加入调度器。

            Console.ReadLine();
        }

        /// <summary>
        /// 清除任务和触发器
        /// </summary>
        public static void ClearJobTrigger(int index)
        {
            TriggerKey triggerKey = new TriggerKey(tiggerName + index.ToString(), gropName);
            JobKey jobKey = new JobKey(jobName + index.ToString(), gropName);
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
