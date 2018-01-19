using ImagerLib.Example.Wpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagerLib.Example.Wpf.Helpers
{
    public static class SystemBrowser
    {
        public static void SelectImage(IViewModel model)
        {
            var fd = new System.Windows.Forms.OpenFileDialog()
            {
                CheckFileExists = true,
                Filter = "Image Files (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
            };

            if (fd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            model.SourcePath = fd.FileName;
        }

        public static void SelectFolder(IViewModel model)
        {
            var fbd = new System.Windows.Forms.FolderBrowserDialog()
            {
                Description = "Please choose a folder to save the converted image."
            };

            if (fbd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            model.DestinationPath = fbd.SelectedPath;
        }
    }
}
