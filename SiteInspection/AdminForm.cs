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
            switch (cmbBox_SortBy.Text)
            {
                case "Date [Oldest-Newest]":
                    DataSet ds_oldest_newest = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM form f ORDER BY date ASC");
                    dgvViewData.DataSource = ds_oldest_newest.Tables[0];
                    break;
                case "Date [Newest-Oldest]":
                    DataSet ds_newest_oldest = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM form f ORDER BY date DESC");
                    dgvViewData.DataSource = ds_newest_oldest.Tables[0];
                    break;
                case "Site":
                    DataSet ds_site = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM form f ORDER BY site_name ASC");
                    dgvViewData.DataSource = ds_site.Tables[0];
                    break;
                case "Type":
                    DataSet ds_type = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM form f ORDER BY type ASC");
                    dgvViewData.DataSource = ds_type.Tables[0];
                    break;
            }
        }

        
    }
}
