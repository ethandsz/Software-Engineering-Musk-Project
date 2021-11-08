using System;
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
using PdfSharp.Drawing.Layout;
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
           
            Form2 form2 = new Form2();
            form2.Show();
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
            //PDFSharp testing.
            //Attempting to generate a pdf from initial data in database.
            //Current default file path: \ethandsz\Software-Engineering-Musk-Project\SiteInspection\bin\Debug.
            
            //Initialising the PDFSharp classes and creating the document/pages.
            PdfDocument doc = new PdfDocument();
            doc.Info.Title = "Site Inspection";
            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XTextFormatter tf = new XTextFormatter(gfx);

            //Setting the various fonts.
            XFont titleFont = new XFont("Verdana", 11, XFontStyle.Bold);
            XFont headerFont = new XFont("Verdana", 9, XFontStyle.Bold);
            XFont stdFont = new XFont("Verdana", 7, XFontStyle.Regular);

            //An example of retrieving the title of the inspection form from the form_name table in the database.
            //This can be copied and used for other such retrievals.
            string pdfTitle;
            int form_id_var = 1;
            string query = String.Format("SELECT form_name FROM form_type WHERE form_type_id = {0}", form_id_var);
            pdfTitle = DBConnection.getInstanceOfDBConnection().getScalar(query);
            //Pulling heading titles from database
            string site = String.Format("SELECT site_name FROM form WHERE form_id = {0}", form_id_var);
            site = DBConnection.getInstanceOfDBConnection().getScalar(site);
            string cmplt_by = String.Format("SELECT cmpltd_by FROM form WHERE form_id = {0}", form_id_var);
            cmplt_by = DBConnection.getInstanceOfDBConnection().getScalar(cmplt_by);
            string date = String.Format("SELECT date FROM form WHERE form_id = {0}", form_id_var);
            date = DBConnection.getInstanceOfDBConnection().getScalar(date);
            string work_area = String.Format("SELECT work_area FROM form WHERE form_id = {0}", form_id_var);
            work_area = DBConnection.getInstanceOfDBConnection().getScalar(work_area);
            string job_desc = String.Format("SELECT job_desc FROM form WHERE form_id = {0}", form_id_var);
            job_desc = DBConnection.getInstanceOfDBConnection().getScalar(job_desc);
            string supervisor = String.Format("SELECT supervisor FROM form WHERE form_id = {0}", form_id_var);
            supervisor = DBConnection.getInstanceOfDBConnection().getScalar(supervisor);
            string inspector = String.Format("SELECT inspector FROM form WHERE form_id = {0}", form_id_var);
            inspector = DBConnection.getInstanceOfDBConnection().getScalar(inspector);
            string type = String.Format("SELECT type FROM form WHERE form_id = {0}", form_id_var);
            type = DBConnection.getInstanceOfDBConnection().getScalar(type);
            //Draw the text for the title and headers.
            //Instead of manually entering each title, the strings can be retrieved from the form table headings.
            //Possibly turn this whole block into a for loop to reduce bloat.
            //To have text wrap inside a box, use XTextFormatter. See the "Action Taken" entry below.
            gfx.DrawString(pdfTitle, titleFont, XBrushes.Black, new XRect(0, 36, page.Width, page.Height), XStringFormats.TopCenter);
            gfx.DrawString("Site: " + site, headerFont, XBrushes.Black, 36, 72);
            gfx.DrawString("Completed By: " + cmplt_by, headerFont, XBrushes.Black, 252, 72);
            gfx.DrawString("Date: " + date, headerFont, XBrushes.Black, 468, 72);
            gfx.DrawString("Work Area: " + work_area, headerFont, XBrushes.Black, 36, 94);
            gfx.DrawString("Job Description: " + job_desc, headerFont, XBrushes.Black, 252, 94);
            gfx.DrawString("Supervisor: " + supervisor, headerFont, XBrushes.Black, 36, 115);
            gfx.DrawString("Inspector: " + inspector, headerFont, XBrushes.Black, 252, 115);
            gfx.DrawString("Type: " + type, headerFont, XBrushes.Black, 468, 115);
            gfx.DrawString("Interventions", headerFont, XBrushes.Black, 230, 144);
            gfx.DrawString("Comment", headerFont, XBrushes.Black, 302, 144);
            gfx.DrawString("Completed", headerFont, XBrushes.Black, 454, 144);
            tf.DrawString("Action Taken", headerFont, XBrushes.Black, new XRect(518, 130, 50, 50));

            //Example code for drawing text inside a box
            //XRect rect = new XRect(100, 100, 100, 100);
            //XPen xpen = new XPen(XColors.Black, 0.4);
            //gfx.DrawRectangle(xpen, rect);
            //XStringFormat format = new XStringFormat();
            //format.LineAlignment = XLineAlignment.Near;
            //format.Alignment = XStringAlignment.Near;
            //XBrush brush = XBrushes.Purple;
            //tf.DrawString("Here goes a load of text that should fit into the box blah blah blah blah", new XFont("Helvetica", 8), brush,
            //    new XRect(rect.X + 5, rect.Y, rect.Width, 34), format);

            //Drawing some boxes at the top of the pdf to get coordinates and an idea of how it will look.
            XPen xpen = new XPen(XColors.Black, 0.4);
            gfx.DrawRectangle(xpen, new XRect(36, 158, 192, 18));
            gfx.DrawRectangle(xpen, new XRect(228, 158, 72, 18));
            gfx.DrawRectangle(xpen, new XRect(300, 158, 150, 18));
            gfx.DrawRectangle(xpen, new XRect(450, 158, 60, 18));
            gfx.DrawRectangle(xpen, new XRect(510, 158, 75, 18));

            //Get the number of entries for the selected form, this will be used in a for loop to populate the pdf.
            query = String.Format("SELECT COUNT(*) FROM form_data_type");
            int num_of_entries = Convert.ToInt32(DBConnection.getInstanceOfDBConnection().getScalar(query));

            //Loop for printing text from form_data_type and form_data to the pdf.
            string text;
            int xCoord = 40;
            int yCoord = 170;            
            //Variables to track the section_id within the loop. Compares the current ID to the previous ID.
            //Used to trigger the if statement to print out a section header.
            int prevId = 0;
            int currId = 1;
            for (int i = 1; i < num_of_entries + 1; i++)
            {
                //Prints a section header when triggered.
                if (prevId != currId)
                {
                    query = String.Format("SELECT section_name FROM section WHERE section_id = {0}", currId);
                    text = DBConnection.getInstanceOfDBConnection().getScalar(query);
                    gfx.DrawString(text, headerFont, XBrushes.Black, xCoord, yCoord);

                    yCoord += 20;
                    prevId = currId;
                }

                query = String.Format("SELECT data_type_name FROM form_data_type WHERE form_data_type_id = {0}", i);
                text = DBConnection.getInstanceOfDBConnection().getScalar(query);
                gfx.DrawString(text, stdFont, XBrushes.Black, xCoord, yCoord);

                query = String.Format("SELECT interventions FROM form_data WHERE form_data_type_id = {0}", i);
                text = DBConnection.getInstanceOfDBConnection().getScalar(query);
                gfx.DrawString(text, stdFont, XBrushes.Black, xCoord + 220, yCoord);

                query = String.Format("SELECT comment FROM form_data WHERE form_data_type_id = {0}", i);
                text = DBConnection.getInstanceOfDBConnection().getScalar(query);
                gfx.DrawString(text, stdFont, XBrushes.Black, xCoord + 263, yCoord);

                query = String.Format("SELECT completed FROM form_data WHERE form_data_type_id = {0}", i);
                text = DBConnection.getInstanceOfDBConnection().getScalar(query);
                gfx.DrawString(text, stdFont, XBrushes.Black, xCoord + 430, yCoord);

                query = String.Format("SELECT action_taken FROM form_data WHERE form_data_type_id = {0}", i);
                text = DBConnection.getInstanceOfDBConnection().getScalar(query);
                gfx.DrawString(text, stdFont, XBrushes.Black, xCoord + 470, yCoord);

                //Get the current section_id, eventually it will be different to the prevID and trigger the header printing statement.
                query = String.Format("SELECT section_id FROM form_data_type WHERE form_data_type_id = {0}", i);
                currId = Convert.ToInt32(DBConnection.getInstanceOfDBConnection().getScalar(query));
                    
                yCoord += 20;
            }

            //Name of the pdf document.
            //Could use a for loop to create the name or even retrieve the form_id from the form table.
            const string filename = "HelloWorld.pdf";
            doc.Save(filename);

            //Opens a process to view the pdf, this is mainly here for debugging.
            Process.Start(filename);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
