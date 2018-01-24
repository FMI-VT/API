using Converter.Exceptions;
using Converter.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace Converter.ConvertAndResize
{
    internal class ResizedStrategy : IStrategy
    {
        private int x, y, width, height;

        public ResizedStrategy(int x, int y, int width, int height)
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
                    ValidateResizeDimensions(rectangle, bitmap);
                    Bitmap resizedBitmap = bitmap.Clone(rectangle, bitmap.PixelFormat);
                    using (FileStream ofs = new FileStream(destinationPath, FileMode.CreateNew))
                    {
                        resizedBitmap.Save(ofs, bitmap.RawFormat);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new MainExeption(ex.Message, ex);
            }


        }

        private void ValidateResizeDimensions(Rectangle rectangle, Bitmap bitmap)
        {
            if (rectangle.X < 0)
            {
                throw new InvalidResizeException("The X shouldn't be outside of the image and/or less than 0");
            }
            else if (rectangle.X + width > bitmap.Width)
            {
                throw new InvalidResizeException("The X + the passed width is more than the image width.");
            }
            else if (rectangle.Y < 0)
            {
                throw new InvalidResizeException("The Y shouldn't be outside of the image and/or less than 0");
            }
            else if (rectangle.Y + height > bitmap.Height)
            {
                throw new InvalidResizeException("The Y + the passed height is more than the image height.");
            }
            else if (rectangle.X > bitmap.Width)
            {
                throw new InvalidResizeException("The X shouldn't be outside of the image dimensions");
            }
            else if (rectangle.Y > bitmap.Height)
            {
                throw new InvalidResizeException("The Y shouldn't be outside of the image dimensions");
            }
        }

    }
}