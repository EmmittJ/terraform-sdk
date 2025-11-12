using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualHubDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_hub.
/// </summary>
public partial class AzurermVirtualHubDataSource : TerraformDataSource
{
    public AzurermVirtualHubDataSource(string name) : base("azurerm_virtual_hub", name)
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
    public AzurermVirtualHubDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [TerraformProperty("address_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AddressPrefix { get; }

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    [TerraformProperty("default_route_table_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultRouteTableId { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The virtual_router_asn attribute.
    /// </summary>
    [TerraformProperty("virtual_router_asn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> VirtualRouterAsn { get; }

    /// <summary>
    /// The virtual_router_ips attribute.
    /// </summary>
    [TerraformProperty("virtual_router_ips")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> VirtualRouterIps { get; }

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    [TerraformProperty("virtual_wan_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VirtualWanId { get; }

}
