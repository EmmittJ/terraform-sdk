using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_system_center_virtual_machine_manager_virtual_machine_template resource.
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineTemplate : TerraformResource
{
    public AzurermSystemCenterVirtualMachineManagerVirtualMachineTemplate(string name) : base("azurerm_system_center_virtual_machine_manager_virtual_machine_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomLocationId
    {
        get => GetProperty<TerraformProperty<string>>("custom_location_id");
        set => this.WithProperty("custom_location_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_server_inventory_item_id attribute.
    /// </summary>
    public TerraformProperty<string>? SystemCenterVirtualMachineManagerServerInventoryItemId
    {
        get => GetProperty<TerraformProperty<string>>("system_center_virtual_machine_manager_server_inventory_item_id");
        set => this.WithProperty("system_center_virtual_machine_manager_server_inventory_item_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

}
