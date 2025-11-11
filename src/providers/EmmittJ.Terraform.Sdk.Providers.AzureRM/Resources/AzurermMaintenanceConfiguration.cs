using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for install_patches in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMaintenanceConfigurationInstallPatchesBlock : TerraformBlockBase
{
    /// <summary>
    /// The reboot attribute.
    /// </summary>
    [TerraformProperty("reboot")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Reboot { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMaintenanceConfigurationTimeoutsBlock : TerraformBlockBase
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
/// Block type for window in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMaintenanceConfigurationWindowBlock : TerraformBlockBase
{
    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformProperty("duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Duration { get; set; }

    /// <summary>
    /// The expiration_date_time attribute.
    /// </summary>
    [TerraformProperty("expiration_date_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExpirationDateTime { get; set; }

    /// <summary>
    /// The recur_every attribute.
    /// </summary>
    [TerraformProperty("recur_every")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RecurEvery { get; set; }

    /// <summary>
    /// The start_date_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDateTime is required")]
    [TerraformProperty("start_date_time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StartDateTime { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    [TerraformProperty("time_zone")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TimeZone { get; set; }

}

/// <summary>
/// Manages a azurerm_maintenance_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMaintenanceConfiguration : TerraformResource
{
    public AzurermMaintenanceConfiguration(string name) : base("azurerm_maintenance_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The in_guest_user_patch_mode attribute.
    /// </summary>
    [TerraformProperty("in_guest_user_patch_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InGuestUserPatchMode { get; set; }

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
    /// The properties attribute.
    /// </summary>
    [TerraformProperty("properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Properties { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformProperty("visibility")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Visibility { get; set; }

    /// <summary>
    /// Block for install_patches.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstallPatches block(s) allowed")]
    [TerraformProperty("install_patches")]
    public partial TerraformList<TerraformBlock<AzurermMaintenanceConfigurationInstallPatchesBlock>>? InstallPatches { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMaintenanceConfigurationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Window block(s) allowed")]
    [TerraformProperty("window")]
    public partial TerraformList<TerraformBlock<AzurermMaintenanceConfigurationWindowBlock>>? Window { get; set; }

}
