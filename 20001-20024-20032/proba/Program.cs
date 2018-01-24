//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeHoldingImage.Resizer;
using PrimeHoldingImage.Converter;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            //PrimeHoldingImage.Convert res = new PrimeHoldingImage.Convert();
            //res.ConvertImage("C:/Users/Xenomorph/Desktop/Untitled01.png", "C:/Users/Xenomorph/Desktop/Converted.gif", "gif");
            PrimeHoldingImage.Resize ress = new PrimeHoldingImage.Resize();
            ress.Process("C:/Users/Xenomorph/Desktop/Untitled.png", "C:/Users/Xenomorph/Desktop/Untitled.test", "scew", 500, 300, 0, 0);
        }
    }
}
