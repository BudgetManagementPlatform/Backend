using System.Reflection;
using API;
using API.Extensions;
using API.Infrastructure;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddApi();

    // Add services to the container.
    builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
    builder.Services.AddProblemDetails();

    builder.Services.AddEndpoints(Assembly.GetExecutingAssembly());

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    // TODO refactor in future
    builder.Services.AddSingleton<TimeProvider>(TimeProvider.System);
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