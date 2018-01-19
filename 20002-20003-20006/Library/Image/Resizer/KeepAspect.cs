////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	resizer\keepaspect.cs
//
// summary:	Implements the keepaspect class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcess.Resizer
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A keep aspect. </summary>
    ///
    /// <remarks>   Viki, 11/1/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class KeepAspect : BaseResize
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Viki, 11/1/2018. </remarks>
        ///
        /// <param name="srcPath">  Full pathname of the source file. </param>
        /// <param name="destPath"> Full pathname of the destination file. </param>
        /// <param name="width">    The width. </param>
        /// <param name="height">   The height. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public KeepAspect(string srcPath, string destPath, int width, int height) : base(srcPath, destPath, width, height)
        {
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Executes this object. </summary>
        ///
        /// <remarks>   Viki, 11/1/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public override void Execute()
        {
            Image imgToResize = Image.FromFile(srcPath);

            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            double sourceAspect = sourceWidth / sourceHeight;
            double destAspect = this.width / this.height;

            if (Math.Round(sourceAspect, 2) != (destAspect))
            {
                throw new Exceptions.MyOutOfMemoryException("There is a problem.");
               
            }
            else
            {
                Bitmap destImage = new Bitmap(imgToResize, this.width, this.height);
                destImage.Save(destPath, imgToResize.RawFormat);
                destImage.Dispose();
            }
        }
    }
}
