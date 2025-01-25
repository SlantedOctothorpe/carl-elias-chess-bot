using Microsoft.AspNetCore.Http;
using System.Text;
using NSec.Cryptography;
using Microsoft.Extensions.Logging;
using CarlElias.Application.Interfaces.Services;

namespace CarlElias.Application.Services
{
    public class NSecCryptographyService(ILogger<NSecCryptographyService> logger) : ICryptographyService
    {
        public bool VerifyRequest(string signatureHeader, string timestampHeader, string messageBody)
        {
            var publicKeyHex = Environment.GetEnvironmentVariable("DiscordPublicKey") ?? "";

            if (string.IsNullOrEmpty(signatureHeader) || string.IsNullOrEmpty(timestampHeader) || string.IsNullOrEmpty(messageBody) || string.IsNullOrEmpty(publicKeyHex))
            {
                return false;
            }

            var publicKeyBytes = Convert.FromHexString(publicKeyHex);
            var publicKey = PublicKey.Import(SignatureAlgorithm.Ed25519, publicKeyBytes, KeyBlobFormat.RawPublicKey);

            var toVerifyString = timestampHeader + messageBody;
            var message = Encoding.UTF8.GetBytes(toVerifyString);

            try
            {
                var signatureBytes = Convert.FromHexString(signatureHeader);

                var algorithm = SignatureAlgorithm.Ed25519;

                // Verify the signature
                if (!algorithm.Verify(publicKey, message, signatureBytes))
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                logger.LogError(e, "Error verifying request");
                return false;
            }

            return true;
        }
    }
}
