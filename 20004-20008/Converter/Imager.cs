using ConverterLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ConverterLibrary.Modules.Converter;
using ConverterLibrary.Modules.Resizer;
using ConverterLibrary.Tools;

namespace ConverterLibrary
{
    public class Imager
    {
        private Converter converter;
        private Resizer resizer;

        public void Convert(string sourcePath, string destinationPath, ConvertType type)
        {
            switch (type)
            {
                case ConvertType.Jpg:
                    converter = new Converter(new Jpg());
                    break;

                case ConvertType.Png:
                    converter = new Converter(new Png());
                    break;

                case ConvertType.Gif:
                    converter = new Converter(new Gif());
                    break;
            }

            try
            {
                converter.Convert(sourcePath, destinationPath);
            }
            catch (ArgumentException)
            {
                throw new IfImageNullOrEmptyException("The path is null or empty");
            }
            catch (FileNotFoundException)
            {
                throw new IfImageNotFoundException("Image not found");
            }
            catch (OutOfMemoryException)
            {
                throw new InvalidImageException("Invalid image");
            }
            catch (NotSupportedException)
            {
                throw new InvalidImageException("Invalid image");
            }
            catch (IfImageAlreadyExistsException iiae)
            {
                throw new IfImageAlreadyExistsException("Image with this name already exists", iiae);
            }
        }

     
        public void Resize(string sourcePath, string destinationPath, ResizeType type, int width, int height, int x = 0, int y = 0)
        {
            switch (type)
            {
                case ResizeType.Crop:
                    resizer = new Resizer(new Crop(x, y));
                    break;

                case ResizeType.Skew:
                    resizer = new Resizer(new Skew());
                    break;
            }

            try
            {
                resizer.Resize(sourcePath, destinationPath, width, height);
            }
            catch (ArgumentException)
            {
                throw new IfImageNullOrEmptyException("Null or empty image path");
            }
            catch (FileNotFoundException)
            {
                throw new IfImageNotFoundException("Image not found");
            }
            catch (OutOfMemoryException)
            {
                throw new InvalidImageException("Invalid image or invalid dimensions");
            }
            catch (InvalidImageDimensionException iide)
            {
                throw new InvalidImageDimensionException("Invalid image dimensions", iide);
            }
            catch (InvalidAspectException iae)
            {
                throw new InvalidAspectException("Invalid image aspect ratio", iae);
            }
            catch (IfImageAlreadyExistsException iiae)
            {
                throw new IfImageAlreadyExistsException("Image with this name already exists", iiae);
            }
        }
    }

    public enum ConvertType
    {
        Jpg,Png,Gif
    }

    public enum ResizeType
    {
        Crop,Skew
    }
}