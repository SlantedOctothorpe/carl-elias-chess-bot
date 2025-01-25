using CarlElias.Common.Enums.Discord;
using CarlElias.Common.Types;
using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    public class User
    {
        /// <summary>
        /// The user's id
        /// Required OAuth2 Scope: identify
        /// </summary>
        [JsonPropertyName("id")]
        public Snowflake Id { get; set; }

        /// <summary>
        /// The user's username, not unique across the platform
        /// Required OAuth2 Scope: identify
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// The user's Discord-tag
        /// Required OAuth2 Scope: identify
        /// </summary>
        [JsonPropertyName("discriminator")]
        public string Discriminator { get; set; }

        /// <summary>
        /// The user's display name, if it is set. For bots, this is the application name
        /// Required OAuth2 Scope: identify
        /// </summary>
        [JsonPropertyName("global_name")]
        public string? GlobalName { get; set; }

        /// <summary>
        /// The user's avatar hash
        /// Required OAuth2 Scope: identify
        /// </summary>
        [JsonPropertyName("avatar")]
        public string? AvatarHash { get; set; }

        /// <summary>
        /// Whether the user belongs to an OAuth2 application
        /// Required OAuth2 Scope: identify
        /// </summary>
        [JsonPropertyName("bot")]
        public bool IsBotUser { get; set; }

        /// <summary>
        /// Whether the user is an Official Discord System user (part of the urgent message system)
        /// Required OAuth2 Scope: identify
        /// </summary>
        [JsonPropertyName("system")]
        public bool? IsSystemUser { get; set; }

        /// <summary>
        /// Whether the user has two factor enabled on their account
        /// Required OAuth2 Scope: identify
        /// </summary>
        [JsonPropertyName("mfa_enabled")]
        public bool? IsMfaEnabled { get; set; }

        /// <summary>
        /// The user's banner hash
        /// Required OAuth2 Scope: identify
        /// </summary>
        [JsonPropertyName("banner")]
        public string? BannerHash { get; set; }

        /// <summary>
        /// The user's banner color encoded as an integer representation of hexadecimal color code
        /// Required OAuth2 Scope: identify
        /// </summary>
        [JsonPropertyName("accent_color")]
        public int? AccentColor { get; set; }

        /// <summary>
        /// The user's chosen language option
        /// Required OAuth2 Scope: identify
        /// </summary>
        [JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// Whether the email on this account has been verified
        /// Required OAuth2 Scope: email
        /// </summary>
        [JsonPropertyName("verified")]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// The user's email
        /// Required OAuth2 Scope: email
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The flags on a user's account
        /// Required OAuth2 Scope: identify
        /// </summary>
        [JsonPropertyName("flags")]
        public UserFlags? Flags { get; set; }

        /// <summary>
        /// The type of Nitro subscription on a user's account
        /// Required OAuth2 Scope: identify
        /// </summary>
        [JsonPropertyName("premium_type")]
        public PremiumType? PremiumType { get; set; }

        /// <summary>
        /// The public flags on a user's account
        /// Required OAuth2 Scope: identify
        /// </summary>
        [JsonPropertyName("public_flags")]
        public UserFlags? PublicFlags { get; set; }

        /// <summary>
        /// Data for the user's avatar decoration
        /// Required OAuth2 Scope: identify
        /// </summary>
        [JsonPropertyName("avatar_decoration_data")]
        public AvatarDecorationData? AvatarDecorationData { get; set; }
    }
}
