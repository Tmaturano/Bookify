using Bookify.Application.Abstractions.Behaviors;
using Bookify.Domain.Entities.Bookings;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Bookify.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);

            //When sending a command, it's going to first enter the logging behavior, run the logging statement and then execute the command handler before returning the response
            configuration.AddOpenBehavior(typeof(LoggingBehavior<,>));

            configuration.AddOpenBehavior(typeof(ValidationBehavior<,>));
            
            configuration.AddOpenBehavior(typeof(QueryCachingBehavior<,>));
        });

        services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

        services.AddTransient<PricingService>();

        return services;
    }
}
