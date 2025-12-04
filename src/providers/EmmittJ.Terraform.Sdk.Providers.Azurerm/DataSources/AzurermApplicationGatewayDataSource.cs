using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApplicationGatewayDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermApplicationGatewayDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_application_gateway Terraform data source.
/// Retrieves information about a azurerm_application_gateway.
/// </summary>
public partial class AzurermApplicationGatewayDataSource(string name) : TerraformDataSource("azurerm_application_gateway", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The authentication_certificate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthenticationCertificate
        => AsReference("authentication_certificate");

    /// <summary>
    /// The autoscale_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoscaleConfiguration
        => AsReference("autoscale_configuration");

    /// <summary>
    /// The backend_address_pool attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BackendAddressPool
        => AsReference("backend_address_pool");

    /// <summary>
    /// The backend_http_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BackendHttpSettings
        => AsReference("backend_http_settings");

    /// <summary>
    /// The custom_error_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomErrorConfiguration
        => AsReference("custom_error_configuration");

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FipsEnabled
        => AsReference("fips_enabled");

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformValue<string> FirewallPolicyId
        => AsReference("firewall_policy_id");

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    public TerraformValue<bool> ForceFirewallPolicyAssociation
        => AsReference("force_firewall_policy_association");

    /// <summary>
    /// The frontend_ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FrontendIpConfiguration
        => AsReference("frontend_ip_configuration");

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FrontendPort
        => AsReference("frontend_port");

    /// <summary>
    /// The gateway_ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> GatewayIpConfiguration
        => AsReference("gateway_ip_configuration");

    /// <summary>
    /// The global attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> GlobalAttribute
        => AsReference("global");

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformValue<bool> Http2Enabled
        => AsReference("http2_enabled");

    /// <summary>
    /// The http_listener attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HttpListener
        => AsReference("http_listener");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateEndpointConnection
        => AsReference("private_endpoint_connection");

    /// <summary>
    /// The private_link_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateLinkConfiguration
        => AsReference("private_link_configuration");

    /// <summary>
    /// The probe attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Probe
        => AsReference("probe");

    /// <summary>
    /// The redirect_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RedirectConfiguration
        => AsReference("redirect_configuration");

    /// <summary>
    /// The request_routing_rule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RequestRoutingRule
        => AsReference("request_routing_rule");

    /// <summary>
    /// The rewrite_rule_set attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RewriteRuleSet
        => AsReference("rewrite_rule_set");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Sku
        => AsReference("sku");

    /// <summary>
    /// The ssl_certificate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SslCertificate
        => AsReference("ssl_certificate");

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SslPolicy
        => AsReference("ssl_policy");

    /// <summary>
    /// The ssl_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SslProfile
        => AsReference("ssl_profile");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The trusted_client_certificate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrustedClientCertificate
        => AsReference("trusted_client_certificate");

    /// <summary>
    /// The trusted_root_certificate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrustedRootCertificate
        => AsReference("trusted_root_certificate");

    /// <summary>
    /// The url_path_map attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UrlPathMap
        => AsReference("url_path_map");

    /// <summary>
    /// The waf_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WafConfiguration
        => AsReference("waf_configuration");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
        => AsReference("zones");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApplicationGatewayDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApplicationGatewayDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
