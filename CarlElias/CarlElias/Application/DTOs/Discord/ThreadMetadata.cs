using CarlElias.Common.Enums.Discord;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    /// <summary>
    /// The thread metadata object contains a number of thread-specific channel fields that are not needed by other channel types
    /// </summary>
    public class ThreadMetadata
    {
        /// <summary>
        /// Whether the thread is archived
        /// </summary>
        [JsonPropertyName("archived")]
        public bool IsArchived { get; set; }

        /// <summary>
        /// The thread will stop showing in the channel list after auto_archive_duration minutes of inactivity, can be set to: 60, 1440, 4320, 10080
        /// </summary>
        [JsonPropertyName("auto_archive_duration")]
        public int AutoArchiveDuration { get; set; }

        /// <summary>
        /// Timestamp when the thread's archive status was last changed, used for calculating recent activity
        /// </summary>
        [JsonPropertyName("archive_timestamp")]
        public DateTimeOffset ArchiveTimestamp { get; set; }

        /// <summary>
        /// Whether the thread is locked; when a thread is locked, only users with <see cref="Permissions.ManageThreads"/> can unarchive it
        /// </summary>
        [JsonPropertyName("locked")]
        public bool IsLocked { get; set; }

        /// <summary>
        /// Whether non-moderators can add other non-moderators to a thread; only available on private threads
        /// </summary>
        [JsonPropertyName("invitable")]
        public bool? IsInvitable { get; set; }

        /// <summary>
        /// Timestamp when the thread was created; only populated for threads created after 2022-01-09
        /// </summary>
        [JsonPropertyName("create_timestamp")]
        public DateTimeOffset? CreateTimestamp { get; set; }
    }
}
