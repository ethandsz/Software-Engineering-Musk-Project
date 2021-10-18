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
    //trying commit
    public partial class Form1 : Form
    {
        
        //Creating InspectionForm as an Object
        InspectionForm insp_frm = new InspectionForm();
        //Selcted Form
        string form;
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
            if (form == "Site Inspection")
            {
                insp_frm.Show();
               // Hide();
            }
            else
            {

            }
            
        }
        //Combo Box Method
        private void cmbBox_Form_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sets form equal to selected combo box item
            form = cmbBox_Form.SelectedItem.ToString();
        }
    }
}
