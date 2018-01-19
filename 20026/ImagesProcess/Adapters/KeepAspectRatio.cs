using System.Drawing;
using System.Drawing.Imaging;
using ImagesProcess.Exceptions;

namespace ImagesProcess.Resize
{
    class KeepAspectRatio : Adapters.BaseResize
    {
        public KeepAspectRatio(string srcPath, string destPath, int width, int height) : base(srcPath, destPath, width, height)
        {
        }
        public override void Process()
        {
            Image img = Image.FromFile(srcPath);
            ImageFormat imgFormat = img.RawFormat;
            int destWidth = this.width;
            int destHeight = this.height;
            int width = img.Width;
            int height = img.Height;
            
            float srcRatio = (float) width / (float) height;
            float destRatio = (float) destWidth / (float) destHeight;
            //int startX = 0, startY = 0;
           /* if (srcRatio > destRatio)
            {
                destWidth = this.width;
                destHeight = System.Convert.ToInt32(Math.Round(this.width / destRatio));
                startY = this.height - destHeight;
            } else
            {
                destWidth = System.Convert.ToInt32(Math.Round(this.height * destRatio));
                destHeight = this.height;
                startX = this.width - destWidth;
            }*/
            if (srcRatio != destRatio)
            {
                throw new AspectRatiosDoesntMatch("Source and destination aspect ration doesn't match!");
            }
            
            Bitmap destImg = new Bitmap(img, new Size(destWidth, destHeight));
            destImg.Save(destPath, imgFormat);
            img.Dispose();
            destImg.Dispose();
        }
    }
}
