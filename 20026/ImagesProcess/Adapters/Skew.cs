using System.Drawing;
using System.Drawing.Imaging;

namespace ImagesProcess.Resize
{
    class Skew : Adapters.BaseResize
    {
        public Skew(string srcPath, string destPath, int width, int height) : base(srcPath, destPath, width, height)
        {
        }

        public override void Process()
        {
            Image img = Image.FromFile(srcPath);
            ImageFormat imgFormat = img.RawFormat;
            Bitmap destImg = new Bitmap(img, new Size(width, height));
            destImg.Save(destPath, imgFormat);
        }
    }
}
