﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Images.cs
//
// summary:	Implements the images class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcess
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   An images. </summary>
    ///
    /// <remarks>   Viki, 8/1/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public abstract class Images
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the full pathname of the source file. </summary>
        ///
        /// <value> The full pathname of the source file. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string srcPath { get; set; }   

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the full pathname of the destination file. </summary>
        ///
        /// <value> The full pathname of the destination file. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string destPath { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the type. </summary>
        ///
        /// <value> The type. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string type { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Viki, 8/1/2018. </remarks>
        ///
        /// <param name="srcPath">  Full pathname of the source file. </param>
        /// <param name="destPath"> Full pathname of the destination file. </param>
        /// <param name="type">     The type. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Images(string srcPath, string destPath, string type)
        {
            this.srcPath = srcPath;
            this.destPath = destPath;
            this.type = type;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Executes this object. </summary>
        ///
        /// <remarks>   Viki, 8/1/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public abstract void Execute();
    }
}
