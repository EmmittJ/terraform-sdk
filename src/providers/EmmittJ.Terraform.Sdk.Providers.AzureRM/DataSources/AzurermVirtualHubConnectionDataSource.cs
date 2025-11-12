using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualHubConnectionDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_hub_connection.
/// </summary>
public partial class AzurermVirtualHubConnectionDataSource : TerraformDataSource
{
    public AzurermVirtualHubConnectionDataSource(string name) : base("azurerm_virtual_hub_connection", name)
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
    public AzurermVirtualHubConnectionDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    [TerraformProperty("internet_security_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> InternetSecurityEnabled { get; }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [TerraformProperty("remote_virtual_network_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RemoteVirtualNetworkId { get; }

    /// <summary>
    /// The routing attribute.
    /// </summary>
    [TerraformProperty("routing")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Routing { get; }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [TerraformProperty("virtual_hub_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VirtualHubId { get; }

}
