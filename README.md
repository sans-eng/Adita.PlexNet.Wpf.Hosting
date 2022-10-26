# Adita.PlexNet.Wpf.Hosting

A WPF hosting library for PlexNet framework that targeting .NET 6

## How to use

1. Implement `Adita.PlexNet.Wpf.Hosting.IApplication` to your `App.xaml.cs`
    
   ```
        public partial class App : Application, IApplication
        {
            //...
        
            public IServiceProvider ServiceProvider { get; private set; } = default!;
            public IConfiguration Configuration { get; private set; } = default!;

            public void SetConfiguration(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public void SetServiceProvider(IServiceProvider serviceProvider)
            {
                ServiceProvider = serviceProvider;
            }
        }
   ```
    

 2. Create a class to override entry point of application with `Main()` method

    Example:

    ```	
		public static void Main()
        {
            IApplicationBuilder<App> builder = new ApplicationBuilder<App>();

            //setup configuration
            string appSettingsPath = Path.Combine(Environment.CurrentDirectory, "AppSettings.json");

            builder.ConfigureAppConfiguration(configBuilder =>
            {
                configBuilder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(appSettingsPath, optional: false, reloadOnChange: true);
            });

            //add services
            builder.ConfigureServices(services =>
            {
                services.AddSingleton<MainViewModel>();
                services.Configure<TestOptions>(builder.Configuration.GetSection(nameof(TestOptions)));
            });

            App application = builder.Build();

             //if App has components such as StartupUri, subscribes event handler to event(s) or others in here need to call InitializeComponent()
            //InitializeComponent method of App class only will generated after build if any component exist.
            //Note: if you delete the StartupUri on App.xaml you need to handle Startup event, otherwise InitializeComponent will never be generated
            //and your app resource will not be initialized too, this is such as bugs of wpf!!!.

            application.InitializeComponent();

            application.Run();
        }

    ```
	

 3. Override StartupObject on project properties to your new entry point class

    example:

    ```
        <StartupObject>Adita.PlexNet.Wpf.Hosting.Sample.Startup</StartupObject>

    ```

[Sample project](/Adita.PlexNet.Wpf.Hosting.Sample)