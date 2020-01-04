using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace Food_Order_Manager.SingletonPattern
{
    public class TaiKhoanDTOSingleton
    {
        public static  UserLoginSingleton SignIn(string Username, string Password)
        {
            DataSet result = new DataSet();
            string sql = @"SELECT * FROM Account WHERE Username = @Username AND Password = @PassWord ";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@Username",Username),
                new SqlParameter("@PassWord",Password),
            };
            DataAccess data = new DataAccess();
            result = data.GetDataSet(sql, para);
            if(result.Tables.Count > 0 && result.Tables[0] != null && result.Tables[0].Rows.Count > 0)
            {
                UserLoginSingleton userlogin = UserLoginSingleton.GetInstance();
                userlogin.NAME =result.Tables[0].Rows[0][2].ToString();
                userlogin.POSITION =result.Tables[0].Rows[0][3].ToString();
                userlogin.USERNAME =result.Tables[0].Rows[0][0].ToString();
                return userlogin;
            }
            else
            {   
                return null;
            }
          

           
        }

    }
}
