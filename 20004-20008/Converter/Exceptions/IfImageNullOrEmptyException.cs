using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary
{
    public class IfImageNullOrEmptyException : Exception
    {
        public IfImageNullOrEmptyException()
        {

        }

        public IfImageNullOrEmptyException(string message) : base(message)
        {

        }

        public IfImageNullOrEmptyException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}