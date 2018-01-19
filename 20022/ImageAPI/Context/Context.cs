using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using ImageAPI.Strategies;

namespace ImageAPI
{
    public class Context
    {
        public void Initialize()
        {
            //Entry point for our DLL
            //Here you chose an option by entering the desired number and the switch case will take you to the desired strategy class
            //Warning! If choice is incorrect program will not close as its inside an endless loop untill a correct option is selected 
            //or the user choses to exit

            while (true)
            {
                int choice = 0;
                Console.WriteLine("What would you like:\n1:Convert\n2:Resize with aspect ratio\n3:Crop an image\n4:Skew\n5:Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ConvertStrategy cs = new ConvertStrategy();
                        cs.Edit();
                        Console.WriteLine("Done!");
                        Console.WriteLine();
                        break;
                    case 2:
                        ResizeKARStrategy ras = new ResizeKARStrategy();
                        ras.Edit();
                        Console.WriteLine("Done!");
                        Console.WriteLine();
                        break;
                    case 3:
                        CropStrategy crp = new CropStrategy();
                        crp.Edit();
                        Console.WriteLine("Done!");
                        Console.WriteLine();
                        break;
                    case 4:
                        SkewStrategy ss = new SkewStrategy();
                        ss.Edit();
                        Console.WriteLine("Done!");
                        Console.WriteLine();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("You have chosen an incorrect option!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }              
            }
        }
	}
}
