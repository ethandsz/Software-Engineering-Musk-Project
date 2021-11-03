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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void uploadPic1_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog pic = new OpenFileDialog();
                pic.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All Files(*.*)|*.*";
                if (pic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = pic.FileName;
                    image1.ImageLocation = imageLocation;
                }
            }
            catch
            {
                MessageBox.Show("An error occurred!", "Error", MessageBoxButtons.OK);
            }

        }
    }
}
