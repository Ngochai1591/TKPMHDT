namespace Food_Order_Manager
{
    partial class Add_Food_Form
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
            System.Windows.Forms.Label label2;
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pb_FoodPicture = new System.Windows.Forms.PictureBox();
            this.btn_ChoosePicture = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_FoodName = new System.Windows.Forms.TextBox();
            this.txt_FoodId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_CategoryName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxt_FoodPrice = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FoodPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(338, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(205, 33);
            label2.TabIndex = 12;
            label2.Text = "Thêm Món ăn";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(226, 345);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(152, 64);
            this.btn_Reset.TabIndex = 21;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(425, 345);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(152, 64);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(40, 345);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(152, 64);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.Text = "Thêm ";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pb_FoodPicture
            // 
            this.pb_FoodPicture.Location = new System.Drawing.Point(589, 109);
            this.pb_FoodPicture.Name = "pb_FoodPicture";
            this.pb_FoodPicture.Size = new System.Drawing.Size(312, 300);
            this.pb_FoodPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_FoodPicture.TabIndex = 18;
            this.pb_FoodPicture.TabStop = false;
            // 
            // btn_ChoosePicture
            // 
            this.btn_ChoosePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChoosePicture.Location = new System.Drawing.Point(705, 50);
            this.btn_ChoosePicture.Name = "btn_ChoosePicture";
            this.btn_ChoosePicture.Size = new System.Drawing.Size(116, 36);
            this.btn_ChoosePicture.TabIndex = 17;
            this.btn_ChoosePicture.Text = "Chọn hình";
            this.btn_ChoosePicture.UseVisualStyleBackColor = true;
            this.btn_ChoosePicture.Click += new System.EventHandler(this.btn_ChoosePicture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(584, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hình ảnh:";
            // 
            // txt_FoodName
            // 
            this.txt_FoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FoodName.Location = new System.Drawing.Point(203, 174);
            this.txt_FoodName.Name = "txt_FoodName";
            this.txt_FoodName.Size = new System.Drawing.Size(374, 31);
            this.txt_FoodName.TabIndex = 15;
            // 
            // txt_FoodId
            // 
            this.txt_FoodId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FoodId.Location = new System.Drawing.Point(203, 106);
            this.txt_FoodId.Name = "txt_FoodId";
            this.txt_FoodId.Size = new System.Drawing.Size(374, 31);
            this.txt_FoodId.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên Món ăn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Món ăn:";
            // 
            // cb_CategoryName
            // 
            this.cb_CategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CategoryName.FormattingEnabled = true;
            this.cb_CategoryName.Location = new System.Drawing.Point(203, 223);
            this.cb_CategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.cb_CategoryName.Name = "cb_CategoryName";
            this.cb_CategoryName.Size = new System.Drawing.Size(143, 34);
            this.cb_CategoryName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tên Danh mục:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Giá tiền";
            // 
            // mtxt_FoodPrice
            // 
            this.mtxt_FoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_FoodPrice.Location = new System.Drawing.Point(203, 281);
            this.mtxt_FoodPrice.Mask = "00,000,000";
            this.mtxt_FoodPrice.Name = "mtxt_FoodPrice";
            this.mtxt_FoodPrice.PromptChar = ' ';
            this.mtxt_FoodPrice.Size = new System.Drawing.Size(175, 31);
            this.mtxt_FoodPrice.TabIndex = 25;
            this.mtxt_FoodPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxt_FoodPrice.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "VNĐ";
            // 
            // Add_Food_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 425);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtxt_FoodPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_CategoryName);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.pb_FoodPicture);
            this.Controls.Add(this.btn_ChoosePicture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_FoodName);
            this.Controls.Add(this.txt_FoodId);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Add_Food_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Food_Form";
            this.Load += new System.EventHandler(this.Add_Food_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_FoodPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.PictureBox pb_FoodPicture;
        private System.Windows.Forms.Button btn_ChoosePicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_FoodName;
        private System.Windows.Forms.TextBox txt_FoodId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_CategoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxt_FoodPrice;
        private System.Windows.Forms.Label label7;
    }
}