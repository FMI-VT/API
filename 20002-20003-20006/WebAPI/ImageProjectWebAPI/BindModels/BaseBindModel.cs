using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageProjectWebAPI.BindModels
{
    public abstract class BaseBindModel
    {
        public string srcPath { get; set; }
        public string destPath { get; set; }
        public string type { get; set; }
    }
}