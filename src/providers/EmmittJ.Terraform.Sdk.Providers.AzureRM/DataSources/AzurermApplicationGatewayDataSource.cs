using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApplicationGatewayDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_application_gateway.
/// </summary>
public partial class AzurermApplicationGatewayDataSource : TerraformDataSource
{
    public AzurermApplicationGatewayDataSource(string name) : base("azurerm_application_gateway", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermApplicationGatewayDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The authentication_certificate attribute.
    /// </summary>
    [TerraformProperty("authentication_certificate")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AuthenticationCertificate { get; }

    /// <summary>
    /// The autoscale_configuration attribute.
    /// </summary>
    [TerraformProperty("autoscale_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AutoscaleConfiguration { get; }

    /// <summary>
    /// The backend_address_pool attribute.
    /// </summary>
    [TerraformProperty("backend_address_pool")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> BackendAddressPool { get; }

    /// <summary>
    /// The backend_http_settings attribute.
    /// </summary>
    [TerraformProperty("backend_http_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> BackendHttpSettings { get; }

    /// <summary>
    /// The custom_error_configuration attribute.
    /// </summary>
    [TerraformProperty("custom_error_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CustomErrorConfiguration { get; }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformProperty("fips_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> FipsEnabled { get; }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformProperty("firewall_policy_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FirewallPolicyId { get; }

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    [TerraformProperty("force_firewall_policy_association")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ForceFirewallPolicyAssociation { get; }

    /// <summary>
    /// The frontend_ip_configuration attribute.
    /// </summary>
    [TerraformProperty("frontend_ip_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> FrontendIpConfiguration { get; }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [TerraformProperty("frontend_port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> FrontendPort { get; }

    /// <summary>
    /// The gateway_ip_configuration attribute.
    /// </summary>
    [TerraformProperty("gateway_ip_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> GatewayIpConfiguration { get; }

    /// <summary>
    /// The global attribute.
    /// </summary>
    [TerraformProperty("global")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Global { get; }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformProperty("http2_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Http2Enabled { get; }

    /// <summary>
    /// The http_listener attribute.
    /// </summary>
    [TerraformProperty("http_listener")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> HttpListener { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Identity { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    [TerraformProperty("private_endpoint_connection")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PrivateEndpointConnection { get; }

    /// <summary>
    /// The private_link_configuration attribute.
    /// </summary>
    [TerraformProperty("private_link_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PrivateLinkConfiguration { get; }

    /// <summary>
    /// The probe attribute.
    /// </summary>
    [TerraformProperty("probe")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Probe { get; }

    /// <summary>
    /// The redirect_configuration attribute.
    /// </summary>
    [TerraformProperty("redirect_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RedirectConfiguration { get; }

    /// <summary>
    /// The request_routing_rule attribute.
    /// </summary>
    [TerraformProperty("request_routing_rule")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RequestRoutingRule { get; }

    /// <summary>
    /// The rewrite_rule_set attribute.
    /// </summary>
    [TerraformProperty("rewrite_rule_set")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RewriteRuleSet { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Sku { get; }

    /// <summary>
    /// The ssl_certificate attribute.
    /// </summary>
    [TerraformProperty("ssl_certificate")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SslCertificate { get; }

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    [TerraformProperty("ssl_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SslPolicy { get; }

    /// <summary>
    /// The ssl_profile attribute.
    /// </summary>
    [TerraformProperty("ssl_profile")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SslProfile { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The trusted_client_certificate attribute.
    /// </summary>
    [TerraformProperty("trusted_client_certificate")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> TrustedClientCertificate { get; }

    /// <summary>
    /// The trusted_root_certificate attribute.
    /// </summary>
    [TerraformProperty("trusted_root_certificate")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> TrustedRootCertificate { get; }

    /// <summary>
    /// The url_path_map attribute.
    /// </summary>
    [TerraformProperty("url_path_map")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> UrlPathMap { get; }

    /// <summary>
    /// The waf_configuration attribute.
    /// </summary>
    [TerraformProperty("waf_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> WafConfiguration { get; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Zones { get; }

}
