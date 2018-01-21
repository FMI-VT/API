////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="InvalidAspectRatioException.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>02.01.2018 г.</date>
// <summary>Implements the invalid aspect ratio exception class</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools.Common.Exceptions
{
    using System;

    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    ///     (Serializable) exception for signalling invalid aspect ratio errors. This class cannot be
    ///     inherited.
    /// </summary>
    ///
    /// <seealso cref="T:PrimeHolding.Tools.Common.Exceptions.GenericException"/>
    ///////////////////////////////////////////////////////////////////////////////////////////////

    [Serializable]
    public sealed class InvalidAspectRatioException : GenericException
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the
        ///     PrimeHolding.Tools.Common.Exceptions.InvalidAspectRatioException class.
        /// </summary>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public InvalidAspectRatioException()
        {
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the
        ///     PrimeHolding.Tools.Common.Exceptions.InvalidAspectRatioException class.
        /// </summary>
        ///
        /// <param name="message">  The message. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public InvalidAspectRatioException(string message) : base(message)
        {
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the
        ///     PrimeHolding.Tools.Common.Exceptions.InvalidAspectRatioException class.
        /// </summary>
        ///
        /// <param name="message">          The message. </param>
        /// <param name="innerException">   The inner exception. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public InvalidAspectRatioException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
