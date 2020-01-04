using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_Order_Manager.BO;
using Food_Order_Manager.DTO;

namespace Food_Order_Manager
{
    public partial class Table_Form : Form
    {
        public Table_Form()
        {
            InitializeComponent();
        }

        private void Table_Form_Load(object sender, EventArgs e)
        {
            userLoading();
            tableLoading();
        }

        private void userLoading()
        {
            lb_Name.Text =  Login_Form.NAME; 
        }
        private void tableLoading()
        {
            tableBO table = new tableBO();
            DataSet tableList = table.getAllTable();
            if (tableList.Tables[0].Rows.Count > 0 && tableList.Tables.Count>0)
            {
                for(int i =0;i<tableList.Tables[0].Rows.Count;i++)
                {
                    Table tableUC = new Table();
                    tableUC.TABLEID = tableList.Tables[0].Rows[i][1].ToString().Trim();
                    tableUC.TABLENAME = tableList.Tables[0].Rows[i][0].ToString().Trim();
                    tableUC.STATUS = tableList.Tables[0].Rows[i][2].ToString().Trim();
                    flp_tableList.Controls.Add(tableUC);

                    foreach(Control con in tableUC.Controls)
                    {
                        con.Click += (sender, e) =>
                        {
                            openMenuForm(sender, e, tableUC.TABLEID, tableUC.TABLENAME);
                        };
                    }
                }
            }
        }

        private void openMenuForm(object sender, EventArgs e, string tableId, string tableName)
        {
            Menu_Form menu = new Menu_Form();
            menu.TABLEID = tableId;
            menu.TABLENAME = tableName;
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Login_Form.USERNAME = "";
            Login_Form.POSITION = "";
            Login_Form.NAME = "";
            Login_Form form = new Login_Form();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
