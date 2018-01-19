using System;  
using System.Drawing;

namespace ImagesProcess.Converter
{
    class JPG : Adapters.BaseConvert
    {
        public JPG(string srcPath, string destPath) : base(srcPath, destPath)
        {
            
        }

        public override void Process()
        {
            Image img = Image.FromFile(this.srcPath);
            img.Save(destPath, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
