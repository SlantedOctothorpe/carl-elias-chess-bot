namespace CarlElias.Common.Enums.Discord
{
    [Flags]
    public enum ChannelFlags
    {
        /// <summary>
        /// This thread is pinned to the top of its parent <see cref="ChannelType.GuildForumChannel"/> or <see cref="ChannelType.GuildMediaChannel"/> channel
        /// </summary>
        Pinned = 1 << 1,

        /// <summary>
        /// Whether a tag is required to be specified when creating a thread in a <see cref="ChannelType.GuildForumChannel"/> or <see cref="ChannelType.GuildMediaChannel"/> channel. Tags are specified in the <see cref="Channel.AppliedTags"/> field
        /// </summary>
        RequireTag = 1 << 4,

        /// <summary>
        /// When set hides the embedded media download options. Available only for <see cref="ChannelType.GuildMediaChannel"/> channels
        /// </summary>
        HideMediaDownloadOptions = 1 << 15
    }
}
