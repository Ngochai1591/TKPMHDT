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
    class billBO
    {
        public int addFood(billDTO dto)
        {
            int result = -1;
            string query = @"INSERT INTO Bill VALUES(@BillId, @OrdinalNumber,  @FoodId,@Username, @Quantity, @Cost, @TableId, @Date, @Status)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@BillId", dto.billId),
                new SqlParameter("@OrdinalNumber", dto.ordinalNumber),
                new SqlParameter("@FoodId", dto.foodId),
                new SqlParameter("@Username", dto.username),
                new SqlParameter("@Quantity", dto.quantity),
                new SqlParameter("@Cost",dto.cost),
                new SqlParameter("@TableId", dto.tableId),
                new SqlParameter("@Date", dto.date),
                new SqlParameter("@Status", dto.status),
            };
            DataAccess data = new DataAccess();
            result = data.Execute(query, para);
            return result;
        }


        public DataSet getBillInfoByBillId(billDTO dto)
        {
            DataSet result = new DataSet();
            string query = @"SELECT * FROM Bill WHERE BillId = @BillId";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@BillId", dto.billId),
            };

            DataAccess data = new DataAccess();

            result = data.GetDataSet(query, para);

            return result;
        }
        public DataSet getBillInfoByTableId(billDTO dto)
        {
            DataSet result = new DataSet();
            string query = @"SELECT * FROM Bill WHERE TableId = @TableId AND Status = @Status";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@TableId", dto.tableId),
                new SqlParameter("@Status", dto.status),
            };
            DataAccess data = new DataAccess();
            result = data.GetDataSet(query, para);

            return result;

        }

        public DataSet getFoodByFoodId(billDTO dto)
        {
            DataSet result = new DataSet();
            string query = @"SELECT FoodName, FoodPrice FROM Food WHERE FoodId = @FoodId";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@FoodId", dto.foodId)
            };

            DataAccess data = new DataAccess();
            result = data.GetDataSet(query, para);
            return result;
        }

        public int paymentForBill(billDTO dto)
        {
            int result = -1;
            string query = @"UPDATE Bill SET Status = 'Done' WHERE BillId = @BillId";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@BillId",dto.billId)
            };
            DataAccess data = new DataAccess();
            result = data.Execute(query, para);
            return result;
        }

        public int deleteSingleFoodByBillIdAndOrdinalNumber(billDTO dto)
        {
            int result = -1;
            string query = @"DELETE FROM Bill WHERE BillId = @BillId AND OrdinalNumber = @OrdinalNumber";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@BillId", dto.billId),
                new SqlParameter("@OrdinalNumber", dto.ordinalNumber),
            };
            DataAccess data = new DataAccess();
            result = data.Execute(query, para);

            return result;
        }

        public int cancelBill(billDTO dto)
        {
            int result = -1;
            string query = @"UPDATE Bill SET Status = 'CANCEL' WHERE BillId = @BillId";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@BillId", dto.billId),
            };
            DataAccess data = new DataAccess();
            result = data.Execute(query, para);


            return result;
        }
        
    }
}
