using System;
using System.Drawing;

namespace ImagesProcess.Converter
{
    class PNG : Adapters.BaseConvert
    {
        public PNG(string srcPath, string destPath) : base(srcPath, destPath)
        {

        }

        public override void Process()
        {
            Image img = Image.FromFile(this.srcPath);
            img.Save(destPath, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
