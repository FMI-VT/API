using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Exception
{
    class FileExtensionNotSupportedException : GenericException
    {
        public FileExtensionNotSupportedException()
        {
        }


        public FileExtensionNotSupportedException(string message) : base(message)
        {
        }
    }
}
