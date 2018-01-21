////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="Jpeg.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>02.01.2018 г.</date>
// <summary>Implements the JPEG class</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools.Converter
{
    using System;
    using System.Drawing;

    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A jpeg. </summary>
    ///
    /// <seealso cref="T:PrimeHolding.Tools.Converter.IConvertStrategy"/>
    ///////////////////////////////////////////////////////////////////////////////////////////////

    class Jpeg : IConvertStrategy
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Image convert. </summary>
        ///
        /// <param name="sourceImage">      Source image. </param>
        /// <param name="destinationFile">  Destination file. </param>
        ///
        /// <seealso cref="M:PrimeHolding.Tools.Converter.IConvertStrategy.ImageConvert(Image,String)"/>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public void ImageConvert(Image sourceImage, String destinationFile)
        {
            sourceImage.Save(destinationFile, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
