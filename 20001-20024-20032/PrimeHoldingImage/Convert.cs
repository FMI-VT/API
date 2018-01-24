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

            #region ActionCheck(convert type)
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
                    throw new IlegalOperetaionException();
#pragma warning disable CS0162 // Unreachable code detected
                    break;
#pragma warning restore CS0162 // Unreachable code detected
            }
            #endregion
            #region FileExistenceCheck
            //check if sourceFile exists, if not, throw exception
            if (!File.Exists(sourceFile))
            {
                throw new PrimeHoldingImage.Exception.FileNotFoundException();
            }
            #endregion
            #region DestionationFileNameCheck
            //Check if source and destionation file names are the same.
            if (Path.GetFullPath(sourceFile) == Path.GetFullPath(destinationFile))
            {
                throw new DestinationFileNameException("Cant write destinationFile over sourceFile.");
            }
            #endregion
            #region DestinationFileDirectoryExistanceCheck

            if (!Directory.Exists(Path.GetDirectoryName(destinationFile)))
            {
                throw new PrimeHoldingImage.Exception.DirectoryNotFoundException();
            }
            #endregion
            #region DestinationFileFormatCheck
            //check if the file's extension is supported .png != .pNg
            string extension = Path.GetExtension(destinationFile);
            if (extension == ".pNg" || extension == ".jpeg" || extension == ".jpg" || extension == ".gif")
            {

            }
            else
            {
                throw new DestinationFileTypeException();
            }
            #endregion
            this.destinationFile = this.converter.Convert(sourceFile, destinationFile);

            return this.destinationFile;
        }
    }
}
