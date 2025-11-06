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
    public string? CustomLocationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_location_id")?.Value;
        set => this.WithProperty("custom_location_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The scoped_resource_id attribute.
    /// </summary>
    public string? ScopedResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scoped_resource_id")?.Value;
        set => this.WithProperty("scoped_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_availability_set_ids attribute.
    /// </summary>
    public List<string>? SystemCenterVirtualMachineManagerAvailabilitySetIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("system_center_virtual_machine_manager_availability_set_ids")?.Value;
        set => this.WithProperty("system_center_virtual_machine_manager_availability_set_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

}
