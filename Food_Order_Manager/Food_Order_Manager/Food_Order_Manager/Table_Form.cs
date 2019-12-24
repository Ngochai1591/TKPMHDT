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
                    tableUC.TABLEID = tableList.Tables[0].Rows[i][1].ToString();
                    tableUC.TABLENAME = tableList.Tables[0].Rows[i][0].ToString();
                    flp_tableList.Controls.Add(tableUC);

                    tableUC.Click += (sender, args) =>
                     {

                     };
                }
            }
        }


    }
}
