using DataAccessLayer;
using Food_Order_Manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Order_Manager.BO
{
    class foodBO
    {
        public DataSet getFoodByFoodId(foodDTO dto)
        {
            DataSet result = new DataSet();
            string query = @"SELECT FoodName FROM Food WHERE FoodId = @FoodId ";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@FoodId", dto.foodId),
            };
            DataAccess data = new DataAccess();
            result = data.GetDataSet(query, para);

            return result;
        }
        public DataSet getAllFood()
        {
            DataSet result = new DataSet();
            string query = "SELECT * FROM Food";
            DataAccess data = new DataAccess();
            result = data.GetDataSet(query);
            return result;
        }

        public DataSet getFoodByCategoryId(foodDTO dto)
        {
            DataSet result = new DataSet();
            string query = "SELECT * FROM Food WHERE CategoryId=@categoryId";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@categoryId", dto.categoryId)
            };
            DataAccess data = new DataAccess();

            result = data.GetDataSet(query, para);

            return result;
        }
        public DataSet getAllCategory()
        {
            DataSet result = new DataSet();
            string query = "SELECT * FROM Category";
            DataAccess data = new DataAccess();
            result = data.GetDataSet(query);
            return result;
        }
        public DataSet getCategoryNameByID(categoryDTO dto)
        {
            DataSet result = new DataSet();
            string query = "SELECT CategoryName FROM Category WHERE CategoryId = @categoryId";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@categoryId", dto.categoryId)
            };

            DataAccess data = new DataAccess();
            result = data.GetDataSet(query, para);
            return result;
        }
        public int addFood(foodDTO dto)
        {
            int result = -1;
            string query = @"INSERT INTO Food VALUES(@FoodId, @FoodName, @CategoryId, @FoodPicture, @FoodPrice)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@FoodId", dto.foodId),
                new SqlParameter("@FoodName", dto.foodName),
                new SqlParameter("@CategoryId", dto.categoryId),
                new SqlParameter("@FoodPicture", dto.foodPicture),
                new SqlParameter("@FoodPrice", dto.foodPrice),
            };
            DataAccess data = new DataAccess();

            result = data.Execute(query, para);

            return result;
        }
        public int deleteFood(foodDTO dto)
        {
            int result = -1;
            string query = @"DELETE FROM Food Where foodId = @FoodId";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@FoodId", dto.foodId),
            };

            DataAccess data = new DataAccess();

            result = data.Execute(query, para);

            return result;
        }
        public int editFood(foodDTO dto)
        {
            int result = -1;
            string query = @"UPDATE Food SET foodName = @foodName, foodPicture = @foodPicture, categoryId = @categoryId, foodPrice = @foodPrice WHERE foodId = @foodId";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@foodId",dto.foodId),
                new SqlParameter("@foodName", dto.foodName),
                new SqlParameter("@foodPicture", dto.foodPicture),
                new SqlParameter("@categoryId", dto.categoryId),
                new SqlParameter("@foodPrice", dto.foodPrice),

            };

            DataAccess data = new DataAccess();

            result = data.Execute(query, para);

            return result;
        }


    }
}
