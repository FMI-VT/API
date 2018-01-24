using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Converter.Exceptions
{
    [Serializable]
    public class MainExeption : Exception
    {
        public MainExeption() { }
        public MainExeption(string message) : base(message) { }
        public MainExeption(string message, Exception inner) : base(message, inner) { }
        protected MainExeption(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class InvalidResizeException : ArgumentOutOfRangeException
    {
        public InvalidResizeException() { }
        public InvalidResizeException(string message) : base(message) { }
        public InvalidResizeException(string message, Exception inner) : base(message, inner) { }
        protected InvalidResizeException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}