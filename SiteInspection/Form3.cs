using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System.Windows.Forms;
using System.IO;

namespace SiteInspection
{
    public partial class Form3 : Form
    {

        string form_data_type_id;

        Form1 f1 = new Form1();
        public Form3()
        {
            InitializeComponent();
            //hide submenu
            customizeDesign();
        }

        // this method will hide the submenu
        private void customizeDesign()
        {
            panelWorkingStandardSubmenu.Visible = false;
            panelQualitySubmenu.Visible = false;
            panelSiteRulesSubmenu.Visible = false;
            panelEnvironmentalSubmenu.Visible = false;
            panelProtectionIndSubmenu.Visible = false;
            panelToolsSubmenu.Visible = false;
            panelMiscellaneousSubmenu.Visible = false;
            panelTotalInterventionsSubmenu.Visible = false;
        }
        // this method will hide the submenu that was already shown
        private void hideSubmenu()
        {
            if (panelWorkingStandardSubmenu.Visible == true)
            {
                panelWorkingStandardSubmenu.Visible = false;
            }
            if (panelQualitySubmenu.Visible == true)
            {
                panelQualitySubmenu.Visible = false;
            }
            if (panelSiteRulesSubmenu.Visible == true)
            {
                panelSiteRulesSubmenu.Visible = false;
            }
            if (panelEnvironmentalSubmenu.Visible == true)
            {
                panelEnvironmentalSubmenu.Visible = false;
            }
            if (panelProtectionIndSubmenu.Visible == true)
            {
                panelProtectionIndSubmenu.Visible = false;
            }
            if (panelToolsSubmenu.Visible == true)
            {
                panelToolsSubmenu.Visible = false;
            }
            if (panelMiscellaneousSubmenu.Visible == true)
            {
                panelMiscellaneousSubmenu.Visible = false;
            }
            if (panelTotalInterventionsSubmenu.Visible == true)
            {
                panelTotalInterventionsSubmenu.Visible = false;
            }
        }
        //display the submenu
        //all the submenus are panel therefore panel can be a parameter
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //we hide submenu
                hideSubmenu();
                //we show submenu
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ettodeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void workingStndBtm_Click(object sender, EventArgs e)
        {

        }

        private void panelMainForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        //
        //Heading buttons
        //
        private void workingStandardsBtn_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt("Working Standards Button used");
            showSubmenu(panelWorkingStandardSubmenu);
        }

