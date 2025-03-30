using Microsoft.AspNetCore.Routing;

namespace Shared.shared.src.shared.infrastructure.Extensions;

public interface IEndpoint
{
    void MapEndpoint(IEndpointRouteBuilder app);
}