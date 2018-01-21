////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="FileNotReadableException.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>02.01.2018 г.</date>
// <summary>Implements the file not readable exception class</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools.Common.Exceptions
{
    using System;

    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    ///     (Serializable) exception for signalling file not readable errors. This class cannot be
    ///     inherited.
    /// </summary>
    ///
    /// <seealso cref="T:PrimeHolding.Tools.Common.Exceptions.GenericException"/>
    ///////////////////////////////////////////////////////////////////////////////////////////////

    [Serializable]
    public sealed class FileNotReadableException : GenericException
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the
        ///     PrimeHolding.Tools.Common.Exceptions.FileNotReadableException class.
        /// </summary>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public FileNotReadableException()
        {
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the
        ///     PrimeHolding.Tools.Common.Exceptions.FileNotReadableException class.
        /// </summary>
        ///
        /// <param name="message">  The message. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public FileNotReadableException(string message) : base(message)
        {
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the
        ///     PrimeHolding.Tools.Common.Exceptions.FileNotReadableException class.
        /// </summary>
        ///
        /// <param name="message">          The message. </param>
        /// <param name="innerException">   The inner exception. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public FileNotReadableException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
