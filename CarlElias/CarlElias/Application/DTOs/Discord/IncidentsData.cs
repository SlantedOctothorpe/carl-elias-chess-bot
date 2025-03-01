using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    public class IncidentsData
    {
        /// <summary>
        /// The channel's id
        /// </summary>
        [JsonPropertyName("invites_disabled_until")]
        public DateTimeOffset? InvitesDisabledUntil { get; set; }

        /// <summary>
        /// The description shown for the channel
        /// </summary>
        [JsonPropertyName("dms_disabled_until")]
        public DateTimeOffset? DmsDisabledUntil { get; set; }

        /// <summary>
        /// The emoji id, if the emoji is custom
        /// </summary>
        [JsonPropertyName("dm_spam_detected_at")]
        public DateTimeOffset? DmSpamDetectedAt { get; set; }

        /// <summary>
        /// The emoji name if custom, the unicode character if standard, or <see langword="null"/> if no emoji is set
        /// </summary>
        [JsonPropertyName("raid_detected_at")]
        public DateTimeOffset? RaidDetectedAt { get; set; }
    }
}
