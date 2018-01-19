using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Converter
{
    class GIF : ConvertStrategy
    {
        public override string Convert(string sourceFile, string destinationFile)
        {
            // Load the image.
            System.Drawing.Image image1 = System.Drawing.Image.FromFile(sourceFile);

            // Save the image in GIF format.
            image1.Save(destinationFile, System.Drawing.Imaging.ImageFormat.Gif);

            return destinationFile;
        }
    }
}
