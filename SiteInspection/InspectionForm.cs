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
               
        //Variables
        
        public InspectionForm()
        {
            InitializeComponent();
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM form");
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void InspectionForm_Load(object sender, EventArgs e)
        {
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM form_data_type WHERE section_id = 1");
            //dgvForm_type.DataSource = ds.Tables[0];
        }

        private void continue_btn(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO form (form_type_id, site_name, cmpltd_by, date, work_area, job_desc, " +
                    "supervisor, inspector, type) VALUES (@form_type_id, @site_name, @cmpltd_by, @date, @work_area, @job_desc," +
                    " @supervisor, @inspector, @type)";

            //This saves the form data to the database. There has to be a way of reducing the amount of parameters!
            DBConnection.getInstanceOfDBConnection().saveToDB(sqlQuery, Form1.form_type_id_var, txtSite.Text, txtCmpltd.Text, convert_date(dateTimePicker1.Text), 
                txtWrk_Area.Text, txtDesc.Text, txtSupr.Text, txtInspc.Text, txtType.Text);

            //Display the database to the datagridview, this is just for debugging and making sure the database has been updated
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM form");
            dataGridView1.DataSource = ds.Tables[0];

            clear();
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
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
        public static string convert_date(string date)
        {
            string converted_date = date;
            if (date.StartsWith("0") || date.StartsWith("1") || date.StartsWith("2") || date.StartsWith("3"))
            {
                int find = date.IndexOf(" ");
                string day = date.Substring(0, find);
                date = date.Substring(find + 1);
                System.Console.WriteLine(date);
                find = date.IndexOf(" ");
                string month = date.Substring(0, find);
                switch (month)
                {
                    case "January":
                        month = "01";
                        break;

                    case "Febuary":
                        month = "02";
                        break;

                    case "March":
                        month = "03";
                        break;

                    case "April":
                        month = "04";
                        break;

                    case "May":
                        month = "05";
                        break;

                    case "June":
                        month = "06";
                        break;

                    case "July":
                        month = "07";
                        break;

                    case "August":
                        month = "08";
                        break;

                    case "September":
                        month = "09";
                        break;

                    case "October":
                        month = "10";
                        break;

                    case "November":
                        month = "11";
                        break;

                    case "December":
                        month = "12";
                        break;
                }
                date = date.Substring(find + 1);
                System.Console.WriteLine(date);
                //find = date.IndexOf(" ");
                string year = date;
                converted_date = year + "-" + month + "-" + day;
            }
            else
            {
                int find = 0;
                find = date.IndexOf(",");
                date = (date.Substring(find + 2));
                find = date.IndexOf(" ");
                string month = date.Substring(0, find);
                switch (month)
                {
                    case "January":
                        converted_date = "01";
                        break;

                    case "Febuary":
                        converted_date = "02";
                        break;

                    case "March":
                        converted_date = "03";
                        break;

                    case "April":
                        converted_date = "04";
                        break;

                    case "May":
                        converted_date = "05";
                        break;

                    case "June":
                        converted_date = "06";
                        break;

                    case "July":
                        converted_date = "07";
                        break;

                    case "August":
                        converted_date = "08";
                        break;

                    case "September":
                        converted_date = "09";
                        break;

                    case "October":
                        converted_date = "10";
                        break;

                    case "November":
                        converted_date = "11";
                        break;

                    case "December":
                        converted_date = "12";
                        break;
                }
                date = date.Substring(find + 1);
                find = date.IndexOf(",");
                string day = date.Substring(0, find);
                if (day.Length == 1)
                {
                    day = "0" + day;
                }
                converted_date = (converted_date + "-" + day);
                date = date.Substring(find + 2);
                converted_date = date + "-" + converted_date;
            }
            return converted_date;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void exit_btn(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void txtCmpltd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWrk_Area_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
