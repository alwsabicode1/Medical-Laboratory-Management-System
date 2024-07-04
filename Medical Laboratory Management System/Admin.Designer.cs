
namespace Medical_Laboratory_Management_System
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LogBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LawnGreen;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(41, 360);
            this.flowLayoutPanel1.TabIndex = 62;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this.flowLayoutPanel1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Medical_Laboratory_Management_System.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(431, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LogBtn
            // 
            this.LogBtn.ActiveBorderThickness = 1;
            this.LogBtn.ActiveCornerRadius = 20;
            this.LogBtn.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.LogBtn.ActiveForecolor = System.Drawing.Color.Blue;
            this.LogBtn.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.LogBtn.BackColor = System.Drawing.Color.White;
            this.LogBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogBtn.BackgroundImage")));
            this.LogBtn.ButtonText = "Login";
            this.LogBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.LogBtn.IdleBorderThickness = 1;
            this.LogBtn.IdleCornerRadius = 20;
            this.LogBtn.IdleFillColor = System.Drawing.Color.White;
            this.LogBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.LogBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.LogBtn.Location = new System.Drawing.Point(187, 192);
            this.LogBtn.Margin = new System.Windows.Forms.Padding(5);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(118, 43);
            this.LogBtn.TabIndex = 71;
            this.LogBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 70;
            this.label5.Text = "Belal Alwsabi\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 69;
            this.label4.Text = "Cancel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Medical_Laboratory_Management_System.Properties.Resources.medical_lab;
            this.pictureBox1.Location = new System.Drawing.Point(179, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(158, 155);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(182, 29);
            this.password.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(154, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "MediLab  1.0";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 366);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 LogBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}