using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcess.Resizer
{
    public class Resize : Images
    {
        public int width { get; set; }
        public int height { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public Resize(string srcPath, string destPath, string type, int width, int height) : base(srcPath, destPath, type)
        {
            this.width = width;
            this.height = height;
        }

        public Resize(string srcPath, string destPath, string type, int width, int height, int x, int y) : base(srcPath, destPath, type)
        {
            this.width = width;
            this.height = height;
        }

        public override void Execute()
        {
            Context context = new Context();
            try
            {
                if (type.ToLower() != "skew" && type.ToLower() != "crop" && type.ToLower() != "keepaspect")
                {
                    throw new Exceptions.UnsupportedTypeException(type + " is invalid resizer type. Supported types: skew, crop and keepaspect");
                }

                switch (type.ToLower())
                {
                    case "crop":
                        context.SetStrategy(new Crop(srcPath, destPath, width, height, x, y));
                        break;
                    case "skew":
                        context.SetStrategy(new Skew(srcPath, destPath, width, height));
                        break;
                    case "keepaspect":
                        context.SetStrategy(new KeepAspect(srcPath, destPath, width, height));
                        break;
                    default:
                        break;
                }

                context.Execute();
            }
            catch (FileNotFoundException)
            {
                throw new Exceptions.MyFileNotFoundException("File with path  " + srcPath + " not found.");
            }
            catch (ArgumentException)
            {
                throw new Exceptions.SourceAndDestPathException("Source or Destination path is an empty string, null or contains invalid characters.");
            }
            catch (NotSupportedException)
            {
                throw new Exceptions.UnsupportedDestPathException("Destination path " + destPath + " is in an invalid format.");
            }
            catch (OutOfMemoryException)
            {
                throw new Exceptions.MyOutOfMemoryException("There is not enough memory to continue the execution of a program");
            }
            catch (SystemException)
            {
                throw new Exceptions.MySystemException("There is a problem with source path or destionation path.");
            }

        }
    }
}
