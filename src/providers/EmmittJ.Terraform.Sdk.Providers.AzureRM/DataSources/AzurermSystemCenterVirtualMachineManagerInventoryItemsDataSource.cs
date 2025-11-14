using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The inventory_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InventoryType is required")]
    [TerraformArgument("inventory_type")]
    public required TerraformValue<string> InventoryType
    {
        get => new TerraformReference<string>(this, "inventory_type");
        set => SetArgument("inventory_type", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SystemCenterVirtualMachineManagerServerId is required")]
    [TerraformArgument("system_center_virtual_machine_manager_server_id")]
    public required TerraformValue<string> SystemCenterVirtualMachineManagerServerId
    {
        get => new TerraformReference<string>(this, "system_center_virtual_machine_manager_server_id");
        set => SetArgument("system_center_virtual_machine_manager_server_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The inventory_items attribute.
    /// </summary>
    [TerraformArgument("inventory_items")]
    public TerraformList<object> InventoryItems
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "inventory_items").ResolveNodes(ctx));
    }

}
