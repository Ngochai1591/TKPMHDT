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
    public partial class ChooseFood_Form : Form
    {
        //table name
        public string TABLENAME
        {
            set
            {
                tableName = value;
            }
        }

        private string tableName;


        public ChooseFood_Form()
        {
            InitializeComponent();
        }
    }
}
