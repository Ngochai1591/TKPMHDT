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
    class AccountBO
    {
        public DataSet SignIn(AccountDTO dto)
        {
            DataSet result = new DataSet();
            string sql = @"SELECT * FROM Account WHERE Username = @Username AND Password = @PassWord ";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@Username",dto.Username),
                new SqlParameter("@PassWord",dto.Password),
            };
            DataAccess data = new DataAccess();
            result = data.GetDataSet(sql, para);
            return result;
        }

        public int SignUp(AccountDTO dto)
        {
            int result = -1;
            string sql = "INSERT INTO Account VALUES (@Username, @Password, @Name, @Position)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@Username", dto.Username),
                new SqlParameter("Password", dto.Password),
                new SqlParameter("@Name",dto.Name),
                new SqlParameter("@Position",dto.Position)
            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;
        }
    }
}
