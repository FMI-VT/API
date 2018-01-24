using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary
{
    public class IfImageAlreadyExistsException : Exception
    {
        public IfImageAlreadyExistsException()
        {

        }

        public IfImageAlreadyExistsException(string message) : base(message)
        {

        }

        public IfImageAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}