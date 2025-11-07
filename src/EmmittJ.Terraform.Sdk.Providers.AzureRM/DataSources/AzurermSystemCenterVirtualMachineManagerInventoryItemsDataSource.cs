using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<string>? InventoryType
    {
        get => GetProperty<TerraformProperty<string>>("inventory_type");
        set => this.WithProperty("inventory_type", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_server_id attribute.
    /// </summary>
    public TerraformProperty<string>? SystemCenterVirtualMachineManagerServerId
    {
        get => GetProperty<TerraformProperty<string>>("system_center_virtual_machine_manager_server_id");
        set => this.WithProperty("system_center_virtual_machine_manager_server_id", value);
    }

    /// <summary>
    /// The inventory_items attribute.
    /// </summary>
    public TerraformExpression InventoryItems => this["inventory_items"];

}
