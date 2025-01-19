using CarlElias.Domain.Services;
using Microsoft.AspNetCore.Http;
using System.Text;
using NSec.Cryptography;

namespace CarlElias.Application.Services
{
    public class NSecCryptographyService : ICryptographyService
    {
        public async Task<bool> VerifyRequest(string signatureHeader, string timestampHeader, string messageBody)
        {
            var verifyResult = true;

            var publicKeyHex = Environment.GetEnvironmentVariable("DiscordPublicKey") ?? "";

            var publicKeyBytes = Convert.FromHexString(publicKeyHex);
            var publicKey = PublicKey.Import(SignatureAlgorithm.Ed25519, publicKeyBytes, KeyBlobFormat.RawPublicKey);

            //var signatureHeader = request.Headers["X-Signature-Ed25519"];
            //var timestampHeader = request.Headers["X-Signature-Timestamp"];

            //// In case request body has already been read seek to beginning
            //var messageBody = await new StreamReader(request.Body).ReadToEndAsync();

            if (string.IsNullOrEmpty(signatureHeader) || string.IsNullOrEmpty(timestampHeader) || string.IsNullOrEmpty(messageBody))
            {
                throw new UnauthorizedAccessException("invalid request signature");
            }

            var toVerifyString = timestampHeader + messageBody;
            var message = Encoding.UTF8.GetBytes(toVerifyString);

            try
            {
                var signatureBytes = Convert.FromHexString(signatureHeader);

                var algorithm = SignatureAlgorithm.Ed25519;

                // Verify the signature
                if (!algorithm.Verify(publicKey, message, signatureBytes))
                {
                    throw new UnauthorizedAccessException("invalid request signature");
                }
            }
            catch (Exception)
            {
                throw new UnauthorizedAccessException("invalid request signature");
            }

            return verifyResult;
        }
    }
}
