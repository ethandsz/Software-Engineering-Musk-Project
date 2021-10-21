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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            customizeDesign();
        }
       
        //this method refers to the panelMediaSubmenu that is the panel used to create the submenu
        //the submenu panel is the grey one and contains only the numbers
        // this menu will hide the submenu and it will appear only when you click on the button 
        private void customizeDesign()
        {
            panelWorkingStandardsSubMenu.Visible = false;
            panelQualitySubmenu.Visible = false;
            panelSiteRulesSubmenu.Visible = false;
            panelEnvironmentalSubmenu.Visible = false;
            panelProtectionIndSubmenu.Visible = false;
            panelToolsSubmenu.Visible = false;
            panelMiscellanousSubmenu.Visible = false;
            panelTotalInterventionsSubmenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelWorkingStandardsSubMenu.Visible == true) { 
                
                panelWorkingStandardsSubMenu.Visible = false;
            }

            if(panelQualitySubmenu.Visible == true){

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
            if (panelMiscellanousSubmenu.Visible == true)
            {
                panelMiscellanousSubmenu.Visible = false;
            }
            if (panelTotalInterventionsSubmenu.Visible == true)
            {
                panelTotalInterventionsSubmenu.Visible = false;
            }

        }

        private void showSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;

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

        private void button3_Click(object sender, EventArgs e)
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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void quality6_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siteRulesBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSiteRulesSubmenu);
        }

        private void workingStandards5_Click(object sender, EventArgs e)
        {

        }

        private void workingStandardsBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelWorkingStandardsSubMenu);
        }

        private void workingStandards1_Click(object sender, EventArgs e)
        {
            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void workingStandards2_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void workingStandards3_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void workingStandards4_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void qualityBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQualitySubmenu);
        }

        private void quality7_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void quality8_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void siteRules9_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void siteRules11_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void siteRules12_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void environmentalbtn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEnvironmentalSubmenu);
        }

        private void environmental13_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void environmental14_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void environmental15_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void protectionIndBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProtectionIndSubmenu);
        }

        private void protectionInd16_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void protectionInd17_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void protectionInd18_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void toolsBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubmenu);

        }

        private void tools19_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void tools20_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void tools21_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void miscellanousBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMiscellanousSubmenu);
        }

        private void miscellanous22_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void miscellanous23_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void miscellanous24_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void button26_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTotalInterventionsSubmenu);
        }

        private void workingStandardsA_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void qualityB_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void siteRuleC_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void environmentalD_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void protectionIndE_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void toolsF_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }

        private void miscellanousG_Click(object sender, EventArgs e)
        {

            //here is were we should call the database for the form text
            //code......

            hideSubMenu();
            //after selecting the submenu and the choice, the submenu is gonna disappear again!
        }
    }
}
