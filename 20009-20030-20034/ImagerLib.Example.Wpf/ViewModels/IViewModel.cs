namespace ImagerLib.Example.Wpf.ViewModels
{
    public interface IViewModel
    {
        string SourcePath { get; set; }

        string DestinationPath { get; set; }
    }
}
