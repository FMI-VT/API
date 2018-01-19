using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Exception
{
    class DestinationFileNameException : GenericException
    {
        public DestinationFileNameException()
        {
        }

        public DestinationFileNameException(string message) : base(message)
        {
        }
    }
}
