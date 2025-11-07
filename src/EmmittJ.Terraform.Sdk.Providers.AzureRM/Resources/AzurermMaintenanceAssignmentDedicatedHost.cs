using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_maintenance_assignment_dedicated_host resource.
/// </summary>
public class AzurermMaintenanceAssignmentDedicatedHost : TerraformResource
{
    public AzurermMaintenanceAssignmentDedicatedHost(string name) : base("azurerm_maintenance_assignment_dedicated_host", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The dedicated_host_id attribute.
    /// </summary>
    public TerraformProperty<string>? DedicatedHostId
    {
        get => GetProperty<TerraformProperty<string>>("dedicated_host_id");
        set => this.WithProperty("dedicated_host_id", value);
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

}
