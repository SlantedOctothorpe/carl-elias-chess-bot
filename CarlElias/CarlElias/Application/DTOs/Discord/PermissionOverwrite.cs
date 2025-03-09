using CarlElias.Common.Enums.Discord;
using CarlElias.Common.Types;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    public class PermissionOverwrite
    {
        /// <summary>
        /// Role or user id
        /// </summary>
        [JsonPropertyName("id")]
        public Snowflake Id { get; set; }

        /// <summary>
        /// One of <see cref="PermissionOverwriteType"/>
        /// </summary>
        [JsonPropertyName("type")]
        public PermissionOverwriteType Type { get; set; }

        /// <summary>
        /// Allow permissions
        /// </summary>
        [JsonPropertyName("allow")]
        public Permissions Allow { get; set; }

        /// <summary>
        /// Deny permissions
        /// </summary>
        [JsonPropertyName("deny")]
        public Permissions Deny { get; set; }
    }
}
