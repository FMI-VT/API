﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Converter\BaseConvert.cs
//
// summary:	Implements the base convert class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcess.Converter
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A base convert. </summary>
    ///
    /// <remarks>   Viki, 8/1/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public abstract class BaseConvert
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the full pathname of the source file. </summary>
        ///
        /// <value> The full pathname of the source file. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        protected string srcPath { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the full pathname of the destination file. </summary>
        ///
        /// <value> The full pathname of the destination file. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        protected string destPath { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Viki, 8/1/2018. </remarks>
        ///
        /// <param name="srcPath">  Full pathname of the source file. </param>
        /// <param name="destPath"> Full pathname of the destination file. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public BaseConvert(string srcPath, string destPath)
        {
            this.srcPath = srcPath;
            this.destPath = destPath;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Executes this object. </summary>
        ///
        /// <remarks>   Viki, 8/1/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public abstract void Execute();
    }
}
