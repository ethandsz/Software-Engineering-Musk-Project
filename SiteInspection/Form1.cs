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
    public partial class Form1 : Form
    {
        
        //Selcted Form
        string form;
        //Form type variable, change it in the switch statement depending on which form is selected
        public static int form_type_id_var;
        public Form1()
        {
            InitializeComponent();
        }
        //Admin Button on click method
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin Login");
            
        }
        //Exit Button on Click method
        private void button3_Click(object sender, EventArgs e)
        {
            //Exits Environment/Quits Program
            Environment.Exit(0);
        }

        private void btn_CreateForm_Click(object sender, EventArgs e)
        {

            switch (cmbBox_Form.Text)
            {
                //The other cases are just examples, the combobox doesn't even have them as options
                case "Site Inspection":
                    this.Hide();
                    form_type_id_var = 1;
                    InspectionForm insp_frm = new InspectionForm();
                    insp_frm.Show();
                    break;

                case "Hot Works":
                    break;

                case "Confined Space":
                    break;
            }
            
        }
        //Combo Box Method
        private void cmbBox_Form_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sets form equal to selected combo box item
            form = cmbBox_Form.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT data_type_name FROM form_data_type WHERE section_id = 1");
            dgvForm_type.DataSource = ds.Tables[0];
        }

        private void dgvForm_type_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
