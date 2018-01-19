using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursov2.Resizer
{
    public class Skew: Helper
    {
        //without saveing the proportions(size) of the image 
        public void Skews()
        {
            Image image = Image.FromFile(SourceFolder);
            using (var newImage = ScaleImage(image, original.Height, original.Width))
            {
                newImage.Save(DestionationFolder, image.RawFormat);
            }
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, image.Height, image.Width, newWidth, newHeight);

            image.Dispose();
            return newImage;
        }
    }
}
