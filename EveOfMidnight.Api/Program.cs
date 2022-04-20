using System.Net;
using EveOfMidnight.Api.Models;
using MediatR;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Error)
    .Enrich.FromLogContext()
    .Enrich.WithThreadId()
    .Enrich.WithMemoryUsage()
    .Enrich.WithEnvironmentUserName()
    .WriteTo.Async(a =>
    {
        a.File("./logs/log-.txt", rollingInterval: RollingInterval.Day);
        a.Console();
    })
    .CreateBootstrapLogger();
try
{
    var builder = WebApplication.CreateBuilder(args);
                                  
    builder.Configuration
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true)
        .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
        .AddEnvironmentVariables();

    builder.Host
        .UseDefaultServiceProvider(options => options.ValidateScopes = false)
        .UseSerilog((context, services, configuration) => configuration
            .ReadFrom.Configuration(context.Configuration)
            .ReadFrom.Services(services)
            .Enrich.FromLogContext());

    // Add services to the container.
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddEveOfMidnightDataServices(builder.Configuration.GetConnectionString("EOMDb"));

    builder.Services.AddEveOfMidnightMediatorServices<Program>();

    builder.Services.AddCors();
    
    builder.Services.AddResponseCaching();

    builder.Services.AddResponseCompression(options => options.MimeTypes = new[]
    {
        MediaTypeNames.Application.Octet
    });

    builder.Logging.ClearProviders()
            .AddSerilog();

    var app = builder.Build();

    app.UseResponseCaching();
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    var summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    app.MapGet("/weatherforecast", () =>
        {
            var forecast = Enumerable.Range(1, 5).Select(index =>
                    new WeatherForecast
                    (
                        DateTime.Now.AddDays(index),
                        Random.Shared.Next(-20, 55),
                        summaries[Random.Shared.Next(summaries.Length)]
                    ))
                .ToArray();

            return forecast;
        })
        .WithName("GetWeatherForecast")
        .Produces<WeatherForecastViewModelCollection>((int)HttpStatusCode.OK, MediaTypeNames.Application.Json);

    app.MapGet("/home", () =>
        {
            var home = new Home();

            return home;
        })
        .WithName("GetHome")
        .Produces<HomeViewModel>((int)HttpStatusCode.OK, MediaTypeNames.Application.Json);

    app.MapGet("/focuses", async () =>
        {
            var mediator = app.Services.GetRequiredService<IMediator>();

            var focuses = await mediator.Send(new GetFocusesQuery());

            return focuses;
        })
        .WithName("GetFocuses")
        .Produces<FocusList>((int)HttpStatusCode.OK, MediaTypeNames.Application.Json);

    await app.RunAsync();
}
catch (Exception ex)
{
    Log.Fatal("{application} failed before it could be started due to exception: {@ex}", nameof(Program), ex);
}
finally
{
    Log.CloseAndFlush();
}

public record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}