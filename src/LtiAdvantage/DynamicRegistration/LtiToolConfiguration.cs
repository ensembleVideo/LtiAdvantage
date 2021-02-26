using Newtonsoft.Json;

namespace LtiAdvantage.DynamicRegistration
{
    /// <summary>
    /// LTI-specific tool configuration details.
    /// </summary>
    public class LtiToolConfiguration
    {
        /// <summary>
        /// Primary tool domain.
        /// </summary>
        [JsonProperty("domain", Required = Required.Always)]
        public string Domain { get; set; }

        /// <summary>
        /// Optional array of secondary tool domains.
        /// </summary>
        [JsonProperty("secondary_domains")]
        public string[] SecondaryDomains { get; set; }

        /// <summary>
        /// Optional LTI deployment_id associated with this client registration's deployment.
        /// </summary>
        [JsonProperty("deployment_id")]
        public string DeploymentId { get; set; }

        /// <summary>
        /// Default target link uri.
        /// </summary>
        [JsonProperty("target_link_uri", Required = Required.Always)]
        public string TargetLinkUri { get; set; }

        /// <summary>
        /// Optional JSON object representing tool's custom parameters.
        /// </summary>
        [JsonProperty("custom_parameters")]
        public object CustomParameters { get; set; }

        /// <summary>
        /// Optional tool description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Array of LTI message types supported by the tool.
        /// </summary>
        [JsonProperty("messages", Required = Required.Always)]
        public ToolSupportedMessage[] Messages { get; set; }

        /// <summary>
        /// Array of claims desired by tool to be included in id token.
        /// </summary>
        [JsonProperty("claims", Required = Required.Always)]
        public string[] Claims { get; set; }
    }
}
