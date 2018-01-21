namespace PrimeHolding.Tools.Converter
{
    using System;
    using System.Drawing;

    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A png. </summary>
    ///
    /// <seealso cref="T:PrimeHolding.Tools.Converter.IConvertStrategy"/>
    ///////////////////////////////////////////////////////////////////////////////////////////////

    class Png : IConvertStrategy
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
            sourceImage.Save(destinationFile, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}