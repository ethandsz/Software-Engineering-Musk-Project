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
    public partial class Form3 : Form
    {

        string form_data_type_id;
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
            showSubmenu(panelWorkingStandardSubmenu);
        }

        private void qualityBtn_Click(object sender, EventArgs e)
        {
            showSubmenu(panelQualitySubmenu);
        }

        private void siteRulesBtn_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSiteRulesSubmenu);
        }

        private void environmentalBtn_Click(object sender, EventArgs e)
        {
            showSubmenu(panelEnvironmentalSubmenu);
        }

        private void protectionIndBtn_Click(object sender, EventArgs e)
        {
            showSubmenu(panelProtectionIndSubmenu);
        }

        private void toolsBtn_Click(object sender, EventArgs e)
        {
            showSubmenu(panelToolsSubmenu);
        }

        private void miscellaneousBtn_Click(object sender, EventArgs e)
        {
            showSubmenu(panelMiscellaneousSubmenu);
        }

        private void totalInterventionsBtn_Click(object sender, EventArgs e)
        {
            showSubmenu(panelTotalInterventionsSubmenu);
        }

        //
        //Section buttons
        //
        private void workingStandards1_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            //Method to set various variables to the section number for later reference
            setVars("1");
        }

        private void workingStandards2_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("2");
        }

        private void workingStandards3_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("3");
        }

        private void workingStandards4_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("4");
        }

        private void workingStandards5_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("5");
        }

        private void quality6_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("6");
        }

        private void quality7_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("7");
        }

        private void quality8_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("8");
        }

        private void siteRules9_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("9");
        }

        private void siteRules10_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("10");
        }

        private void siteRules11_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("11");
        }

        private void siteRules12_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("12");
        }

        private void environmental13_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("13");
        }

        private void environmental14_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("14");
        }

        private void environmental15_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("15");
        }

        private void protectionInd16_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("16");
        }

        private void protectionInd17_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("17");
        }

        private void protectionInd18_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("18");
        }

        private void tools19_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("19");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("20");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("21");
        }

        private void miscellaneous22_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("22");
        }

        private void miscellaneous23_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("23");
        }

        private void miscellaneous24_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            setVars("24");
        }

        private void workingStandardsA_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void qualityB_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void siteRulesC_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void environmentalD_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void protectionIndE_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void toolsF_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void miscellaneousG_Click(object sender, EventArgs e)
        {            
            hideSubmenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn(object sender, EventArgs e)
        {
            InspectionForm form = new InspectionForm();
            form.Show();
            this.Close();
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
            string query = string.Format("SELECT interventions,comment,completed,action_taken FROM form_data WHERE form_id = {0} AND form_data_type_id = {1}", get_latest_form_id(), num);
            return query;
        }

        //For efficiency/Less code 
        public void populate_dgv(string num)
        {
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(data_query(num));
            dataGrd.DataSource = ds.Tables[0];
            //
            textBox4.Text = populate_txtBox(0);
            textBox3.Text = populate_txtBox(1);
            textBox2.Text = populate_txtBox(2);
            textBox1.Text = populate_txtBox(3);
        }

        private void add_btn(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO form_data (form_data_type_id, form_id, interventions, comment, completed, action_taken)" +
                " VALUES (@form_data_type_id, @form_id, @interventions, @comment, @completed, @action_taken)";
            DBConnection.getInstanceOfDBConnection().saveToDB2(sqlQuery, form_data_type_id, get_latest_form_id(), textBox4.Text, textBox3.Text, textBox2.Text,
                textBox1.Text);

            populate_dgv(form_data_type_id);
            populate_currentDgv();

            //clearTxtBox();
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
            //clearTxtBox();
            //string sqlQuery = string.Format("SELECT form_id,fd_t.form_data_type_id,interventions,comment,completed,action_taken,data_type_name FROM form_data fd RIGHT JOIN form_data_type fd_t ON(fd_t.form_data_type_id = fd.form_data_type_id) WHERE form_id = {0} ORDER BY fd_t.form_data_type_id",get_latest_form_id());
            //DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet(sqlQuery);
            //dataGridView1.DataSource = ds.Tables[0];
        }
        public void populate_currentDgv()
        {
            string sqlQuery = string.Format("SELECT form_id,fd_t.form_data_type_id,interventions,comment,completed,action_taken,data_type_name FROM form_data fd RIGHT JOIN form_data_type fd_t ON(fd_t.form_data_type_id = fd.form_data_type_id) WHERE form_id = {0} ORDER BY fd_t.form_data_type_id", get_latest_form_id());
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
            //This will be where the code to commit all interventions from form_data table to a pdf document will go
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

            Form4 newForm = new Form4();

            newForm.Show();
            this.Hide();

        }
    }
}
