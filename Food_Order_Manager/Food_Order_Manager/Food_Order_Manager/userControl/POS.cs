using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_Order_Manager.SingletonPattern;

namespace Food_Order_Manager.userControl
{
    public partial class POS : UserControl
    {
        public POS()
        {
            InitializeComponent();
        }
        public UserLoginSingleton userlogin;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //get userlogin position from table form to user control when click
            if (userlogin.POSITION == "QUANLY")
            {
                Manage_Form manage = new Manage_Form();
                manage.userlogin = userlogin;
                manage.ShowDialog();
                manage.Close();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void POS_Load(object sender, EventArgs e)
        {

        }
    }
}
