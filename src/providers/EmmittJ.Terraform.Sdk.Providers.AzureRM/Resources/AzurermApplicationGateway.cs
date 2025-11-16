using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for authentication_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayAuthenticationCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication_certificate";

    /// <summary>
    /// The data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Data is required")]
    public required TerraformValue<string> Data
    {
        get => new TerraformReference<string>(this, "data");
        set => SetArgument("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for autoscale_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayAutoscaleConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscale_configuration";

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MaxCapacity
    {
        get => new TerraformReference<double>(this, "max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformValue<double> MinCapacity
    {
        get => new TerraformReference<double>(this, "min_capacity");
        set => SetArgument("min_capacity", value);
    }

}

/// <summary>
/// Block type for backend_address_pool in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayBackendAddressPoolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend_address_pool";

    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    public TerraformSet<string>? Fqdns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fqdns").ResolveNodes(ctx));
        set => SetArgument("fqdns", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public TerraformSet<string>? IpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ip_addresses").ResolveNodes(ctx));
        set => SetArgument("ip_addresses", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for backend_http_settings in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayBackendHttpSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend_http_settings";

    /// <summary>
    /// The affinity_cookie_name attribute.
    /// </summary>
    public TerraformValue<string>? AffinityCookieName
    {
        get => new TerraformReference<string>(this, "affinity_cookie_name");
        set => SetArgument("affinity_cookie_name", value);
    }

    /// <summary>
    /// The cookie_based_affinity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookieBasedAffinity is required")]
    public required TerraformValue<string> CookieBasedAffinity
    {
        get => new TerraformReference<string>(this, "cookie_based_affinity");
        set => SetArgument("cookie_based_affinity", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformValue<string>? HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The pick_host_name_from_backend_address attribute.
    /// </summary>
    public TerraformValue<bool>? PickHostNameFromBackendAddress
    {
        get => new TerraformReference<bool>(this, "pick_host_name_from_backend_address");
        set => SetArgument("pick_host_name_from_backend_address", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    public TerraformValue<string> ProbeId
    {
        get => new TerraformReference<string>(this, "probe_id");
    }

    /// <summary>
    /// The probe_name attribute.
    /// </summary>
    public TerraformValue<string>? ProbeName
    {
        get => new TerraformReference<string>(this, "probe_name");
        set => SetArgument("probe_name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The request_timeout attribute.
    /// </summary>
    public TerraformValue<double>? RequestTimeout
    {
        get => new TerraformReference<double>(this, "request_timeout");
        set => SetArgument("request_timeout", value);
    }

    /// <summary>
    /// The trusted_root_certificate_names attribute.
    /// </summary>
    public TerraformList<string>? TrustedRootCertificateNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "trusted_root_certificate_names").ResolveNodes(ctx));
        set => SetArgument("trusted_root_certificate_names", value);
    }

}

/// <summary>
/// Block type for custom_error_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayCustomErrorConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_error_configuration";

    /// <summary>
    /// The custom_error_page_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomErrorPageUrl is required")]
    public required TerraformValue<string> CustomErrorPageUrl
    {
        get => new TerraformReference<string>(this, "custom_error_page_url");
        set => SetArgument("custom_error_page_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformValue<string> StatusCode
    {
        get => new TerraformReference<string>(this, "status_code");
        set => SetArgument("status_code", value);
    }

}

/// <summary>
/// Block type for frontend_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayFrontendIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frontend_ip_configuration";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAddressAllocation
    {
        get => new TerraformReference<string>(this, "private_ip_address_allocation");
        set => SetArgument("private_ip_address_allocation", value);
    }

    /// <summary>
    /// The private_link_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> PrivateLinkConfigurationId
    {
        get => new TerraformReference<string>(this, "private_link_configuration_id");
    }

    /// <summary>
    /// The private_link_configuration_name attribute.
    /// </summary>
    public TerraformValue<string>? PrivateLinkConfigurationName
    {
        get => new TerraformReference<string>(this, "private_link_configuration_name");
        set => SetArgument("private_link_configuration_name", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for frontend_port in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayFrontendPortBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frontend_port";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for gateway_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayGatewayIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gateway_ip_configuration";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for global in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayGlobalAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "global";

    /// <summary>
    /// The request_buffering_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestBufferingEnabled is required")]
    public required TerraformValue<bool> RequestBufferingEnabled
    {
        get => new TerraformReference<bool>(this, "request_buffering_enabled");
        set => SetArgument("request_buffering_enabled", value);
    }

    /// <summary>
    /// The response_buffering_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseBufferingEnabled is required")]
    public required TerraformValue<bool> ResponseBufferingEnabled
    {
        get => new TerraformReference<bool>(this, "response_buffering_enabled");
        set => SetArgument("response_buffering_enabled", value);
    }

}

/// <summary>
/// Block type for http_listener in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayHttpListenerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_listener";

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? FirewallPolicyId
    {
        get => new TerraformReference<string>(this, "firewall_policy_id");
        set => SetArgument("firewall_policy_id", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> FrontendIpConfigurationId
    {
        get => new TerraformReference<string>(this, "frontend_ip_configuration_id");
    }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    public required TerraformValue<string> FrontendIpConfigurationName
    {
        get => new TerraformReference<string>(this, "frontend_ip_configuration_name");
        set => SetArgument("frontend_ip_configuration_name", value);
    }

    /// <summary>
    /// The frontend_port_id attribute.
    /// </summary>
    public TerraformValue<string> FrontendPortId
    {
        get => new TerraformReference<string>(this, "frontend_port_id");
    }

    /// <summary>
    /// The frontend_port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPortName is required")]
    public required TerraformValue<string> FrontendPortName
    {
        get => new TerraformReference<string>(this, "frontend_port_name");
        set => SetArgument("frontend_port_name", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformValue<string>? HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The host_names attribute.
    /// </summary>
    public TerraformSet<string>? HostNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "host_names").ResolveNodes(ctx));
        set => SetArgument("host_names", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The require_sni attribute.
    /// </summary>
    public TerraformValue<bool>? RequireSni
    {
        get => new TerraformReference<bool>(this, "require_sni");
        set => SetArgument("require_sni", value);
    }

    /// <summary>
    /// The ssl_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> SslCertificateId
    {
        get => new TerraformReference<string>(this, "ssl_certificate_id");
    }

    /// <summary>
    /// The ssl_certificate_name attribute.
    /// </summary>
    public TerraformValue<string>? SslCertificateName
    {
        get => new TerraformReference<string>(this, "ssl_certificate_name");
        set => SetArgument("ssl_certificate_name", value);
    }

    /// <summary>
    /// The ssl_profile_id attribute.
    /// </summary>
    public TerraformValue<string> SslProfileId
    {
        get => new TerraformReference<string>(this, "ssl_profile_id");
    }

    /// <summary>
    /// The ssl_profile_name attribute.
    /// </summary>
    public TerraformValue<string>? SslProfileName
    {
        get => new TerraformReference<string>(this, "ssl_profile_name");
        set => SetArgument("ssl_profile_name", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for private_link_configuration in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayPrivateLinkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_link_configuration";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for probe in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "probe";

    /// <summary>
    /// The host attribute.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The minimum_servers attribute.
    /// </summary>
    public TerraformValue<double>? MinimumServers
    {
        get => new TerraformReference<double>(this, "minimum_servers");
        set => SetArgument("minimum_servers", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The pick_host_name_from_backend_http_settings attribute.
    /// </summary>
    public TerraformValue<bool>? PickHostNameFromBackendHttpSettings
    {
        get => new TerraformReference<bool>(this, "pick_host_name_from_backend_http_settings");
        set => SetArgument("pick_host_name_from_backend_http_settings", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    public required TerraformValue<double> Timeout
    {
        get => new TerraformReference<double>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnhealthyThreshold is required")]
    public required TerraformValue<double> UnhealthyThreshold
    {
        get => new TerraformReference<double>(this, "unhealthy_threshold");
        set => SetArgument("unhealthy_threshold", value);
    }

}

/// <summary>
/// Block type for redirect_configuration in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayRedirectConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redirect_configuration";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The include_path attribute.
    /// </summary>
    public TerraformValue<bool>? IncludePath
    {
        get => new TerraformReference<bool>(this, "include_path");
        set => SetArgument("include_path", value);
    }

    /// <summary>
    /// The include_query_string attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeQueryString
    {
        get => new TerraformReference<bool>(this, "include_query_string");
        set => SetArgument("include_query_string", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The redirect_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectType is required")]
    public required TerraformValue<string> RedirectType
    {
        get => new TerraformReference<string>(this, "redirect_type");
        set => SetArgument("redirect_type", value);
    }

    /// <summary>
    /// The target_listener_id attribute.
    /// </summary>
    public TerraformValue<string> TargetListenerId
    {
        get => new TerraformReference<string>(this, "target_listener_id");
    }

    /// <summary>
    /// The target_listener_name attribute.
    /// </summary>
    public TerraformValue<string>? TargetListenerName
    {
        get => new TerraformReference<string>(this, "target_listener_name");
        set => SetArgument("target_listener_name", value);
    }

    /// <summary>
    /// The target_url attribute.
    /// </summary>
    public TerraformValue<string>? TargetUrl
    {
        get => new TerraformReference<string>(this, "target_url");
        set => SetArgument("target_url", value);
    }

}

/// <summary>
/// Block type for request_routing_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewayRequestRoutingRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_routing_rule";

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    public TerraformValue<string> BackendAddressPoolId
    {
        get => new TerraformReference<string>(this, "backend_address_pool_id");
    }

    /// <summary>
    /// The backend_address_pool_name attribute.
    /// </summary>
    public TerraformValue<string>? BackendAddressPoolName
    {
        get => new TerraformReference<string>(this, "backend_address_pool_name");
        set => SetArgument("backend_address_pool_name", value);
    }

    /// <summary>
    /// The backend_http_settings_id attribute.
    /// </summary>
    public TerraformValue<string> BackendHttpSettingsId
    {
        get => new TerraformReference<string>(this, "backend_http_settings_id");
    }

    /// <summary>
    /// The backend_http_settings_name attribute.
    /// </summary>
    public TerraformValue<string>? BackendHttpSettingsName
    {
        get => new TerraformReference<string>(this, "backend_http_settings_name");
        set => SetArgument("backend_http_settings_name", value);
    }

    /// <summary>
    /// The http_listener_id attribute.
    /// </summary>
    public TerraformValue<string> HttpListenerId
    {
        get => new TerraformReference<string>(this, "http_listener_id");
    }

    /// <summary>
    /// The http_listener_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpListenerName is required")]
    public required TerraformValue<string> HttpListenerName
    {
        get => new TerraformReference<string>(this, "http_listener_name");
        set => SetArgument("http_listener_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The redirect_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> RedirectConfigurationId
    {
        get => new TerraformReference<string>(this, "redirect_configuration_id");
    }

    /// <summary>
    /// The redirect_configuration_name attribute.
    /// </summary>
    public TerraformValue<string>? RedirectConfigurationName
    {
        get => new TerraformReference<string>(this, "redirect_configuration_name");
        set => SetArgument("redirect_configuration_name", value);
    }

    /// <summary>
    /// The rewrite_rule_set_id attribute.
    /// </summary>
    public TerraformValue<string> RewriteRuleSetId
    {
        get => new TerraformReference<string>(this, "rewrite_rule_set_id");
    }

    /// <summary>
    /// The rewrite_rule_set_name attribute.
    /// </summary>
    public TerraformValue<string>? RewriteRuleSetName
    {
        get => new TerraformReference<string>(this, "rewrite_rule_set_name");
        set => SetArgument("rewrite_rule_set_name", value);
    }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    public required TerraformValue<string> RuleType
    {
        get => new TerraformReference<string>(this, "rule_type");
        set => SetArgument("rule_type", value);
    }

    /// <summary>
    /// The url_path_map_id attribute.
    /// </summary>
    public TerraformValue<string> UrlPathMapId
    {
        get => new TerraformReference<string>(this, "url_path_map_id");
    }

    /// <summary>
    /// The url_path_map_name attribute.
    /// </summary>
    public TerraformValue<string>? UrlPathMapName
    {
        get => new TerraformReference<string>(this, "url_path_map_name");
        set => SetArgument("url_path_map_name", value);
    }

}

/// <summary>
/// Block type for rewrite_rule_set in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayRewriteRuleSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rewrite_rule_set";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewaySkuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku";

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double>? Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

}

/// <summary>
/// Block type for ssl_certificate in .
/// Nesting mode: set
/// </summary>
public class AzurermApplicationGatewaySslCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssl_certificate";

    /// <summary>
    /// The data attribute.
    /// </summary>
    public TerraformValue<string>? Data
    {
        get => new TerraformReference<string>(this, "data");
        set => SetArgument("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The public_cert_data attribute.
    /// </summary>
    public TerraformValue<string> PublicCertData
    {
        get => new TerraformReference<string>(this, "public_cert_data");
    }

}

/// <summary>
/// Block type for ssl_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewaySslPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssl_policy";

    /// <summary>
    /// The cipher_suites attribute.
    /// </summary>
    public TerraformList<string>? CipherSuites
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cipher_suites").ResolveNodes(ctx));
        set => SetArgument("cipher_suites", value);
    }

    /// <summary>
    /// The disabled_protocols attribute.
    /// </summary>
    public TerraformList<string>? DisabledProtocols
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "disabled_protocols").ResolveNodes(ctx));
        set => SetArgument("disabled_protocols", value);
    }

    /// <summary>
    /// The min_protocol_version attribute.
    /// </summary>
    public TerraformValue<string>? MinProtocolVersion
    {
        get => new TerraformReference<string>(this, "min_protocol_version");
        set => SetArgument("min_protocol_version", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    public TerraformValue<string>? PolicyName
    {
        get => new TerraformReference<string>(this, "policy_name");
        set => SetArgument("policy_name", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformValue<string>? PolicyType
    {
        get => new TerraformReference<string>(this, "policy_type");
        set => SetArgument("policy_type", value);
    }

}

/// <summary>
/// Block type for ssl_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewaySslProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssl_profile";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The trusted_client_certificate_names attribute.
    /// </summary>
    public TerraformList<string>? TrustedClientCertificateNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "trusted_client_certificate_names").ResolveNodes(ctx));
        set => SetArgument("trusted_client_certificate_names", value);
    }

    /// <summary>
    /// The verify_client_cert_issuer_dn attribute.
    /// </summary>
    public TerraformValue<bool>? VerifyClientCertIssuerDn
    {
        get => new TerraformReference<bool>(this, "verify_client_cert_issuer_dn");
        set => SetArgument("verify_client_cert_issuer_dn", value);
    }

    /// <summary>
    /// The verify_client_certificate_revocation attribute.
    /// </summary>
    public TerraformValue<string>? VerifyClientCertificateRevocation
    {
        get => new TerraformReference<string>(this, "verify_client_certificate_revocation");
        set => SetArgument("verify_client_certificate_revocation", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationGatewayTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for trusted_client_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayTrustedClientCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trusted_client_certificate";

    /// <summary>
    /// The data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Data is required")]
    public required TerraformValue<string> Data
    {
        get => new TerraformReference<string>(this, "data");
        set => SetArgument("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for trusted_root_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayTrustedRootCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trusted_root_certificate";

    /// <summary>
    /// The data attribute.
    /// </summary>
    public TerraformValue<string>? Data
    {
        get => new TerraformReference<string>(this, "data");
        set => SetArgument("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for url_path_map in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayUrlPathMapBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_path_map";

    /// <summary>
    /// The default_backend_address_pool_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultBackendAddressPoolId
    {
        get => new TerraformReference<string>(this, "default_backend_address_pool_id");
    }

    /// <summary>
    /// The default_backend_address_pool_name attribute.
    /// </summary>
    public TerraformValue<string>? DefaultBackendAddressPoolName
    {
        get => new TerraformReference<string>(this, "default_backend_address_pool_name");
        set => SetArgument("default_backend_address_pool_name", value);
    }

    /// <summary>
    /// The default_backend_http_settings_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultBackendHttpSettingsId
    {
        get => new TerraformReference<string>(this, "default_backend_http_settings_id");
    }

    /// <summary>
    /// The default_backend_http_settings_name attribute.
    /// </summary>
    public TerraformValue<string>? DefaultBackendHttpSettingsName
    {
        get => new TerraformReference<string>(this, "default_backend_http_settings_name");
        set => SetArgument("default_backend_http_settings_name", value);
    }

    /// <summary>
    /// The default_redirect_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultRedirectConfigurationId
    {
        get => new TerraformReference<string>(this, "default_redirect_configuration_id");
    }

    /// <summary>
    /// The default_redirect_configuration_name attribute.
    /// </summary>
    public TerraformValue<string>? DefaultRedirectConfigurationName
    {
        get => new TerraformReference<string>(this, "default_redirect_configuration_name");
        set => SetArgument("default_redirect_configuration_name", value);
    }

    /// <summary>
    /// The default_rewrite_rule_set_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultRewriteRuleSetId
    {
        get => new TerraformReference<string>(this, "default_rewrite_rule_set_id");
    }

    /// <summary>
    /// The default_rewrite_rule_set_name attribute.
    /// </summary>
    public TerraformValue<string>? DefaultRewriteRuleSetName
    {
        get => new TerraformReference<string>(this, "default_rewrite_rule_set_name");
        set => SetArgument("default_rewrite_rule_set_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for waf_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayWafConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "waf_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The file_upload_limit_mb attribute.
    /// </summary>
    public TerraformValue<double>? FileUploadLimitMb
    {
        get => new TerraformReference<double>(this, "file_upload_limit_mb");
        set => SetArgument("file_upload_limit_mb", value);
    }

    /// <summary>
    /// The firewall_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallMode is required")]
    public required TerraformValue<string> FirewallMode
    {
        get => new TerraformReference<string>(this, "firewall_mode");
        set => SetArgument("firewall_mode", value);
    }

    /// <summary>
    /// The max_request_body_size_kb attribute.
    /// </summary>
    public TerraformValue<double>? MaxRequestBodySizeKb
    {
        get => new TerraformReference<double>(this, "max_request_body_size_kb");
        set => SetArgument("max_request_body_size_kb", value);
    }

    /// <summary>
    /// The request_body_check attribute.
    /// </summary>
    public TerraformValue<bool>? RequestBodyCheck
    {
        get => new TerraformReference<bool>(this, "request_body_check");
        set => SetArgument("request_body_check", value);
    }

    /// <summary>
    /// The rule_set_type attribute.
    /// </summary>
    public TerraformValue<string>? RuleSetType
    {
        get => new TerraformReference<string>(this, "rule_set_type");
        set => SetArgument("rule_set_type", value);
    }

    /// <summary>
    /// The rule_set_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleSetVersion is required")]
    public required TerraformValue<string> RuleSetVersion
    {
        get => new TerraformReference<string>(this, "rule_set_version");
        set => SetArgument("rule_set_version", value);
    }

}

/// <summary>
/// Represents a azurerm_application_gateway Terraform resource.
/// Manages a azurerm_application_gateway resource.
/// </summary>
public partial class AzurermApplicationGateway(string name) : TerraformResource("azurerm_application_gateway", name)
{
    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    public TerraformValue<bool>? EnableHttp2
    {
        get => new TerraformReference<bool>(this, "enable_http2");
        set => SetArgument("enable_http2", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FipsEnabled
    {
        get => new TerraformReference<bool>(this, "fips_enabled");
        set => SetArgument("fips_enabled", value);
    }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? FirewallPolicyId
    {
        get => new TerraformReference<string>(this, "firewall_policy_id");
        set => SetArgument("firewall_policy_id", value);
    }

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    public TerraformValue<bool>? ForceFirewallPolicyAssociation
    {
        get => new TerraformReference<bool>(this, "force_firewall_policy_association");
        set => SetArgument("force_firewall_policy_association", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> PrivateEndpointConnection
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "private_endpoint_connection").ResolveNodes(ctx));
    }

    /// <summary>
    /// AuthenticationCertificate block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationGatewayAuthenticationCertificateBlock>? AuthenticationCertificate
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayAuthenticationCertificateBlock>>("authentication_certificate");
        set => SetArgument("authentication_certificate", value);
    }

    /// <summary>
    /// AutoscaleConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleConfiguration block(s) allowed")]
    public TerraformList<AzurermApplicationGatewayAutoscaleConfigurationBlock>? AutoscaleConfiguration
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayAutoscaleConfigurationBlock>>("autoscale_configuration");
        set => SetArgument("autoscale_configuration", value);
    }

    /// <summary>
    /// BackendAddressPool block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendAddressPool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendAddressPool block(s) required")]
    public required TerraformSet<AzurermApplicationGatewayBackendAddressPoolBlock> BackendAddressPool
    {
        get => GetRequiredArgument<TerraformSet<AzurermApplicationGatewayBackendAddressPoolBlock>>("backend_address_pool");
        set => SetArgument("backend_address_pool", value);
    }

    /// <summary>
    /// BackendHttpSettings block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendHttpSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendHttpSettings block(s) required")]
    public required TerraformSet<AzurermApplicationGatewayBackendHttpSettingsBlock> BackendHttpSettings
    {
        get => GetRequiredArgument<TerraformSet<AzurermApplicationGatewayBackendHttpSettingsBlock>>("backend_http_settings");
        set => SetArgument("backend_http_settings", value);
    }

    /// <summary>
    /// CustomErrorConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationGatewayCustomErrorConfigurationBlock>? CustomErrorConfiguration
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayCustomErrorConfigurationBlock>>("custom_error_configuration");
        set => SetArgument("custom_error_configuration", value);
    }

    /// <summary>
    /// FrontendIpConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendIpConfiguration block(s) required")]
    public required TerraformList<AzurermApplicationGatewayFrontendIpConfigurationBlock> FrontendIpConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermApplicationGatewayFrontendIpConfigurationBlock>>("frontend_ip_configuration");
        set => SetArgument("frontend_ip_configuration", value);
    }

    /// <summary>
    /// FrontendPort block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendPort block(s) required")]
    public required TerraformSet<AzurermApplicationGatewayFrontendPortBlock> FrontendPort
    {
        get => GetRequiredArgument<TerraformSet<AzurermApplicationGatewayFrontendPortBlock>>("frontend_port");
        set => SetArgument("frontend_port", value);
    }

    /// <summary>
    /// GatewayIpConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayIpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GatewayIpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 GatewayIpConfiguration block(s) allowed")]
    public required TerraformList<AzurermApplicationGatewayGatewayIpConfigurationBlock> GatewayIpConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermApplicationGatewayGatewayIpConfigurationBlock>>("gateway_ip_configuration");
        set => SetArgument("gateway_ip_configuration", value);
    }

    /// <summary>
    /// GlobalAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GlobalAttribute block(s) allowed")]
    public TerraformList<AzurermApplicationGatewayGlobalAttributeBlock>? GlobalAttribute
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayGlobalAttributeBlock>>("global");
        set => SetArgument("global", value);
    }

    /// <summary>
    /// HttpListener block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpListener is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HttpListener block(s) required")]
    public required TerraformSet<AzurermApplicationGatewayHttpListenerBlock> HttpListener
    {
        get => GetRequiredArgument<TerraformSet<AzurermApplicationGatewayHttpListenerBlock>>("http_listener");
        set => SetArgument("http_listener", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermApplicationGatewayIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// PrivateLinkConfiguration block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermApplicationGatewayPrivateLinkConfigurationBlock>? PrivateLinkConfiguration
    {
        get => GetArgument<TerraformSet<AzurermApplicationGatewayPrivateLinkConfigurationBlock>>("private_link_configuration");
        set => SetArgument("private_link_configuration", value);
    }

    /// <summary>
    /// Probe block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermApplicationGatewayProbeBlock>? Probe
    {
        get => GetArgument<TerraformSet<AzurermApplicationGatewayProbeBlock>>("probe");
        set => SetArgument("probe", value);
    }

    /// <summary>
    /// RedirectConfiguration block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermApplicationGatewayRedirectConfigurationBlock>? RedirectConfiguration
    {
        get => GetArgument<TerraformSet<AzurermApplicationGatewayRedirectConfigurationBlock>>("redirect_configuration");
        set => SetArgument("redirect_configuration", value);
    }

    /// <summary>
    /// RequestRoutingRule block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestRoutingRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RequestRoutingRule block(s) required")]
    public required TerraformSet<AzurermApplicationGatewayRequestRoutingRuleBlock> RequestRoutingRule
    {
        get => GetRequiredArgument<TerraformSet<AzurermApplicationGatewayRequestRoutingRuleBlock>>("request_routing_rule");
        set => SetArgument("request_routing_rule", value);
    }

    /// <summary>
    /// RewriteRuleSet block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationGatewayRewriteRuleSetBlock>? RewriteRuleSet
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayRewriteRuleSetBlock>>("rewrite_rule_set");
        set => SetArgument("rewrite_rule_set", value);
    }

    /// <summary>
    /// Sku block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public required TerraformList<AzurermApplicationGatewaySkuBlock> Sku
    {
        get => GetRequiredArgument<TerraformList<AzurermApplicationGatewaySkuBlock>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// SslCertificate block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermApplicationGatewaySslCertificateBlock>? SslCertificate
    {
        get => GetArgument<TerraformSet<AzurermApplicationGatewaySslCertificateBlock>>("ssl_certificate");
        set => SetArgument("ssl_certificate", value);
    }

    /// <summary>
    /// SslPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslPolicy block(s) allowed")]
    public TerraformList<AzurermApplicationGatewaySslPolicyBlock>? SslPolicy
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewaySslPolicyBlock>>("ssl_policy");
        set => SetArgument("ssl_policy", value);
    }

    /// <summary>
    /// SslProfile block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationGatewaySslProfileBlock>? SslProfile
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewaySslProfileBlock>>("ssl_profile");
        set => SetArgument("ssl_profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApplicationGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApplicationGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TrustedClientCertificate block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationGatewayTrustedClientCertificateBlock>? TrustedClientCertificate
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayTrustedClientCertificateBlock>>("trusted_client_certificate");
        set => SetArgument("trusted_client_certificate", value);
    }

    /// <summary>
    /// TrustedRootCertificate block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationGatewayTrustedRootCertificateBlock>? TrustedRootCertificate
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayTrustedRootCertificateBlock>>("trusted_root_certificate");
        set => SetArgument("trusted_root_certificate", value);
    }

    /// <summary>
    /// UrlPathMap block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationGatewayUrlPathMapBlock>? UrlPathMap
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayUrlPathMapBlock>>("url_path_map");
        set => SetArgument("url_path_map", value);
    }

    /// <summary>
    /// WafConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WafConfiguration block(s) allowed")]
    public TerraformList<AzurermApplicationGatewayWafConfigurationBlock>? WafConfiguration
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayWafConfigurationBlock>>("waf_configuration");
        set => SetArgument("waf_configuration", value);
    }

}
