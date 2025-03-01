using CarlElias.Common.Types;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    public class Emoji
    {
        /// <summary>
        /// Emoji id
        /// </summary>
        [JsonPropertyName("id")]
        public Snowflake? Id { get; set; }

        /// <summary>
        /// Emoji name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Roles allowed to use this emoji
        /// </summary>
        [JsonPropertyName("roles")]
        public Snowflake[]? RolesAllowed { get; set; }

        /// <summary>
        /// User that created this emoji
        /// </summary>
        [JsonPropertyName("user")]
        public User? CreatedByUser { get; set; }

        /// <summary>
        /// Whether this emoji must be wrapped in colons
        /// </summary>
        [JsonPropertyName("require_colons")]
        public bool? RequireColons { get; set; }

        /// <summary>
        /// Whether this emoji is managed
        /// </summary>
        [JsonPropertyName("managed")]
        public bool? Managed { get; set; }

        /// <summary>
        /// Whether this emoji is animated
        /// </summary>
        [JsonPropertyName("animated")]
        public bool Animated { get; set; }

        /// <summary>
        /// Whether this emoji can be used, may be false due to loss of Server Boosts
        /// </summary>
        [JsonPropertyName("available")]
        public bool? Available { get; set; }
    }
}
