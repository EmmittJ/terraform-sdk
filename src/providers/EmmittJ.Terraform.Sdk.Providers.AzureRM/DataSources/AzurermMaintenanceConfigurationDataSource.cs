using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMaintenanceConfigurationDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_maintenance_configuration.
/// </summary>
public partial class AzurermMaintenanceConfigurationDataSource : TerraformDataSource
{
    public AzurermMaintenanceConfigurationDataSource(string name) : base("azurerm_maintenance_configuration", name)
    {
    }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMaintenanceConfigurationDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The in_guest_user_patch_mode attribute.
    /// </summary>
    [TerraformProperty("in_guest_user_patch_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InGuestUserPatchMode { get; }

    /// <summary>
    /// The install_patches attribute.
    /// </summary>
    [TerraformProperty("install_patches")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> InstallPatches { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformProperty("properties")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Properties { get; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformProperty("scope")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Scope { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformProperty("visibility")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Visibility { get; }

    /// <summary>
    /// The window attribute.
    /// </summary>
    [TerraformProperty("window")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Window { get; }

}
