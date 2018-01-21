﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="IResizeStrategy.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>08.01.2018 г.</date>
// <summary>Declares the IResizeStrategy interface</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools.Resizer
{
    using System;
    using System.Drawing;

    /// <summary>   Interface for resize strategy. </summary>
    interface IResizeStrategy
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Image resize. </summary>
        ///
        /// <param name="sourceFile">       Source file. </param>
        /// <param name="destinationFile">  Destination file. </param>
        /// <param name="destWidth">        Width of the destination. </param>
        /// <param name="destHeight">       Height of the destination. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        void ImageResize(Image sourceFile, String destinationFile, int destWidth, int destHeight);
    }
}
