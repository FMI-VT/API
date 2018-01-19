////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	resizer\skew.cs
//
// summary:	Implements the skew class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcess.Resizer
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A skew. </summary>
    ///
    /// <remarks>   Viki, 11/1/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class Skew : BaseResize
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

        public Skew(string srcPath, string destPath, int width, int height) : base(srcPath, destPath, width, height)
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
            Bitmap destImage = new Bitmap(imgToResize, this.width, this.height);
            destImage.Save(destPath, imgToResize.RawFormat);
            destImage.Dispose();
        }
    }
}