        private void qualityBtn_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt("Quality Button used");
            showSubmenu(panelQualitySubmenu);
        }

        private void siteRulesBtn_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt("Site Rules button used");
            showSubmenu(panelSiteRulesSubmenu);
        }

        private void environmentalBtn_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt("Environmental button used");
            showSubmenu(panelEnvironmentalSubmenu);
        }

        private void protectionIndBtn_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt("Protection of Individuals button used");
            showSubmenu(panelProtectionIndSubmenu);
        }

        private void toolsBtn_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt("Tools Button used");
            showSubmenu(panelToolsSubmenu);
        }

        private void miscellaneousBtn_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt("Muscellaneous Button used");
            showSubmenu(panelMiscellaneousSubmenu);
        }

        private void totalInterventionsBtn_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt("Total Interventions Button used");
            showSubmenu(panelTotalInterventionsSubmenu);
        }

        //
        //Section buttons
        //
        private void workingStandards1_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(workingStandards1.Text.ToString() + " Clicked");
            hideSubmenu();
            //Method to set various variables to the section number for later reference
            setVars("1");
        }

        private void workingStandards2_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(workingStandards2.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("2");
        }

        private void workingStandards3_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(workingStandards3.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("3");
        }

        private void workingStandards4_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(workingStandards4.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("4");
        }

        private void workingStandards5_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(workingStandards5.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("5");
        }

        private void quality6_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(quality6.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("6");
        }

        private void quality7_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(quality7.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("7");
        }

        private void quality8_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(quality8.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("8");
        }

        private void siteRules9_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(siteRules9.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("9");
        }

        private void siteRules10_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(siteRules10.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("10");
        }

        private void siteRules11_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(siteRules11.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("11");
        }

        private void siteRules12_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(siteRules12.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("12");
        }

        private void environmental13_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(environmental13.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("13");
        }

        private void environmental14_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(environmental14.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("14");
        }

        private void environmental15_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(environmental15.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("15");
        }

        private void protectionInd16_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(protectionInd16.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("16");
        }

        private void protectionInd17_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(protectionInd17.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("17");
        }

        private void protectionInd18_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(protectionInd18.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("18");
        }

        private void tools19_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(tools19.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("19");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            logbook._Instance.wrt(button3.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("20");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            logbook._Instance.wrt(button4.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("21");
        }

        private void miscellaneous22_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(miscellaneous22.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("22");
        }

        private void miscellaneous23_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(miscellaneous23.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("23");
        }

        private void miscellaneous24_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(miscellaneous24.Text.ToString() + " Clicked");
            hideSubmenu();
            setVars("24");
        }

        private void workingStandardsA_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(workingStandardsA.Text.ToString() + " Clicked");
            hideSubmenu();
        }

        private void qualityB_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(qualityB.Text.ToString() + " Clicked");
            hideSubmenu();
        }

        private void siteRulesC_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(siteRulesC.Text.ToString() + " Clicked");
            hideSubmenu();
        }

        private void environmentalD_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(environmentalD.Text.ToString() + " Clicked");
            hideSubmenu();
        }

        private void protectionIndE_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(protectionIndE.Text.ToString() + " Clicked");
            hideSubmenu();
        }

        private void toolsF_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(toolsF.Text.ToString() + " Clicked");
            hideSubmenu();
        }

        private void miscellaneousG_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt(miscellaneousG.Text.ToString() + " Clicked");
            hideSubmenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn(object sender, EventArgs e)
        {
            logbook._Instance.wrt("Exited Form 3");
            InspectionForm form = new InspectionForm();
            form.Show();
            this.Close();
        }

        private void dataGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void section_label(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            logbook._Instance.wrt("Browse Files button Clicked");
            using (OpenFileDialog pic = new OpenFileDialog())
            {
                pic.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All Files(*.*)|*.*";
                if (pic.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(pic.FileName);
                    textBox5.Text = pic.FileName;

                    DBConnection.getInstanceOfDBConnection().LoadImage();
                }

            }
        }

        private void interv_txt(object sender, EventArgs e)
        {

        }

        private void comment_txt(object sender, EventArgs e)
        {

        }

        private void completed_txt(object sender, EventArgs e)
        {

        }

        private void action_text(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            logbook._Instance.wrt("Form 3 Save as PDF button Clicked");
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
            //int form_id_var = 1;
            try
            {
                int form_id_var = Convert.ToInt32(get_latest_form_id());

                string query = String.Format("SELECT form_name FROM form_type WHERE form_type_id = {0}", form_id_var);
                pdfTitle = DBConnection.getInstanceOfDBConnection().getScalar(query);
                //Pulling heading titles from database
                string site = form_headers("site_name", form_id_var);
                string cmplt_by = form_headers("cmpltd_by", form_id_var);
                string date = form_headers("date", form_id_var);
                string work_area = form_headers("work_area", form_id_var);
                string job_desc = form_headers("job_desc", form_id_var);
                string supervisor = form_headers("supervisor", form_id_var);
                string inspector = form_headers("inspector", form_id_var);
                string type = form_headers("type", form_id_var);
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
                gfx.DrawString("Completed", headerFont, XBrushes.Black, 434, 144);
                tf.DrawString("Action Taken", headerFont, XBrushes.Black, new XRect(498, 130, 50, 50));
                gfx.DrawString("Image", headerFont, XBrushes.Black, 543, 144);

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
                gfx.DrawRectangle(xpen, new XRect(300, 158, 130, 18));
                gfx.DrawRectangle(xpen, new XRect(430, 158, 60, 18));
                gfx.DrawRectangle(xpen, new XRect(490, 158, 50, 18));
                gfx.DrawRectangle(xpen, new XRect(540, 158, 40, 18));

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

                    query = String.Format("SELECT interventions FROM form_data WHERE form_data_type_id = {0} AND form_id = {1}", i, form_id_var);
                    text = DBConnection.getInstanceOfDBConnection().getScalar(query);
                    if (text.Equals("")) { text = "0"; }
                    gfx.DrawString(text, stdFont, XBrushes.Black, xCoord + 220, yCoord);

                    query = String.Format("SELECT comment FROM form_data WHERE form_data_type_id = {0} AND form_id = {1}", i, form_id_var);
                    text = DBConnection.getInstanceOfDBConnection().getScalar(query);
                    gfx.DrawString(text, stdFont, XBrushes.Black, xCoord + 263, yCoord);

                    query = String.Format("SELECT completed FROM form_data WHERE form_data_type_id = {0} AND form_id = {1}", i, form_id_var);
                    text = DBConnection.getInstanceOfDBConnection().getScalar(query);
                    gfx.DrawString(text, stdFont, XBrushes.Black, xCoord + 410, yCoord);

                    query = String.Format("SELECT action_taken FROM form_data WHERE form_data_type_id = {0} AND form_id = {1}", i, form_id_var);
                    text = DBConnection.getInstanceOfDBConnection().getScalar(query);
                    gfx.DrawString(text, stdFont, XBrushes.Black, xCoord + 450, yCoord);

                    //Check if an image is present, if it is, create a link to it.
                    //I literally cannot figure out a way to create a link through the pdf document. 
                    //It'll be easier to view images via the admin login screen, which incidentally is what is already implemented in Musk's current software.
                    //query = String.Format("SELECT file_name FROM form_data WHERE form_data_type_id = {0} AND form_id = {1}", i, form_id_var);
                    //imgCheck = DBConnection.getInstanceOfDBConnection().getScalar(query);
                    //if (imgCheck.Length > 3)
                    //{
                    //    gfx.DrawString("view", stdFont, XBrushes.Black, xCoord + 510, yCoord);
                    //}

                    //Get the current section_id, eventually it will be different to the prevID and trigger the header printing statement.
                    query = String.Format("SELECT section_id FROM form_data_type WHERE form_data_type_id = {0}", i);
                    currId = Convert.ToInt32(DBConnection.getInstanceOfDBConnection().getScalar(query));

                    yCoord += 20;
                    //IMAGE SAVING
                    query = String.Format("SELECT file_name from form_data WHERE form_id = {0} AND form_data_type_id = {1}", form_id_var, i);
                    text = (DBConnection.getInstanceOfDBConnection().getScalar(query)).ToString();
                    MessageBox.Show(text);
                    //Check text
                    if (text.Length > 3)
                    {
                        Uri best = new Uri(text);
                        var xrect = new XRect(xCoord + 470, yCoord, 100, 100);
                        var rect = gfx.Transformer.WorldToDefaultPage(xrect);
                        var pdfrect = new PdfRectangle(rect);
                        page.AddWebLink(pdfrect, best.AbsoluteUri);
                        gfx.DrawString("MYFILE", titleFont, XBrushes.Black, xrect, XStringFormats.TopLeft);
                    }

                }

                //Name of the pdf document.
                //Could use a for loop to create the name or even retrieve the form_id from the form table.
                string filename = "SiteInspection" + get_latest_form_id() + ".pdf";
                doc.Save(filename);
                MessageBox.Show("Inspection form saved as: " + filename);

                //Opens a process to view the pdf, this is mainly here for debugging.
                //Process.Start(filename);

                this.Close();
                f1.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void add_btn(object sender, EventArgs e)
        {
            logbook._Instance.wrt("Form 3 Add button Clicked");
            byte[] picture = { };

            if (!string.IsNullOrEmpty(value: textBox5.Text))
            {
               
                picture = DBConnection.ConvertImageByte(pictureBox.Image);
                string sqlQuery = "INSERT INTO form_data (form_data_type_id, form_id, interventions, comment, completed, action_taken, file_name, image)" +
                    " VALUES (@form_data_type_id, @form_id, @interventions, @comment, @completed, @action_taken, @file_name, @image)";
                DBConnection.getInstanceOfDBConnection().saveToDB2(sqlQuery, form_data_type_id, get_latest_form_id(), textBox4.Text, textBox3.Text, textBox2.Text,
                    textBox1.Text, textBox5.Text, picture);
                
            }
            else
            {
                string Query = "INSERT INTO form_data (form_data_type_id, form_id, interventions, comment, completed, action_taken, file_name, image)" +
                  " VALUES (@form_data_type_id, @form_id, @interventions, @comment, @completed, @action_taken, @file_name, @image)";
                DBConnection.getInstanceOfDBConnection().saveToDB2(Query, form_data_type_id, get_latest_form_id(), textBox4.Text, textBox3.Text, textBox2.Text,
                    textBox1.Text, textBox5.Text, picture);
            }




            populate_dgv(form_data_type_id);
            populate_currentDgv();

            //clearTxtBox();
        }

        //Methods
        //
        //Method for getting the most latest(user_created) form
        public string get_latest_form_id()
        {
            DataSet get_id = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT TOP 1 form_id FROM form ORDER BY form_id DESC");
            int f1 = Convert.ToInt32(get_id.Tables[0].Rows[0]["form_id"]);
            string sql_form_id = f1.ToString();
            return sql_form_id;
        }
        
        //Method for making a query coressponding to each button, change get_latest_form_id() to "1" to see how its supposed to work with a actual form
        public string data_query(string num)
        {
            string query = string.Format("SELECT interventions,comment,completed,action_taken, file_name, image  FROM form_data WHERE form_id = {0} AND form_data_type_id = {1}", get_latest_form_id(), num);
            return query;
        }

        //For efficiency/Less code 
        public void populate_dgv(string num)
        {
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(data_query(num));
            dataGrd.DataSource = ds.Tables[0];
            dataGridView2.DataSource = ds.Tables[0];
            //

            textBox4.Text = populate_txtBox(0);
            textBox3.Text = populate_txtBox(1);
            textBox2.Text = populate_txtBox(2);
            textBox1.Text = populate_txtBox(3);
        }


        //Each time a button is pressed this method is called
        //Variables used in sqlQueries to call from the corresponding sections
        //Populates the datagridview
        //Clears textboxes
        public void setVars(string num)
        {
            form_data_type_id = num;
            label1.Text = num;
            populate_dgv(num);
            pictureBox.Image = null;
            textBox5.Text = "";
            //clearTxtBox();
            //string sqlQuery = string.Format("SELECT form_id,fd_t.form_data_type_id,interventions,comment,completed,action_taken,data_type_name FROM form_data fd RIGHT JOIN form_data_type fd_t ON(fd_t.form_data_type_id = fd.form_data_type_id) WHERE form_id = {0} ORDER BY fd_t.form_data_type_id",get_latest_form_id());
            //DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(sqlQuery);
            //dataGridView1.DataSource = ds.Tables[0];
        }
        public void populate_currentDgv()
        {
            string sqlQuery = string.Format("SELECT form_id,fd_t.form_data_type_id,interventions,comment,completed,action_taken,file_name, image, data_type_name FROM form_data fd RIGHT JOIN form_data_type fd_t ON(fd_t.form_data_type_id = fd.form_data_type_id) WHERE form_id = {0} ORDER BY fd_t.form_data_type_id", get_latest_form_id());
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(sqlQuery);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public void clearTxtBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        public string populate_txtBox(int column_num)
        {
            string s = "";
            //dataGrd.Rows[0].Cells[column_num].Value.ToString()
            if(dataGrd.Rows[0].Cells[column_num].Value == null)
            {
                s = "";
            }
            else
            {
                s = dataGrd.Rows[0].Cells[column_num].Value.ToString();
            }
            //MessageBox.Show(s);
            return s;
        }

        public string form_headers(string data, int form_id)
        {
            try
            {
                string name = String.Format("SELECT {0} FROM form WHERE form_id = {1}", data, form_id);
                return name = DBConnection.getInstanceOfDBConnection().getScalar(name);
            }
            catch (System.NullReferenceException)
            {
                return "";
            }
            return "";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
