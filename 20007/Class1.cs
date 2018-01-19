using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace ClassLibrary2
{

    public class Class1
    {

        public static void ImageConvert(string imgFile, string OutputFile,string FileFormat)
        {
            // GET THE IMAGE
            var srcImage = Image.FromFile(imgFile);
            int newWidth = srcImage.Width;
            int newHeight = srcImage.Height;
            var newImage = new Bitmap(newWidth, newHeight);
            var graphics = Graphics.FromImage(newImage);
            
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight));

            ImageFormat FORMAT = ImageFormat.Jpeg;
            string outp=".jpg";
            switch (FileFormat.ToUpper())
            {
                case "JPG":
                    FORMAT = ImageFormat.Jpeg;
                    outp = ".jpg";
                    break;
                case "PNG":
                    FORMAT = ImageFormat.Png;
                    outp = ".png";
                    break;
                case "GIF":
                    FORMAT = ImageFormat.Gif;
                    outp = ".gif";
                    break;
                case "BMP":
                    FORMAT = ImageFormat.Bmp;
                    outp = ".bmp";
                    break;
                default:
                    break;
            }
            newImage.Save(OutputFile+outp, FORMAT);

        }
        public static void ResizeImage(string imgFile, string OutputFile, double ScaleFactor, int newWidth,int newHeight)
        {
            using (var srcImage = Image.FromFile(imgFile))
            {
                // USE SCALE FACTOR OR IF 0 USE WIDTH AND HEIGHT INSTEAD
                if(ScaleFactor!=0)
                {                    
                      newWidth = (int)(srcImage.Width * ScaleFactor);
                      newHeight = (int)(srcImage.Height * ScaleFactor);
                }
                using (var newImage = new Bitmap(newWidth, newHeight))
                using (var graphics = Graphics.FromImage(newImage))
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    graphics.DrawImage(srcImage, 0, 0, newWidth, newHeight);
                    string outt = imgFile.Substring(imgFile.Length - 3);
                    ImageFormat imgFormat = ImageFormat.Jpeg;
                    switch(outt.ToUpper())
                    {
                        case "JPG":
                            imgFormat = ImageFormat.Jpeg;
                            break;
                        case "GIF":
                            imgFormat = ImageFormat.Gif;
                            break;
                        case "PNG":
                            imgFormat = ImageFormat.Png;
                            break;
                        case "BMP":
                            imgFormat = ImageFormat.Bmp;
                            break;
                        default:
                            imgFormat = ImageFormat.Jpeg;
                            break;
                    }
                    newImage.Save(OutputFile+"."+outt, imgFormat);
                }
            }
        }
    }
}