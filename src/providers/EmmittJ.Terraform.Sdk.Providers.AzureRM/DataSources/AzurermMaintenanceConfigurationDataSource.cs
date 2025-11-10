using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMaintenanceConfigurationDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMaintenanceConfigurationDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The in_guest_user_patch_mode attribute.
    /// </summary>
    [TerraformPropertyName("in_guest_user_patch_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InGuestUserPatchMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "in_guest_user_patch_mode");

    /// <summary>
    /// The install_patches attribute.
    /// </summary>
    [TerraformPropertyName("install_patches")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InstallPatches => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "install_patches");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Properties => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "properties");

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformPropertyName("scope")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Scope => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "scope");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformPropertyName("visibility")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Visibility => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "visibility");

    /// <summary>
    /// The window attribute.
    /// </summary>
    [TerraformPropertyName("window")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Window => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "window");

}
