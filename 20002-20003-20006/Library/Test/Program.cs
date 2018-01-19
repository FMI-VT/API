using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcess.Converter;
using System.IO;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //    ImageProcess.Converter.Convert convert = new ImageProcess.Converter.Convert(@"D:\test\test.gif", @"Dsdasd\test\test", "png");
            //    convert.Execute();


            //skew and keepaspect have to have different dest path (can not be same as src path);
            ImageProcess.Resizer.Resize resize = new ImageProcess.Resizer.Resize(@"D:\test\k.gif", @"D:\test\k.gif", "skew", 600, 400);
            resize.Execute();
            Console.ReadKey(true);
        }
    }
}
