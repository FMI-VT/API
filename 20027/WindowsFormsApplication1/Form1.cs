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
using ClassLibrary3;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int Quality = 4;
        string filename;
        int type = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 test = new Class1(textBox1.Text, textBox2.Text);
            test.PRINT();

            if(checkBox1.Checked==true)
            {
                MessageBox.Show("RESIZING!");
                int x = 0;
                int y = 0;

                if(radioButton1.Checked==true)
                {
                    x = 1920;
                    y = 1080;
                }

                if(radioButton2.Checked==true)
                {
                    x = 1280;
                    y = 720;
                }

                if(radioButton3.Checked==true)
                {
                    try
                    {
                        x = int.Parse(textBox3.Text);
                        y = int.Parse(textBox4.Text);
                    }
                   catch(Exception ex)
                    {
                        MessageBox.Show("Неправилно въведени размери!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if(checkBox2.Checked==true)
                {
                    if (radioButton4.Checked == true)
                    {
                        type = 1; //JPG
                    }
                    if (radioButton5.Checked == true)
                    {
                        type = 2;  //PNG
                    }
                    if (radioButton6.Checked == true)
                    {
                        type = 3; // GIF
                    }
                }
                else
                {
                    type = 1;
                }


                test.Resize(x, y, Quality,type);

            }
            if(checkBox2.Checked==true && checkBox1.Checked==false)
            {
                MessageBox.Show("CHANGING FILE TYPE");
                
                
                if(radioButton4.Checked==true)
                {
                    type = 1; //JPG
                }
                if(radioButton5.Checked==true)
                {
                    type = 2;  //PNG
                }
                if(radioButton6.Checked==true)
                {
                    type = 3; // GIF
                }

                test.convert(type);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "JPG (*.JPG)|*.JPG|PNG (*.PNG)|*.PNG|GIF (*.GIF)|*.GIF";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {

                        using (myStream)
                        {
                            string directoryPath = Path.GetDirectoryName(openFileDialog1.FileName);
                            string file = Path.GetFileName(openFileDialog1.FileName);
                            filename = file;
                            textBox1.Text = directoryPath + "\\" + file;
                            textBox2.Text = directoryPath +"\\Out" +file ;
                            
                            pictureBox1.Image = new Bitmap(openFileDialog1.FileName);

                            myStream.Dispose();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }         
           openFileDialog1.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            visible(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string directoryPath = Path.GetDirectoryName(fbd.SelectedPath);                    
                    string file = Path.GetFileName(fbd.SelectedPath);
                    textBox2.Text = directoryPath + "\\" + file + "\\Out" + filename;

                    fbd.Dispose();
                    //string[] files = Directory.GetFiles(fbd.SelectedPath);

                   // System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            visible(true);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            visible(false);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            visible(false);
        }
        void visible(bool t)
        {
            label3.Visible = t;
            label4.Visible = t;
            textBox3.Visible = t;
            textBox4.Visible = t;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value==1)
            {
                Quality = 1;
            }
            if(trackBar1.Value==2)
            {
                Quality = 2;
            }
            if(trackBar1.Value==3)
            {
                Quality = 3;
            }
            if(trackBar1.Value==4)
            {
                Quality = 4;
            }
        }
    }
}
