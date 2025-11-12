using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualMachineAutomanageConfigurationAssignmentTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_virtual_machine_automanage_configuration_assignment resource.
/// </summary>
public partial class AzurermVirtualMachineAutomanageConfigurationAssignment : TerraformResource
{
    public AzurermVirtualMachineAutomanageConfigurationAssignment(string name) : base("azurerm_virtual_machine_automanage_configuration_assignment", name)
    {
    }

    /// <summary>
    /// The configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationId is required")]
    [TerraformProperty("configuration_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConfigurationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    [TerraformProperty("virtual_machine_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualMachineId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermVirtualMachineAutomanageConfigurationAssignmentTimeoutsBlock Timeouts { get; set; } = new();

}
