using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursov2.Resizer
{
    public class Keep_Aspect:Helper
    {
        //with saving the proportions(size) of the image
        public void KeepAspect()
        {
            Bitmap resizedImage;

            try
            {
                using (FileStream fs = new System.IO.FileStream(SourceFolder, System.IO.FileMode.Open))
                {
                    original = new Bitmap(fs);
                }

                int rectHeight = original.Height;
                int rectWidth = original.Width;


                if (original.Height == original.Width)
                {
                    resizedImage = new Bitmap(original, rectHeight, rectHeight);
                }
                else
                {
                    float aspect = original.Width / (float)original.Height;
                    int newWidth, newHeight;

                    newWidth = (int)(rectWidth * aspect);
                    newHeight = (int)(newWidth / aspect);


                    if (newWidth > rectWidth || newHeight > rectHeight)
                    {
                        if (newWidth > newHeight)
                        {
                            newWidth = rectWidth;
                            newHeight = (int)(newWidth / aspect);
                        }
                        else
                        {
                            newHeight = rectHeight;
                            newWidth = (int)(newHeight * aspect);
                        }
                    }
                    resizedImage = new Bitmap(original, newWidth, newHeight);
                    resizedImage.Save(DestionationFolder);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
