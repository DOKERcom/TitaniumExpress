using Microsoft.Extensions.DependencyInjection;
using TitaniumExpress.Core.Interfaces.View;
using TitaniumExpress.View.Models;
using TitaniumExpress.View.ViewModels;
using TitaniumExpress.View.Views;

namespace TitaniumExpress.View;

public static class ServiceCollectionExtentions
{
    public static IServiceCollection AddViewServices(this IServiceCollection services)
    {
        services.AddSingleton<MainWindow>();
        services.AddTransient<IMainModel, MainModel>();
        services.AddTransient<IMainViewModel, MainViewModel>();

        return services;
    }
}