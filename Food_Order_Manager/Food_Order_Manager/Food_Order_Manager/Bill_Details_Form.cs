using Food_Order_Manager.BO;
using Food_Order_Manager.DTO;
using Food_Order_Manager.SingletonPattern;
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
    public partial class Bill_Details_Form : Form
    {

        public UserLoginSingleton userlogin;
        public Bill_Details_Form()
        {
            InitializeComponent();
        }
        public string BILLID
        {
            get
            {
                return billid;
            }
            set
            {
                billid = value;
            }
        }
        private int total;
        public int TOTAL
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }
        private string billid;
        private void Bill_Details_Form_Load(object sender, EventArgs e)
        {
           // this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
            this.AutoScroll = true;

            this.pl_BillDetals.AutoSize = true;
            this.pl_BillDetals.AutoSizeMode = AutoSizeMode.GrowOnly;
          
           
            //


            loadingBillDetails();
        }

        private void loadingBillDetails()
        {
            lb_NAME.Text = userlogin.NAME;
            lb_BillId.Text = billid;
            billDTO dto = new billDTO();
            dto.billId = billid;
            billBO bo = new billBO();
            DataSet result = new DataSet();
            result = bo.getBillInfoByBillId(dto);
            string tableId = "";
            // Point initPoint = new Point(0, 0);
            if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < result.Tables[0].Rows.Count; i++)
                {
                    foodDTO fooddto = new foodDTO();
                    fooddto.foodId = result.Tables[0].Rows[i][2].ToString();
                    foodBO foodbo = new foodBO();
                    DataSet foodTable = new DataSet();
                    foodTable = foodbo.getFoodByFoodId(fooddto);
                    BillInfo info = new BillInfo();
                    info.FOODNAME = foodTable.Tables[0].Rows[0][0].ToString();
                    info.FOODPRICE = int.Parse(result.Tables[0].Rows[i][5].ToString());
                    info.QUANTITY = int.Parse(result.Tables[0].Rows[i][4].ToString());
                    int y = 50 * i;
                    info.Location = new Point(0, y);
                    this.pl_BillDetals.Controls.Add(info);
                }
                tableId = result.Tables[0].Rows[0][6].ToString().Trim();
                Label lb_characters = new Label();
                Label lb_TotalText = new Label();
                Label lb_Total = new Label();
                lb_characters.Text = "--------------------------------------------------------------------------";
                lb_characters.Font = new Font("Times New Roman", 11.0f, FontStyle.Bold);
                lb_characters.Location = new Point(32, pl_BillDetals.Location.Y + pl_BillDetals.Size.Height + 20);
                lb_characters.AutoSize = true;
                this.Controls.Add(lb_characters);
                lb_TotalText.Text = "Tổng cộng:";
                lb_TotalText.Font = new Font("Times New Roman", 15.0f, FontStyle.Bold);
                lb_TotalText.Location = new Point(210, lb_characters.Location.Y + 20);
                lb_TotalText.AutoSize = true;
                this.Controls.Add(lb_TotalText);
                lb_Total.Text = String.Format("{0:n0}", total);
                lb_Total.Font = new Font("Times New Roman", 15.0f, FontStyle.Bold);
                lb_Total.Location = new Point(310, lb_TotalText.Location.Y);
                lb_Total.AutoSize = true;
                this.Controls.Add(lb_Total);
                //Payment Button
                Button btn_Payment = new Button();
                btn_Payment.Text = "Thanh toán";
                btn_Payment.Font = new Font("Times New Roman", 15.0f, FontStyle.Bold);
                btn_Payment.Location = new Point(32, lb_TotalText.Location.Y - 10);
                btn_Payment.Size = new Size(150, 50);
                //btn_Payment.AutoSize = true;
                btn_Payment.BackColor = Color.Blue;
                this.Controls.Add(btn_Payment);

                //Handle Button Payment click

                btn_Payment.Click += (sender, e) =>
                 {
                     if (userlogin.POSITION == "QUANLY" || userlogin.POSITION == "THUNGAN")
                     {
                         paymentEvent(sender, e, billid, tableId);
                     }
                     else
                     {
                         MessageBox.Show("Bạn không có quyền này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 };
            }
        }
        private void paymentEvent(Object sender, EventArgs e, string billId, string tableId )
        {
            billDTO dto = new billDTO();
            dto.billId = billId;
            billBO bo = new billBO();
            int result = bo.paymentForBill(dto);
            if(result != -1)
            {
                tableDTO tabledto = new tableDTO();
                tabledto.tableID = tableId;
                tabledto.status = "FREE";
                tableBO tablebo = new tableBO();
                int result2 = -1;
                result2 = tablebo.setTableStatus(tabledto);
                if(result2 != -1)
                {
                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Table_Form form = new Table_Form();
                    form.userlogin = userlogin;
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
                MessageBox.Show("Thanh toán thất bại, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
