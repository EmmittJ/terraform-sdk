using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSnapshotDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public TerraformBlock<AzurermSnapshotDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The creation_option attribute.
    /// </summary>
    [TerraformPropertyName("creation_option")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationOption => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_option");

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
    /// The time_created attribute.
    /// </summary>
    [TerraformPropertyName("time_created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeCreated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_created");

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    [TerraformPropertyName("trusted_launch_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> TrustedLaunchEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "trusted_launch_enabled");

}
