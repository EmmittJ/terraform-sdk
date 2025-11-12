using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMaintenanceAssignmentDedicatedHostTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a azurerm_maintenance_assignment_dedicated_host resource.
/// </summary>
public partial class AzurermMaintenanceAssignmentDedicatedHost : TerraformResource
{
    public AzurermMaintenanceAssignmentDedicatedHost(string name) : base("azurerm_maintenance_assignment_dedicated_host", name)
    {
    }

    /// <summary>
    /// The dedicated_host_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DedicatedHostId is required")]
    [TerraformProperty("dedicated_host_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DedicatedHostId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The maintenance_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceConfigurationId is required")]
    [TerraformProperty("maintenance_configuration_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MaintenanceConfigurationId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMaintenanceAssignmentDedicatedHostTimeoutsBlock Timeouts { get; set; } = new();

}
