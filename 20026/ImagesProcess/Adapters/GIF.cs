using System;
using System.Drawing;

namespace ImagesProcess.Converter
{
    class GIF : Adapters.BaseConvert
    {
        public GIF(string srcPath, string destPath) : base(srcPath, destPath)
        {

        }

        public override void Process()
        {
            Image img = Image.FromFile(this.srcPath);
            img.Save(destPath, System.Drawing.Imaging.ImageFormat.Gif);
        }
    }
}
