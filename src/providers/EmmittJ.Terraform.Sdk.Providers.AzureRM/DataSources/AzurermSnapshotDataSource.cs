using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSnapshotDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_snapshot.
/// </summary>
public partial class AzurermSnapshotDataSource : TerraformDataSource
{
    public AzurermSnapshotDataSource(string name) : base("azurerm_snapshot", name)
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
    public AzurermSnapshotDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The creation_option attribute.
    /// </summary>
    [TerraformProperty("creation_option")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationOption { get; }

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
    /// The time_created attribute.
    /// </summary>
    [TerraformProperty("time_created")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeCreated { get; }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    [TerraformProperty("trusted_launch_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> TrustedLaunchEnabled { get; }

}
