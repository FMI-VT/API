﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Resizer\Context.cs
//
// summary:	Implements the context class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcess.Resizer
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A context. </summary>
    ///
    /// <remarks>   Viki, 8/1/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class Context
    {
        /// <summary>   The resize. </summary>
        protected BaseResize resize;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Sets a strategy. </summary>
        ///
        /// <remarks>   Viki, 8/1/2018. </remarks>
        ///
        /// <param name="resize">   The resize. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void SetStrategy(BaseResize resize)
        {
            this.resize = resize;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Executes this object. </summary>
        ///
        /// <remarks>   Viki, 8/1/2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Execute()
        {
            this.resize.Execute();
        }
    }
}
