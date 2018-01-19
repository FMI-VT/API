using System;

namespace ImagerLib
{
    public class ImageAlreadyExistsException : Exception
    {
        public ImageAlreadyExistsException()
        {
        }

        public ImageAlreadyExistsException(string message) : base(message)
        {
        }

        public ImageAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
