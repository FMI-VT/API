using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary
{
    public class InvalidImageDimensionException : Exception
    {
        public InvalidImageDimensionException()
        {

        }

        public InvalidImageDimensionException(string message) : base(message)
        {

        }

        public InvalidImageDimensionException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}