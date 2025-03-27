using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shared.shared.src.shared.infrastructure;

namespace Shared;

public static class SharedDependencyInjection
{
    public static IServiceCollection AddSharedModule(this IServiceCollection services)
    {
        services.AddExceptionHandler<GlobalExceptionHandler>();
        services.AddProblemDetails();

        return services;
    }

    public static IApplicationBuilder UseSharedModule(this IApplicationBuilder app)
    {
        app.UseExceptionHandler();

        return app;
    }
}