using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageVersionDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    public required TerraformValue<string> GalleryName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    [TerraformPropertyName("image_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ImageName { get; set; }

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
    /// The sort_versions_by_semver attribute.
    /// </summary>
    [TerraformPropertyName("sort_versions_by_semver")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SortVersionsBySemver { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSharedImageVersionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    [TerraformPropertyName("exclude_from_latest")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ExcludeFromLatest => new TerraformReference(this, "exclude_from_latest");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The managed_image_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_image_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ManagedImageId => new TerraformReference(this, "managed_image_id");

    /// <summary>
    /// The os_disk_image_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_image_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> OsDiskImageSizeGb => new TerraformReference(this, "os_disk_image_size_gb");

    /// <summary>
    /// The os_disk_snapshot_id attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_snapshot_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OsDiskSnapshotId => new TerraformReference(this, "os_disk_snapshot_id");

    /// <summary>
    /// The target_region attribute.
    /// </summary>
    [TerraformPropertyName("target_region")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TargetRegion => new TerraformReference(this, "target_region");

}
