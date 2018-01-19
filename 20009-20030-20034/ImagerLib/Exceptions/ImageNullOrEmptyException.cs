using System;

namespace ImagerLib
{
    public class ImageNullOrEmptyException : Exception
    {
        public ImageNullOrEmptyException()
        {
        }

        public ImageNullOrEmptyException(string message) : base(message)
        {
        }

        public ImageNullOrEmptyException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
