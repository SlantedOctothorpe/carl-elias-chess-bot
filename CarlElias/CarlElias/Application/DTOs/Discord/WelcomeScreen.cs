using System.Text.Json.Serialization;

namespace CarlElias.Application.DTOs.Discord
{
    public class WelcomeScreen
    {
        /// <summary>
        /// The server description shown in the welcome screen
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The channels shown in the welcome screen, up to 5
        /// </summary>
        [JsonPropertyName("welcome_channels")]
        public WelcomeScreenChannel[] WelcomeChannels { get; set; }
    }
}
