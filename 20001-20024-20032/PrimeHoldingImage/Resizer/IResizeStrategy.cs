using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Resizer
{
    public interface IResizeStrategy
    {
        string Resize(string sourceFile, string destinationFile, int destinationWidth, int destinationHeight);

        string Resize(string sourceFile, string destinationFile, int x, int y, int destinationWidth, int destinationHeight);
    }
}
