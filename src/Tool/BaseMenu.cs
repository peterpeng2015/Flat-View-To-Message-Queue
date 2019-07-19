namespace Tool
{
    public class BaseMenu
    {
        public string Id { get; set; }//节点id
        public string ParentId { get; set; }//菜单父节点
        public string Name { get; set; }//节点名称
        public string Display { get; set; }//展示方式0弹出1内嵌
        public string DLLName { get; set; }//DLL名称
        public string ClassFullName { get; set; }//包括命名空间的类
    }
}
