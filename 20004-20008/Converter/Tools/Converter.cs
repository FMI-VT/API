using ConverterLibrary;
using ConverterLibrary.Modules.Converter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConverterLibrary.Tools
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
                throw new IfImageAlreadyExistsException();
            }
            this.convertModule.Convert(sourcePath, destinationPath);
        }
    }
}
