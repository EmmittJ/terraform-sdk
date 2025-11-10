using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_system_center_virtual_machine_manager_inventory_items.
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSource : TerraformDataSource
{
    public AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSource(string name) : base("azurerm_system_center_virtual_machine_manager_inventory_items", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("inventory_items");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The inventory_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InventoryType is required")]
    public required TerraformProperty<string> InventoryType
    {
        get => GetProperty<TerraformProperty<string>>("inventory_type");
        set => this.WithProperty("inventory_type", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SystemCenterVirtualMachineManagerServerId is required")]
    public required TerraformProperty<string> SystemCenterVirtualMachineManagerServerId
    {
        get => GetProperty<TerraformProperty<string>>("system_center_virtual_machine_manager_server_id");
        set => this.WithProperty("system_center_virtual_machine_manager_server_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSystemCenterVirtualMachineManagerInventoryItemsDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The inventory_items attribute.
    /// </summary>
    public TerraformExpression InventoryItems => this["inventory_items"];

}
