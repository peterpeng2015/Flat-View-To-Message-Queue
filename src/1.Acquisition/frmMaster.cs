using DataHelper;
using System;
using System.Data;
using System.Windows.Forms;

namespace Acquisition
{
    public partial class frmMaster : Form
    {
        private DataTable _linkDt;
        public frmMaster()
        {
            InitializeComponent();
        }

        private void frmMaster_Load(object sender, EventArgs e)
        {
            BindDGV();
        }

        public void BindDGV()
        {
            _linkDt = new DBConfigHelper().GetSourceDatabaseConfig();
            dgv_dbLink.DataSource = _linkDt;
        }

        private void tsb_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsb_addLink_Click(object sender, EventArgs e)
        {
            frmDBLink frm = new frmDBLink(this);
            frm.ShowDialog();
        }

        private void tsb_modifyLink_Click(object sender, EventArgs e)
        {
            if (dgv_dbLink.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要修改的记录！");

                return;
            }

            frmDBLink frm = new frmDBLink(this, _linkDt.Rows[dgv_dbLink.SelectedRows[0].Index]);
            frm.ShowDialog();
        }

        private void tsb_deleteLink_Click(object sender, EventArgs e)
        {
            if (dgv_dbLink.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要修改的记录！");

                return;
            }

            if (MessageBox.Show("确认要删除这条记录吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            string[] array = { _linkDt.Rows[dgv_dbLink.SelectedRows[0].Index]["数据源代码"].ToString() };

            DBConfigHelper helper = new DBConfigHelper();
            if (helper.DeleteSourceDatabaseConfig(array) > 0)
            {
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败！");
            }

        }
    }
}
