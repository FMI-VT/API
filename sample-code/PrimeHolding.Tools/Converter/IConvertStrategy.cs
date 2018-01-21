////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="IConvertStrategy.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>02.01.2018 г.</date>
// <summary>Declares the IConvertStrategy interface</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools.Converter
{
    using System;
    using System.Drawing;

    /// <summary>   Interface for convert strategy. </summary>
    interface IConvertStrategy
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Image convert. </summary>
        ///
        /// <param name="sourceImage">      Source image. </param>
        /// <param name="destinationFile">  Destination file. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        void ImageConvert(Image sourceImage, String destinationFile);
    }
}