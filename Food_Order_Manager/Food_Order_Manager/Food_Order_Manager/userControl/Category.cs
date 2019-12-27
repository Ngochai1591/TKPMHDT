using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Food_Order_Manager.userControl
{
    public partial class Category : UserControl
    {
        private string categoryId;
        private string categoryName;
        private byte[] categoryPicture;

        public string CATEGORYID
        {
            get
            {
                return categoryId;
            }
            set
            {
                categoryId = value;
            }
        }

        public string CATEGORYNAME
        {
            get
            {
                return categoryName;
            }
            set
            {
                categoryName = value;
            }
        }

        public byte [] CATEGORYPICTURE
        {
            get
            {
                return categoryPicture;
            }
            set
            {
                categoryPicture = value;
            }
        }
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            setCategory();
        }
        private void setCategory()
        {
            System.Byte[] arr = categoryPicture;
            MemoryStream stream = new MemoryStream(arr);
            Image img = Image.FromStream(stream);
            pb_CategoryPicture.Image = img;
            this.lb_CategoryName.Text = categoryName;
            int middle = (Width / 2) - (lb_CategoryName.Width / 2);
            Point labelPoint = new Point(middle, 100);
            this.lb_CategoryName.Location = labelPoint;
        }
    }
}
