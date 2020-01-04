using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Order_Manager.userControl
{
    public partial class BillInfo : UserControl
    {
        public BillInfo()
        {
            InitializeComponent();
        }
        private string foodname;
        public string FOODNAME
        {
            get
            {
                return foodname;
            }
            set
            {
                foodname = value;
            }
        }

        private int quantity;
        public int QUANTITY
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        private int foodprice;
        public int FOODPRICE
        {
            get
            {
                return foodprice;
            }
            set
            {
                foodprice = value;
            }
        }


        private void BillInfo_Load(object sender, EventArgs e)
        {
            setBillInfo();
        }
        private void setBillInfo()
        {
            lb_FoodName.Text = foodname;
            lb_FoodPrice.Text = String.Format("{0:n0}", foodprice);
            lb_Quantity.Text = quantity.ToString();
            lb_Total.Text = String.Format("{0:n0}", quantity * foodprice);
        }
    }
}
