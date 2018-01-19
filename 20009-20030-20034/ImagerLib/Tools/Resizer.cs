using ImagerLib.Modules.Resizer;
using System.Drawing;
using System.IO;

namespace ImagerLib.Tools
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
                throw new ImageAlreadyExistsException();
            }

            if (width <= 0 || height <= 0)
            {
                throw new InvalidImageDimensionsException();
            }

            this.resizeModule.Resize(sourcePath, destinationPath, width, height);
        }
    }
}
