//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeHoldingImage.Resizer;
using PrimeHoldingImage.Converter;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {
            //JPG-PNG
             PrimeHoldingImage.Convert res = new PrimeHoldingImage.Convert();
             res.ConvertImage("C:/Users/453/Desktop/API/minions.jpg", "C:/Users/453/Desktop/API/Hristiqna.png","png");

            //JPG-GIF
            //PrimeHoldingImage.Convert res = new PrimeHoldingImage.Convert();
            // res.ConvertImage("C:/Users/453/Desktop/API/minions.jpg", "C:/Users/453/Desktop/API/Minions.gif","gif");

            //GIF-JPG
            //  PrimeHoldingImage.Convert res = new PrimeHoldingImage.Convert();
            //  res.ConvertImage("C:/Users/453/Desktop/API/a.gif", "C:/Users/453/Desktop/API/newa.jpg", "jpg");

            //GIF-PNG
            // PrimeHoldingImage.Convert res = new PrimeHoldingImage.Convert();
            // res.ConvertImage("C:/Users/453/Desktop/API/v.gif", "C:/Users/453/Desktop/API/newv.png", "png");

            //PNG->JPG
            // PrimeHoldingImage.Convert res = new PrimeHoldingImage.Convert();
            // res.ConvertImage("C:/Users/453/Desktop/API/photo.png", "C:/Users/453/Desktop/API/newphoto.jpg","jpg");

            //PNG->GIF
            // PrimeHoldingImage.Convert res = new PrimeHoldingImage.Convert();
            // res.ConvertImage("C:/Users/453/Desktop/API/photo.png", "C:/Users/453/Desktop/API/photooo.gif","gif");


            // PrimeHoldingImage.Resize ress = new PrimeHoldingImage.Resize();
            // ress.Process("C:/Users/453/Desktop/DSCF0609.jpg", "C:/Users/453/Desktop/scew.jpg", "scew",500,300,0,0);

            //SCEW
            // PrimeHoldingImage.Resize res = new PrimeHoldingImage.Scew();
            // ress.Process("C:/Users/453/Desktop/DSCF0609.jpg", "C:/Users/453/Desktop/scew.jpg", "scew", 500, 300, 0, 0);

          
        }
    }
}
