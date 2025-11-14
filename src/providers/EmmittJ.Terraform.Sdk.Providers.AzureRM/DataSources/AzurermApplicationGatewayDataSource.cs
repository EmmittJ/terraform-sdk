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
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_application_gateway.
/// </summary>
public class AzurermApplicationGatewayDataSource : TerraformDataSource
{
    public AzurermApplicationGatewayDataSource(string name) : base("azurerm_application_gateway", name)
    {
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApplicationGatewayDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The authentication_certificate attribute.
    /// </summary>
    [TerraformArgument("authentication_certificate")]
    public TerraformList<object> AuthenticationCertificate
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "authentication_certificate").ResolveNodes(ctx));
    }

    /// <summary>
    /// The autoscale_configuration attribute.
    /// </summary>
    [TerraformArgument("autoscale_configuration")]
    public TerraformList<object> AutoscaleConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "autoscale_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The backend_address_pool attribute.
    /// </summary>
    [TerraformArgument("backend_address_pool")]
    public TerraformList<object> BackendAddressPool
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "backend_address_pool").ResolveNodes(ctx));
    }

    /// <summary>
    /// The backend_http_settings attribute.
    /// </summary>
    [TerraformArgument("backend_http_settings")]
    public TerraformList<object> BackendHttpSettings
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "backend_http_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The custom_error_configuration attribute.
    /// </summary>
    [TerraformArgument("custom_error_configuration")]
    public TerraformList<object> CustomErrorConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "custom_error_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformArgument("fips_enabled")]
    public TerraformValue<bool> FipsEnabled
    {
        get => new TerraformReference<bool>(this, "fips_enabled");
    }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformArgument("firewall_policy_id")]
    public TerraformValue<string> FirewallPolicyId
    {
        get => new TerraformReference<string>(this, "firewall_policy_id");
    }

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    [TerraformArgument("force_firewall_policy_association")]
    public TerraformValue<bool> ForceFirewallPolicyAssociation
    {
        get => new TerraformReference<bool>(this, "force_firewall_policy_association");
    }

    /// <summary>
    /// The frontend_ip_configuration attribute.
    /// </summary>
    [TerraformArgument("frontend_ip_configuration")]
    public TerraformList<object> FrontendIpConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "frontend_ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [TerraformArgument("frontend_port")]
    public TerraformList<object> FrontendPort
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "frontend_port").ResolveNodes(ctx));
    }

    /// <summary>
    /// The gateway_ip_configuration attribute.
    /// </summary>
    [TerraformArgument("gateway_ip_configuration")]
    public TerraformList<object> GatewayIpConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "gateway_ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The global attribute.
    /// </summary>
    [TerraformArgument("global")]
    public TerraformList<object> Global
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "global").ResolveNodes(ctx));
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformArgument("http2_enabled")]
    public TerraformValue<bool> Http2Enabled
    {
        get => new TerraformReference<bool>(this, "http2_enabled");
    }

    /// <summary>
    /// The http_listener attribute.
    /// </summary>
    [TerraformArgument("http_listener")]
    public TerraformList<object> HttpListener
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "http_listener").ResolveNodes(ctx));
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    [TerraformArgument("private_endpoint_connection")]
    public TerraformList<object> PrivateEndpointConnection
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "private_endpoint_connection").ResolveNodes(ctx));
    }

    /// <summary>
    /// The private_link_configuration attribute.
    /// </summary>
    [TerraformArgument("private_link_configuration")]
    public TerraformList<object> PrivateLinkConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "private_link_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The probe attribute.
    /// </summary>
    [TerraformArgument("probe")]
    public TerraformList<object> Probe
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "probe").ResolveNodes(ctx));
    }

    /// <summary>
    /// The redirect_configuration attribute.
    /// </summary>
    [TerraformArgument("redirect_configuration")]
    public TerraformList<object> RedirectConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "redirect_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The request_routing_rule attribute.
    /// </summary>
    [TerraformArgument("request_routing_rule")]
    public TerraformList<object> RequestRoutingRule
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "request_routing_rule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The rewrite_rule_set attribute.
    /// </summary>
    [TerraformArgument("rewrite_rule_set")]
    public TerraformList<object> RewriteRuleSet
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "rewrite_rule_set").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformList<object> Sku
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "sku").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ssl_certificate attribute.
    /// </summary>
    [TerraformArgument("ssl_certificate")]
    public TerraformList<object> SslCertificate
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "ssl_certificate").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    [TerraformArgument("ssl_policy")]
    public TerraformList<object> SslPolicy
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "ssl_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ssl_profile attribute.
    /// </summary>
    [TerraformArgument("ssl_profile")]
    public TerraformList<object> SslProfile
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "ssl_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The trusted_client_certificate attribute.
    /// </summary>
    [TerraformArgument("trusted_client_certificate")]
    public TerraformList<object> TrustedClientCertificate
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "trusted_client_certificate").ResolveNodes(ctx));
    }

    /// <summary>
    /// The trusted_root_certificate attribute.
    /// </summary>
    [TerraformArgument("trusted_root_certificate")]
    public TerraformList<object> TrustedRootCertificate
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "trusted_root_certificate").ResolveNodes(ctx));
    }

    /// <summary>
    /// The url_path_map attribute.
    /// </summary>
    [TerraformArgument("url_path_map")]
    public TerraformList<object> UrlPathMap
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "url_path_map").ResolveNodes(ctx));
    }

    /// <summary>
    /// The waf_configuration attribute.
    /// </summary>
    [TerraformArgument("waf_configuration")]
    public TerraformList<object> WafConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "waf_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

}
