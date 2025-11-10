using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authentication_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayAuthenticationCertificateBlock : TerraformBlock
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Data is required")]
    public required TerraformProperty<string> Data
    {
        set => SetProperty("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for autoscale_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayAutoscaleConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCapacity
    {
        set => SetProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformProperty<double> MinCapacity
    {
        set => SetProperty("min_capacity", value);
    }

}

/// <summary>
/// Block type for backend_address_pool in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayBackendAddressPoolBlock : TerraformBlock
{
    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Fqdns
    {
        set => SetProperty("fqdns", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IpAddresses
    {
        set => SetProperty("ip_addresses", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for backend_http_settings in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayBackendHttpSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The affinity_cookie_name attribute.
    /// </summary>
    public TerraformProperty<string>? AffinityCookieName
    {
        set => SetProperty("affinity_cookie_name", value);
    }

    /// <summary>
    /// The cookie_based_affinity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookieBasedAffinity is required")]
    public required TerraformProperty<string> CookieBasedAffinity
    {
        set => SetProperty("cookie_based_affinity", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformProperty<string>? HostName
    {
        set => SetProperty("host_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The pick_host_name_from_backend_address attribute.
    /// </summary>
    public TerraformProperty<bool>? PickHostNameFromBackendAddress
    {
        set => SetProperty("pick_host_name_from_backend_address", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProbeId
    {
        set => SetProperty("probe_id", value);
    }

    /// <summary>
    /// The probe_name attribute.
    /// </summary>
    public TerraformProperty<string>? ProbeName
    {
        set => SetProperty("probe_name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The request_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? RequestTimeout
    {
        set => SetProperty("request_timeout", value);
    }

    /// <summary>
    /// The trusted_root_certificate_names attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedRootCertificateNames
    {
        set => SetProperty("trusted_root_certificate_names", value);
    }

}

/// <summary>
/// Block type for custom_error_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayCustomErrorConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The custom_error_page_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomErrorPageUrl is required")]
    public required TerraformProperty<string> CustomErrorPageUrl
    {
        set => SetProperty("custom_error_page_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformProperty<string> StatusCode
    {
        set => SetProperty("status_code", value);
    }

}

/// <summary>
/// Block type for frontend_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayFrontendIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpAddress
    {
        set => SetProperty("private_ip_address", value);
    }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpAddressAllocation
    {
        set => SetProperty("private_ip_address_allocation", value);
    }

    /// <summary>
    /// The private_link_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateLinkConfigurationId
    {
        set => SetProperty("private_link_configuration_id", value);
    }

    /// <summary>
    /// The private_link_configuration_name attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateLinkConfigurationName
    {
        set => SetProperty("private_link_configuration_name", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIpAddressId
    {
        set => SetProperty("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for frontend_port in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayFrontendPortBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        set => SetProperty("port", value);
    }

}

/// <summary>
/// Block type for gateway_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayGatewayIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for global in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayGlobalBlock : TerraformBlock
{
    /// <summary>
    /// The request_buffering_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestBufferingEnabled is required")]
    public required TerraformProperty<bool> RequestBufferingEnabled
    {
        set => SetProperty("request_buffering_enabled", value);
    }

    /// <summary>
    /// The response_buffering_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseBufferingEnabled is required")]
    public required TerraformProperty<bool> ResponseBufferingEnabled
    {
        set => SetProperty("response_buffering_enabled", value);
    }

}

/// <summary>
/// Block type for http_listener in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayHttpListenerBlock : TerraformBlock
{
    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? FirewallPolicyId
    {
        set => SetProperty("firewall_policy_id", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string>? FrontendIpConfigurationId
    {
        set => SetProperty("frontend_ip_configuration_id", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    public required TerraformProperty<string> FrontendIpConfigurationName
    {
        set => SetProperty("frontend_ip_configuration_name", value);
    }

    /// <summary>
    /// The frontend_port_id attribute.
    /// </summary>
    public TerraformProperty<string>? FrontendPortId
    {
        set => SetProperty("frontend_port_id", value);
    }

    /// <summary>
    /// The frontend_port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPortName is required")]
    public required TerraformProperty<string> FrontendPortName
    {
        set => SetProperty("frontend_port_name", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformProperty<string>? HostName
    {
        set => SetProperty("host_name", value);
    }

    /// <summary>
    /// The host_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? HostNames
    {
        set => SetProperty("host_names", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The require_sni attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireSni
    {
        set => SetProperty("require_sni", value);
    }

    /// <summary>
    /// The ssl_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslCertificateId
    {
        set => SetProperty("ssl_certificate_id", value);
    }

    /// <summary>
    /// The ssl_certificate_name attribute.
    /// </summary>
    public TerraformProperty<string>? SslCertificateName
    {
        set => SetProperty("ssl_certificate_name", value);
    }

    /// <summary>
    /// The ssl_profile_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslProfileId
    {
        set => SetProperty("ssl_profile_id", value);
    }

    /// <summary>
    /// The ssl_profile_name attribute.
    /// </summary>
    public TerraformProperty<string>? SslProfileName
    {
        set => SetProperty("ssl_profile_name", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for private_link_configuration in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayPrivateLinkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for probe in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayProbeBlock : TerraformBlock
{
    /// <summary>
    /// The host attribute.
    /// </summary>
    public TerraformProperty<string>? Host
    {
        set => SetProperty("host", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformProperty<double> Interval
    {
        set => SetProperty("interval", value);
    }

    /// <summary>
    /// The minimum_servers attribute.
    /// </summary>
    public TerraformProperty<double>? MinimumServers
    {
        set => SetProperty("minimum_servers", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The pick_host_name_from_backend_http_settings attribute.
    /// </summary>
    public TerraformProperty<bool>? PickHostNameFromBackendHttpSettings
    {
        set => SetProperty("pick_host_name_from_backend_http_settings", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    public required TerraformProperty<double> Timeout
    {
        set => SetProperty("timeout", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnhealthyThreshold is required")]
    public required TerraformProperty<double> UnhealthyThreshold
    {
        set => SetProperty("unhealthy_threshold", value);
    }

}

/// <summary>
/// Block type for redirect_configuration in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayRedirectConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The include_path attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludePath
    {
        set => SetProperty("include_path", value);
    }

    /// <summary>
    /// The include_query_string attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeQueryString
    {
        set => SetProperty("include_query_string", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The redirect_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectType is required")]
    public required TerraformProperty<string> RedirectType
    {
        set => SetProperty("redirect_type", value);
    }

    /// <summary>
    /// The target_listener_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetListenerId
    {
        set => SetProperty("target_listener_id", value);
    }

    /// <summary>
    /// The target_listener_name attribute.
    /// </summary>
    public TerraformProperty<string>? TargetListenerName
    {
        set => SetProperty("target_listener_name", value);
    }

    /// <summary>
    /// The target_url attribute.
    /// </summary>
    public TerraformProperty<string>? TargetUrl
    {
        set => SetProperty("target_url", value);
    }

}

/// <summary>
/// Block type for request_routing_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayRequestRoutingRuleBlock : TerraformBlock
{
    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? BackendAddressPoolId
    {
        set => SetProperty("backend_address_pool_id", value);
    }

    /// <summary>
    /// The backend_address_pool_name attribute.
    /// </summary>
    public TerraformProperty<string>? BackendAddressPoolName
    {
        set => SetProperty("backend_address_pool_name", value);
    }

    /// <summary>
    /// The backend_http_settings_id attribute.
    /// </summary>
    public TerraformProperty<string>? BackendHttpSettingsId
    {
        set => SetProperty("backend_http_settings_id", value);
    }

    /// <summary>
    /// The backend_http_settings_name attribute.
    /// </summary>
    public TerraformProperty<string>? BackendHttpSettingsName
    {
        set => SetProperty("backend_http_settings_name", value);
    }

    /// <summary>
    /// The http_listener_id attribute.
    /// </summary>
    public TerraformProperty<string>? HttpListenerId
    {
        set => SetProperty("http_listener_id", value);
    }

    /// <summary>
    /// The http_listener_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpListenerName is required")]
    public required TerraformProperty<string> HttpListenerName
    {
        set => SetProperty("http_listener_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The redirect_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string>? RedirectConfigurationId
    {
        set => SetProperty("redirect_configuration_id", value);
    }

    /// <summary>
    /// The redirect_configuration_name attribute.
    /// </summary>
    public TerraformProperty<string>? RedirectConfigurationName
    {
        set => SetProperty("redirect_configuration_name", value);
    }

    /// <summary>
    /// The rewrite_rule_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? RewriteRuleSetId
    {
        set => SetProperty("rewrite_rule_set_id", value);
    }

    /// <summary>
    /// The rewrite_rule_set_name attribute.
    /// </summary>
    public TerraformProperty<string>? RewriteRuleSetName
    {
        set => SetProperty("rewrite_rule_set_name", value);
    }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    public required TerraformProperty<string> RuleType
    {
        set => SetProperty("rule_type", value);
    }

    /// <summary>
    /// The url_path_map_id attribute.
    /// </summary>
    public TerraformProperty<string>? UrlPathMapId
    {
        set => SetProperty("url_path_map_id", value);
    }

    /// <summary>
    /// The url_path_map_name attribute.
    /// </summary>
    public TerraformProperty<string>? UrlPathMapName
    {
        set => SetProperty("url_path_map_name", value);
    }

}

/// <summary>
/// Block type for rewrite_rule_set in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayRewriteRuleSetBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewaySkuBlock : TerraformBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformProperty<double>? Capacity
    {
        set => SetProperty("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformProperty<string> Tier
    {
        set => SetProperty("tier", value);
    }

}

/// <summary>
/// Block type for ssl_certificate in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewaySslCertificateBlock : TerraformBlock
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    public TerraformProperty<string>? Data
    {
        set => SetProperty("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultSecretId
    {
        set => SetProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The public_cert_data attribute.
    /// </summary>
    public TerraformProperty<string>? PublicCertData
    {
        set => SetProperty("public_cert_data", value);
    }

}

/// <summary>
/// Block type for ssl_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewaySslPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The cipher_suites attribute.
    /// </summary>
    public List<TerraformProperty<string>>? CipherSuites
    {
        set => SetProperty("cipher_suites", value);
    }

    /// <summary>
    /// The disabled_protocols attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DisabledProtocols
    {
        set => SetProperty("disabled_protocols", value);
    }

    /// <summary>
    /// The min_protocol_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinProtocolVersion
    {
        set => SetProperty("min_protocol_version", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyName
    {
        set => SetProperty("policy_name", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyType
    {
        set => SetProperty("policy_type", value);
    }

}

/// <summary>
/// Block type for ssl_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewaySslProfileBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The trusted_client_certificate_names attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedClientCertificateNames
    {
        set => SetProperty("trusted_client_certificate_names", value);
    }

    /// <summary>
    /// The verify_client_cert_issuer_dn attribute.
    /// </summary>
    public TerraformProperty<bool>? VerifyClientCertIssuerDn
    {
        set => SetProperty("verify_client_cert_issuer_dn", value);
    }

    /// <summary>
    /// The verify_client_certificate_revocation attribute.
    /// </summary>
    public TerraformProperty<string>? VerifyClientCertificateRevocation
    {
        set => SetProperty("verify_client_certificate_revocation", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationGatewayTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for trusted_client_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayTrustedClientCertificateBlock : TerraformBlock
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Data is required")]
    public required TerraformProperty<string> Data
    {
        set => SetProperty("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for trusted_root_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayTrustedRootCertificateBlock : TerraformBlock
{
    /// <summary>
    /// The data attribute.
    /// </summary>
    public TerraformProperty<string>? Data
    {
        set => SetProperty("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultSecretId
    {
        set => SetProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for url_path_map in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayUrlPathMapBlock : TerraformBlock
{
    /// <summary>
    /// The default_backend_address_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultBackendAddressPoolId
    {
        set => SetProperty("default_backend_address_pool_id", value);
    }

    /// <summary>
    /// The default_backend_address_pool_name attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultBackendAddressPoolName
    {
        set => SetProperty("default_backend_address_pool_name", value);
    }

    /// <summary>
    /// The default_backend_http_settings_id attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultBackendHttpSettingsId
    {
        set => SetProperty("default_backend_http_settings_id", value);
    }

    /// <summary>
    /// The default_backend_http_settings_name attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultBackendHttpSettingsName
    {
        set => SetProperty("default_backend_http_settings_name", value);
    }

    /// <summary>
    /// The default_redirect_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultRedirectConfigurationId
    {
        set => SetProperty("default_redirect_configuration_id", value);
    }

    /// <summary>
    /// The default_redirect_configuration_name attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultRedirectConfigurationName
    {
        set => SetProperty("default_redirect_configuration_name", value);
    }

    /// <summary>
    /// The default_rewrite_rule_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultRewriteRuleSetId
    {
        set => SetProperty("default_rewrite_rule_set_id", value);
    }

    /// <summary>
    /// The default_rewrite_rule_set_name attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultRewriteRuleSetName
    {
        set => SetProperty("default_rewrite_rule_set_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for waf_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayWafConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The file_upload_limit_mb attribute.
    /// </summary>
    public TerraformProperty<double>? FileUploadLimitMb
    {
        set => SetProperty("file_upload_limit_mb", value);
    }

    /// <summary>
    /// The firewall_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallMode is required")]
    public required TerraformProperty<string> FirewallMode
    {
        set => SetProperty("firewall_mode", value);
    }

    /// <summary>
    /// The max_request_body_size_kb attribute.
    /// </summary>
    public TerraformProperty<double>? MaxRequestBodySizeKb
    {
        set => SetProperty("max_request_body_size_kb", value);
    }

    /// <summary>
    /// The request_body_check attribute.
    /// </summary>
    public TerraformProperty<bool>? RequestBodyCheck
    {
        set => SetProperty("request_body_check", value);
    }

    /// <summary>
    /// The rule_set_type attribute.
    /// </summary>
    public TerraformProperty<string>? RuleSetType
    {
        set => SetProperty("rule_set_type", value);
    }

    /// <summary>
    /// The rule_set_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleSetVersion is required")]
    public required TerraformProperty<string> RuleSetVersion
    {
        set => SetProperty("rule_set_version", value);
    }

}

/// <summary>
/// Manages a azurerm_application_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermApplicationGateway : TerraformResource
{
    public AzurermApplicationGateway(string name) : base("azurerm_application_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("private_endpoint_connection");
        SetOutput("enable_http2");
        SetOutput("fips_enabled");
        SetOutput("firewall_policy_id");
        SetOutput("force_firewall_policy_association");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
        SetOutput("zones");
    }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    public TerraformProperty<bool> EnableHttp2
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_http2");
        set => SetProperty("enable_http2", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> FipsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("fips_enabled");
        set => SetProperty("fips_enabled", value);
    }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformProperty<string> FirewallPolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firewall_policy_id");
        set => SetProperty("firewall_policy_id", value);
    }

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    public TerraformProperty<bool> ForceFirewallPolicyAssociation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_firewall_policy_association");
        set => SetProperty("force_firewall_policy_association", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Zones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("zones");
        set => SetProperty("zones", value);
    }

    /// <summary>
    /// Block for authentication_certificate.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApplicationGatewayAuthenticationCertificateBlock>? AuthenticationCertificate
    {
        set => SetProperty("authentication_certificate", value);
    }

    /// <summary>
    /// Block for autoscale_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleConfiguration block(s) allowed")]
    public List<AzurermApplicationGatewayAutoscaleConfigurationBlock>? AutoscaleConfiguration
    {
        set => SetProperty("autoscale_configuration", value);
    }

    /// <summary>
    /// Block for backend_address_pool.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendAddressPool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendAddressPool block(s) required")]
    public HashSet<AzurermApplicationGatewayBackendAddressPoolBlock>? BackendAddressPool
    {
        set => SetProperty("backend_address_pool", value);
    }

    /// <summary>
    /// Block for backend_http_settings.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendHttpSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendHttpSettings block(s) required")]
    public HashSet<AzurermApplicationGatewayBackendHttpSettingsBlock>? BackendHttpSettings
    {
        set => SetProperty("backend_http_settings", value);
    }

    /// <summary>
    /// Block for custom_error_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApplicationGatewayCustomErrorConfigurationBlock>? CustomErrorConfiguration
    {
        set => SetProperty("custom_error_configuration", value);
    }

    /// <summary>
    /// Block for frontend_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendIpConfiguration block(s) required")]
    public List<AzurermApplicationGatewayFrontendIpConfigurationBlock>? FrontendIpConfiguration
    {
        set => SetProperty("frontend_ip_configuration", value);
    }

    /// <summary>
    /// Block for frontend_port.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendPort block(s) required")]
    public HashSet<AzurermApplicationGatewayFrontendPortBlock>? FrontendPort
    {
        set => SetProperty("frontend_port", value);
    }

    /// <summary>
    /// Block for gateway_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayIpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GatewayIpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 GatewayIpConfiguration block(s) allowed")]
    public List<AzurermApplicationGatewayGatewayIpConfigurationBlock>? GatewayIpConfiguration
    {
        set => SetProperty("gateway_ip_configuration", value);
    }

    /// <summary>
    /// Block for global.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Global block(s) allowed")]
    public List<AzurermApplicationGatewayGlobalBlock>? Global
    {
        set => SetProperty("global", value);
    }

    /// <summary>
    /// Block for http_listener.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpListener is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HttpListener block(s) required")]
    public HashSet<AzurermApplicationGatewayHttpListenerBlock>? HttpListener
    {
        set => SetProperty("http_listener", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermApplicationGatewayIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for private_link_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermApplicationGatewayPrivateLinkConfigurationBlock>? PrivateLinkConfiguration
    {
        set => SetProperty("private_link_configuration", value);
    }

    /// <summary>
    /// Block for probe.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermApplicationGatewayProbeBlock>? Probe
    {
        set => SetProperty("probe", value);
    }

    /// <summary>
    /// Block for redirect_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermApplicationGatewayRedirectConfigurationBlock>? RedirectConfiguration
    {
        set => SetProperty("redirect_configuration", value);
    }

    /// <summary>
    /// Block for request_routing_rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestRoutingRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RequestRoutingRule block(s) required")]
    public HashSet<AzurermApplicationGatewayRequestRoutingRuleBlock>? RequestRoutingRule
    {
        set => SetProperty("request_routing_rule", value);
    }

    /// <summary>
    /// Block for rewrite_rule_set.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApplicationGatewayRewriteRuleSetBlock>? RewriteRuleSet
    {
        set => SetProperty("rewrite_rule_set", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermApplicationGatewaySkuBlock>? Sku
    {
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// Block for ssl_certificate.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermApplicationGatewaySslCertificateBlock>? SslCertificate
    {
        set => SetProperty("ssl_certificate", value);
    }

    /// <summary>
    /// Block for ssl_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslPolicy block(s) allowed")]
    public List<AzurermApplicationGatewaySslPolicyBlock>? SslPolicy
    {
        set => SetProperty("ssl_policy", value);
    }

    /// <summary>
    /// Block for ssl_profile.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApplicationGatewaySslProfileBlock>? SslProfile
    {
        set => SetProperty("ssl_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApplicationGatewayTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for trusted_client_certificate.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApplicationGatewayTrustedClientCertificateBlock>? TrustedClientCertificate
    {
        set => SetProperty("trusted_client_certificate", value);
    }

    /// <summary>
    /// Block for trusted_root_certificate.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApplicationGatewayTrustedRootCertificateBlock>? TrustedRootCertificate
    {
        set => SetProperty("trusted_root_certificate", value);
    }

    /// <summary>
    /// Block for url_path_map.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApplicationGatewayUrlPathMapBlock>? UrlPathMap
    {
        set => SetProperty("url_path_map", value);
    }

    /// <summary>
    /// Block for waf_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WafConfiguration block(s) allowed")]
    public List<AzurermApplicationGatewayWafConfigurationBlock>? WafConfiguration
    {
        set => SetProperty("waf_configuration", value);
    }

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    public TerraformExpression PrivateEndpointConnection => this["private_endpoint_connection"];

}
