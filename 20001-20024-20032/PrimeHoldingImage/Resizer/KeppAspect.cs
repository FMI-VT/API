using PrimeHoldingImage.Converter;
using System;
using System.Collections.Generic;
using System.Drawing;
using PrimeHoldingImage.Exception;
using PrimeHoldingImage.Resizer;

namespace PrimeHoldingImage.Resizer
{
    public class KeppAspect : IResizeStrategy
    {
        private static bool keepAspectRatio;

        public string Resize(string sourceFile, string destinationFile, int destinationWidth, int destinationHeight)
        {
            throw new NotImplementedException();
        }



        public string Resize(string sourceFile, string destinationFile, int Width, int Height, int x, int y)
        {
            Bitmap imgPhoto = Image.FromFile(sourceFile) as Bitmap;
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            float sourceAspect = sourceWidth / sourceHeight;
            float destinationAspect = Width / Height;


            if (sourceAspect == destinationAspect)
            {


                Bitmap target = new Bitmap(Width, Height);

                using (Graphics g = Graphics.FromImage(target))
                {
                    g.DrawImage(
                        imgPhoto,
                        new Rectangle(0, 0, target.Width, target.Height),
                        new Rectangle(0, 0, imgPhoto.Width, imgPhoto.Height),
                        GraphicsUnit.Pixel
                    );

                }

                target.Save(destinationFile, System.Drawing.Imaging.ImageFormat.Jpeg);
                target.Dispose();
                imgPhoto.Dispose();

            }
            else
            {
                throw new AspectRatioNotMatch("Source and Destination aspect ratios doesn't match");
            }

            return destinationFile;

        }



    }



}