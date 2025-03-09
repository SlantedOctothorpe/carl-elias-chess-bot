using CarlElias.Common.Types;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    /// <summary>
    /// A thread member object contains information about a user that has joined a thread
    /// </summary>
    public class ThreadCurrentMember
    {
        /// <summary>
        /// ID of the thread
        /// </summary>
        [JsonPropertyName("id")]
        public Snowflake? Id { get; set; }

        /// <summary>
        /// ID of the user
        /// </summary>
        [JsonPropertyName("user_id")]
        public Snowflake? UserId { get; set; }

        /// <summary>
        /// Time the user last joined the thread
        /// </summary>
        [JsonPropertyName("join_timestamp")]
        public DateTimeOffset JoinTimestamp { get; set; }

        /// <summary>
        /// Any user-thread settings, currently only used for notifications
        /// </summary>
        [JsonPropertyName("flags")]
        public int Flags { get; set; }

        /// <summary>
        /// Additional information about the user
        /// </summary>
        [JsonPropertyName("member")]
        public GuildMember? Member { get; set; }
    }
}
