using System;

namespace ImagerLib
{
    public class InvalidAspectRatioException : Exception
    {
        public InvalidAspectRatioException()
        {
        }

        public InvalidAspectRatioException(string message) : base(message)
        {
        }

        public InvalidAspectRatioException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
