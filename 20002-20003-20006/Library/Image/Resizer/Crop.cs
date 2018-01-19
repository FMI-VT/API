////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	resizer\crop.cs
//
// summary:	Implements the crop class
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
    /// <summary>   A crop. </summary>
    ///
    /// <remarks>   Viki, 11/1/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class Crop : BaseResize
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
        /// <param name="x">        The x coordinate. </param>
        /// <param name="y">        The y coordinate. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Crop(string srcPath, string destPath, int width, int height, int x, int y) : base(srcPath, destPath, width, height, x, y)
        {
            this.x = x;
            this.y = y;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Executes this object. </summary>
        ///
        /// <remarks>   Viki, 11/1/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public override void Execute()
        {
          Bitmap croppedImage;

          using (var originalImage = new Bitmap(srcPath))
            {
                Rectangle crop = new Rectangle(x, y, width, height);        
                croppedImage = originalImage.Clone(crop, originalImage.PixelFormat);

            } 

          
            croppedImage.Save(destPath);

            
            croppedImage.Dispose();
        }
    }
}
