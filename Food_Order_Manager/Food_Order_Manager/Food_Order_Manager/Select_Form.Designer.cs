namespace Food_Order_Manager
{
    partial class Select_Form
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
            this.btn_TakeAway = new System.Windows.Forms.Button();
            this.btn_DineIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_TakeAway
            // 
            this.btn_TakeAway.Location = new System.Drawing.Point(51, 48);
            this.btn_TakeAway.Name = "btn_TakeAway";
            this.btn_TakeAway.Size = new System.Drawing.Size(107, 40);
            this.btn_TakeAway.TabIndex = 0;
            this.btn_TakeAway.Text = "Take Away";
            this.btn_TakeAway.UseVisualStyleBackColor = true;
            // 
            // btn_DineIn
            // 
            this.btn_DineIn.Location = new System.Drawing.Point(181, 48);
            this.btn_DineIn.Name = "btn_DineIn";
            this.btn_DineIn.Size = new System.Drawing.Size(107, 40);
            this.btn_DineIn.TabIndex = 1;
            this.btn_DineIn.Text = "Dine-in";
            this.btn_DineIn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "SELECT ";
            // 
            // Select_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DineIn);
            this.Controls.Add(this.btn_TakeAway);
            this.Name = "Select_Form";
            this.Text = "Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TakeAway;
        private System.Windows.Forms.Button btn_DineIn;
        private System.Windows.Forms.Label label1;
    }
}