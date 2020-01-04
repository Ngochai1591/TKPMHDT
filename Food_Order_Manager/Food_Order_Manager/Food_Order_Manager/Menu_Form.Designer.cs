namespace Food_Order_Manager
{
    partial class Menu_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_BillDetails = new System.Windows.Forms.DataGridView();
            this.btn_Quantity_10 = new System.Windows.Forms.Button();
            this.btn_Quantity_9 = new System.Windows.Forms.Button();
            this.btn_Quantity_8 = new System.Windows.Forms.Button();
            this.btn_Quantity_7 = new System.Windows.Forms.Button();
            this.btn_Quantity_6 = new System.Windows.Forms.Button();
            this.btn_Quantity_5 = new System.Windows.Forms.Button();
            this.btn_Quantity_4 = new System.Windows.Forms.Button();
            this.btn_Quantity_3 = new System.Windows.Forms.Button();
            this.btn_Quantity_2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Quantity_1 = new System.Windows.Forms.Button();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.bnt_DeleteFoodDetail = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_TableName = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NumberBill = new System.Windows.Forms.TextBox();
            this.gb_Category = new System.Windows.Forms.GroupBox();
            this.flp_Category = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flp_Food = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_CancelBill = new System.Windows.Forms.Button();
            this.btn_PrintBill = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.gb_Category.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgv_BillDetails);
            this.panel1.Controls.Add(this.btn_Quantity_10);
            this.panel1.Controls.Add(this.btn_Quantity_9);
            this.panel1.Controls.Add(this.btn_Quantity_8);
            this.panel1.Controls.Add(this.btn_Quantity_7);
            this.panel1.Controls.Add(this.btn_Quantity_6);
            this.panel1.Controls.Add(this.btn_Quantity_5);
            this.panel1.Controls.Add(this.btn_Quantity_4);
            this.panel1.Controls.Add(this.btn_Quantity_3);
            this.panel1.Controls.Add(this.btn_Quantity_2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_Quantity_1);
            this.panel1.Controls.Add(this.txt_Total);
            this.panel1.Controls.Add(this.bnt_DeleteFoodDetail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_NumberBill);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 851);
            this.panel1.TabIndex = 0;
            // 
            // dgv_BillDetails
            // 
            this.dgv_BillDetails.AllowUserToAddRows = false;
            this.dgv_BillDetails.AllowUserToDeleteRows = false;
            this.dgv_BillDetails.AllowUserToResizeColumns = false;
            this.dgv_BillDetails.AllowUserToResizeRows = false;
            this.dgv_BillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BillDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodId,
            this.Quantity1,
            this.Price});
            this.dgv_BillDetails.Location = new System.Drawing.Point(3, 139);
            this.dgv_BillDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_BillDetails.Name = "dgv_BillDetails";
            this.dgv_BillDetails.ReadOnly = true;
            this.dgv_BillDetails.Size = new System.Drawing.Size(432, 609);
            this.dgv_BillDetails.TabIndex = 31;
            // 
            // btn_Quantity_10
            // 
            this.btn_Quantity_10.Location = new System.Drawing.Point(441, 772);
            this.btn_Quantity_10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Quantity_10.Name = "btn_Quantity_10";
            this.btn_Quantity_10.Size = new System.Drawing.Size(80, 57);
            this.btn_Quantity_10.TabIndex = 30;
            this.btn_Quantity_10.Text = "10";
            this.btn_Quantity_10.UseVisualStyleBackColor = true;
            this.btn_Quantity_10.Click += new System.EventHandler(this.btn_Quantity_10_Click);
            // 
            // btn_Quantity_9
            // 
            this.btn_Quantity_9.Location = new System.Drawing.Point(441, 690);
            this.btn_Quantity_9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Quantity_9.Name = "btn_Quantity_9";
            this.btn_Quantity_9.Size = new System.Drawing.Size(80, 57);
            this.btn_Quantity_9.TabIndex = 29;
            this.btn_Quantity_9.Text = "9";
            this.btn_Quantity_9.UseVisualStyleBackColor = true;
            this.btn_Quantity_9.Click += new System.EventHandler(this.btn_Quantity_9_Click);
            // 
            // btn_Quantity_8
            // 
            this.btn_Quantity_8.Location = new System.Drawing.Point(441, 614);
            this.btn_Quantity_8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Quantity_8.Name = "btn_Quantity_8";
            this.btn_Quantity_8.Size = new System.Drawing.Size(80, 57);
            this.btn_Quantity_8.TabIndex = 28;
            this.btn_Quantity_8.Text = "8";
            this.btn_Quantity_8.UseVisualStyleBackColor = true;
            this.btn_Quantity_8.Click += new System.EventHandler(this.btn_Quantity_8_Click);
            // 
            // btn_Quantity_7
            // 
            this.btn_Quantity_7.Location = new System.Drawing.Point(441, 534);
            this.btn_Quantity_7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Quantity_7.Name = "btn_Quantity_7";
            this.btn_Quantity_7.Size = new System.Drawing.Size(80, 57);
            this.btn_Quantity_7.TabIndex = 27;
            this.btn_Quantity_7.Text = "7";
            this.btn_Quantity_7.UseVisualStyleBackColor = true;
            this.btn_Quantity_7.Click += new System.EventHandler(this.btn_Quantity_7_Click);
            // 
            // btn_Quantity_6
            // 
            this.btn_Quantity_6.Location = new System.Drawing.Point(441, 460);
            this.btn_Quantity_6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Quantity_6.Name = "btn_Quantity_6";
            this.btn_Quantity_6.Size = new System.Drawing.Size(80, 57);
            this.btn_Quantity_6.TabIndex = 26;
            this.btn_Quantity_6.Text = "6";
            this.btn_Quantity_6.UseVisualStyleBackColor = true;
            this.btn_Quantity_6.Click += new System.EventHandler(this.btn_Quantity_6_Click);
            // 
            // btn_Quantity_5
            // 
            this.btn_Quantity_5.Location = new System.Drawing.Point(441, 388);
            this.btn_Quantity_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Quantity_5.Name = "btn_Quantity_5";
            this.btn_Quantity_5.Size = new System.Drawing.Size(80, 57);
            this.btn_Quantity_5.TabIndex = 25;
            this.btn_Quantity_5.Text = "5";
            this.btn_Quantity_5.UseVisualStyleBackColor = true;
            this.btn_Quantity_5.Click += new System.EventHandler(this.btn_Quantity_5_Click);
            // 
            // btn_Quantity_4
            // 
            this.btn_Quantity_4.Location = new System.Drawing.Point(441, 314);
            this.btn_Quantity_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Quantity_4.Name = "btn_Quantity_4";
            this.btn_Quantity_4.Size = new System.Drawing.Size(80, 57);
            this.btn_Quantity_4.TabIndex = 24;
            this.btn_Quantity_4.Text = "4";
            this.btn_Quantity_4.UseVisualStyleBackColor = true;
            this.btn_Quantity_4.Click += new System.EventHandler(this.btn_Quantity_4_Click);
            // 
            // btn_Quantity_3
            // 
            this.btn_Quantity_3.Location = new System.Drawing.Point(441, 235);
            this.btn_Quantity_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Quantity_3.Name = "btn_Quantity_3";
            this.btn_Quantity_3.Size = new System.Drawing.Size(80, 57);
            this.btn_Quantity_3.TabIndex = 23;
            this.btn_Quantity_3.Text = "3";
            this.btn_Quantity_3.UseVisualStyleBackColor = true;
            this.btn_Quantity_3.Click += new System.EventHandler(this.btn_Quantity_3_Click);
            // 
            // btn_Quantity_2
            // 
            this.btn_Quantity_2.Location = new System.Drawing.Point(441, 154);
            this.btn_Quantity_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Quantity_2.Name = "btn_Quantity_2";
            this.btn_Quantity_2.Size = new System.Drawing.Size(80, 57);
            this.btn_Quantity_2.TabIndex = 22;
            this.btn_Quantity_2.Text = "2";
            this.btn_Quantity_2.UseVisualStyleBackColor = true;
            this.btn_Quantity_2.Click += new System.EventHandler(this.btn_Quantity_2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(424, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 32);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mã Hóa đơn";
            // 
            // btn_Quantity_1
            // 
            this.btn_Quantity_1.Location = new System.Drawing.Point(441, 75);
            this.btn_Quantity_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Quantity_1.Name = "btn_Quantity_1";
            this.btn_Quantity_1.Size = new System.Drawing.Size(80, 57);
            this.btn_Quantity_1.TabIndex = 8;
            this.btn_Quantity_1.Text = "1";
            this.btn_Quantity_1.UseVisualStyleBackColor = true;
            this.btn_Quantity_1.Click += new System.EventHandler(this.btn_Quantity_1_Click);
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(20, 809);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Total.Multiline = true;
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Total.Size = new System.Drawing.Size(251, 37);
            this.txt_Total.TabIndex = 6;
            // 
            // bnt_DeleteFoodDetail
            // 
            this.bnt_DeleteFoodDetail.Location = new System.Drawing.Point(161, 754);
            this.bnt_DeleteFoodDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnt_DeleteFoodDetail.Name = "bnt_DeleteFoodDetail";
            this.bnt_DeleteFoodDetail.Size = new System.Drawing.Size(256, 49);
            this.bnt_DeleteFoodDetail.TabIndex = 6;
            this.bnt_DeleteFoodDetail.Text = "Xóa món đã chọn";
            this.bnt_DeleteFoodDetail.UseVisualStyleBackColor = true;
            this.bnt_DeleteFoodDetail.Click += new System.EventHandler(this.bnt_DeleteFoodDetail_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 763);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng tiền:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_TableName);
            this.panel2.Controls.Add(this.txt_Name);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 73);
            this.panel2.TabIndex = 3;
            // 
            // txt_TableName
            // 
            this.txt_TableName.Enabled = false;
            this.txt_TableName.Location = new System.Drawing.Point(273, 23);
            this.txt_TableName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TableName.Multiline = true;
            this.txt_TableName.Name = "txt_TableName";
            this.txt_TableName.ReadOnly = true;
            this.txt_TableName.Size = new System.Drawing.Size(139, 36);
            this.txt_TableName.TabIndex = 24;
            // 
            // txt_Name
            // 
            this.txt_Name.Enabled = false;
            this.txt_Name.Location = new System.Drawing.Point(5, 23);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(256, 36);
            this.txt_Name.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên NV";
            // 
            // txt_NumberBill
            // 
            this.txt_NumberBill.Enabled = false;
            this.txt_NumberBill.Location = new System.Drawing.Point(175, 14);
            this.txt_NumberBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NumberBill.Multiline = true;
            this.txt_NumberBill.Name = "txt_NumberBill";
            this.txt_NumberBill.ReadOnly = true;
            this.txt_NumberBill.Size = new System.Drawing.Size(245, 43);
            this.txt_NumberBill.TabIndex = 1;
            // 
            // gb_Category
            // 
            this.gb_Category.Controls.Add(this.flp_Category);
            this.gb_Category.Location = new System.Drawing.Point(555, 57);
            this.gb_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Category.Name = "gb_Category";
            this.gb_Category.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Category.Size = new System.Drawing.Size(1240, 329);
            this.gb_Category.TabIndex = 1;
            this.gb_Category.TabStop = false;
            this.gb_Category.Text = "Danh mục";
            // 
            // flp_Category
            // 
            this.flp_Category.AutoScroll = true;
            this.flp_Category.Location = new System.Drawing.Point(5, 15);
            this.flp_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_Category.Name = "flp_Category";
            this.flp_Category.Size = new System.Drawing.Size(1229, 309);
            this.flp_Category.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flp_Food);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(555, 386);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1240, 475);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết danh mục";
            // 
            // flp_Food
            // 
            this.flp_Food.AutoScroll = true;
            this.flp_Food.Location = new System.Drawing.Point(5, 18);
            this.flp_Food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_Food.Name = "flp_Food";
            this.flp_Food.Size = new System.Drawing.Size(1229, 495);
            this.flp_Food.TabIndex = 1;
            // 
            // btn_CancelBill
            // 
            this.btn_CancelBill.BackColor = System.Drawing.Color.Red;
            this.btn_CancelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelBill.Location = new System.Drawing.Point(555, -4);
            this.btn_CancelBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CancelBill.Name = "btn_CancelBill";
            this.btn_CancelBill.Size = new System.Drawing.Size(171, 62);
            this.btn_CancelBill.TabIndex = 24;
            this.btn_CancelBill.Text = "HỦY BILL";
            this.btn_CancelBill.UseVisualStyleBackColor = false;
            this.btn_CancelBill.Click += new System.EventHandler(this.btn_CancelBill_Click);
            // 
            // btn_PrintBill
            // 
            this.btn_PrintBill.BackColor = System.Drawing.Color.Lime;
            this.btn_PrintBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintBill.Location = new System.Drawing.Point(1381, -4);
            this.btn_PrintBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PrintBill.Name = "btn_PrintBill";
            this.btn_PrintBill.Size = new System.Drawing.Size(239, 62);
            this.btn_PrintBill.TabIndex = 26;
            this.btn_PrintBill.Text = "IN BILL";
            this.btn_PrintBill.UseVisualStyleBackColor = false;
            this.btn_PrintBill.Click += new System.EventHandler(this.bnt_PrintBill_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Blue;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(1640, -4);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(149, 62);
            this.btn_Back.TabIndex = 27;
            this.btn_Back.Text = "TRỞ LẠI";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // FoodId
            // 
            this.FoodId.DataPropertyName = "FoodId";
            this.FoodId.HeaderText = "ID Món ăn";
            this.FoodId.Name = "FoodId";
            this.FoodId.ReadOnly = true;
            // 
            // Quantity1
            // 
            this.Quantity1.DataPropertyName = "Quantity";
            this.Quantity1.HeaderText = "Số lượng";
            this.Quantity1.Name = "Quantity1";
            this.Quantity1.ReadOnly = true;
            this.Quantity1.Width = 80;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Cost";
            this.Price.HeaderText = "Giá tiền";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 120;
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1800, 863);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_PrintBill);
            this.Controls.Add(this.btn_CancelBill);
            this.Controls.Add(this.gb_Category);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Form";
            this.Load += new System.EventHandler(this.Menu_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gb_Category.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Button bnt_DeleteFoodDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_NumberBill;
        private System.Windows.Forms.Button btn_Quantity_1;
        private System.Windows.Forms.GroupBox gb_Category;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_CancelBill;
        private System.Windows.Forms.Button btn_PrintBill;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TableName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flp_Category;
        private System.Windows.Forms.FlowLayoutPanel flp_Food;
        private System.Windows.Forms.Button btn_Quantity_10;
        private System.Windows.Forms.Button btn_Quantity_9;
        private System.Windows.Forms.Button btn_Quantity_8;
        private System.Windows.Forms.Button btn_Quantity_7;
        private System.Windows.Forms.Button btn_Quantity_6;
        private System.Windows.Forms.Button btn_Quantity_5;
        private System.Windows.Forms.Button btn_Quantity_4;
        private System.Windows.Forms.Button btn_Quantity_3;
        private System.Windows.Forms.Button btn_Quantity_2;
        private System.Windows.Forms.DataGridView dgv_BillDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}