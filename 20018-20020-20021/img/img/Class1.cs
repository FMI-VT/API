using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using img.Strategies.Resize;
using img.Interfeca;
using img.Strategies.Convert;

namespace img
{
    public class Class1 : IContext
    {
        private IStrategy strategy;
        private string sourcePath;
        private string destinationPath;
        private string imageOperation;

        private int x;
        private int y;
        private int width;
        private int height;

        public Class1(string sourcePath, string destinationPath, string imageOperation)
        {
            this.sourcePath = sourcePath;
            this.destinationPath = destinationPath;
            this.imageOperation = imageOperation;
        }

        public Class1(string sourcePath, string destionationPath, string imageOperation, int x, int y, int width, int height)
        {
            this.sourcePath = sourcePath;
            this.destinationPath = destionationPath;
            this.imageOperation = imageOperation;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void ExecuteStrategy()
        {
            switch (imageOperation)
            {
           
                case "Crop":
                    this.strategy = new Crop(this.x, this.y, this.width, this.height);
                    break;

                case "ConvertToPNG":
                    this.strategy = new ConvertToPNG();
                    break;

                case "ConvertToJPG":
                    this.strategy = new ConvertToJPG();
                    break;

                case "ConvertToGIF":
                    this.strategy = new ConvertToGIF();
                    break;
            }
            strategy.Start(this.sourcePath, this.destinationPath);
        }
    }
}