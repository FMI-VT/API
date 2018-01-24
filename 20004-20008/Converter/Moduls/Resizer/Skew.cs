using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary.Modules.Resizer
{
    class Skew : IResizable
    {
        public void Resize(string sourcePath, string destinationPath, int width, int height)
        {
            using (Bitmap ImageFromFile = new Bitmap(Image.FromFile(sourcePath)))
            {
                using (Bitmap image = new Bitmap(width, height))
                {
                    using (Graphics graphic = Graphics.FromImage(image))
                    {
                        graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        graphic.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                        graphic.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                        graphic.DrawImage(ImageFromFile, 0, 0, width, height);
                    }
                    image.Save(destinationPath);
                }
            }
        }
    }
}