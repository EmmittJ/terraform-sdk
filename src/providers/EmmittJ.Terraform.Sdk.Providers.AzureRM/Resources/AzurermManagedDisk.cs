using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermManagedDiskEncryptionSettingsBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagedDiskTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_managed_disk resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermManagedDisk : TerraformResource
{
    public AzurermManagedDisk(string name) : base("azurerm_managed_disk", name)
    {
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    [TerraformPropertyName("create_option")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CreateOption { get; set; }

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_access_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DiskAccessId { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The disk_iops_read_only attribute.
    /// </summary>
    [TerraformPropertyName("disk_iops_read_only")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DiskIopsReadOnly { get; set; } = default!;

    /// <summary>
    /// The disk_iops_read_write attribute.
    /// </summary>
    [TerraformPropertyName("disk_iops_read_write")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DiskIopsReadWrite { get; set; } = default!;

    /// <summary>
    /// The disk_mbps_read_only attribute.
    /// </summary>
    [TerraformPropertyName("disk_mbps_read_only")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DiskMbpsReadOnly { get; set; } = default!;

    /// <summary>
    /// The disk_mbps_read_write attribute.
    /// </summary>
    [TerraformPropertyName("disk_mbps_read_write")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DiskMbpsReadWrite { get; set; } = default!;

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DiskSizeGb { get; set; } = default!;

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EdgeZone { get; set; }

    /// <summary>
    /// The gallery_image_reference_id attribute.
    /// </summary>
    [TerraformPropertyName("gallery_image_reference_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GalleryImageReferenceId { get; set; }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    [TerraformPropertyName("hyper_v_generation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HyperVGeneration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The image_reference_id attribute.
    /// </summary>
    [TerraformPropertyName("image_reference_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ImageReferenceId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The logical_sector_size attribute.
    /// </summary>
    [TerraformPropertyName("logical_sector_size")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> LogicalSectorSize { get; set; } = default!;

    /// <summary>
    /// The max_shares attribute.
    /// </summary>
    [TerraformPropertyName("max_shares")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxShares { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_access_policy attribute.
    /// </summary>
    [TerraformPropertyName("network_access_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NetworkAccessPolicy { get; set; }

    /// <summary>
    /// The on_demand_bursting_enabled attribute.
    /// </summary>
    [TerraformPropertyName("on_demand_bursting_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? OnDemandBurstingEnabled { get; set; }

    /// <summary>
    /// The optimized_frequent_attach_enabled attribute.
    /// </summary>
    [TerraformPropertyName("optimized_frequent_attach_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? OptimizedFrequentAttachEnabled { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OsType { get; set; }

    /// <summary>
    /// The performance_plus_enabled attribute.
    /// </summary>
    [TerraformPropertyName("performance_plus_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PerformancePlusEnabled { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("secure_vm_disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>
    /// The security_type attribute.
    /// </summary>
    [TerraformPropertyName("security_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecurityType { get; set; }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("source_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceResourceId { get; set; }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    [TerraformPropertyName("source_uri")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SourceUri { get; set; } = default!;

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageAccountId { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    [TerraformPropertyName("storage_account_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageAccountType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformPropertyName("tier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Tier { get; set; } = default!;

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    [TerraformPropertyName("trusted_launch_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TrustedLaunchEnabled { get; set; }

    /// <summary>
    /// The upload_size_bytes attribute.
    /// </summary>
    [TerraformPropertyName("upload_size_bytes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? UploadSizeBytes { get; set; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// Block for encryption_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSettings block(s) allowed")]
    [TerraformPropertyName("encryption_settings")]
    public TerraformList<TerraformBlock<AzurermManagedDiskEncryptionSettingsBlock>>? EncryptionSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermManagedDiskTimeoutsBlock>? Timeouts { get; set; }

}
