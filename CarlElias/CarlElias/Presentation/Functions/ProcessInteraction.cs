using CarlElias.Application.Interfaces.Services;
using CarlElias.Presentation.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace CarlElias.Presentation.Functions
{
    public class ProcessInteraction(ILogger<ProcessInteraction> logger, ICryptographyService cryptographyService)
    {
        [Function(nameof(ProcessInteraction))]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
        {
            logger.LogInformation("Request Received");

            if (!req.Headers.TryGetValue(PresentationConstants.AuthSignatureHeaderName, out var signatureHex) || !req.Headers.TryGetValue(PresentationConstants.AuthTimestampHeaderName, out var timestamp))
            {
                return new UnauthorizedResult();
            }

            if (string.IsNullOrEmpty(signatureHex) || string.IsNullOrEmpty(timestamp))
            {
                return new UnauthorizedResult();
            }

            var messageBody = await new StreamReader(req.Body).ReadToEndAsync();

            if (!cryptographyService.VerifyRequest(signatureHex, timestamp, messageBody))
            {
                return new UnauthorizedObjectResult("invalid request signature");
            }

            logger.LogInformation("Valid request, processing message with body: {messageBody}", messageBody);

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
