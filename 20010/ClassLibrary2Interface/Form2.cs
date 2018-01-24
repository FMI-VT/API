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
    public partial class Form2 : Form
    {
        public string imgFile;
        public string OutputFile;
        public string FileFormat;
        public string fileName;
        public int newWidth;
        public int newHeight;
        public double scaleFactor;

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = imgFile;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int width;
            bool isInt = int.TryParse(textBox2.Text, out width);

            if (isInt)
            {
                this.newWidth = width;
            }
            else
            {
                MessageBox.Show("You have to enter a digit", "Processing error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int height;
            bool isInt = int.TryParse(textBox3.Text, out height);

            if (isInt)
            {
                this.newHeight = height;
            }
            else
            {
                MessageBox.Show("You have to enter a digit", "Processing error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int scale;
            bool isInt = int.TryParse(textBox4.Text, out scale);

            if (isInt)
            {
                this.scaleFactor = scale;
            }
            else
            {
                MessageBox.Show("You have to enter a digit", "Processing error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OutputFile = Path.GetDirectoryName(imgFile) + "\\Resized_" + Path.GetFileNameWithoutExtension(fileName);
                Class1.ResizeImage(imgFile, OutputFile, scaleFactor, newWidth, newHeight);
                MessageBox.Show("The photo was resized", "Completed",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {

                throw;
            }
            
            
        }
    }
}
