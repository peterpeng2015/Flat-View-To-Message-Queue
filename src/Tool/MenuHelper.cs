using Client;
using IOHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool
{
    public class MenuHelper
    {
        public static List<BaseMenu> GetMenuList()
        {
            string json = ReadHelper.Read(Application.StartupPath + "\\menu.json");

            if (string.IsNullOrEmpty(json))
            {
                throw new ArgumentNullException("菜单json字符串为空！");
            }

            return JsonHelper.Json2List<BaseMenu>(json);
        }
    }
}
