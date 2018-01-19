using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageResizer.Models
{
    public class ImageCommon
    {
        public string Path { get; set; }

        public System.Drawing.Image ImageDetails { get; set; }

        public int Height { get; set; }
        
        public int Width { get; set; }
        //e tuka novi dve propartita width i heigth, deto da se zadavat vav view-to
    }
}