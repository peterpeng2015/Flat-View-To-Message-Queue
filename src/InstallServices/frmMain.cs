using System;
using System.Collections;
using System.Configuration.Install;
using System.ServiceProcess;
using System.Windows.Forms;

namespace InstallServices
{
    public partial class frmMain : Form
    {
        string serviceFilePath = $@"{Application.StartupPath}\\FV2MQServices.exe";
        string serviceName = "FV2MQServices";

        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_install_Click(object sender, EventArgs e)
        {
            if (this.IsServiceExisted(serviceName)) this.UninstallService(serviceName);
            this.InstallService(serviceFilePath);
            MessageBox.Show("安装成功！");
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (this.IsServiceExisted(serviceName)) this.ServiceStart(serviceName);
            MessageBox.Show("启动成功！");
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (this.IsServiceExisted(serviceName)) this.ServiceStop(serviceName);
            MessageBox.Show("暂停成功！");
        }

        private void btn_uninstall_Click(object sender, EventArgs e)
        {
            if (this.IsServiceExisted(serviceName))
            {
                this.ServiceStop(serviceName);
                this.UninstallService(serviceFilePath);
            }

            MessageBox.Show("卸载成功！");
        }

        //判断服务是否存在
        private bool IsServiceExisted(string serviceName)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController sc in services)
            {
                if (sc.ServiceName.ToLower() == serviceName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        //安装服务
        private void InstallService(string serviceFilePath)
        {
            using (AssemblyInstaller installer = new AssemblyInstaller())
            {
                installer.UseNewContext = true;
                installer.Path = serviceFilePath;
                IDictionary savedState = new Hashtable();
                installer.Install(savedState);
                installer.Commit(savedState);
            }
        }

        //卸载服务
        private void UninstallService(string serviceFilePath)
        {
            using (AssemblyInstaller installer = new AssemblyInstaller())
            {
                installer.UseNewContext = true;
                installer.Path = serviceFilePath;
                installer.Uninstall(null);
            }
        }
        //启动服务
        private void ServiceStart(string serviceName)
        {
            using (ServiceController control = new ServiceController(serviceName))
            {
                if (control.Status == ServiceControllerStatus.Stopped)
                {
                    control.Start();
                }
            }
        }

        //停止服务
        private void ServiceStop(string serviceName)
        {
            using (ServiceController control = new ServiceController(serviceName))
            {
                if (control.Status == ServiceControllerStatus.Running)
                {
                    control.Stop();
                }
            }
        }
    }
}
