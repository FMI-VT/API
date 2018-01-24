using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ConverterLibrary;

namespace ConverterLibrary.Modules.Resizer
{
    class Crop : IResizable
    {
        private int x;
        private int y;
        public Crop(int x, int y)
        {
            if(x < 0 || y < 0)
            {
                throw new InvalidImageDimensionException();
            }
            this.x = x;
            this.y = y;
        }
        public void Resize(string sourcePath, string destinationPath, int width, int height)
        {
            using (Bitmap BitmapImage = new Bitmap(Image.FromFile(sourcePath)))
            {
                if(x > BitmapImage.Width|| y > BitmapImage.Height || width+x>BitmapImage.Width || height + y > BitmapImage.Height)
                {
                    throw new InvalidImageDimensionException();
                }
                Rectangle rectangle = new Rectangle(x, y, width, height);
                using (Bitmap CroppedImage = BitmapImage.Clone(rectangle, BitmapImage.PixelFormat))
                {
                    CroppedImage.Save(destinationPath);
                }
            }
        }
    }
}