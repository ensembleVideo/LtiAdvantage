using Newtonsoft.Json;

namespace LtiAdvantage.DynamicRegistration
{
    /// <summary>
    /// Tool OpenID configuration.
    /// </summary>
    public class ToolConfiguration
    {
        /// <summary>
        /// Tool's client identifier. Only available in tool configuration provided by platform after successful registration.
        /// </summary>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional platform client registration url. Only available in tool configuration provided by platform
        /// after successful registration. Used for configuration retrieval and potential modification.
        /// </summary>
        [JsonProperty("registration_client_uri")]
        public string RegistrationClientUri { get; set; }

        /// <summary>
        /// The application type.
        /// </summary>
        [JsonProperty("application_type", Required = Required.Always)]
        public string ApplicationType => "web";

        /// <summary>
        /// Required OpenID connect grant types.
        /// </summary>
        [JsonProperty("grant_types", Required = Required.Always)]
        public string[] GrantTypes { get; } = { "client_credentials", "implicit" };

        /// <summary>
        /// Accepted token response types.
        /// </summary>
        [JsonProperty("response_types", Required = Required.Always)]
        public string[] ResponseTypes { get; set; } = { "id_token" };

        /// <summary>
        /// Tool redirect uris.
        /// </summary>
        [JsonProperty("redirect_uris", Required = Required.Always)]
        public string[] RedirectUris { get; set; }

        /// <summary>
        /// URI used by the platform to initiate the LTI launch.
        /// </summary>
        [JsonProperty("initiate_login_uri", Required = Required.Always)]
        public string InitiateLoginUri { get; set; }

        /// <summary>
        /// Tool name.
        /// </summary>
        [JsonProperty("client_name", Required = Required.Always)]
        public string ClientName { get; set; }

        /// <summary>
        /// URL of the tool JWK set endpoint.
        /// </summary>
        [JsonProperty("jwks_uri", Required = Required.Always)]
        public string JwksUri { get; set; }

        /// <summary>
        /// Optional tool logo URL.
        /// </summary>
        [JsonProperty("logo_uri")]
        public string LogoUri { get; set; }

        /// <summary>
        /// Tool token endpoint authentication method.
        /// </summary>
        [JsonProperty("token_endpoint_auth_method", Required = Required.Always)]
        public string TokenEndpointAuthMethod => "private_key_jwt";

        /// <summary>
        /// Optional array of tool contacts.
        /// </summary>
        [JsonProperty("contacts")]
        public string[] Contacts { get; set; }

        /// <summary>
        /// Optional url of valid web page containing tool information.
        /// </summary>
        [JsonProperty("client_uri")]
        public string ClientUri { get; set; }

        /// <summary>
        /// Optional url of valid web page containing tool's terms of service.
        /// </summary>
        [JsonProperty("tos_uri")]
        public string TosUri { get; set; }

        /// <summary>
        /// Optional url of valid web page containing policy regarding profile data usage.
        /// </summary>
        [JsonProperty("policy_uri")]
        public string PolicyUri { get; set; }

        /// <summary>
        /// Space-separated list of scope values the tool requests access to.
        /// </summary>
        [JsonProperty("scope", Required = Required.Always)]
        public string Scope { get; set; }

        /// <summary>
        /// LTI-specific tool configuration details.
        /// </summary>
        [JsonProperty("https://purl.imsglobal.org/spec/lti-tool-configuration", Required = Required.Always)]
        public LtiToolConfiguration LtiToolConfiguration { get; set; }
    }
}
