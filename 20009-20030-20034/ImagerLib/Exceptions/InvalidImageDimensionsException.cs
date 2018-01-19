using System;

namespace ImagerLib
{
    public class InvalidImageDimensionsException : Exception
    {
        public InvalidImageDimensionsException()
        {
        }

        public InvalidImageDimensionsException(string message) : base(message)
        {
        }

        public InvalidImageDimensionsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
