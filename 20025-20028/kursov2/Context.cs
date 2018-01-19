using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursov2
{
    public class Context: IContext
    {
        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }
        public string Operation { get; set; }

        public Context(string SorcePath, string DestinationPath, string Operation)
        {
            this.SourcePath = SourcePath;
            this.DestinationPath = DestinationPath;
            this.Operation = Operation;
        }

        public void ExecuteStrategy()
        {
            switch (Operation)
            {
                case "Convert":
                    {
                        Converter.Convert convert = new Converter.Convert();
                        FileInfo fileInfo = new FileInfo("");
                        convert.Converter(fileInfo);
                        break;
                    }
                case "Crop":
                    {
                        Resizer.Crop crop = new Resizer.Crop();
                        crop.Croping();
                        break;
                    }
                case "Skew":
                    {
                        Resizer.Skew skew = new Resizer.Skew();
                        skew.Skews();
                        break;
                    }
                case "Keep Aspect":
                    {
                        Resizer.Keep_Aspect aspect = new Resizer.Keep_Aspect();
                        aspect.KeepAspect();
                        break;
                    }
                default:
                    {
                        throw new InvalidEnumArgumentException("Reached default - this should not happen");
                    }
            }
        }


    }
}
