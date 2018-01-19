using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursov2.Converter
{
    public class Convert : Helper
    {
        //converts the images to other formats
        public string Converter(FileInfo foo)
        {
            //Get file extension
            string fileExtension = foo.Extension.ToLower();

        System.Drawing.Image image = Image.FromFile(SourceFolder);

        ImageConverter b = new ImageConverter();

        ImageFormat format = ImageFormat.Jpeg;

            switch (foo.Extension.ToLower())
            {
                case ".jpeg":
                case ".jpg":
                    format = ImageFormat.Jpeg;
                    break;

                case ".png":
                    format = ImageFormat.Png;
                    break;

                case ".gif":
                    format = ImageFormat.Gif;
                    break;
            }

            image.Save(DestionationFolder, format);

            image.Dispose();

            return (fileExtension);
        }
    }
}
