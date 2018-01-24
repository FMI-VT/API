using ConverterLibrary;
using ConverterLibrary.Modules.Resizer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary.Tools
{
    class Resizer
    {
        private IResizable resizeModule;
        public Resizer(IResizable resizeModule)
        {
            this.resizeModule = resizeModule;
        }
        public void Resize(string sourcePath, string destinationPath, int width, int height)
        {
            if (File.Exists(destinationPath))
            {
                throw new IfImageAlreadyExistsException();
            }
            if(width <= 0 || height <= 0)
            {
                throw new InvalidImageDimensionException();
            }
            this.resizeModule.Resize(sourcePath, destinationPath, width, height);
        }
    }
}