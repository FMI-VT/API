using ImagesProcess.Exceptions;
using System;

namespace ImagesProcess.Resize
{
    public class Resize : Images
    {
        private int width;
        private int height;
        private int x;
        private int y;
        private string srcPath;
        private string destPath;

        public Resize(string srcPath, string destPath, string operationType, int width, int height)
        {
            this.operationType = operationType;
            this.width = width;
            this.height = height;
            this.srcPath = srcPath;
            this.destPath = destPath;
        }

        public Resize(string srcPath, string destPath, string operationType, int width, int height, int x, int y)
        {
           
            this.operationType = operationType;
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
            this.srcPath = srcPath;
            this.destPath = destPath;
        }

        public override void Process()
        {
            Context strategy = new Context();
            switch (this.operationType)
            {
                case "crop":
                    strategy.SetStrategy(new Crop(srcPath, destPath, width, height, x, y));
                    break;
                case "skew":
                    strategy.SetStrategy(new Skew(srcPath, destPath, width, height));
                    break;
                case "keepAspect":
                    strategy.SetStrategy(new KeepAspectRatio(srcPath, destPath, width, height));
                    break;
                default: throw new IlegalOperationException("Unknown operation selected");
            }
            try
            {
                strategy.Process();
            } catch (System.IO.FileNotFoundException e)
            {
                throw new SrcFileNotFound("Wrong srcfile "+srcPath, e);
            }
        }
    }
}
