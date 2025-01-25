using CarlElias.Common.Enums.Discord;
using CarlElias.Common.Types;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    public class GuildMember
    {
        /// <summary>
        /// The user this guild member represents
        /// </summary>
        [JsonPropertyName("user")]
        public User? User { get; set; }

        /// <summary>
        /// This user's guild nickname
        /// </summary>
        [JsonPropertyName("nick")]
        public string? Nickname { get; set; }

        /// <summary>
        /// The member's guild avatar hash
        /// </summary>
        [JsonPropertyName("avatar")]
        public string? GuildAvatarHash { get; set; }

        /// <summary>
        /// The member's guild banner hash
        /// </summary>
        [JsonPropertyName("banner")]
        public string? GuildBannerHash { get; set; }

        /// <summary>
        /// Array of role object ids
        /// </summary>
        [JsonPropertyName("roles")]
        public Snowflake[] RoleIds { get; set; }

        /// <summary>
        /// When the user joined the guild
        /// </summary>
        [JsonPropertyName("joined_at")]
        public DateTimeOffset JoinedAt { get; set; }

        /// <summary>
        /// When the user started boosting the guild
        /// </summary>
        [JsonPropertyName("premium_since")]
        public DateTimeOffset? GuildBoostStart { get; set; }

        /// <summary>
        /// Whether the user is deafened in voice channels
        /// </summary>
        [JsonPropertyName("deaf")]
        public bool IsDeafened { get; set; }

        /// <summary>
        /// Whether the user is muted in voice channels
        /// </summary>
        [JsonPropertyName("mute")]
        public bool IsMuted { get; set; }

        /// <summary>
        /// Guild member flags represented as a bit set, defaults to 0
        /// </summary>
        [JsonPropertyName("flags")]
        public GuildMemberFlags GuildFlags { get; set; }

        /// <summary>
        /// Whether the user has not yet passed the guild's Membership Screening requirements
        /// </summary>
        [JsonPropertyName("pending")]
        public bool? IsPendingScreening { get; set; }

        /// <summary>
        /// Total permissions of the member in the channel, including overwrites, returned when in the interaction object
        /// </summary>
        [JsonPropertyName("permissions")]
        public string? Permissions { get; set; }

        /// <summary>
        /// When the user's timeout will expire and the user will be able to communicate in the guild again, null or a time in the past if the user is not timed out
        /// </summary>
        [JsonPropertyName("communication_disabled_until")]
        public DateTimeOffset? TimeOutUntil { get; set; }

        /// <summary>
        /// Data for the member's guild avatar decoration
        /// </summary>
        [JsonPropertyName("avatar_decoration_data")]
        public AvatarDecorationData? GuildAvatarDecorationData { get; set; }
    }
}
