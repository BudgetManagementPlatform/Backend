using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Shared.Extensions;

namespace Food.Endpoints;

public static class DepInj
{
    public static IServiceCollection AddFoodEndpoints(this IServiceCollection services)
    {
        services.AddEndpoints(Assembly.GetExecutingAssembly());

        return services;
    }

    public static IEndpointRouteBuilder MapFoodEndpoints(this WebApplication app)
    {
        app.MapEndpoints();

        return app;
    }
}