using Microsoft.Extensions.DependencyInjection;
using TitaniumExpress.Core.DomainModels;
using TitaniumExpress.Core.Interfaces;

namespace TitaniumExpress.Core;

public static class ServiceCollectionExtentions
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddTransient<BotDomainModel>();
        services.AddTransient<HeroDomainModel>();
        services.AddTransient<UserDomainModel>();

        return services;
    }
}