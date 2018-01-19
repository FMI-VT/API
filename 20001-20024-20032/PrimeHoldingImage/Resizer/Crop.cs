using PrimeHoldingImage.Resizer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Resizer
{
    class Crop : IResizeStrategy
    {
        public string Resize(string s, string s2, int i1, int i2) {
            return "";
        }
        public string Resize(string sourceFile, string destinationFile, int x, int y, int destinationWidth, int destinationHeight)
        {
            /*
             * Proverki za:
             * - prava za chetene ot sourceFile
             * - prava za zapis za destinationFile
             * - Koordinati x i y za rectangle pri crop
             * - width i height za rectangle pri crop
             * - width i height na destinationFile da ne nadvishavat width i height na sourceFile
             * - polojitelni stojnosti za x, y, width i height
             * 
             */

            Rectangle cropRect = new Rectangle(x, y, destinationWidth, destinationHeight);
            Bitmap src = Image.FromFile(sourceFile) as Bitmap;
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

            Graphics g = Graphics.FromImage(target);
            g.DrawImage(src, new Rectangle(x, y, target.Width, target.Height),
                            new Rectangle(0, 0, src.Width, src.Height),
                            GraphicsUnit.Pixel);
            //
            //g.CopyFromScreen(x, y, destinationWidth, destinationHeight, target.Size, CopyPixelOperation.SourceCopy);
            target.Save(destinationFile, System.Drawing.Imaging.ImageFormat.Jpeg);
            target.Dispose();
            src.Dispose();
            return destinationFile;
        }

        
    }
}
