using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualDesktopApplicationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_desktop_application resource.
/// </summary>
public partial class AzurermVirtualDesktopApplication : TerraformResource
{
    public AzurermVirtualDesktopApplication(string name) : base("azurerm_virtual_desktop_application", name)
    {
    }

    /// <summary>
    /// The application_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationGroupId is required")]
    [TerraformProperty("application_group_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApplicationGroupId { get; set; }

    /// <summary>
    /// The command_line_argument_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommandLineArgumentPolicy is required")]
    [TerraformProperty("command_line_argument_policy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CommandLineArgumentPolicy { get; set; }

    /// <summary>
    /// The command_line_arguments attribute.
    /// </summary>
    [TerraformProperty("command_line_arguments")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CommandLineArguments { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformProperty("friendly_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> FriendlyName { get; set; }

    /// <summary>
    /// The icon_index attribute.
    /// </summary>
    [TerraformProperty("icon_index")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? IconIndex { get; set; }

    /// <summary>
    /// The icon_path attribute.
    /// </summary>
    [TerraformProperty("icon_path")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IconPath { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The show_in_portal attribute.
    /// </summary>
    [TerraformProperty("show_in_portal")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ShowInPortal { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermVirtualDesktopApplicationTimeoutsBlock>? Timeouts { get; set; }

}
