using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_Order_Manager.SingletonPattern;

namespace Food_Order_Manager
{
    public partial class Manage_Form : Form
    {
        public UserLoginSingleton userlogin;

        public Manage_Form()
        {
            InitializeComponent();
        }

        private void Manage_Form_Load(object sender, EventArgs e)
        {

        }
        

        private void pic_ManageEmployee_Click(object sender, EventArgs e)
        {
            ManageEmploy_Form manageemployee = new ManageEmploy_Form();
            manageemployee.ShowDialog();
            manageemployee.Close();
        }

        private void pic_ManageFood_Click(object sender, EventArgs e)
        {
            Food_Form food = new Food_Form();
            food.ShowDialog();
            food.Close();
        }

        private void pic_ManageCategory_Click(object sender, EventArgs e)
        {
            Category_Form category = new Category_Form();

            category.ShowDialog();
            category.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
