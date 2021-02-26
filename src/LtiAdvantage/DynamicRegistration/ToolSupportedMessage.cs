using Newtonsoft.Json;

namespace LtiAdvantage.DynamicRegistration
{
    /// <summary>
    /// Represents an LTI message type supported by a tool.
    /// </summary>
    public class ToolSupportedMessage
    {
        /// <summary>
        /// The message type.
        /// </summary>
        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; set; }

        /// <summary>
        /// Optional target link uri for this message type if different than tool default.
        /// </summary>
        [JsonProperty("target_link_uri")]
        public string TargetLinkUri { get; set; }

        /// <summary>
        /// Optional label platform may apply to target link.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// Optional icon platform may apply to target link.
        /// </summary>
        [JsonProperty("icon_uri")]
        public string IconUri { get; set; }

        /// <summary>
        /// Optional JSON object representing message-specific custom parameters. Overrides custom parameters defined at tool-level.
        /// </summary>
        [JsonProperty("custom_parameters")]
        public object CustomParameters { get; set; }

        /// <summary>
        /// Optional array of placements where platform should add links for this tool.
        /// </summary>
        [JsonProperty("placements")]
        public string[] Placements { get; set; }
    }
}
