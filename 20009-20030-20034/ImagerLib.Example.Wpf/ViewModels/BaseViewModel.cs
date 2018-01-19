using System.Collections.Generic;
using System.ComponentModel;

namespace ImagerLib.Example.Wpf.ViewModels
{
    internal class BaseViewModel : IViewModel, INotifyPropertyChanged
    {
        private string sourcePath;
        public string SourcePath
        {
            get { return sourcePath; }
            set { SetAndNotify(ref sourcePath, value, nameof(SourcePath)); }
        }

        private string destinationPath;
        public string DestinationPath
        {
            get { return destinationPath; }
            set { SetAndNotify(ref destinationPath, value, nameof(DestinationPath)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void SetAndNotify<T>(ref T field, T value, string propertyName)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                RaisePropertyChanged(propertyName);
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
