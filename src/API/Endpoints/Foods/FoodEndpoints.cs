using API.Infrastructure.EndpointsConventions;

namespace API.Endpoints.Foods;

public class FoodEndpoints : IEndpoint
{
    // TODO remove this when the API is ready
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/test", () => "Hello World!")
            .GetApiConvention<int>()
            .WithTags("Remove");
    }
}