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
    public partial class Edit_Category_Form : Form
    {
        private string fileName = "";
        public Edit_Category_Form()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Category_Form_Load(object sender, EventArgs e)
        {
            loadingCategory();
        }
        private void loadingCategory()
        {
            txt_CategoryId.Text = Category_Form.categoryId;
            txt_CategoryName.Text = Category_Form.categoryName;
            System.Byte[] arr = Category_Form.categoryPicture;
            MemoryStream stream = new MemoryStream(arr);
            Image img = Image.FromStream(stream);
            pb_CategoryPicture.Image = img;
        }
        private Boolean checkingBeforeEdit()
        {
            if(string.IsNullOrEmpty(txt_CategoryId.Text) || string.IsNullOrEmpty(txt_CategoryName.Text) || pb_CategoryPicture.Image == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            loadingCategory();
            fileName = "";

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkingBeforeEdit() == true)
            {
                categoryDTO dto = new categoryDTO();
                dto.categoryId = txt_CategoryId.Text;
                dto.categoryName = txt_CategoryName.Text;
                //image processing
                if(fileName == "")
                {
                    System.Byte[] arr = Category_Form.categoryPicture;
                    dto.categoryPicture = arr;
                }
                else
                {
                    Image img = Image.FromFile(fileName);
                    MemoryStream stream = new MemoryStream();
                    img.Save(stream, ImageFormat.Jpeg);
                    stream.Seek(0, SeekOrigin.Begin);
                    byte[] imgByte = System.IO.File.ReadAllBytes(fileName);
                    int sizeImg = imgByte.Length;
                    stream.Read(imgByte, 0, sizeImg);
                    //done
                    dto.categoryPicture = imgByte;
                }
               

                categoryBO bo = new categoryBO();
                int result = bo.editCategory(dto);
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
                fileName = open.FileName;
                if (string.IsNullOrEmpty(fileName))
                {
                    return;
                }
                else
                {
                    Image img = Image.FromFile(fileName);
                    pb_CategoryPicture.Image = img;
                }
            }
        }
    }
}
