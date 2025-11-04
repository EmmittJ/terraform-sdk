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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The inventory_type attribute.
    /// </summary>
    public string? InventoryType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("inventory_type")?.Value;
        set => this.WithProperty("inventory_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_server_id attribute.
    /// </summary>
    public string? SystemCenterVirtualMachineManagerServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("system_center_virtual_machine_manager_server_id")?.Value;
        set => this.WithProperty("system_center_virtual_machine_manager_server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The inventory_items attribute.
    /// </summary>
    public TerraformExpression InventoryItems => this["inventory_items"];

}
