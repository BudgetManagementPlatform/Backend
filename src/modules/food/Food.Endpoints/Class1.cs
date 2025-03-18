using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Shared.EndpointsConventions;
using Shared.Extensions;

namespace Food.Endpoints;

public class Class1 : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/otro", () => "Hello World!")
            .GetApiConvention<int>()
            .WithTags("otro")
            .WithName("GetOtro");
    }
}