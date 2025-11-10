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
        get => GetProperty<TerraformProperty<string>>("data");
        set => WithProperty("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        get => GetProperty<TerraformProperty<double>>("max_capacity");
        set => WithProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformProperty<double> MinCapacity
    {
        get => GetProperty<TerraformProperty<double>>("min_capacity");
        set => WithProperty("min_capacity", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("fqdns");
        set => WithProperty("fqdns", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IpAddresses
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ip_addresses");
        set => WithProperty("ip_addresses", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        get => GetProperty<TerraformProperty<string>>("affinity_cookie_name");
        set => WithProperty("affinity_cookie_name", value);
    }

    /// <summary>
    /// The cookie_based_affinity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookieBasedAffinity is required")]
    public required TerraformProperty<string> CookieBasedAffinity
    {
        get => GetProperty<TerraformProperty<string>>("cookie_based_affinity");
        set => WithProperty("cookie_based_affinity", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformProperty<string>? HostName
    {
        get => GetProperty<TerraformProperty<string>>("host_name");
        set => WithProperty("host_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The pick_host_name_from_backend_address attribute.
    /// </summary>
    public TerraformProperty<bool>? PickHostNameFromBackendAddress
    {
        get => GetProperty<TerraformProperty<bool>>("pick_host_name_from_backend_address");
        set => WithProperty("pick_host_name_from_backend_address", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProbeId
    {
        get => GetProperty<TerraformProperty<string>>("probe_id");
        set => WithProperty("probe_id", value);
    }

    /// <summary>
    /// The probe_name attribute.
    /// </summary>
    public TerraformProperty<string>? ProbeName
    {
        get => GetProperty<TerraformProperty<string>>("probe_name");
        set => WithProperty("probe_name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The request_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? RequestTimeout
    {
        get => GetProperty<TerraformProperty<double>>("request_timeout");
        set => WithProperty("request_timeout", value);
    }

    /// <summary>
    /// The trusted_root_certificate_names attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedRootCertificateNames
    {
        get => GetProperty<List<TerraformProperty<string>>>("trusted_root_certificate_names");
        set => WithProperty("trusted_root_certificate_names", value);
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
        get => GetProperty<TerraformProperty<string>>("custom_error_page_url");
        set => WithProperty("custom_error_page_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformProperty<string> StatusCode
    {
        get => GetProperty<TerraformProperty<string>>("status_code");
        set => WithProperty("status_code", value);
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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("private_ip_address");
        set => WithProperty("private_ip_address", value);
    }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpAddressAllocation
    {
        get => GetProperty<TerraformProperty<string>>("private_ip_address_allocation");
        set => WithProperty("private_ip_address_allocation", value);
    }

    /// <summary>
    /// The private_link_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateLinkConfigurationId
    {
        get => GetProperty<TerraformProperty<string>>("private_link_configuration_id");
        set => WithProperty("private_link_configuration_id", value);
    }

    /// <summary>
    /// The private_link_configuration_name attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateLinkConfigurationName
    {
        get => GetProperty<TerraformProperty<string>>("private_link_configuration_name");
        set => WithProperty("private_link_configuration_name", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIpAddressId
    {
        get => GetProperty<TerraformProperty<string>>("public_ip_address_id");
        set => WithProperty("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
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
        get => GetProperty<TerraformProperty<bool>>("request_buffering_enabled");
        set => WithProperty("request_buffering_enabled", value);
    }

    /// <summary>
    /// The response_buffering_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseBufferingEnabled is required")]
    public required TerraformProperty<bool> ResponseBufferingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("response_buffering_enabled");
        set => WithProperty("response_buffering_enabled", value);
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
        get => GetProperty<TerraformProperty<string>>("firewall_policy_id");
        set => WithProperty("firewall_policy_id", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string>? FrontendIpConfigurationId
    {
        get => GetProperty<TerraformProperty<string>>("frontend_ip_configuration_id");
        set => WithProperty("frontend_ip_configuration_id", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    public required TerraformProperty<string> FrontendIpConfigurationName
    {
        get => GetProperty<TerraformProperty<string>>("frontend_ip_configuration_name");
        set => WithProperty("frontend_ip_configuration_name", value);
    }

    /// <summary>
    /// The frontend_port_id attribute.
    /// </summary>
    public TerraformProperty<string>? FrontendPortId
    {
        get => GetProperty<TerraformProperty<string>>("frontend_port_id");
        set => WithProperty("frontend_port_id", value);
    }

    /// <summary>
    /// The frontend_port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPortName is required")]
    public required TerraformProperty<string> FrontendPortName
    {
        get => GetProperty<TerraformProperty<string>>("frontend_port_name");
        set => WithProperty("frontend_port_name", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformProperty<string>? HostName
    {
        get => GetProperty<TerraformProperty<string>>("host_name");
        set => WithProperty("host_name", value);
    }

    /// <summary>
    /// The host_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? HostNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("host_names");
        set => WithProperty("host_names", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The require_sni attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireSni
    {
        get => GetProperty<TerraformProperty<bool>>("require_sni");
        set => WithProperty("require_sni", value);
    }

    /// <summary>
    /// The ssl_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("ssl_certificate_id");
        set => WithProperty("ssl_certificate_id", value);
    }

    /// <summary>
    /// The ssl_certificate_name attribute.
    /// </summary>
    public TerraformProperty<string>? SslCertificateName
    {
        get => GetProperty<TerraformProperty<string>>("ssl_certificate_name");
        set => WithProperty("ssl_certificate_name", value);
    }

    /// <summary>
    /// The ssl_profile_id attribute.
    /// </summary>
    public TerraformProperty<string>? SslProfileId
    {
        get => GetProperty<TerraformProperty<string>>("ssl_profile_id");
        set => WithProperty("ssl_profile_id", value);
    }

    /// <summary>
    /// The ssl_profile_name attribute.
    /// </summary>
    public TerraformProperty<string>? SslProfileName
    {
        get => GetProperty<TerraformProperty<string>>("ssl_profile_name");
        set => WithProperty("ssl_profile_name", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        get => GetProperty<TerraformProperty<string>>("host");
        set => WithProperty("host", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformProperty<double> Interval
    {
        get => GetProperty<TerraformProperty<double>>("interval");
        set => WithProperty("interval", value);
    }

    /// <summary>
    /// The minimum_servers attribute.
    /// </summary>
    public TerraformProperty<double>? MinimumServers
    {
        get => GetProperty<TerraformProperty<double>>("minimum_servers");
        set => WithProperty("minimum_servers", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The pick_host_name_from_backend_http_settings attribute.
    /// </summary>
    public TerraformProperty<bool>? PickHostNameFromBackendHttpSettings
    {
        get => GetProperty<TerraformProperty<bool>>("pick_host_name_from_backend_http_settings");
        set => WithProperty("pick_host_name_from_backend_http_settings", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    public required TerraformProperty<double> Timeout
    {
        get => GetProperty<TerraformProperty<double>>("timeout");
        set => WithProperty("timeout", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnhealthyThreshold is required")]
    public required TerraformProperty<double> UnhealthyThreshold
    {
        get => GetProperty<TerraformProperty<double>>("unhealthy_threshold");
        set => WithProperty("unhealthy_threshold", value);
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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The include_path attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludePath
    {
        get => GetProperty<TerraformProperty<bool>>("include_path");
        set => WithProperty("include_path", value);
    }

    /// <summary>
    /// The include_query_string attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeQueryString
    {
        get => GetProperty<TerraformProperty<bool>>("include_query_string");
        set => WithProperty("include_query_string", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The redirect_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectType is required")]
    public required TerraformProperty<string> RedirectType
    {
        get => GetProperty<TerraformProperty<string>>("redirect_type");
        set => WithProperty("redirect_type", value);
    }

    /// <summary>
    /// The target_listener_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetListenerId
    {
        get => GetProperty<TerraformProperty<string>>("target_listener_id");
        set => WithProperty("target_listener_id", value);
    }

    /// <summary>
    /// The target_listener_name attribute.
    /// </summary>
    public TerraformProperty<string>? TargetListenerName
    {
        get => GetProperty<TerraformProperty<string>>("target_listener_name");
        set => WithProperty("target_listener_name", value);
    }

    /// <summary>
    /// The target_url attribute.
    /// </summary>
    public TerraformProperty<string>? TargetUrl
    {
        get => GetProperty<TerraformProperty<string>>("target_url");
        set => WithProperty("target_url", value);
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
        get => GetProperty<TerraformProperty<string>>("backend_address_pool_id");
        set => WithProperty("backend_address_pool_id", value);
    }

    /// <summary>
    /// The backend_address_pool_name attribute.
    /// </summary>
    public TerraformProperty<string>? BackendAddressPoolName
    {
        get => GetProperty<TerraformProperty<string>>("backend_address_pool_name");
        set => WithProperty("backend_address_pool_name", value);
    }

    /// <summary>
    /// The backend_http_settings_id attribute.
    /// </summary>
    public TerraformProperty<string>? BackendHttpSettingsId
    {
        get => GetProperty<TerraformProperty<string>>("backend_http_settings_id");
        set => WithProperty("backend_http_settings_id", value);
    }

    /// <summary>
    /// The backend_http_settings_name attribute.
    /// </summary>
    public TerraformProperty<string>? BackendHttpSettingsName
    {
        get => GetProperty<TerraformProperty<string>>("backend_http_settings_name");
        set => WithProperty("backend_http_settings_name", value);
    }

    /// <summary>
    /// The http_listener_id attribute.
    /// </summary>
    public TerraformProperty<string>? HttpListenerId
    {
        get => GetProperty<TerraformProperty<string>>("http_listener_id");
        set => WithProperty("http_listener_id", value);
    }

    /// <summary>
    /// The http_listener_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpListenerName is required")]
    public required TerraformProperty<string> HttpListenerName
    {
        get => GetProperty<TerraformProperty<string>>("http_listener_name");
        set => WithProperty("http_listener_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

    /// <summary>
    /// The redirect_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string>? RedirectConfigurationId
    {
        get => GetProperty<TerraformProperty<string>>("redirect_configuration_id");
        set => WithProperty("redirect_configuration_id", value);
    }

    /// <summary>
    /// The redirect_configuration_name attribute.
    /// </summary>
    public TerraformProperty<string>? RedirectConfigurationName
    {
        get => GetProperty<TerraformProperty<string>>("redirect_configuration_name");
        set => WithProperty("redirect_configuration_name", value);
    }

    /// <summary>
    /// The rewrite_rule_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? RewriteRuleSetId
    {
        get => GetProperty<TerraformProperty<string>>("rewrite_rule_set_id");
        set => WithProperty("rewrite_rule_set_id", value);
    }

    /// <summary>
    /// The rewrite_rule_set_name attribute.
    /// </summary>
    public TerraformProperty<string>? RewriteRuleSetName
    {
        get => GetProperty<TerraformProperty<string>>("rewrite_rule_set_name");
        set => WithProperty("rewrite_rule_set_name", value);
    }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    public required TerraformProperty<string> RuleType
    {
        get => GetProperty<TerraformProperty<string>>("rule_type");
        set => WithProperty("rule_type", value);
    }

    /// <summary>
    /// The url_path_map_id attribute.
    /// </summary>
    public TerraformProperty<string>? UrlPathMapId
    {
        get => GetProperty<TerraformProperty<string>>("url_path_map_id");
        set => WithProperty("url_path_map_id", value);
    }

    /// <summary>
    /// The url_path_map_name attribute.
    /// </summary>
    public TerraformProperty<string>? UrlPathMapName
    {
        get => GetProperty<TerraformProperty<string>>("url_path_map_name");
        set => WithProperty("url_path_map_name", value);
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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        get => GetProperty<TerraformProperty<double>>("capacity");
        set => WithProperty("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformProperty<string> Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => WithProperty("tier", value);
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
        get => GetProperty<TerraformProperty<string>>("data");
        set => WithProperty("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_secret_id");
        set => WithProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// The public_cert_data attribute.
    /// </summary>
    public TerraformProperty<string>? PublicCertData
    {
        get => GetProperty<TerraformProperty<string>>("public_cert_data");
        set => WithProperty("public_cert_data", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("cipher_suites");
        set => WithProperty("cipher_suites", value);
    }

    /// <summary>
    /// The disabled_protocols attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DisabledProtocols
    {
        get => GetProperty<List<TerraformProperty<string>>>("disabled_protocols");
        set => WithProperty("disabled_protocols", value);
    }

    /// <summary>
    /// The min_protocol_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinProtocolVersion
    {
        get => GetProperty<TerraformProperty<string>>("min_protocol_version");
        set => WithProperty("min_protocol_version", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyName
    {
        get => GetProperty<TerraformProperty<string>>("policy_name");
        set => WithProperty("policy_name", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyType
    {
        get => GetProperty<TerraformProperty<string>>("policy_type");
        set => WithProperty("policy_type", value);
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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The trusted_client_certificate_names attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedClientCertificateNames
    {
        get => GetProperty<List<TerraformProperty<string>>>("trusted_client_certificate_names");
        set => WithProperty("trusted_client_certificate_names", value);
    }

    /// <summary>
    /// The verify_client_cert_issuer_dn attribute.
    /// </summary>
    public TerraformProperty<bool>? VerifyClientCertIssuerDn
    {
        get => GetProperty<TerraformProperty<bool>>("verify_client_cert_issuer_dn");
        set => WithProperty("verify_client_cert_issuer_dn", value);
    }

    /// <summary>
    /// The verify_client_certificate_revocation attribute.
    /// </summary>
    public TerraformProperty<string>? VerifyClientCertificateRevocation
    {
        get => GetProperty<TerraformProperty<string>>("verify_client_certificate_revocation");
        set => WithProperty("verify_client_certificate_revocation", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        get => GetProperty<TerraformProperty<string>>("data");
        set => WithProperty("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        get => GetProperty<TerraformProperty<string>>("data");
        set => WithProperty("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_secret_id");
        set => WithProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        get => GetProperty<TerraformProperty<string>>("default_backend_address_pool_id");
        set => WithProperty("default_backend_address_pool_id", value);
    }

    /// <summary>
    /// The default_backend_address_pool_name attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultBackendAddressPoolName
    {
        get => GetProperty<TerraformProperty<string>>("default_backend_address_pool_name");
        set => WithProperty("default_backend_address_pool_name", value);
    }

    /// <summary>
    /// The default_backend_http_settings_id attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultBackendHttpSettingsId
    {
        get => GetProperty<TerraformProperty<string>>("default_backend_http_settings_id");
        set => WithProperty("default_backend_http_settings_id", value);
    }

    /// <summary>
    /// The default_backend_http_settings_name attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultBackendHttpSettingsName
    {
        get => GetProperty<TerraformProperty<string>>("default_backend_http_settings_name");
        set => WithProperty("default_backend_http_settings_name", value);
    }

    /// <summary>
    /// The default_redirect_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultRedirectConfigurationId
    {
        get => GetProperty<TerraformProperty<string>>("default_redirect_configuration_id");
        set => WithProperty("default_redirect_configuration_id", value);
    }

    /// <summary>
    /// The default_redirect_configuration_name attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultRedirectConfigurationName
    {
        get => GetProperty<TerraformProperty<string>>("default_redirect_configuration_name");
        set => WithProperty("default_redirect_configuration_name", value);
    }

    /// <summary>
    /// The default_rewrite_rule_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultRewriteRuleSetId
    {
        get => GetProperty<TerraformProperty<string>>("default_rewrite_rule_set_id");
        set => WithProperty("default_rewrite_rule_set_id", value);
    }

    /// <summary>
    /// The default_rewrite_rule_set_name attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultRewriteRuleSetName
    {
        get => GetProperty<TerraformProperty<string>>("default_rewrite_rule_set_name");
        set => WithProperty("default_rewrite_rule_set_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The file_upload_limit_mb attribute.
    /// </summary>
    public TerraformProperty<double>? FileUploadLimitMb
    {
        get => GetProperty<TerraformProperty<double>>("file_upload_limit_mb");
        set => WithProperty("file_upload_limit_mb", value);
    }

    /// <summary>
    /// The firewall_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallMode is required")]
    public required TerraformProperty<string> FirewallMode
    {
        get => GetProperty<TerraformProperty<string>>("firewall_mode");
        set => WithProperty("firewall_mode", value);
    }

    /// <summary>
    /// The max_request_body_size_kb attribute.
    /// </summary>
    public TerraformProperty<double>? MaxRequestBodySizeKb
    {
        get => GetProperty<TerraformProperty<double>>("max_request_body_size_kb");
        set => WithProperty("max_request_body_size_kb", value);
    }

    /// <summary>
    /// The request_body_check attribute.
    /// </summary>
    public TerraformProperty<bool>? RequestBodyCheck
    {
        get => GetProperty<TerraformProperty<bool>>("request_body_check");
        set => WithProperty("request_body_check", value);
    }

    /// <summary>
    /// The rule_set_type attribute.
    /// </summary>
    public TerraformProperty<string>? RuleSetType
    {
        get => GetProperty<TerraformProperty<string>>("rule_set_type");
        set => WithProperty("rule_set_type", value);
    }

    /// <summary>
    /// The rule_set_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleSetVersion is required")]
    public required TerraformProperty<string> RuleSetVersion
    {
        get => GetProperty<TerraformProperty<string>>("rule_set_version");
        set => WithProperty("rule_set_version", value);
    }

}

/// <summary>
/// Manages a azurerm_application_gateway resource.
/// </summary>
public class AzurermApplicationGateway : TerraformResource
{
    public AzurermApplicationGateway(string name) : base("azurerm_application_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("private_endpoint_connection");
    }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableHttp2
    {
        get => GetProperty<TerraformProperty<bool>>("enable_http2");
        set => this.WithProperty("enable_http2", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FipsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("fips_enabled");
        set => this.WithProperty("fips_enabled", value);
    }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? FirewallPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("firewall_policy_id");
        set => this.WithProperty("firewall_policy_id", value);
    }

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceFirewallPolicyAssociation
    {
        get => GetProperty<TerraformProperty<bool>>("force_firewall_policy_association");
        set => this.WithProperty("force_firewall_policy_association", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// Block for authentication_certificate.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApplicationGatewayAuthenticationCertificateBlock>? AuthenticationCertificate
    {
        get => GetProperty<List<AzurermApplicationGatewayAuthenticationCertificateBlock>>("authentication_certificate");
        set => this.WithProperty("authentication_certificate", value);
    }

    /// <summary>
    /// Block for autoscale_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleConfiguration block(s) allowed")]
    public List<AzurermApplicationGatewayAutoscaleConfigurationBlock>? AutoscaleConfiguration
    {
        get => GetProperty<List<AzurermApplicationGatewayAutoscaleConfigurationBlock>>("autoscale_configuration");
        set => this.WithProperty("autoscale_configuration", value);
    }

    /// <summary>
    /// Block for backend_address_pool.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendAddressPool block(s) required")]
    public HashSet<AzurermApplicationGatewayBackendAddressPoolBlock>? BackendAddressPool
    {
        get => GetProperty<HashSet<AzurermApplicationGatewayBackendAddressPoolBlock>>("backend_address_pool");
        set => this.WithProperty("backend_address_pool", value);
    }

    /// <summary>
    /// Block for backend_http_settings.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendHttpSettings block(s) required")]
    public HashSet<AzurermApplicationGatewayBackendHttpSettingsBlock>? BackendHttpSettings
    {
        get => GetProperty<HashSet<AzurermApplicationGatewayBackendHttpSettingsBlock>>("backend_http_settings");
        set => this.WithProperty("backend_http_settings", value);
    }

    /// <summary>
    /// Block for custom_error_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApplicationGatewayCustomErrorConfigurationBlock>? CustomErrorConfiguration
    {
        get => GetProperty<List<AzurermApplicationGatewayCustomErrorConfigurationBlock>>("custom_error_configuration");
        set => this.WithProperty("custom_error_configuration", value);
    }

    /// <summary>
    /// Block for frontend_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendIpConfiguration block(s) required")]
    public List<AzurermApplicationGatewayFrontendIpConfigurationBlock>? FrontendIpConfiguration
    {
        get => GetProperty<List<AzurermApplicationGatewayFrontendIpConfigurationBlock>>("frontend_ip_configuration");
        set => this.WithProperty("frontend_ip_configuration", value);
    }

    /// <summary>
    /// Block for frontend_port.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendPort block(s) required")]
    public HashSet<AzurermApplicationGatewayFrontendPortBlock>? FrontendPort
    {
        get => GetProperty<HashSet<AzurermApplicationGatewayFrontendPortBlock>>("frontend_port");
        set => this.WithProperty("frontend_port", value);
    }

    /// <summary>
    /// Block for gateway_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GatewayIpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 GatewayIpConfiguration block(s) allowed")]
    public List<AzurermApplicationGatewayGatewayIpConfigurationBlock>? GatewayIpConfiguration
    {
        get => GetProperty<List<AzurermApplicationGatewayGatewayIpConfigurationBlock>>("gateway_ip_configuration");
        set => this.WithProperty("gateway_ip_configuration", value);
    }

    /// <summary>
    /// Block for global.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Global block(s) allowed")]
    public List<AzurermApplicationGatewayGlobalBlock>? Global
    {
        get => GetProperty<List<AzurermApplicationGatewayGlobalBlock>>("global");
        set => this.WithProperty("global", value);
    }

    /// <summary>
    /// Block for http_listener.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HttpListener block(s) required")]
    public HashSet<AzurermApplicationGatewayHttpListenerBlock>? HttpListener
    {
        get => GetProperty<HashSet<AzurermApplicationGatewayHttpListenerBlock>>("http_listener");
        set => this.WithProperty("http_listener", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermApplicationGatewayIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermApplicationGatewayIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for private_link_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermApplicationGatewayPrivateLinkConfigurationBlock>? PrivateLinkConfiguration
    {
        get => GetProperty<HashSet<AzurermApplicationGatewayPrivateLinkConfigurationBlock>>("private_link_configuration");
        set => this.WithProperty("private_link_configuration", value);
    }

    /// <summary>
    /// Block for probe.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermApplicationGatewayProbeBlock>? Probe
    {
        get => GetProperty<HashSet<AzurermApplicationGatewayProbeBlock>>("probe");
        set => this.WithProperty("probe", value);
    }

    /// <summary>
    /// Block for redirect_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermApplicationGatewayRedirectConfigurationBlock>? RedirectConfiguration
    {
        get => GetProperty<HashSet<AzurermApplicationGatewayRedirectConfigurationBlock>>("redirect_configuration");
        set => this.WithProperty("redirect_configuration", value);
    }

    /// <summary>
    /// Block for request_routing_rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RequestRoutingRule block(s) required")]
    public HashSet<AzurermApplicationGatewayRequestRoutingRuleBlock>? RequestRoutingRule
    {
        get => GetProperty<HashSet<AzurermApplicationGatewayRequestRoutingRuleBlock>>("request_routing_rule");
        set => this.WithProperty("request_routing_rule", value);
    }

    /// <summary>
    /// Block for rewrite_rule_set.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApplicationGatewayRewriteRuleSetBlock>? RewriteRuleSet
    {
        get => GetProperty<List<AzurermApplicationGatewayRewriteRuleSetBlock>>("rewrite_rule_set");
        set => this.WithProperty("rewrite_rule_set", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermApplicationGatewaySkuBlock>? Sku
    {
        get => GetProperty<List<AzurermApplicationGatewaySkuBlock>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// Block for ssl_certificate.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermApplicationGatewaySslCertificateBlock>? SslCertificate
    {
        get => GetProperty<HashSet<AzurermApplicationGatewaySslCertificateBlock>>("ssl_certificate");
        set => this.WithProperty("ssl_certificate", value);
    }

    /// <summary>
    /// Block for ssl_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslPolicy block(s) allowed")]
    public List<AzurermApplicationGatewaySslPolicyBlock>? SslPolicy
    {
        get => GetProperty<List<AzurermApplicationGatewaySslPolicyBlock>>("ssl_policy");
        set => this.WithProperty("ssl_policy", value);
    }

    /// <summary>
    /// Block for ssl_profile.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApplicationGatewaySslProfileBlock>? SslProfile
    {
        get => GetProperty<List<AzurermApplicationGatewaySslProfileBlock>>("ssl_profile");
        set => this.WithProperty("ssl_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApplicationGatewayTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApplicationGatewayTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for trusted_client_certificate.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApplicationGatewayTrustedClientCertificateBlock>? TrustedClientCertificate
    {
        get => GetProperty<List<AzurermApplicationGatewayTrustedClientCertificateBlock>>("trusted_client_certificate");
        set => this.WithProperty("trusted_client_certificate", value);
    }

    /// <summary>
    /// Block for trusted_root_certificate.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApplicationGatewayTrustedRootCertificateBlock>? TrustedRootCertificate
    {
        get => GetProperty<List<AzurermApplicationGatewayTrustedRootCertificateBlock>>("trusted_root_certificate");
        set => this.WithProperty("trusted_root_certificate", value);
    }

    /// <summary>
    /// Block for url_path_map.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApplicationGatewayUrlPathMapBlock>? UrlPathMap
    {
        get => GetProperty<List<AzurermApplicationGatewayUrlPathMapBlock>>("url_path_map");
        set => this.WithProperty("url_path_map", value);
    }

    /// <summary>
    /// Block for waf_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WafConfiguration block(s) allowed")]
    public List<AzurermApplicationGatewayWafConfigurationBlock>? WafConfiguration
    {
        get => GetProperty<List<AzurermApplicationGatewayWafConfigurationBlock>>("waf_configuration");
        set => this.WithProperty("waf_configuration", value);
    }

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    public TerraformExpression PrivateEndpointConnection => this["private_endpoint_connection"];

}
