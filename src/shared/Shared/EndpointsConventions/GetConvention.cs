using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Shared.EndpointsConventions;

public static class GetConvention
{
    public static RouteHandlerBuilder GetApiConvention<T>(this RouteHandlerBuilder builder)
    {
        return builder
            .Produces<T>(StatusCodes.Status200OK, "application/json")
            .Produces<T>(StatusCodes.Status404NotFound, "application/json")
            .Produces<ProblemDetails>(StatusCodes.Status500InternalServerError, "problem/json");
    }
}