using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_maintenance_assignment_virtual_machine_scale_set resource.
/// </summary>
public class AzurermMaintenanceAssignmentVirtualMachineScaleSet : TerraformResource
{
    public AzurermMaintenanceAssignmentVirtualMachineScaleSet(string name) : base("azurerm_maintenance_assignment_virtual_machine_scale_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The maintenance_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string>? MaintenanceConfigurationId
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_configuration_id");
        set => this.WithProperty("maintenance_configuration_id", value);
    }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualMachineScaleSetId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_scale_set_id");
        set => this.WithProperty("virtual_machine_scale_set_id", value);
    }

}
