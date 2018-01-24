using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary.Modules.Converter
{
    interface IConvertable
    {
        void Convert(string sourcePath, string destinationPath);
    }
}