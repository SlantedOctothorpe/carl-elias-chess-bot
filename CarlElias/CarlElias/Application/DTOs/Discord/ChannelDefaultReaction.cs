using CarlElias.Common.Types;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    /// <summary>
    /// An object that specifies the emoji to use as the default way to react to a forum post. Exactly one of <see cref="EmojiId"/> and <see cref="EmojiName"/> must be set
    /// </summary>
    public class ChannelDefaultReaction
    {
        /// <summary>
        /// The id of a guild's custom emoji
        /// </summary>
        [JsonPropertyName("emoji_id")]
        public Snowflake? EmojiId { get; set; }

        /// <summary>
        /// The unicode character of the emoji
        /// </summary>
        [JsonPropertyName("emoji_name")]
        public string? EmojiName { get; set; }
    }
}
