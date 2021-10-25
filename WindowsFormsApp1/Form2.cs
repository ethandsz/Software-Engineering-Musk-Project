using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Form3 f3 = new Form3();
        
        //Variables
        string sqlQuery = "INSERT INTO form (form_type_id, site_name, cmpltd_by, date, work_area, job_desc, " +
                    "supervisor, inspector, type) VALUES (@form_type_id, @site_name, @cmpltd_by, @date, @work_area, @job_desc," +
                    " @supervisor, @inspector, @type)";
        public Form2()
        {
            InitializeComponent();
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM form");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home form1 = new Home();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form3 f3 = new Form3();
            //f3.ShowDialog();

            //This saves the form data to the database. There has to be a way of reducing the amount of parameters!
            DBConnection.getInstanceOfDBConnection().saveToDB(sqlQuery, Home.form_type_id_var, textBox1.Text, textBox8.Text, dateTimePicker1.Text,
                textBox6.Text, textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text);

            //Display the database to the datagridview, this is just for debugging and making sure the database has been updated
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM form");
            dataGridView1.DataSource = ds.Tables[0];

            clear();
        }
        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
