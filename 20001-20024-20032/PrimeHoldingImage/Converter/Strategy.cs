using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Converter
{
    abstract class ConvertStrategy
    {
        abstract public string Convert(string sourceFile, string destinationFile);
    }
}
