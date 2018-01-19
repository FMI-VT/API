using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageAPI.Strategies
{
    public class CropStrategy:IEditStrategy
    {

        public void Edit ()
        {

            //Cropping image strategy
            //Uses an image from a sourcepath, provided by user input 
            //Crops the image and creates a new image 
            //Using the graphics library it does a high quality cropping
            //This class uses source(string), width(int), height(int) and destinationPath(string) as user inputs 

            try
            {
                ImageClass img = new ImageClass();
                //Must provide full path with picture name and extension (e.g C:/Desktop/image.jpg)
                Console.WriteLine("Enter source path: ");
                img.Source = Console.ReadLine();
                //Width and height are simple integers, px not needed after the digit
                Console.WriteLine("Enter desired width: ");
                int width = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter desired height: ");
                int height = int.Parse(Console.ReadLine());
                //Must provide full path with picture name and extension (e.g C:/Desktop/image.jpg)
                Console.WriteLine("Enter desired location to store file: ");
                img.DestinationPath = Console.ReadLine();
                Bitmap bmp = new Bitmap(img.Source);

                //Creating a new bitmap
                var destRect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                var destImage = new Bitmap(width, height);

                //Setting the desired width and height for the new image
                destImage.SetResolution(bmp.Width, bmp.Height);

                //High image quality resizing
                using (var graphics = Graphics.FromImage(destImage))
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        graphics.DrawImage(bmp, destRect, 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, wrapMode);
                    }
                }

                destImage.Save(img.DestinationPath);
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
