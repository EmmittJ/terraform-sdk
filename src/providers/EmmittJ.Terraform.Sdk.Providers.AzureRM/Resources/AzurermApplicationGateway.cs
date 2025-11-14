using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("data")]
    public required TerraformValue<string> Data
    {
        get => new TerraformReference<string>(this, "data");
        set => SetArgument("data", value);
    }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
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
    [TerraformArgument("max_capacity")]
    public TerraformValue<double>? MaxCapacity
    {
        get => new TerraformReference<double>(this, "max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    [TerraformArgument("min_capacity")]
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
    [TerraformArgument("fqdns")]
    public TerraformSet<string>? Fqdns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fqdns").ResolveNodes(ctx));
        set => SetArgument("fqdns", value);
    }


    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    [TerraformArgument("ip_addresses")]
    public TerraformSet<string>? IpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ip_addresses").ResolveNodes(ctx));
        set => SetArgument("ip_addresses", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
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
    [TerraformArgument("affinity_cookie_name")]
    public TerraformValue<string>? AffinityCookieName
    {
        get => new TerraformReference<string>(this, "affinity_cookie_name");
        set => SetArgument("affinity_cookie_name", value);
    }

    /// <summary>
    /// The cookie_based_affinity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookieBasedAffinity is required")]
    [TerraformArgument("cookie_based_affinity")]
    public required TerraformValue<string> CookieBasedAffinity
    {
        get => new TerraformReference<string>(this, "cookie_based_affinity");
        set => SetArgument("cookie_based_affinity", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformArgument("host_name")]
    public TerraformValue<string>? HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformArgument("path")]
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The pick_host_name_from_backend_address attribute.
    /// </summary>
    [TerraformArgument("pick_host_name_from_backend_address")]
    public TerraformValue<bool>? PickHostNameFromBackendAddress
    {
        get => new TerraformReference<bool>(this, "pick_host_name_from_backend_address");
        set => SetArgument("pick_host_name_from_backend_address", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformArgument("port")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }


    /// <summary>
    /// The probe_name attribute.
    /// </summary>
    [TerraformArgument("probe_name")]
    public TerraformValue<string>? ProbeName
    {
        get => new TerraformReference<string>(this, "probe_name");
        set => SetArgument("probe_name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformArgument("protocol")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The request_timeout attribute.
    /// </summary>
    [TerraformArgument("request_timeout")]
    public TerraformValue<double>? RequestTimeout
    {
        get => new TerraformReference<double>(this, "request_timeout");
        set => SetArgument("request_timeout", value);
    }

    /// <summary>
    /// The trusted_root_certificate_names attribute.
    /// </summary>
    [TerraformArgument("trusted_root_certificate_names")]
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
    [TerraformArgument("custom_error_page_url")]
    public required TerraformValue<string> CustomErrorPageUrl
    {
        get => new TerraformReference<string>(this, "custom_error_page_url");
        set => SetArgument("custom_error_page_url", value);
    }


    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    [TerraformArgument("status_code")]
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformArgument("private_ip_address")]
    public TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    [TerraformArgument("private_ip_address_allocation")]
    public TerraformValue<string>? PrivateIpAddressAllocation
    {
        get => new TerraformReference<string>(this, "private_ip_address_allocation");
        set => SetArgument("private_ip_address_allocation", value);
    }


    /// <summary>
    /// The private_link_configuration_name attribute.
    /// </summary>
    [TerraformArgument("private_link_configuration_name")]
    public TerraformValue<string>? PrivateLinkConfigurationName
    {
        get => new TerraformReference<string>(this, "private_link_configuration_name");
        set => SetArgument("private_link_configuration_name", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformArgument("public_ip_address_id")]
    public TerraformValue<string>? PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformArgument("subnet_id")]
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformArgument("port")]
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
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
public class AzurermApplicationGatewayGlobalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "global";

    /// <summary>
    /// The request_buffering_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestBufferingEnabled is required")]
    [TerraformArgument("request_buffering_enabled")]
    public required TerraformValue<bool> RequestBufferingEnabled
    {
        get => new TerraformReference<bool>(this, "request_buffering_enabled");
        set => SetArgument("request_buffering_enabled", value);
    }

    /// <summary>
    /// The response_buffering_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseBufferingEnabled is required")]
    [TerraformArgument("response_buffering_enabled")]
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
    [TerraformArgument("firewall_policy_id")]
    public TerraformValue<string>? FirewallPolicyId
    {
        get => new TerraformReference<string>(this, "firewall_policy_id");
        set => SetArgument("firewall_policy_id", value);
    }


    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    [TerraformArgument("frontend_ip_configuration_name")]
    public required TerraformValue<string> FrontendIpConfigurationName
    {
        get => new TerraformReference<string>(this, "frontend_ip_configuration_name");
        set => SetArgument("frontend_ip_configuration_name", value);
    }


    /// <summary>
    /// The frontend_port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPortName is required")]
    [TerraformArgument("frontend_port_name")]
    public required TerraformValue<string> FrontendPortName
    {
        get => new TerraformReference<string>(this, "frontend_port_name");
        set => SetArgument("frontend_port_name", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformArgument("host_name")]
    public TerraformValue<string>? HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The host_names attribute.
    /// </summary>
    [TerraformArgument("host_names")]
    public TerraformSet<string>? HostNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "host_names").ResolveNodes(ctx));
        set => SetArgument("host_names", value);
    }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformArgument("protocol")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The require_sni attribute.
    /// </summary>
    [TerraformArgument("require_sni")]
    public TerraformValue<bool>? RequireSni
    {
        get => new TerraformReference<bool>(this, "require_sni");
        set => SetArgument("require_sni", value);
    }


    /// <summary>
    /// The ssl_certificate_name attribute.
    /// </summary>
    [TerraformArgument("ssl_certificate_name")]
    public TerraformValue<string>? SslCertificateName
    {
        get => new TerraformReference<string>(this, "ssl_certificate_name");
        set => SetArgument("ssl_certificate_name", value);
    }


    /// <summary>
    /// The ssl_profile_name attribute.
    /// </summary>
    [TerraformArgument("ssl_profile_name")]
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
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
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
    [TerraformArgument("host")]
    public TerraformValue<string>? Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }


    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformArgument("interval")]
    public required TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The minimum_servers attribute.
    /// </summary>
    [TerraformArgument("minimum_servers")]
    public TerraformValue<double>? MinimumServers
    {
        get => new TerraformReference<double>(this, "minimum_servers");
        set => SetArgument("minimum_servers", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformArgument("path")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The pick_host_name_from_backend_http_settings attribute.
    /// </summary>
    [TerraformArgument("pick_host_name_from_backend_http_settings")]
    public TerraformValue<bool>? PickHostNameFromBackendHttpSettings
    {
        get => new TerraformReference<bool>(this, "pick_host_name_from_backend_http_settings");
        set => SetArgument("pick_host_name_from_backend_http_settings", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformArgument("port")]
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformArgument("protocol")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    [TerraformArgument("timeout")]
    public required TerraformValue<double> Timeout
    {
        get => new TerraformReference<double>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnhealthyThreshold is required")]
    [TerraformArgument("unhealthy_threshold")]
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
    /// The include_path attribute.
    /// </summary>
    [TerraformArgument("include_path")]
    public TerraformValue<bool>? IncludePath
    {
        get => new TerraformReference<bool>(this, "include_path");
        set => SetArgument("include_path", value);
    }

    /// <summary>
    /// The include_query_string attribute.
    /// </summary>
    [TerraformArgument("include_query_string")]
    public TerraformValue<bool>? IncludeQueryString
    {
        get => new TerraformReference<bool>(this, "include_query_string");
        set => SetArgument("include_query_string", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The redirect_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectType is required")]
    [TerraformArgument("redirect_type")]
    public required TerraformValue<string> RedirectType
    {
        get => new TerraformReference<string>(this, "redirect_type");
        set => SetArgument("redirect_type", value);
    }


    /// <summary>
    /// The target_listener_name attribute.
    /// </summary>
    [TerraformArgument("target_listener_name")]
    public TerraformValue<string>? TargetListenerName
    {
        get => new TerraformReference<string>(this, "target_listener_name");
        set => SetArgument("target_listener_name", value);
    }

    /// <summary>
    /// The target_url attribute.
    /// </summary>
    [TerraformArgument("target_url")]
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
    /// The backend_address_pool_name attribute.
    /// </summary>
    [TerraformArgument("backend_address_pool_name")]
    public TerraformValue<string>? BackendAddressPoolName
    {
        get => new TerraformReference<string>(this, "backend_address_pool_name");
        set => SetArgument("backend_address_pool_name", value);
    }


    /// <summary>
    /// The backend_http_settings_name attribute.
    /// </summary>
    [TerraformArgument("backend_http_settings_name")]
    public TerraformValue<string>? BackendHttpSettingsName
    {
        get => new TerraformReference<string>(this, "backend_http_settings_name");
        set => SetArgument("backend_http_settings_name", value);
    }


    /// <summary>
    /// The http_listener_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpListenerName is required")]
    [TerraformArgument("http_listener_name")]
    public required TerraformValue<string> HttpListenerName
    {
        get => new TerraformReference<string>(this, "http_listener_name");
        set => SetArgument("http_listener_name", value);
    }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformArgument("priority")]
    public TerraformValue<double>? Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }


    /// <summary>
    /// The redirect_configuration_name attribute.
    /// </summary>
    [TerraformArgument("redirect_configuration_name")]
    public TerraformValue<string>? RedirectConfigurationName
    {
        get => new TerraformReference<string>(this, "redirect_configuration_name");
        set => SetArgument("redirect_configuration_name", value);
    }


    /// <summary>
    /// The rewrite_rule_set_name attribute.
    /// </summary>
    [TerraformArgument("rewrite_rule_set_name")]
    public TerraformValue<string>? RewriteRuleSetName
    {
        get => new TerraformReference<string>(this, "rewrite_rule_set_name");
        set => SetArgument("rewrite_rule_set_name", value);
    }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    [TerraformArgument("rule_type")]
    public required TerraformValue<string> RuleType
    {
        get => new TerraformReference<string>(this, "rule_type");
        set => SetArgument("rule_type", value);
    }


    /// <summary>
    /// The url_path_map_name attribute.
    /// </summary>
    [TerraformArgument("url_path_map_name")]
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
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
    [TerraformArgument("capacity")]
    public TerraformValue<double>? Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformArgument("tier")]
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
    [TerraformArgument("data")]
    public TerraformValue<string>? Data
    {
        get => new TerraformReference<string>(this, "data");
        set => SetArgument("data", value);
    }


    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_secret_id")]
    public TerraformValue<string>? KeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformArgument("password")]
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
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
    [TerraformArgument("cipher_suites")]
    public TerraformList<string>? CipherSuites
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cipher_suites").ResolveNodes(ctx));
        set => SetArgument("cipher_suites", value);
    }

    /// <summary>
    /// The disabled_protocols attribute.
    /// </summary>
    [TerraformArgument("disabled_protocols")]
    public TerraformList<string>? DisabledProtocols
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "disabled_protocols").ResolveNodes(ctx));
        set => SetArgument("disabled_protocols", value);
    }

    /// <summary>
    /// The min_protocol_version attribute.
    /// </summary>
    [TerraformArgument("min_protocol_version")]
    public TerraformValue<string>? MinProtocolVersion
    {
        get => new TerraformReference<string>(this, "min_protocol_version");
        set => SetArgument("min_protocol_version", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    [TerraformArgument("policy_name")]
    public TerraformValue<string>? PolicyName
    {
        get => new TerraformReference<string>(this, "policy_name");
        set => SetArgument("policy_name", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformArgument("policy_type")]
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The trusted_client_certificate_names attribute.
    /// </summary>
    [TerraformArgument("trusted_client_certificate_names")]
    public TerraformList<string>? TrustedClientCertificateNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "trusted_client_certificate_names").ResolveNodes(ctx));
        set => SetArgument("trusted_client_certificate_names", value);
    }

    /// <summary>
    /// The verify_client_cert_issuer_dn attribute.
    /// </summary>
    [TerraformArgument("verify_client_cert_issuer_dn")]
    public TerraformValue<bool>? VerifyClientCertIssuerDn
    {
        get => new TerraformReference<bool>(this, "verify_client_cert_issuer_dn");
        set => SetArgument("verify_client_cert_issuer_dn", value);
    }

    /// <summary>
    /// The verify_client_certificate_revocation attribute.
    /// </summary>
    [TerraformArgument("verify_client_certificate_revocation")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
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
    [TerraformArgument("data")]
    public required TerraformValue<string> Data
    {
        get => new TerraformReference<string>(this, "data");
        set => SetArgument("data", value);
    }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
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
    [TerraformArgument("data")]
    public TerraformValue<string>? Data
    {
        get => new TerraformReference<string>(this, "data");
        set => SetArgument("data", value);
    }


    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_secret_id")]
    public TerraformValue<string>? KeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
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
    /// The default_backend_address_pool_name attribute.
    /// </summary>
    [TerraformArgument("default_backend_address_pool_name")]
    public TerraformValue<string>? DefaultBackendAddressPoolName
    {
        get => new TerraformReference<string>(this, "default_backend_address_pool_name");
        set => SetArgument("default_backend_address_pool_name", value);
    }


    /// <summary>
    /// The default_backend_http_settings_name attribute.
    /// </summary>
    [TerraformArgument("default_backend_http_settings_name")]
    public TerraformValue<string>? DefaultBackendHttpSettingsName
    {
        get => new TerraformReference<string>(this, "default_backend_http_settings_name");
        set => SetArgument("default_backend_http_settings_name", value);
    }


    /// <summary>
    /// The default_redirect_configuration_name attribute.
    /// </summary>
    [TerraformArgument("default_redirect_configuration_name")]
    public TerraformValue<string>? DefaultRedirectConfigurationName
    {
        get => new TerraformReference<string>(this, "default_redirect_configuration_name");
        set => SetArgument("default_redirect_configuration_name", value);
    }


    /// <summary>
    /// The default_rewrite_rule_set_name attribute.
    /// </summary>
    [TerraformArgument("default_rewrite_rule_set_name")]
    public TerraformValue<string>? DefaultRewriteRuleSetName
    {
        get => new TerraformReference<string>(this, "default_rewrite_rule_set_name");
        set => SetArgument("default_rewrite_rule_set_name", value);
    }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
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
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The file_upload_limit_mb attribute.
    /// </summary>
    [TerraformArgument("file_upload_limit_mb")]
    public TerraformValue<double>? FileUploadLimitMb
    {
        get => new TerraformReference<double>(this, "file_upload_limit_mb");
        set => SetArgument("file_upload_limit_mb", value);
    }

    /// <summary>
    /// The firewall_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallMode is required")]
    [TerraformArgument("firewall_mode")]
    public required TerraformValue<string> FirewallMode
    {
        get => new TerraformReference<string>(this, "firewall_mode");
        set => SetArgument("firewall_mode", value);
    }

    /// <summary>
    /// The max_request_body_size_kb attribute.
    /// </summary>
    [TerraformArgument("max_request_body_size_kb")]
    public TerraformValue<double>? MaxRequestBodySizeKb
    {
        get => new TerraformReference<double>(this, "max_request_body_size_kb");
        set => SetArgument("max_request_body_size_kb", value);
    }

    /// <summary>
    /// The request_body_check attribute.
    /// </summary>
    [TerraformArgument("request_body_check")]
    public TerraformValue<bool>? RequestBodyCheck
    {
        get => new TerraformReference<bool>(this, "request_body_check");
        set => SetArgument("request_body_check", value);
    }

    /// <summary>
    /// The rule_set_type attribute.
    /// </summary>
    [TerraformArgument("rule_set_type")]
    public TerraformValue<string>? RuleSetType
    {
        get => new TerraformReference<string>(this, "rule_set_type");
        set => SetArgument("rule_set_type", value);
    }

    /// <summary>
    /// The rule_set_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleSetVersion is required")]
    [TerraformArgument("rule_set_version")]
    public required TerraformValue<string> RuleSetVersion
    {
        get => new TerraformReference<string>(this, "rule_set_version");
        set => SetArgument("rule_set_version", value);
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
    }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    [TerraformArgument("enable_http2")]
    public TerraformValue<bool>? EnableHttp2
    {
        get => new TerraformReference<bool>(this, "enable_http2");
        set => SetArgument("enable_http2", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformArgument("fips_enabled")]
    public TerraformValue<bool>? FipsEnabled
    {
        get => new TerraformReference<bool>(this, "fips_enabled");
        set => SetArgument("fips_enabled", value);
    }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformArgument("firewall_policy_id")]
    public TerraformValue<string>? FirewallPolicyId
    {
        get => new TerraformReference<string>(this, "firewall_policy_id");
        set => SetArgument("firewall_policy_id", value);
    }

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    [TerraformArgument("force_firewall_policy_association")]
    public TerraformValue<bool>? ForceFirewallPolicyAssociation
    {
        get => new TerraformReference<bool>(this, "force_firewall_policy_association");
        set => SetArgument("force_firewall_policy_association", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// Block for authentication_certificate.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("authentication_certificate")]
    public TerraformList<AzurermApplicationGatewayAuthenticationCertificateBlock> AuthenticationCertificate { get; set; } = new();

    /// <summary>
    /// Block for autoscale_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleConfiguration block(s) allowed")]
    [TerraformArgument("autoscale_configuration")]
    public TerraformList<AzurermApplicationGatewayAutoscaleConfigurationBlock> AutoscaleConfiguration { get; set; } = new();

    /// <summary>
    /// Block for backend_address_pool.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendAddressPool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendAddressPool block(s) required")]
    [TerraformArgument("backend_address_pool")]
    public required TerraformSet<AzurermApplicationGatewayBackendAddressPoolBlock> BackendAddressPool { get; set; } = new();

    /// <summary>
    /// Block for backend_http_settings.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendHttpSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendHttpSettings block(s) required")]
    [TerraformArgument("backend_http_settings")]
    public required TerraformSet<AzurermApplicationGatewayBackendHttpSettingsBlock> BackendHttpSettings { get; set; } = new();

    /// <summary>
    /// Block for custom_error_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("custom_error_configuration")]
    public TerraformList<AzurermApplicationGatewayCustomErrorConfigurationBlock> CustomErrorConfiguration { get; set; } = new();

    /// <summary>
    /// Block for frontend_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendIpConfiguration block(s) required")]
    [TerraformArgument("frontend_ip_configuration")]
    public required TerraformList<AzurermApplicationGatewayFrontendIpConfigurationBlock> FrontendIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for frontend_port.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendPort block(s) required")]
    [TerraformArgument("frontend_port")]
    public required TerraformSet<AzurermApplicationGatewayFrontendPortBlock> FrontendPort { get; set; } = new();

    /// <summary>
    /// Block for gateway_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayIpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GatewayIpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 GatewayIpConfiguration block(s) allowed")]
    [TerraformArgument("gateway_ip_configuration")]
    public required TerraformList<AzurermApplicationGatewayGatewayIpConfigurationBlock> GatewayIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for global.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Global block(s) allowed")]
    [TerraformArgument("global")]
    public TerraformList<AzurermApplicationGatewayGlobalBlock> Global { get; set; } = new();

    /// <summary>
    /// Block for http_listener.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpListener is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HttpListener block(s) required")]
    [TerraformArgument("http_listener")]
    public required TerraformSet<AzurermApplicationGatewayHttpListenerBlock> HttpListener { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermApplicationGatewayIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for private_link_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("private_link_configuration")]
    public TerraformSet<AzurermApplicationGatewayPrivateLinkConfigurationBlock> PrivateLinkConfiguration { get; set; } = new();

    /// <summary>
    /// Block for probe.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("probe")]
    public TerraformSet<AzurermApplicationGatewayProbeBlock> Probe { get; set; } = new();

    /// <summary>
    /// Block for redirect_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("redirect_configuration")]
    public TerraformSet<AzurermApplicationGatewayRedirectConfigurationBlock> RedirectConfiguration { get; set; } = new();

    /// <summary>
    /// Block for request_routing_rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestRoutingRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RequestRoutingRule block(s) required")]
    [TerraformArgument("request_routing_rule")]
    public required TerraformSet<AzurermApplicationGatewayRequestRoutingRuleBlock> RequestRoutingRule { get; set; } = new();

    /// <summary>
    /// Block for rewrite_rule_set.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("rewrite_rule_set")]
    public TerraformList<AzurermApplicationGatewayRewriteRuleSetBlock> RewriteRuleSet { get; set; } = new();

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformArgument("sku")]
    public required TerraformList<AzurermApplicationGatewaySkuBlock> Sku { get; set; } = new();

    /// <summary>
    /// Block for ssl_certificate.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("ssl_certificate")]
    public TerraformSet<AzurermApplicationGatewaySslCertificateBlock> SslCertificate { get; set; } = new();

    /// <summary>
    /// Block for ssl_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslPolicy block(s) allowed")]
    [TerraformArgument("ssl_policy")]
    public TerraformList<AzurermApplicationGatewaySslPolicyBlock> SslPolicy { get; set; } = new();

    /// <summary>
    /// Block for ssl_profile.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("ssl_profile")]
    public TerraformList<AzurermApplicationGatewaySslProfileBlock> SslProfile { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApplicationGatewayTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for trusted_client_certificate.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("trusted_client_certificate")]
    public TerraformList<AzurermApplicationGatewayTrustedClientCertificateBlock> TrustedClientCertificate { get; set; } = new();

    /// <summary>
    /// Block for trusted_root_certificate.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("trusted_root_certificate")]
    public TerraformList<AzurermApplicationGatewayTrustedRootCertificateBlock> TrustedRootCertificate { get; set; } = new();

    /// <summary>
    /// Block for url_path_map.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("url_path_map")]
    public TerraformList<AzurermApplicationGatewayUrlPathMapBlock> UrlPathMap { get; set; } = new();

    /// <summary>
    /// Block for waf_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WafConfiguration block(s) allowed")]
    [TerraformArgument("waf_configuration")]
    public TerraformList<AzurermApplicationGatewayWafConfigurationBlock> WafConfiguration { get; set; } = new();

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    [TerraformArgument("private_endpoint_connection")]
    public TerraformSet<object> PrivateEndpointConnection
    {
        get => TerraformSet<object>.Lazy(ctx => new TerraformReference<TerraformSet<object>>(this, "private_endpoint_connection").ResolveNodes(ctx));
    }

}
