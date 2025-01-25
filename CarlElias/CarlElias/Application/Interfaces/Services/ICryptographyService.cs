using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlElias.Application.Interfaces.Services
{
    public interface ICryptographyService
    {
        bool VerifyRequest(string signatureHeader, string timestampHeader, string messageBody);
    }
}
