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
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }

        private void lbAppName_Click(object sender, EventArgs e)
        {

        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtName.Text == "" || txtPosition.Text == "" || txtPassword.Text == "" || txtPassword2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AccountDTO dto = new AccountDTO();
                dto.Username = txtUsername.Text;
                dto.Password = txtPassword.Text;
                dto.Password = txtPassword2.Text;
                dto.Name = txtName.Text;
                dto.Position = txtPosition.Text;
                AccountBO bo = new AccountBO();
                int result = bo.SignUp(dto);
                if(result!= -1)
                {
                    MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login_Form f = new Login_Form();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng thử lại");
                }
            }
        }
    }
}
