using CarlElias.Common.Types;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    public class WelcomeScreenChannel
    {
        /// <summary>
        /// The channel's id
        /// </summary>
        [JsonPropertyName("channel_id")]
        public Snowflake ChannelId { get; set; }

        /// <summary>
        /// The description shown for the channel
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The emoji id, if the emoji is custom
        /// </summary>
        [JsonPropertyName("emoji_id")]
        public Snowflake? EmojiId { get; set; }

        /// <summary>
        /// The emoji name if custom, the unicode character if standard, or <see langword="null"/> if no emoji is set
        /// </summary>
        [JsonPropertyName("emoji_name")]
        public string? EmojiName { get; set; }
    }
}
