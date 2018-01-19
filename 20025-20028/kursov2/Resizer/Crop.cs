using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursov2.Resizer
{

    public class Crop: Helper
    {
        
        //crop the image
        public void Croping()
        {
            using (FileStream fs = new System.IO.FileStream(SourceFolder, System.IO.FileMode.Open))
            {
                original = new Bitmap(fs);
            }

            Rectangle cropRect = new Rectangle();
            Bitmap src = Image.FromFile(SourceFolder) as Bitmap;
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(src, cropRect, new Rectangle(0, 0, original.Height, original.Width), GraphicsUnit.Pixel);
            }

            target.Save(DestionationFolder);
            target.Dispose();
            src.Dispose();
        }
    }
}

