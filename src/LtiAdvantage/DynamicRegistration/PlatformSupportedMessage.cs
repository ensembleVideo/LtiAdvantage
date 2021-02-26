using Newtonsoft.Json;

namespace LtiAdvantage.DynamicRegistration
{
    /// <summary>
    /// Represents a supported LTI message type.
    /// </summary>
    public class PlatformSupportedMessage
    {
        /// <summary>
        /// The message type.
        /// </summary>
        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; set; }

        /// <summary>
        /// Optional array of placements where platform supports this message type.
        /// </summary>
        [JsonProperty("placements")]
        public string[] Placements { get; set; }
    }
}
