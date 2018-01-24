using ConverterLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary.Modules.Converter
{
    internal class Jpg : IConvertable
    {
        public void Convert(string sourcePath, string destinationPath)
        {
            using (Image image = Image.FromFile(sourcePath))
            {
                var qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);
                var jpegCodec = ImageCodec.GetEncoderInfo("image/jpeg");

                var encoderParams = new EncoderParameters(1);
                encoderParams.Param[0] = qualityParam;

                image.Save(destinationPath, jpegCodec, encoderParams);
            }
        }
    }
}