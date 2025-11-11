using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLocalNetworkGatewayDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_local_network_gateway.
/// </summary>
public partial class AzurermLocalNetworkGatewayDataSource : TerraformDataSource
{
    public AzurermLocalNetworkGatewayDataSource(string name) : base("azurerm_local_network_gateway", name)
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
    public TerraformBlock<AzurermLocalNetworkGatewayDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [TerraformProperty("address_space")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AddressSpace { get; }

    /// <summary>
    /// The bgp_settings attribute.
    /// </summary>
    [TerraformProperty("bgp_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> BgpSettings { get; }

    /// <summary>
    /// The gateway_address attribute.
    /// </summary>
    [TerraformProperty("gateway_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GatewayAddress { get; }

    /// <summary>
    /// The gateway_fqdn attribute.
    /// </summary>
    [TerraformProperty("gateway_fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GatewayFqdn { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

}
