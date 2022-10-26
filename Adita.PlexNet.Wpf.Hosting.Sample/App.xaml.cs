using Microsoft.Extensions.Configuration;
using System;
using System.Windows;

namespace Adita.PlexNet.Wpf.Hosting.Sample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application, IWpfApplication
    {
        #region Public properties
        public static new App Current => (App)Application.Current;
        public IServiceProvider ServiceProvider { get; private set; } = default!;
        public IConfiguration Configuration { get; private set; } = default!;
        #endregion Public properties

        #region Public methods
        public void SetConfiguration(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void SetServiceProvider(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
        #endregion Public methods
    }
}
