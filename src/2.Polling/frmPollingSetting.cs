using DataHelper;
using DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Polling
{
    public partial class frmPollingSetting : Form
    {
        private DataTable _linkDt;//数据连接集合
        private DataTable _flatViewDt;//视图集合
        private Dictionary<int, string> _columnDict;//所选视图中的所有列
        private string _connectString;
        private DataBaseClass _dataBaseClass;
        private frmPollConfig _main;
        public DataRow SettingDr;
        public frmPollingSetting(frmPollConfig frm)
        {
            _main = frm;
            InitializeComponent();
        }

        private void frmPollingSetting_Load(object sender, EventArgs e)
        {
            BindSource();

            if (SettingDr != null)
            {
                FillControls();
            }
        }

        private void BindSource()
        {
            _linkDt = new DBConfigHelper().GetSourceDatabaseConfig();
            cbb_conn.DataSource = _linkDt;
            cbb_conn.ValueMember = "数据源代码";
            cbb_conn.DisplayMember = "数据源名称";
        }

        private void BindFlatView()
        {
            if (cbb_conn.SelectedIndex < 0)
            {
                return;
            }
            _connectString = _linkDt.Rows[cbb_conn.SelectedIndex]["连接字符串"].ToString();
            _dataBaseClass = (DataBaseClass)Convert.ToInt32(_linkDt.Rows[cbb_conn.SelectedIndex]["数据源类型"]);
            _flatViewDt = new SqlHelper(_connectString, _dataBaseClass).GetFlatView();
            cbb_view.DataSource = _flatViewDt;
            cbb_view.DisplayMember = "视图名";
            cbb_view.ValueMember = "视图名";
        }

        private void InitColumnType()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            foreach (ConstraintColumnType type in Enum.GetValues(typeof(ConstraintColumnType)))
            {
                dict.Add((int)type, type.ToString());
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = dict;
            cbb_type.DataSource = bs;
            cbb_type.ValueMember = "Key";
            cbb_type.DisplayMember = "Value";
        }

        private void InitColumn()
        {
            if (cbb_view.SelectedIndex < 0)
            {
                return;
            }

            string viewName = _flatViewDt.Rows[cbb_view.SelectedIndex]["视图名"].ToString();
            DataTable dt = new SqlHelper(_connectString, _dataBaseClass).GetViewColumn(viewName);
            _columnDict = new Dictionary<int, string>();

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                _columnDict.Add(i, dt.Columns[i].ColumnName);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = _columnDict;

            cbb_column.DataSource = bs;
            cbb_column.DisplayMember = "Value";
            cbb_column.ValueMember = "Key";
        }

        private bool ValidateValue()
        {
            if (string.IsNullOrEmpty(txt_pollinginterval.Text.Trim()))
            {
                MessageBox.Show("轮询时长不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (string.IsNullOrEmpty(txt_pollingrecordcount.Text.Trim()))
            {
                MessageBox.Show("轮询记录数/间隔不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (string.IsNullOrEmpty(txt_retrycount.Text.Trim()))
            {
                MessageBox.Show("重试次数不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (string.IsNullOrEmpty(txt_retryinterval.Text.Trim()))
            {
                MessageBox.Show("重试时长不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (string.IsNullOrEmpty(txt_initvalue.Text.Trim()))
            {
                MessageBox.Show("初始值不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private void tsb_save_Click(object sender, EventArgs e)
        {
            if (!ValidateValue())
            {
                return;
            }

            DBConfigHelper helper = new DBConfigHelper();

            if (SettingDr == null)
            {
                string[] array = { cbb_conn.SelectedValue.ToString(), cbb_view.Text, txt_pollinginterval.Text, txt_pollingrecordcount.Text, txt_retrycount.Text, txt_retryinterval.Text, "0", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), cbb_column.Text, txt_initvalue.Text, cbb_type.SelectedIndex.ToString() };
                if (helper.InsertFlatViewPollConfig(array) > 0)
                {
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            }
            else
            {
                string[] array = { cbb_conn.SelectedValue.ToString(), cbb_view.Text, txt_pollinginterval.Text, txt_pollingrecordcount.Text, txt_retrycount.Text, txt_retryinterval.Text, cbb_column.Text, txt_initvalue.Text, cbb_type.SelectedIndex.ToString(), SettingDr["编号"].ToString() };
                if (helper.UpdateFlatViewPollConfig(array) > 0)
                {
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            }

            _main.BindSetting();
            Close();
        }

        private void FillControls()
        {
            cbb_conn.SelectedValue = Convert.ToInt32(SettingDr["数据源代码"]);
            cbb_view.SelectedValue = SettingDr["视图名"];
            txt_pollinginterval.Text = SettingDr["同步时长"].ToString();
            txt_pollingrecordcount.Text = SettingDr["同步记录数"].ToString();
            txt_retrycount.Text = SettingDr["重试次数"].ToString();
            txt_retryinterval.Text = SettingDr["重试时长"].ToString();
            cbb_type.SelectedIndex = Convert.ToInt32(SettingDr["约束列类型"]);
            cbb_column.Text = SettingDr["约束列"].ToString();
            txt_initvalue.Text = SettingDr["初始值"].ToString();
        }

        private void tsb_quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbb_conn_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindFlatView();
        }

        private void cbb_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitColumnType();
            InitColumn();
        }
    }
}
