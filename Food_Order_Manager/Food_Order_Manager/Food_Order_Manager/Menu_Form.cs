using Food_Order_Manager.BO;
using Food_Order_Manager.DTO;
using Food_Order_Manager.userControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Order_Manager
{
    public partial class Menu_Form : Form
    {
        public Menu_Form()
        {
            InitializeComponent();
        }
        //table id
        private string tableId;
        public string TABLEID
        {
            set
            {
                tableId = value;
            }
            get
            {
                return tableId;
            }
        }
        //table name
        private string tableName;
        public string TABLENAME
        {
            set
            {
                tableName = value;
            }
            get
            {
                return tableName;
            }
        }
        string billId = "";

        private void Menu_Form_Load(object sender, EventArgs e)
        {
            //checking table status
            //if table status = "USING"
            //Show the food in bill
            //if table status ="FREE"
            //create new BillId;
            tableDTO dto = new tableDTO();
            dto.tableID = tableId;

            DataSet result = new DataSet();
            tableBO bo = new tableBO();
            result = bo.getTableStatus(dto);
            if(result.Tables.Count >0 && result.Tables[0].Rows.Count >0)
            {
                if (result.Tables[0].Rows[0][0].ToString().Trim() == "FREE")
                {
                    billId = createId();
                    txt_NumberBill.Text = billId;
                }
                else
                {
                    //if it is USING
                    loadingBillByTableId();
                    
                }
            }
            loadingMenu();
        }
        private void loadingBillByTableId()
        {
            billDTO dto = new billDTO();
            dto.tableId = tableId;
            dto.status = "USING";
            billBO bo = new billBO();
            DataSet result = bo.getBillInfoByTableId(dto);
            txt_NumberBill.Text = result.Tables[0].Rows[0][0].ToString().Trim();
            ordinal = int.Parse(result.Tables[0].Rows[result.Tables[0].Rows.Count - 1][1].ToString());
           // ordinal = 
            loadingGridView();

        }
        private void loadingMenu()
        {
            txt_TableName.Text = tableName;
            txt_Name.Text = Login_Form.NAME;
            loadingCategory();
        }

        private List<categoryDTO> CategoryList = new List<categoryDTO>();
        private void loadingCategory()
        {
            flp_Category.Controls.Clear();
            categoryBO bo = new categoryBO();
            DataSet result = bo.getAllCategory();
            for(int i =0;i<result.Tables[0].Rows.Count;i++)
            {
                System.Byte[] arr = (result.Tables[0].Rows[i][2]) as System.Byte[];
                CategoryList.Add(new categoryDTO { categoryId = result.Tables[0].Rows[i][0].ToString(), categoryName = result.Tables[0].Rows[i][1].ToString(), categoryPicture = arr });
                Category categoryUC = new Category();
                categoryUC.CATEGORYID = CategoryList[i].categoryId;
                categoryUC.CATEGORYNAME = CategoryList[i].categoryName;
                categoryUC.CATEGORYPICTURE = CategoryList[i].categoryPicture;

                
                flp_Category.Controls.Add(categoryUC);

                foreach(Control control in categoryUC.Controls)
                {
                    control.Click += (sender, e) =>
                    {
                        loadingFoodByCategoryId(sender, e, categoryUC.CATEGORYID);
                    };
                }
            }

            

        }
        private void loadingFoodByCategoryId(object sender, EventArgs e, string categoryId)
        {
            flp_Food.Controls.Clear();
            foodBO bo = new foodBO();
            foodDTO dto = new foodDTO();
            dto.categoryId = categoryId;
            DataSet result = bo.getFoodByCategoryId(dto);
            for (int i = 0; i < result.Tables[0].Rows.Count; i++)
            {
                Food foodUC = new Food();
                foodUC.CATEGORYID = categoryId;
                foodUC.FOODID = result.Tables[0].Rows[i][0].ToString();
                foodUC.FOODNAME = result.Tables[0].Rows[i][1].ToString();
                foodUC.FOODPRICE = int.Parse(result.Tables[0].Rows[i][4].ToString());
                System.Byte[] arr = (result.Tables[0].Rows[i][3]) as System.Byte[];
                foodUC.FOODPICTURE = arr;
                flp_Food.Controls.Add(foodUC);

                foreach(Control control in foodUC.Controls)
                {
                    control.Click += (sender1, e1) =>
                    {
                        addFood(sender1, e1, foodUC.FOODID, foodUC.FOODPRICE);
                    };
                }

            }
        }

        int ordinal = 0;
        int quantity = 1;
        private void addFood(Object sender, EventArgs e, string foodId, int foodPrice)
        {
            billDTO dto = new billDTO();
            //create tempcartid

            dto.billId = txt_NumberBill.Text;
            dto.tableId = tableId;
            dto.username = Login_Form.USERNAME;
            //update ordinal number
            ordinal = ordinal + 1;
            dto.ordinalNumber = ordinal;
            dto.foodId = foodId;
            dto.cost = foodPrice;
            dto.quantity = quantity;
            dto.date = DateTime.Now;
            dto.status = "USING";
            //set table status 
            tableDTO table = new tableDTO();
            table.status = "USING";
            table.tableID = tableId;
            tableBO tablebo = new tableBO();
            tablebo.setTableStatus(table);
            //

            billBO billbo = new billBO();
            int result = billbo.addFood(dto);
            if(result != -1)
            {
                loadingGridView();
            }

            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }

        private string createId()
        {
            string id = "";
            string restaurantName = "SinhVienQuan";
            string date = DateTime.Now.ToString();

            date = date.Replace(":", "");
            date = date.Replace("/", "");
            date = date.Replace(" ", "");
            id = restaurantName + "_" + date.ToString();

            return id;
        }

        private void loadingGridView()
        {

            billDTO dto = new billDTO();
            dto.billId = txt_NumberBill.Text;

            DataSet result = new DataSet();
            billBO billbo = new billBO();
            result =billbo.getBillInfoByBillId(dto);

            dgv_BillDetails.DataSource = result.Tables[0];

        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Table_Form table = new Table_Form();
            this.Hide();
            table.ShowDialog();
            this.Close();
        }

        private void bnt_PrintBill_Click(object sender, EventArgs e)
        {
            if (Login_Form.POSITION == "QUANLY" || Login_Form.POSITION == "THUNGAN")
            {
                MessageBox.Show("Bạn được thực hiện");
            }
            else
            {
                MessageBox.Show("Bạn không có quyền này");
            }
        }

        private void btn_Quantity_1_Click(object sender, EventArgs e)
        {
            quantity = 1;
        }

        private void btn_Quantity_2_Click(object sender, EventArgs e)
        {
            quantity = 2;
        }

        private void btn_Quantity_3_Click(object sender, EventArgs e)
        {
            quantity = 3;
        }

        private void btn_Quantity_4_Click(object sender, EventArgs e)
        {
            quantity = 4;
        }

        private void btn_Quantity_5_Click(object sender, EventArgs e)
        {
            quantity = 5;
        }

        private void btn_Quantity_6_Click(object sender, EventArgs e)
        {
            quantity = 6;
        }

        private void btn_Quantity_7_Click(object sender, EventArgs e)
        {
            quantity = 7;
        }

        private void btn_Quantity_8_Click(object sender, EventArgs e)
        {
            quantity = 8;
        }

        private void btn_Quantity_9_Click(object sender, EventArgs e)
        {
            quantity = 9;
        }

        private void btn_Quantity_10_Click(object sender, EventArgs e)
        {
            quantity = 10;
        }
    }
}
