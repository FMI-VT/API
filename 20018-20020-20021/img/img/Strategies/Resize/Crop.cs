using img.Interfeca;
using System.Drawing;
using System.IO;
using System;
using System.Security;

namespace img.Strategies.Resize
{
    internal class Crop : IStrategy
    {
        private int x, y, width, height;

        public Crop(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void Start(string sourcePath, string destinationPath)
        {
            try
            {
                using (FileStream ifs = new FileStream(sourcePath, FileMode.Open))
                {
                    Bitmap bitmap = new Bitmap(ifs);
                    Rectangle rectangle = new Rectangle(this.x, this.y, this.width, this.height);
                    Bitmap resizedBitmap = bitmap.Clone(rectangle, bitmap.PixelFormat);
                    using (FileStream ofs = new FileStream(destinationPath, FileMode.CreateNew))
                    {
                        resizedBitmap.Save(ofs, bitmap.RawFormat);
                    }
                }
                Console.WriteLine("Your image was successfuly resized!");
            }
            catch (Exception)
            {
                Console.WriteLine("Inserted pixels are more than the original image pixels or image is already created!");
            }
        }
    }
}