using ImagesProcess.Converter;

namespace ImagesProcess.Adapters
{
    public abstract class BaseConvert
    {
        protected string srcPath;
        protected string destPath;
        
        public BaseConvert(string srcPath, string destPath)
        {
            this.srcPath = srcPath;
            this.destPath = destPath;
        }

        public abstract void Process();
        
    }
}
