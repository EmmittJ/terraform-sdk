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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The authentication_certificate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthenticationCertificate
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "authentication_certificate").ResolveNodes(ctx));
    }

    /// <summary>
    /// The autoscale_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoscaleConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "autoscale_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The backend_address_pool attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BackendAddressPool
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "backend_address_pool").ResolveNodes(ctx));
    }

    /// <summary>
    /// The backend_http_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BackendHttpSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "backend_http_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The custom_error_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomErrorConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "custom_error_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FipsEnabled
    {
        get => new TerraformReference<bool>(this, "fips_enabled");
    }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformValue<string> FirewallPolicyId
    {
        get => new TerraformReference<string>(this, "firewall_policy_id");
    }

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    public TerraformValue<bool> ForceFirewallPolicyAssociation
    {
        get => new TerraformReference<bool>(this, "force_firewall_policy_association");
    }

    /// <summary>
    /// The frontend_ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FrontendIpConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "frontend_ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FrontendPort
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "frontend_port").ResolveNodes(ctx));
    }

    /// <summary>
    /// The gateway_ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> GatewayIpConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "gateway_ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The global attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> GlobalAttribute
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "global").ResolveNodes(ctx));
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformValue<bool> Http2Enabled
    {
        get => new TerraformReference<bool>(this, "http2_enabled");
    }

    /// <summary>
    /// The http_listener attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HttpListener
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "http_listener").ResolveNodes(ctx));
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateEndpointConnection
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "private_endpoint_connection").ResolveNodes(ctx));
    }

    /// <summary>
    /// The private_link_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateLinkConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "private_link_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The probe attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Probe
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "probe").ResolveNodes(ctx));
    }

    /// <summary>
    /// The redirect_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RedirectConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "redirect_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The request_routing_rule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RequestRoutingRule
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "request_routing_rule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The rewrite_rule_set attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RewriteRuleSet
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "rewrite_rule_set").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Sku
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "sku").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ssl_certificate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SslCertificate
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ssl_certificate").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SslPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ssl_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ssl_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SslProfile
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ssl_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The trusted_client_certificate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrustedClientCertificate
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "trusted_client_certificate").ResolveNodes(ctx));
    }

    /// <summary>
    /// The trusted_root_certificate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrustedRootCertificate
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "trusted_root_certificate").ResolveNodes(ctx));
    }

    /// <summary>
    /// The url_path_map attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UrlPathMap
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "url_path_map").ResolveNodes(ctx));
    }

    /// <summary>
    /// The waf_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WafConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "waf_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApplicationGatewayDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApplicationGatewayDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
