using ImagesProcess.Exceptions;

namespace ImagesProcess.Converter

{
    public class Convert : Images
    {
        public Convert(string srcPath, string destPath, string operationType)
        {
            this.srcPath = srcPath;
            this.destPath = destPath;
            this.operationType = operationType;
        }

        public override void Process()
        {
          
            Context strategy = new Context();
            
            switch (operationType)
            {
                case "jpg":
                    strategy.SetStrategy(new JPG(srcPath, destPath));
                    break;
                case "gif":
                    strategy.SetStrategy(new GIF(srcPath, destPath));
                    break;
                case "png":
                    strategy.SetStrategy(new PNG(srcPath, destPath));
                    break;
                default: throw new IlegalOperationException("Unknow convert to format");
            }
            
            strategy.Process();
        }
    }
}
