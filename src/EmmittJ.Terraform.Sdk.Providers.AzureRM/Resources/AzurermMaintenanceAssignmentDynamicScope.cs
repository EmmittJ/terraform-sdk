using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_maintenance_assignment_dynamic_scope resource.
/// </summary>
public class AzurermMaintenanceAssignmentDynamicScope : TerraformResource
{
    public AzurermMaintenanceAssignmentDynamicScope(string name) : base("azurerm_maintenance_assignment_dynamic_scope", name)
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
    /// The maintenance_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string>? MaintenanceConfigurationId
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_configuration_id");
        set => this.WithProperty("maintenance_configuration_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

}
