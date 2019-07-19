using log4net.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool
{
    public partial class MainView : Form
    {
        private List<BaseMenu> _baseMenuList;
        public MainView()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            log4net.ILog log = log4net.LogManager.GetLogger("WebLogger");//获取一个日志记录器

            log.Info(DateTime.Now.ToString() + ": login success");//写入一条新log

            _baseMenuList = MenuHelper.GetMenuList();

            InitContextMenu("0", menu_main.Items);
        }


        void InitContextMenu(string parentId, ToolStripItemCollection tsc)
        {
            var list = _baseMenuList.Where(m => m.ParentId == parentId).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                ToolStripMenuItem innerItem = new ToolStripMenuItem();
                innerItem.Text = list[i].Name;//显示名称
                innerItem.Name = list[i].Id;//名称

                if (parentId != "0")
                {
                    innerItem.Click += MenuClicked;//绑定点击事件
                }

                tsc.Add(innerItem);

                InitContextMenu(list[i].Id, innerItem.DropDownItems);
            }
        }

        void MenuClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            BaseMenu baseMenu = _baseMenuList.Where(m => m.Id == item.Name).FirstOrDefault();

            if ("退出".Equals(baseMenu.Name))
            {
                if (MessageBox.Show("确定要退出吗？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }

                return;
            }

            var obj = Activator.CreateInstance(baseMenu.DLLName, baseMenu.ClassFullName);

            Form f = (Form)obj.Unwrap();

            if ("0".Equals(baseMenu.Display))
            {
                f.ShowDialog();
            }
            else
            {
                tc_main.TabPages.Clear();
                TabPage tp = new TabPage();
                tp.Name = baseMenu.Id + baseMenu.Name;
                tp.Text = baseMenu.Name;
                f.TopLevel = false;
                f.Parent = tp;
                tc_main.TabPages.Add(tp);

                if (!tc_main.Visible)
                {
                    tc_main.Visible = true;
                }

                f.FormBorderStyle = FormBorderStyle.None;
                f.Show();


            }

        }
    }
}
