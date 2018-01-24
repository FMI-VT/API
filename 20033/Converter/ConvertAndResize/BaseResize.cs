using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Converter.ConvertAndResize
{
    internal abstract class BaseResize
    {
        protected static void ValidateWidthHeight(int width, int height)
        {
            if (width < 1)
            {
                throw new ArgumentOutOfRangeException("width", "Width more than 0");
            }
            else if (height < 1)
            {
                throw new ArgumentOutOfRangeException("height", "Height more than 0");
            }
        }
    }
}