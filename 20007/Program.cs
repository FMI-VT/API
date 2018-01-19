using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using ClassLibrary2;

namespace ImageConverter
{
    class Program
    {
        static void Resize(string imgFile, string OutputFile)
        {
            Console.WriteLine("Please input scale factor if you want. If you do not want enter (0): ");
            double ScaleFactor = double.Parse(Console.ReadLine());

            var srcImage = Image.FromFile(imgFile);
            int newWidth = srcImage.Width;
            int newHeight = srcImage.Height;

            if (ScaleFactor == 0)
            {
                Console.WriteLine("Enter the Width: ");
                newWidth = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Height: ");
                newHeight = int.Parse(Console.ReadLine());
            }
            Class1.ResizeImage(imgFile, OutputFile, ScaleFactor, newWidth, newHeight);
        }

        static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            // MAIN MENU FOR THE PROGRAM
            Console.Write("Welcome to the image Resizer/Converter Program. Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine("Pic a directory to input an image (EXAMPLE --> C:\\pictures\\picture1.jpg): ");
            string imgFile = Console.ReadLine();            
            
            Console.WriteLine("Pick a directory to save the image: (EXAMPLE --> C:\\pictures\\picture1): ");
            string OutputFile = Console.ReadLine();         
                     
            
            Console.Write(" \n \n What do you want to do with the image? R(esize), C(onvert) or Q(uit) the program: ");
            casetest(imgFile,OutputFile);

        }
            // RECURSION
        static void casetest(string imgFile,string OutputFile)
        {
            string choice = Console.ReadLine();
            switch (choice.ToUpper())
            {
                case "R":
                    Resize(imgFile, OutputFile);
                    break;
                case "C":
                    Console.WriteLine("Please choose a format type (PNG), (JPG), (GIF) or (BMP):");
                    string FileFormat = Console.ReadLine();
                    Class1.ImageConvert(imgFile,OutputFile,FileFormat);
                    break;
                case "Q":
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try Again!");
                    casetest(imgFile,OutputFile);
                    break;
            }
        }
        
    }
}

