using CarlElias.Common.Enums.Discord;
using CarlElias.Common.Types;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    /// <summary>
    /// Represents a guild or DM channel within Discord
    /// </summary>
    public class Channel
    {
        /// <summary>
        /// The id of this channel
        /// </summary>
        [JsonPropertyName("id")]
        public Snowflake Id { get; set; }

        /// <summary>
        /// The type of channel
        /// </summary>
        [JsonPropertyName("type")]
        public ChannelType Type { get; set; }

        /// <summary>
        /// The id of the guild (may be missing for some channel objects received over gateway guild dispatches)
        /// </summary>
        [JsonPropertyName("guild_id")]
        public Snowflake? GuildId { get; set; }

        /// <summary>
        /// Sorting position of the channel (channels with the same position are sorted by id)
        /// </summary>
        [JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Explicit permission overwrites for members and roles
        /// </summary>
        [JsonPropertyName("permission_overwrites")]
        public PermissionOverwrite[]? PermissionOverwrites { get; set; }

        /// <summary>
        /// The name of the channel (1-100 characters)
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The channel topic (0-4096 characters for <see cref="ChannelType.GuildForumChannel"/> and <see cref="ChannelType.GuildMediaChannel"/> channels, 0-1024 characters for all others)
        /// </summary>
        [JsonPropertyName("topic")]
        public string? Topic { get; set; }

        /// <summary>
        /// Whether the channel is nsfw
        /// </summary>
        [JsonPropertyName("nsfw")]
        public bool? IsNsfwChannel { get; set; }

        /// <summary>
        /// The id of the last message sent in this channel (or thread for <see cref="ChannelType.GuildForumChannel"/> or <see cref="ChannelType.GuildMediaChannel"/> channels) (may not point to an existing or valid message or thread)
        /// </summary>
        [JsonPropertyName("last_message_id")]
        public Snowflake? LastMessageId { get; set; }

        /// <summary>
        /// The bitrate (in bits) of the voice channel
        /// </summary>
        [JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// The user limit of the voice channel
        /// </summary>
        [JsonPropertyName("user_limit")]
        public int? UserLimit { get; set; }

        /// <summary>
        /// Amount of seconds a user has to wait before sending another message (0-21600) <para />
        /// Bots, as well as users with the permission <see cref="Permissions.ManageMessages"/> or <see cref="Permissions.ManageChannels"/>, are unaffected <para />
        /// <see cref="RateLimitSecordsPerUser"/> also applies to thread creation. Users can send one message and create one thread during each <see cref="RateLimitSecordsPerUser"/> interval
        /// </summary>
        [JsonPropertyName("rate_limit_per_user")]
        public int? RateLimitSecordsPerUser { get; set; }

        /// <summary>
        /// The recipients of the DM
        /// </summary>
        [JsonPropertyName("recipients")]
        public User[]? Recipients { get; set; }

        /// <summary>
        /// Icon hash of the group DM
        /// </summary>
        [JsonPropertyName("icon")]
        public string? IconHash { get; set; }

        /// <summary>
        /// Id of the creator of the group DM or thread
        /// </summary>
        [JsonPropertyName("owner_id")]
        public Snowflake? OwnerId { get; set; }

        /// <summary>
        /// Application id of the group DM creator if it is bot-created
        /// </summary>
        [JsonPropertyName("application_id")]
        public Snowflake? ApplicationId { get; set; }

        /// <summary>
        /// For group DM channels: whether the channel is managed by an application via the gdm.join OAuth2 scope
        /// </summary>
        [JsonPropertyName("managed")]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// For guild channels: id of the parent category for a channel (each parent category can contain up to 50 channels) <para />
        /// For threads: id of the text channel this thread was created
        /// </summary>
        [JsonPropertyName("parent_id")]
        public Snowflake? ParentId { get; set; }

        /// <summary>
        /// When the last pinned message was pinned <para />
        /// This may be <see langword="null"/> in events such as GUILD_CREATE when a message is not pinned
        /// </summary>
        [JsonPropertyName("last_pin_timestamp")]
        public DateTimeOffset? LastPinDateTime { get; set; }

        /// <summary>
        /// Voice region id for the voice channel, automatic when set to <see langword="null"/>
        /// </summary>
        [JsonPropertyName("rtc_region")]
        public string? RtcRegion { get; set; }

        /// <summary>
        /// The camera <see cref="Common.Enums.Discord.VideoQualityMode"/> of the voice channel, <see cref="VideoQualityMode.Auto"/> when not present
        /// </summary>
        [JsonPropertyName("video_quality_mode")]
        public VideoQualityMode? VideoQualityMode { get; set; }

        /// <summary>
        /// Number of messages (not including the initial message or deleted messages) in a thread
        /// </summary>
        [JsonPropertyName("message_count")]
        public int? MessageCount { get; set; }

        /// <summary>
        /// An approximate count of users in a thread, stops counting at 50
        /// </summary>
        [JsonPropertyName("member_count")]
        public int? MemberCount { get; set; }

        /// <summary>
        /// Thread-specific fields not needed by other channels
        /// </summary>
        [JsonPropertyName("thread_metadata")]
        public ThreadMetadata? ThreadMetadata { get; set; }

        /// <summary>
        /// Thread member object for the current user, if they have joined the thread, only included on certain API endpoints
        /// </summary>
        [JsonPropertyName("member")]
        public ThreadCurrentMember? CurrentMember { get; set; }

        /// <summary>
        /// Default duration, copied onto newly created threads, in minutes, threads will stop showing in the channel list after the specified period of inactivity, can be set to: 60, 1440, 4320, 10080
        /// </summary>
        [JsonPropertyName("default_auto_archive_duration")]
        public int? DefaultAutoArchiveDuration { get; set; }

        /// <summary>
        /// Computed permissions for the invoking user in the channel, including overwrites, only included when part of the resolved data received on a slash command interaction <para />
        /// This does not include implicit permissions, which may need to be checked separately
        /// </summary>
        [JsonPropertyName("permissions")]
        public Permissions? Permissions { get; set; }

        /// <summary>
        /// <see cref="ChannelFlags"/> combined as a bitfield
        /// </summary>
        [JsonPropertyName("flags")]
        public ChannelFlags? Flags { get; set; }

        /// <summary>
        /// Number of messages ever sent in a thread, it's similar to <see cref="MessageCount"/> on message creation, but will not decrement the number when a message is deleted
        /// </summary>
        [JsonPropertyName("total_message_sent")]
        public int? TotalMessagesSent { get; set; }

        /// <summary>
        /// The set of tags that can be used in a <see cref="ChannelType.GuildForumChannel"/> or <see cref="ChannelType.GuildMediaChannel"/> channel
        /// </summary>
        [JsonPropertyName("available_tags")]
        public ForumTag[]? AvailableTags { get; set; }

        /// <summary>
        /// The IDs of the set of tags that have been applied to a thread in a <see cref="ChannelType.GuildForumChannel"/> or a <see cref="ChannelType.GuildMediaChannel"/> channel
        /// </summary>
        [JsonPropertyName("applied_tags")]
        public Snowflake[]? AppliedTags { get; set; }

        /// <summary>
        /// The emoji to show in the add reaction button on a thread in a <see cref="ChannelType.GuildForumChannel"/> or a <see cref="ChannelType.GuildMediaChannel"/> channel
        /// </summary>
        [JsonPropertyName("default_reaction_emoji")]
        public ChannelDefaultReaction? DefaultReactionEmoji { get; set; }

        /// <summary>
        /// The initial <see cref="RateLimitSecordsPerUser"/> to set on newly created threads in a channel <para />
        /// This field is copied to the thread at creation time and does not live update
        /// </summary>
        [JsonPropertyName("default_thread_rate_limit_per_user")]
        public int? DefaultThreadRateLimitSeconds { get; set; }

        /// <summary>
        /// The default sort order type used to order posts in <see cref="ChannelType.GuildForumChannel"/> and <see cref="ChannelType.GuildMediaChannel"/> channels <para />
        /// Defaults to <see langword="null"/>, which indicates a preferred sort order hasn't been set by a channel admin
        /// </summary>
        [JsonPropertyName("default_sort_order")]
        public ChannelSortOrderType? DefaultSortOrder { get; set; }

        /// <summary>
        /// The default forum layout view used to display posts in <see cref="ChannelType.GuildForumChannel"/> channels <para />
        /// Defaults to 0, which indicates a layout view has not been set by a channel admin
        /// </summary>
        [JsonPropertyName("default_forum_layout")]
        public ChannelForumLayoutType? DefaultForumLayout { get; set; }
    }
}
