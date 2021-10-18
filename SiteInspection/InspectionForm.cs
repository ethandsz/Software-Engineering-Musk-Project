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

namespace SiteInspection
{
    
    public partial class InspectionForm : Form
    {
        FillingForm fil_form = new FillingForm();
        //Path to connect to the database
        string path = @"Data Source=DESKTOP-NQL9UQO;Initial Catalog=siteinspection;Integrated Security=True";//Change data source = (Your data source from your computer) and Initial Catalog = (Your created database, unless you used the same name)
        
        //Creating the connection and command objs
        SqlConnection con;
        SqlCommand cmd;
       
        //Variables
        string date;
        public InspectionForm()
        {
            InitializeComponent();
            con = new SqlConnection(path); //Setting the connecting object and passing the path to it            
        }

        private void InspectionForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            date = dateTimePicker1.Text;

            if (txtCmpltd.Text == "" || txtDesc.Text == "" || txtInspc.Text == "" || txtSite.Text == "" || txtSupr.Text == "" || txtType.Text == "" || txtWrk_Area.Text == "")
            {
                MessageBox.Show("Please fill in all boxes");
            }
            else
            {
                try
                {
                    con.Open(); //Opening the connection to the database
                    cmd = new SqlCommand("insert into Information (Site_Location,Date_Created,Completed_By,Supervisor,Inspector,Job_Description,Type_of_Job,Work_Area) values('" + txtSite.Text + "','" + date + "','" + txtCmpltd.Text + "','" + txtSupr.Text + "','" + txtInspc.Text + "','" + txtDesc.Text + "','" + txtType.Text + "','" + txtWrk_Area.Text + "')", con); //Saves the data from the textbox to the command object and gets it ready to send to the database. (Change 'Information' to your created table in the database unless you also used 'Information')
                    cmd.ExecuteNonQuery(); //Executes the exchange of information from the form to the database
                    con.Close(); //Closes the connection to the database
                    MessageBox.Show("Your data has been saved into the database");
                    clear();
                    fil_form.Show();

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
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
    }
}
