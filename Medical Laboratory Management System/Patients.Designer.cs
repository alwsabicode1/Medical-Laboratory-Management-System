﻿
namespace Medical_Laboratory_Management_System
{
    partial class Patients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.PatDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.PatGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PatPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PatAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PatName = new System.Windows.Forms.TextBox();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PatGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeletePat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SavePat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditPat = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.PatGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PatDate
            // 
            this.PatDate.BackColor = System.Drawing.Color.LawnGreen;
            this.PatDate.Checked = true;
            this.PatDate.FillColor = System.Drawing.Color.LawnGreen;
            this.PatDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PatDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.PatDate.Location = new System.Drawing.Point(638, 182);
            this.PatDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.PatDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.PatDate.Name = "PatDate";
            this.PatDate.Size = new System.Drawing.Size(193, 38);
            this.PatDate.TabIndex = 42;
            this.PatDate.Value = new System.DateTime(2024, 1, 4, 20, 30, 31, 280);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.PatDate;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(818, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Gender";
            // 
            // PatGender
            // 
            this.PatGender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PatGender.FormattingEnabled = true;
            this.PatGender.Items.AddRange(new object[] {
            "Male",
            "female"});
            this.PatGender.Location = new System.Drawing.Point(822, 134);
            this.PatGender.Name = "PatGender";
            this.PatGender.Size = new System.Drawing.Size(121, 29);
            this.PatGender.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(634, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Phone";
            // 
            // PatPhone
            // 
            this.PatPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatPhone.Location = new System.Drawing.Point(638, 134);
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.Size = new System.Drawing.Size(164, 29);
            this.PatPhone.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(454, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Address";
            // 
            // PatAddress
            // 
            this.PatAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatAddress.Location = new System.Drawing.Point(458, 134);
            this.PatAddress.Multiline = true;
            this.PatAddress.Name = "PatAddress";
            this.PatAddress.Size = new System.Drawing.Size(164, 86);
            this.PatAddress.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(255, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Patients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 9);
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
            // PatName
            // 
            this.PatName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatName.Location = new System.Drawing.Point(259, 134);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(186, 29);
            this.PatName.TabIndex = 29;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this.PatGV;
            // 
            // PatGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PatGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PatGV.ColumnHeadersHeight = 30;
            this.PatGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PatGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatGV.Location = new System.Drawing.Point(199, 310);
            this.PatGV.Name = "PatGV";
            this.PatGV.ReadOnly = true;
            this.PatGV.RowHeadersVisible = false;
            this.PatGV.RowTemplate.Height = 24;
            this.PatGV.Size = new System.Drawing.Size(900, 233);
            this.PatGV.TabIndex = 43;
            this.PatGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PatGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PatGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PatGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PatGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PatGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PatGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkGreen;
            this.PatGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PatGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PatGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PatGV.ThemeStyle.HeaderStyle.Height = 30;
            this.PatGV.ThemeStyle.ReadOnly = true;
            this.PatGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PatGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.PatGV.ThemeStyle.RowsStyle.Height = 24;
            this.PatGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LawnGreen;
            this.PatGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatGV_CellContentClick);
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.labDate.Location = new System.Drawing.Point(895, 19);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(48, 23);
            this.labDate.TabIndex = 82;
            this.labDate.Text = "Date";
            this.labDate.Click += new System.EventHandler(this.labDate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(205, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 84;
            this.label8.Text = "Belal ALwsabi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 602);
            this.panel1.TabIndex = 85;
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
            this.pictureBox5.Location = new System.Drawing.Point(6, 312);
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
            this.pictureBox4.Location = new System.Drawing.Point(3, 234);
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
            this.pictureBox3.Location = new System.Drawing.Point(3, 166);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Medical_Laboratory_Management_System.Properties.Resources.medical_lab;
            this.pictureBox7.Location = new System.Drawing.Point(6, 15);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(43, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Medical_Laboratory_Management_System.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(1074, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DeletePat
            // 
            this.DeletePat.ActiveBorderThickness = 1;
            this.DeletePat.ActiveCornerRadius = 20;
            this.DeletePat.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.DeletePat.ActiveForecolor = System.Drawing.Color.Blue;
            this.DeletePat.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.DeletePat.BackColor = System.Drawing.Color.White;
            this.DeletePat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeletePat.BackgroundImage")));
            this.DeletePat.ButtonText = "Delete";
            this.DeletePat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletePat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePat.ForeColor = System.Drawing.Color.SeaGreen;
            this.DeletePat.IdleBorderThickness = 1;
            this.DeletePat.IdleCornerRadius = 20;
            this.DeletePat.IdleFillColor = System.Drawing.Color.White;
            this.DeletePat.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.DeletePat.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.DeletePat.Location = new System.Drawing.Point(739, 245);
            this.DeletePat.Margin = new System.Windows.Forms.Padding(5);
            this.DeletePat.Name = "DeletePat";
            this.DeletePat.Size = new System.Drawing.Size(118, 48);
            this.DeletePat.TabIndex = 40;
            this.DeletePat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeletePat.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // SavePat
            // 
            this.SavePat.ActiveBorderThickness = 1;
            this.SavePat.ActiveCornerRadius = 20;
            this.SavePat.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.SavePat.ActiveForecolor = System.Drawing.Color.Blue;
            this.SavePat.ActiveLineColor = System.Drawing.Color.White;
            this.SavePat.BackColor = System.Drawing.Color.White;
            this.SavePat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SavePat.BackgroundImage")));
            this.SavePat.ButtonText = "Save";
            this.SavePat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SavePat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePat.ForeColor = System.Drawing.Color.SeaGreen;
            this.SavePat.IdleBorderThickness = 1;
            this.SavePat.IdleCornerRadius = 20;
            this.SavePat.IdleFillColor = System.Drawing.Color.White;
            this.SavePat.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SavePat.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SavePat.Location = new System.Drawing.Point(410, 245);
            this.SavePat.Margin = new System.Windows.Forms.Padding(5);
            this.SavePat.Name = "SavePat";
            this.SavePat.Size = new System.Drawing.Size(118, 48);
            this.SavePat.TabIndex = 38;
            this.SavePat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SavePat.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // EditPat
            // 
            this.EditPat.ActiveBorderThickness = 1;
            this.EditPat.ActiveCornerRadius = 20;
            this.EditPat.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.EditPat.ActiveForecolor = System.Drawing.Color.Blue;
            this.EditPat.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.EditPat.BackColor = System.Drawing.Color.White;
            this.EditPat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditPat.BackgroundImage")));
            this.EditPat.ButtonText = "Edit";
            this.EditPat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditPat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPat.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditPat.IdleBorderThickness = 1;
            this.EditPat.IdleCornerRadius = 20;
            this.EditPat.IdleFillColor = System.Drawing.Color.White;
            this.EditPat.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.EditPat.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.EditPat.Location = new System.Drawing.Point(573, 245);
            this.EditPat.Margin = new System.Windows.Forms.Padding(5);
            this.EditPat.Name = "EditPat";
            this.EditPat.Size = new System.Drawing.Size(118, 48);
            this.EditPat.TabIndex = 39;
            this.EditPat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditPat.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.PatGV);
            this.Controls.Add(this.PatDate);
            this.Controls.Add(this.DeletePat);
            this.Controls.Add(this.SavePat);
            this.Controls.Add(this.EditPat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PatGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PatPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatGV)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker PatDate;
        private Bunifu.Framework.UI.BunifuThinButton2 DeletePat;
        private Bunifu.Framework.UI.BunifuThinButton2 SavePat;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuThinButton2 EditPat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PatGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PatPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PatAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox PatName;
        private Guna.UI2.WinForms.Guna2DataGridView PatGV;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}