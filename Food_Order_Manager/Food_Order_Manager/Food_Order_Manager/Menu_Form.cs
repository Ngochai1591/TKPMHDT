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
            quantity = 1;
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
        private int total = 0;
        private void loadingGridView()
        {
            total = 0;
            billDTO dto = new billDTO();
            dto.billId = txt_NumberBill.Text;

            DataSet result = new DataSet();
            billBO billbo = new billBO();
            result =billbo.getBillInfoByBillId(dto);

            dgv_BillDetails.DataSource = result.Tables[0];

            for(int i =0;i<result.Tables[0].Rows.Count;i++)
            {
                total = total + (int.Parse(result.Tables[0].Rows[i][4].ToString()) * int.Parse(result.Tables[0].Rows[i][5].ToString()));
            }
            txt_Total.Text = String.Format("{0:n0}", total);
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
            if (Login_Form.POSITION == "Manager" || Login_Form.POSITION == "Cashier")
            {
                Bill_Details_Form form = new Bill_Details_Form();
                form.BILLID = txt_NumberBill.Text;
                form.TOTAL = total;
                this.Hide();
                form.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Bạn không có quyền này","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private void bnt_DeleteFoodDetail_Click(object sender, EventArgs e)
        {
            if(dgv_BillDetails.Rows.Count == 0)
            {
                MessageBox.Show("Hiện không còn món nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dgv_BillDetails.Rows.Count == 1)
                {
                    tableDTO tabledto = new tableDTO();
                    tabledto.tableID = tableId;
                    tabledto.status = "FREE";
                    tableBO tablebo = new tableBO();
                    int result1 = tablebo.setTableStatus(tabledto);
                    if (result1 != -1)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi thay đổi trạng thái bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                billDTO dto = new billDTO();
                dto.billId = txt_NumberBill.Text;
                dto.ordinalNumber = int.Parse(dgv_BillDetails.CurrentRow.Cells["OrdinalNumber"].Value.ToString());
                billBO bo = new billBO();
                int result = bo.deleteSingleFoodByBillIdAndOrdinalNumber(dto);
                if (result != -1)
                {
                    loadingGridView();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra ,Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           



        }

        private void btn_CancelBill_Click(object sender, EventArgs e)
        {
            if(dgv_BillDetails.Rows.Count == 0)
            {
                MessageBox.Show("Không có món nào trong hóa đơn, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (Login_Form.POSITION == "Manager" || Login_Form.POSITION == "Cashier")
                {
                    DialogResult dialog = MessageBox.Show("Bạn có muốn cancel Bill này chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        billDTO dto = new billDTO();
                        dto.billId = txt_NumberBill.Text;
                        billBO bo = new billBO();
                        int result = bo.cancelBill(dto);
                        if (result != -1)
                        {
                            tableDTO tabledto = new tableDTO();
                            tabledto.tableID = tableId;
                            tabledto.status = "FREE";
                            tableBO tablebo = new tableBO();
                            int result1 = tablebo.setTableStatus(tabledto);
                            if (result1 != -1)
                            {
                                MessageBox.Show("Đã cancel Bill !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Table_Form form = new Table_Form();
                                this.Hide();
                                form.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Lỗi khi thay đổi trạng thái bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Đã có lỗi xảy ra, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
