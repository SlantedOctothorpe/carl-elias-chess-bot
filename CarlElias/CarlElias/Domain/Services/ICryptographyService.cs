using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlElias.Domain.Services
{
    public interface ICryptographyService
    {
        Task<bool> VerifyRequest(string signatureHeader, string timestampHeader, string messageBody);
    }
}
