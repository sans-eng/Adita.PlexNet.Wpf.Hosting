using Adita.PlexNet.Wpf.Hosting.Sample.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adita.PlexNet.Wpf.Hosting.Sample
{
    public static class Startup
    {
        [STAThread]
        public static void Main()
        {
            var builder = new ApplicationBuilder<App>();
            builder.ConfigureServices(services => 
            {
                services.AddSingleton<MainViewModel>();
            });

            App app = builder.Build();
            app.InitializeComponent();
            app.Run();
        }
    }
}
