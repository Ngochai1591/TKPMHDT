namespace Food_Order_Manager.userControl
{
    partial class Category
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
            this.pb_CategoryPicture = new System.Windows.Forms.PictureBox();
            this.lb_CategoryName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CategoryPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_CategoryPicture
            // 
            this.pb_CategoryPicture.Location = new System.Drawing.Point(4, 0);
            this.pb_CategoryPicture.Name = "pb_CategoryPicture";
            this.pb_CategoryPicture.Size = new System.Drawing.Size(111, 94);
            this.pb_CategoryPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_CategoryPicture.TabIndex = 0;
            this.pb_CategoryPicture.TabStop = false;
            // 
            // lb_CategoryName
            // 
            this.lb_CategoryName.AutoSize = true;
            this.lb_CategoryName.Location = new System.Drawing.Point(3, 100);
            this.lb_CategoryName.Name = "lb_CategoryName";
            this.lb_CategoryName.Size = new System.Drawing.Size(76, 13);
            this.lb_CategoryName.TabIndex = 1;
            this.lb_CategoryName.Text = "categoryName";
            this.lb_CategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_CategoryName);
            this.Controls.Add(this.pb_CategoryPicture);
            this.Name = "Category";
            this.Size = new System.Drawing.Size(119, 122);
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_CategoryPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_CategoryPicture;
        private System.Windows.Forms.Label lb_CategoryName;
    }
}
