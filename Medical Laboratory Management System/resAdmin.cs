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
using static Bunifu.UI.WinForms.BunifuSnackbar;

namespace Medical_Laboratory_Management_System
{
    public partial class resAdmin : Form
    {
        public resAdmin()
        {
            InitializeComponent();
            ShowResult();
            GetPat();
            GetLab();
            GetTest();
            GetPatName();
            GetTestName();
            GetLabName();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Life's smile\Documents\MedicalLabDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            laboratories Lab = new laboratories();
            this.Hide();
            Lab.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            resAdmin res = new resAdmin();
            res.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PatAdmin Pat = new PatAdmin();
            Pat.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            testAdmin tes = new testAdmin();
            tes.Show();
            this.Hide();
        }

        private void resAdmin_Load(object sender, EventArgs e)
        {
            ShowResult();
            GetPat();
            GetLab();
            GetTest();
            GetPatName();
            GetTestName();
            labDate.Text = DateTime.Today.Date.Day.ToString() + "-" + DateTime.Today.Date.Month.ToString() + "-" + DateTime.Today.Date.Year.ToString();


        }
        private void GetPatName()
        {
            con.Open();
            String quary = "select * from PatientTbl where PatNum=" + PatId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(quary, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatName.Text = dr["PatName"].ToString();
            }
            con.Close();
        }
        int Cost;
        private void GetTestName()
        {
            con.Open();
            String quary = "select * from TestTbl where TestCode=" + TestCode.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(quary, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TestName.Text = dr["TestName"].ToString();
                Cost = Convert.ToInt32(dr["TestCost"].ToString());
            }
            con.Close();
        }
        private void GetLabName()
        {
            con.Open();
            String quary = "select * from LaboratorianTbl where LabId=" + LabId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(quary, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                LabName.Text = dr["LabName"].ToString();
            }
            con.Close();
        }
        private void GetPat()
        {
            con.Open();
            SqlCommand com = new SqlCommand("select PatNum from PatientTbl ", con);
            SqlDataReader sdr;
            sdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatNum", typeof(int));
            dt.Load(sdr);
            PatId.ValueMember = "PatNum";
            PatId.DataSource = dt;


            con.Close();

        }
        private void GetLab()
        {
            con.Open();
            SqlCommand com = new SqlCommand("select LabId from LaboratorianTbl ", con);
            SqlDataReader sdr;
            sdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("LabId", typeof(int));
            dt.Load(sdr);
            LabId.ValueMember = "LabId";
            LabId.DataSource = dt;


            con.Close();

        }
        private void GetTest()
        {
            con.Open();
            SqlCommand com = new SqlCommand("select TestCode from TestTbl ", con);
            SqlDataReader sdr;
            sdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TestCode", typeof(int));
            dt.Load(sdr);
            TestCode.ValueMember = "TestCode";
            TestCode.DataSource = dt;


            con.Close();

        }
        private void ShowResult()
        {
            con.Open();
            String query = "select * from ResultTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ResultGV.DataSource = ds.Tables[0];

            con.Close();

        }

        int Key = 0;
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (LabName.Text == "" || PatName.Text == "" || TestCode.Text == "" || PatId.SelectedIndex == -1 || LabId.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information !!!");

            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ResultTbl(PatId,PatName,laboratorian,LabName,TestDone,ResDate,Test,TestCost) values(@PI,@PN,@Lab,@LN,@TD,@RD,@Test,@TC)", con);
                    cmd.Parameters.AddWithValue("@PN", PatName.Text);
                    cmd.Parameters.AddWithValue("@PI", PatId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Lab", LabId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@LN", LabName.Text);
                    cmd.Parameters.AddWithValue("@TD", Tests.Text);
                    cmd.Parameters.AddWithValue("@RD", Tdate.Value.Date);
                    cmd.Parameters.AddWithValue("@Test", TestCode.Text);
                    cmd.Parameters.AddWithValue("@TC", TestCost.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Result Saved !!!");
                    con.Close();
                    ShowResult();
                    LabName.Text = "";
                    PatId.SelectedIndex = -1;
                    LabId.SelectedIndex = -1;
                    Key = 0;
                    PatName.Text = "";
                    TestCode.SelectedIndex = -1;
                    Restb.SelectedIndex = -1;
                    TestName.Text = "";
                    Tests.Text = "";
                    TestCost.Text = "";

                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);

                }
            }
        }
        String RT = "";
        int costs = 0;
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (LabId.SelectedIndex == -1 || Restb.SelectedIndex == -1)
            {
                MessageBox.Show("select the Test and Result");
            }
            else
            {
                RT = RT + "**" + TestName.Text + ":" + Restb.SelectedItem.ToString();
                Tests.Text = RT;
                costs = costs + Cost;
                TestCost.Text = "" + costs;




            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void PatId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPatName();

        }

        private void LabId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetLabName();

        }

        private void TestCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTestName();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Result ");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ResultTbl where ResNum=@RKey", con);

                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Result Delete !!!");
                    con.Close();
                    ShowResult();
                    LabName.Text = "";
                    LabId.SelectedIndex = -1;
                    PatName.Text = "";
                    PatId.SelectedIndex = -1;
                    TestCode.SelectedIndex = -1;
                    Restb.SelectedIndex = -1;
                    TestName.Text = "";
                    Tests.Text = "";
                    TestCost.Text = "";
                    Key = 0;

                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);

                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ResultGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ResultGV.SelectedRows.Count > 0)
            {
                PatName.Text = ResultGV.SelectedRows[0].Cells[2].Value.ToString();
                PatId.SelectedItem = ResultGV.SelectedRows[0].Cells[1].Value.ToString();
                LabName.Text = ResultGV.SelectedRows[0].Cells[4].Value.ToString();
                LabId.SelectedItem = ResultGV.SelectedRows[0].Cells[3].Value.ToString();


                if (LabName.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(ResultGV.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }
    }
}
