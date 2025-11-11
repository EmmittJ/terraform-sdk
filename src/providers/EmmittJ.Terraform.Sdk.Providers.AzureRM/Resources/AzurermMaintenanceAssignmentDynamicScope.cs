using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMaintenanceAssignmentDynamicScopeFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The locations attribute.
    /// </summary>
    [TerraformProperty("locations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Locations { get; set; }

    /// <summary>
    /// The os_types attribute.
    /// </summary>
    [TerraformProperty("os_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? OsTypes { get; set; }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    [TerraformProperty("resource_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ResourceGroups { get; set; }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    [TerraformProperty("resource_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ResourceTypes { get; set; }

    /// <summary>
    /// The tag_filter attribute.
    /// </summary>
    [TerraformProperty("tag_filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TagFilter { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMaintenanceAssignmentDynamicScopeTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_maintenance_assignment_dynamic_scope resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMaintenanceAssignmentDynamicScope : TerraformResource
{
    public AzurermMaintenanceAssignmentDynamicScope(string name) : base("azurerm_maintenance_assignment_dynamic_scope", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The maintenance_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceConfigurationId is required")]
    [TerraformProperty("maintenance_configuration_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MaintenanceConfigurationId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    [TerraformProperty("filter")]
    public partial TerraformList<TerraformBlock<AzurermMaintenanceAssignmentDynamicScopeFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMaintenanceAssignmentDynamicScopeTimeoutsBlock>? Timeouts { get; set; }

}
