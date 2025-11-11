using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authentication_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayAuthenticationCertificateBlock
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Data is required")]
    [TerraformPropertyName("data")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Data { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for autoscale_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayAutoscaleConfigurationBlock
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformPropertyName("max_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    [TerraformPropertyName("min_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MinCapacity { get; set; }

}

/// <summary>
/// Block type for backend_address_pool in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayBackendAddressPoolBlock
{
    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    [TerraformPropertyName("fqdns")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Fqdns { get; set; }


    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("ip_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IpAddresses { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for backend_http_settings in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayBackendHttpSettingsBlock
{
    /// <summary>
    /// The affinity_cookie_name attribute.
    /// </summary>
    [TerraformPropertyName("affinity_cookie_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AffinityCookieName { get; set; }

    /// <summary>
    /// The cookie_based_affinity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookieBasedAffinity is required")]
    [TerraformPropertyName("cookie_based_affinity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CookieBasedAffinity { get; set; }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformPropertyName("host_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HostName { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The pick_host_name_from_backend_address attribute.
    /// </summary>
    [TerraformPropertyName("pick_host_name_from_backend_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PickHostNameFromBackendAddress { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformPropertyName("port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Port { get; set; }


    /// <summary>
    /// The probe_name attribute.
    /// </summary>
    [TerraformPropertyName("probe_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProbeName { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The request_timeout attribute.
    /// </summary>
    [TerraformPropertyName("request_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RequestTimeout { get; set; }

    /// <summary>
    /// The trusted_root_certificate_names attribute.
    /// </summary>
    [TerraformPropertyName("trusted_root_certificate_names")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? TrustedRootCertificateNames { get; set; }

}

/// <summary>
/// Block type for custom_error_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayCustomErrorConfigurationBlock
{
    /// <summary>
    /// The custom_error_page_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomErrorPageUrl is required")]
    [TerraformPropertyName("custom_error_page_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CustomErrorPageUrl { get; set; }


    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    [TerraformPropertyName("status_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StatusCode { get; set; }

}

/// <summary>
/// Block type for frontend_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayFrontendIpConfigurationBlock
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PrivateIpAddress { get; set; } = default!;

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address_allocation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateIpAddressAllocation { get; set; }


    /// <summary>
    /// The private_link_configuration_name attribute.
    /// </summary>
    [TerraformPropertyName("private_link_configuration_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateLinkConfigurationName { get; set; }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_address_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PublicIpAddressId { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubnetId { get; set; }

}

/// <summary>
/// Block type for frontend_port in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayFrontendPortBlock
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformPropertyName("port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Port { get; set; }

}

/// <summary>
/// Block type for gateway_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayGatewayIpConfigurationBlock
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for global in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayGlobalBlock
{
    /// <summary>
    /// The request_buffering_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestBufferingEnabled is required")]
    [TerraformPropertyName("request_buffering_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> RequestBufferingEnabled { get; set; }

    /// <summary>
    /// The response_buffering_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseBufferingEnabled is required")]
    [TerraformPropertyName("response_buffering_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> ResponseBufferingEnabled { get; set; }

}

/// <summary>
/// Block type for http_listener in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayHttpListenerBlock
{
    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("firewall_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FirewallPolicyId { get; set; }


    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    [TerraformPropertyName("frontend_ip_configuration_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FrontendIpConfigurationName { get; set; }


    /// <summary>
    /// The frontend_port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPortName is required")]
    [TerraformPropertyName("frontend_port_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FrontendPortName { get; set; }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformPropertyName("host_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HostName { get; set; }

    /// <summary>
    /// The host_names attribute.
    /// </summary>
    [TerraformPropertyName("host_names")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? HostNames { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The require_sni attribute.
    /// </summary>
    [TerraformPropertyName("require_sni")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequireSni { get; set; }


    /// <summary>
    /// The ssl_certificate_name attribute.
    /// </summary>
    [TerraformPropertyName("ssl_certificate_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslCertificateName { get; set; }


    /// <summary>
    /// The ssl_profile_name attribute.
    /// </summary>
    [TerraformPropertyName("ssl_profile_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslProfileName { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for private_link_configuration in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayPrivateLinkConfigurationBlock
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for probe in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayProbeBlock
{
    /// <summary>
    /// The host attribute.
    /// </summary>
    [TerraformPropertyName("host")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Host { get; set; }


    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformPropertyName("interval")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Interval { get; set; }

    /// <summary>
    /// The minimum_servers attribute.
    /// </summary>
    [TerraformPropertyName("minimum_servers")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinimumServers { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformPropertyName("path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The pick_host_name_from_backend_http_settings attribute.
    /// </summary>
    [TerraformPropertyName("pick_host_name_from_backend_http_settings")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PickHostNameFromBackendHttpSettings { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    [TerraformPropertyName("timeout")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Timeout { get; set; }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnhealthyThreshold is required")]
    [TerraformPropertyName("unhealthy_threshold")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> UnhealthyThreshold { get; set; }

}

/// <summary>
/// Block type for redirect_configuration in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayRedirectConfigurationBlock
{

    /// <summary>
    /// The include_path attribute.
    /// </summary>
    [TerraformPropertyName("include_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludePath { get; set; }

    /// <summary>
    /// The include_query_string attribute.
    /// </summary>
    [TerraformPropertyName("include_query_string")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeQueryString { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The redirect_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectType is required")]
    [TerraformPropertyName("redirect_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RedirectType { get; set; }


    /// <summary>
    /// The target_listener_name attribute.
    /// </summary>
    [TerraformPropertyName("target_listener_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetListenerName { get; set; }

    /// <summary>
    /// The target_url attribute.
    /// </summary>
    [TerraformPropertyName("target_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetUrl { get; set; }

}

/// <summary>
/// Block type for request_routing_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayRequestRoutingRuleBlock
{

    /// <summary>
    /// The backend_address_pool_name attribute.
    /// </summary>
    [TerraformPropertyName("backend_address_pool_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BackendAddressPoolName { get; set; }


    /// <summary>
    /// The backend_http_settings_name attribute.
    /// </summary>
    [TerraformPropertyName("backend_http_settings_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BackendHttpSettingsName { get; set; }


    /// <summary>
    /// The http_listener_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpListenerName is required")]
    [TerraformPropertyName("http_listener_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HttpListenerName { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Priority { get; set; }


    /// <summary>
    /// The redirect_configuration_name attribute.
    /// </summary>
    [TerraformPropertyName("redirect_configuration_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RedirectConfigurationName { get; set; }


    /// <summary>
    /// The rewrite_rule_set_name attribute.
    /// </summary>
    [TerraformPropertyName("rewrite_rule_set_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RewriteRuleSetName { get; set; }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    [TerraformPropertyName("rule_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RuleType { get; set; }


    /// <summary>
    /// The url_path_map_name attribute.
    /// </summary>
    [TerraformPropertyName("url_path_map_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UrlPathMapName { get; set; }

}

/// <summary>
/// Block type for rewrite_rule_set in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayRewriteRuleSetBlock
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewaySkuBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformPropertyName("capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Capacity { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformPropertyName("tier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Tier { get; set; }

}

/// <summary>
/// Block type for ssl_certificate in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewaySslCertificateBlock
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    [TerraformPropertyName("data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Data { get; set; }


    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Password { get; set; }


}

/// <summary>
/// Block type for ssl_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewaySslPolicyBlock
{
    /// <summary>
    /// The cipher_suites attribute.
    /// </summary>
    [TerraformPropertyName("cipher_suites")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? CipherSuites { get; set; }

    /// <summary>
    /// The disabled_protocols attribute.
    /// </summary>
    [TerraformPropertyName("disabled_protocols")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? DisabledProtocols { get; set; }

    /// <summary>
    /// The min_protocol_version attribute.
    /// </summary>
    [TerraformPropertyName("min_protocol_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MinProtocolVersion { get; set; }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    [TerraformPropertyName("policy_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PolicyName { get; set; }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformPropertyName("policy_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PolicyType { get; set; }

}

/// <summary>
/// Block type for ssl_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewaySslProfileBlock
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The trusted_client_certificate_names attribute.
    /// </summary>
    [TerraformPropertyName("trusted_client_certificate_names")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? TrustedClientCertificateNames { get; set; }

    /// <summary>
    /// The verify_client_cert_issuer_dn attribute.
    /// </summary>
    [TerraformPropertyName("verify_client_cert_issuer_dn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? VerifyClientCertIssuerDn { get; set; }

    /// <summary>
    /// The verify_client_certificate_revocation attribute.
    /// </summary>
    [TerraformPropertyName("verify_client_certificate_revocation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VerifyClientCertificateRevocation { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationGatewayTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for trusted_client_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayTrustedClientCertificateBlock
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Data is required")]
    [TerraformPropertyName("data")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Data { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for trusted_root_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayTrustedRootCertificateBlock
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    [TerraformPropertyName("data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Data { get; set; }


    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for url_path_map in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayUrlPathMapBlock
{

    /// <summary>
    /// The default_backend_address_pool_name attribute.
    /// </summary>
    [TerraformPropertyName("default_backend_address_pool_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultBackendAddressPoolName { get; set; }


    /// <summary>
    /// The default_backend_http_settings_name attribute.
    /// </summary>
    [TerraformPropertyName("default_backend_http_settings_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultBackendHttpSettingsName { get; set; }


    /// <summary>
    /// The default_redirect_configuration_name attribute.
    /// </summary>
    [TerraformPropertyName("default_redirect_configuration_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultRedirectConfigurationName { get; set; }


    /// <summary>
    /// The default_rewrite_rule_set_name attribute.
    /// </summary>
    [TerraformPropertyName("default_rewrite_rule_set_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultRewriteRuleSetName { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for waf_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayWafConfigurationBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The file_upload_limit_mb attribute.
    /// </summary>
    [TerraformPropertyName("file_upload_limit_mb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? FileUploadLimitMb { get; set; }

    /// <summary>
    /// The firewall_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallMode is required")]
    [TerraformPropertyName("firewall_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FirewallMode { get; set; }

    /// <summary>
    /// The max_request_body_size_kb attribute.
    /// </summary>
    [TerraformPropertyName("max_request_body_size_kb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxRequestBodySizeKb { get; set; }

    /// <summary>
    /// The request_body_check attribute.
    /// </summary>
    [TerraformPropertyName("request_body_check")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequestBodyCheck { get; set; }

    /// <summary>
    /// The rule_set_type attribute.
    /// </summary>
    [TerraformPropertyName("rule_set_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RuleSetType { get; set; }

    /// <summary>
    /// The rule_set_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleSetVersion is required")]
    [TerraformPropertyName("rule_set_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RuleSetVersion { get; set; }

}

/// <summary>
/// Manages a azurerm_application_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermApplicationGateway : TerraformResource
{
    public AzurermApplicationGateway(string name) : base("azurerm_application_gateway", name)
    {
    }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    [TerraformPropertyName("enable_http2")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableHttp2 { get; set; }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformPropertyName("fips_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FipsEnabled { get; set; }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("firewall_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FirewallPolicyId { get; set; }

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    [TerraformPropertyName("force_firewall_policy_association")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceFirewallPolicyAssociation { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for authentication_certificate.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("authentication_certificate")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayAuthenticationCertificateBlock>>? AuthenticationCertificate { get; set; }

    /// <summary>
    /// Block for autoscale_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleConfiguration block(s) allowed")]
    [TerraformPropertyName("autoscale_configuration")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayAutoscaleConfigurationBlock>>? AutoscaleConfiguration { get; set; }

    /// <summary>
    /// Block for backend_address_pool.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendAddressPool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendAddressPool block(s) required")]
    [TerraformPropertyName("backend_address_pool")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayBackendAddressPoolBlock>>? BackendAddressPool { get; set; }

    /// <summary>
    /// Block for backend_http_settings.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendHttpSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendHttpSettings block(s) required")]
    [TerraformPropertyName("backend_http_settings")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayBackendHttpSettingsBlock>>? BackendHttpSettings { get; set; }

    /// <summary>
    /// Block for custom_error_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("custom_error_configuration")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayCustomErrorConfigurationBlock>>? CustomErrorConfiguration { get; set; }

    /// <summary>
    /// Block for frontend_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendIpConfiguration block(s) required")]
    [TerraformPropertyName("frontend_ip_configuration")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayFrontendIpConfigurationBlock>>? FrontendIpConfiguration { get; set; }

    /// <summary>
    /// Block for frontend_port.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendPort block(s) required")]
    [TerraformPropertyName("frontend_port")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayFrontendPortBlock>>? FrontendPort { get; set; }

    /// <summary>
    /// Block for gateway_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayIpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GatewayIpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 GatewayIpConfiguration block(s) allowed")]
    [TerraformPropertyName("gateway_ip_configuration")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayGatewayIpConfigurationBlock>>? GatewayIpConfiguration { get; set; }

    /// <summary>
    /// Block for global.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Global block(s) allowed")]
    [TerraformPropertyName("global")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayGlobalBlock>>? Global { get; set; }

    /// <summary>
    /// Block for http_listener.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpListener is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HttpListener block(s) required")]
    [TerraformPropertyName("http_listener")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayHttpListenerBlock>>? HttpListener { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for private_link_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("private_link_configuration")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayPrivateLinkConfigurationBlock>>? PrivateLinkConfiguration { get; set; }

    /// <summary>
    /// Block for probe.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("probe")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayProbeBlock>>? Probe { get; set; }

    /// <summary>
    /// Block for redirect_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("redirect_configuration")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayRedirectConfigurationBlock>>? RedirectConfiguration { get; set; }

    /// <summary>
    /// Block for request_routing_rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestRoutingRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RequestRoutingRule block(s) required")]
    [TerraformPropertyName("request_routing_rule")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayRequestRoutingRuleBlock>>? RequestRoutingRule { get; set; }

    /// <summary>
    /// Block for rewrite_rule_set.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("rewrite_rule_set")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayRewriteRuleSetBlock>>? RewriteRuleSet { get; set; }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformPropertyName("sku")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewaySkuBlock>>? Sku { get; set; }

    /// <summary>
    /// Block for ssl_certificate.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ssl_certificate")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewaySslCertificateBlock>>? SslCertificate { get; set; }

    /// <summary>
    /// Block for ssl_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslPolicy block(s) allowed")]
    [TerraformPropertyName("ssl_policy")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewaySslPolicyBlock>>? SslPolicy { get; set; }

    /// <summary>
    /// Block for ssl_profile.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("ssl_profile")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewaySslProfileBlock>>? SslProfile { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApplicationGatewayTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for trusted_client_certificate.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("trusted_client_certificate")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayTrustedClientCertificateBlock>>? TrustedClientCertificate { get; set; }

    /// <summary>
    /// Block for trusted_root_certificate.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("trusted_root_certificate")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayTrustedRootCertificateBlock>>? TrustedRootCertificate { get; set; }

    /// <summary>
    /// Block for url_path_map.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("url_path_map")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayUrlPathMapBlock>>? UrlPathMap { get; set; }

    /// <summary>
    /// Block for waf_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WafConfiguration block(s) allowed")]
    [TerraformPropertyName("waf_configuration")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayWafConfigurationBlock>>? WafConfiguration { get; set; }

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint_connection")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> PrivateEndpointConnection => new TerraformReference(this, "private_endpoint_connection");

}
