using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesProcess
{
    public abstract class Images
    {
        protected string srcPath { get; set; }
        protected string destPath { get; set; }
        protected string operationType { get; set; }
        public abstract void Process();
    }
}
