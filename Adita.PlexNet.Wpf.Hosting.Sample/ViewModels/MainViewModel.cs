using CommunityToolkit.Mvvm.ComponentModel;

namespace Adita.PlexNet.Wpf.Hosting.Sample.ViewModels
{
    [ObservableObject]
    public partial class MainViewModel
    {
        [ObservableProperty]
        private string _data = "This is main view";
    }
}
