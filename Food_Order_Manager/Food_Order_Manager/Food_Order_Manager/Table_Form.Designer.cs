﻿namespace Food_Order_Manager
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
            this.flp_tableList = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pos1 = new Food_Order_Manager.userControl.POS();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_tableList
            // 
            this.flp_tableList.Location = new System.Drawing.Point(3, 201);
            this.flp_tableList.Name = "flp_tableList";
            this.flp_tableList.Size = new System.Drawing.Size(1344, 498);
            this.flp_tableList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1060, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Xin chào: ";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(1175, 15);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(155, 25);
            this.lb_Name.TabIndex = 3;
            this.lb_Name.Text = "tên nhân viên";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(1163, 55);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(167, 94);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.pos1);
            this.groupBox1.Controls.Add(this.btn_Logout);
            this.groupBox1.Controls.Add(this.lb_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1344, 181);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // pos1
            // 
            this.pos1.Location = new System.Drawing.Point(6, 15);
            this.pos1.Name = "pos1";
            this.pos1.Size = new System.Drawing.Size(150, 150);
            this.pos1.TabIndex = 0;
            // 
            // Table_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1350, 711);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flp_tableList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Table_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table_Form";
            this.Load += new System.EventHandler(this.Table_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private userControl.POS pos1;
        private System.Windows.Forms.FlowLayoutPanel flp_tableList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}