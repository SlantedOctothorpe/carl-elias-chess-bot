using CarlElias.Common.Types;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    public class AvatarDecorationData
    {
        [JsonPropertyName("asset")]
        public string AssetHash { get; set; }

        [JsonPropertyName("sku_id")]
        public Snowflake SkuId { get; set; }
    }
}
