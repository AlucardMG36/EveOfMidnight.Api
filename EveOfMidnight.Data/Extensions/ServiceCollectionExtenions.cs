using EveOfMidnight.Core.Accessors;
using EveOfMidnight.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EveOfMidnight.Data.Extensions;

public static class ServiceCollectionExtenions
{
    private static ILoggerFactory _loggerFactory = LoggerFactory.Create(builder =>
    {
        builder.AddDebug();
        builder.AddConsole();
    });

    public static IServiceCollection AddEveOfMidnightDataServices(this IServiceCollection services, String connectionString)
    {
        services.AddPooledDbContextFactory<EveofmidnightContext>(options =>
        {
            options
                .UseSqlServer(connectionString
                    , cfg => cfg.EnableRetryOnFailure()
                        .UseQuerySplittingBehavior(QuerySplittingBehavior.SingleQuery))
                .UseLoggerFactory(_loggerFactory)
                .EnableDetailedErrors()
                .EnableSensitiveDataLogging()
                .EnableServiceProviderCaching()
                ;
        });

        services.AddScoped<IFocusAccessor, FocusRepository>();

        return services;
    }

}

