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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
            ShowTest();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Life's smile\Documents\MedicalLabDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowTest()
        {
            con.Open();
            String query = "select * from TestTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TestGV.DataSource = ds.Tables[0];

            con.Close();

        }
        int Key = 0;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (TestName.Text == "" || TestCostTb.Text == "" )
            {
                MessageBox.Show("Missing Information !!!");

            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TestTbl (TestName,TestCost) values(@TN,@TC)", con);
                    cmd.Parameters.AddWithValue("@TN", TestName.Text);
                    cmd.Parameters.AddWithValue("@TC", TestCostTb.Text);
                  
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Saved !!!");
                    con.Close();
                    ShowTest();
                    TestName.Text = "";
                    Key = 0;
                    TestCostTb.Text = "";
                   
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);

                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            if (TestName.Text == "" || TestCostTb.Text == "" )
            {
                MessageBox.Show("Missing Information !!!");

            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update TestTbl set TestName=@TN,TestCost=@TC where TestCode=@TKey", con);
                    cmd.Parameters.AddWithValue("@TN", TestName.Text);
                    cmd.Parameters.AddWithValue("@TC", TestCostTb.Text);
                    
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Update !!!");
                    con.Close();
                    ShowTest();
                    TestName.Text = "";
                    TestCostTb.Text = "";
                    
                    Key = 0;

                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);

                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            if (Key == 0)
            {
                MessageBox.Show("Select the Test ");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from TestTbl where TestCode=@TKey", con);

                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Delete !!!");
                    con.Close();
                    ShowTest();
                    TestName.Text = "";
                    TestCostTb.Text = "";
                    
                    Key = 0;

                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);

                }
            }
        }

        private void TestGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void test_Load(object sender, EventArgs e)
        {
            ShowTest();
            labDate.Text = DateTime.Today.Date.Day.ToString() + "-" + DateTime.Today.Date.Month.ToString() + "-" + DateTime.Today.Date.Year.ToString();

        }

        private void TestGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            TestName.Text = TestGV.SelectedRows[0].Cells[1].Value.ToString();
            TestCostTb.Text = TestGV.SelectedRows[0].Cells[2].Value.ToString();

            if (TestName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(TestGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            test tes = new test();
            this.Hide();
            tes.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Patients Pat = new Patients();
            Pat.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Results Res = new Results();
            this.Hide();
            Res.Show();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();

        }
    }
}
