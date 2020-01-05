using Food_Order_Manager.BO;
using Food_Order_Manager.DTO;
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
    public partial class Category_Form : Form
    {
        public static string categoryId = "";
        public static string categoryName = "";
        public static byte[] categoryPicture = null;

        public Category_Form()
        {
            InitializeComponent();
        }

        private void Category_Form_Load(object sender, EventArgs e)
        {
            loadingCategory();
        }

        private void loadingCategory()
        {
            categoryBO bo = new categoryBO();
            DataSet result = bo.getAllCategory();
            dgv_ShowUp.DataSource = result.Tables[0];
            lb_CategoryId.Text = "";
            lb_CategoryName.Text = "";
            pb_CategoryPicture.Image = null;
;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add_Category_Form add = new Add_Category_Form();
            add.ShowDialog();
            loadingCategory();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_ShowUp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_CategoryId.Text = dgv_ShowUp.CurrentRow.Cells["CategoryId"].Value.ToString();
            categoryId = lb_CategoryId.Text;
            lb_CategoryName.Text = dgv_ShowUp.CurrentRow.Cells["CategoryName"].Value.ToString();
            categoryName = lb_CategoryName.Text;
            System.Byte[] arr = (dgv_ShowUp.CurrentRow.Cells["CategoryPicture"].Value) as System.Byte [];
            categoryPicture = arr;
            MemoryStream stream = new MemoryStream(arr);
            Image img = Image.FromStream(stream);
            pb_CategoryPicture.Image = img;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if(checkingBeforeClickEditOrDelete() == true)
            {
                Edit_Category_Form edit = new Edit_Category_Form();
                edit.ShowDialog();
                loadingCategory();
                lb_CategoryId.Text = dgv_ShowUp.CurrentRow.Cells["CategoryId"].Value.ToString();
                categoryId = lb_CategoryId.Text;
                lb_CategoryName.Text = dgv_ShowUp.CurrentRow.Cells["CategoryName"].Value.ToString();
                categoryName = lb_CategoryName.Text;
                System.Byte[] arr = (dgv_ShowUp.CurrentRow.Cells["CategoryPicture"].Value) as System.Byte[];
                categoryPicture = arr;
                MemoryStream stream = new MemoryStream(arr);
                Image img = Image.FromStream(stream);
                pb_CategoryPicture.Image = img;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục để thực hiện sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        private Boolean checkingBeforeClickEditOrDelete()
        {
            if(string.IsNullOrEmpty(lb_CategoryId.Text) || string.IsNullOrEmpty(lb_CategoryName.Text) || pb_CategoryPicture.Image == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(checkingBeforeClickEditOrDelete() == true)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa danh mục " + lb_CategoryName.Text + " này không ?, Việc này không thể khôi phục lại dữ liệu, Bạn chắc chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    categoryDTO dto = new categoryDTO();
                    dto.categoryId = lb_CategoryId.Text;
                    categoryBO bo = new categoryBO();
                    int result1 = bo.deleteCategory(dto);
                    if(result1 != -1)
                    {
                        MessageBox.Show("Đã xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadingCategory();

                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi trong quá trình xóa, vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trước khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
