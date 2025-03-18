using Microsoft.AspNetCore.Routing;

namespace Shared.Extensions;

public interface IEndpoint
{
    void MapEndpoint(IEndpointRouteBuilder app);
}