using CarlElias.Common.Enums.Discord;
using CarlElias.Common.Types;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    public class Sticker
    {
        /// <summary>
        /// Id of the sticker
        /// </summary>
        [JsonPropertyName("id")]
        public Snowflake Id { get; set; }

        /// <summary>
        /// For standard stickers, id of the pack the sticker is from
        /// </summary>
        [JsonPropertyName("pack_id")]
        public Snowflake? PackId { get; set; }

        /// <summary>
        /// Name of the sticker
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the sticker
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Autocomplete/suggestion tags for the sticker (max 200 characters)
        /// </summary>
        [JsonPropertyName("tags")]
        public string? Tags { get; set; }

        /// <summary>
        /// Type of sticker
        /// </summary>
        [JsonPropertyName("type")]
        public StickerType? Type { get; set; }

        /// <summary>
        /// Type of sticker format
        /// </summary>
        [JsonPropertyName("format_type")]
        public StickerFormatType Format { get; set; }

        /// <summary>
        /// Whether this guild sticker can be used, may be false due to loss of Server Boosts
        /// </summary>
        [JsonPropertyName("available")]
        public bool? Available { get; set; }

        /// <summary>
        /// Id of the guild that owns this sticker
        /// </summary>
        [JsonPropertyName("guild_id")]
        public Snowflake? GuildId { get; set; }

        /// <summary>
        /// The user that uploaded the guild sticker
        /// </summary>
        [JsonPropertyName("user")]
        public User? CreatedByUser { get; set; }

        /// <summary>
        /// The standard sticker's sort order within its pack
        /// </summary>
        [JsonPropertyName("sort_value")]
        public int? SortValue { get; set; }
    }
}
