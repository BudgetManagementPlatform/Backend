using Food.Endpoints;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
{
// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    //builder.Services.AddEndpoints(Assembly.GetExecutingAssembly());

    builder.Services.AddFoodEndpoints();
}

WebApplication app = builder.Build();
{
    //app.MapEndpointsYes();
    app.MapFoodEndpoints();
// Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.Run();
}

public partial class Program
{
}