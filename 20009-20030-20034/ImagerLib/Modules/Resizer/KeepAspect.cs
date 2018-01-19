using System;
using System.Drawing;

namespace ImagerLib.Modules.Resizer
{
    class KeepAspect : IResizable
    {
        public void Resize(string sourcePath, string destinationPath, int width, int height)
        {
            using (Image image = Image.FromFile(sourcePath))
            {
                double sourceRatio = (double)image.Width / image.Height;
                double destinationRatio = (double)width / height;

                if (Math.Round(sourceRatio, 2) != Math.Round(destinationRatio, 2))
                {
                    throw new InvalidAspectRatioException();
                }

                Skew skew = new Skew();
                skew.Resize(sourcePath, destinationPath, width, height);
            }
        }
    }
}
