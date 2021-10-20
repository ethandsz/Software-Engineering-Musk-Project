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
    public partial class FillingForm : Form
    {
        public FillingForm()
        {
            InitializeComponent();
        }

        private void FillingForm_Load(object sender, EventArgs e)
        {
            //DataSet workStan = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM form_data_type" +
            //    "WHERE section_id IS 1");
            //dgvWrkstan.DataSource = workStan.Tables[0];
        }
    }
}
