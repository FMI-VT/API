////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="FileNotWritableException.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>02.01.2018 г.</date>
// <summary>Implements the file not writable exception class</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools.Common.Exceptions
{
    using System;

    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    ///     (Serializable) exception for signalling file not writable errors. This class cannot be
    ///     inherited.
    /// </summary>
    ///
    /// <seealso cref="T:PrimeHolding.Tools.Common.Exceptions.GenericException"/>
    ///////////////////////////////////////////////////////////////////////////////////////////////

    [Serializable]
    public sealed class FileNotWritableException : GenericException
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the
        ///     PrimeHolding.Tools.Common.Exceptions.FileNotWritableException class.
        /// </summary>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public FileNotWritableException()
        {
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the
        ///     PrimeHolding.Tools.Common.Exceptions.FileNotWritableException class.
        /// </summary>
        ///
        /// <param name="message">  The message. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public FileNotWritableException(string message) : base(message)
        {
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the
        ///     PrimeHolding.Tools.Common.Exceptions.FileNotWritableException class.
        /// </summary>
        ///
        /// <param name="message">          The message. </param>
        /// <param name="innerException">   The inner exception. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public FileNotWritableException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
