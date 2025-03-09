using CarlElias.Common.Types;
using CarlElias.Common.Enums.Discord;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    /// <summary>
    /// An object that represents a tag that is able to be applied to a thread in a <see cref="ChannelType.GuildForumChannel"/> or <see cref="ChannelType.GuildMediaChannel"/> channel
    /// </summary>
    public class ForumTag
    {
        /// <summary>
        /// The id of the tag
        /// </summary>
        [JsonPropertyName("id")]
        public Snowflake Id { get; set; }

        /// <summary>
        /// The name of the tag (0-20 characters)
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Whether this tag can only be added to or removed from threads by a member with the <see cref="Permissions.ManageThreads"/> permission
        /// </summary>
        [JsonPropertyName("moderated")]
        public bool Moderated { get; set; }

        /// <summary>
        /// The id of a guild's custom emoji <para />
        /// At most one of <see cref="EmojiId"/> and <see cref="EmojiName"/> may be set to a non-null value
        /// </summary>
        [JsonPropertyName("emoji_id")]
        public Snowflake? EmojiId { get; set; }

        /// <summary>
        /// The unicode character of the emoji <para />
        /// At most one of <see cref="EmojiId"/> and <see cref="EmojiName"/> may be set to a non-null value
        /// </summary>
        [JsonPropertyName("emoji_name")]
        public string? EmojiName { get; set; }
    }
}
