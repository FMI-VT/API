﻿using System;

namespace ImagerLib
{
    public class InvalidImageException : Exception
    {
        public InvalidImageException()
        {
        }

        public InvalidImageException(string message) : base(message)
        {
        }

        public InvalidImageException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
