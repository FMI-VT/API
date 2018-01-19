using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagerLib.Example.Wpf.ViewModels
{
    internal class CropViewModel : BaseViewModel
    {
        public string FileName { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int StartX { get; set; }

        public int StartY { get; set; }

        public CropViewModel()
        {
            DestinationPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FileName = "cropped-image";
        }
    }
}
