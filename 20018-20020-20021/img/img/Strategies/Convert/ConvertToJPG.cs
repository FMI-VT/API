using img.Interfeca;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System;
using System.Security;

namespace img.Strategies.Convert
{
    public class ConvertToJPG : IStrategy
    {
        public void Start(string sourcePath, string destinationPath)
        {
            try
            {
                using (FileStream inputFileStream = new FileStream(sourcePath, FileMode.Open))
                {
                    using (FileStream outputFileStream = new FileStream(destinationPath, FileMode.CreateNew))
                    {
                        Image outputImage = Image.FromStream(inputFileStream);
                        outputImage.Save(outputFileStream, ImageFormat.Jpeg);
                    }
                }
                Console.WriteLine("Your image was successfuly converted to jpg!");
            }
            catch (Exception)
            {
                Console.WriteLine("Inserted image already exists!");
            }
        }
    }
}