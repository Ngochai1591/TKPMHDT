using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using Food_Order_Manager.DTO;

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

        public int setTableStatus(tableDTO dto)
        {
            int result = -1;
            string query = @"UPDATE tableList SET Status = @Status WHERE TableId = @TableId";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@Status", dto.status),
                new SqlParameter("@TableId",dto.tableID),
            };

            DataAccess data = new DataAccess();
            result = data.Execute(query, para);

            return result;
        }

        public DataSet getTableStatus(tableDTO dto)
        {
            DataSet result = new DataSet();
            string query = @"SELECT Status FROM tableList WHERE TableId = @TableId";

            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@TableId", dto.tableID),
            };

            DataAccess data = new DataAccess();
            result = data.GetDataSet(query, para);

            return result;


        }

    }
}
