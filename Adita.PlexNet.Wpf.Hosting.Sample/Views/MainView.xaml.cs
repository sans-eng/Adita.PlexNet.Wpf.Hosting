using Adita.PlexNet.Wpf.Hosting.Sample.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Controls;

namespace Adita.PlexNet.Wpf.Hosting.Sample.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = App.Current.ServiceProvider.GetRequiredService<MainViewModel>();
        }
    }
}
