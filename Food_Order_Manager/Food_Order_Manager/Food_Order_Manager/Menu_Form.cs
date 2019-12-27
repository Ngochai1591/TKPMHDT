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


        private void Menu_Form_Load(object sender, EventArgs e)
        {
            loadingMenu();
        }

        private void loadingMenu()
        {
            txt_TableName.Text = tableName;
            txt_Name.Text = Login_Form.NAME;
            loadingFood();
        }

        private void loadingFood()
        {

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
    }
}
