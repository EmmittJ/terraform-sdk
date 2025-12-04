using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_system_center_virtual_machine_manager_inventory_items Terraform data source.
/// Retrieves information about a azurerm_system_center_virtual_machine_manager_inventory_items.
/// </summary>
public partial class AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSource(string name) : TerraformDataSource("azurerm_system_center_virtual_machine_manager_inventory_items", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The inventory_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InventoryType is required")]
    public required TerraformValue<string> InventoryType
    {
        get => GetArgument<TerraformValue<string>>("inventory_type");
        set => SetArgument("inventory_type", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SystemCenterVirtualMachineManagerServerId is required")]
    public required TerraformValue<string> SystemCenterVirtualMachineManagerServerId
    {
        get => GetArgument<TerraformValue<string>>("system_center_virtual_machine_manager_server_id");
        set => SetArgument("system_center_virtual_machine_manager_server_id", value);
    }

    /// <summary>
    /// The inventory_items attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InventoryItems
        => AsReference("inventory_items");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
