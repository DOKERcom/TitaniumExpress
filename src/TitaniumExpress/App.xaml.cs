using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TitaniumExpress.App;
using TitaniumExpress.Core;
using TitaniumExpress.Core.DomainModels;
using TitaniumExpress.Core.Interfaces.View;
using TitaniumExpress.View.Models;
using TitaniumExpress.View.ViewModels;
using TitaniumExpress.View.Views;

namespace TitaniumExpress.View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            AppHost = Host.CreateDefaultBuilder().ConfigureServices((hostContext, services) =>
            {
                services.AddCoreServices();

                services.AddViewServices();

                services.AddAppServices();

            }).Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();
            var startupForm = AppHost.Services.GetRequiredService<MainWindow>();
            startupForm!.DataContext = AppHost.Services.GetService<IMainViewModel>();
            startupForm!.InitializeComponent();
            startupForm!.Show();
            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();
            base.OnExit(e);
        }

        public static IHost? AppHost { get; private set; }
    }
}
