using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace ImageAPI.Strategies
{
    class ResizeKARStrategy : IEditStrategy
    {
        public void Edit()
        {

            //Resizing while keeping aspect ratio
            //Uses an image from a sourcepath, provided by user input 
            //Calculates the width and height with percentage to keep the AR
            //Using the graphics library it does a high quality conversion to the desired width and height
            //This class uses source(string), width(int), height(int) and destinationPath(string) as user inputs 

            try
            {
                //Must provide full path with picture name and extension (e.g C:/Desktop/image.jpg)
                Console.WriteLine("Enter the source filepath of your image: ");
                string source = Console.ReadLine();
                Image imgPhoto = Image.FromFile(source);
                //Width and height are simple integers, px not needed after the digit
                Console.WriteLine("Enter your desired width: ");
                int Width = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your desired height: ");
                int Height = int.Parse(Console.ReadLine());
                //Must provide full path with picture name and extension (e.g C:/Desktop/image.jpg)
                Console.WriteLine("Enter your desired destination path: ");
                string destinationPath = Console.ReadLine();

                int sourceWidth = imgPhoto.Width;
                int sourceHeight = imgPhoto.Height;
                int sourceX = 0;
                int sourceY = 0;
                int destX = 0;
                int destY = 0;

                float nPercent = 0;
                float nPercentW = 0;
                float nPercentH = 0;

                //Calculating width and height by percentage to keep AR
                nPercentW = ((float)Width / (float)sourceWidth);
                nPercentH = ((float)Height / (float)sourceHeight);
                if (nPercentH < nPercentW)
                {
                    nPercent = nPercentH;
                    destX = System.Convert.ToInt16((Width -
                                  (sourceWidth * nPercent)) / 2);
                }
                else
                {
                    nPercent = nPercentW;
                    destY = System.Convert.ToInt16((Height -
                                  (sourceHeight * nPercent)) / 2);
                }

                int destWidth = (int)(sourceWidth * nPercent);
                int destHeight = (int)(sourceHeight * nPercent);

                Bitmap bmPhoto = new Bitmap(Width, Height,
                                  PixelFormat.Format24bppRgb);
                bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                                 imgPhoto.VerticalResolution);

                Graphics grPhoto = Graphics.FromImage(bmPhoto);
                grPhoto.Clear(Color.White);
                grPhoto.InterpolationMode =
                        InterpolationMode.HighQualityBicubic;

                grPhoto.DrawImage(imgPhoto,
                    new Rectangle(destX, destY, destWidth, destHeight),
                    new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                    GraphicsUnit.Pixel);

                grPhoto.Dispose();
                bmPhoto.Save(destinationPath);
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
