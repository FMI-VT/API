using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using ImageAPI.Strategies;
using QuadrilateralDistortion;
using System.IO;

namespace ImageAPI.Strategies
{
    class SkewStrategy:IEditStrategy
    {
        public void Edit()
        {
            //Skewing strategy
            //By using 4(X,Y) Points from user input it distorts the image with those coordinates 
            //using the QuadDistort additional class
            //This class uses source(string), 4 Points(int X, int Y) and destinationPath(string) as user inputs 

            try
            {
                //Must provide full path with picture name and extension (e.g C:/Desktop/image.jpg)
                Console.WriteLine("Enter the source path of your image: ");
                string source = Console.ReadLine();

                Console.WriteLine("Enter the first angle's X coordinate : ");
                int x1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the first angle's Y coordinate : ");
                int y1 = int.Parse(Console.ReadLine());
       
                Console.WriteLine("Enter the second angle's X coordinate: ");
                int x2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second angle's Y coordinate : ");
                int y2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the third angle's X coordinate: ");
                int x3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the third angle's Y coordinate : ");
                int y3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the fourth angle's X coordinate: ");
                int x4 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the fourth angle's Y, to change the perspective of the image: ");
                int y4 = int.Parse(Console.ReadLine());

                //Must provide full path with picture name and extension (e.g C:/Desktop/image.jpg)
                Console.WriteLine("Enter desired location to store file: ");
                string destinationPath = Console.ReadLine();

                Point topLeft = new Point(x1 , y1);
                Point topRight = new Point(x2, y2);
                Point bottomLeft = new Point(x3, y3);
                Point bottomRight = new Point(x4, y4);

                //Transofrming image to a Bitmap to use QuadDistort function
                Image imgPhoto = Image.FromFile(source);
                Bitmap transitionBmp = (Bitmap)imgPhoto;

                //Additional function that distorts image 
                Bitmap bmp = QuadDistort.Distort(transitionBmp, topLeft, topRight, bottomLeft, bottomRight);
                bmp.Save(destinationPath);
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("The specified file could not be found!");
                Console.WriteLine();
            }
            catch (FileLoadException)
            {
                Console.WriteLine("File could not be loaded!");
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, that is not a valid format!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("File name is too long!");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong...");
            }
        }

    }
}
