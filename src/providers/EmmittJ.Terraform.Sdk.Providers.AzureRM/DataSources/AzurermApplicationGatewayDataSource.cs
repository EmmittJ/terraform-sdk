using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationGatewayDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApplicationGatewayDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The authentication_certificate attribute.
    /// </summary>
    [TerraformPropertyName("authentication_certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AuthenticationCertificate => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "authentication_certificate");

    /// <summary>
    /// The autoscale_configuration attribute.
    /// </summary>
    [TerraformPropertyName("autoscale_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AutoscaleConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "autoscale_configuration");

    /// <summary>
    /// The backend_address_pool attribute.
    /// </summary>
    [TerraformPropertyName("backend_address_pool")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BackendAddressPool => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "backend_address_pool");

    /// <summary>
    /// The backend_http_settings attribute.
    /// </summary>
    [TerraformPropertyName("backend_http_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BackendHttpSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "backend_http_settings");

    /// <summary>
    /// The custom_error_configuration attribute.
    /// </summary>
    [TerraformPropertyName("custom_error_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CustomErrorConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "custom_error_configuration");

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    [TerraformPropertyName("fips_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> FipsEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "fips_enabled");

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("firewall_policy_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FirewallPolicyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "firewall_policy_id");

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    [TerraformPropertyName("force_firewall_policy_association")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ForceFirewallPolicyAssociation => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "force_firewall_policy_association");

    /// <summary>
    /// The frontend_ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("frontend_ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> FrontendIpConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "frontend_ip_configuration");

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [TerraformPropertyName("frontend_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> FrontendPort => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "frontend_port");

    /// <summary>
    /// The gateway_ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("gateway_ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> GatewayIpConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "gateway_ip_configuration");

    /// <summary>
    /// The global attribute.
    /// </summary>
    [TerraformPropertyName("global")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Global => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "global");

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformPropertyName("http2_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Http2Enabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "http2_enabled");

    /// <summary>
    /// The http_listener attribute.
    /// </summary>
    [TerraformPropertyName("http_listener")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> HttpListener => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "http_listener");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    [TerraformPropertyName("private_endpoint_connection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PrivateEndpointConnection => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "private_endpoint_connection");

    /// <summary>
    /// The private_link_configuration attribute.
    /// </summary>
    [TerraformPropertyName("private_link_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PrivateLinkConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "private_link_configuration");

    /// <summary>
    /// The probe attribute.
    /// </summary>
    [TerraformPropertyName("probe")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Probe => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "probe");

    /// <summary>
    /// The redirect_configuration attribute.
    /// </summary>
    [TerraformPropertyName("redirect_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RedirectConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "redirect_configuration");

    /// <summary>
    /// The request_routing_rule attribute.
    /// </summary>
    [TerraformPropertyName("request_routing_rule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RequestRoutingRule => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "request_routing_rule");

    /// <summary>
    /// The rewrite_rule_set attribute.
    /// </summary>
    [TerraformPropertyName("rewrite_rule_set")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RewriteRuleSet => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "rewrite_rule_set");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Sku => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "sku");

    /// <summary>
    /// The ssl_certificate attribute.
    /// </summary>
    [TerraformPropertyName("ssl_certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SslCertificate => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ssl_certificate");

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    [TerraformPropertyName("ssl_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SslPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ssl_policy");

    /// <summary>
    /// The ssl_profile attribute.
    /// </summary>
    [TerraformPropertyName("ssl_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SslProfile => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ssl_profile");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The trusted_client_certificate attribute.
    /// </summary>
    [TerraformPropertyName("trusted_client_certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TrustedClientCertificate => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "trusted_client_certificate");

    /// <summary>
    /// The trusted_root_certificate attribute.
    /// </summary>
    [TerraformPropertyName("trusted_root_certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TrustedRootCertificate => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "trusted_root_certificate");

    /// <summary>
    /// The url_path_map attribute.
    /// </summary>
    [TerraformPropertyName("url_path_map")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> UrlPathMap => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "url_path_map");

    /// <summary>
    /// The waf_configuration attribute.
    /// </summary>
    [TerraformPropertyName("waf_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> WafConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "waf_configuration");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Zones => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "zones");

}
