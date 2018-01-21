////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="ImageTools.cs" company="SBND jsc">
// Copyright (c) 2017 - 2018 SBND jsc. All rights reserved.
// </copyright>
// <author>Dimiter "Arruor" Nikov</author>
// <date>02.01.2018 г.</date>
// <summary>Implements the image tools class</summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PrimeHolding.Tools
{
    using System;
    using System.Drawing;
    using IO = System.IO;
    using PrimeHolding.Tools.Converter;
    using PrimeHolding.Tools.Resizer;
    using PrimeHolding.Tools.Common.Exceptions;
    using PrimeHolding.Tools.Common.Permissions;

    /// <summary>   An image tools. </summary>
    public class ImageTools
    {
        /// <summary>   The converter. </summary>
        ConverterContext converter;
        /// <summary>   The resizer. </summary>
        ResizerContext resizer;

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Check source file. </summary>
        ///
        /// <exception cref="FileNotReadableException"> Thrown when a File Not Readable error condition
        ///                                             occurs. </exception>
        /// <exception cref="FileNotFoundException">    Thrown when the requested file is not present. </exception>
        ///
        /// <param name="sourceFile">   Source file. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        private void CheckSourceFile (String sourceFile)
        {
            try
            {
                CheckPermissions sourceFilePermissions = new CheckPermissions(sourceFile);
                if (!sourceFilePermissions.CanRead() || !sourceFilePermissions.CanReadData())
                {
                    throw new FileNotReadableException("Could not read source file!");
                }
            }
            catch (IO.FileNotFoundException ex)
            {
                throw new FileNotFoundException("Source file does not exists!", ex);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Check destination file. </summary>
        ///
        /// <exception cref="FileNotWritableException"> Thrown when a File Not Writable error condition
        ///                                             occurs. </exception>
        /// <exception cref="FileNotFoundException">    Thrown when the requested file is not present. </exception>
        ///
        /// <param name="destinationFile">  Destination file. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        private void CheckDestinationFile (String destinationFile)
        {
            try
            {
                CheckPermissions destFilePermissions = new CheckPermissions(IO.Path.GetDirectoryName(destinationFile));
                
                if (!destFilePermissions.CanWrite() || !destFilePermissions.CanWriteData())
                {
                    throw new FileNotWritableException("Could not write to destination file!");
                }
            }
            catch (IO.FileNotFoundException ex)
            {
                throw new FileNotFoundException("Destination file does not exists!", ex);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Check width. </summary>
        ///
        /// <exception cref="InvalidParameterException">    Thrown when an Invalid Parameter error
        ///                                                 condition occurs. </exception>
        ///
        /// <param name="width">    The width. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        private void CheckWidth(int width)
        {
            if (width <= 0)
            {
                throw new InvalidParameterException("Destination width must be non-zero value!");
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Check height. </summary>
        ///
        /// <exception cref="InvalidParameterException">    Thrown when an Invalid Parameter error
        ///                                                 condition occurs. </exception>
        ///
        /// <param name="height">   The height. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        private void CheckHeight(int height)
        {
            if (height <= 0)
            {
                throw new InvalidParameterException("Destination height must be non-zero value!");
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Converts images. </summary>
        ///
        /// <exception cref="ImageFormatException"> Thrown when an Image Format error condition occurs. </exception>
        ///
        /// <param name="sourceFile">       Source file. </param>
        /// <param name="destinationFile">  Destination file. </param>
        /// <param name="Type">             The type. </param>
        ///////////////////////////////////////////////////////////////////////////////////////////

        public void Convert(String sourceFile, String destinationFile, String Type)
        {
            switch (Type.ToLower())
            {
                case "jpg":
                case "jpeg":
                    converter = new ConverterContext(new Jpeg());
                    break;

                case "gif":
                    converter = new ConverterContext(new Gif());
                    break;

                case "png":
                    converter = new ConverterContext(new Png());
                    break;

                default:
#pragma warning disable CS0162 // Unreachable code detected
                    throw new ImageFormatException();
                    break;
#pragma warning restore CS0162 // Unreachable code detected
            }
            
            // Check source file for read access
            //CheckSourceFile(sourceFile);

            // Check destination file for write access
            //CheckDestinationFile(destinationFile);

            Image sourceImage = Image.FromFile(sourceFile);
            converter.ConvertImage(sourceImage, destinationFile);
            sourceImage.Dispose();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Resizes images. </summary>
        ///
        /// <exception cref="InvalidParameterException">    Thrown when an Invalid Parameter error
        ///                                                 condition occurs. </exception>
        ///
        /// <param name="sourceFile">       Source file. </param>
        /// <param name="destinationFile">  Destination file. </param>
        /// <param name="Type">             The type. </param>
        /// <param name="width">            The width. </param>
        /// <param name="height">           The height. </param>
        /// <param name="startX">           (Optional) The start x coordinate. </param>
        /// <param name="startY">           (Optional) The start y coordinate. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Resize(String sourceFile, String destinationFile, String Type, int width, int height, int startX = 0, int startY = 0)
        {
            switch (Type.ToLower())
            {
                case "keepaspect":
                    resizer = new ResizerContext(new KeepAspect());
                    break;

                case "skew":
                    resizer = new ResizerContext(new Skew());
                    break;

                case "crop":
                    resizer = new ResizerContext(new Crop(startX, startY));
                    break;

                default:
                    throw new InvalidParameterException();
#pragma warning disable CS0162 // Unreachable code detected
                    break;
#pragma warning restore CS0162 // Unreachable code detected
            }

            // Check source file for read access
            CheckSourceFile(sourceFile);

            // Check destination file for write access
            CheckDestinationFile(destinationFile);

            // Check destination width
            CheckWidth(width);

            // Check destination height
            CheckHeight(height);

            Image sourceImage = new Bitmap(sourceFile);

            // Check if crop area is largest than source file
            if (((sourceImage.Width - startX) < width) || ((sourceImage.Height - startY) < height))
            {
                throw new InvalidParameterException("Could not crop area bigger than source image!");
            }

            // Check if start position for crop area are within source image
            if ((sourceImage.Width < width) || (sourceImage.Height < height))
            {
                throw new InvalidParameterException("Starting point should be within source image!");
            }

            resizer.ResizeImage(sourceImage, destinationFile, width, height);
            sourceImage.Dispose();
        }

    }
}
