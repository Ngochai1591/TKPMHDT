using Food_Order_Manager.BO;
using Food_Order_Manager.DTO;
using Food_Order_Manager.userControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Order_Manager
{
    public partial class Menu_Form : Form
    {
        public Menu_Form()
        {
            InitializeComponent();
        }
        //table id
        private string tableId;
        public string TABLEID
        {
            set
            {
                tableId = value;
            }
            get
            {
                return tableId;
            }
        }
        //table name
        private string tableName;
        public string TABLENAME
        {
            set
            {
                tableName = value;
            }
            get
            {
                return tableName;
            }
        }


        private void Menu_Form_Load(object sender, EventArgs e)
        {
            loadingMenu();
        }

        private void loadingMenu()
        {
            txt_TableName.Text = tableName;
            txt_Name.Text = Login_Form.NAME;
            loadingCategory();
        }

        private List<categoryDTO> CategoryList = new List<categoryDTO>();
        private void loadingCategory()
        {
            flp_Category.Controls.Clear();
            categoryBO bo = new categoryBO();
            DataSet result = bo.getAllCategory();
            for(int i =0;i<result.Tables[0].Rows.Count;i++)
            {
                System.Byte[] arr = (result.Tables[0].Rows[i][2]) as System.Byte[];
                CategoryList.Add(new categoryDTO { categoryId = result.Tables[0].Rows[i][0].ToString(), categoryName = result.Tables[0].Rows[i][1].ToString(), categoryPicture = arr });
                Category categoryUC = new Category();
                categoryUC.CATEGORYID = CategoryList[i].categoryId;
                categoryUC.CATEGORYNAME = CategoryList[i].categoryName;
                categoryUC.CATEGORYPICTURE = CategoryList[i].categoryPicture;

                
                flp_Category.Controls.Add(categoryUC);

                foreach(Control control in categoryUC.Controls)
                {
                    control.Click += (sender, e) =>
                    {
                        loadingFoodByCategoryId(sender, e, categoryUC.CATEGORYID);
                    };
                }
            }

            

        }
        private void loadingFoodByCategoryId(object sender, EventArgs e, string categoryId)
        {
            flp_Food.Controls.Clear();
            foodBO bo = new foodBO();
            foodDTO dto = new foodDTO();
            dto.categoryId = categoryId;
            DataSet result = bo.getFoodByCategoryId(dto);
            for(int i =0;i<result.Tables[0].Rows.Count;i++)
            {
                Food foodUC = new Food();
                foodUC.CATEGORYID = categoryId;
                foodUC.FOODID = result.Tables[0].Rows[i][0].ToString();
                foodUC.FOODNAME = result.Tables[0].Rows[i][1].ToString();
                System.Byte[] arr = (result.Tables[0].Rows[i][3]) as System.Byte[];
                foodUC.FOODPICTURE = arr;

                flp_Food.Controls.Add(foodUC);
            }
        }
        

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Table_Form table = new Table_Form();
            this.Hide();
            table.ShowDialog();
            this.Close();
        }
    }
}
