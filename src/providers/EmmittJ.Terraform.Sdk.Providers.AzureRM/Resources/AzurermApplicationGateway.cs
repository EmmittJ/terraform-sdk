using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authentication_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayAuthenticationCertificateBlock : ITerraformBlock
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Data is required")]
    [TerraformPropertyName("data")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Data { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for autoscale_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayAutoscaleConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformPropertyName("max_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    [TerraformPropertyName("min_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinCapacity { get; set; }

}

/// <summary>
/// Block type for backend_address_pool in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayBackendAddressPoolBlock : ITerraformBlock
{
    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    [TerraformPropertyName("fqdns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Fqdns { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("ip_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IpAddresses { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for backend_http_settings in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayBackendHttpSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The affinity_cookie_name attribute.
    /// </summary>
    [TerraformPropertyName("affinity_cookie_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AffinityCookieName { get; set; }

    /// <summary>
    /// The cookie_based_affinity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookieBasedAffinity is required")]
    [TerraformPropertyName("cookie_based_affinity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CookieBasedAffinity { get; set; }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformPropertyName("host_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HostName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Path { get; set; }

    /// <summary>
    /// The pick_host_name_from_backend_address attribute.
    /// </summary>
    [TerraformPropertyName("pick_host_name_from_backend_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PickHostNameFromBackendAddress { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformPropertyName("port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Port { get; set; }

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    [TerraformPropertyName("probe_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProbeId => new TerraformReferenceProperty<TerraformProperty<string>>("", "probe_id");

    /// <summary>
    /// The probe_name attribute.
    /// </summary>
    [TerraformPropertyName("probe_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProbeName { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

    /// <summary>
    /// The request_timeout attribute.
    /// </summary>
    [TerraformPropertyName("request_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RequestTimeout { get; set; }

    /// <summary>
    /// The trusted_root_certificate_names attribute.
    /// </summary>
    [TerraformPropertyName("trusted_root_certificate_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? TrustedRootCertificateNames { get; set; }

}

/// <summary>
/// Block type for custom_error_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayCustomErrorConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The custom_error_page_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomErrorPageUrl is required")]
    [TerraformPropertyName("custom_error_page_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CustomErrorPageUrl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    [TerraformPropertyName("status_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StatusCode { get; set; }

}

/// <summary>
/// Block type for frontend_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayFrontendIpConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateIpAddress { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "private_ip_address");

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address_allocation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateIpAddressAllocation { get; set; }

    /// <summary>
    /// The private_link_configuration_id attribute.
    /// </summary>
    [TerraformPropertyName("private_link_configuration_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateLinkConfigurationId => new TerraformReferenceProperty<TerraformProperty<string>>("", "private_link_configuration_id");

    /// <summary>
    /// The private_link_configuration_name attribute.
    /// </summary>
    [TerraformPropertyName("private_link_configuration_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateLinkConfigurationName { get; set; }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_address_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicIpAddressId { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetId { get; set; }

}

/// <summary>
/// Block type for frontend_port in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayFrontendPortBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformPropertyName("port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Port { get; set; }

}

/// <summary>
/// Block type for gateway_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayGatewayIpConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

}

/// <summary>
/// Block type for global in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayGlobalBlock : ITerraformBlock
{
    /// <summary>
    /// The request_buffering_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestBufferingEnabled is required")]
    [TerraformPropertyName("request_buffering_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> RequestBufferingEnabled { get; set; }

    /// <summary>
    /// The response_buffering_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseBufferingEnabled is required")]
    [TerraformPropertyName("response_buffering_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> ResponseBufferingEnabled { get; set; }

}

/// <summary>
/// Block type for http_listener in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayHttpListenerBlock : ITerraformBlock
{
    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("firewall_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FirewallPolicyId { get; set; }

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    [TerraformPropertyName("frontend_ip_configuration_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FrontendIpConfigurationId => new TerraformReferenceProperty<TerraformProperty<string>>("", "frontend_ip_configuration_id");

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    [TerraformPropertyName("frontend_ip_configuration_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FrontendIpConfigurationName { get; set; }

    /// <summary>
    /// The frontend_port_id attribute.
    /// </summary>
    [TerraformPropertyName("frontend_port_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FrontendPortId => new TerraformReferenceProperty<TerraformProperty<string>>("", "frontend_port_id");

    /// <summary>
    /// The frontend_port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPortName is required")]
    [TerraformPropertyName("frontend_port_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FrontendPortName { get; set; }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformPropertyName("host_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HostName { get; set; }

    /// <summary>
    /// The host_names attribute.
    /// </summary>
    [TerraformPropertyName("host_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? HostNames { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

    /// <summary>
    /// The require_sni attribute.
    /// </summary>
    [TerraformPropertyName("require_sni")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequireSni { get; set; }

    /// <summary>
    /// The ssl_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("ssl_certificate_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SslCertificateId => new TerraformReferenceProperty<TerraformProperty<string>>("", "ssl_certificate_id");

    /// <summary>
    /// The ssl_certificate_name attribute.
    /// </summary>
    [TerraformPropertyName("ssl_certificate_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslCertificateName { get; set; }

    /// <summary>
    /// The ssl_profile_id attribute.
    /// </summary>
    [TerraformPropertyName("ssl_profile_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SslProfileId => new TerraformReferenceProperty<TerraformProperty<string>>("", "ssl_profile_id");

    /// <summary>
    /// The ssl_profile_name attribute.
    /// </summary>
    [TerraformPropertyName("ssl_profile_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslProfileName { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for private_link_configuration in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayPrivateLinkConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for probe in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayProbeBlock : ITerraformBlock
{
    /// <summary>
    /// The host attribute.
    /// </summary>
    [TerraformPropertyName("host")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Host { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformPropertyName("interval")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Interval { get; set; }

    /// <summary>
    /// The minimum_servers attribute.
    /// </summary>
    [TerraformPropertyName("minimum_servers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinimumServers { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformPropertyName("path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Path { get; set; }

    /// <summary>
    /// The pick_host_name_from_backend_http_settings attribute.
    /// </summary>
    [TerraformPropertyName("pick_host_name_from_backend_http_settings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PickHostNameFromBackendHttpSettings { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    [TerraformPropertyName("timeout")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Timeout { get; set; }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnhealthyThreshold is required")]
    [TerraformPropertyName("unhealthy_threshold")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> UnhealthyThreshold { get; set; }

}

/// <summary>
/// Block type for redirect_configuration in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayRedirectConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The include_path attribute.
    /// </summary>
    [TerraformPropertyName("include_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludePath { get; set; }

    /// <summary>
    /// The include_query_string attribute.
    /// </summary>
    [TerraformPropertyName("include_query_string")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeQueryString { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The redirect_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectType is required")]
    [TerraformPropertyName("redirect_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RedirectType { get; set; }

    /// <summary>
    /// The target_listener_id attribute.
    /// </summary>
    [TerraformPropertyName("target_listener_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TargetListenerId => new TerraformReferenceProperty<TerraformProperty<string>>("", "target_listener_id");

    /// <summary>
    /// The target_listener_name attribute.
    /// </summary>
    [TerraformPropertyName("target_listener_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TargetListenerName { get; set; }

    /// <summary>
    /// The target_url attribute.
    /// </summary>
    [TerraformPropertyName("target_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TargetUrl { get; set; }

}

/// <summary>
/// Block type for request_routing_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayRequestRoutingRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("backend_address_pool_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackendAddressPoolId => new TerraformReferenceProperty<TerraformProperty<string>>("", "backend_address_pool_id");

    /// <summary>
    /// The backend_address_pool_name attribute.
    /// </summary>
    [TerraformPropertyName("backend_address_pool_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BackendAddressPoolName { get; set; }

    /// <summary>
    /// The backend_http_settings_id attribute.
    /// </summary>
    [TerraformPropertyName("backend_http_settings_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackendHttpSettingsId => new TerraformReferenceProperty<TerraformProperty<string>>("", "backend_http_settings_id");

    /// <summary>
    /// The backend_http_settings_name attribute.
    /// </summary>
    [TerraformPropertyName("backend_http_settings_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BackendHttpSettingsName { get; set; }

    /// <summary>
    /// The http_listener_id attribute.
    /// </summary>
    [TerraformPropertyName("http_listener_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HttpListenerId => new TerraformReferenceProperty<TerraformProperty<string>>("", "http_listener_id");

    /// <summary>
    /// The http_listener_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpListenerName is required")]
    [TerraformPropertyName("http_listener_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HttpListenerName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Priority { get; set; }

    /// <summary>
    /// The redirect_configuration_id attribute.
    /// </summary>
    [TerraformPropertyName("redirect_configuration_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RedirectConfigurationId => new TerraformReferenceProperty<TerraformProperty<string>>("", "redirect_configuration_id");

    /// <summary>
    /// The redirect_configuration_name attribute.
    /// </summary>
    [TerraformPropertyName("redirect_configuration_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RedirectConfigurationName { get; set; }

    /// <summary>
    /// The rewrite_rule_set_id attribute.
    /// </summary>
    [TerraformPropertyName("rewrite_rule_set_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RewriteRuleSetId => new TerraformReferenceProperty<TerraformProperty<string>>("", "rewrite_rule_set_id");

    /// <summary>
    /// The rewrite_rule_set_name attribute.
    /// </summary>
    [TerraformPropertyName("rewrite_rule_set_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RewriteRuleSetName { get; set; }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    [TerraformPropertyName("rule_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RuleType { get; set; }

    /// <summary>
    /// The url_path_map_id attribute.
    /// </summary>
    [TerraformPropertyName("url_path_map_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UrlPathMapId => new TerraformReferenceProperty<TerraformProperty<string>>("", "url_path_map_id");

    /// <summary>
    /// The url_path_map_name attribute.
    /// </summary>
    [TerraformPropertyName("url_path_map_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UrlPathMapName { get; set; }

}

/// <summary>
/// Block type for rewrite_rule_set in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayRewriteRuleSetBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewaySkuBlock : ITerraformBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformPropertyName("capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Capacity { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformPropertyName("tier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Tier { get; set; }

}

/// <summary>
/// Block type for ssl_certificate in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewaySslCertificateBlock : ITerraformBlock
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    [TerraformPropertyName("data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Data { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// The public_cert_data attribute.
    /// </summary>
    [TerraformPropertyName("public_cert_data")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicCertData => new TerraformReferenceProperty<TerraformProperty<string>>("", "public_cert_data");

}

/// <summary>
/// Block type for ssl_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewaySslPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The cipher_suites attribute.
    /// </summary>
    [TerraformPropertyName("cipher_suites")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? CipherSuites { get; set; }

    /// <summary>
    /// The disabled_protocols attribute.
    /// </summary>
    [TerraformPropertyName("disabled_protocols")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DisabledProtocols { get; set; }

    /// <summary>
    /// The min_protocol_version attribute.
    /// </summary>
    [TerraformPropertyName("min_protocol_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MinProtocolVersion { get; set; }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    [TerraformPropertyName("policy_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PolicyName { get; set; }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformPropertyName("policy_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PolicyType { get; set; }

}

/// <summary>
/// Block type for ssl_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewaySslProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The trusted_client_certificate_names attribute.
    /// </summary>
    [TerraformPropertyName("trusted_client_certificate_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? TrustedClientCertificateNames { get; set; }

    /// <summary>
    /// The verify_client_cert_issuer_dn attribute.
    /// </summary>
    [TerraformPropertyName("verify_client_cert_issuer_dn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? VerifyClientCertIssuerDn { get; set; }

    /// <summary>
    /// The verify_client_certificate_revocation attribute.
    /// </summary>
    [TerraformPropertyName("verify_client_certificate_revocation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VerifyClientCertificateRevocation { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationGatewayTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for trusted_client_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayTrustedClientCertificateBlock : ITerraformBlock
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Data is required")]
    [TerraformPropertyName("data")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Data { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for trusted_root_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayTrustedRootCertificateBlock : ITerraformBlock
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    [TerraformPropertyName("data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Data { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for url_path_map in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayUrlPathMapBlock : ITerraformBlock
{
    /// <summary>
    /// The default_backend_address_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("default_backend_address_pool_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultBackendAddressPoolId => new TerraformReferenceProperty<TerraformProperty<string>>("", "default_backend_address_pool_id");

    /// <summary>
    /// The default_backend_address_pool_name attribute.
    /// </summary>
    [TerraformPropertyName("default_backend_address_pool_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultBackendAddressPoolName { get; set; }

    /// <summary>
    /// The default_backend_http_settings_id attribute.
    /// </summary>
    [TerraformPropertyName("default_backend_http_settings_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultBackendHttpSettingsId => new TerraformReferenceProperty<TerraformProperty<string>>("", "default_backend_http_settings_id");

    /// <summary>
    /// The default_backend_http_settings_name attribute.
    /// </summary>
    [TerraformPropertyName("default_backend_http_settings_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultBackendHttpSettingsName { get; set; }

    /// <summary>
    /// The default_redirect_configuration_id attribute.
    /// </summary>
    [TerraformPropertyName("default_redirect_configuration_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultRedirectConfigurationId => new TerraformReferenceProperty<TerraformProperty<string>>("", "default_redirect_configuration_id");

    /// <summary>
    /// The default_redirect_configuration_name attribute.
    /// </summary>
    [TerraformPropertyName("default_redirect_configuration_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultRedirectConfigurationName { get; set; }

    /// <summary>
    /// The default_rewrite_rule_set_id attribute.
    /// </summary>
    [TerraformPropertyName("default_rewrite_rule_set_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultRewriteRuleSetId => new TerraformReferenceProperty<TerraformProperty<string>>("", "default_rewrite_rule_set_id");

    /// <summary>
    /// The default_rewrite_rule_set_name attribute.
    /// </summary>
    [TerraformPropertyName("default_rewrite_rule_set_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultRewriteRuleSetName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for waf_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayWafConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The file_upload_limit_mb attribute.
    /// </summary>
    [TerraformPropertyName("file_upload_limit_mb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FileUploadLimitMb { get; set; }

    /// <summary>
    /// The firewall_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallMode is required")]
    [TerraformPropertyName("firewall_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FirewallMode { get; set; }

    /// <summary>
    /// The max_request_body_size_kb attribute.
    /// </summary>
    [TerraformPropertyName("max_request_body_size_kb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxRequestBodySizeKb { get; set; }

    /// <summary>
    /// The request_body_check attribute.
    /// </summary>
    [TerraformPropertyName("request_body_check")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequestBodyCheck { get; set; }

    /// <summary>
    /// The rule_set_type attribute.
    /// </summary>
    [TerraformPropertyName("rule_set_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RuleSetType { get; set; }

    /// <summary>
    /// The rule_set_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleSetVersion is required")]
    [TerraformPropertyName("rule_set_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RuleSetVersion { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? EnableHttp2 { get; set; }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformPropertyName("fips_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FipsEnabled { get; set; }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("firewall_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FirewallPolicyId { get; set; }

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    [TerraformPropertyName("force_firewall_policy_association")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceFirewallPolicyAssociation { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Zones { get; set; }

    /// <summary>
    /// Block for authentication_certificate.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("authentication_certificate")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayAuthenticationCertificateBlock>>? AuthenticationCertificate { get; set; } = new();

    /// <summary>
    /// Block for autoscale_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleConfiguration block(s) allowed")]
    [TerraformPropertyName("autoscale_configuration")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayAutoscaleConfigurationBlock>>? AutoscaleConfiguration { get; set; } = new();

    /// <summary>
    /// Block for backend_address_pool.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendAddressPool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendAddressPool block(s) required")]
    [TerraformPropertyName("backend_address_pool")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayBackendAddressPoolBlock>>? BackendAddressPool { get; set; } = new();

    /// <summary>
    /// Block for backend_http_settings.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendHttpSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendHttpSettings block(s) required")]
    [TerraformPropertyName("backend_http_settings")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayBackendHttpSettingsBlock>>? BackendHttpSettings { get; set; } = new();

    /// <summary>
    /// Block for custom_error_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("custom_error_configuration")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayCustomErrorConfigurationBlock>>? CustomErrorConfiguration { get; set; } = new();

    /// <summary>
    /// Block for frontend_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendIpConfiguration block(s) required")]
    [TerraformPropertyName("frontend_ip_configuration")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayFrontendIpConfigurationBlock>>? FrontendIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for frontend_port.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendPort block(s) required")]
    [TerraformPropertyName("frontend_port")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayFrontendPortBlock>>? FrontendPort { get; set; } = new();

    /// <summary>
    /// Block for gateway_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayIpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GatewayIpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 GatewayIpConfiguration block(s) allowed")]
    [TerraformPropertyName("gateway_ip_configuration")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayGatewayIpConfigurationBlock>>? GatewayIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for global.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Global block(s) allowed")]
    [TerraformPropertyName("global")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayGlobalBlock>>? Global { get; set; } = new();

    /// <summary>
    /// Block for http_listener.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpListener is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HttpListener block(s) required")]
    [TerraformPropertyName("http_listener")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayHttpListenerBlock>>? HttpListener { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for private_link_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("private_link_configuration")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayPrivateLinkConfigurationBlock>>? PrivateLinkConfiguration { get; set; } = new();

    /// <summary>
    /// Block for probe.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("probe")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayProbeBlock>>? Probe { get; set; } = new();

    /// <summary>
    /// Block for redirect_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("redirect_configuration")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayRedirectConfigurationBlock>>? RedirectConfiguration { get; set; } = new();

    /// <summary>
    /// Block for request_routing_rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestRoutingRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RequestRoutingRule block(s) required")]
    [TerraformPropertyName("request_routing_rule")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewayRequestRoutingRuleBlock>>? RequestRoutingRule { get; set; } = new();

    /// <summary>
    /// Block for rewrite_rule_set.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("rewrite_rule_set")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayRewriteRuleSetBlock>>? RewriteRuleSet { get; set; } = new();

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformPropertyName("sku")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewaySkuBlock>>? Sku { get; set; } = new();

    /// <summary>
    /// Block for ssl_certificate.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ssl_certificate")]
    public TerraformSet<TerraformBlock<AzurermApplicationGatewaySslCertificateBlock>>? SslCertificate { get; set; } = new();

    /// <summary>
    /// Block for ssl_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslPolicy block(s) allowed")]
    [TerraformPropertyName("ssl_policy")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewaySslPolicyBlock>>? SslPolicy { get; set; } = new();

    /// <summary>
    /// Block for ssl_profile.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("ssl_profile")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewaySslProfileBlock>>? SslProfile { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApplicationGatewayTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for trusted_client_certificate.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("trusted_client_certificate")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayTrustedClientCertificateBlock>>? TrustedClientCertificate { get; set; } = new();

    /// <summary>
    /// Block for trusted_root_certificate.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("trusted_root_certificate")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayTrustedRootCertificateBlock>>? TrustedRootCertificate { get; set; } = new();

    /// <summary>
    /// Block for url_path_map.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("url_path_map")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayUrlPathMapBlock>>? UrlPathMap { get; set; } = new();

    /// <summary>
    /// Block for waf_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WafConfiguration block(s) allowed")]
    [TerraformPropertyName("waf_configuration")]
    public TerraformList<TerraformBlock<AzurermApplicationGatewayWafConfigurationBlock>>? WafConfiguration { get; set; } = new();

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint_connection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> PrivateEndpointConnection => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "private_endpoint_connection");

}
