using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConverterLibrary;
using System.IO;

namespace WFAConverter
{
    public partial class Form1 : Form
    {
        private Imager imager = new Imager();


        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png|GIF|*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        private void button3_Click(object sender, EventArgs e)
        {

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = fbd.SelectedPath;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = null;
            try
            {
                if (radioButton1.Checked)
                {
                    textBox2.Text = fbd.SelectedPath + "\\converted-image" + "." + ConvertType.Jpg;
                    imager.Convert(textBox1.Text, textBox2.Text, ConvertType.Jpg);
                    message = "Converted to jpg";
                    MessageBox.Show(message);
                }
                if (radioButton2.Checked)
                {
                    textBox2.Text = fbd.SelectedPath + "\\converted-image" + "." + ConvertType.Png;
                    imager.Convert(textBox1.Text, textBox2.Text, ConvertType.Png);
                    message = "Converted to png";
                    MessageBox.Show(message);
                }
                if (radioButton3.Checked)
                {
                    textBox2.Text = fbd.SelectedPath + "\\converted-image" + "." + ConvertType.Gif;
                    imager.Convert(textBox1.Text, textBox2.Text, ConvertType.Gif);
                    message = "Converted to gif";
                    MessageBox.Show(message);
                }
            }
            catch (IfImageNullOrEmptyException)
            {
                message = "Please Select Existing Image";
                MessageBox.Show(message);
            }
            catch (IfImageAlreadyExistsException)
            {
                message = "The Image Already Exists";
                MessageBox.Show(message);
            }
            catch (IfImageNotFoundException)
            {
                message = "Image Not Found";
                MessageBox.Show(message);
            }
            catch (InvalidImageException)
            {
                message = "Invalid Image";
                MessageBox.Show(message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string message = null;
            int width = int.Parse(textBox5.Text);
            int height = int.Parse(textBox6.Text);
            string extension = Path.GetExtension(textBox4.Text);

            try
            {
                if (extension == ".jpg")
                {
                    textBox3.Text = fbd.SelectedPath + "\\resized-image.jpg";
                    imager.Resize(textBox4.Text, textBox3.Text, ResizeType.Skew, width, height);
                    message = "Resized to " + width + "x" + height;
                    MessageBox.Show(message);
                }

                if (extension == ".png")
                {
                    textBox3.Text = fbd.SelectedPath + "\\resized-image.png";
                    imager.Resize(textBox4.Text, textBox3.Text, ResizeType.Skew, width, height);
                    message = "Resized to " + width + "x" + height;
                    MessageBox.Show(message);
                }

                if (extension == ".gif")
                {
                    textBox3.Text = fbd.SelectedPath + "\\resized-image.gif";
                    imager.Resize(textBox4.Text, textBox3.Text, ResizeType.Skew, width, height);
                    message = "Resized to " + width + "x" + height;
                    MessageBox.Show(message);
                }

            }
            catch (IfImageNullOrEmptyException)
            {
                message = "Please Select Existing Image";
                MessageBox.Show(message);
            }
            catch (IfImageAlreadyExistsException)
            {
                message = "The Image Already Exists";
                MessageBox.Show(message);
            }
            catch (IfImageNotFoundException)
            {
                message = "Image Not Found";
                MessageBox.Show(message);
            }
            catch (InvalidImageException)
            {
                message = "Invalid Image";
                MessageBox.Show(message);
            }
            catch (InvalidImageDimensionException)
            {
                message = "Invalid Dimensions";
                MessageBox.Show(message);
            }
            catch (InvalidAspectException)
            {
                message = "Invalid Aspect";
                MessageBox.Show(message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png|GIF|*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = ofd.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = fbd.SelectedPath;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png|GIF|*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox9.Text = ofd.FileName;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox11.Text = fbd.SelectedPath;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string message = null;
            int width = int.Parse(textBox7.Text);
            int height = int.Parse(textBox8.Text);
            int x = int.Parse(textBox13.Text);
            int y = int.Parse(textBox12.Text);
            string extension = Path.GetExtension(textBox9.Text);

            try
            {
                if (extension == ".jpg")
                {
                    textBox11.Text = fbd.SelectedPath + "\\cropped-image.jpg";
                    imager.Resize(textBox9.Text, textBox11.Text, ResizeType.Crop, width, height, x, y);
                    message = "Cropped!";
                    MessageBox.Show(message);
                }

                if (extension == ".png")
                {
                    textBox11.Text = fbd.SelectedPath + "\\cropped-image.png";
                    imager.Resize(textBox9.Text, textBox11.Text, ResizeType.Crop, width, height, x, y);
                    message = "Cropped!";
                    MessageBox.Show(message);
                }

                if (extension == ".gif")
                {
                    textBox11.Text = fbd.SelectedPath + "\\cropped-image.gif";
                    imager.Resize(textBox9.Text, textBox11.Text, ResizeType.Crop, width, height, x, y);
                    message = "Cropped!";
                    MessageBox.Show(message);
                }

            }
            catch (IfImageNullOrEmptyException)
            {
                message = "Please Select Existing Image";
                MessageBox.Show(message);
            }
            catch (IfImageAlreadyExistsException)
            {
                message = "The Image Already Exists";
                MessageBox.Show(message);
            }
            catch (IfImageNotFoundException)
            {
                message = "Image Not Found";
                MessageBox.Show(message);
            }
            catch (InvalidImageException)
            {
                message = "Invalid Image";
                MessageBox.Show(message);
            }
            catch (InvalidImageDimensionException)
            {
                message = "Invalid Dimensions";
                MessageBox.Show(message);
            }
            catch (InvalidAspectException)
            {
                message = "Invalid Aspect";
                MessageBox.Show(message);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}