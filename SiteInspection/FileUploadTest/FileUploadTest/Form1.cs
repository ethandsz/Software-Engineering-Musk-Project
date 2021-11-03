using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileUploadTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string destinationFolder = @"C:\Users\Sprite Cranberry\Desktop\SendStuffHere\newCopy.jpg";
            string filename = openFileDialog1.FileName;
            string filepath = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
            Console.WriteLine(filepath);

            try
            {
                File.Copy(filename, destinationFolder, true);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }


            //File.Copy(filepath, destinationFolder);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
