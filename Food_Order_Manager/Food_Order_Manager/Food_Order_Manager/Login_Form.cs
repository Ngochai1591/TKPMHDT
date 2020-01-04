using Food_Order_Manager.BO;
using Food_Order_Manager.DTO;
using Food_Order_Manager.SingletonPattern;
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
                UserLoginSingleton userlogin = TaiKhoanDTOSingleton.SignIn(txtUserName.Text, txtPassWord.Text);
                if (userlogin != null)
                {
                    Table_Form table = new Table_Form();
                    table.userlogin = userlogin;
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
