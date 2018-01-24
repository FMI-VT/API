using Converter.ConvertAndResize;
using Converter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Converter
{
    public class Main : IContext
    {
        private IStrategy strategy;
        private string sourcePath;
        private string destinationPath;
        private string imageOperation;

        private int x;
        private int y;
        private int width;
        private int height;

        public Main(string sourcePath, string destinationPath, string imageOperation)
        {
            this.sourcePath = sourcePath;
            this.destinationPath = destinationPath;
            this.imageOperation = imageOperation;
        }

        public Main(string sourcePath, string destionationPath, string imageOperation, int x, int y, int width, int height)
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

                case "Resize":
                    this.strategy = new ResizedStrategy(this.x, this.y, this.width, this.height);
                    break;

                case "ConvertToPNG":
                    this.strategy = new ConvertToPNG();
                    break;

                case "ConvertToJPEG":
                    this.strategy = new ConvertToJPEG();
                    break;
            }
            strategy.Start(this.sourcePath, this.destinationPath);
        }
    }
}