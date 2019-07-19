using Preserve;
using System;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;

namespace FV2MQServices
{
    public partial class MainService : ServiceBase
    {
        public MainService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //调试服务
#if DEBUG
            if (!Debugger.IsAttached)
                Debugger.Launch();
            Debugger.Break();
#endif
            Engine.Start();
        }

        protected override void OnStop()
        {
            Engine.ClearJobTrigger();
        }
    }
}
