using Converter.Exceptions;
using Converter.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace Converter.ConvertAndResize
{
    public class ConvertToJPEG : IStrategy
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
            }
            catch (Exception ex)
            {
                throw new MainExeption(ex.Message, ex);
            }
        }
    }
}