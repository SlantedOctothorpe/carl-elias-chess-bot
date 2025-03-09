namespace CarlElias.Common.Enums.Discord
{
    public enum ChannelType
    {
        /// <summary>
        /// A text channel within a server
        /// </summary>
        GuildTextChannel = 0,

        /// <summary>
        /// A direct message between two users
        /// </summary>
        DMChannel = 1,

        /// <summary>
        /// A voice channel within a server
        /// </summary>
        GuildVoiceChannel = 2,

        /// <summary>
        /// A direct message between multiple users
        /// </summary>
        GroupDMChannel = 3,

        /// <summary>
        /// An organizational category that contains up to 50 channels
        /// </summary>
        GuildCategoryChannel = 4,

        /// <summary>
        /// A channel that users can follow and crosspost into their own guild (formerly news channels)
        /// </summary>
        GuildAnnouncementChannel = 5,

        /// <summary>
        /// A temporary sub-channel within an <see cref="GuildAnnouncementChannel"/> channel
        /// </summary>
        GuildAnnouncementThread = 10,

        /// <summary>
        /// A temporary sub-channel within a <see cref="GuildTextChannel"/> or <see cref="GuildForumChannel"/> channel
        /// </summary>
        GuildPublicThread = 11,

        /// <summary>
        /// A temporary sub-channel within a <see cref="GuildTextChannel"/> channel that is only viewable by those invited and those with the <see cref="Permissions.ManageThreads"/> permission
        /// </summary>
        GuildPrivateThread = 12,

        /// <summary>
        /// A voice channel for hosting events with an audience
        /// </summary>
        GuildStageChannel = 13,

        /// <summary>
        /// The channel in a hub containing the listed guilds
        /// </summary>
        GuildDirectoryChannel = 14,

        /// <summary>
        /// A channel that can only contain threads
        /// </summary>
        GuildForumChannel = 15,

        /// <summary>
        /// A channel that can only contain threads, similar to a <see cref="GuildForumChannel"/> channel
        /// </summary>
        GuildMediaChannel = 16
    }
}
