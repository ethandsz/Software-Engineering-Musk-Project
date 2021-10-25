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

        private void siteRules12_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void workingStandardsBtn_Click(object sender, EventArgs e)
        {
            showSubmenu(panelWorkingStandardSubmenu);
        }

        private void workingStandards1_Click(object sender, EventArgs e)
        {
            //here goes the code 
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
            label1.Text = "1A";
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

        private void workingStandards2_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
            label1.Text = "1B";
        }

        private void workingStandards3_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void workingStandards4_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void workingStandards5_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void quality6_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void quality7_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void quality8_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void siteRules9_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void siteRules10_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void siteRules11_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void environmental13_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void environmental14_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void environmental15_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void protectionInd16_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void protectionInd17_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void protectionInd18_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void tools19_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void miscellaneous22_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void miscellaneous23_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void miscellaneous24_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void workingStandardsA_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void qualityB_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void siteRulesC_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void environmentalD_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void protectionIndE_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void toolsF_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void miscellaneousG_Click(object sender, EventArgs e)
        {
            // here goes the code
            //maybe database and so on

            //but once you click the number menu, it will disappear from the side menu panel
            hideSubmenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InspectionForm form = new InspectionForm();
            form.Show();
            this.Close();
        }
    }
}
