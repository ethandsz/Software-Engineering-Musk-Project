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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Enter button click method
        private void button1_Click(object sender, EventArgs e)
        {
            //This is hardcoded at the moment, put it in the db for easy editing
            string adminPass = "opensesame";

            //Checks if the text entered by the user in the text box is the same as the hardcoded admin password above
            string userPassInput = UserPassField.Text;
            //If the password is correct, the admin form is shown
            if(userPassInput == adminPass)
            {
                AdminForm adminform = new AdminForm();
                adminform.Show();
                this.Hide();
            }
            //If the password is incorrect, a messagebox is shown and the user can try again
            else
            {
                MessageBox.Show("Incorrect password.");
            }
        }

        //Back button click method
        private void button2_Click(object sender, EventArgs e)
        {
            //The user is taken back to the home page
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
