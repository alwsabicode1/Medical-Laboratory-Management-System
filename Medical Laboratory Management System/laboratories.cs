using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Medical_Laboratory_Management_System
{
    public partial class laboratories : Form
    {
        public laboratories()
        {
            InitializeComponent();
            ShowLab();
        }
       
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Life's smile\Documents\MedicalLabDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowLab()
        {
            con.Open();
            String query = "select * from LaboratorianTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            LabGV.DataSource = ds.Tables[0];

            con.Close();

        }
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void laboratories_Load(object sender, EventArgs e)
        {
            ShowLab();
            lab.Text = DateTime.Today.Date.Day.ToString() + "-" + DateTime.Today.Date.Month.ToString() + "-" + DateTime.Today.Date.Year.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (LabName.Text == "" || LabAdders.Text == "" || LabPhone.Text == "" || LabGender.SelectedIndex == -1 || Qual.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information !!!");

            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into LaboratorianTbl(LabName,LabGender,LabAdders,LabQual,LabPhone,LabDate,LabPass) values(@LN,@LG,@LA,@LQ,@LP,@LD,@LPass)",con);
                    cmd.Parameters.AddWithValue("@LN",LabName.Text);
                    cmd.Parameters.AddWithValue("@LG", LabGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@LA", LabAdders.Text);
                    cmd.Parameters.AddWithValue("@LQ", Qual.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@LP", LabPhone.Text);
                    cmd.Parameters.AddWithValue("@LD", LabDate.Value.Date);
                    cmd.Parameters.AddWithValue("@LPass", PasswordTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Laboratorian Saved !!!");
                    con.Close();
                    ShowLab();
                    LabName.Text = "";
                    LabGender.SelectedIndex = -1;
                    Qual.SelectedIndex = -1;
                    Key = 0;
                    LabAdders.Text = "";
                    LabPhone.Text = "";
                    LabDate.Text = "";
                    PasswordTb.Text = "";
                }
                catch(Exception EX)
                {
                    MessageBox.Show(EX.Message);

                }
            }
        }
        int Key = 0; 
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (LabName.Text == "" || LabAdders.Text == "" || LabPhone.Text == "" || LabGender.SelectedIndex == -1 || Qual.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information !!!");

            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update LaboratorianTbl set LabName=@LN,LabGender=@LG,LabAdderss=@LA,LabQual=@LQ,LabPhone=@LP,LabDate=@LD,LabPass=@LPass where LabId=@LKey", con);
                    cmd.Parameters.AddWithValue("@LN", LabName.Text);
                    cmd.Parameters.AddWithValue("@LG", LabGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@LA", LabAdders.Text);
                    cmd.Parameters.AddWithValue("@LQ", Qual.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@LP", LabPhone.Text);
                    cmd.Parameters.AddWithValue("@LD", LabDate.Value.Date);
                    cmd.Parameters.AddWithValue("@LKey", Key);
                    cmd.Parameters.AddWithValue("@LPass", PasswordTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Laboratorian Update !!!");
                    con.Close();
                    ShowLab();
                    LabName.Text = "";
                    LabGender.SelectedIndex = -1;
                    Qual.SelectedIndex = -1;
                    LabAdders.Text = "";
                    LabPhone.Text = "";
                    LabDate.Text = "";
                    Key = 0;
                    PasswordTb.Text = "";

                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);

                }
            }

        }

        private void LabGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LabName.Text = LabGV.SelectedRows[0].Cells[1].Value.ToString();
            LabGender.SelectedItem = LabGV.SelectedRows[0].Cells[2].Value.ToString();
            LabAdders.Text = LabGV.SelectedRows[0].Cells[3].Value.ToString();
            Qual.SelectedItem = LabGV.SelectedRows[0].Cells[4].Value.ToString();
            LabPhone.Text = LabGV.SelectedRows[0].Cells[5].Value.ToString();
            LabDate.Text = LabGV.SelectedRows[0].Cells[6].Value.ToString();
            PasswordTb.Text = LabGV.SelectedRows[0].Cells[7].Value.ToString();
            if (LabName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(LabGV.SelectedRows[0].Cells[0].Value.ToString());
            }


        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Laboratorian ");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from LaboratorianTbl where LabId=@LKey", con);
                    
                    cmd.Parameters.AddWithValue("@LKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Laboratorian Delete !!!");
                    con.Close();
                    ShowLab();
                    LabName.Text = "";
                    LabGender.SelectedIndex = -1;
                    Qual.SelectedIndex = -1;
                    LabAdders.Text = "";
                    LabPhone.Text = "";
                    LabDate.Text = "";
                    Key = 0;
                    PasswordTb.Text = "";

                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);

                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            laboratories Lab = new laboratories();
            this.Hide();
            Lab.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            testAdmin tes = new testAdmin();
            tes.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PatAdmin Pat = new PatAdmin();
            Pat.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            resAdmin res = new resAdmin();
            res.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
