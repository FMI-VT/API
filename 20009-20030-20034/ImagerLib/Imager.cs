using ImagerLib.Tools;
using ImagerLib.Modules.Converter;
using ImagerLib.Modules.Resizer;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ImagerLib
{
    public class Imager
    {
        /// <summary>
        /// Contains converter instance
        /// </summary>
        private Converter converter;

        /// <summary>
        /// Contains resizer instance
        /// </summary>
        private Resizer resizer;

        /// <summary>
        /// Converts an image from one type to another
        /// </summary>
        /// <param name="sourcePath">Path to the source image</param>
        /// <param name="destinationPath">Destination path where the converted image will be saved</param>
        /// <param name="type">The type to which the image will be converted</param>
        /// <exception cref="ImageNotFoundException">The specific image does not exist</exception>
        /// <exception cref="ImageNullOrEmptyException">The specific image path is null or empty</exception>
        /// <exception cref="ImageAlreadyExistsException">Image with the specific name already exists</exception>
        /// <exception cref="InvalidImageException">Invalid image format or not supported pixel format</exception>
        /// <exception cref="ExternalException">External error</exception>
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
                throw new ImageNullOrEmptyException("Null or empty image path");
            }
            catch (FileNotFoundException)
            {
                throw new ImageNotFoundException("Image not found");
            }
            catch (OutOfMemoryException)
            {
                throw new InvalidImageException("Invalid image");
            }
            catch (NotSupportedException)
            {
                throw new InvalidImageException("Invalid image");
            }
            catch (ImageAlreadyExistsException ex)
            {
                throw new ImageAlreadyExistsException("Image with this name already exists", ex);
            }
            catch (ExternalException ee)
            {
                throw new ExternalException("External error", ee);
            }
        }

        /// <summary>
        /// Resizes or crops an image
        /// </summary>
        /// <param name="sourcePath">Path to the source image</param>
        /// <param name="destinationPath">Destination path where the resized image will be saved</param>
        /// <param name="type">Operation type</param>
        /// <param name="width">Desired image width</param>
        /// <param name="height">Desired image height</param>
        /// <param name="x">X coordinate for starting point when cropping image</param>
        /// <param name="y">Y coordinate for starting point when cropping image</param>
        /// <exception cref="ImageNotFoundException">The specific image does not exist</exception>
        /// <exception cref="ImageNullOrEmptyException">The specific image path is null or empty</exception>
        /// <exception cref="ImageAlreadyExistsException">Image with the specific name already exists</exception>
        /// <exception cref="InvalidImageException">Invalid image format or not supported pixel format</exception>
        /// <exception cref="InvalidImageDimensionsException">Invalid image dimensions</exception>
        /// <exception cref="InvalidAspectRatioException">Incompatible image aspect ratio</exception>
        /// <exception cref="ExternalException">External error</exception>
        public void Resize(string sourcePath, string destinationPath, ResizeType type, int width, int height, int x = 0, int y = 0)
        {
            switch (type)
            {
                case ResizeType.Crop:
                    resizer = new Resizer(new Crop(x, y));
                    break;

                case ResizeType.KeepAspect:
                    resizer = new Resizer(new KeepAspect());
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
                throw new ImageNullOrEmptyException("Null or empty image path");
            }
            catch (FileNotFoundException)
            {
                throw new ImageNotFoundException("Image not found");
            }
            catch (OutOfMemoryException)
            {
                throw new InvalidImageException("Invalid image or invalid dimensions");
            }
            catch (InvalidImageDimensionsException iid)
            {
                throw new InvalidImageDimensionsException("Invalid image dimensions", iid);
            }
            catch (InvalidAspectRatioException iar)
            {
                throw new InvalidAspectRatioException("Invalid image aspect ratio", iar);
            }
            catch (ImageAlreadyExistsException ex)
            {
                throw new ImageAlreadyExistsException("Image with this name already exists", ex);
            }
            catch (ExternalException ee)
            {
                throw new ExternalException("External error", ee);
            }
        }
    }

    public enum ConvertType
    {
        Jpg,
        Png,
        Gif
    }

    public enum ResizeType
    {
        KeepAspect,
        Crop,
        Skew
    }
}
