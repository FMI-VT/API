using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesProcess.Exceptions
{
    class SrcFileNotReadible :Exception
    {
        public SrcFileNotReadible()
        {
        }

        public SrcFileNotReadible(string message)
        : base(message)
        {
        }

        public SrcFileNotReadible(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
