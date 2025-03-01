using CarlElias.Common.Types;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    public class RoleTags
    {
        /// <summary>
        /// The id of the bot this role belongs to
        /// </summary>
        [JsonPropertyName("bot_id")]
        public Snowflake BotId { get; set; }

        /// <summary>
        /// The id of the integration this role belongs to
        /// </summary>
        [JsonPropertyName("integration_id")]
        public Snowflake IntegrationId { get; set; }

        /// <summary>
        /// Whether this is the guild's Booster role
        /// API assumes false values are not present in message
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("premium_subscriber")]
        public NullBool IsPremiumSubscriber { get; set; }

        /// <summary>
        /// The id of this role's subscription sku and listing
        /// </summary>
        [JsonPropertyName("subscription_listing_id")]
        public Snowflake SubscriptionListingId { get; set; }

        /// <summary>
        /// Whether this role is available for purchase
        /// API assumes false values are not present in message
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("available_for_purchase")]
        public NullBool IsAvailableForPurchase { get; set; }

        /// <summary>
        /// Whether this role is a guild's linked role
        /// API assumes false values are not present in message
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("guild_connections")]
        public NullBool GuildConnections { get; set; }
    }
}
