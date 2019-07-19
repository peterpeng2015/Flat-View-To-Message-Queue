using DataHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Polling
{
    public partial class frmTaskSettring : Form
    {
        private DataTable _settingDt;
        private frmPollConfig _main;

        public frmTaskSettring(frmPollConfig frm)
        {
            _main = frm;
            InitializeComponent();
        }

        private void frmTaskSettring_Load(object sender, EventArgs e)
        {
            BindPolling();
            BindTaskResult();
            BindTaskType();
        }

        private void BindPolling()
        {
            _settingDt = new DBConfigHelper().GetFlatViewPollConfig();
            cbb_polling.DataSource = _settingDt;
            cbb_polling.DisplayMember = "视图名";
            cbb_polling.ValueMember = "编号";
        }

        private void BindTaskResult()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            foreach (ResultType type in Enum.GetValues(typeof(ResultType)))
            {
                dict.Add((int)type, type.ToString());
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = dict;
            cbb_taskresult.DataSource = bs;
            cbb_taskresult.ValueMember = "Key";
            cbb_taskresult.DisplayMember = "Value";
        }

        private void BindTaskType()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            foreach (TaskType type in Enum.GetValues(typeof(TaskType)))
            {
                dict.Add((int)type, type.ToString());
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = dict;
            cbb_tasktype.DataSource = bs;
            cbb_tasktype.ValueMember = "Key";
            cbb_tasktype.DisplayMember = "Value";
        }

        private void tsb_quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsb_save_Click(object sender, EventArgs e)
        {
            string[] array = { cbb_polling.SelectedValue.ToString(), _settingDt.Select("编号=" + cbb_polling.SelectedValue.ToString())[0]["初始值"].ToString(), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), cbb_tasktype.SelectedValue.ToString(), cbb_taskresult.SelectedValue.ToString() };

            if (new DBConfigHelper().InsertSyncTask(array) > 0)
            {
                MessageBox.Show("保存成功！");
            }
            else
            {
                MessageBox.Show("保存失败！");
            }

            _main.BindTask();
            Close();
        }
    }
}
