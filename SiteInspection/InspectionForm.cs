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
//Tools > NuGet Package Manager > Package Manager Console. Enter this command: Install-Package MySql.Data -Version 8.0.26
using MySql.Data.MySqlClient;

namespace SiteInspection
{
    
    public partial class InspectionForm : Form
    {
        string connStr = Properties.Settings.Default.TestConnectStr;
        public InspectionForm()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(connStr))
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Information", connStr);
                da.Fill(ds, "Information");
                con.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Information";
            }
        }

        private void InspectionForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Information (Site_Location, Date_Created, Completed_By, Supervisor, Inspector, " +
                    "Job_Description, Type_of_Job, Work_Area) VALUES (@Site_Location, @Date_Created, @Completed_By, @Supervisor, @Inspector," +
                    " @Job_Description, @Type_of_Job, @Work_Area)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("Site_Location", txtSite.Text));
                cmd.Parameters.Add(new SqlParameter("Date_Created", dateTimePicker1.Text));
                cmd.Parameters.Add(new SqlParameter("Completed_By", txtCmpltd.Text));
                cmd.Parameters.Add(new SqlParameter("Supervisor", txtSupr.Text));
                cmd.Parameters.Add(new SqlParameter("Inspector", txtInspc.Text));
                cmd.Parameters.Add(new SqlParameter("Job_Description", txtDesc.Text));
                cmd.Parameters.Add(new SqlParameter("Type_of_Job", txtType.Text));
                cmd.Parameters.Add(new SqlParameter("Work_Area", txtWrk_Area.Text));

                cmd.ExecuteNonQuery();

                con.Close();
            }

            clear();

            using (SqlConnection con = new SqlConnection(connStr))
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Information", connStr);
                da.Fill(ds, "Information");
                con.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Information";
            }
        }
        //Method to clear textboxes after user has saved data

        public void clear()
        {
            txtCmpltd.Text = "";
            txtDesc.Text = "";
            txtInspc.Text = "";
            txtSite.Text = "";
            txtSupr.Text = "";
            txtType.Text = "";
            txtWrk_Area.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
