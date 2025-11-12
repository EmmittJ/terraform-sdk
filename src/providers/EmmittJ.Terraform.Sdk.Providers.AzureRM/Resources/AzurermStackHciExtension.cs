using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStackHciExtensionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_stack_hci_extension resource.
/// </summary>
public partial class AzurermStackHciExtension : TerraformResource
{
    public AzurermStackHciExtension(string name) : base("azurerm_stack_hci_extension", name)
    {
    }

    /// <summary>
    /// The arc_setting_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcSettingId is required")]
    [TerraformProperty("arc_setting_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ArcSettingId { get; set; }

    /// <summary>
    /// The auto_upgrade_minor_version_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_upgrade_minor_version_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoUpgradeMinorVersionEnabled { get; set; }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    [TerraformProperty("automatic_upgrade_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutomaticUpgradeEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    public AzurermStackHciExtensionTimeoutsBlock Timeouts { get; set; } = new();

}
