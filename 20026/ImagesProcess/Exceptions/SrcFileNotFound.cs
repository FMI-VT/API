using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesProcess.Exceptions
{
    public class SrcFileNotFound : Exception
    {
        public SrcFileNotFound()
        {
        }

        public SrcFileNotFound(string message)
        : base(message)
        {
        }

        public SrcFileNotFound(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
