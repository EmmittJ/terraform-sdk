using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermManagedDiskDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_managed_disk.
/// </summary>
public partial class AzurermManagedDiskDataSource : TerraformDataSource
{
    public AzurermManagedDiskDataSource(string name) : base("azurerm_managed_disk", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermManagedDiskDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [TerraformProperty("create_option")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateOption { get; }

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    [TerraformProperty("disk_access_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DiskAccessId { get; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("disk_encryption_set_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DiskEncryptionSetId { get; }

    /// <summary>
    /// The disk_iops_read_write attribute.
    /// </summary>
    [TerraformProperty("disk_iops_read_write")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DiskIopsReadWrite { get; }

    /// <summary>
    /// The disk_mbps_read_write attribute.
    /// </summary>
    [TerraformProperty("disk_mbps_read_write")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DiskMbpsReadWrite { get; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DiskSizeGb { get; }

    /// <summary>
    /// The encryption_settings attribute.
    /// </summary>
    [TerraformProperty("encryption_settings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EncryptionSettings { get; }

    /// <summary>
    /// The image_reference_id attribute.
    /// </summary>
    [TerraformProperty("image_reference_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImageReferenceId { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The network_access_policy attribute.
    /// </summary>
    [TerraformProperty("network_access_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkAccessPolicy { get; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformProperty("os_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OsType { get; }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [TerraformProperty("source_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceResourceId { get; }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    [TerraformProperty("source_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceUri { get; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageAccountId { get; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformProperty("storage_account_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageAccountType { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Zones { get; }

}
