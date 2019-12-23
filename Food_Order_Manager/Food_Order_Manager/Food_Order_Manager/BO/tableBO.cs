using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
namespace Food_Order_Manager.BO
{
    class tableBO
    {
        public DataSet getAllTable()
        {
            DataSet tableList = new DataSet();
            string query = "SELECT * FROM tableList";
            DataAccess data = new DataAccess();
            tableList = data.GetDataSet(query);
            return tableList;
        }
    }
}
