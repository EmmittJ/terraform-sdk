using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermManagedDiskEncryptionSettingsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermManagedDiskTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_managed_disk resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermManagedDisk : TerraformResource
{
    public AzurermManagedDisk(string name) : base("azurerm_managed_disk", name)
    {
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    [TerraformProperty("create_option")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CreateOption { get; set; }

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    [TerraformProperty("disk_access_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DiskAccessId { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("disk_encryption_set_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The disk_iops_read_only attribute.
    /// </summary>
    [TerraformProperty("disk_iops_read_only")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DiskIopsReadOnly { get; set; }

    /// <summary>
    /// The disk_iops_read_write attribute.
    /// </summary>
    [TerraformProperty("disk_iops_read_write")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DiskIopsReadWrite { get; set; }

    /// <summary>
    /// The disk_mbps_read_only attribute.
    /// </summary>
    [TerraformProperty("disk_mbps_read_only")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DiskMbpsReadOnly { get; set; }

    /// <summary>
    /// The disk_mbps_read_write attribute.
    /// </summary>
    [TerraformProperty("disk_mbps_read_write")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DiskMbpsReadWrite { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DiskSizeGb { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformProperty("edge_zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EdgeZone { get; set; }

    /// <summary>
    /// The gallery_image_reference_id attribute.
    /// </summary>
    [TerraformProperty("gallery_image_reference_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GalleryImageReferenceId { get; set; }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    [TerraformProperty("hyper_v_generation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HyperVGeneration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_reference_id attribute.
    /// </summary>
    [TerraformProperty("image_reference_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ImageReferenceId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The logical_sector_size attribute.
    /// </summary>
    [TerraformProperty("logical_sector_size")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> LogicalSectorSize { get; set; }

    /// <summary>
    /// The max_shares attribute.
    /// </summary>
    [TerraformProperty("max_shares")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaxShares { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_access_policy attribute.
    /// </summary>
    [TerraformProperty("network_access_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NetworkAccessPolicy { get; set; }

    /// <summary>
    /// The on_demand_bursting_enabled attribute.
    /// </summary>
    [TerraformProperty("on_demand_bursting_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? OnDemandBurstingEnabled { get; set; }

    /// <summary>
    /// The optimized_frequent_attach_enabled attribute.
    /// </summary>
    [TerraformProperty("optimized_frequent_attach_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? OptimizedFrequentAttachEnabled { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformProperty("os_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OsType { get; set; }

    /// <summary>
    /// The performance_plus_enabled attribute.
    /// </summary>
    [TerraformProperty("performance_plus_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PerformancePlusEnabled { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("secure_vm_disk_encryption_set_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>
    /// The security_type attribute.
    /// </summary>
    [TerraformProperty("security_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecurityType { get; set; }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [TerraformProperty("source_resource_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceResourceId { get; set; }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    [TerraformProperty("source_uri")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SourceUri { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountId { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    [TerraformProperty("storage_account_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageAccountType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformProperty("tier")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Tier { get; set; }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    [TerraformProperty("trusted_launch_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TrustedLaunchEnabled { get; set; }

    /// <summary>
    /// The upload_size_bytes attribute.
    /// </summary>
    [TerraformProperty("upload_size_bytes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? UploadSizeBytes { get; set; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// Block for encryption_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSettings block(s) allowed")]
    [TerraformProperty("encryption_settings")]
    public TerraformList<TerraformBlock<AzurermManagedDiskEncryptionSettingsBlock>>? EncryptionSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermManagedDiskTimeoutsBlock>? Timeouts { get; set; }

}
