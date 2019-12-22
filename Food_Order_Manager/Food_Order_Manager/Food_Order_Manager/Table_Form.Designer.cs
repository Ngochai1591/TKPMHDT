namespace Food_Order_Manager
{
    partial class Table_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table_Form));
            this.pos1 = new Food_Order_Manager.userControl.POS();
            this.SuspendLayout();
            // 
            // pos1
            // 
            this.pos1.Location = new System.Drawing.Point(-3, 579);
            this.pos1.Name = "pos1";
            this.pos1.Size = new System.Drawing.Size(150, 150);
            this.pos1.TabIndex = 0;
            // 
            // Table_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pos1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Table_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table_Form";
            this.Load += new System.EventHandler(this.Table_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private userControl.POS pos1;
    }
}