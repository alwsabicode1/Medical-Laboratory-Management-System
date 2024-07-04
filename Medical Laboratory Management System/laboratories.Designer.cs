
namespace Medical_Laboratory_Management_System
{
    partial class laboratories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(laboratories));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.LabGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LabPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabAdders = new System.Windows.Forms.TextBox();
            this.LabName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Qual = new System.Windows.Forms.ComboBox();
            this.EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SaveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LabGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lab = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LabGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabDate
            // 
            this.LabDate.BackColor = System.Drawing.Color.LawnGreen;
            this.LabDate.Checked = true;
            this.LabDate.FillColor = System.Drawing.Color.LawnGreen;
            this.LabDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.LabDate.Location = new System.Drawing.Point(281, 180);
            this.LabDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.LabDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.LabDate.Name = "LabDate";
            this.LabDate.Size = new System.Drawing.Size(186, 38);
            this.LabDate.TabIndex = 44;
            this.LabDate.Value = new System.DateTime(2024, 1, 4, 20, 30, 31, 280);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.LabDate;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(840, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Gender";
            // 
            // LabGender
            // 
            this.LabGender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LabGender.FormattingEnabled = true;
            this.LabGender.Items.AddRange(new object[] {
            "Male",
            "female"});
            this.LabGender.Location = new System.Drawing.Point(844, 145);
            this.LabGender.Name = "LabGender";
            this.LabGender.Size = new System.Drawing.Size(121, 29);
            this.LabGender.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(656, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Phone";
            // 
            // LabPhone
            // 
            this.LabPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPhone.Location = new System.Drawing.Point(660, 145);
            this.LabPhone.Name = "LabPhone";
            this.LabPhone.Size = new System.Drawing.Size(164, 29);
            this.LabPhone.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(476, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Address";
            // 
            // LabAdders
            // 
            this.LabAdders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabAdders.Location = new System.Drawing.Point(480, 145);
            this.LabAdders.Multiline = true;
            this.LabAdders.Name = "LabAdders";
            this.LabAdders.Size = new System.Drawing.Size(164, 86);
            this.LabAdders.TabIndex = 31;
            // 
            // LabName
            // 
            this.LabName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabName.Location = new System.Drawing.Point(281, 145);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(186, 29);
            this.LabName.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Laboratories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "New Life Medical Lab";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(277, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Agent Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(656, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 46;
            this.label7.Text = "Qualification";
            // 
            // Qual
            // 
            this.Qual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qual.FormattingEnabled = true;
            this.Qual.Items.AddRange(new object[] {
            "Diploma",
            "Bachelor",
            "Master"});
            this.Qual.Location = new System.Drawing.Point(660, 202);
            this.Qual.Name = "Qual";
            this.Qual.Size = new System.Drawing.Size(162, 29);
            this.Qual.TabIndex = 45;
            this.Qual.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // EditBtn
            // 
            this.EditBtn.ActiveBorderThickness = 1;
            this.EditBtn.ActiveCornerRadius = 20;
            this.EditBtn.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.EditBtn.ActiveForecolor = System.Drawing.Color.Blue;
            this.EditBtn.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.EditBtn.BackColor = System.Drawing.Color.White;
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.ButtonText = "Edit";
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.IdleBorderThickness = 1;
            this.EditBtn.IdleCornerRadius = 20;
            this.EditBtn.IdleFillColor = System.Drawing.Color.White;
            this.EditBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.EditBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.Location = new System.Drawing.Point(595, 256);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(5);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(118, 48);
            this.EditBtn.TabIndex = 41;
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.ActiveBorderThickness = 1;
            this.SaveBtn.ActiveCornerRadius = 20;
            this.SaveBtn.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.SaveBtn.ActiveForecolor = System.Drawing.Color.Blue;
            this.SaveBtn.ActiveLineColor = System.Drawing.Color.White;
            this.SaveBtn.BackColor = System.Drawing.Color.White;
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.ButtonText = "Save";
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.IdleBorderThickness = 1;
            this.SaveBtn.IdleCornerRadius = 20;
            this.SaveBtn.IdleFillColor = System.Drawing.Color.White;
            this.SaveBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.Location = new System.Drawing.Point(432, 256);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(118, 48);
            this.SaveBtn.TabIndex = 40;
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.ActiveBorderThickness = 1;
            this.DeleteBtn.ActiveCornerRadius = 20;
            this.DeleteBtn.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.DeleteBtn.ActiveForecolor = System.Drawing.Color.Blue;
            this.DeleteBtn.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.ButtonText = "Delete";
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtn.IdleBorderThickness = 1;
            this.DeleteBtn.IdleCornerRadius = 20;
            this.DeleteBtn.IdleFillColor = System.Drawing.Color.White;
            this.DeleteBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.DeleteBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtn.Location = new System.Drawing.Point(761, 256);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(118, 48);
            this.DeleteBtn.TabIndex = 42;
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this.LabGV;
            // 
            // LabGV
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.LabGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LabGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.LabGV.ColumnHeadersHeight = 30;
            this.LabGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LabGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.LabGV.GridColor = System.Drawing.Color.White;
            this.LabGV.Location = new System.Drawing.Point(159, 341);
            this.LabGV.Name = "LabGV";
            this.LabGV.ReadOnly = true;
            this.LabGV.RowHeadersVisible = false;
            this.LabGV.Size = new System.Drawing.Size(906, 204);
            this.LabGV.TabIndex = 47;
            this.LabGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.LabGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.LabGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.LabGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.LabGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LabGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.LabGV.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.LabGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkGreen;
            this.LabGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LabGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.LabGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.LabGV.ThemeStyle.HeaderStyle.Height = 30;
            this.LabGV.ThemeStyle.ReadOnly = true;
            this.LabGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.LabGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LabGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.LabGV.ThemeStyle.RowsStyle.Height = 22;
            this.LabGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LawnGreen;
            this.LabGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.LabGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LabGV_CellContentClick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Medical_Laboratory_Management_System.Properties.Resources.close;
            this.pictureBox7.Location = new System.Drawing.Point(1074, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(49, 36);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 83;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.lab.Location = new System.Drawing.Point(892, 20);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(48, 23);
            this.lab.TabIndex = 82;
            this.lab.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(840, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 86;
            this.label8.Text = "Password";
            // 
            // PasswordTb
            // 
            this.PasswordTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.Location = new System.Drawing.Point(844, 202);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(164, 29);
            this.PasswordTb.TabIndex = 85;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(192, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 87;
            this.label9.Text = "Belal ALwsabi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 602);
            this.panel1.TabIndex = 88;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Medical_Laboratory_Management_System.Properties.Resources.exit;
            this.pictureBox6.Location = new System.Drawing.Point(6, 505);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Medical_Laboratory_Management_System.Properties.Resources.scan;
            this.pictureBox5.Location = new System.Drawing.Point(6, 356);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 51);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Medical_Laboratory_Management_System.Properties.Resources.examination;
            this.pictureBox4.Location = new System.Drawing.Point(3, 278);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Medical_Laboratory_Management_System.Properties.Resources.microscope;
            this.pictureBox3.Location = new System.Drawing.Point(3, 210);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Medical_Laboratory_Management_System.Properties.Resources.laboratory__1_;
            this.pictureBox2.Location = new System.Drawing.Point(6, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Medical_Laboratory_Management_System.Properties.Resources.medical_lab;
            this.pictureBox1.Location = new System.Drawing.Point(6, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // laboratories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.LabGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Qual);
            this.Controls.Add(this.LabDate);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabAdders);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "laboratories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "laboratories";
            this.Load += new System.EventHandler(this.laboratories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LabGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker LabDate;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox LabGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LabPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LabAdders;
        private System.Windows.Forms.TextBox LabName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Qual;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Guna.UI2.WinForms.Guna2DataGridView LabGV;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}