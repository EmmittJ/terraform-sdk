using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for manage_action in .
/// Nesting mode: list
/// </summary>
public partial class AzurermGalleryApplicationVersionManageActionBlock : TerraformBlockBase
{
    /// <summary>
    /// The install attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Install is required")]
    [TerraformProperty("install")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Install { get; set; }

    /// <summary>
    /// The remove attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Remove is required")]
    [TerraformProperty("remove")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Remove { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public partial class AzurermGalleryApplicationVersionSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The default_configuration_link attribute.
    /// </summary>
    [TerraformProperty("default_configuration_link")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultConfigurationLink { get; set; }

    /// <summary>
    /// The media_link attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MediaLink is required")]
    [TerraformProperty("media_link")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MediaLink { get; set; }

}

/// <summary>
/// Block type for target_region in .
/// Nesting mode: list
/// </summary>
public partial class AzurermGalleryApplicationVersionTargetRegionBlock : TerraformBlockBase
{
    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    [TerraformProperty("exclude_from_latest")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExcludeFromLatest { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The regional_replica_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionalReplicaCount is required")]
    [TerraformProperty("regional_replica_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> RegionalReplicaCount { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformProperty("storage_account_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermGalleryApplicationVersionTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_gallery_application_version resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermGalleryApplicationVersion : TerraformResource
{
    public AzurermGalleryApplicationVersion(string name) : base("azurerm_gallery_application_version", name)
    {
    }

    /// <summary>
    /// The config_file attribute.
    /// </summary>
    [TerraformProperty("config_file")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConfigFile { get; set; }

    /// <summary>
    /// The enable_health_check attribute.
    /// </summary>
    [TerraformProperty("enable_health_check")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableHealthCheck { get; set; }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    [TerraformProperty("end_of_life_date")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EndOfLifeDate { get; set; }

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    [TerraformProperty("exclude_from_latest")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExcludeFromLatest { get; set; }

    /// <summary>
    /// The gallery_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryApplicationId is required")]
    [TerraformProperty("gallery_application_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GalleryApplicationId { get; set; }

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
    /// The package_file attribute.
    /// </summary>
    [TerraformProperty("package_file")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PackageFile { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for manage_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManageAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManageAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManageAction block(s) allowed")]
    [TerraformProperty("manage_action")]
    public partial TerraformList<TerraformBlock<AzurermGalleryApplicationVersionManageActionBlock>>? ManageAction { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformProperty("source")]
    public partial TerraformList<TerraformBlock<AzurermGalleryApplicationVersionSourceBlock>>? Source { get; set; }

    /// <summary>
    /// Block for target_region.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRegion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetRegion block(s) required")]
    [TerraformProperty("target_region")]
    public partial TerraformList<TerraformBlock<AzurermGalleryApplicationVersionTargetRegionBlock>>? TargetRegion { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermGalleryApplicationVersionTimeoutsBlock>? Timeouts { get; set; }

}
