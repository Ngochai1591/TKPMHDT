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
    public partial class Food : UserControl
    {
        public Food()
        {
            InitializeComponent();
        }
        private string foodId;
        private string foodName;
        private string categoryId;
        private byte[] foodPicture;

        private int foodprice;
        public int FOODPRICE
        {
            get
            {
                return foodprice;
            }
            set
            {
                foodprice = value;
            }
        }
        public string FOODID
        {
            get
            {
                return foodId;
            }
            set
            {
                foodId = value;
            }
        }

        public string FOODNAME
        {
            get
            {
                return foodName;
            }
            set
            {
                foodName = value;
            }
        }

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

        public byte [] FOODPICTURE
        {
            get
            {
                return foodPicture;
            }
            set
            {
                foodPicture = value;
            }
        }


        private void Food_Load(object sender, EventArgs e)
        {
            setFood();
        }
        private void setFood()
        {
            lb_FoodName.Text = foodName;
            int middle = (Width / 2) - (lb_FoodName.Width / 2);
            Point labelPoint = new Point(middle, 100);
            this.lb_FoodName.Location = labelPoint;
            System.Byte[] arr = foodPicture;
            MemoryStream stream = new MemoryStream(arr);
            Image img = Image.FromStream(stream);
            pb_FoodPicture.Image = img;
           
        }
    }
}
