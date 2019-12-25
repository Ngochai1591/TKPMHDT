namespace Food_Order_Manager
{
    partial class Category_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ShowUp = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_CategoryId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_CategoryName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pb_CategoryPicture = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CategoryPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý Danh mục món ăn";
            // 
            // dgv_ShowUp
            // 
            this.dgv_ShowUp.AllowUserToAddRows = false;
            this.dgv_ShowUp.AllowUserToDeleteRows = false;
            this.dgv_ShowUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ShowUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ShowUp.Location = new System.Drawing.Point(24, 60);
            this.dgv_ShowUp.Name = "dgv_ShowUp";
            this.dgv_ShowUp.ReadOnly = true;
            this.dgv_ShowUp.Size = new System.Drawing.Size(591, 272);
            this.dgv_ShowUp.TabIndex = 1;
            this.dgv_ShowUp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ShowUp_CellClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(637, 60);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(125, 49);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(637, 128);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(125, 49);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(637, 203);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(125, 49);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh mục món ăn đã chọn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã danh mục";
            // 
            // lb_CategoryId
            // 
            this.lb_CategoryId.AutoSize = true;
            this.lb_CategoryId.Location = new System.Drawing.Point(226, 424);
            this.lb_CategoryId.Name = "lb_CategoryId";
            this.lb_CategoryId.Size = new System.Drawing.Size(0, 25);
            this.lb_CategoryId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên danh mục:";
            // 
            // lb_CategoryName
            // 
            this.lb_CategoryName.AutoSize = true;
            this.lb_CategoryName.Location = new System.Drawing.Point(226, 495);
            this.lb_CategoryName.Name = "lb_CategoryName";
            this.lb_CategoryName.Size = new System.Drawing.Size(0, 25);
            this.lb_CategoryName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hình ảnh";
            // 
            // pb_CategoryPicture
            // 
            this.pb_CategoryPicture.Location = new System.Drawing.Point(561, 382);
            this.pb_CategoryPicture.Name = "pb_CategoryPicture";
            this.pb_CategoryPicture.Size = new System.Drawing.Size(201, 200);
            this.pb_CategoryPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_CategoryPicture.TabIndex = 11;
            this.pb_CategoryPicture.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(637, 283);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(125, 49);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Thoát";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Category_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 594);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.pb_CategoryPicture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_CategoryName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_CategoryId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_ShowUp);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Category_Form";
            this.Text = "Category_Form";
            this.Load += new System.EventHandler(this.Category_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CategoryPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ShowUp;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_CategoryId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_CategoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pb_CategoryPicture;
        private System.Windows.Forms.Button btn_Cancel;
    }
}