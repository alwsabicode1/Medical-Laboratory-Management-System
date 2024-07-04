using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Laboratory_Management_System
{
    public partial class PatAdmin : Form
    {
        public PatAdmin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Life's smile\Documents\MedicalLabDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void PatAdmin_Load(object sender, EventArgs e)
        {
            ShowPat();
            labDate.Text = DateTime.Today.Date.Day.ToString() + "-" + DateTime.Today.Date.Month.ToString() + "-" + DateTime.Today.Date.Year.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void ShowPat()
        {
            con.Open();
            String query = "select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PatGV.DataSource = ds.Tables[0];

            con.Close();

        }
        int Key = 0;
        private void SavePat_Click(object sender, EventArgs e)
        {
            if (PatName.Text == "" || PatAddress.Text == "" || PatPhone.Text == "" || PatGender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information !!!");

            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PatientTbl(PatName,PatGender,PatAdderss,PatPhone,PatDate) values(@PN,@PG,@PA,@PP,@PD)", con);
                    cmd.Parameters.AddWithValue("@PN", PatName.Text);
                    cmd.Parameters.AddWithValue("@PG", PatGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PA", PatAddress.Text);
                    cmd.Parameters.AddWithValue("@PP", PatPhone.Text);
                    cmd.Parameters.AddWithValue("@PD", PatDate.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Saved !!!");
                    con.Close();
                    ShowPat();
                    PatName.Text = "";
                    PatGender.SelectedIndex = -1;
                    Key = 0;
                    PatAddress.Text = "";
                    PatPhone.Text = "";
                    PatDate.Text = "";
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);

                }
            }
        }

        private void EditPat_Click(object sender, EventArgs e)
        {
            if (PatName.Text == "" || PatAddress.Text == "" || PatPhone.Text == "" || PatGender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information !!!");

            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update PatientTbl set PatName=@PN,PatGender=@PG,PatAdderss=@PA,PatPhone=@PP,PatDate=@PD where PatNum=@PKey", con);
                    cmd.Parameters.AddWithValue("@PN", PatName.Text);
                    cmd.Parameters.AddWithValue("@PG", PatGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PA", PatAddress.Text);
                    cmd.Parameters.AddWithValue("@PP", PatPhone.Text);
                    cmd.Parameters.AddWithValue("@PD", PatDate.Value.Date);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Update !!!");
                    con.Close();
                    ShowPat();
                    PatName.Text = "";
                    PatGender.SelectedIndex = -1;
                    PatAddress.Text = "";
                    PatPhone.Text = "";
                    PatDate.Text = "";
                    Key = 0;

                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);

                }
            }
        }

        private void DeletePat_Click(object sender, EventArgs e)
        {

            if (Key == 0)
            {
                MessageBox.Show("Select the Patient ");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from PatientTbl where PatNum=@PKey", con);

                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Delete !!!");
                    con.Close();
                    ShowPat();
                    PatName.Text = "";
                    PatGender.SelectedIndex = -1;
                    PatAddress.Text = "";
                    PatPhone.Text = "";
                    PatDate.Text = "";
                    Key = 0;

                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);

                }
            }
        }

        private void PatGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatName.Text = PatGV.SelectedRows[0].Cells[1].Value.ToString();
            PatGender.SelectedItem = PatGV.SelectedRows[0].Cells[2].Value.ToString();
            PatAddress.Text = PatGV.SelectedRows[0].Cells[3].Value.ToString();
            PatPhone.Text = PatGV.SelectedRows[0].Cells[4].Value.ToString();
            PatDate.Text = PatGV.SelectedRows[0].Cells[5].Value.ToString();
            if (PatName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PatGV.SelectedRows[0].Cells[0].Value.ToString());
            }
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
