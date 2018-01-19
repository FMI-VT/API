using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeHoldingImage.Resizer;
using PrimeHoldingImage.Exception;
using System.IO;
using System.Security.Permissions;

namespace PrimeHoldingImage
{
    public class Resize
    {
        private string destinationFile;
        private IResizeStrategy converter;

        public void Process(string sourceFile, string destinationFile, string type, int width, int height, int x, int y)
        {
            #region FileExistenceCheck
            //check if sourceFile exists, if not, throw exception
            if (!File.Exists(sourceFile))
            {
                throw new PrimeHoldingImage.Exception.FileNotFoundException();
            }
            #endregion
            #region FileFormatCheck
            //check if the file's extension is supported
            string extension = Path.GetExtension(sourceFile);
            if (extension == ".png" || extension == ".jpeg" || extension == ".jpg" || extension == ".gif")
            {

            }
            else
            {
                throw new FileExtensionNotSupportedException(extension);
            }
            #endregion
            #region ActionCheck
            //check which action is chosen
            switch (type.ToLower())
            {
                case "crop":
                    this.converter = new Crop();
                    break;

                case "keepaspect":
                    this.converter = new KeppAspect();
                    break;

                case "scew":
                    this.converter = new Scew();
                    break;
                //if none of the above actions matches, throw IlegalOperationException
                default: throw new IlegalOperetaionException();
            }
            #endregion
            #region DestionationFileNameCheck
            //Check if source and destionation file names are the same.
            if (Path.GetFullPath(sourceFile) == Path.GetFullPath(destinationFile))
            {
                throw new DestinationFileNameException("Cant write destinationFile over sourceFile.");
            }
            #endregion
            #region DirectoryWritePermissionCheck
            var directoryPermission = new DirectoryInfo(destinationFile);
            if (directoryPermission.Attributes.HasFlag(FileAttributes.ReadOnly))
            {
                throw new NoWritePermissionsException();
            }
            #endregion
            this.converter.Resize(sourceFile, destinationFile, width, height, x, y);
        }
    }

}

