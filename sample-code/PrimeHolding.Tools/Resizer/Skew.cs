﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="Skew.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>02.01.2018 г.</date>
// <summary>Implements the skew class</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools.Resizer
{
    using System;
    using System.Drawing;

    /// <summary>   A skew. </summary>
    class Skew : IResizeStrategy
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Image resize. </summary>
        ///
        /// <param name="sourceImage">      Source file. </param>
        /// <param name="destinationFile">  Destination file. </param>
        /// <param name="destWidth">        Width of the destination. </param>
        /// <param name="destHeight">       Height of the destination. </param>
        ///
        /// <seealso cref="M:PrimeHolding.Tools.Resizer.ResizerStrategy.ImageResize(Image,String,int,int)"/>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public void ImageResize(Image sourceImage, String destinationFile, int destWidth, int destHeight)
        {
            Bitmap destinationImage = new Bitmap(sourceImage, destWidth, destHeight);
            destinationImage.Save(destinationFile, sourceImage.RawFormat);
            destinationImage.Dispose();
        }
    }
}
