using System.Reflection;

namespace EveOfMidnight.Mediator.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddEveOfMidnightMediatorServices<T>(this IServiceCollection services)
    {
        var containingType = typeof(T);

        services.AddScoped<ServiceFactory>(p => p.GetService);

        services.AddMediatR(typeof(T).GetTypeInfo().Assembly,typeof(ServiceCollectionExtensions).GetTypeInfo().Assembly);

        var writer = new WrappingWriter(Console.Out);

        services.AddSingleton<TextWriter>(writer);

        services.AddLazyCache();

        services.AddScoped(typeof(IRequestPreProcessor<>), typeof(EmptyRequestPreProcessor<>));
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
     //   services.AddScoped(typeof(IStreamPipelineBehavior<,>), typeof(StreamingLoggingBehavior<,>));
//#if DEBUG
   //     services.AddScoped(typeof(IPipelineBehavior<,>), typeof(OperationProfilingBehaviour<,>));
    //    services.AddScoped(typeof(IStreamPipelineBehavior<,>), typeof(StreamingOperationProfilingBehaviour<,>));
//#endif

        //      services.AddScoped(typeof(IPipelineBehavior<,>), typeof(DistributedCacheInvalidationBehavior<,>));
        //      services.AddScoped(typeof(IPipelineBehavior<,>), typeof(DistributedCachingBehavior<,>));

        //services.RegisterBuiltCaches(containingType);

        services.Scan(scan => scan
            .FromAssembliesOf(typeof(IMediator), containingType)
            .AddClasses()
            .AsImplementedInterfaces());

        services.AddScoped(typeof(IRequestPostProcessor<,>), typeof(EmptyRequestPostProcessor<,>));

        return services;
    }
}