////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="ConverterContext.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>02.01.2018 г.</date>
// <summary>Implements the converter context class</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools.Converter
{
    using System;
    using System.Drawing;

    /// <summary>   A converter context. </summary>
    class ConverterContext
    {
        /// <summary>   The converter. </summary>
        IConvertStrategy converter;

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Initializes a new instance of the PrimeHolding.Tools.Converter.ConverterContext class.
        /// </summary>
        ///
        /// <param name="converter">    The converter. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public ConverterContext(IConvertStrategy converter)
        {
            this.converter = converter;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Convert image. </summary>
        ///
        /// <param name="sourceImage">      Source image. </param>
        /// <param name="destinationFile">  Destination file. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public void ConvertImage(Image sourceImage, String destinationFile)
        {
            this.converter.ImageConvert(sourceImage, destinationFile);
        }
    }
}
