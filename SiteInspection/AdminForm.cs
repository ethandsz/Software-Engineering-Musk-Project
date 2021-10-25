using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteInspection
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btn_updateGrd_Click(object sender, EventArgs e)
        {
            //Switch case for combo box and what query to display
            showSortByData();
            
        }

        private void dgvViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //If Statement to not create error is user selects a column header
                if (e.RowIndex != -1)
                {
                    //Gets the form_id from a selected row
                    DataGridViewRow dgvRow = dgvViewData.Rows[e.RowIndex];
                    string frm_id = dgvRow.Cells[0].Value.ToString();
                    textBox1.Text = frm_id;
                    //Shows all data associated with a form[Still have to sort by section, didnt have time tonight]
                    string sql_query = string.Format("SELECT interventions,comment,completed,action_taken FROM form_data WHERE form_id = {0}", frm_id);
                    DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(sql_query);
                    dgvViewData.DataSource = ds.Tables[0];
                }
            }
            catch(Exception ex)
            {
                showSortByData();
            }
        }
        public void showSortByData()
        {
            switch (cmbBox_SortBy.Text)
            {
                case "Date [Oldest-Newest]":
                    DataSet ds_oldest_newest = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT form_id AS 'Form #',site_name AS 'Site',cmpltd_by AS 'Completed By',date AS 'Date',work_area AS 'Work Area',job_desc AS 'Job Description',supervisor AS 'Supervisor',inspector AS 'inspector',type AS 'Type' FROM form f ORDER BY date ASC");
                    dgvViewData.DataSource = ds_oldest_newest.Tables[0];
                    break;
                case "Date [Newest-Oldest]":
                    DataSet ds_newest_oldest = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT form_id AS 'Form #',site_name AS 'Site',cmpltd_by AS 'Completed By',date AS 'Date',work_area AS 'Work Area',job_desc AS 'Job Description',supervisor AS 'Supervisor',inspector AS 'inspector',type AS 'Type' FROM form f ORDER BY date DESC");
                    dgvViewData.DataSource = ds_newest_oldest.Tables[0];
                    break;
                case "Site":
                    DataSet ds_site = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT form_id AS 'Form #',site_name AS 'Site',cmpltd_by AS 'Completed By',date AS 'Date',work_area AS 'Work Area',job_desc AS 'Job Description',supervisor AS 'Supervisor',inspector AS 'inspector',type AS 'Type' FROM form f ORDER BY site_name ASC");
                    dgvViewData.DataSource = ds_site.Tables[0];
                    break;
                case "Type":
                    DataSet ds_type = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT form_id AS 'Form #',site_name AS 'Site',cmpltd_by AS 'Completed By',date AS 'Date',work_area AS 'Work Area',job_desc AS 'Job Description',supervisor AS 'Supervisor',inspector AS 'inspector',type AS 'Type' FROM form f ORDER BY type ASC");
                    dgvViewData.DataSource = ds_type.Tables[0];
                    break;
            }
        }
    }
}
