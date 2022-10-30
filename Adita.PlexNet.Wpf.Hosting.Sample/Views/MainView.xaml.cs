using Adita.PlexNet.Wpf.Hosting.Sample.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel;
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
            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                DataContext = App.Current.ServiceProvider.GetRequiredService<MainViewModel>();
            }
        }
    }
}
