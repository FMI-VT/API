
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImagesProcess.Resize;
using ImagesProcess.Converter;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                //Convert cnv = new Convert("c:/Users/Mladen/Desktop/pic1.jpg", "c:/Users/Mladen/Desktop/pic1.png", "png");
                //cnv.Process();
                Resize rsz = new Resize("c:/Users/Mladen/Desktop/pic_43.jpg", "c:/Users/Mladen/Desktop/pic43.jpg", "crop", 1000, 1000, 150, 150);
                rsz.Process();
            
        }
    }
}
