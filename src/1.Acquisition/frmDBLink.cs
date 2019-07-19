using DataHelper;
using DBHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acquisition
{
    public partial class frmDBLink : Form
    {
        private frmMaster _master;
        private DataRow _linkDr;

        public frmDBLink(frmMaster frm, DataRow linkDr = null)
        {
            InitializeComponent();
            _master = frm;
            _linkDr = linkDr;
            BindCombobox();
        }

        private void frmDBLink_Load(object sender, EventArgs e)
        {

        }

        private void BindCombobox()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            foreach (int v in Enum.GetValues(typeof(DataBaseClass)))
            {
                dict.Add(v, Enum.GetName(typeof(DataBaseClass), v));
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = dict;
            cbb_dbClass.DataSource = bs;
            cbb_dbClass.ValueMember = "Key";
            cbb_dbClass.DisplayMember = "Value";

            if (_linkDr == null)
            {
                cbb_dbClass.SelectedIndex = 0;
            }
            else
            {
                cbb_dbClass.SelectedIndex = Convert.ToInt32(_linkDr["数据源类型"]);
                InitView();
            }
        }

        private void InitView()
        {
            txt_dbName.Text = _linkDr["数据源名称"].ToString();
            dbConnect._host = _linkDr["主机名"].ToString();
            dbConnect._port = _linkDr["端口号"].ToString();
            dbConnect._dbName = _linkDr["数据库名"].ToString();
            dbConnect._userName = _linkDr["用户名"].ToString();
            dbConnect._password = _linkDr["密码"].ToString();
        }

        private void tsb_save_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            if (!dbConnect.CheckValue())
            {
                return;
            }
            DataBaseClass dataBaseClass = (DataBaseClass)cbb_dbClass.SelectedIndex;
            string conn = string.Empty;
            switch (dataBaseClass)
            {
                case DataBaseClass.SqlServer:
                    conn = $"data source={dbConnect._host};initial catalog={dbConnect._dbName};user id={dbConnect._userName};password={dbConnect._password};";
                    break;
                case DataBaseClass.Oracle:
                    conn = $"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={dbConnect._host})(PORT={dbConnect._port}))(CONNECT_DATA=(SERVICE_NAME={dbConnect._dbName})));Persist Security Info=True;user id={dbConnect._userName};password={dbConnect._password};";
                    break;
                case DataBaseClass.Mysql:
                    break;
                case DataBaseClass.MongoDB:
                    break;
                case DataBaseClass.DB2:
                    break;
                default:
                    break;
            }

            //添加
            if (_linkDr == null)
            {
                string[] array = { txt_dbName.Text.Trim(), cbb_dbClass.SelectedIndex.ToString(), dbConnect._host, dbConnect._port, dbConnect._dbName, dbConnect._userName, dbConnect._password, "0", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), conn };

                DBConfigHelper helper = new DBConfigHelper();
                if (helper.InsertSourceDatabaseConfig(array) > 0)
                {
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            }//修改
            else
            {
                string[] array = { txt_dbName.Text.Trim(), cbb_dbClass.SelectedIndex.ToString(), dbConnect._host, dbConnect._port, dbConnect._dbName, dbConnect._userName, dbConnect._password, "0", _linkDr["数据源添加时间"].ToString(), _linkDr["数据源代码"].ToString(), conn };

                DBConfigHelper helper = new DBConfigHelper();
                if (helper.UpdateSourceDatabaseConfig(array) > 0)
                {
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            }


            _master.BindDGV();
            Close();
        }

        private bool ValidateData()
        {
            if (string.IsNullOrEmpty(txt_dbName.Text.Trim()))
            {
                MessageBox.Show("请填写数据库名称！");

                return false;
            }

            if (cbb_dbClass.SelectedIndex < 0)
            {
                MessageBox.Show("请选择数据库类型！");

                return false;
            }

            return true;
        }

        private void tsb_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
