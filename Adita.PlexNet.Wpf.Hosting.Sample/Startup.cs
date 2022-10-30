using Adita.PlexNet.Wpf.Hosting.Sample.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;

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

            //if App has components such as StartupUri, subscribes event handler to event(s) or others in here need to call InitializeComponent()
            //InitializeComponent method of App class only will generated after build if any component exist.
            //Note: if you delete the StartupUri on App.xaml you need to handle Startup event, otherwise InitializeComponent will never be generated
            //and your app resource will not be initialized too, this is such as bugs of wpf!!!.
            app.InitializeComponent();
            app.Run();
        }
    }
}
