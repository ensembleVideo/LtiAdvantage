using Newtonsoft.Json;

namespace LtiAdvantage.DynamicRegistration
{
    /// <summary>
    /// Platform OpenID configuration.
    /// </summary>
    public class PlatformConfiguration
    {
        /// <summary>
        /// Platform's issuer value.
        /// </summary>
        [JsonProperty("issuer", Required = Required.Always)]
        public string Issuer { get; set; }

        /// <summary>
        /// URL of the OAuth 2.0 Authorization Endpoint.
        /// </summary>
        [JsonProperty("authorization_endpoint", Required = Required.Always)]
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// URL of the registration endpoint.
        /// </summary>
        [JsonProperty("registration_endpoint", Required = Required.Always)]
        public string RegistrationEndpoint { get; set; }

        /// <summary>
        /// URL of the platform JWK set endpoint.
        /// </summary>
        [JsonProperty("jwks_uri", Required = Required.Always)]
        public string JwksUri { get; set; }

        /// <summary>
        /// URL for access token requests from tool.
        /// </summary>
        [JsonProperty("token_endpoint", Required = Required.Always)]
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// Supported token endpoint authorization methods.
        /// </summary>
        [JsonProperty("token_endpoint_auth_methods_supported", Required = Required.Always)]
        public string[] TokenEndpointAuthMethodsSupported { get; set; }

        /// <summary>
        /// Supported token endpoint signature algorithms.
        /// </summary>
        [JsonProperty("token_endpoint_auth_signing_alg_values_supported", Required = Required.Always)]
        public string[] TokenEndpointAuthSigningAlgValuesSupported { get; set; }

        /// <summary>
        /// Required OpenID and supported LTI service scopes.
        /// </summary>
        [JsonProperty("scopes_supported", Required = Required.Always)]
        public string[] ScopesSupported { get; set; }

        /// <summary>
        /// Supported token response types.
        /// </summary>
        [JsonProperty("response_types_supported", Required = Required.Always)]
        public string[] ResponseTypesSupported { get; set; }

        /// <summary>
        /// Supported id_token signature algorithms.
        /// </summary>
        [JsonProperty("id_token_signing_alg_values_supported", Required = Required.Always)]
        public string[] IdTokenSigningAlgValuesSupported { get; set; }

        /// <summary>
        /// OpenID claims supported by the platform.
        /// </summary>
        [JsonProperty("claims_supported", Required = Required.Always)]
        public string[] ClaimsSupported { get; set; }

        /// <summary>
        /// Optional authorization server identifier to be used as the aud when requesting an access token. Defaults to value set in <see cref="TokenEndpoint"/>.
        /// </summary>
        [JsonProperty("authorization_server")]
        public string AuthorizationServer { get; set; }

        /// <summary>
        /// LTI-specific platform configuration details.
        /// </summary>
        [JsonProperty("https://purl.imsglobal.org/spec/lti-platform-configuration", Required = Required.Always)]
        public LtiPlatformConfiguration LtiPlatformConfiguration { get; set; }
    }
}
