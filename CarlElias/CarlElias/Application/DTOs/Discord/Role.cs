using CarlElias.Common.Enums.Discord;
using CarlElias.Common.Types;
using System.Drawing;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    public class Role
    {
        /// <summary>
        /// Role id
        /// </summary>
        [JsonPropertyName("id")]
        public Snowflake Id { get; set; }

        /// <summary>
        /// Role name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Integer representation of hexadecimal color code
        /// </summary>
        [JsonPropertyName("color")]
        public Color Color { get; set; }

        /// <summary>
        /// If this role is pinned in the user listing
        /// </summary>
        [JsonPropertyName("hoist")]
        public bool Hoist { get; set; }

        /// <summary>
        /// Role icon hash
        /// </summary>
        [JsonPropertyName("icon")]
        public string? IconHash { get; set; }

        /// <summary>
        /// Role unicode emoji
        /// </summary>
        [JsonPropertyName("unicode_emoji")]
        public string? UnicodeEmoji { get; set; }

        /// <summary>
        /// Position of this role (roles with the same position are sorted by id)
        /// </summary>
        [JsonPropertyName("position")]
        public int Position { get; set; }

        /// <summary>
        /// Permission bit set
        /// </summary>
        [JsonPropertyName("permissions")]
        public Permissions Permissions { get; set; }

        /// <summary>
        /// Whether this role is managed by an integration
        /// </summary>
        [JsonPropertyName("managed")]
        public bool Managed { get; set; }

        /// <summary>
        /// Whether this role is mentionable
        /// </summary>
        [JsonPropertyName("mentionable")]
        public bool Mentionable { get; set; }

        /// <summary>
        /// The tags this role has
        /// </summary>
        [JsonPropertyName("tags")]
        public RoleTags? Tags { get; set; }

        /// <summary>
        /// Role flags combined as a bitfield
        /// </summary>
        [JsonPropertyName("flags")]
        public RoleFlags Flags { get; set; }
    }
}
