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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The authentication_certificate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthenticationCertificate
        => CreateReference("authentication_certificate");

    /// <summary>
    /// The autoscale_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoscaleConfiguration
        => CreateReference("autoscale_configuration");

    /// <summary>
    /// The backend_address_pool attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BackendAddressPool
        => CreateReference("backend_address_pool");

    /// <summary>
    /// The backend_http_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BackendHttpSettings
        => CreateReference("backend_http_settings");

    /// <summary>
    /// The custom_error_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomErrorConfiguration
        => CreateReference("custom_error_configuration");

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FipsEnabled
        => CreateReference("fips_enabled");

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformValue<string> FirewallPolicyId
        => CreateReference("firewall_policy_id");

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    public TerraformValue<bool> ForceFirewallPolicyAssociation
        => CreateReference("force_firewall_policy_association");

    /// <summary>
    /// The frontend_ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FrontendIpConfiguration
        => CreateReference("frontend_ip_configuration");

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FrontendPort
        => CreateReference("frontend_port");

    /// <summary>
    /// The gateway_ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> GatewayIpConfiguration
        => CreateReference("gateway_ip_configuration");

    /// <summary>
    /// The global attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> GlobalAttribute
        => CreateReference("global");

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformValue<bool> Http2Enabled
        => CreateReference("http2_enabled");

    /// <summary>
    /// The http_listener attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HttpListener
        => CreateReference("http_listener");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => CreateReference("identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateEndpointConnection
        => CreateReference("private_endpoint_connection");

    /// <summary>
    /// The private_link_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateLinkConfiguration
        => CreateReference("private_link_configuration");

    /// <summary>
    /// The probe attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Probe
        => CreateReference("probe");

    /// <summary>
    /// The redirect_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RedirectConfiguration
        => CreateReference("redirect_configuration");

    /// <summary>
    /// The request_routing_rule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RequestRoutingRule
        => CreateReference("request_routing_rule");

    /// <summary>
    /// The rewrite_rule_set attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RewriteRuleSet
        => CreateReference("rewrite_rule_set");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Sku
        => CreateReference("sku");

    /// <summary>
    /// The ssl_certificate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SslCertificate
        => CreateReference("ssl_certificate");

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SslPolicy
        => CreateReference("ssl_policy");

    /// <summary>
    /// The ssl_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SslProfile
        => CreateReference("ssl_profile");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The trusted_client_certificate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrustedClientCertificate
        => CreateReference("trusted_client_certificate");

    /// <summary>
    /// The trusted_root_certificate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrustedRootCertificate
        => CreateReference("trusted_root_certificate");

    /// <summary>
    /// The url_path_map attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UrlPathMap
        => CreateReference("url_path_map");

    /// <summary>
    /// The waf_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WafConfiguration
        => CreateReference("waf_configuration");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
        => CreateReference("zones");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApplicationGatewayDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApplicationGatewayDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
