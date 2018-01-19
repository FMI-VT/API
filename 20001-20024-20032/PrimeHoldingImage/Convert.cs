using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PrimeHoldingImage.Converter;
using PrimeHoldingImage.Exception;
using PrimeHoldingImage.Resizer;

namespace PrimeHoldingImage
{
   public class Convert
    {
        private string destinationFile;
        private ConvertStrategy converter;

        public string ConvertImage(string sourceFile, string destinationFile, string type)
        {
           

            switch (type.ToLower())
            {
                case "gif":
                    this.converter = new GIF();
                    break;

                case "jpg":
                    this.converter = new JPEG();
                    break;

                case "png":
                    this.converter = new PNG();
                    break;

                default:
                    throw new UnknownTypeException();
#pragma warning disable CS0162 // Unreachable code detected
                    break;
#pragma warning restore CS0162 // Unreachable code detected
            }

            this.destinationFile = this.converter.Convert(sourceFile, destinationFile);

            return this.destinationFile;
        }
    }
}
