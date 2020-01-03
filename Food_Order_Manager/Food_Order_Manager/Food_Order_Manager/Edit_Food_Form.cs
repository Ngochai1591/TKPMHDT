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
        private List<categoryDTO> Category = new List<categoryDTO>();
        private void loadingFood()
        {
            foodBO bo = new foodBO();
            DataSet result = bo.getAllCategory();
            for(int i=0;i<result.Tables[0].Rows.Count;i++)
            {
                Category.Add(new categoryDTO { categoryId = result.Tables[0].Rows[i][0].ToString() , categoryName = result.Tables[0].Rows[i][1].ToString()});
                cb_CategoryName.Items.Add(Category[i].categoryName);
            }
            txt_FoodId.Text = Food_Form.foodId;
            txt_FoodName.Text = Food_Form.foodName;
            cb_CategoryName.Text = Food_Form.categoryName;
            System.Byte[] arr = Food_Form.foodPicture;
            MemoryStream stream = new MemoryStream(arr);
            Image img = Image.FromStream(stream);
            pb_FoodPicture.Image = img;
        }

        private Boolean checkingBeforeEdit()
        {
            if (string.IsNullOrEmpty(txt_FoodId.Text) || string.IsNullOrEmpty(txt_FoodName.Text) || string.IsNullOrEmpty(cb_CategoryName.Text) || pb_FoodPicture.Image == null)
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
            for (int i = 0; i < Category.Count(); i++)
            {
                if (Category[i].categoryName == name)
                {
                    id = Category[i].categoryId;
                    break;
                }
            }

            return id;
        }
        private string fileFoodName = "";
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(checkingBeforeEdit() == true)
            {
                foodDTO dto = new foodDTO();
                dto.foodId = txt_FoodId.Text;
                dto.foodName = txt_FoodName.Text;
                dto.categoryId = getIdFromList(cb_CategoryName.Text);
                if(fileFoodName == "")
                {
                    System.Byte[] arr = Food_Form.foodPicture;
                    dto.foodPicture = arr;
                }
                else
                {
                    Image img = Image.FromFile(fileFoodName);
                    MemoryStream stream = new MemoryStream();
                    img.Save(stream, ImageFormat.Jpeg);
                    stream.Seek(0, SeekOrigin.Begin);
                    byte[] imgByte = System.IO.File.ReadAllBytes(fileFoodName);
                    int sizeImg = imgByte.Length;
                    stream.Read(imgByte, 0, sizeImg);
                    //done
                    dto.foodPicture = imgByte;
                }

                foodBO bo = new foodBO();
                int result = bo.editFood(dto);
                if (result == -1)
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            loadingFood();
            fileFoodName = "";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
