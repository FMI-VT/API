using System.Drawing;
using System.Drawing.Imaging;
using ImagesProcess.Exceptions;
using System;
using System.IO;

namespace ImagesProcess.Resize
{
    class Crop : Adapters.BaseResize
    {
        int x, y;
        public Crop(string srcPath, string destPath, int width, int height, int x, int y) : base(srcPath, destPath, width, height)
        {
            this.x = x;
            this.y = y;
        }
        public override void Process()
        {
            try
            {
                Bitmap srcImg = Image.FromFile(srcPath) as Bitmap;
                ImageFormat imgFormat = srcImg.RawFormat;

                Rectangle destRect = new Rectangle(x, y, width, height);

                Bitmap bmp = new Bitmap(destRect.Width, destRect.Height, PixelFormat.Format24bppRgb);
                Rectangle srcRect = new Rectangle(0,0, destRect.Width, destRect.Height);
                
                //int srcWidth, srcHeight;
                float srcRatio = width / height;
                if (x < 0 || (x + width) > srcImg.Width || y < 0 || (y + height) > srcImg.Height)
                {
                    throw new CropOutOfRange("Selected area is out of destination image range.");
                }
                Graphics gfx = Graphics.FromImage(bmp);
                gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gfx.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                gfx.DrawImage(srcImg, srcRect, destRect, GraphicsUnit.Pixel);
                                
               // Image destImage = bmp.Clone(destRect, bmp.PixelFormat);
                bmp.Save(destPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                srcImg.Dispose();
                bmp.Dispose();
                gfx.Dispose();
              //  destImage.Dispose();
            } catch (UnauthorizedAccessException e) {
                throw new SrcFileNotReadible("Src file access denied", e);
            } catch (FileNotFoundException e)
            {
                throw new SrcFileNotFound("File not found ("+srcPath+")",e);
            }
            
        }
    }
}
