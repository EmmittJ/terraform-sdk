using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopApplicationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_desktop_application resource.
/// </summary>
public class AzurermVirtualDesktopApplication : TerraformResource
{
    public AzurermVirtualDesktopApplication(string name) : base("azurerm_virtual_desktop_application", name)
    {
    }

    /// <summary>
    /// The application_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationGroupId is required")]
    [TerraformPropertyName("application_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApplicationGroupId { get; set; }

    /// <summary>
    /// The command_line_argument_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommandLineArgumentPolicy is required")]
    [TerraformPropertyName("command_line_argument_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CommandLineArgumentPolicy { get; set; }

    /// <summary>
    /// The command_line_arguments attribute.
    /// </summary>
    [TerraformPropertyName("command_line_arguments")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CommandLineArguments { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformPropertyName("friendly_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FriendlyName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "friendly_name");

    /// <summary>
    /// The icon_index attribute.
    /// </summary>
    [TerraformPropertyName("icon_index")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? IconIndex { get; set; }

    /// <summary>
    /// The icon_path attribute.
    /// </summary>
    [TerraformPropertyName("icon_path")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IconPath { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "icon_path");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformPropertyName("path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Path { get; set; }

    /// <summary>
    /// The show_in_portal attribute.
    /// </summary>
    [TerraformPropertyName("show_in_portal")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ShowInPortal { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualDesktopApplicationTimeoutsBlock>? Timeouts { get; set; } = new();

}
