namespace CarlElias.Common.Enums.Discord
{
    public enum DefaultMessageNotificationLevel
    {
        /// <summary>
        /// Members will receive notifications for all messages by default
        /// </summary>
        AllMessages = 0,

        /// <summary>
        /// Members will receive notifications only for messages that <see langword="@mention"/> them by default
        /// </summary>
        OnlyMentions = 1
    }
}
