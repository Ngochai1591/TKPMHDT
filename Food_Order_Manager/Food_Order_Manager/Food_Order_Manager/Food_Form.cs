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
    public partial class Food_Form : Form
    {
        public static string foodId = "";
        public static string foodName = "";
        public static string categoryName = "";
        public static byte[] foodPicture = null;
        public Food_Form()
        {
            InitializeComponent();
        }

        private void Food_Form_Load(object sender, EventArgs e)
        {
            Loading_Food();
        }
        public void Loading_Food()
        {
            foodBO bo = new foodBO();
            DataSet result = bo.getAllFood();
            dgv_ShowUp.DataSource = result.Tables[0];
            lb_FoodId.Text = "";
            lb_FoodName.Text = "";
            lb_CategoryName.Text = "";
            pb_FoodPicture.Image = null;
        }

        private Boolean checkingBeforeClickEditOrDelete()
        {
            if (string.IsNullOrEmpty(lb_CategoryName.Text) || string.IsNullOrEmpty(lb_FoodName.Text)|| 
                string.IsNullOrEmpty(lb_FoodId.Text) || pb_FoodPicture.Image == null)
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
            if (checkingBeforeClickEditOrDelete() == true)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa danh mục " + lb_CategoryName.Text + " này không ?, Việc này không thể khôi phục lại dữ liệu, Bạn chắc chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    foodDTO dto = new foodDTO();
                    dto.foodId = lb_FoodId.Text;
                    foodBO bo = new foodBO();
                    int result1 = bo.deleteFood(dto);
                    if (result1 != -1)
                    {
                        MessageBox.Show("Đã xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Loading_Food();

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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add_Food_Form add = new Add_Food_Form();
            add.ShowDialog();
            Loading_Food();
        }

        private void dgv_ShowUp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_FoodId.Text = dgv_ShowUp.CurrentRow.Cells["FoodId"].Value.ToString();
            foodId = lb_FoodId.Text;
            lb_FoodName.Text = dgv_ShowUp.CurrentRow.Cells["FoodName"].Value.ToString();
            foodName = lb_FoodName.Text;
            //lb_CategoryName.Text = dgv_ShowUp.CurrentRow.Cells["CategoryName"].Value.ToString();
          
            categoryDTO dto = new categoryDTO();
            dto.categoryId = dgv_ShowUp.CurrentRow.Cells["CategoryId"].Value.ToString();

            foodBO bo = new foodBO();
            DataSet result = bo.getCategoryNameByID(dto);
            lb_CategoryName.Text = result.Tables[0].Rows[0][0].ToString();
            categoryName = lb_CategoryName.Text;
            System.Byte[] arr = (dgv_ShowUp.CurrentRow.Cells["FoodPicture"].Value) as System.Byte[];
            foodPicture = arr;
            MemoryStream stream = new MemoryStream(arr);
            Image img = Image.FromStream(stream);
            pb_FoodPicture.Image = img;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (checkingBeforeClickEditOrDelete() == true)
            {
                Edit_Food_Form edit = new Edit_Food_Form();
                edit.ShowDialog();
                Loading_Food();
                lb_FoodId.Text = dgv_ShowUp.CurrentRow.Cells["FoodId"].Value.ToString();
                foodId = lb_FoodId.Text;
                lb_FoodName.Text = dgv_ShowUp.CurrentRow.Cells["FoodName"].Value.ToString();
                foodName = lb_FoodName.Text;

                string categoryId = dgv_ShowUp.CurrentRow.Cells["CategoryId"].Value.ToString();

                foodBO bo = new foodBO();
                categoryDTO dto = new categoryDTO();
                dto.categoryId = categoryId;

                DataSet result = bo.getCategoryNameByID(dto);

                lb_CategoryName.Text = result.Tables[0].Rows[0][0].ToString();

                System.Byte[] arr = (dgv_ShowUp.CurrentRow.Cells["FoodPicture"].Value) as System.Byte[];
                foodPicture = arr;
                MemoryStream stream = new MemoryStream(arr);
                Image img = Image.FromStream(stream);
                pb_FoodPicture.Image = img;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục để thực hiện sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
