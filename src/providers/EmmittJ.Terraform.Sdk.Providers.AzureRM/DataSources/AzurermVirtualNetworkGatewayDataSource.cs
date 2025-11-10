using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_network_gateway.
/// </summary>
public class AzurermVirtualNetworkGatewayDataSource : TerraformDataSource
{
    public AzurermVirtualNetworkGatewayDataSource(string name) : base("azurerm_virtual_network_gateway", name)
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
    public TerraformBlock<AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The active_active attribute.
    /// </summary>
    [TerraformPropertyName("active_active")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ActiveActive => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "active_active");

    /// <summary>
    /// The bgp_settings attribute.
    /// </summary>
    [TerraformPropertyName("bgp_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BgpSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "bgp_settings");

    /// <summary>
    /// The custom_route attribute.
    /// </summary>
    [TerraformPropertyName("custom_route")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CustomRoute => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "custom_route");

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("default_local_network_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultLocalNetworkGatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_local_network_gateway_id");

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    [TerraformPropertyName("enable_bgp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableBgp => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_bgp");

    /// <summary>
    /// The generation attribute.
    /// </summary>
    [TerraformPropertyName("generation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Generation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "generation");

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IpConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ip_configuration");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PrivateIpAddressEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "private_ip_address_enabled");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sku => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The vpn_client_configuration attribute.
    /// </summary>
    [TerraformPropertyName("vpn_client_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VpnClientConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "vpn_client_configuration");

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    [TerraformPropertyName("vpn_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpnType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpn_type");

}
