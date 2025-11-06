using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_maintenance_assignment_virtual_machine resource.
/// </summary>
public class AzurermMaintenanceAssignmentVirtualMachine : TerraformResource
{
    public AzurermMaintenanceAssignmentVirtualMachine(string name) : base("azurerm_maintenance_assignment_virtual_machine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maintenance_configuration_id attribute.
    /// </summary>
    public string? MaintenanceConfigurationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_configuration_id")?.Value;
        set => this.WithProperty("maintenance_configuration_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public string? VirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_id")?.Value;
        set => this.WithProperty("virtual_machine_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
