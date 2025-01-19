using CarlElias.Application.Services;
using CarlElias.Domain.Services;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services =>
    {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();

        services.AddHttpClient("DiscordClient", client =>
        {
            var botName = Environment.GetEnvironmentVariable("DiscordBotName");
            var botURL = Environment.GetEnvironmentVariable("DiscordBotURL");
            var botVersion = Environment.GetEnvironmentVariable("DiscordBotVersion");
            var userAgent = $"{botName} ({botURL}, {botVersion})";

            client.DefaultRequestHeaders.Add("User-Agent", userAgent);
            client.DefaultRequestHeaders.Add("Content-Type", "application/json");
        });

        services.AddSingleton<ICryptographyService, NSecCryptographyService>();
    })
    .Build();

host.Run();