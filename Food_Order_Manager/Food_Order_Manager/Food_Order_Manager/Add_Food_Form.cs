using Food_Order_Manager.BO;
using Food_Order_Manager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Order_Manager
{
    public partial class Add_Food_Form : Form
    {
        public Add_Food_Form()
        {
            InitializeComponent();
        }

        private List<categoryDTO> Category = new List<categoryDTO>();


        private void Add_Food_Form_Load(object sender, EventArgs e)
        {
            Loading_Form();

        }
        private int changingStringToInt(string text)
        {
            int number = 0;
            number = int.Parse(text.Replace(",", ""));
            return number;
        }
        private void Loading_Form()
        {
            foodBO bo = new foodBO();
            DataSet result = bo.getAllCategory();
            if (result.Tables[0].Rows.Count > 0 && result.Tables.Count > 0)
            {
                for (int i = 0; i < result.Tables[0].Rows.Count; i++)
                {
                    //cb_CategoryName.Items.Add(result.Tables[0].Rows[i][1].ToString());
                    Category.Add(new categoryDTO { categoryId = result.Tables[0].Rows[i][0].ToString(),
                        categoryName = result.Tables[0].Rows[i][1].ToString()
                    });
                    cb_CategoryName.Items.Add(Category[i].categoryName);
                }

            }
        }

        private Boolean checkingBeforeSubmit()
        {
            if (string.IsNullOrEmpty(mtxt_FoodPrice.Text) || string.IsNullOrEmpty(txt_FoodName.Text) || string.IsNullOrEmpty(txt_FoodId.Text) ||string.IsNullOrEmpty(cb_CategoryName.Text) || pb_FoodPicture.Image == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private string getIdFromList(string name)
        {
            string id = "";
            for(int i=0;i<Category.Count();i++)
            {
                if(Category[i].categoryName == name)
                {
                    id = Category[i].categoryId;
                    break;
                }
            }

            return id;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkingBeforeSubmit() == true)
            {
                foodDTO dto = new foodDTO();
                dto.foodId = txt_FoodId.Text;
                dto.foodName = txt_FoodName.Text;
                dto.categoryId = getIdFromList(cb_CategoryName.Text);
                dto.foodPrice = changingStringToInt(mtxt_FoodPrice.Text);
                //image processing
                Image img = Image.FromFile(fileFoodName);
                MemoryStream stream = new MemoryStream();
                img.Save(stream, ImageFormat.Jpeg);
                stream.Seek(0, SeekOrigin.Begin);
                byte[] imgByte = System.IO.File.ReadAllBytes(fileFoodName);
                int sizeImg = imgByte.Length;
                stream.Read(imgByte, 0, sizeImg);
                //done
                dto.foodPicture = imgByte;
                //
                foodBO bo = new foodBO();
                int result = bo.addFood(dto);
                if (result == -1)
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string fileFoodName = "";

        private void Reset()
        {
            txt_FoodId.Text = "";
            txt_FoodName.Text = "";
            cb_CategoryName.Text = "";
            mtxt_FoodPrice.Text = "";
            pb_FoodPicture.Image = null;
        }

        private void btn_ChoosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                fileFoodName = open.FileName;
                if (string.IsNullOrEmpty(fileFoodName))
                {
                    return;
                }
                else
                {
                    Image img = Image.FromFile(fileFoodName);
                    pb_FoodPicture.Image = img;
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
