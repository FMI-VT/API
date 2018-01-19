using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagerLib.Modules.Converter
{
    interface IConvertable
    {
        void Convert(string sourcePath, string destinationPath);
    }
}
