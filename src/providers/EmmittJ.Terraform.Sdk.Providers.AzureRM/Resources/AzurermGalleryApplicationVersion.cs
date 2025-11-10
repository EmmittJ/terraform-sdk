using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for manage_action in .
/// Nesting mode: list
/// </summary>
public class AzurermGalleryApplicationVersionManageActionBlock : ITerraformBlock
{
    /// <summary>
    /// The install attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Install is required")]
    [TerraformPropertyName("install")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Install { get; set; }

    /// <summary>
    /// The remove attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Remove is required")]
    [TerraformPropertyName("remove")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Remove { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AzurermGalleryApplicationVersionSourceBlock : ITerraformBlock
{
    /// <summary>
    /// The default_configuration_link attribute.
    /// </summary>
    [TerraformPropertyName("default_configuration_link")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultConfigurationLink { get; set; }

    /// <summary>
    /// The media_link attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MediaLink is required")]
    [TerraformPropertyName("media_link")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MediaLink { get; set; }

}

/// <summary>
/// Block type for target_region in .
/// Nesting mode: list
/// </summary>
public class AzurermGalleryApplicationVersionTargetRegionBlock : ITerraformBlock
{
    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    [TerraformPropertyName("exclude_from_latest")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ExcludeFromLatest { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The regional_replica_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionalReplicaCount is required")]
    [TerraformPropertyName("regional_replica_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> RegionalReplicaCount { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermGalleryApplicationVersionTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_gallery_application_version resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermGalleryApplicationVersion : TerraformResource
{
    public AzurermGalleryApplicationVersion(string name) : base("azurerm_gallery_application_version", name)
    {
    }

    /// <summary>
    /// The config_file attribute.
    /// </summary>
    [TerraformPropertyName("config_file")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConfigFile { get; set; }

    /// <summary>
    /// The enable_health_check attribute.
    /// </summary>
    [TerraformPropertyName("enable_health_check")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableHealthCheck { get; set; }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    [TerraformPropertyName("end_of_life_date")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EndOfLifeDate { get; set; }

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    [TerraformPropertyName("exclude_from_latest")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ExcludeFromLatest { get; set; }

    /// <summary>
    /// The gallery_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryApplicationId is required")]
    [TerraformPropertyName("gallery_application_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GalleryApplicationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The package_file attribute.
    /// </summary>
    [TerraformPropertyName("package_file")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PackageFile { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for manage_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManageAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManageAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManageAction block(s) allowed")]
    [TerraformPropertyName("manage_action")]
    public TerraformList<TerraformBlock<AzurermGalleryApplicationVersionManageActionBlock>>? ManageAction { get; set; } = new();

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformPropertyName("source")]
    public TerraformList<TerraformBlock<AzurermGalleryApplicationVersionSourceBlock>>? Source { get; set; } = new();

    /// <summary>
    /// Block for target_region.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRegion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetRegion block(s) required")]
    [TerraformPropertyName("target_region")]
    public TerraformList<TerraformBlock<AzurermGalleryApplicationVersionTargetRegionBlock>>? TargetRegion { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermGalleryApplicationVersionTimeoutsBlock>? Timeouts { get; set; } = new();

}
