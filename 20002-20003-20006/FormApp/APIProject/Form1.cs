using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcess;
using System.IO;

namespace APIProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                    label1.Text = imageLocation;
                }
            }
            catch (Exception)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int w = Convert.ToInt32(txtwidth.Text);
            int h = Convert.ToInt32(txtheight.Text);
            ImageProcess.Resizer.Resize resize = new ImageProcess.Resizer.Resize(label1.Text, label5.Text, comboBox1.Text, w, h);

            resize.Execute();
            MessageBox.Show("Image saved!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();

                DialogResult dr = dialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                    label5.Text = imageLocation + comboBox2.SelectedItem;
                }
            }
            catch
            {

            }

            ImageProcess.Converter.Convert convert = new ImageProcess.Converter.Convert(label1.Text, label5.Text, comboBox2.Text);

            convert.Execute();
        }
    }

}
