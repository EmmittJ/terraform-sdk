using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageVersionDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_shared_image_version.
/// </summary>
public class AzurermSharedImageVersionDataSource : TerraformDataSource
{
    public AzurermSharedImageVersionDataSource(string name) : base("azurerm_shared_image_version", name)
    {
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    [TerraformPropertyName("gallery_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GalleryName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    [TerraformPropertyName("image_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ImageName { get; set; }

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
    /// The sort_versions_by_semver attribute.
    /// </summary>
    [TerraformPropertyName("sort_versions_by_semver")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SortVersionsBySemver { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSharedImageVersionDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    [TerraformPropertyName("exclude_from_latest")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ExcludeFromLatest => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "exclude_from_latest");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The managed_image_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_image_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ManagedImageId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "managed_image_id");

    /// <summary>
    /// The os_disk_image_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_image_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> OsDiskImageSizeGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "os_disk_image_size_gb");

    /// <summary>
    /// The os_disk_snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_snapshot_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OsDiskSnapshotId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "os_disk_snapshot_id");

    /// <summary>
    /// The target_region attribute.
    /// </summary>
    [TerraformPropertyName("target_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TargetRegion => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "target_region");

}
