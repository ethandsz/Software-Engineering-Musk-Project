﻿using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

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
            cmbBox_Form.SelectedIndex = 0;
        }
        //Admin Button on click method
        private void admin_login_btn(object sender, EventArgs e)
        {
            MessageBox.Show("Admin Login");
            AdminForm adminform = new AdminForm();
            adminform.Show();
            this.Hide();
            
        }
        //Exit Button on Click method
        private void exit_btn(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //PDFSharp testing
            //Attempting to generate a pdf from initial data in database
            //Current default file path: \ethandsz\Software-Engineering-Musk-Project\SiteInspection\bin\Debug

            PdfDocument doc = new PdfDocument();
            doc.Info.Title = "Site Inspection";

            PdfPage page = doc.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Verdana", 14, XFontStyle.Bold);

            string pdfTitle;
            int form_type = 1;
            string query = String.Format("SELECT form_name FROM form_type WHERE form_type_id = {0}", form_type);
            DataSet get_title = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT form_name FROM form_type WHERE form_type_id = 1");
            pdfTitle = get_title.Tables[0].Rows[0]["form_name"].ToString();

            gfx.DrawString(pdfTitle, font, XBrushes.Black, new XRect(0, 30, page.Width, page.Height), XStringFormats.TopCenter);

            const string filename = "HelloWorld.pdf";
            doc.Save(filename);

            Process.Start(filename);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
