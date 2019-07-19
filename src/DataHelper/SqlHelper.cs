using DBHelper;
using IOHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHelper
{
    public class SqlHelper
    {
        private IDBHelper _iDBHelper;
        private DataBaseClass _dataBaseClass;
        private string _sql;

        public SqlHelper(string connectString, DataBaseClass dataBaseClass)
        {
            _dataBaseClass = dataBaseClass;

            _iDBHelper = DBHelperFactory.CreateDBHelper(dataBaseClass, connectString);
        }

        public DataTable GetFlatView()
        {
            string dataBaseClassString = (_dataBaseClass).ToString();
            _sql = ConfigHelper.GetAppConfig($"{dataBaseClassString}_GetFlatView");

            return _iDBHelper.Execute(_sql);
        }

        public DataTable GetViewColumn(string viewName)
        {
            _sql = $"select * from {viewName} where 1<>1";

            return _iDBHelper.Execute(_sql);
        }

        public object GetMax(string sql)
        {
            return _iDBHelper.ExecuteScalar(sql);
        }

        public DataTable GetData(string sql)
        {
            return _iDBHelper.Execute(sql);
        }
    }
}
