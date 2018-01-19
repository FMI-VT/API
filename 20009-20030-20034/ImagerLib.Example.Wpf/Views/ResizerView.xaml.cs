using ImagerLib.Example.Wpf.Helpers;
using ImagerLib.Example.Wpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImagerLib.Example.Wpf.Views
{
    /// <summary>
    /// Interaction logic for ResizerView.xaml
    /// </summary>
    public partial class ResizerView : UserControl
    {
        private ResizeViewModel model;

        public ResizerView()
        {
            model = new ResizeViewModel();

            InitializeComponent();

            this.ResizerGrid.DataContext = model;
        }

        private void SourceTextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            SystemBrowser.SelectImage(model);
        }

        private void SourceButton_Click(object sender, RoutedEventArgs e)
        {
            SystemBrowser.SelectImage(model);
        }

        private void DestinationTextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            SystemBrowser.SelectFolder(model);
        }

        private void DestinationButton_Click(object sender, RoutedEventArgs e)
        {
            SystemBrowser.SelectFolder(model);
        }

        private void ResizeButton_Click(object sender, RoutedEventArgs e)
        {
            string message = null;

            try
            {
                Imager imager = new Imager();

                string destinationPath = System.IO.Path.Combine(model.DestinationPath, model.FileName + "." + model.SourcePath.Substring(model.SourcePath.Length - 3));

                ResizeType resizeType = (bool)KeepAspectCheckBox.IsChecked ? ResizeType.KeepAspect : ResizeType.Skew;

                imager.Resize(model.SourcePath, destinationPath, resizeType, model.Width, model.Height);

                message = "The image was successfully resized!";
            }
            catch (ImageNotFoundException)
            {
                message = "Please select an existing image!";
            }
            catch (ImageNullOrEmptyException)
            {
                message = "Please choose a source image!";
            }
            catch (ImageAlreadyExistsException)
            {
                message = "Image with this name already exists! Please change the destination path.";
            }
            catch (InvalidImageException)
            {
                message = "Invalid image format!";
            }
            catch (InvalidImageDimensionsException)
            {
                message = "Please enter a valid dimensions!";
            }
            catch (InvalidAspectRatioException)
            {
                message = "Incompatible aspect ratio!";
            }
            catch (ExternalException)
            {
                message = "Something went wrong! Please try again.";
            }
            finally
            {
                MainWindow.Instance.ShowMessage(message);
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
