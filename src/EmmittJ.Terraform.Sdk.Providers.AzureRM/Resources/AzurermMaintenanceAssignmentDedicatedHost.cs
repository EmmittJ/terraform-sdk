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
    public TerraformLiteralProperty<string>? DedicatedHostId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dedicated_host_id");
        set => this.WithProperty("dedicated_host_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The maintenance_configuration_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MaintenanceConfigurationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_configuration_id");
        set => this.WithProperty("maintenance_configuration_id", value);
    }

}
