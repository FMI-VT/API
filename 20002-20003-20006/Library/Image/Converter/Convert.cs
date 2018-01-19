////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Converter\Convert.cs
//
// summary:	Implements the convert class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcess.Converter
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A convert. </summary>
    ///
    /// <remarks>   Viki, 11/1/2018. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class Convert : Images
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Viki, 11/1/2018. </remarks>
        ///
        /// <param name="srcPath">  Full pathname of the source file. </param>
        /// <param name="destPath"> Full pathname of the destination file. </param>
        /// <param name="type">     The type. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Convert(string srcPath, string destPath, string type) : base(srcPath, destPath, type)
        {
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Executes this object. </summary>
        ///
        /// <remarks>   Viki, 11/1/2018. </remarks>
        ///
        /// <exception cref="UnsupportedTypeException">     Thrown when an Unsupported Type error
        ///                                                 condition occurs.
        /// </exception>
        /// <exception cref="MyFileNotFoundException">      Thrown when My File Not Found error condition
        ///                                                 occurs.
        /// </exception>
        /// <exception cref="SourceAndDestPathException">   Thrown when a Source And Destination Path
        ///                                                 error condition occurs.
        /// </exception>
        /// <exception cref="UnsupportedDestPathException"> Thrown when an Unsupported Destination Path
        ///                                                 error condition occurs.
        /// </exception>
        /// <exception cref="MyOutOfMemoryException">       Thrown when My Out Of Memory error condition
        ///                                                 occurs.
        /// </exception>
        /// <exception cref="MySystemException">            Thrown when My System error condition occurs.
        /// </exception>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public override void Execute()
        {
            Context context = new Context();

            try
            {
                if (type.ToLower() != "jpg" && type.ToLower() != "gif" && type.ToLower() != "png")
                {
                    throw new Exceptions.UnsupportedTypeException(type + " is invalid type. Supported types: .jpg, .gif, .png");
                }

                switch (type.ToLower())
                {
                    case "jpg":
                        context.SetStrategy(new JPG(srcPath, destPath));
                        break;
                    case "gif":
                        context.SetStrategy(new GIF(srcPath, destPath));
                        break;
                    case "png":
                        context.SetStrategy(new PNG(srcPath, destPath));
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
