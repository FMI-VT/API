using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary2Interface
{
    public partial class Form1 : Form
    {
        public string imgFile;
        public string OutputFile;
        public string FileFormat;
        public string fileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            int size = -1;
            string path = FD.FileName;
            DialogResult result = FD.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = FD.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
            this.imgFile = FD.FileName;
            this.fileName = FD.SafeFileName;
        
 //           if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
       //     {
//this.fileName = Path.GetFileName(FD.FileName);
       //     }
       //     else
      //      {
      //          this.fileName = Path.GetFileNameWithoutExtension(FD.FileName);
        //    }

            textBox1.Text = imgFile;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = imgFile;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                FileFormat = "PNG";
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                FileFormat = "JPG";
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                FileFormat = "GIF";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                FileFormat = "BMP";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OutputFile = Path.GetDirectoryName(imgFile) + "\\" + Path.GetFileNameWithoutExtension(fileName);
                Class1.ImageConvert(imgFile, OutputFile, FileFormat);
                MessageBox.Show("The photo was converted", "Completed",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();
            form1.Close();
            form2.Show();
        }
    }
}
