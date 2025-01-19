using CarlElias.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace CarlElias.Functions
{
    public class ProcessInteraction(ILogger<ProcessInteraction> logger, ICryptographyService cryptographyService)
    {
        [Function(nameof(ProcessInteraction))]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            logger.LogInformation("C# HTTP trigger function processed a request.");

            var messageBody = await new StreamReader(req.Body).ReadToEndAsync();

            // TODO Remove these
            var signatureHex = req.Headers["X-Signature-Ed25519"];
            var timestamp = req.Headers["X-Signature-Timestamp"];

            logger.LogInformation("Message information:");
            logger.LogInformation("Signatrue: {}", signatureHex);
            logger.LogInformation("Timestamp: {}", timestamp);
            logger.LogInformation("Message Body: {}", messageBody);

            try
            {
                await cryptographyService.VerifyRequest(signatureHex, timestamp, messageBody);
            }
            catch (UnauthorizedAccessException uae)
            {
                var errorMessage = uae.Message;

                return new UnauthorizedObjectResult(errorMessage);
            }

            var interactionRequest = JsonSerializer.Deserialize<JsonNode>(messageBody);
            var interactionType = interactionRequest["type"].GetValue<int>();

            if (interactionType == 1)
            {
                return new JsonResult(new { type = 1 });
            }

            return new UnauthorizedResult();
        }
    }
}
