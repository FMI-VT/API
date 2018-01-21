﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="ResizerContext.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>02.01.2018 г.</date>
// <summary>Implements the resizer context class</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools.Resizer
{
    using System;
    using System.Drawing;

    /// <summary>   A resizer context. </summary>
    class ResizerContext
    {
        /// <summary>   The resizer. </summary>
        IResizeStrategy resizer;

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Initializes a new instance of the PrimeHolding.Tools.Resizer.ResizerContext class.
        /// </summary>
        ///
        /// <param name="resizer">  The resizer. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public ResizerContext(IResizeStrategy resizer)
        {
            this.resizer = resizer;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Resize image. </summary>
        ///
        /// <remarks>   Arruor, 08.01.2018 г. </remarks>
        ///
        /// <param name="sourceFile">       Source file. </param>
        /// <param name="destinationFile">  Destination file. </param>
        /// <param name="destWidth">        Width of the destination. </param>
        /// <param name="destHeight">       The destheight. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public void ResizeImage(Image sourceFile, String destinationFile, int destWidth, int destHeight)
        {
            this.resizer.ImageResize(sourceFile, destinationFile, destWidth, destHeight);
        }
    }
}
