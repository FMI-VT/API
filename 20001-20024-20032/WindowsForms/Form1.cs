using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public string sourceFile { get; set; }
        public string destinationFile { get; set; }

        //save method
        public void saveFile()
        {
            SaveFileDialog saveFile = new SaveFileDialog(); 
            //which format to save as
            if (comboBox1.SelectedItem.ToString().ToLower() == "jpg")
            saveFile.Filter = "JPG (*.jpg)|*.jpeg";
            else if (comboBox1.SelectedItem.ToString().ToLower() == "png")
            saveFile.Filter = "PNG (*.png)|*.png";
            else if (comboBox1.SelectedItem.ToString().ToLower() == "gif")
            saveFile.Filter = "GIF (*.gif)|*.gif";
            saveFile.ShowDialog();
            destinationFile = saveFile.FileName;
        }

        public Form1()
        {
            InitializeComponent();
            //populate the comboBox1
            comboBox1.Items.Add(new comboBoxItem("JPG"));
            comboBox1.Items.Add(new comboBoxItem("PNG"));
            comboBox1.Items.Add(new comboBoxItem("GIF"));
            //... and comboBox2
            comboBox2.Items.Add(new comboBoxItem("skew"));
            comboBox2.Items.Add(new comboBoxItem("crop"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        PrimeHoldingImage.Convert conv = new PrimeHoldingImage.Convert();
        
        
        #region openFileDialog
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); //create new object - OpenFileDialog
            openFileDialog.Filter = "Image Files(*.PNG;*.JPG;*.GIF) |*.PNG;*.JPG;*.GIF"; //filter image files only to be shown(jpg,gif,png)
            openFileDialog.ShowDialog(); //show the openFileDialog
            sourceFile = openFileDialog.FileName; //set the sourceFile 
            pictureBox1.Image = new Bitmap(openFileDialog.FileName); //set the picture box image
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        #endregion


        #region ConvertSave
        private void button2_Click(object sender, EventArgs e)
        {
            //check if comboBox value is jpg => save as jpg
            if (comboBox1.SelectedItem.ToString().ToLower() == "jpg")
            {
                saveFile();
                conv.ConvertImage(sourceFile, destinationFile, "jpg");              
                pictureBox1.Image = new Bitmap(destinationFile);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                label2.Text = "Saved as jpg!";

            }
            //check if comboBox value is png => save as png
            else if (comboBox1.SelectedItem.ToString().ToLower() == "png")
            {
                saveFile();
                conv.ConvertImage(sourceFile, destinationFile, "png");
                pictureBox1.Image = new Bitmap(destinationFile);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                label2.Text = "Saved as png!";
            }
            //check if comboBox value is gif => save as gif
            else if (comboBox1.SelectedItem.ToString().ToLower() == "gif")
            {
                saveFile();
                conv.ConvertImage(sourceFile, destinationFile, "gif");
                pictureBox1.Image = new Bitmap(destinationFile);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                label2.Text = "Saved as gif!";
            }
        }
        #endregion


        #region comboBox Items class & constructor
        private class comboBoxItem
        {
            public string comboBoxName;
            //constructor
            public comboBoxItem(string name)
            {
                comboBoxName = name;
            }

            public override string ToString()
            {
                // Generates the text shown in the combo box
                return comboBoxName;
            }
        }
        #endregion


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        //resize
        PrimeHoldingImage.Resize resize = new PrimeHoldingImage.Resize();

        
        private void button3_Click_1(object sender, EventArgs e)
        {
            //check comboBox2 value 
            if (comboBox2.SelectedItem.ToString().ToLower() == "skew")
            {
                saveFile();
                resize.Process(sourceFile, destinationFile, "scew", width, height, 0, 0);
                pictureBox1.Image = new Bitmap(destinationFile);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                label2.Text = "Image skew'd";
            }
            else if (comboBox2.SelectedItem.ToString().ToLower() == "crop")
            {
                saveFile();
                resize.Process(sourceFile, destinationFile, "crop", 0, 0, width, height);
                pictureBox1.Image = new Bitmap(destinationFile);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                label2.Text = "Image crop'd";
            }
        }

        
        int width; //resize width
        int height; //resize height


        #region textBox
        public void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //restrict textBox1 to digits only
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //tryParse textBox1.Text value and set as height value
            if (int.TryParse(textBox1.Text, out int height))
            {
                this.height = height;
            }
        }

        public void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //restrict textBox2 to digits only
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //tryParse textBox2.Text value and set as width value
            if(int.TryParse(textBox1.Text, out int width))
            {
                this.width = width;
            }
        }
        #endregion
    }
}
