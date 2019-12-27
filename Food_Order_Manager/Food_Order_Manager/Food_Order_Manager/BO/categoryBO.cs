using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Food_Order_Manager.DTO;

namespace Food_Order_Manager.BO
{
    class categoryBO
    {
        public DataSet getAllCategory()
        {
            DataSet result = new DataSet();
            string query = "SELECT * FROM Category";
            DataAccess data = new DataAccess();
            result = data.GetDataSet(query);
            return result;
        }
        public int addCategory(categoryDTO dto)
        {
            int result = -1;
            string query = @"INSERT INTO Category VALUES(@categoryId, @categoryName, @categoryPicture)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@categoryId", dto.categoryId),
                new SqlParameter("@categoryName", dto.categoryName),
                new SqlParameter("@categoryPicture", dto.categoryPicture)
            };
            DataAccess data = new DataAccess();

            result = data.Execute(query, para);

            return result;
        }

        public int deleteCategory(categoryDTO dto)
        {
            int result = -1;
            string query = @"DELETE FROM Category Where categoryId = @categoryId";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@categoryId", dto.categoryId),
            };

            DataAccess data = new DataAccess();

            result = data.Execute(query, para);

            return result;
        }
        public int editCategory(categoryDTO dto)
        {
            int result = -1;
            string query =@"UPDATE Category SET categoryName = @categoryName, categoryPicture = @categoryPicture WHERE categoryId = @categoryId";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@categoryName", dto.categoryName),
                new SqlParameter("@categoryPicture", dto.categoryPicture),
                new SqlParameter("@categoryId", dto.categoryId)
            };

            DataAccess data = new DataAccess();

            result = data.Execute(query, para);

            return result;
        }
    }

}
