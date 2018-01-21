////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="InvalidParameterException.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>02.01.2018 г.</date>
// <summary>Implements the invalid parameter exception class</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools.Common.Exceptions
{
    using System;

    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    ///     (Serializable) exception for signalling invalid parameter errors. This class cannot be
    ///     inherited.
    /// </summary>
    ///
    /// <seealso cref="T:System.Exception"/>
    ///////////////////////////////////////////////////////////////////////////////////////////////

    [Serializable]
    public sealed class InvalidParameterException : GenericException
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the
        ///     PrimeHolding.Tools.Common.Exceptions.InvalidParameterException class.
        /// </summary>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public InvalidParameterException()
        {
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the
        ///     PrimeHolding.Tools.Common.Exceptions.InvalidParameterException class.
        /// </summary>
        ///
        /// <param name="message">  The message. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public InvalidParameterException(string message) : base(message)
        {
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the
        ///     PrimeHolding.Tools.Common.Exceptions.InvalidParameterException class.
        /// </summary>
        ///
        /// <param name="message">          The message. </param>
        /// <param name="innerException">   The inner exception. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public InvalidParameterException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
