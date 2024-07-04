using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Laboratory_Management_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                MessageBox.Show("Enter The Password!!!");

            }
            else if (password.Text == "1122"){
                laboratories Lab = new laboratories();
                this.Hide();
                Lab.Show();
            }
            else
            {
                MessageBox.Show("Wrong Admin Password!!! ");
            }
        }
    }
}
