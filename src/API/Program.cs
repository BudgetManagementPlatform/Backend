using Shared;
using Shared.shared.src.shared.infrastructure;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddSharedModule();

    // Add services to the container.
    builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
    builder.Services.AddProblemDetails();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    //builder.Services.AddEndpoints(Assembly.GetExecutingAssembly());
}

WebApplication app = builder.Build();
{
    app.UseSharedModule();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.MapGet("/", () => { throw new Exception(); });

    app.UseHttpsRedirection();

    app.Run();
}

public partial class Program
{
}