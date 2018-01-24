using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary.Modules.Resizer
{
    interface IResizable
    {
        void Resize(string sourcePath, string destinationPath, int width, int height);
    }
}