using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesProcess.Exceptions
{
    class IlegalOperationException : Exception
    {
        public IlegalOperationException()
        {
        }

        public IlegalOperationException(string message)
        : base(message)
        {
        }

        public IlegalOperationException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
