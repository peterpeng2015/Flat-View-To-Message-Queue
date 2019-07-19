using DataHelper;
using DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Polling
{
    public partial class frmPollConfig : Form
    {
        private DataTable _settingDt;//配置集合
        private DataTable _taskDt;//任务集合

        public frmPollConfig()
        {
            InitializeComponent();
        }

        private void tsb_quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPollConfig_Load(object sender, EventArgs e)
        {
            BindSetting();
            BindTask();
        }

        public void BindSetting()
        {
            _settingDt = new DBConfigHelper().GetFlatViewPollConfig();
            dgv_setting.DataSource = _settingDt;
        }

        public void BindTask()
        {
            _taskDt = new DBConfigHelper().GetTaskList();
            dgv_task.DataSource = _taskDt;
        }

        private void tsb_addpoll_Click(object sender, EventArgs e)
        {
            frmPollingSetting polling = new frmPollingSetting(this);
            polling.ShowDialog();
        }

        private void tsb_updatepoll_Click(object sender, EventArgs e)
        {
            if (dgv_setting.SelectedRows == null || dgv_setting.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择需要修改的记录！");
                return;
            }

            frmPollingSetting polling = new frmPollingSetting(this);
            polling.SettingDr = _settingDt.Rows[dgv_setting.SelectedRows[0].Index];
            polling.ShowDialog();
        }

        private void tsb_deletepoll_Click(object sender, EventArgs e)
        {
            //还要判断是否再使用中
            if (dgv_setting.SelectedRows == null || dgv_setting.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择需要删除的记录！");
                return;
            }

            if (MessageBox.Show("确定要删除选中的记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string pollConfigID = _settingDt.Rows[dgv_setting.SelectedRows[0].Index]["编号"].ToString();

                string[] array = { pollConfigID };

                if (new DBConfigHelper().DeleteFlatViewPollConfig(array) > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
                BindSetting();
            }
        }

        private void tsb_addtask_Click(object sender, EventArgs e)
        {
            frmTaskSettring task = new frmTaskSettring(this);
            task.ShowDialog();
        }

        private void tsb_deletetask_Click(object sender, EventArgs e)
        {
            //还要判断是否再使用中
            if (dgv_task.SelectedRows == null || dgv_task.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择需要删除的记录！");
                return;
            }

            if (MessageBox.Show("确定要删除选中的记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string taskID = _taskDt.Rows[dgv_task.SelectedRows[0].Index]["任务编号"].ToString();

                string[] array = { taskID };

                if (new DBConfigHelper().DeleteSyncTask(array) > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }

                BindTask();
            }
        }
    }
}
