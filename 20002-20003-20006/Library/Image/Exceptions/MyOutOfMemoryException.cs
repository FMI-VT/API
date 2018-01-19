////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Exceptions\MyOutOfMemoryException.cs
//
// summary:	Implements my out of memory exception class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcess.Exceptions
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   (Serializable) exception for signalling my out of memory errors. </summary>
    ///
    /// <remarks>   Viki, 11/1/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    [Serializable()]
    public class MyOutOfMemoryException : Exception
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Viki, 11/1/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public MyOutOfMemoryException()
        {
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Specialised constructor for use only by derived class. </summary>
        ///
        /// <remarks>   Viki, 11/1/2018. </remarks>
        ///
        /// <param name="message">  The message. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public MyOutOfMemoryException(string message) : base(message)
        {
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Specialised constructor for use only by derived class. </summary>
        ///
        /// <remarks>   Viki, 11/1/2018. </remarks>
        ///
        /// <param name="message">          The message. </param>
        /// <param name="innerException">   The inner exception. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public MyOutOfMemoryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Specialised constructor for use only by derived class. </summary>
        ///
        /// <remarks>   Viki, 11/1/2018. </remarks>
        ///
        /// <param name="info">     The information. </param>
        /// <param name="context">  The context. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        protected MyOutOfMemoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
