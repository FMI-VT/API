using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageProjectWebAPI.BindModels
{
    public class ResizeBindModel : BaseBindModel
    {
        public int width { get; set; }
        public int height { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }
}