using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesProcess.Adapters
{
    public abstract class BaseResize
    {
        protected string srcPath;
        protected string destPath;
        protected int width;
        protected int height;


        public BaseResize(string srcPath, string destPath, int width, int height)
        {
            this.srcPath = srcPath;
            this.destPath = destPath;
            this.width = width;
            this.height = height;
        }
        public abstract void Process();
    }
}
