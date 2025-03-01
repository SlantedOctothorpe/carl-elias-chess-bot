namespace CarlElias.Common.Enums.Discord
{
    [Flags]
    public enum SystemChannelFlags
    {
        /// <summary>
        /// Suppress member join notifications
        /// </summary>
        SuppressJoinNotifications = 1 << 0,

        /// <summary>
        /// Suppress server boost notifications
        /// </summary>
        SuppressPremiumSubscriptions = 1 << 1,

        /// <summary>
        /// Suppress server setup tips
        /// </summary>
        SuppressGuildReminderNotifications = 1 << 2,

        /// <summary>
        /// Hide member join sticker reply buttons
        /// </summary>
        SupressJoinNotificationReplies = 1 << 3,

        /// <summary>
        /// Suppress role subscription purchase and renewal notifications
        /// </summary>
        SupressRoleSubscriptionPurchaseNotifications = 1 << 4,

        /// <summary>
        /// Hide role subscription sticker reply buttons
        /// </summary>
        SupressRoleSubscriptionPurchaseNotificationReplies = 1 << 5
    }
}
