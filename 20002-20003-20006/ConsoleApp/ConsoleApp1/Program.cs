using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var srcpath = "";
            var destpath = "";
            var type = "";
            int height = Convert.ToInt32(true);
            int width = Convert.ToInt32(true);


            Console.WriteLine("Welcome");
            Console.WriteLine("[C]onvert or [R]esize");
            string choice = Console.ReadLine();
            switch (choice.ToUpper())
            {
                case "C":
                    {
                        Console.WriteLine("Add source image:");
                        srcpath = Console.ReadLine();
                        Console.WriteLine("Where to save image:");
                        destpath = Console.ReadLine();
                        Console.WriteLine("Add image type(jpg / gif / png)?");
                        type =Console.ReadLine();

                        ImageProcess.Converter.Convert convert = new ImageProcess.Converter.Convert(srcpath,destpath,type);
                        convert.Execute();
                        Console.WriteLine("Done!");
                        break;
                    }
                case "R":
                    {
                        Console.WriteLine("Add source image:");
                        srcpath = Console.ReadLine();
                        Console.WriteLine("Where to save image:");
                        destpath = Console.ReadLine();
                        Console.WriteLine("Add image height:");
                        height = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Add image width:");
                        width = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Add resizing type(crop / keepaspect / skew )?");
                        type = Console.ReadLine();

                        ImageProcess.Resizer.Resize resize = new ImageProcess.Resizer.Resize(srcpath, destpath, type, width, height);
                        resize.Execute();
                        Console.WriteLine("Done!");
                        break;
                    }
            }
           


           // ImageProcess.Resizer.Resize resize = new ImageProcess.Resizer.Resize(srcpath,destpath, type, width, height);
           // resize.Execute();
           // Console.WriteLine("Done!");
            
            /*
            ImageProcess.Converter.Convert convert = new ImageProcess.Converter.Convert(@"E:\fox.jpg", @"E:\foxCon.gif", "gif");
            convert.Execute();
            Console.WriteLine("Done!");
            
            //1.59 
          
            ImageProcess.Resizer.Resize resize = new ImageProcess.Resizer.Resize(@"E:\fox.jpg", @"E:\fox1.jpg", "keepaspect",350,220 );
            resize.Execute();
            Console.WriteLine("Done!");
            
            
            ImageProcess.Resizer.Resize resize = new ImageProcess.Resizer.Resize(@"E:\fox.jpg", @"E:\fox1.jpg", "skew", 480, 220);
            resize.Execute();
            Console.WriteLine("Done!");
           */
        }
    }
}
