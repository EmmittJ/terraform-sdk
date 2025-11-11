using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSnapshotDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_snapshot.
/// </summary>
public class AzurermSnapshotDataSource : TerraformDataSource
{
    public AzurermSnapshotDataSource(string name) : base("azurerm_snapshot", name)
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
    public TerraformBlock<AzurermSnapshotDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The creation_option attribute.
    /// </summary>
    [TerraformPropertyName("creation_option")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationOption => new TerraformReference(this, "creation_option");

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
    /// The time_created attribute.
    /// </summary>
    [TerraformPropertyName("time_created")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeCreated => new TerraformReference(this, "time_created");

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    [TerraformPropertyName("trusted_launch_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> TrustedLaunchEnabled => new TerraformReference(this, "trusted_launch_enabled");

}
