using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authentication_certificate in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationGatewayAuthenticationCertificateBlock() : TerraformBlock("authentication_certificate")
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Data is required")]
    [TerraformProperty("data")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Data { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for autoscale_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationGatewayAutoscaleConfigurationBlock() : TerraformBlock("autoscale_configuration")
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformProperty("max_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    [TerraformProperty("min_capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MinCapacity { get; set; }

}

/// <summary>
/// Block type for backend_address_pool in .
/// Nesting mode: set
/// </summary>
public partial class AzurermApplicationGatewayBackendAddressPoolBlock() : TerraformBlock("backend_address_pool")
{
    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    [TerraformProperty("fqdns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Fqdns { get; set; }


    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    [TerraformProperty("ip_addresses")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IpAddresses { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for backend_http_settings in .
/// Nesting mode: set
/// </summary>
public partial class AzurermApplicationGatewayBackendHttpSettingsBlock() : TerraformBlock("backend_http_settings")
{
    /// <summary>
    /// The affinity_cookie_name attribute.
    /// </summary>
    [TerraformProperty("affinity_cookie_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AffinityCookieName { get; set; }

    /// <summary>
    /// The cookie_based_affinity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookieBasedAffinity is required")]
    [TerraformProperty("cookie_based_affinity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CookieBasedAffinity { get; set; }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformProperty("host_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostName { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The pick_host_name_from_backend_address attribute.
    /// </summary>
    [TerraformProperty("pick_host_name_from_backend_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PickHostNameFromBackendAddress { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformProperty("port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Port { get; set; }


    /// <summary>
    /// The probe_name attribute.
    /// </summary>
    [TerraformProperty("probe_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProbeName { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The request_timeout attribute.
    /// </summary>
    [TerraformProperty("request_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RequestTimeout { get; set; }

    /// <summary>
    /// The trusted_root_certificate_names attribute.
    /// </summary>
    [TerraformProperty("trusted_root_certificate_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? TrustedRootCertificateNames { get; set; }

}

/// <summary>
/// Block type for custom_error_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationGatewayCustomErrorConfigurationBlock() : TerraformBlock("custom_error_configuration")
{
    /// <summary>
    /// The custom_error_page_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomErrorPageUrl is required")]
    [TerraformProperty("custom_error_page_url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CustomErrorPageUrl { get; set; }


    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    [TerraformProperty("status_code")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StatusCode { get; set; }

}

/// <summary>
/// Block type for frontend_ip_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationGatewayFrontendIpConfigurationBlock() : TerraformBlock("frontend_ip_configuration")
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformProperty("private_ip_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PrivateIpAddress { get; set; }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    [TerraformProperty("private_ip_address_allocation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateIpAddressAllocation { get; set; }


    /// <summary>
    /// The private_link_configuration_name attribute.
    /// </summary>
    [TerraformProperty("private_link_configuration_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateLinkConfigurationName { get; set; }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformProperty("public_ip_address_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicIpAddressId { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetId { get; set; }

}

/// <summary>
/// Block type for frontend_port in .
/// Nesting mode: set
/// </summary>
public partial class AzurermApplicationGatewayFrontendPortBlock() : TerraformBlock("frontend_port")
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformProperty("port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Port { get; set; }

}

/// <summary>
/// Block type for gateway_ip_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationGatewayGatewayIpConfigurationBlock() : TerraformBlock("gateway_ip_configuration")
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for global in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationGatewayGlobalBlock() : TerraformBlock("global")
{
    /// <summary>
    /// The request_buffering_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestBufferingEnabled is required")]
    [TerraformProperty("request_buffering_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> RequestBufferingEnabled { get; set; }

    /// <summary>
    /// The response_buffering_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseBufferingEnabled is required")]
    [TerraformProperty("response_buffering_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> ResponseBufferingEnabled { get; set; }

}

/// <summary>
/// Block type for http_listener in .
/// Nesting mode: set
/// </summary>
public partial class AzurermApplicationGatewayHttpListenerBlock() : TerraformBlock("http_listener")
{
    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformProperty("firewall_policy_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FirewallPolicyId { get; set; }


    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    [TerraformProperty("frontend_ip_configuration_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FrontendIpConfigurationName { get; set; }


    /// <summary>
    /// The frontend_port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPortName is required")]
    [TerraformProperty("frontend_port_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FrontendPortName { get; set; }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformProperty("host_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostName { get; set; }

    /// <summary>
    /// The host_names attribute.
    /// </summary>
    [TerraformProperty("host_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? HostNames { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The require_sni attribute.
    /// </summary>
    [TerraformProperty("require_sni")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequireSni { get; set; }


    /// <summary>
    /// The ssl_certificate_name attribute.
    /// </summary>
    [TerraformProperty("ssl_certificate_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslCertificateName { get; set; }


    /// <summary>
    /// The ssl_profile_name attribute.
    /// </summary>
    [TerraformProperty("ssl_profile_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslProfileName { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationGatewayIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for private_link_configuration in .
/// Nesting mode: set
/// </summary>
public partial class AzurermApplicationGatewayPrivateLinkConfigurationBlock() : TerraformBlock("private_link_configuration")
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for probe in .
/// Nesting mode: set
/// </summary>
public partial class AzurermApplicationGatewayProbeBlock() : TerraformBlock("probe")
{
    /// <summary>
    /// The host attribute.
    /// </summary>
    [TerraformProperty("host")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Host { get; set; }


    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformProperty("interval")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Interval { get; set; }

    /// <summary>
    /// The minimum_servers attribute.
    /// </summary>
    [TerraformProperty("minimum_servers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinimumServers { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The pick_host_name_from_backend_http_settings attribute.
    /// </summary>
    [TerraformProperty("pick_host_name_from_backend_http_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PickHostNameFromBackendHttpSettings { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    [TerraformProperty("timeout")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Timeout { get; set; }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnhealthyThreshold is required")]
    [TerraformProperty("unhealthy_threshold")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> UnhealthyThreshold { get; set; }

}

/// <summary>
/// Block type for redirect_configuration in .
/// Nesting mode: set
/// </summary>
public partial class AzurermApplicationGatewayRedirectConfigurationBlock() : TerraformBlock("redirect_configuration")
{

    /// <summary>
    /// The include_path attribute.
    /// </summary>
    [TerraformProperty("include_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludePath { get; set; }

    /// <summary>
    /// The include_query_string attribute.
    /// </summary>
    [TerraformProperty("include_query_string")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeQueryString { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The redirect_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectType is required")]
    [TerraformProperty("redirect_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RedirectType { get; set; }


    /// <summary>
    /// The target_listener_name attribute.
    /// </summary>
    [TerraformProperty("target_listener_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetListenerName { get; set; }

    /// <summary>
    /// The target_url attribute.
    /// </summary>
    [TerraformProperty("target_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetUrl { get; set; }

}

/// <summary>
/// Block type for request_routing_rule in .
/// Nesting mode: set
/// </summary>
public partial class AzurermApplicationGatewayRequestRoutingRuleBlock() : TerraformBlock("request_routing_rule")
{

    /// <summary>
    /// The backend_address_pool_name attribute.
    /// </summary>
    [TerraformProperty("backend_address_pool_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BackendAddressPoolName { get; set; }


    /// <summary>
    /// The backend_http_settings_name attribute.
    /// </summary>
    [TerraformProperty("backend_http_settings_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BackendHttpSettingsName { get; set; }


    /// <summary>
    /// The http_listener_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpListenerName is required")]
    [TerraformProperty("http_listener_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HttpListenerName { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Priority { get; set; }


    /// <summary>
    /// The redirect_configuration_name attribute.
    /// </summary>
    [TerraformProperty("redirect_configuration_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RedirectConfigurationName { get; set; }


    /// <summary>
    /// The rewrite_rule_set_name attribute.
    /// </summary>
    [TerraformProperty("rewrite_rule_set_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RewriteRuleSetName { get; set; }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    [TerraformProperty("rule_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RuleType { get; set; }


    /// <summary>
    /// The url_path_map_name attribute.
    /// </summary>
    [TerraformProperty("url_path_map_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UrlPathMapName { get; set; }

}

/// <summary>
/// Block type for rewrite_rule_set in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationGatewayRewriteRuleSetBlock() : TerraformBlock("rewrite_rule_set")
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationGatewaySkuBlock() : TerraformBlock("sku")
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformProperty("capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Capacity { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformProperty("tier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Tier { get; set; }

}

/// <summary>
/// Block type for ssl_certificate in .
/// Nesting mode: set
/// </summary>
public partial class AzurermApplicationGatewaySslCertificateBlock() : TerraformBlock("ssl_certificate")
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    [TerraformProperty("data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Data { get; set; }


    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_secret_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }


}

/// <summary>
/// Block type for ssl_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationGatewaySslPolicyBlock() : TerraformBlock("ssl_policy")
{
    /// <summary>
    /// The cipher_suites attribute.
    /// </summary>
    [TerraformProperty("cipher_suites")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? CipherSuites { get; set; }

    /// <summary>
    /// The disabled_protocols attribute.
    /// </summary>
    [TerraformProperty("disabled_protocols")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DisabledProtocols { get; set; }

    /// <summary>
    /// The min_protocol_version attribute.
    /// </summary>
    [TerraformProperty("min_protocol_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MinProtocolVersion { get; set; }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    [TerraformProperty("policy_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PolicyName { get; set; }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformProperty("policy_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PolicyType { get; set; }

}

/// <summary>
/// Block type for ssl_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationGatewaySslProfileBlock() : TerraformBlock("ssl_profile")
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The trusted_client_certificate_names attribute.
    /// </summary>
    [TerraformProperty("trusted_client_certificate_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? TrustedClientCertificateNames { get; set; }

    /// <summary>
    /// The verify_client_cert_issuer_dn attribute.
    /// </summary>
    [TerraformProperty("verify_client_cert_issuer_dn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VerifyClientCertIssuerDn { get; set; }

    /// <summary>
    /// The verify_client_certificate_revocation attribute.
    /// </summary>
    [TerraformProperty("verify_client_certificate_revocation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VerifyClientCertificateRevocation { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApplicationGatewayTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for trusted_client_certificate in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationGatewayTrustedClientCertificateBlock() : TerraformBlock("trusted_client_certificate")
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Data is required")]
    [TerraformProperty("data")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Data { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for trusted_root_certificate in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationGatewayTrustedRootCertificateBlock() : TerraformBlock("trusted_root_certificate")
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    [TerraformProperty("data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Data { get; set; }


    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_secret_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for url_path_map in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationGatewayUrlPathMapBlock() : TerraformBlock("url_path_map")
{

    /// <summary>
    /// The default_backend_address_pool_name attribute.
    /// </summary>
    [TerraformProperty("default_backend_address_pool_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultBackendAddressPoolName { get; set; }


    /// <summary>
    /// The default_backend_http_settings_name attribute.
    /// </summary>
    [TerraformProperty("default_backend_http_settings_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultBackendHttpSettingsName { get; set; }


    /// <summary>
    /// The default_redirect_configuration_name attribute.
    /// </summary>
    [TerraformProperty("default_redirect_configuration_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultRedirectConfigurationName { get; set; }


    /// <summary>
    /// The default_rewrite_rule_set_name attribute.
    /// </summary>
    [TerraformProperty("default_rewrite_rule_set_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultRewriteRuleSetName { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for waf_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationGatewayWafConfigurationBlock() : TerraformBlock("waf_configuration")
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The file_upload_limit_mb attribute.
    /// </summary>
    [TerraformProperty("file_upload_limit_mb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FileUploadLimitMb { get; set; }

    /// <summary>
    /// The firewall_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallMode is required")]
    [TerraformProperty("firewall_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FirewallMode { get; set; }

    /// <summary>
    /// The max_request_body_size_kb attribute.
    /// </summary>
    [TerraformProperty("max_request_body_size_kb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxRequestBodySizeKb { get; set; }

    /// <summary>
    /// The request_body_check attribute.
    /// </summary>
    [TerraformProperty("request_body_check")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequestBodyCheck { get; set; }

    /// <summary>
    /// The rule_set_type attribute.
    /// </summary>
    [TerraformProperty("rule_set_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RuleSetType { get; set; }

    /// <summary>
    /// The rule_set_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleSetVersion is required")]
    [TerraformProperty("rule_set_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RuleSetVersion { get; set; }

}

/// <summary>
/// Manages a azurerm_application_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermApplicationGateway : TerraformResource
{
    public AzurermApplicationGateway(string name) : base("azurerm_application_gateway", name)
    {
    }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    [TerraformProperty("enable_http2")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableHttp2 { get; set; }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformProperty("fips_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FipsEnabled { get; set; }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformProperty("firewall_policy_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FirewallPolicyId { get; set; }

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    [TerraformProperty("force_firewall_policy_association")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceFirewallPolicyAssociation { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for authentication_certificate.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("authentication_certificate")]
    public TerraformList<AzurermApplicationGatewayAuthenticationCertificateBlock> AuthenticationCertificate { get; set; } = new();

    /// <summary>
    /// Block for autoscale_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleConfiguration block(s) allowed")]
    [TerraformProperty("autoscale_configuration")]
    public TerraformList<AzurermApplicationGatewayAutoscaleConfigurationBlock> AutoscaleConfiguration { get; set; } = new();

    /// <summary>
    /// Block for backend_address_pool.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendAddressPool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendAddressPool block(s) required")]
    [TerraformProperty("backend_address_pool")]
    public required TerraformSet<AzurermApplicationGatewayBackendAddressPoolBlock> BackendAddressPool { get; set; } = new();

    /// <summary>
    /// Block for backend_http_settings.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendHttpSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendHttpSettings block(s) required")]
    [TerraformProperty("backend_http_settings")]
    public required TerraformSet<AzurermApplicationGatewayBackendHttpSettingsBlock> BackendHttpSettings { get; set; } = new();

    /// <summary>
    /// Block for custom_error_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("custom_error_configuration")]
    public TerraformList<AzurermApplicationGatewayCustomErrorConfigurationBlock> CustomErrorConfiguration { get; set; } = new();

    /// <summary>
    /// Block for frontend_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendIpConfiguration block(s) required")]
    [TerraformProperty("frontend_ip_configuration")]
    public required TerraformList<AzurermApplicationGatewayFrontendIpConfigurationBlock> FrontendIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for frontend_port.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendPort block(s) required")]
    [TerraformProperty("frontend_port")]
    public required TerraformSet<AzurermApplicationGatewayFrontendPortBlock> FrontendPort { get; set; } = new();

    /// <summary>
    /// Block for gateway_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayIpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GatewayIpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 GatewayIpConfiguration block(s) allowed")]
    [TerraformProperty("gateway_ip_configuration")]
    public required TerraformList<AzurermApplicationGatewayGatewayIpConfigurationBlock> GatewayIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for global.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Global block(s) allowed")]
    [TerraformProperty("global")]
    public TerraformList<AzurermApplicationGatewayGlobalBlock> Global { get; set; } = new();

    /// <summary>
    /// Block for http_listener.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpListener is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HttpListener block(s) required")]
    [TerraformProperty("http_listener")]
    public required TerraformSet<AzurermApplicationGatewayHttpListenerBlock> HttpListener { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermApplicationGatewayIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for private_link_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("private_link_configuration")]
    public TerraformSet<AzurermApplicationGatewayPrivateLinkConfigurationBlock> PrivateLinkConfiguration { get; set; } = new();

    /// <summary>
    /// Block for probe.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("probe")]
    public TerraformSet<AzurermApplicationGatewayProbeBlock> Probe { get; set; } = new();

    /// <summary>
    /// Block for redirect_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("redirect_configuration")]
    public TerraformSet<AzurermApplicationGatewayRedirectConfigurationBlock> RedirectConfiguration { get; set; } = new();

    /// <summary>
    /// Block for request_routing_rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestRoutingRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RequestRoutingRule block(s) required")]
    [TerraformProperty("request_routing_rule")]
    public required TerraformSet<AzurermApplicationGatewayRequestRoutingRuleBlock> RequestRoutingRule { get; set; } = new();

    /// <summary>
    /// Block for rewrite_rule_set.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("rewrite_rule_set")]
    public TerraformList<AzurermApplicationGatewayRewriteRuleSetBlock> RewriteRuleSet { get; set; } = new();

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformProperty("sku")]
    public required TerraformList<AzurermApplicationGatewaySkuBlock> Sku { get; set; } = new();

    /// <summary>
    /// Block for ssl_certificate.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ssl_certificate")]
    public TerraformSet<AzurermApplicationGatewaySslCertificateBlock> SslCertificate { get; set; } = new();

    /// <summary>
    /// Block for ssl_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslPolicy block(s) allowed")]
    [TerraformProperty("ssl_policy")]
    public TerraformList<AzurermApplicationGatewaySslPolicyBlock> SslPolicy { get; set; } = new();

    /// <summary>
    /// Block for ssl_profile.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("ssl_profile")]
    public TerraformList<AzurermApplicationGatewaySslProfileBlock> SslProfile { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermApplicationGatewayTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for trusted_client_certificate.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("trusted_client_certificate")]
    public TerraformList<AzurermApplicationGatewayTrustedClientCertificateBlock> TrustedClientCertificate { get; set; } = new();

    /// <summary>
    /// Block for trusted_root_certificate.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("trusted_root_certificate")]
    public TerraformList<AzurermApplicationGatewayTrustedRootCertificateBlock> TrustedRootCertificate { get; set; } = new();

    /// <summary>
    /// Block for url_path_map.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("url_path_map")]
    public TerraformList<AzurermApplicationGatewayUrlPathMapBlock> UrlPathMap { get; set; } = new();

    /// <summary>
    /// Block for waf_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WafConfiguration block(s) allowed")]
    [TerraformProperty("waf_configuration")]
    public TerraformList<AzurermApplicationGatewayWafConfigurationBlock> WafConfiguration { get; set; } = new();

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    [TerraformProperty("private_endpoint_connection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> PrivateEndpointConnection { get; }

}
