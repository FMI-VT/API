using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesProcess.Exceptions
{
    class GeneralException : Exception
    {
        public GeneralException()
        {
        }

        public GeneralException(string message)
        : base(message)
        {
        }

        public GeneralException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
