using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagedDiskDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermManagedDiskDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [TerraformPropertyName("create_option")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateOption => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_option");

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_access_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DiskAccessId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disk_access_id");

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DiskEncryptionSetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disk_encryption_set_id");

    /// <summary>
    /// The disk_iops_read_write attribute.
    /// </summary>
    [TerraformPropertyName("disk_iops_read_write")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DiskIopsReadWrite => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "disk_iops_read_write");

    /// <summary>
    /// The disk_mbps_read_write attribute.
    /// </summary>
    [TerraformPropertyName("disk_mbps_read_write")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DiskMbpsReadWrite => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "disk_mbps_read_write");

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DiskSizeGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "disk_size_gb");

    /// <summary>
    /// The encryption_settings attribute.
    /// </summary>
    [TerraformPropertyName("encryption_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EncryptionSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "encryption_settings");

    /// <summary>
    /// The image_reference_id attribute.
    /// </summary>
    [TerraformPropertyName("image_reference_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageReferenceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_reference_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The network_access_policy attribute.
    /// </summary>
    [TerraformPropertyName("network_access_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkAccessPolicy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_access_policy");

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OsType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "os_type");

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("source_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_resource_id");

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    [TerraformPropertyName("source_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_uri");

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_account_id");

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageAccountType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_account_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Zones => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "zones");

}
