using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace WindowsFormsApplication1
{
    class Class1
    {
        private string input;
        private string output;
        //constructor
        public Class1(string InputDir, string OutputDir)
        {
            Initialize(InputDir,OutputDir);
            
        }
        private void Initialize(string inp, string outp)
        {
            input = inp;
            output = outp;
        }

        public void PRINT()
        {
            MessageBox.Show("your input file =  " +input);
           // MessageBox.Show("your output file =  " +output);
           
           
        }
        public void Resize(int maxWidth, int maxHeight, int quality,int type)
        {
            try
            {
                ImageFormat FileFormat = ImageFormat.Jpeg;
                string filetype = "jpg";
                switch (type)
                {
                    case 1:
                        FileFormat = ImageFormat.Jpeg;
                        filetype = "jpg";
                        break;
                    case 2:
                        FileFormat = ImageFormat.Png;
                        filetype = "png";
                        break;
                    case 3:
                        FileFormat = ImageFormat.Gif;
                        filetype = "gif";
                        break;
                }

                MessageBox.Show("X= " + maxWidth + "  Y= " + maxHeight);

                Image image = (Bitmap)Image.FromFile(input);

                int originalWidth = image.Width;
                int originalHeight = image.Height;

                // To preserve the aspect ratio
                float ratioX = (float)maxWidth / (float)originalWidth;
                float ratioY = (float)maxHeight / (float)originalHeight;
                float ratio = Math.Min(ratioX, ratioY);

                // New width and height based on aspect ratio
                int newWidth = (int)(originalWidth * ratio);
                int newHeight = (int)(originalHeight * ratio);

                // Convert other formats (including CMYK) to RGB.
                Bitmap newImage = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);

                // Draws the image in the specified size with quality mode set to HighQuality
                using (Graphics graphics = Graphics.FromImage(newImage))
                {
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.DrawImage(image, 0, 0, newWidth, newHeight);
                }

                // Get an ImageCodecInfo object that represents the JPEG codec.
                ImageCodecInfo imageCodecInfo = this.GetEncoderInfo(FileFormat);

                // Create an Encoder object for the Quality parameter.
                System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;

                // Create an EncoderParameters object. 
                EncoderParameters encoderParameters = new EncoderParameters(1);

                // Save the image as a JPEG file with quality level.

                Int64 Qual=CheckQuality(quality);

                EncoderParameter encoderParameter = new EncoderParameter(encoder, Qual);
                encoderParameters.Param[0] = encoderParameter;
                string out1 = output.Remove(output.Length - 3, 3);

                newImage.Save(out1+filetype, imageCodecInfo, encoderParameters);
                MessageBox.Show("Your output file = " + out1+filetype);
                image.Dispose();
                
                                
            }
            catch(Exception ex)
            {
                MessageBox.Show("SOme Kind of erroR! O_o Something is not ok! :D");
            }
           
            
        }
        private Int64 CheckQuality(int quality)
        {
            Int64 Qual;
            switch (quality)
            {
                case 1:
                    Qual = 25L;
                    break;
                case 2:
                    Qual = 50L;
                    break;
                case 3:
                    Qual = 75L;
                    break;
                case 4:
                    Qual = 100L;
                    break;
                default:
                    Qual = 100L;
                    break;
            }
            return Qual;
        }
        private ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().SingleOrDefault(c => c.FormatID == format.Guid);
        }

        public void convert(int type)
        {
           
            ImageFormat FileFormat = ImageFormat.Jpeg;
            string filetype="jpg";
            switch (type)
            {
                case 1:
                    FileFormat = ImageFormat.Jpeg;
                    filetype = "jpg";
                    break;
                case 2:
                    FileFormat = ImageFormat.Png;
                    filetype = "png";
                    break;
                case 3:
                    FileFormat = ImageFormat.Gif;
                    filetype = "gif";
                    break;
            }
            MessageBox.Show("CONVERTING TO: " + filetype);
            try
            {
                Image image = (Bitmap)Image.FromFile(input);

                int originalWidth = image.Width;
                int originalHeight = image.Height;

                int newWidth = originalWidth;
                int newHeight = originalHeight;

                // Convert other formats (including CMYK) to RGB.
                Bitmap newImage = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);

                // Draws the image in the specified size with quality mode set to HighQuality
                using (Graphics graphics = Graphics.FromImage(newImage))
                {
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.DrawImage(image, 0, 0, newWidth, newHeight);
                }

                // Get an ImageCodecInfo object that represents the JPEG codec.
                ImageCodecInfo imageCodecInfo = this.GetEncoderInfo(FileFormat);

                // Create an Encoder object for the Quality parameter.
                System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;

                // Create an EncoderParameters object. 
                EncoderParameters encoderParameters = new EncoderParameters(1);

                // Save the image as a JPEG file with quality level.            

                EncoderParameter encoderParameter = new EncoderParameter(encoder, 100L);
                encoderParameters.Param[0] = encoderParameter;

                string out1 = output.Remove(output.Length - 3, 3);

                newImage.Save(out1+filetype, imageCodecInfo, encoderParameters);
                MessageBox.Show("Your output file = " + out1+filetype);
                image.Dispose();


            }
            catch(Exception ex)
            {
                MessageBox.Show("SOme Kind of erroR! O_o Something is not ok! :D");
            }
        }
    }
}
