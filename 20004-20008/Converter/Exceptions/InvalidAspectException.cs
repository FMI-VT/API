using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary
{
    public class InvalidAspectException : Exception
    {
        public InvalidAspectException()
        {

        }

        public InvalidAspectException(string message) : base(message)
        {

        }

        public InvalidAspectException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}