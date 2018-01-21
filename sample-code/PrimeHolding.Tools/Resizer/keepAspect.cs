﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="keepAspect.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>02.01.2018 г.</date>
// <summary>Implements the keep aspect class</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools.Resizer
{
    using System;
    using System.Drawing;
    using PrimeHolding.Tools.Common.Exceptions;

    /// <summary>   A keep aspect. </summary>
    class KeepAspect : IResizeStrategy
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Image resize. </summary>
        ///
        /// <exception cref="InvalidAspectRatioException">  Thrown when an Invalid Aspect Ratio error
        ///                                                 condition occurs. </exception>
        ///
        /// <param name="sourceImage">      Source image. </param>
        /// <param name="destinationFile">  Destination file. </param>
        /// <param name="destWidth">        Width of the destination. </param>
        /// <param name="destHeight">       Height of the destination. </param>
        ///
        /// <seealso cref="M:PrimeHolding.Tools.Resizer.KeepAspect.ImageResize(Image,String,int,int)"/>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public void ImageResize(Image sourceImage, String destinationFile, int destWidth, int destHeight)
        {
            double srcAspect = sourceImage.Width / sourceImage.Height;
            double destAspect = destWidth / destHeight;

            if (Math.Round(srcAspect, 2) != Math.Round(destAspect, 2))
            {
                throw new InvalidAspectRatioException("Source and destination aspect ratios must be same!");
            }
            
            Bitmap destinationImage = new Bitmap(sourceImage, destWidth, destHeight);
            destinationImage.Save(destinationFile, sourceImage.RawFormat);
            destinationImage.Dispose();
        }
    }
}