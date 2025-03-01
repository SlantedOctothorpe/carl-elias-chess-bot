using CarlElias.Common.Enums.Discord;
using CarlElias.Common.Types;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    public class Guild
    {
        /// <summary>
        /// Guild id
        /// </summary>
        [JsonPropertyName("id")]
        public Snowflake Id { get; set; }

        /// <summary>
        /// Guild name (2-100 characters, excluding trailing and leading whitespace)
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Icon hash
        /// </summary>
        [JsonPropertyName("icon")]
        public string? IconHash { get; set; }

        /// <summary>
        /// Icon hash, returned when in the template object
        /// </summary>
        [JsonPropertyName("icon_hash")]
        public string? TemplateIconHash { get; set; }

        /// <summary>
        /// Splash hash
        /// </summary>
        [JsonPropertyName("splash")]
        public string? SplashHash { get; set; }

        /// <summary>
        /// Discovery splash hash; only present for guilds with the "DISCOVERABLE" feature
        /// </summary>
        [JsonPropertyName("discovery_splash")]
        public string? DiscoverySplashHash { get; set; }

        /// <summary>
        /// true if the user is the owner of the guild
        /// </summary>
        [JsonPropertyName("owner")]
        public bool IsOwner { get; set; }

        /// <summary>
        /// Id of owner
        /// </summary>
        [JsonPropertyName("owner_id")]
        public Snowflake OwnerId { get; set; }

        /// <summary>
        /// Total permissions for the user in the guild (excludes overwrites and implicit permissions)
        /// </summary>
        [JsonPropertyName("permissions")]
        public Permissions? Permissions { get; set; }

        /// <summary>
        /// Id of afk channel
        /// </summary>
        [JsonPropertyName("afk_channel_id")]
        public Snowflake? AfkChannelId { get; set; }

        /// <summary>
        /// Afk timeout in seconds
        /// </summary>
        [JsonPropertyName("afk_timeout")]
        public int AfkTimeout { get; set; }

        /// <summary>
        /// True if the server widget is enabled
        /// </summary>
        [JsonPropertyName("widget_enabled")]
        public bool? IsWidgetEnabled { get; set; }

        /// <summary>
        /// The channel id that the widget will generate an invite to, or <see langword="null"/> if set to no invite
        /// </summary>
        [JsonPropertyName("widget_channel_id")]
        public Snowflake? WidgetChannelId { get; set; }

        /// <summary>
        /// Verification level required for the guild
        /// </summary>
        [JsonPropertyName("verification_level")]
        public VerificationLevel VerificationLevel { get; set; }

        /// <summary>
        /// Default message notifications level
        /// </summary>
        [JsonPropertyName("default_message_notifications")]
        public DefaultMessageNotificationLevel DefaultMessageNotificationLevel { get; set; }

        /// <summary>
        /// Explicit content filter level
        /// </summary>
        [JsonPropertyName("explicit_content_filter")]
        public ExplicitContentFilterLevel ExplicitContentFilterLevel { get; set; }

        /// <summary>
        /// Roles in the guild
        /// </summary>
        [JsonPropertyName("roles")]
        public Role[] Roles { get; set; }

        /// <summary>
        /// Custom guild emojis
        /// </summary>
        [JsonPropertyName("emojis")]
        public Emoji[] Emojis { get; set; }

        /// <summary>
        /// Enabled guild features
        /// </summary>
        [JsonPropertyName("features")]
        public string[] Features { get; set; }

        /// <summary>
        /// Required MFA level for the guild
        /// </summary>
        [JsonPropertyName("mfa_level")]
        public MfaLevel MfaLevel { get; set; }

        /// <summary>
        /// Application id of the guild creator if it is bot-created
        /// </summary>
        [JsonPropertyName("application_id")]
        public Snowflake? ApplicationId { get; set; }

        /// <summary>
        /// The id of the channel where guild notices such as welcome messages and boost events are posted
        /// </summary>
        [JsonPropertyName("system_channel_id")]
        public Snowflake? SystemChannelId { get; set; }

        /// <summary>
        /// System channel flags
        /// </summary>
        [JsonPropertyName("system_channel_flags")]
        public SystemChannelFlags SystemChannelFlags { get; set; }

        /// <summary>
        /// The id of the channel where Community guilds can display rules and/or guidelines
        /// </summary>
        [JsonPropertyName("rules_channel_id")]
        public Snowflake? RulesChannelId { get; set; }

        /// <summary>
        /// The maximum number of presences for the guild (<see langword="null"/> is always returned, apart from the largest of guilds)
        /// </summary>
        [JsonPropertyName("max_presences")]
        public int? MaxPresences { get; set; }

        /// <summary>
        /// The maximum number of members for the guild
        /// </summary>
        [JsonPropertyName("max_members")]
        public int? MaxMembers { get; set; }

        /// <summary>
        /// The vanity url code for the guild
        /// </summary>
        [JsonPropertyName("vanity_url_code")]
        public string? VanityUrlCode { get; set; }

        /// <summary>
        /// The description of a guild
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Banner hash
        /// </summary>
        [JsonPropertyName("banner")]
        public string? BannerHash { get; set; }

        /// <summary>
        /// Premium tier (Server Boost level)
        /// </summary>
        [JsonPropertyName("premium_tier")]
        public PremiumTier PremiumTier { get; set; }

        /// <summary>
        /// The number of boosts this guild currently has
        /// </summary>
        [JsonPropertyName("premium_subscription_count")]
        public int? PremiumSubscriptionCount { get; set; }

        /// <summary>
        /// The preferred locale of a Community guild; used in server discovery and notices from Discord, and sent in interactions; defaults to "en-US"
        /// </summary>
        [JsonPropertyName("preferred_locale")]
        public string PreferredLocale { get; set; }

        /// <summary>
        /// The id of the channel where admins and moderators of Community guilds receive notices from Discord
        /// </summary>
        [JsonPropertyName("public_updates_channel_id")]
        public Snowflake? PublicUpdatesChannelId { get; set; }

        /// <summary>
        /// The maximum amount of users in a video channel
        /// </summary>
        [JsonPropertyName("max_video_channel_users")]
        public int? MaxVideoChannelUsers { get; set; }

        /// <summary>
        /// The maximum amount of users in a stage video channel
        /// </summary>
        [JsonPropertyName("max_stage_video_channel_users")]
        public int? MaxStageVideoChannelUsers { get; set; }

        /// <summary>
        /// Approximate number of members in this guild, returned when with_counts is <see langword="true"/>
        /// </summary>
        [JsonPropertyName("approximate_member_count")]
        public int? ApproximateMemberCount { get; set; }

        /// <summary>
        /// Approximate number of non-offline members in this guild, returned when with_counts is <see langword="true"/>
        /// </summary>
        [JsonPropertyName("approximate_presence_count")]
        public int? ApproximatePresenceCount { get; set; }

        /// <summary>
        /// The welcome screen of a Community guild, shown to new members, returned in an Invite's guild object
        /// </summary>
        [JsonPropertyName("welcome_screen")]
        public WelcomeScreen? WelcomeScreen { get; set; }

        /// <summary>
        /// Guild NSFW level
        /// </summary>
        [JsonPropertyName("nsfw_level")]
        public GuildNsfwLevel NsfwLevel { get; set; }

        /// <summary>
        /// Custom guild stickers
        /// </summary>
        [JsonPropertyName("stickers")]
        public Sticker[]? Stickers { get; set; }

        /// <summary>
        /// Whether the guild has the boost progress bar enabled
        /// </summary>
        [JsonPropertyName("premium_progress_bar_enabled")]
        public bool IsPremiumProgressBarEnabled { get; set; }

        /// <summary>
        /// The id of the channel where admins and moderators of Community guilds receive safety alerts from Discord
        /// </summary>
        [JsonPropertyName("safety_alerts_channel_id")]
        public Snowflake? SafetyAlertsChannelId { get; set; }

        /// <summary>
        /// The incidents data for this guild
        /// </summary>
        [JsonPropertyName("incidents_data")]
        public IncidentsData? IncidentsData { get; set; }
    }
}
