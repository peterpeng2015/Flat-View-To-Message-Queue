using DataHelper;
using Polling;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace QuartzJob
{
    public class LoopTaskListJob : IJob
    {
        private readonly string tiggerName = "FV2MQJobTrigger";
        private readonly string gropName = "FV2MQJobGroup";
        private readonly string jobName = "FV2MQJob";
        private static DataTable taskDt;
        //从工厂中获取一个调度器实例化
        private IScheduler scheduler = null;

        public Task Execute(IJobExecutionContext context)
        {
            LoopTaskList();
            return null;
        }

        public async void LoopTaskList()
        {
            Console.WriteLine("主任务开始");
            Program.GetTaskList();

            if (Program._taskList == null || Program._taskList.Rows.Count == 0)
            {
                Console.WriteLine("当前无任务需要执行！");
                return;
            }

            if (taskDt == null)
            {
                taskDt = Program._taskList.Clone();
            }

            var newTask = Program._taskList.AsEnumerable().Except(taskDt.AsEnumerable(), DataRowComparer.Default);

            //比较结束后
            taskDt = Program._taskList;
            if (newTask == null)
            {
                return;
            }

            List<DataRow> taskList = newTask.ToList<DataRow>();

            //从工厂中获取一个调度器实例化
            scheduler = await StdSchedulerFactory.GetDefaultScheduler();
            await scheduler.Start();

            for (int i = 0; i < taskList.Count; i++)
            {
                object taskIdObj = taskList[i]["TaskID"];

                //创建一个作业
                IJobDetail job = JobBuilder.Create<FV2MQJob>()
                 .WithIdentity(jobName + taskIdObj.ToString(), gropName)
                 .UsingJobData("taskId", Convert.ToInt32(taskIdObj))
                 .Build();

                TaskType type = (TaskType)Convert.ToInt32(taskList[i]["TaskType"].ToString());
                ITrigger trigger = null;

                //若是单次任务，只执行一次即可
                if (type == TaskType.单次任务)
                {
                    // 创建触发器
                    trigger = TriggerBuilder.Create()
                                               .WithIdentity(tiggerName + taskIdObj.ToString(), gropName)
                                               .StartNow()                        //现在开始
                                               .WithSimpleSchedule(x => x
                                                   .WithIntervalInSeconds(Convert.ToInt32(taskList[i]["SyncInterval"]))   //触发时间，10秒一次。
                                                   .WithRepeatCount(2))
                                               .Build();
                }
                else//否则不简单重复执行
                {
                    // 创建触发器
                    trigger = TriggerBuilder.Create()
                                               .WithIdentity(tiggerName + taskIdObj.ToString(), gropName)
                                               .StartNow()                        //现在开始
                                               .WithSimpleSchedule(x => x
                                                   .WithIntervalInSeconds(Convert.ToInt32(taskList[i]["SyncInterval"]))   //触发时间，10秒一次。
                                                   .RepeatForever())              //不间断重复执行
                                               .Build();
                }

                await scheduler.ScheduleJob(job, trigger);      //把作业，触发器加入调度器。
            }

            Console.WriteLine("主任务结束");
            Console.WriteLine("==========================");
        }
    }
}
