using Food_Order_Manager.BO;
using Food_Order_Manager.DTO;
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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        public static string USERNAME = "";
        public static string POSITION = "";
        public static string NAME = "";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text== "" || txtPassWord.Text=="")
            {
                MessageBox.Show("Vui long nhap thong tin","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            else
            {
                AccountDTO dto = new AccountDTO();
                dto.Username = txtUserName.Text;
                dto.Password = txtPassWord.Text;
                AccountBO bo = new AccountBO();
                DataSet dataSet = bo.SignIn(dto);
                if(dataSet.Tables[0].Rows.Count>0 && dataSet.Tables.Count>0)
                {
                    USERNAME = dataSet.Tables[0].Rows[0][0].ToString().Trim();
                    NAME = dataSet.Tables[0].Rows[0][2].ToString().Trim();
                    POSITION = dataSet.Tables[0].Rows[0][3].ToString().Trim();
                    Table_Form table = new Table_Form();
                    this.Hide();
                    table.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register_Form f = new Register_Form();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
