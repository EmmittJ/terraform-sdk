using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermArcMachineExtensionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_arc_machine_extension resource.
/// </summary>
public partial class AzurermArcMachineExtension : TerraformResource
{
    public AzurermArcMachineExtension(string name) : base("azurerm_arc_machine_extension", name)
    {
    }

    /// <summary>
    /// The arc_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcMachineId is required")]
    [TerraformProperty("arc_machine_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ArcMachineId { get; set; }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    [TerraformProperty("automatic_upgrade_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutomaticUpgradeEnabled { get; set; }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    [TerraformProperty("force_update_tag")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ForceUpdateTag { get; set; }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    [TerraformProperty("protected_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProtectedSettings { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformProperty("publisher")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Publisher { get; set; }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    [TerraformProperty("settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Settings { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [TerraformProperty("type_handler_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TypeHandlerVersion { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermArcMachineExtensionTimeoutsBlock Timeouts { get; set; } = new();

}
