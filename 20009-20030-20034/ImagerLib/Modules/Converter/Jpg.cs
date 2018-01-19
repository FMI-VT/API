using ImagerLib.Helpers;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImagerLib.Modules.Converter
{
    internal class Jpg : IConvertable
    {
        public void Convert(string sourcePath, string destinationPath)
        {
            using (Image image = Image.FromFile(sourcePath))
            {
                var qualityParam = new EncoderParameter(Encoder.Quality, 100L);
                var jpegCodec = ImageCodec.GetEncoderInfo("image/jpeg");

                var encoderParams = new EncoderParameters(1);
                encoderParams.Param[0] = qualityParam;

                image.Save(destinationPath, jpegCodec, encoderParams);
            }
        }
    }
}
