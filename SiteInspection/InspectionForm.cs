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
        //Path to connect to the database
        //Change data source = (Your data source from your computer) and Initial Catalog = (Your created database, unless you used the same name)
        //string path = @"Data Source=DESKTOP-NQL9UQO;Initial Catalog=siteinspection;Integrated Security=True";
        string testConStr = Properties.Settings.Default.TestConnectStr;
        
        //Creating the connection and command objs
        //SqlConnection con;
        SqlConnection testCon = null;
        SqlCommand cmd;
       
        //Variables
        string date;
        public InspectionForm()
        {
            InitializeComponent();
            //Setting the connecting object and passing the path to it
            //con = new SqlConnection(path);
            testCon = new SqlConnection(testConStr);
        }

        private void InspectionForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            date = dateTimePicker1.Text;

            //if (txtCmpltd.Text == "" || txtDesc.Text == "" || txtInspc.Text == "" || txtSite.Text == "" || txtSupr.Text == "" || txtType.Text == "" || txtWrk_Area.Text == "")
            //{
            //    MessageBox.Show("Please fill in all boxes");
            //}
            //else
            //{
                try
                {
                    /*
                    //Opening the connection to the database
                    con.Open();
                    //Saves the data from the textbox to the command object and gets it ready to send to the database. (Change 'Information'
                    //to your created table in the database unless you also used 'Information')
                    cmd = new SqlCommand("insert into Information (Site_Location,Date_Created,Completed_By,Supervisor,Inspector,Job_Description,Type_of_Job,Work_Area)" +
                        " values('" + txtSite.Text + "','" + date + "','" + txtCmpltd.Text + "','" + txtSupr.Text + "','" + txtInspc.Text + "','" + txtDesc.Text + "','"
                        + txtType.Text + "','" + txtWrk_Area.Text + "')", con);
                    //Executes the exchange of information from the form to the database
                    cmd.ExecuteNonQuery();
                    //Closes the connection to the database
                    con.Close();
                    MessageBox.Show("Your data has been saved into the database");
                    clear();
                    fil_form.Show();
                    */

                    testCon.Open();
                    cmd = new SqlCommand("insert into Information (Site_Location,Date_Created,Completed_By,Supervisor,Inspector,Job_Description,Type_of_Job,Work_Area)" +
                        " values('" + txtSite.Text + "','" + date + "','" + txtCmpltd.Text + "','" + txtSupr.Text + "','" + txtInspc.Text + "','" + txtDesc.Text + "','"
                        + txtType.Text + "','" + txtWrk_Area.Text + "')", testCon);
                    cmd.ExecuteNonQuery();
                    testCon.Close();
                    MessageBox.Show("Your data has been saved into the database");
                    clear();
                    FillingForm fil_form = new FillingForm();
                    fil_form.Show();

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            //}

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
