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
    public partial class Add_Category_Form : Form
    {
        private string fileName;
        public Add_Category_Form()
        {
            InitializeComponent();
        }

        private void Add_Category_Form_Load(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            txt_CategoryId.Text = "";
            txt_CategoryName.Text = "";
            pb_CategoryPicture.Image = null;
            
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_ChoosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                fileName = open.FileName;
                if(string.IsNullOrEmpty(fileName))
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(checkingBeforeSubmit()== true)
            {
                categoryDTO dto = new categoryDTO();
                dto.categoryId = txt_CategoryId.Text;
                dto.categoryName = txt_CategoryName.Text;
                //image processing
                Image img = Image.FromFile(fileName);
                MemoryStream stream = new MemoryStream();
                img.Save(stream, ImageFormat.Jpeg);
                stream.Seek(0, SeekOrigin.Begin);
                byte[] imgByte = System.IO.File.ReadAllBytes(fileName);
                int sizeImg = imgByte.Length;
                stream.Read(imgByte, 0, sizeImg);
                //done
                dto.categoryPicture = imgByte;
                //
                categoryBO bo = new categoryBO();
                int result = bo.addCategory(dto);
                if(result == -1)
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

        private Boolean checkingBeforeSubmit()
        {
            if(string.IsNullOrEmpty(txt_CategoryName.Text) || string.IsNullOrEmpty(txt_CategoryId.Text) || pb_CategoryPicture.Image == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_CategoryPicture_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_CategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CategoryId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
