using System.Drawing.Imaging;
using System.Linq;

namespace ImagerLib.Helpers
{
    internal class ImageCodec
    {
        public static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            return ImageCodecInfo.GetImageEncoders().FirstOrDefault(t => t.MimeType == mimeType);
        }
    }
}
