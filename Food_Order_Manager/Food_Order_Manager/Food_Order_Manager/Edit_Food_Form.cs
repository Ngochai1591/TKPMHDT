using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Order_Manager
{
    public partial class Edit_Food_Form : Form
    {
        public Edit_Food_Form()
        {
            InitializeComponent();
        }

        private void Edit_Food_Form_Load(object sender, EventArgs e)
        {
            loadingFood();
        }

        //private string getIdFromList(string name)
        //{
        //    string id = "";
        //    for (int i = 0; i < Category.Count(); i++)
        //    {
        //        if (Category[i].categoryName == name)
        //        {
        //            id = Category[i].categoryId;
        //            break;
        //        }
        //    }

        //    return id;
        //}

        private void loadingFood()
        {
            txt_FoodId.Text = Food_Form.foodId;
            txt_FoodName.Text = Food_Form.foodName;
            cb_CategoryName.Text = Food_Form.categoryName;
            System.Byte[] arr = Food_Form.foodPicture;
            MemoryStream stream = new MemoryStream(arr);
            Image img = Image.FromStream(stream);
            pb_FoodPicture.Image = img;
        }
    }
}
