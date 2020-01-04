namespace Food_Order_Manager.userControl
{
    partial class BillInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Total = new System.Windows.Forms.Label();
            this.lb_FoodPrice = new System.Windows.Forms.Label();
            this.lb_Quantity = new System.Windows.Forms.Label();
            this.lb_FoodName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.Location = new System.Drawing.Point(324, 17);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(78, 17);
            this.lb_Total.TabIndex = 18;
            this.lb_Total.Text = "Thành tiền";
            // 
            // lb_FoodPrice
            // 
            this.lb_FoodPrice.AutoSize = true;
            this.lb_FoodPrice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FoodPrice.Location = new System.Drawing.Point(224, 17);
            this.lb_FoodPrice.Name = "lb_FoodPrice";
            this.lb_FoodPrice.Size = new System.Drawing.Size(58, 17);
            this.lb_FoodPrice.TabIndex = 17;
            this.lb_FoodPrice.Text = "Đơn giá";
            // 
            // lb_Quantity
            // 
            this.lb_Quantity.AutoSize = true;
            this.lb_Quantity.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Quantity.Location = new System.Drawing.Point(136, 17);
            this.lb_Quantity.Name = "lb_Quantity";
            this.lb_Quantity.Size = new System.Drawing.Size(65, 17);
            this.lb_Quantity.TabIndex = 16;
            this.lb_Quantity.Text = "Số lượng";
            // 
            // lb_FoodName
            // 
            this.lb_FoodName.AutoSize = true;
            this.lb_FoodName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FoodName.Location = new System.Drawing.Point(7, 17);
            this.lb_FoodName.Name = "lb_FoodName";
            this.lb_FoodName.Size = new System.Drawing.Size(69, 17);
            this.lb_FoodName.TabIndex = 15;
            this.lb_FoodName.Text = "Tên Món";
            // 
            // BillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.lb_FoodPrice);
            this.Controls.Add(this.lb_Quantity);
            this.Controls.Add(this.lb_FoodName);
            this.Name = "BillInfo";
            this.Size = new System.Drawing.Size(405, 51);
            this.Load += new System.EventHandler(this.BillInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Label lb_FoodPrice;
        private System.Windows.Forms.Label lb_Quantity;
        private System.Windows.Forms.Label lb_FoodName;
    }
}
