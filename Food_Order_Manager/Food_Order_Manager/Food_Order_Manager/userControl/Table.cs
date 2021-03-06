﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Order_Manager
{
    public partial class Table : UserControl
    {
        public Table()
        {
            InitializeComponent();
        }

        //table ID
        private string tableID;
        public string TABLEID
        {
            set
            {
                tableID = value;
            }
            get
            {
                return tableID;
            }
        }

        //status

        private string status;

        public string STATUS
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
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
        //load function
        private void Table_Load(object sender, EventArgs e)
        {
            setTableInfo();
        }

        //set table infomation
        private void setTableInfo()
        {
            this.lb_tableName.Text = tableName;
            this.lb_tableName.Name = tableID;
            if(status == "USING")
            {
                lb_tableName.BackColor = Color.Red;
            }
        }

   
    }
}
