using ImagerLib.Example.Wpf.Helpers;
using ImagerLib.Example.Wpf.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ImagerLib.Example.Wpf.Views
{
    /// <summary>
    /// Interaction logic for ConverterView.xaml
    /// </summary>
    public partial class ConverterView : UserControl
    {
        private ConvertViewModel model;

        public ConverterView()
        {
            model = new ConvertViewModel();

            InitializeComponent();
            
            this.ConverterGrid.DataContext = model;
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton checkedRadio = sender as RadioButton;

            if (checkedRadio.IsChecked.Value)
            {
                model.ConvertType = (ConvertType)Enum.Parse(typeof(ConvertType), checkedRadio.Content.ToString(), true); ;
            }
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            string message = null;

            try
            {
                Imager imager = new Imager();

                string destinationPath = System.IO.Path.Combine(model.DestinationPath, model.FileName + "." + model.ConvertType.ToString().ToLower());

                imager.Convert(model.SourcePath, destinationPath, model.ConvertType);

                message = "The image was successfully converted!";
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
