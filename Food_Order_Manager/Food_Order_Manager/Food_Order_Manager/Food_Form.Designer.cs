namespace Food_Order_Manager
{
    partial class Food_Form
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.pb_FoodPicture = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_FoodName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_FoodId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_ShowUp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_CategoryName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_FoodPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FoodPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowUp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(600, 232);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(116, 40);
            this.btn_Cancel.TabIndex = 38;
            this.btn_Cancel.Text = "Thoát";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // pb_FoodPicture
            // 
            this.pb_FoodPicture.Location = new System.Drawing.Point(523, 302);
            this.pb_FoodPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pb_FoodPicture.Name = "pb_FoodPicture";
            this.pb_FoodPicture.Size = new System.Drawing.Size(208, 204);
            this.pb_FoodPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_FoodPicture.TabIndex = 37;
            this.pb_FoodPicture.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Hình ảnh";
            // 
            // lb_FoodName
            // 
            this.lb_FoodName.AutoSize = true;
            this.lb_FoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FoodName.Location = new System.Drawing.Point(211, 393);
            this.lb_FoodName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_FoodName.Name = "lb_FoodName";
            this.lb_FoodName.Size = new System.Drawing.Size(0, 25);
            this.lb_FoodName.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 393);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tên món ăn:";
            // 
            // lb_FoodId
            // 
            this.lb_FoodId.AutoSize = true;
            this.lb_FoodId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FoodId.Location = new System.Drawing.Point(211, 339);
            this.lb_FoodId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_FoodId.Name = "lb_FoodId";
            this.lb_FoodId.Size = new System.Drawing.Size(0, 25);
            this.lb_FoodId.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mã món ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 31);
            this.label2.TabIndex = 31;
            this.label2.Text = "Món ăn đã chọn";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(600, 167);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(116, 40);
            this.btn_Delete.TabIndex = 30;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(600, 106);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(116, 40);
            this.btn_Edit.TabIndex = 29;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(600, 50);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(116, 40);
            this.btn_Add.TabIndex = 28;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_ShowUp
            // 
            this.dgv_ShowUp.AllowUserToAddRows = false;
            this.dgv_ShowUp.AllowUserToDeleteRows = false;
            this.dgv_ShowUp.AllowUserToResizeColumns = false;
            this.dgv_ShowUp.AllowUserToResizeRows = false;
            this.dgv_ShowUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ShowUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ShowUp.Location = new System.Drawing.Point(14, 50);
            this.dgv_ShowUp.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_ShowUp.Name = "dgv_ShowUp";
            this.dgv_ShowUp.ReadOnly = true;
            this.dgv_ShowUp.Size = new System.Drawing.Size(559, 221);
            this.dgv_ShowUp.TabIndex = 27;
            this.dgv_ShowUp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ShowUp_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "Quản lý Món ăn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 437);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tên danh mục: ";
            // 
            // lb_CategoryName
            // 
            this.lb_CategoryName.AutoSize = true;
            this.lb_CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CategoryName.Location = new System.Drawing.Point(211, 437);
            this.lb_CategoryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_CategoryName.Name = "lb_CategoryName";
            this.lb_CategoryName.Size = new System.Drawing.Size(0, 25);
            this.lb_CategoryName.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 481);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Giá tiền: ";
            // 
            // lb_FoodPrice
            // 
            this.lb_FoodPrice.AutoSize = true;
            this.lb_FoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FoodPrice.Location = new System.Drawing.Point(211, 481);
            this.lb_FoodPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_FoodPrice.Name = "lb_FoodPrice";
            this.lb_FoodPrice.Size = new System.Drawing.Size(0, 25);
            this.lb_FoodPrice.TabIndex = 42;
            // 
            // Food_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 515);
            this.Controls.Add(this.lb_FoodPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_CategoryName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.pb_FoodPicture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_FoodName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_FoodId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_ShowUp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Food_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food_Form";
            this.Load += new System.EventHandler(this.Food_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_FoodPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.PictureBox pb_FoodPicture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_FoodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_FoodId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_ShowUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_CategoryName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_FoodPrice;
    }
}