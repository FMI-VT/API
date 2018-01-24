using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            of.Filter = "jpeg files (*.jpg)|*.jpg| bmp files (*.bmp)|*.bmp| gif files (*.gif)|*.gif| png files (*.png)|*.png";
            of.ShowDialog();
            pictureBox1.Image = new Bitmap(of.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
             SaveFileDialog of = new SaveFileDialog();

            try
            {

                if ((string)comboBoxTargetFormat.SelectedItem == "PNG")
                {
                    of.Filter = "PNG|*.png";
                    if (of.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                    {

                        pictureBox1.Image.Save(of.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("Successful convertion to PNG !");
                    }

                }
                else if ((string)comboBoxTargetFormat.SelectedItem == "JPEG")
                {
                    of.Filter = "JPEG|*.jpg";
                    if (of.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                    {
                        pictureBox1.Image.Save(of.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        MessageBox.Show("Successful convertion to JPEG !");
                    }
                }
                else if ((string)comboBoxTargetFormat.SelectedItem == "BMP")
                {
                    of.Filter = "BMP|*.bmp";
                    if (of.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                    {
                        pictureBox1.Image.Save(of.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        MessageBox.Show("Successful convertion to BMP !");
                    }
                }
                else if ((string)comboBoxTargetFormat.SelectedItem == "GIF")
                {
                    of.Filter = "GIF|*.gif";
                    if (of.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                    {
                        pictureBox1.Image.Save(of.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                        MessageBox.Show("Successful convertion to GIF !");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        


        }

        private void resize_Click(object sender, EventArgs e)
        {
            SaveFileDialog of = new SaveFileDialog();
            of.Filter = " jpeg files (*.jpg)|*.jpg| bmp files (*.bmp)|*.bmp| gif files (*.gif)|*.gif| png files (*.png)|*.png";
            Bitmap newImage = new Bitmap(pictureBox1.Image, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            of.ShowDialog();
            newImage.Save(of.FileName);

            MessageBox.Show("Resized and converted!");
        }
    }
}
