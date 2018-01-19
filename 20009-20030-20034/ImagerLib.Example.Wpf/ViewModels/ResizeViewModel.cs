using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagerLib.Example.Wpf.ViewModels
{
    internal class ResizeViewModel : BaseViewModel
    {
        public string FileName { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public ResizeViewModel()
        {
            DestinationPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FileName = "resized-image";
        }
    }
}
