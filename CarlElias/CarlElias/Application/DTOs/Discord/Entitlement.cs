using CarlElias.Common.Enums.Discord;
using CarlElias.Common.Types;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    public class Entitlement
    {
        /// <summary>
        /// ID of the entitlement
        /// </summary>
        [JsonPropertyName("id")]
        public Snowflake Id { get; set; }

        /// <summary>
        /// ID of the SKU
        /// </summary>
        [JsonPropertyName("sku_id")]
        public Snowflake SkuId { get; set; }

        /// <summary>
        /// ID of the parent application
        /// </summary>
        [JsonPropertyName("application_id")]
        public Snowflake ApplicationId { get; set; }

        /// <summary>
        /// ID of the user that is granted access to the entitlement's sku
        /// </summary>
        [JsonPropertyName("user_id")]
        public Snowflake? UserId { get; set; }

        /// <summary>
        /// Type of entitlement
        /// </summary>
        [JsonPropertyName("type")]
        public EntitlementType Type { get; set; }

        /// <summary>
        /// Entitlement was deleted
        /// </summary>
        [JsonPropertyName("deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// Start date at which the entitlement is valid
        /// </summary>
        [JsonPropertyName("starts_at")]
        public DateTimeOffset? StartsAt { get; set; }

        /// <summary>
        /// Date at which the entitlement is no longer valid
        /// </summary>
        [JsonPropertyName("ends_at")]
        public DateTimeOffset? EndsAt { get; set; }

        /// <summary>
        /// ID of the guild that is granted access to the entitlement's sku
        /// </summary>
        [JsonPropertyName("guild_id")]
        public Snowflake? GuildId { get; set; }

        /// <summary>
        /// For consumable items, whether or not the entitlement has been consumed
        /// </summary>
        [JsonPropertyName("consumed")]
        public bool? Consumed { get; set; }
    }
}
