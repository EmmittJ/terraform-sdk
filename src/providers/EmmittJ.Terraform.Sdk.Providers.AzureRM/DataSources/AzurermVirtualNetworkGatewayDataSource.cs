using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    public TerraformBlock<AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The active_active attribute.
    /// </summary>
    [TerraformPropertyName("active_active")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ActiveActive => new TerraformReference(this, "active_active");

    /// <summary>
    /// The bgp_settings attribute.
    /// </summary>
    [TerraformPropertyName("bgp_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BgpSettings => new TerraformReference(this, "bgp_settings");

    /// <summary>
    /// The custom_route attribute.
    /// </summary>
    [TerraformPropertyName("custom_route")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CustomRoute => new TerraformReference(this, "custom_route");

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("default_local_network_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultLocalNetworkGatewayId => new TerraformReference(this, "default_local_network_gateway_id");

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    [TerraformPropertyName("enable_bgp")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableBgp => new TerraformReference(this, "enable_bgp");

    /// <summary>
    /// The generation attribute.
    /// </summary>
    [TerraformPropertyName("generation")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Generation => new TerraformReference(this, "generation");

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IpConfiguration => new TerraformReference(this, "ip_configuration");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PrivateIpAddressEnabled => new TerraformReference(this, "private_ip_address_enabled");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Sku => new TerraformReference(this, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

    /// <summary>
    /// The vpn_client_configuration attribute.
    /// </summary>
    [TerraformPropertyName("vpn_client_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> VpnClientConfiguration => new TerraformReference(this, "vpn_client_configuration");

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    [TerraformPropertyName("vpn_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpnType => new TerraformReference(this, "vpn_type");

}
