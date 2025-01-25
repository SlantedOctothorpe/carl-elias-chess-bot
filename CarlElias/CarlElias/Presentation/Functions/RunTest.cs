using CarlElias.Application.DTOs.Discord;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CarlElias.Presentation.Functions
{
    public class RunTest(ILogger<RunTest> logger)
    {
        [Function(nameof(RunTest))]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            logger.LogInformation("C# HTTP trigger function processed a request.");

            var messageBody = await new StreamReader(req.Body).ReadToEndAsync();

            var entitlement = JsonSerializer.Deserialize<Entitlement>(messageBody);

            if (entitlement == null)
            {
                return new BadRequestObjectResult("Invalid request body");
            }

            logger.LogInformation("Entitlement: {entitlement}", entitlement.Id);

            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
