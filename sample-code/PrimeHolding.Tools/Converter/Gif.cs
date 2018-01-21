////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="Gif.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>02.01.2018 г.</date>
// <summary>Implements the GIF class</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools.Converter
{
    using System;
    using System.Drawing;

    class Gif : IConvertStrategy
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Image convert. </summary>
        ///
        /// <param name="sourceImage">      System.Drawing.Image instance of Source image. </param>
        /// <param name="destinationFile">  Path to destination file for converted image. </param>
        ///
        /// <seealso cref="M:PrimeHolding.Tools.Converter.IConvertStrategy.ImageConvert(Image,String)"/>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public void ImageConvert(Image sourceImage, String destinationFile)
        {
            sourceImage.Save(destinationFile, System.Drawing.Imaging.ImageFormat.Gif);
        }
    }
}