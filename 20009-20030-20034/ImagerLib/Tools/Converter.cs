using ImagerLib.Modules.Converter;
using System.IO;

namespace ImagerLib.Tools
{
    class Converter
    {
        private IConvertable convertModule;

        public Converter(IConvertable convertModule)
        {
            this.convertModule = convertModule;
        }

        public void Convert(string sourcePath, string destinationPath)
        {
            if (File.Exists(destinationPath))
            {
                throw new ImageAlreadyExistsException();
            }

            this.convertModule.Convert(sourcePath, destinationPath);
        }
    }
}
