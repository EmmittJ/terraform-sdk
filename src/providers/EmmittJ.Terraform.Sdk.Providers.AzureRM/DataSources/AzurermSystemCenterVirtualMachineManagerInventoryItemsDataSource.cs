using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_system_center_virtual_machine_manager_inventory_items.
/// </summary>
public partial class AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSource : TerraformDataSource
{
    public AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSource(string name) : base("azurerm_system_center_virtual_machine_manager_inventory_items", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The inventory_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InventoryType is required")]
    [TerraformProperty("inventory_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InventoryType { get; set; }

    /// <summary>
    /// The system_center_virtual_machine_manager_server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SystemCenterVirtualMachineManagerServerId is required")]
    [TerraformProperty("system_center_virtual_machine_manager_server_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SystemCenterVirtualMachineManagerServerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The inventory_items attribute.
    /// </summary>
    [TerraformProperty("inventory_items")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> InventoryItems { get; }

}
