using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_system_center_virtual_machine_manager_virtual_machine_instance resource.
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstance : TerraformResource
{
    public AzurermSystemCenterVirtualMachineManagerVirtualMachineInstance(string name) : base("azurerm_system_center_virtual_machine_manager_virtual_machine_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomLocationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_location_id");
        set => this.WithProperty("custom_location_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The scoped_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScopedResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scoped_resource_id");
        set => this.WithProperty("scoped_resource_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_availability_set_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? SystemCenterVirtualMachineManagerAvailabilitySetIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("system_center_virtual_machine_manager_availability_set_ids");
        set => this.WithProperty("system_center_virtual_machine_manager_availability_set_ids", value);
    }

}
