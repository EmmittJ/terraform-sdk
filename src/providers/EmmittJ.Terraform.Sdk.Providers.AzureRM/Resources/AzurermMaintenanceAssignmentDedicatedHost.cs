using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMaintenanceAssignmentDedicatedHostTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("dedicated_host_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("maintenance_configuration_id");
    }

    /// <summary>
    /// The dedicated_host_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DedicatedHostId is required")]
    public required TerraformProperty<string> DedicatedHostId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dedicated_host_id");
        set => SetProperty("dedicated_host_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The maintenance_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceConfigurationId is required")]
    public required TerraformProperty<string> MaintenanceConfigurationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maintenance_configuration_id");
        set => SetProperty("maintenance_configuration_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMaintenanceAssignmentDedicatedHostTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
