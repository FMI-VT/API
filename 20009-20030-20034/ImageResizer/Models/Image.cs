//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImageResizer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Web;
    using System.Drawing;

    public partial class Image
    {
        public int ImageId { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }

        //public Image ImageDetails { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
