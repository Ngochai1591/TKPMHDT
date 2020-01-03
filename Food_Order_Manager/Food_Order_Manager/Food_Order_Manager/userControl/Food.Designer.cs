namespace Food_Order_Manager.userControl
{
    partial class Food
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
            this.lb_FoodName = new System.Windows.Forms.Label();
            this.pb_FoodPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FoodPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_FoodName
            // 
            this.lb_FoodName.AutoSize = true;
            this.lb_FoodName.Location = new System.Drawing.Point(3, 100);
            this.lb_FoodName.Name = "lb_FoodName";
            this.lb_FoodName.Size = new System.Drawing.Size(59, 13);
            this.lb_FoodName.TabIndex = 3;
            this.lb_FoodName.Text = "FoodName";
            this.lb_FoodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_FoodPicture
            // 
            this.pb_FoodPicture.Location = new System.Drawing.Point(4, 6);
            this.pb_FoodPicture.Name = "pb_FoodPicture";
            this.pb_FoodPicture.Size = new System.Drawing.Size(93, 94);
            this.pb_FoodPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_FoodPicture.TabIndex = 2;
            this.pb_FoodPicture.TabStop = false;
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_FoodName);
            this.Controls.Add(this.pb_FoodPicture);
            this.Name = "Food";
            this.Size = new System.Drawing.Size(100, 122);
            this.Load += new System.EventHandler(this.Food_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_FoodPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_FoodName;
        private System.Windows.Forms.PictureBox pb_FoodPicture;
    }
}
