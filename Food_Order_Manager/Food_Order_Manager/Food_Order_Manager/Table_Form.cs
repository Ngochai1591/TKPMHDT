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

        }

        private void tableLoading()
        {
            tableDO table = new tableDO();
            DataSet tableList = table.getAllTable();
            if (tableList.Tables[0].Rows.Count > 0 && tableList.Tables.Count>0)
            {

            }
        }


    }
}
