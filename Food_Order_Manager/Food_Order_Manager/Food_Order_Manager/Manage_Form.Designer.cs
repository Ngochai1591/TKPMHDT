namespace Food_Order_Manager
{
    partial class Manage_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_ManageFood = new System.Windows.Forms.PictureBox();
            this.pic_ManageCategory = new System.Windows.Forms.PictureBox();
            this.pic_ManageEmployee = new System.Windows.Forms.PictureBox();
            this.pn_ManageEmployee = new System.Windows.Forms.Panel();
            this.pn_ManageFood = new System.Windows.Forms.Panel();
            this.pn_ManageCategory = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ManageFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ManageCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ManageEmployee)).BeginInit();
            this.pn_ManageEmployee.SuspendLayout();
            this.pn_ManageFood.SuspendLayout();
            this.pn_ManageCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quản lý Đồ ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quản lý Danh mục";
            // 
            // pic_ManageFood
            // 
            this.pic_ManageFood.Image = ((System.Drawing.Image)(resources.GetObject("pic_ManageFood.Image")));
            this.pic_ManageFood.Location = new System.Drawing.Point(13, 83);
            this.pic_ManageFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_ManageFood.Name = "pic_ManageFood";
            this.pic_ManageFood.Size = new System.Drawing.Size(325, 251);
            this.pic_ManageFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ManageFood.TabIndex = 38;
            this.pic_ManageFood.TabStop = false;
            this.pic_ManageFood.Click += new System.EventHandler(this.pic_ManageFood_Click);
            // 
            // pic_ManageCategory
            // 
            this.pic_ManageCategory.Image = ((System.Drawing.Image)(resources.GetObject("pic_ManageCategory.Image")));
            this.pic_ManageCategory.Location = new System.Drawing.Point(25, 83);
            this.pic_ManageCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_ManageCategory.Name = "pic_ManageCategory";
            this.pic_ManageCategory.Size = new System.Drawing.Size(325, 251);
            this.pic_ManageCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ManageCategory.TabIndex = 39;
            this.pic_ManageCategory.TabStop = false;
            this.pic_ManageCategory.Click += new System.EventHandler(this.pic_ManageCategory_Click);
            // 
            // pic_ManageEmployee
            // 
            this.pic_ManageEmployee.Image = ((System.Drawing.Image)(resources.GetObject("pic_ManageEmployee.Image")));
            this.pic_ManageEmployee.Location = new System.Drawing.Point(8, 88);
            this.pic_ManageEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_ManageEmployee.Name = "pic_ManageEmployee";
            this.pic_ManageEmployee.Size = new System.Drawing.Size(325, 251);
            this.pic_ManageEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ManageEmployee.TabIndex = 40;
            this.pic_ManageEmployee.TabStop = false;
            this.pic_ManageEmployee.Click += new System.EventHandler(this.pic_ManageEmployee_Click);
            // 
            // pn_ManageEmployee
            // 
            this.pn_ManageEmployee.Controls.Add(this.pic_ManageEmployee);
            this.pn_ManageEmployee.Controls.Add(this.label1);
            this.pn_ManageEmployee.Location = new System.Drawing.Point(36, 118);
            this.pn_ManageEmployee.Name = "pn_ManageEmployee";
            this.pn_ManageEmployee.Size = new System.Drawing.Size(369, 373);
            this.pn_ManageEmployee.TabIndex = 41;
            // 
            // pn_ManageFood
            // 
            this.pn_ManageFood.Controls.Add(this.pic_ManageFood);
            this.pn_ManageFood.Controls.Add(this.label2);
            this.pn_ManageFood.Location = new System.Drawing.Point(412, 118);
            this.pn_ManageFood.Name = "pn_ManageFood";
            this.pn_ManageFood.Size = new System.Drawing.Size(369, 373);
            this.pn_ManageFood.TabIndex = 42;
            // 
            // pn_ManageCategory
            // 
            this.pn_ManageCategory.Controls.Add(this.label3);
            this.pn_ManageCategory.Controls.Add(this.pic_ManageCategory);
            this.pn_ManageCategory.Location = new System.Drawing.Point(787, 118);
            this.pn_ManageCategory.Name = "pn_ManageCategory";
            this.pn_ManageCategory.Size = new System.Drawing.Size(369, 373);
            this.pn_ManageCategory.TabIndex = 43;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Back.Location = new System.Drawing.Point(36, 33);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(164, 66);
            this.btn_Back.TabIndex = 44;
            this.btn_Back.Text = "Trở về";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Manage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1192, 557);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.pn_ManageCategory);
            this.Controls.Add(this.pn_ManageFood);
            this.Controls.Add(this.pn_ManageEmployee);
            this.Name = "Manage_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Form";
            this.Load += new System.EventHandler(this.Manage_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ManageFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ManageCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ManageEmployee)).EndInit();
            this.pn_ManageEmployee.ResumeLayout(false);
            this.pn_ManageEmployee.PerformLayout();
            this.pn_ManageFood.ResumeLayout(false);
            this.pn_ManageFood.PerformLayout();
            this.pn_ManageCategory.ResumeLayout(false);
            this.pn_ManageCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic_ManageFood;
        private System.Windows.Forms.PictureBox pic_ManageCategory;
        private System.Windows.Forms.PictureBox pic_ManageEmployee;
        private System.Windows.Forms.Panel pn_ManageEmployee;
        private System.Windows.Forms.Panel pn_ManageFood;
        private System.Windows.Forms.Panel pn_ManageCategory;
        private System.Windows.Forms.Button btn_Back;
    }
}