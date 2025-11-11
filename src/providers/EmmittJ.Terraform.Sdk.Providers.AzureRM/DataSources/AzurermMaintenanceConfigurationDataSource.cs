using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMaintenanceConfigurationDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_maintenance_configuration.
/// </summary>
public class AzurermMaintenanceConfigurationDataSource : TerraformDataSource
{
    public AzurermMaintenanceConfigurationDataSource(string name) : base("azurerm_maintenance_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMaintenanceConfigurationDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The in_guest_user_patch_mode attribute.
    /// </summary>
    [TerraformPropertyName("in_guest_user_patch_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InGuestUserPatchMode => new TerraformReference(this, "in_guest_user_patch_mode");

    /// <summary>
    /// The install_patches attribute.
    /// </summary>
    [TerraformPropertyName("install_patches")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InstallPatches => new TerraformReference(this, "install_patches");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Properties => new TerraformReference(this, "properties");

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformPropertyName("scope")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Scope => new TerraformReference(this, "scope");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformPropertyName("visibility")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Visibility => new TerraformReference(this, "visibility");

    /// <summary>
    /// The window attribute.
    /// </summary>
    [TerraformPropertyName("window")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Window => new TerraformReference(this, "window");

}
