using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using img;

namespace Execution
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1("D:\\User Files\\Desktop\\pics\\IMAG0415.jpg", "D:\\User Files\\Desktop\\TestImages\\Resized\\IMA04.jpg", "Crop", 0, 0, 4224 , 2368);
            c.ExecuteStrategy();

            Class1 png = new Class1("D:\\User Files\\Desktop\\pics\\IMAG0037.jpg", "D:\\User Files\\Desktop\\TestImages\\Converted\\IMAG0037png.png", "ConvertToPNG");
            png.ExecuteStrategy();

            Class1 jpg = new Class1("D:\\User Files\\Desktop\\pics\\IMAG0037.jpg", "D:\\User Files\\Desktop\\TestImages\\Converted\\IMAG0037jpg.jpg", "ConvertToJPG");
            jpg.ExecuteStrategy();

            Class1 gif = new Class1("D:\\User Files\\Desktop\\pics\\IMAG0037.jpg", "D:\\User Files\\Desktop\\TestImages\\Converted\\IMAG0037gif.gif", "ConvertToGIF");
            gif.ExecuteStrategy();
            
            Console.ReadKey();
        }

    }
}
