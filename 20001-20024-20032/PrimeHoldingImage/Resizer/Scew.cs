using PrimeHoldingImage.Resizer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using static System.Net.Mime.MediaTypeNames as MimeMediaType;

namespace PrimeHoldingImage.Resizer
{
    class Scew : IResizeStrategy
    {
      

        public string Resize(string a, string b, int c, int d)
        {
            return null;
        }
        public string Resize(string sourceFile, string destinationFile, int destinationWidth, int destinationHeight,int b,int c)
        {
           
            Bitmap src = Image.FromFile(sourceFile) as Bitmap;
            Bitmap target = new Bitmap(destinationWidth, destinationHeight);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(
                    src,
                    new Rectangle(0, 0, target.Width, target.Height),
                    new Rectangle(0, 0, src.Width, src.Height),
                    GraphicsUnit.Pixel
                );

            }

            target.Save(destinationFile, System.Drawing.Imaging.ImageFormat.Jpeg);
            target.Dispose();
            src.Dispose();



            return destinationFile;
        }
    }
}
