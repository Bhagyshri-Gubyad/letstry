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

namespace AirlineReservationSystemCollegeProject
{
    public partial class View_Scheduled_Holiday : Form
    {
        public View_Scheduled_Holiday()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\NewAirlineReservationSystemProject\AirlineReservationSystemCollegeProject\AirlineReservationSystemCollegeProject\Login_Database.mdf;Integrated Security=True");

        private void Populate()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from TblHoliday", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("Hotels Recorded Successfully");
            con.Close();
        }

        private void View_Scheduled_Holiday_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login_DatabaseDataSet3.TblHoliday' table. You can move, or remove it, as needed.
            this.tblHolidayTableAdapter.Fill(this.login_DatabaseDataSet3.TblHoliday);

        }
        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (hidTB.Text != "" && CnameCB.Text != "" && PackageTypeCB.Text != "" && BudgetTB.Text != "" )
            {
                SqlCommand cmd = new SqlCommand("update TblHoliday set holiday_Id=@hid,Country_name=@cname,Package_type=@packtype,Budget=@budget", con);
                con.Open();
                cmd.Parameters.AddWithValue("@hid", hidTB.Text);
                cmd.Parameters.AddWithValue("@cname", CnameCB.Text);
                cmd.Parameters.AddWithValue("@packtype", PackageTypeCB.Text);
                cmd.Parameters.AddWithValue("@budget", BudgetTB.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Flight Details Updated Successfully");
                Populate();

            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");
            }
        }

        //Delete btn
        private void Delete_btn_Click(object sender, EventArgs e)
        {
                if (hidTB.Text == "")
                {
                    MessageBox.Show("Enter the Holiday id to Delete");
                }
                else
                {
                    try
                    {
                        con.Open();
                        string query = "delete from TblHoliday where holiday_Id=" + hidTB.Text + ";";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Holiday Package Deleted Successfully");
                        con.Close();
                        Populate();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }

        //reset btn
        private void Reset_btn_Click(object sender, EventArgs e)
        {
            hidTB.Text = "";
            CnameCB.Text = "";
            PackageTypeCB.Text = "";
            BudgetTB.Text = "";
        }

        //redirect to record new holiday package page
        private void Back_btn_Click(object sender, EventArgs e)
        {
            Record_Holidays_packages H = new Record_Holidays_packages();
            H.Show();
            this.Hide();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            hidTB.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            CnameCB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            PackageTypeCB.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            BudgetTB.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
    }

