using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CarlElias.Application.DTOs.Discord
{
    public class AvatarDecorationData
    {
        [JsonPropertyName("asset")]
        public string AssetHash { get; set; }

        [JsonPropertyName("sku_id")]
        public ulong SkuId { get; set; }
    }
}
