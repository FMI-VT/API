﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="Crop.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>08.01.2018 г.</date>
// <summary>Implements the crop class</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools.Resizer
{
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;

    /// <summary>   A crop. </summary>
    class Crop : IResizeStrategy
    {
        private int startX;
        private int startY;

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Initializes a new instance of the PrimeHolding.Tools.Resizer.Crop class.
        /// </summary>
        ///
        /// <param name="x">    The x coordinate. </param>
        /// <param name="y">    The y coordinate. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public Crop(int x, int y)
        {
            this.startX = x;
            this.startY = y;
        }

       ////////////////////////////////////////////////////////////////////////////////////////////
       /// <summary>    Image resize. </summary>
       ///
       /// <param name="sourceImage">       Source file. </param>
       /// <param name="destinationFile">   Destination file. </param>
       /// <param name="destWidth">         Width of the destination. </param>
       /// <param name="destHeight">        Height of the destination. </param>
       ////////////////////////////////////////////////////////////////////////////////////////////

       public void ImageResize(Image sourceImage, string destinationFile, int destWidth, int destHeight)
       {
            Bitmap bmp = new Bitmap(destWidth, destHeight, PixelFormat.Format24bppRgb);
            bmp.SetResolution(80, 60);

            Graphics gfx = Graphics.FromImage(bmp);
            gfx.SmoothingMode = SmoothingMode.AntiAlias;
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;
            gfx.DrawImage(sourceImage, new Rectangle(0, 0, destWidth, destHeight), this.startX, this.startY, destWidth, destHeight, GraphicsUnit.Pixel);

            bmp.Save(destinationFile, sourceImage.RawFormat);

            sourceImage.Dispose();
            bmp.Dispose();
            gfx.Dispose();
        }
    }
}