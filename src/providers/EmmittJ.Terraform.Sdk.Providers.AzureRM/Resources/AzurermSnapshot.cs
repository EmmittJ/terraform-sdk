using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSnapshotEncryptionSettingsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSnapshotTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_snapshot resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSnapshot : TerraformResource
{
    public AzurermSnapshot(string name) : base("azurerm_snapshot", name)
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
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DiskSizeGb { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The incremental_enabled attribute.
    /// </summary>
    [TerraformProperty("incremental_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IncrementalEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

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
    /// The source_resource_id attribute.
    /// </summary>
    [TerraformProperty("source_resource_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceResourceId { get; set; }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    [TerraformProperty("source_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceUri { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for encryption_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSettings block(s) allowed")]
    [TerraformProperty("encryption_settings")]
    public TerraformList<TerraformBlock<AzurermSnapshotEncryptionSettingsBlock>>? EncryptionSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSnapshotTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    [TerraformProperty("trusted_launch_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> TrustedLaunchEnabled { get; }

}
