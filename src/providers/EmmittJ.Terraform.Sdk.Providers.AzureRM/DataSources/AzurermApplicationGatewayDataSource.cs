using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationGatewayDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApplicationGatewayDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The authentication_certificate attribute.
    /// </summary>
    [TerraformPropertyName("authentication_certificate")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AuthenticationCertificate => new TerraformReference(this, "authentication_certificate");

    /// <summary>
    /// The autoscale_configuration attribute.
    /// </summary>
    [TerraformPropertyName("autoscale_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AutoscaleConfiguration => new TerraformReference(this, "autoscale_configuration");

    /// <summary>
    /// The backend_address_pool attribute.
    /// </summary>
    [TerraformPropertyName("backend_address_pool")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BackendAddressPool => new TerraformReference(this, "backend_address_pool");

    /// <summary>
    /// The backend_http_settings attribute.
    /// </summary>
    [TerraformPropertyName("backend_http_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BackendHttpSettings => new TerraformReference(this, "backend_http_settings");

    /// <summary>
    /// The custom_error_configuration attribute.
    /// </summary>
    [TerraformPropertyName("custom_error_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CustomErrorConfiguration => new TerraformReference(this, "custom_error_configuration");

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformPropertyName("fips_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> FipsEnabled => new TerraformReference(this, "fips_enabled");

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("firewall_policy_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FirewallPolicyId => new TerraformReference(this, "firewall_policy_id");

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    [TerraformPropertyName("force_firewall_policy_association")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ForceFirewallPolicyAssociation => new TerraformReference(this, "force_firewall_policy_association");

    /// <summary>
    /// The frontend_ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("frontend_ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> FrontendIpConfiguration => new TerraformReference(this, "frontend_ip_configuration");

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [TerraformPropertyName("frontend_port")]
    // Output-only attribute - read-only reference
    public TerraformList<object> FrontendPort => new TerraformReference(this, "frontend_port");

    /// <summary>
    /// The gateway_ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("gateway_ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> GatewayIpConfiguration => new TerraformReference(this, "gateway_ip_configuration");

    /// <summary>
    /// The global attribute.
    /// </summary>
    [TerraformPropertyName("global")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Global => new TerraformReference(this, "global");

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformPropertyName("http2_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Http2Enabled => new TerraformReference(this, "http2_enabled");

    /// <summary>
    /// The http_listener attribute.
    /// </summary>
    [TerraformPropertyName("http_listener")]
    // Output-only attribute - read-only reference
    public TerraformList<object> HttpListener => new TerraformReference(this, "http_listener");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint_connection")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PrivateEndpointConnection => new TerraformReference(this, "private_endpoint_connection");

    /// <summary>
    /// The private_link_configuration attribute.
    /// </summary>
    [TerraformPropertyName("private_link_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PrivateLinkConfiguration => new TerraformReference(this, "private_link_configuration");

    /// <summary>
    /// The probe attribute.
    /// </summary>
    [TerraformPropertyName("probe")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Probe => new TerraformReference(this, "probe");

    /// <summary>
    /// The redirect_configuration attribute.
    /// </summary>
    [TerraformPropertyName("redirect_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RedirectConfiguration => new TerraformReference(this, "redirect_configuration");

    /// <summary>
    /// The request_routing_rule attribute.
    /// </summary>
    [TerraformPropertyName("request_routing_rule")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RequestRoutingRule => new TerraformReference(this, "request_routing_rule");

    /// <summary>
    /// The rewrite_rule_set attribute.
    /// </summary>
    [TerraformPropertyName("rewrite_rule_set")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RewriteRuleSet => new TerraformReference(this, "rewrite_rule_set");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Sku => new TerraformReference(this, "sku");

    /// <summary>
    /// The ssl_certificate attribute.
    /// </summary>
    [TerraformPropertyName("ssl_certificate")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SslCertificate => new TerraformReference(this, "ssl_certificate");

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    [TerraformPropertyName("ssl_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SslPolicy => new TerraformReference(this, "ssl_policy");

    /// <summary>
    /// The ssl_profile attribute.
    /// </summary>
    [TerraformPropertyName("ssl_profile")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SslProfile => new TerraformReference(this, "ssl_profile");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The trusted_client_certificate attribute.
    /// </summary>
    [TerraformPropertyName("trusted_client_certificate")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TrustedClientCertificate => new TerraformReference(this, "trusted_client_certificate");

    /// <summary>
    /// The trusted_root_certificate attribute.
    /// </summary>
    [TerraformPropertyName("trusted_root_certificate")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TrustedRootCertificate => new TerraformReference(this, "trusted_root_certificate");

    /// <summary>
    /// The url_path_map attribute.
    /// </summary>
    [TerraformPropertyName("url_path_map")]
    // Output-only attribute - read-only reference
    public TerraformList<object> UrlPathMap => new TerraformReference(this, "url_path_map");

    /// <summary>
    /// The waf_configuration attribute.
    /// </summary>
    [TerraformPropertyName("waf_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> WafConfiguration => new TerraformReference(this, "waf_configuration");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Zones => new TerraformReference(this, "zones");

}
