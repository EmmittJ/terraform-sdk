using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_system_center_virtual_machine_manager_inventory_items.
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSource : TerraformDataSource
{
    public AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSource(string name) : base("azurerm_system_center_virtual_machine_manager_inventory_items", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The inventory_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InventoryType is required")]
    [TerraformPropertyName("inventory_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InventoryType { get; set; }

    /// <summary>
    /// The system_center_virtual_machine_manager_server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SystemCenterVirtualMachineManagerServerId is required")]
    [TerraformPropertyName("system_center_virtual_machine_manager_server_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SystemCenterVirtualMachineManagerServerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The inventory_items attribute.
    /// </summary>
    [TerraformPropertyName("inventory_items")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InventoryItems => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "inventory_items");

}
