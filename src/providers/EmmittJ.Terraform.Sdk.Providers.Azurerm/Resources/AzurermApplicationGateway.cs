using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for authentication_certificate in AzurermApplicationGateway.
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
        get => GetArgument<TerraformValue<string>>("data");
        set => SetArgument("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for autoscale_configuration in AzurermApplicationGateway.
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
        get => GetArgument<TerraformValue<double>>("max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformValue<double> MinCapacity
    {
        get => GetArgument<TerraformValue<double>>("min_capacity");
        set => SetArgument("min_capacity", value);
    }

}


/// <summary>
/// Block type for backend_address_pool in AzurermApplicationGateway.
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
        get => GetArgument<TerraformSet<string>>("fqdns");
        set => SetArgument("fqdns", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public TerraformSet<string>? IpAddresses
    {
        get => GetArgument<TerraformSet<string>>("ip_addresses");
        set => SetArgument("ip_addresses", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for backend_http_settings in AzurermApplicationGateway.
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
        get => GetArgument<TerraformValue<string>>("affinity_cookie_name");
        set => SetArgument("affinity_cookie_name", value);
    }

    /// <summary>
    /// The cookie_based_affinity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookieBasedAffinity is required")]
    public required TerraformValue<string> CookieBasedAffinity
    {
        get => GetArgument<TerraformValue<string>>("cookie_based_affinity");
        set => SetArgument("cookie_based_affinity", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformValue<string>? HostName
    {
        get => GetArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The pick_host_name_from_backend_address attribute.
    /// </summary>
    public TerraformValue<bool>? PickHostNameFromBackendAddress
    {
        get => GetArgument<TerraformValue<bool>>("pick_host_name_from_backend_address");
        set => SetArgument("pick_host_name_from_backend_address", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    public TerraformValue<string> ProbeId
        => AsReference("probe_id");

    /// <summary>
    /// The probe_name attribute.
    /// </summary>
    public TerraformValue<string>? ProbeName
    {
        get => GetArgument<TerraformValue<string>>("probe_name");
        set => SetArgument("probe_name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The request_timeout attribute.
    /// </summary>
    public TerraformValue<double>? RequestTimeout
    {
        get => GetArgument<TerraformValue<double>>("request_timeout");
        set => SetArgument("request_timeout", value);
    }

    /// <summary>
    /// The trusted_root_certificate_names attribute.
    /// </summary>
    public TerraformList<string>? TrustedRootCertificateNames
    {
        get => GetArgument<TerraformList<string>>("trusted_root_certificate_names");
        set => SetArgument("trusted_root_certificate_names", value);
    }

    /// <summary>
    /// AuthenticationCertificate block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationGatewayBackendHttpSettingsBlockAuthenticationCertificateBlock>? AuthenticationCertificate
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayBackendHttpSettingsBlockAuthenticationCertificateBlock>>("authentication_certificate");
        set => SetArgument("authentication_certificate", value);
    }

    /// <summary>
    /// ConnectionDraining block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionDraining block(s) allowed")]
    public TerraformList<AzurermApplicationGatewayBackendHttpSettingsBlockConnectionDrainingBlock>? ConnectionDraining
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayBackendHttpSettingsBlockConnectionDrainingBlock>>("connection_draining");
        set => SetArgument("connection_draining", value);
    }

}

/// <summary>
/// Block type for authentication_certificate in AzurermApplicationGatewayBackendHttpSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayBackendHttpSettingsBlockAuthenticationCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication_certificate";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for connection_draining in AzurermApplicationGatewayBackendHttpSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayBackendHttpSettingsBlockConnectionDrainingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_draining";

    /// <summary>
    /// The drain_timeout_sec attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DrainTimeoutSec is required")]
    public required TerraformValue<double> DrainTimeoutSec
    {
        get => GetArgument<TerraformValue<double>>("drain_timeout_sec");
        set => SetArgument("drain_timeout_sec", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for custom_error_configuration in AzurermApplicationGateway.
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
        get => GetArgument<TerraformValue<string>>("custom_error_page_url");
        set => SetArgument("custom_error_page_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformValue<string> StatusCode
    {
        get => GetArgument<TerraformValue<string>>("status_code");
        set => SetArgument("status_code", value);
    }

}


/// <summary>
/// Block type for frontend_ip_configuration in AzurermApplicationGateway.
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
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAddress
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAddressAllocation
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address_allocation");
        set => SetArgument("private_ip_address_allocation", value);
    }

    /// <summary>
    /// The private_link_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> PrivateLinkConfigurationId
        => AsReference("private_link_configuration_id");

    /// <summary>
    /// The private_link_configuration_name attribute.
    /// </summary>
    public TerraformValue<string>? PrivateLinkConfigurationName
    {
        get => GetArgument<TerraformValue<string>>("private_link_configuration_name");
        set => SetArgument("private_link_configuration_name", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpAddressId
    {
        get => GetArgument<TerraformValue<string>>("public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for frontend_port in AzurermApplicationGateway.
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
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}


/// <summary>
/// Block type for gateway_ip_configuration in AzurermApplicationGateway.
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
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for global in AzurermApplicationGateway.
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
        get => GetArgument<TerraformValue<bool>>("request_buffering_enabled");
        set => SetArgument("request_buffering_enabled", value);
    }

    /// <summary>
    /// The response_buffering_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseBufferingEnabled is required")]
    public required TerraformValue<bool> ResponseBufferingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("response_buffering_enabled");
        set => SetArgument("response_buffering_enabled", value);
    }

}


/// <summary>
/// Block type for http_listener in AzurermApplicationGateway.
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
        get => GetArgument<TerraformValue<string>>("firewall_policy_id");
        set => SetArgument("firewall_policy_id", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> FrontendIpConfigurationId
        => AsReference("frontend_ip_configuration_id");

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    public required TerraformValue<string> FrontendIpConfigurationName
    {
        get => GetArgument<TerraformValue<string>>("frontend_ip_configuration_name");
        set => SetArgument("frontend_ip_configuration_name", value);
    }

    /// <summary>
    /// The frontend_port_id attribute.
    /// </summary>
    public TerraformValue<string> FrontendPortId
        => AsReference("frontend_port_id");

    /// <summary>
    /// The frontend_port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPortName is required")]
    public required TerraformValue<string> FrontendPortName
    {
        get => GetArgument<TerraformValue<string>>("frontend_port_name");
        set => SetArgument("frontend_port_name", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformValue<string>? HostName
    {
        get => GetArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The host_names attribute.
    /// </summary>
    public TerraformSet<string>? HostNames
    {
        get => GetArgument<TerraformSet<string>>("host_names");
        set => SetArgument("host_names", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The require_sni attribute.
    /// </summary>
    public TerraformValue<bool>? RequireSni
    {
        get => GetArgument<TerraformValue<bool>>("require_sni");
        set => SetArgument("require_sni", value);
    }

    /// <summary>
    /// The ssl_certificate_id attribute.
    /// </summary>
    public TerraformValue<string> SslCertificateId
        => AsReference("ssl_certificate_id");

    /// <summary>
    /// The ssl_certificate_name attribute.
    /// </summary>
    public TerraformValue<string>? SslCertificateName
    {
        get => GetArgument<TerraformValue<string>>("ssl_certificate_name");
        set => SetArgument("ssl_certificate_name", value);
    }

    /// <summary>
    /// The ssl_profile_id attribute.
    /// </summary>
    public TerraformValue<string> SslProfileId
        => AsReference("ssl_profile_id");

    /// <summary>
    /// The ssl_profile_name attribute.
    /// </summary>
    public TerraformValue<string>? SslProfileName
    {
        get => GetArgument<TerraformValue<string>>("ssl_profile_name");
        set => SetArgument("ssl_profile_name", value);
    }

    /// <summary>
    /// CustomErrorConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationGatewayHttpListenerBlockCustomErrorConfigurationBlock>? CustomErrorConfiguration
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayHttpListenerBlockCustomErrorConfigurationBlock>>("custom_error_configuration");
        set => SetArgument("custom_error_configuration", value);
    }

}

/// <summary>
/// Block type for custom_error_configuration in AzurermApplicationGatewayHttpListenerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayHttpListenerBlockCustomErrorConfigurationBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("custom_error_page_url");
        set => SetArgument("custom_error_page_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformValue<string> StatusCode
    {
        get => GetArgument<TerraformValue<string>>("status_code");
        set => SetArgument("status_code", value);
    }

}


/// <summary>
/// Block type for identity in AzurermApplicationGateway.
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
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for private_link_configuration in AzurermApplicationGateway.
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
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// IpConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    public required TerraformList<AzurermApplicationGatewayPrivateLinkConfigurationBlockIpConfigurationBlock> IpConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermApplicationGatewayPrivateLinkConfigurationBlockIpConfigurationBlock>>("ip_configuration");
        set => SetArgument("ip_configuration", value);
    }

}

/// <summary>
/// Block type for ip_configuration in AzurermApplicationGatewayPrivateLinkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayPrivateLinkConfigurationBlockIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_configuration";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Primary is required")]
    public required TerraformValue<bool> Primary
    {
        get => GetArgument<TerraformValue<bool>>("primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAddress
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddressAllocation is required")]
    public required TerraformValue<string> PrivateIpAddressAllocation
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address_allocation");
        set => SetArgument("private_ip_address_allocation", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for probe in AzurermApplicationGateway.
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
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => GetArgument<TerraformValue<double>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The minimum_servers attribute.
    /// </summary>
    public TerraformValue<double>? MinimumServers
    {
        get => GetArgument<TerraformValue<double>>("minimum_servers");
        set => SetArgument("minimum_servers", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The pick_host_name_from_backend_http_settings attribute.
    /// </summary>
    public TerraformValue<bool>? PickHostNameFromBackendHttpSettings
    {
        get => GetArgument<TerraformValue<bool>>("pick_host_name_from_backend_http_settings");
        set => SetArgument("pick_host_name_from_backend_http_settings", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    public required TerraformValue<double> Timeout
    {
        get => GetArgument<TerraformValue<double>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnhealthyThreshold is required")]
    public required TerraformValue<double> UnhealthyThreshold
    {
        get => GetArgument<TerraformValue<double>>("unhealthy_threshold");
        set => SetArgument("unhealthy_threshold", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public TerraformList<AzurermApplicationGatewayProbeBlockMatchBlock>? Match
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayProbeBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AzurermApplicationGatewayProbeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayProbeBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformValue<string>? Body
    {
        get => GetArgument<TerraformValue<string>>("body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public TerraformList<string>? StatusCode
    {
        get => GetArgument<TerraformList<string>>("status_code");
        set => SetArgument("status_code", value);
    }

}


/// <summary>
/// Block type for redirect_configuration in AzurermApplicationGateway.
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
        => AsReference("id");

    /// <summary>
    /// The include_path attribute.
    /// </summary>
    public TerraformValue<bool>? IncludePath
    {
        get => GetArgument<TerraformValue<bool>>("include_path");
        set => SetArgument("include_path", value);
    }

    /// <summary>
    /// The include_query_string attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeQueryString
    {
        get => GetArgument<TerraformValue<bool>>("include_query_string");
        set => SetArgument("include_query_string", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The redirect_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectType is required")]
    public required TerraformValue<string> RedirectType
    {
        get => GetArgument<TerraformValue<string>>("redirect_type");
        set => SetArgument("redirect_type", value);
    }

    /// <summary>
    /// The target_listener_id attribute.
    /// </summary>
    public TerraformValue<string> TargetListenerId
        => AsReference("target_listener_id");

    /// <summary>
    /// The target_listener_name attribute.
    /// </summary>
    public TerraformValue<string>? TargetListenerName
    {
        get => GetArgument<TerraformValue<string>>("target_listener_name");
        set => SetArgument("target_listener_name", value);
    }

    /// <summary>
    /// The target_url attribute.
    /// </summary>
    public TerraformValue<string>? TargetUrl
    {
        get => GetArgument<TerraformValue<string>>("target_url");
        set => SetArgument("target_url", value);
    }

}


/// <summary>
/// Block type for request_routing_rule in AzurermApplicationGateway.
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
        => AsReference("backend_address_pool_id");

    /// <summary>
    /// The backend_address_pool_name attribute.
    /// </summary>
    public TerraformValue<string>? BackendAddressPoolName
    {
        get => GetArgument<TerraformValue<string>>("backend_address_pool_name");
        set => SetArgument("backend_address_pool_name", value);
    }

    /// <summary>
    /// The backend_http_settings_id attribute.
    /// </summary>
    public TerraformValue<string> BackendHttpSettingsId
        => AsReference("backend_http_settings_id");

    /// <summary>
    /// The backend_http_settings_name attribute.
    /// </summary>
    public TerraformValue<string>? BackendHttpSettingsName
    {
        get => GetArgument<TerraformValue<string>>("backend_http_settings_name");
        set => SetArgument("backend_http_settings_name", value);
    }

    /// <summary>
    /// The http_listener_id attribute.
    /// </summary>
    public TerraformValue<string> HttpListenerId
        => AsReference("http_listener_id");

    /// <summary>
    /// The http_listener_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpListenerName is required")]
    public required TerraformValue<string> HttpListenerName
    {
        get => GetArgument<TerraformValue<string>>("http_listener_name");
        set => SetArgument("http_listener_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The redirect_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> RedirectConfigurationId
        => AsReference("redirect_configuration_id");

    /// <summary>
    /// The redirect_configuration_name attribute.
    /// </summary>
    public TerraformValue<string>? RedirectConfigurationName
    {
        get => GetArgument<TerraformValue<string>>("redirect_configuration_name");
        set => SetArgument("redirect_configuration_name", value);
    }

    /// <summary>
    /// The rewrite_rule_set_id attribute.
    /// </summary>
    public TerraformValue<string> RewriteRuleSetId
        => AsReference("rewrite_rule_set_id");

    /// <summary>
    /// The rewrite_rule_set_name attribute.
    /// </summary>
    public TerraformValue<string>? RewriteRuleSetName
    {
        get => GetArgument<TerraformValue<string>>("rewrite_rule_set_name");
        set => SetArgument("rewrite_rule_set_name", value);
    }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    public required TerraformValue<string> RuleType
    {
        get => GetArgument<TerraformValue<string>>("rule_type");
        set => SetArgument("rule_type", value);
    }

    /// <summary>
    /// The url_path_map_id attribute.
    /// </summary>
    public TerraformValue<string> UrlPathMapId
        => AsReference("url_path_map_id");

    /// <summary>
    /// The url_path_map_name attribute.
    /// </summary>
    public TerraformValue<string>? UrlPathMapName
    {
        get => GetArgument<TerraformValue<string>>("url_path_map_name");
        set => SetArgument("url_path_map_name", value);
    }

}


/// <summary>
/// Block type for rewrite_rule_set in AzurermApplicationGateway.
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
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// RewriteRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlock>? RewriteRule
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlock>>("rewrite_rule");
        set => SetArgument("rewrite_rule", value);
    }

}

/// <summary>
/// Block type for rewrite_rule in AzurermApplicationGatewayRewriteRuleSetBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rewrite_rule";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The rule_sequence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleSequence is required")]
    public required TerraformValue<double> RuleSequence
    {
        get => GetArgument<TerraformValue<double>>("rule_sequence");
        set => SetArgument("rule_sequence", value);
    }

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// RequestHeaderConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlockRequestHeaderConfigurationBlock>? RequestHeaderConfiguration
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlockRequestHeaderConfigurationBlock>>("request_header_configuration");
        set => SetArgument("request_header_configuration", value);
    }

    /// <summary>
    /// ResponseHeaderConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlockResponseHeaderConfigurationBlock>? ResponseHeaderConfiguration
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlockResponseHeaderConfigurationBlock>>("response_header_configuration");
        set => SetArgument("response_header_configuration", value);
    }

    /// <summary>
    /// Url block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Url block(s) allowed")]
    public TerraformList<AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlockUrlBlock>? Url
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlockUrlBlock>>("url");
        set => SetArgument("url", value);
    }

}

/// <summary>
/// Block type for condition in AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// The ignore_case attribute.
    /// </summary>
    public TerraformValue<bool>? IgnoreCase
    {
        get => GetArgument<TerraformValue<bool>>("ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// The negate attribute.
    /// </summary>
    public TerraformValue<bool>? Negate
    {
        get => GetArgument<TerraformValue<bool>>("negate");
        set => SetArgument("negate", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => GetArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

    /// <summary>
    /// The variable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Variable is required")]
    public required TerraformValue<string> Variable
    {
        get => GetArgument<TerraformValue<string>>("variable");
        set => SetArgument("variable", value);
    }

}

/// <summary>
/// Block type for request_header_configuration in AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlockRequestHeaderConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_header_configuration";

    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The header_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    public required TerraformValue<string> HeaderValue
    {
        get => GetArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

}

/// <summary>
/// Block type for response_header_configuration in AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlockResponseHeaderConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_header_configuration";

    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The header_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    public required TerraformValue<string> HeaderValue
    {
        get => GetArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

}

/// <summary>
/// Block type for url in AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayRewriteRuleSetBlockRewriteRuleBlockUrlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url";

    /// <summary>
    /// The components attribute.
    /// </summary>
    public TerraformValue<string>? Components
    {
        get => GetArgument<TerraformValue<string>>("components");
        set => SetArgument("components", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    public TerraformValue<string>? QueryString
    {
        get => GetArgument<TerraformValue<string>>("query_string");
        set => SetArgument("query_string", value);
    }

    /// <summary>
    /// The reroute attribute.
    /// </summary>
    public TerraformValue<bool>? Reroute
    {
        get => GetArgument<TerraformValue<bool>>("reroute");
        set => SetArgument("reroute", value);
    }

}


/// <summary>
/// Block type for sku in AzurermApplicationGateway.
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
        get => GetArgument<TerraformValue<double>>("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformValue<string> Tier
    {
        get => GetArgument<TerraformValue<string>>("tier");
        set => SetArgument("tier", value);
    }

}


/// <summary>
/// Block type for ssl_certificate in AzurermApplicationGateway.
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
        get => GetArgument<TerraformValue<string>>("data");
        set => SetArgument("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultSecretId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The public_cert_data attribute.
    /// </summary>
    public TerraformValue<string> PublicCertData
        => AsReference("public_cert_data");

}


/// <summary>
/// Block type for ssl_policy in AzurermApplicationGateway.
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
        get => GetArgument<TerraformList<string>>("cipher_suites");
        set => SetArgument("cipher_suites", value);
    }

    /// <summary>
    /// The disabled_protocols attribute.
    /// </summary>
    public TerraformList<string>? DisabledProtocols
    {
        get => GetArgument<TerraformList<string>>("disabled_protocols");
        set => SetArgument("disabled_protocols", value);
    }

    /// <summary>
    /// The min_protocol_version attribute.
    /// </summary>
    public TerraformValue<string>? MinProtocolVersion
    {
        get => GetArgument<TerraformValue<string>>("min_protocol_version");
        set => SetArgument("min_protocol_version", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    public TerraformValue<string>? PolicyName
    {
        get => GetArgument<TerraformValue<string>>("policy_name");
        set => SetArgument("policy_name", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformValue<string>? PolicyType
    {
        get => GetArgument<TerraformValue<string>>("policy_type");
        set => SetArgument("policy_type", value);
    }

}


/// <summary>
/// Block type for ssl_profile in AzurermApplicationGateway.
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
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The trusted_client_certificate_names attribute.
    /// </summary>
    public TerraformList<string>? TrustedClientCertificateNames
    {
        get => GetArgument<TerraformList<string>>("trusted_client_certificate_names");
        set => SetArgument("trusted_client_certificate_names", value);
    }

    /// <summary>
    /// The verify_client_cert_issuer_dn attribute.
    /// </summary>
    public TerraformValue<bool>? VerifyClientCertIssuerDn
    {
        get => GetArgument<TerraformValue<bool>>("verify_client_cert_issuer_dn");
        set => SetArgument("verify_client_cert_issuer_dn", value);
    }

    /// <summary>
    /// The verify_client_certificate_revocation attribute.
    /// </summary>
    public TerraformValue<string>? VerifyClientCertificateRevocation
    {
        get => GetArgument<TerraformValue<string>>("verify_client_certificate_revocation");
        set => SetArgument("verify_client_certificate_revocation", value);
    }

    /// <summary>
    /// SslPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslPolicy block(s) allowed")]
    public TerraformList<AzurermApplicationGatewaySslProfileBlockSslPolicyBlock>? SslPolicy
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewaySslProfileBlockSslPolicyBlock>>("ssl_policy");
        set => SetArgument("ssl_policy", value);
    }

}

/// <summary>
/// Block type for ssl_policy in AzurermApplicationGatewaySslProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewaySslProfileBlockSslPolicyBlock : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("cipher_suites");
        set => SetArgument("cipher_suites", value);
    }

    /// <summary>
    /// The disabled_protocols attribute.
    /// </summary>
    public TerraformList<string>? DisabledProtocols
    {
        get => GetArgument<TerraformList<string>>("disabled_protocols");
        set => SetArgument("disabled_protocols", value);
    }

    /// <summary>
    /// The min_protocol_version attribute.
    /// </summary>
    public TerraformValue<string>? MinProtocolVersion
    {
        get => GetArgument<TerraformValue<string>>("min_protocol_version");
        set => SetArgument("min_protocol_version", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    public TerraformValue<string>? PolicyName
    {
        get => GetArgument<TerraformValue<string>>("policy_name");
        set => SetArgument("policy_name", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformValue<string>? PolicyType
    {
        get => GetArgument<TerraformValue<string>>("policy_type");
        set => SetArgument("policy_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermApplicationGateway.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for trusted_client_certificate in AzurermApplicationGateway.
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
        get => GetArgument<TerraformValue<string>>("data");
        set => SetArgument("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for trusted_root_certificate in AzurermApplicationGateway.
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
        get => GetArgument<TerraformValue<string>>("data");
        set => SetArgument("data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultSecretId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for url_path_map in AzurermApplicationGateway.
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
        => AsReference("default_backend_address_pool_id");

    /// <summary>
    /// The default_backend_address_pool_name attribute.
    /// </summary>
    public TerraformValue<string>? DefaultBackendAddressPoolName
    {
        get => GetArgument<TerraformValue<string>>("default_backend_address_pool_name");
        set => SetArgument("default_backend_address_pool_name", value);
    }

    /// <summary>
    /// The default_backend_http_settings_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultBackendHttpSettingsId
        => AsReference("default_backend_http_settings_id");

    /// <summary>
    /// The default_backend_http_settings_name attribute.
    /// </summary>
    public TerraformValue<string>? DefaultBackendHttpSettingsName
    {
        get => GetArgument<TerraformValue<string>>("default_backend_http_settings_name");
        set => SetArgument("default_backend_http_settings_name", value);
    }

    /// <summary>
    /// The default_redirect_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultRedirectConfigurationId
        => AsReference("default_redirect_configuration_id");

    /// <summary>
    /// The default_redirect_configuration_name attribute.
    /// </summary>
    public TerraformValue<string>? DefaultRedirectConfigurationName
    {
        get => GetArgument<TerraformValue<string>>("default_redirect_configuration_name");
        set => SetArgument("default_redirect_configuration_name", value);
    }

    /// <summary>
    /// The default_rewrite_rule_set_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultRewriteRuleSetId
        => AsReference("default_rewrite_rule_set_id");

    /// <summary>
    /// The default_rewrite_rule_set_name attribute.
    /// </summary>
    public TerraformValue<string>? DefaultRewriteRuleSetName
    {
        get => GetArgument<TerraformValue<string>>("default_rewrite_rule_set_name");
        set => SetArgument("default_rewrite_rule_set_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// PathRule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PathRule block(s) required")]
    public required TerraformList<AzurermApplicationGatewayUrlPathMapBlockPathRuleBlock> PathRule
    {
        get => GetRequiredArgument<TerraformList<AzurermApplicationGatewayUrlPathMapBlockPathRuleBlock>>("path_rule");
        set => SetArgument("path_rule", value);
    }

}

/// <summary>
/// Block type for path_rule in AzurermApplicationGatewayUrlPathMapBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayUrlPathMapBlockPathRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "path_rule";

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    public TerraformValue<string> BackendAddressPoolId
        => AsReference("backend_address_pool_id");

    /// <summary>
    /// The backend_address_pool_name attribute.
    /// </summary>
    public TerraformValue<string>? BackendAddressPoolName
    {
        get => GetArgument<TerraformValue<string>>("backend_address_pool_name");
        set => SetArgument("backend_address_pool_name", value);
    }

    /// <summary>
    /// The backend_http_settings_id attribute.
    /// </summary>
    public TerraformValue<string> BackendHttpSettingsId
        => AsReference("backend_http_settings_id");

    /// <summary>
    /// The backend_http_settings_name attribute.
    /// </summary>
    public TerraformValue<string>? BackendHttpSettingsName
    {
        get => GetArgument<TerraformValue<string>>("backend_http_settings_name");
        set => SetArgument("backend_http_settings_name", value);
    }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? FirewallPolicyId
    {
        get => GetArgument<TerraformValue<string>>("firewall_policy_id");
        set => SetArgument("firewall_policy_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    public TerraformList<string>? Paths
    {
        get => GetArgument<TerraformList<string>>("paths");
        set => SetArgument("paths", value);
    }

    /// <summary>
    /// The redirect_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> RedirectConfigurationId
        => AsReference("redirect_configuration_id");

    /// <summary>
    /// The redirect_configuration_name attribute.
    /// </summary>
    public TerraformValue<string>? RedirectConfigurationName
    {
        get => GetArgument<TerraformValue<string>>("redirect_configuration_name");
        set => SetArgument("redirect_configuration_name", value);
    }

    /// <summary>
    /// The rewrite_rule_set_id attribute.
    /// </summary>
    public TerraformValue<string> RewriteRuleSetId
        => AsReference("rewrite_rule_set_id");

    /// <summary>
    /// The rewrite_rule_set_name attribute.
    /// </summary>
    public TerraformValue<string>? RewriteRuleSetName
    {
        get => GetArgument<TerraformValue<string>>("rewrite_rule_set_name");
        set => SetArgument("rewrite_rule_set_name", value);
    }

}


/// <summary>
/// Block type for waf_configuration in AzurermApplicationGateway.
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
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The file_upload_limit_mb attribute.
    /// </summary>
    public TerraformValue<double>? FileUploadLimitMb
    {
        get => GetArgument<TerraformValue<double>>("file_upload_limit_mb");
        set => SetArgument("file_upload_limit_mb", value);
    }

    /// <summary>
    /// The firewall_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallMode is required")]
    public required TerraformValue<string> FirewallMode
    {
        get => GetArgument<TerraformValue<string>>("firewall_mode");
        set => SetArgument("firewall_mode", value);
    }

    /// <summary>
    /// The max_request_body_size_kb attribute.
    /// </summary>
    public TerraformValue<double>? MaxRequestBodySizeKb
    {
        get => GetArgument<TerraformValue<double>>("max_request_body_size_kb");
        set => SetArgument("max_request_body_size_kb", value);
    }

    /// <summary>
    /// The request_body_check attribute.
    /// </summary>
    public TerraformValue<bool>? RequestBodyCheck
    {
        get => GetArgument<TerraformValue<bool>>("request_body_check");
        set => SetArgument("request_body_check", value);
    }

    /// <summary>
    /// The rule_set_type attribute.
    /// </summary>
    public TerraformValue<string>? RuleSetType
    {
        get => GetArgument<TerraformValue<string>>("rule_set_type");
        set => SetArgument("rule_set_type", value);
    }

    /// <summary>
    /// The rule_set_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleSetVersion is required")]
    public required TerraformValue<string> RuleSetVersion
    {
        get => GetArgument<TerraformValue<string>>("rule_set_version");
        set => SetArgument("rule_set_version", value);
    }

    /// <summary>
    /// DisabledRuleGroup block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationGatewayWafConfigurationBlockDisabledRuleGroupBlock>? DisabledRuleGroup
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayWafConfigurationBlockDisabledRuleGroupBlock>>("disabled_rule_group");
        set => SetArgument("disabled_rule_group", value);
    }

    /// <summary>
    /// Exclusion block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationGatewayWafConfigurationBlockExclusionBlock>? Exclusion
    {
        get => GetArgument<TerraformList<AzurermApplicationGatewayWafConfigurationBlockExclusionBlock>>("exclusion");
        set => SetArgument("exclusion", value);
    }

}

/// <summary>
/// Block type for disabled_rule_group in AzurermApplicationGatewayWafConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayWafConfigurationBlockDisabledRuleGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disabled_rule_group";

    /// <summary>
    /// The rule_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleGroupName is required")]
    public required TerraformValue<string> RuleGroupName
    {
        get => GetArgument<TerraformValue<string>>("rule_group_name");
        set => SetArgument("rule_group_name", value);
    }

    /// <summary>
    /// The rules attribute.
    /// </summary>
    public TerraformList<double>? Rules
    {
        get => GetArgument<TerraformList<double>>("rules");
        set => SetArgument("rules", value);
    }

}

/// <summary>
/// Block type for exclusion in AzurermApplicationGatewayWafConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationGatewayWafConfigurationBlockExclusionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusion";

    /// <summary>
    /// The match_variable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchVariable is required")]
    public required TerraformValue<string> MatchVariable
    {
        get => GetArgument<TerraformValue<string>>("match_variable");
        set => SetArgument("match_variable", value);
    }

    /// <summary>
    /// The selector attribute.
    /// </summary>
    public TerraformValue<string>? Selector
    {
        get => GetArgument<TerraformValue<string>>("selector");
        set => SetArgument("selector", value);
    }

    /// <summary>
    /// The selector_match_operator attribute.
    /// </summary>
    public TerraformValue<string>? SelectorMatchOperator
    {
        get => GetArgument<TerraformValue<string>>("selector_match_operator");
        set => SetArgument("selector_match_operator", value);
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
        get => GetArgument<TerraformValue<bool>>("enable_http2");
        set => SetArgument("enable_http2", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FipsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("fips_enabled");
        set => SetArgument("fips_enabled", value);
    }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? FirewallPolicyId
    {
        get => GetArgument<TerraformValue<string>>("firewall_policy_id");
        set => SetArgument("firewall_policy_id", value);
    }

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    public TerraformValue<bool>? ForceFirewallPolicyAssociation
    {
        get => GetArgument<TerraformValue<bool>>("force_firewall_policy_association");
        set => SetArgument("force_firewall_policy_association", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => GetArgument<TerraformSet<string>>("zones");
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> PrivateEndpointConnection
        => AsReference("private_endpoint_connection");

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
