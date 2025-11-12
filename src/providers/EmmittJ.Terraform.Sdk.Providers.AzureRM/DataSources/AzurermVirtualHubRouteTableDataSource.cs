using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualHubRouteTableDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_hub_route_table.
/// </summary>
public partial class AzurermVirtualHubRouteTableDataSource : TerraformDataSource
{
    public AzurermVirtualHubRouteTableDataSource(string name) : base("azurerm_virtual_hub_route_table", name)
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
    /// The virtual_hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubName is required")]
    [TerraformProperty("virtual_hub_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualHubName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermVirtualHubRouteTableDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> Labels { get; }

    /// <summary>
    /// The route attribute.
    /// </summary>
    [TerraformProperty("route")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Route { get; }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [TerraformProperty("virtual_hub_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VirtualHubId { get; }

}
