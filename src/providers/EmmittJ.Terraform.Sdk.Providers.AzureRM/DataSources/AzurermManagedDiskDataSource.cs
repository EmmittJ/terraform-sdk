using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagedDiskDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_managed_disk.
/// </summary>
public class AzurermManagedDiskDataSource : TerraformDataSource
{
    public AzurermManagedDiskDataSource(string name) : base("azurerm_managed_disk", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermManagedDiskDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [TerraformPropertyName("create_option")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateOption => new TerraformReference(this, "create_option");

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_access_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DiskAccessId => new TerraformReference(this, "disk_access_id");

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DiskEncryptionSetId => new TerraformReference(this, "disk_encryption_set_id");

    /// <summary>
    /// The disk_iops_read_write attribute.
    /// </summary>
    [TerraformPropertyName("disk_iops_read_write")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DiskIopsReadWrite => new TerraformReference(this, "disk_iops_read_write");

    /// <summary>
    /// The disk_mbps_read_write attribute.
    /// </summary>
    [TerraformPropertyName("disk_mbps_read_write")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DiskMbpsReadWrite => new TerraformReference(this, "disk_mbps_read_write");

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DiskSizeGb => new TerraformReference(this, "disk_size_gb");

    /// <summary>
    /// The encryption_settings attribute.
    /// </summary>
    [TerraformPropertyName("encryption_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EncryptionSettings => new TerraformReference(this, "encryption_settings");

    /// <summary>
    /// The image_reference_id attribute.
    /// </summary>
    [TerraformPropertyName("image_reference_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageReferenceId => new TerraformReference(this, "image_reference_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The network_access_policy attribute.
    /// </summary>
    [TerraformPropertyName("network_access_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkAccessPolicy => new TerraformReference(this, "network_access_policy");

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OsType => new TerraformReference(this, "os_type");

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("source_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceResourceId => new TerraformReference(this, "source_resource_id");

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    [TerraformPropertyName("source_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceUri => new TerraformReference(this, "source_uri");

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageAccountId => new TerraformReference(this, "storage_account_id");

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageAccountType => new TerraformReference(this, "storage_account_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Zones => new TerraformReference(this, "zones");

}
