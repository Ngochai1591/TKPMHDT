using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using Food_Order_Manager.DTO;
using Food_Order_Manager.BuilderPattern;

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

        public DataSet ShowListNV()
        {
            DataSet result = new DataSet();
            string sql = "Select Username, Name, Password, Position, Sex, DOB, Address, NumberPhone from Account";
            DataAccess data = new DataAccess();
            result = data.GetDataSet(sql);
            return result;
        }

        public int AddNV(User user)
        {
            int result = -1;
            string sql = "INSERT INTO Account VALUES (@Username, @Password, @Name, @Position, @Sex, @DOB, @Address, @NumberPhone)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@Username", user.Username),
                new SqlParameter("Password", user.Password),
                new SqlParameter("@Name",user.Name),
                new SqlParameter("@Position",user.Position),
                new SqlParameter("@Sex",user.Sex),
                new SqlParameter("@DOB",user.DOB),
                new SqlParameter("@Address",user.Address),
                new SqlParameter("@NumberPhone",user.NumberPhone)
            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;
        }

        public int UpdateNV(AccountDTO dto)
        {
            int result = -1;
            string sql = "UPDATE Account SET Password = @Password, Name = @Name, Position = @Position, Sex = @Sex, DOB = @DOB, Address = @Address, NumberPhone = @NumberPhone WHERE Username = @Username";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@Username", dto.Username),
                new SqlParameter("@Password", dto.Password),
                new SqlParameter("@Name",dto.Name),
                new SqlParameter("@Position",dto.Position),
                new SqlParameter("@Sex",dto.Sex),
                new SqlParameter("@DOB",dto.DOB),
                new SqlParameter("@Address",dto.Address),
                new SqlParameter("@NumberPhone",dto.NumberPhone)
            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;
        }
        public int DeleteNV(string Username)
        {
            int result = -1;
            string sql = "DELETE FROM Account WHERE Username = @Username";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@Username", Username),
            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;
        }
    }
}
