using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Exception
{
    public class GenericException : System.Exception
    {
        public GenericException()
        {
        }

        public GenericException(string message) : base(message)
        {
        }

        public GenericException(string message, System.Exception inner) : base(message, inner)
        {
        }
    }
}