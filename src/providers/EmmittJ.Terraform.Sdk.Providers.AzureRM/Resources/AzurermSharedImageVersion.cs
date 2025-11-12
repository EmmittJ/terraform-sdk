using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for target_region in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSharedImageVersionTargetRegionBlock() : TerraformBlock("target_region")
{
    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("disk_encryption_set_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The exclude_from_latest_enabled attribute.
    /// </summary>
    [TerraformProperty("exclude_from_latest_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExcludeFromLatestEnabled { get; set; }

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
public partial class AzurermSharedImageVersionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_shared_image_version resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSharedImageVersion : TerraformResource
{
    public AzurermSharedImageVersion(string name) : base("azurerm_shared_image_version", name)
    {
    }

    /// <summary>
    /// The blob_uri attribute.
    /// </summary>
    [TerraformProperty("blob_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BlobUri { get; set; }

    /// <summary>
    /// The deletion_of_replicated_locations_enabled attribute.
    /// </summary>
    [TerraformProperty("deletion_of_replicated_locations_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeletionOfReplicatedLocationsEnabled { get; set; }

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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_image_id attribute.
    /// </summary>
    [TerraformProperty("managed_image_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManagedImageId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The os_disk_snapshot_id attribute.
    /// </summary>
    [TerraformProperty("os_disk_snapshot_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OsDiskSnapshotId { get; set; }

    /// <summary>
    /// The replication_mode attribute.
    /// </summary>
    [TerraformProperty("replication_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReplicationMode { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for target_region.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRegion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetRegion block(s) required")]
    [TerraformProperty("target_region")]
    public required TerraformList<AzurermSharedImageVersionTargetRegionBlock> TargetRegion { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSharedImageVersionTimeoutsBlock Timeouts { get; set; } = new();

}
