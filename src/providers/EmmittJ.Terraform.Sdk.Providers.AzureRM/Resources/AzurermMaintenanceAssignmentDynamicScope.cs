using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AzurermMaintenanceAssignmentDynamicScopeFilterBlock : TerraformBlock
{
    /// <summary>
    /// The locations attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Locations
    {
        set => SetProperty("locations", value);
    }

    /// <summary>
    /// The os_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? OsTypes
    {
        set => SetProperty("os_types", value);
    }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceGroups
    {
        set => SetProperty("resource_groups", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceTypes
    {
        set => SetProperty("resource_types", value);
    }

    /// <summary>
    /// The tag_filter attribute.
    /// </summary>
    public TerraformProperty<string>? TagFilter
    {
        set => SetProperty("tag_filter", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMaintenanceAssignmentDynamicScopeTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_maintenance_assignment_dynamic_scope resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMaintenanceAssignmentDynamicScope : TerraformResource
{
    public AzurermMaintenanceAssignmentDynamicScope(string name) : base("azurerm_maintenance_assignment_dynamic_scope", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("maintenance_configuration_id");
        SetOutput("name");
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
    /// The maintenance_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceConfigurationId is required")]
    public required TerraformProperty<string> MaintenanceConfigurationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maintenance_configuration_id");
        set => SetProperty("maintenance_configuration_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public List<AzurermMaintenanceAssignmentDynamicScopeFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMaintenanceAssignmentDynamicScopeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
