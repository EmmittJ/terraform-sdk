using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSharedImageVersionDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_shared_image_version.
/// </summary>
public partial class AzurermSharedImageVersionDataSource : TerraformDataSource
{
    public AzurermSharedImageVersionDataSource(string name) : base("azurerm_shared_image_version", name)
    {
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    [TerraformProperty("gallery_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GalleryName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    [TerraformProperty("image_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ImageName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sort_versions_by_semver attribute.
    /// </summary>
    [TerraformProperty("sort_versions_by_semver")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SortVersionsBySemver { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermSharedImageVersionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    [TerraformProperty("exclude_from_latest")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ExcludeFromLatest { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The managed_image_id attribute.
    /// </summary>
    [TerraformProperty("managed_image_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ManagedImageId { get; }

    /// <summary>
    /// The os_disk_image_size_gb attribute.
    /// </summary>
    [TerraformProperty("os_disk_image_size_gb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> OsDiskImageSizeGb { get; }

    /// <summary>
    /// The os_disk_snapshot_id attribute.
    /// </summary>
    [TerraformProperty("os_disk_snapshot_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OsDiskSnapshotId { get; }

    /// <summary>
    /// The target_region attribute.
    /// </summary>
    [TerraformProperty("target_region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TargetRegion { get; }

}
