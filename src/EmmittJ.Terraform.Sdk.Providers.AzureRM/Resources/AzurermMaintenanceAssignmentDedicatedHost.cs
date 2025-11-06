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
    public string? DedicatedHostId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dedicated_host_id")?.Value;
        set => this.WithProperty("dedicated_host_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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

}
