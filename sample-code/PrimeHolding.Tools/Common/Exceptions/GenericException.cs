////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="GenericException.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>02.01.2018 г.</date>
// <summary>Implements the generic exception class</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools.Common.Exceptions
{
    using System;

    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   (Serializable) exception for signalling generic errors. </summary>
    ///
    /// <seealso cref="T:System.Exception"/>
    ///////////////////////////////////////////////////////////////////////////////////////////////

   [Serializable]
    public class GenericException : Exception
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the PrimeHolding.Tools.Common.Exceptions.GenericException
        ///     class.
        /// </summary>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public GenericException()
        {
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the PrimeHolding.Tools.Common.Exceptions.GenericException
        ///     class.
        /// </summary>
        ///
        /// <param name="message">  The message. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public GenericException(string message) : base(message)
        {
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the PrimeHolding.Tools.Common.Exceptions.GenericException
        ///     class.
        /// </summary>
        ///
        /// <param name="message">          The message. </param>
        /// <param name="innerException">   The inner exception. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public GenericException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
