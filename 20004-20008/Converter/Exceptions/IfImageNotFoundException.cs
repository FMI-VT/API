using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary
{
    public class IfImageNotFoundException : Exception
    {
        public IfImageNotFoundException() 
        {

        }

        public IfImageNotFoundException(string message) : base(message)
        {

        }

        public IfImageNotFoundException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}