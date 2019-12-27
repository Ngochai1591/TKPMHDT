using Food_Order_Manager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_Order_Manager.BO;

namespace Food_Order_Manager
{
    public partial class ManageEmploy_Form : Form
    {
        public ManageEmploy_Form()
        {
            InitializeComponent();
            btn_Exit.Enabled = true;
        }

        DataSet data = new DataSet();
        int f = 0;

       
        private void ManageEmploy_Form_Load(object sender, EventArgs e)
        {
            AccountBO list = new AccountBO();
            DataSet ds = list.ShowListNV();// lấy dữ liệu từ database đổ vào 1 table
           
                dgv_Thongtinnv.DataSource = ds.Tables[0];

            if (ds.Tables.Count > 0 && ds != null)
            {
                txt_UsernameNV.Text = dgv_Thongtinnv.CurrentRow.Cells["Username"].Value.ToString();
                txt_Name.Text = dgv_Thongtinnv.CurrentRow.Cells["Name"].Value.ToString();
                txt_Password.Text = dgv_Thongtinnv.CurrentRow.Cells["Password"].Value.ToString();
                txt_Address.Text = dgv_Thongtinnv.CurrentRow.Cells["Address"].Value.ToString();
                cmb_Sex.Text = dgv_Thongtinnv.CurrentRow.Cells["Sex"].Value.ToString();
                dt_DOB.Text = dgv_Thongtinnv.CurrentRow.Cells["DOB"].Value.ToString();
                cmb_Position.Text = dgv_Thongtinnv.CurrentRow.Cells["Position"].Value.ToString();
                txt_NumberPhone.Text = dgv_Thongtinnv.CurrentRow.Cells["NumberPhone"].Value.ToString();
            }
            else
            {
                txt_UsernameNV.Text = "";
                txt_Name.Text = "";
                txt_Password.Text = "";
                txt_Address.Text = "";
                cmb_Sex.Text = "";
                dt_DOB.Text = "";
                cmb_Position.Text = "";
                txt_NumberPhone.Text = "";
            }
            loadcbm();
            //Enable(true);
        }
        void rex()// hàm kiểm tra lỗi kí tự đặc biệt
        {
            Regex regex = new Regex("[0-9a-zA-Z]");
            if (!regex.IsMatch(txt_UsernameNV.Text.TrimEnd()))
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ ", "Lỗi");
                txt_UsernameNV.Clear();
                return;
            }   
            else if (!regex.IsMatch(txt_Name.Text.TrimEnd()))
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ ", "Lỗi");
                txt_Name.Clear();
                return;
            }
            else if (!regex.IsMatch(txt_Password.Text.TrimEnd()))
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ ", "Lỗi");
                txt_Password.Clear();
                return;
            }
            else if (!regex.IsMatch(txt_Address.Text.TrimEnd()))
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ ", "Lỗi");
                txt_Address.Clear();
                return;
            }
            else if (!regex.IsMatch(txt_NumberPhone.Text.TrimEnd()))
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ ", "Lỗi");
                txt_NumberPhone.Clear();
                return;
            }
        }
       
        void SaveData(AccountDTO nv)//lưu dữ liệu vào class AccountDTO
        {
            nv.Username = txt_UsernameNV.Text.Trim();
            nv.Name = txt_Name.Text.Trim();
            nv.Password = txt_Password.Text.Trim();
            nv.Address = txt_Address.Text.Trim();
            nv.Sex = cmb_Sex.Text.Trim();
            nv.DOB = dt_DOB.Text.Trim();
            nv.Position = cmb_Position.Text.Trim();
            nv.NumberPhone = txt_NumberPhone.Text.Trim();

            //nv.Matkhau = "";
        } // lưu dữ liệu vào class AccountDTO
        void loadcbm()//hiển thị combobox 
        {
            cmb_Sex.Items.Clear();
            cmb_Sex.Items.Add("Nam");
            cmb_Sex.Items.Add("Nữ");
            cmb_Sex.SelectedIndex = 0;

          

            var items = new List<ComboItemPosition> { new ComboItemPosition("QUANLY", "Quản lý"),
            new ComboItemPosition( "THUNGAN", "Thu Ngân"),
            new ComboItemPosition( "NHANVIEN", "Nhân viên")};

            this.cmb_Position.DataSource = items;
            this.cmb_Position.DisplayMember = "Value";
            this.cmb_Position.ValueMember = "Key";

            this.cmb_Position.SelectedValue = "QUANLY";
           

            dt_DOB.Text = DateTime.Now.ToString();

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            f = 0;
            Enable(true);// tắt button thêm,xóa,sửa và bật button lưu và các textbox
            clearData();
            loadcbm();
        }
        private void clearData()// clear dữ liệu trên các textbox
        {
            txt_UsernameNV.Text = "";
            txt_Name.Text = "";
            txt_Password.Text = "";
            txt_Address.Text = "";
            txt_NumberPhone.Text = "";
            dt_DOB.Value = DateTime.Now.Date;
            loadcbm();
        }
        void Enable(bool e)// tắt hoặc bật các control 
        {
            btn_Add.Enabled = !e;
            btn_Edit.Enabled = !e;
            btn_Delete.Enabled = !e;
            btn_Save.Enabled = e;
            btn_Cancel.Enabled = e;
            txt_UsernameNV.Enabled = e;
            txt_Name.Enabled = e;
            txt_Password.Enabled = e;
            txt_Address.Enabled = e;
            cmb_Sex.Enabled = e;
            dt_DOB.Enabled = e;
            cmb_Position.Enabled = e;
            txt_NumberPhone.Enabled = e;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ManageEmploy_Form_Load(sender, e);
                clearData();            // clear các controls 
                btn_Add.Enabled = true;
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = true;
                btn_Save.Enabled = false;
            }
            else
                return;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) // nếu chọn yes trong hợp thoại thì sẽ đóng ứng dụng
            {
                this.Close();
            }
            else
                return;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            AccountDTO nvdto = new AccountDTO();// khởi tạo 1 instance cho class AccountDTO
            rex();                             //kiểm tra lỗi của dữ liệu
            SaveData(nvdto);                   // lưu dữ liệu vào trong class AccountDTO
            if (f == 0)                         //nếu chọn button Thêm thì khối lệnh trong if được thực hine65
            {
                if (txt_UsernameNV.Text == "" || txt_Password.Text == "" || txt_Name.Text == "" || 
                    txt_Address.Text == "" || txt_NumberPhone.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    AccountDTO dto = new AccountDTO();
                    dto.Username = txt_UsernameNV.Text;
                    dto.Password = txt_Password.Text;
                    dto.Name = txt_Name.Text;
                    dto.Position = cmb_Position.SelectedValue.ToString();
                    dto.Sex = cmb_Sex.Text;
                    dto.DOB = dt_DOB.Text;
                    dto.Address = txt_Address.Text;
                    dto.NumberPhone = txt_NumberPhone.Text;

                    AccountBO bo = new AccountBO();
                    int result = bo.AddNV(dto);
                    if (result != -1)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ManageEmploy_Form_Load(sender, e);     //cập nhật lại cho màn hình hiển thị
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng thử lại");
                    }
                }
            }
            else// Ngược lại nếu chọn button Sửa thì khối lệnh update được thực hiện
            {
                if (txt_UsernameNV.Text == "" || txt_Password.Text == "" || txt_Name.Text == "" ||
                   txt_Address.Text == "" || txt_NumberPhone.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    AccountDTO dto = new AccountDTO();
                    AccountBO bo = new AccountBO();
                    dto.Username = txt_UsernameNV.Text;
                    dto.Password = txt_Password.Text;
                    dto.Name = txt_Name.Text;
                    dto.Position = cmb_Position.SelectedValue.ToString();
                    dto.Sex = cmb_Sex.Text;
                    dto.DOB = dt_DOB.Text;
                    dto.Address = txt_Address.Text;
                    dto.NumberPhone = txt_NumberPhone.Text;

                    int result = bo.UpdateNV(dto);
                    if (result != -1)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ManageEmploy_Form_Load(sender, e);     //cập nhật lại cho màn hình hiển thị
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng thử lại");
                    }
                }
            }
            ManageEmploy_Form_Load(sender, e);
            Enable(false);
        }

        private void dgv_Thongtinnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            f = 1; // cập nhật cờ bằng 1 
            Enable(true);
            loadcbm();
        }

        private void dgv_Thongtinnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_UsernameNV.Text = dgv_Thongtinnv.CurrentRow.Cells["Username"].Value.ToString();
            txt_Name.Text = dgv_Thongtinnv.CurrentRow.Cells["Name"].Value.ToString();
            txt_Password.Text = dgv_Thongtinnv.CurrentRow.Cells["Password"].Value.ToString();
            txt_Address.Text = dgv_Thongtinnv.CurrentRow.Cells["Address"].Value.ToString();
            cmb_Sex.Text = dgv_Thongtinnv.CurrentRow.Cells["Sex"].Value.ToString();
            dt_DOB.Text = dgv_Thongtinnv.CurrentRow.Cells["DOB"].Value.ToString();
            cmb_Position.Text = dgv_Thongtinnv.CurrentRow.Cells["Position"].Value.ToString();
            txt_NumberPhone.Text = dgv_Thongtinnv.CurrentRow.Cells["NumberPhone"].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                AccountBO del = new AccountBO();
                if (del.DeleteNV(txt_UsernameNV.Text) != -1) // xóa gọi tới hàm delNV của class NhanVienControls
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Nhớ Suy Nghĩ Kĩ Rồi Hãy Lựa Chọn ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ManageEmploy_Form_Load(sender, e);// hiển thị dữ liệu lên lại giao diện
        }

        private void cmb_Position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
public class ComboItemPosition
{
    public string Key { get; set; }
    public string Value { get; set; }
    public ComboItemPosition(string key, string value)
    {
        Key = key; Value = value;
    }
    public override string ToString()
    {
        return Value;
    }
}