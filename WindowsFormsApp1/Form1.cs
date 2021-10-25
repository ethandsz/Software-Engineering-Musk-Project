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
    public partial class Home : Form
    {

        public static int form_type_id_var;

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Home_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void homeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.hide();
            //form2 f2 = new form2();
            //f2.showdialog();

            switch (homeComboBox.Text)
            {
                //The other cases are just examples, the combobox doesn't even have them as options
                case "Site Inspection":
                    this.Hide();
                    form_type_id_var = 1;
                    Form2 f2 = new Form2();
                    f2.Show();
                    break;

                case "Hot Works":
                    break;

                case "Confined Space":
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin login");
        }
    }
}
