using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_network_gateway.
/// </summary>
public partial class AzurermVirtualNetworkGatewayDataSource : TerraformDataSource
{
    public AzurermVirtualNetworkGatewayDataSource(string name) : base("azurerm_virtual_network_gateway", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The active_active attribute.
    /// </summary>
    [TerraformProperty("active_active")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ActiveActive { get; }

    /// <summary>
    /// The bgp_settings attribute.
    /// </summary>
    [TerraformProperty("bgp_settings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> BgpSettings { get; }

    /// <summary>
    /// The custom_route attribute.
    /// </summary>
    [TerraformProperty("custom_route")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CustomRoute { get; }

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    [TerraformProperty("default_local_network_gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultLocalNetworkGatewayId { get; }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    [TerraformProperty("enable_bgp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnableBgp { get; }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    [TerraformProperty("generation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Generation { get; }

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformProperty("ip_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> IpConfiguration { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    [TerraformProperty("private_ip_address_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PrivateIpAddressEnabled { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Sku { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

    /// <summary>
    /// The vpn_client_configuration attribute.
    /// </summary>
    [TerraformProperty("vpn_client_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> VpnClientConfiguration { get; }

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    [TerraformProperty("vpn_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpnType { get; }

}
