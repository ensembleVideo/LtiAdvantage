using Newtonsoft.Json;

namespace LtiAdvantage.DynamicRegistration
{
    /// <summary>
    /// LTI-specific platform configuration details.
    /// </summary>
    public class LtiPlatformConfiguration
    {
        /// <summary>
        /// Product identifier for the platform.
        /// </summary>
        [JsonProperty("product_family_code", Required = Required.Always)]
        public string ProductFamilyCode { get; set; }

        /// <summary>
        /// Version of the software running the platform.
        /// </summary>
        [JsonProperty("version", Required = Required.Always)]
        public string Version { get; set; }

        //// TODO - Moodle and the spec differ here! The following matches the spec where message has type and placement properties.
        ///// <summary>
        ///// Array of LTI message types supported by the platform.
        ///// </summary>
        //[JsonProperty("messages_supported", Required = Required.Always)]
        //public PlatformSupportedMessage[] MessagesSupported { get; set; }

        // TODO - Moodle impl
        /// <summary>
        /// Array of LTI message types supported by the platform.
        /// </summary>
        [JsonProperty("messages_supported", Required = Required.Always)]
        public string[] MessagesSupported { get; set; }

        // TODO - Moodle impl
        /// <summary>
        /// Optional array of placements where platform supports this message type.
        /// </summary>
        [JsonProperty("placements")]
        public string[] Placements { get; set; }

        /// <summary>
        /// Optional array of supported substitution parameters.
        /// </summary>
        [JsonProperty("variables")]
        public string[] Variables { get; set; }
    }
}
