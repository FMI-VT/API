using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagerLib.Example.Wpf.ViewModels
{
    internal class ConvertViewModel : BaseViewModel
    {
        public ConvertType ConvertType { get; set; }

        public string FileName { get; set; }

        public ConvertViewModel()
        {
            DestinationPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FileName = "converted-image";
        }
    }
}
