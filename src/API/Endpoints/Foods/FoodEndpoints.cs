using API.Infrastructure.EndpointsConventions;

namespace API.Endpoints.Foods;

public class FoodEndpoints : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/test", () => "Hello World!")
            .GetApiConvention<int>()
            .WithTags("Test");
    }
}