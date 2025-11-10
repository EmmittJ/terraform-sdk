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
        get => GetProperty<List<TerraformProperty<string>>>("locations");
        set => WithProperty("locations", value);
    }

    /// <summary>
    /// The os_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? OsTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("os_types");
        set => WithProperty("os_types", value);
    }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceGroups
    {
        get => GetProperty<List<TerraformProperty<string>>>("resource_groups");
        set => WithProperty("resource_groups", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("resource_types");
        set => WithProperty("resource_types", value);
    }

    /// <summary>
    /// The tag_filter attribute.
    /// </summary>
    public TerraformProperty<string>? TagFilter
    {
        get => GetProperty<TerraformProperty<string>>("tag_filter");
        set => WithProperty("tag_filter", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceConfigurationId is required")]
    public required TerraformProperty<string> MaintenanceConfigurationId
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_configuration_id");
        set => this.WithProperty("maintenance_configuration_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public List<AzurermMaintenanceAssignmentDynamicScopeFilterBlock>? Filter
    {
        get => GetProperty<List<AzurermMaintenanceAssignmentDynamicScopeFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMaintenanceAssignmentDynamicScopeTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMaintenanceAssignmentDynamicScopeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
