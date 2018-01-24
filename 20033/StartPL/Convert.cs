using Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPL
{
    class Convert
    {
        static void Main(string[] args)
        {
            Main resize = new Main("C:\\Users\\User\\Desktop\\az.jpg", "C:\\Users\\User\\Desktop\\azresized.jpg", "Resize", 50, 100, 400, 200);
            resize.ExecuteStrategy();

            Main png = new Main("C:\\Users\\User\\Desktop\\az.jpg", "C:\\Users\\User\\Desktop\\azpng.png", "ConvertToPNG");
            png.ExecuteStrategy();

            Main jpeg = new Main("C:\\Users\\User\\Desktop\\ripng.png", "C:\\Users\\User\\Desktop\\riAgainJPEG.jpeg", "ConvertToJPEG");
            jpeg.ExecuteStrategy();

            Console.WriteLine("Your image was succesfully converted and resized!");
            Console.ReadKey();
        }
    }
}
