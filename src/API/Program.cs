using System.Reflection;
using API;
using API.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddApi();

    // Add services to the container.
    builder.Services.AddEndpoints(Assembly.GetExecutingAssembly());

    // TODO refactor in future
    builder.Services.AddSingleton(TimeProvider.System);
}

WebApplication app = builder.Build();
{
    app.UseApi();

    app.MapEndpoints();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    // TODO: remove in future
    app.MapGet("/time", (TimeProvider timeProvider) => timeProvider.GetUtcNow().UtcDateTime)
        .WithName("GetCurrentTime")
        .Produces<DateTime>()
        .WithTags("Remove");

    app.UseHttpsRedirection();

    app.Run();
}

public partial class Program
{
}