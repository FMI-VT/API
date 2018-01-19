using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageAPI.Strategies
{
    public class ConvertStrategy:IEditStrategy
    {
        //The convert strategy takes an image from source path and by using the System.Drawing library
        //coverts the type of the image to the desired one ,which is given by user input as a string
        //This class uses Source,DestinationPath and Type for the image which are all strings

        public void Edit()
        {

            try
            {
                ImageClass img = new ImageClass();
                //Must provide full path with picture name and extension (e.g C:/Desktop/image.jpg)
                Console.WriteLine("Enter the full source path(e.g C:/Users/Username/Desktop/Image.jpg): ");
                img.Source = Console.ReadLine();

                //Must provide full path with picture name and extension (e.g C:/Desktop/image.jpg)
                Console.WriteLine("Enter destination path: ");
                img.DestinationPath = Console.ReadLine();

                //Input must be in lowercase as shown
                Console.WriteLine("Enter desired type (jpeg, png or gif): ");
                img.Type = Console.ReadLine();

                // Load the image.
                Image image1 = Image.FromFile(@img.Source);
                switch (img.Type)
                {
                    case "jpeg":
                        // Save the image in JPEG format.
                        image1.Save(@img.DestinationPath, ImageFormat.Jpeg);
                        break;
                    case "gif":
                        // Save the image in GIF format.
                        image1.Save(@img.DestinationPath, ImageFormat.Gif);
                        break;
                    case "png":
                        // Save the image in PNG format.
                        image1.Save(@img.DestinationPath, ImageFormat.Png);
                        break;
                    default:
                        Console.WriteLine("Not a correct value!"); ;
                        break;
                }
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
