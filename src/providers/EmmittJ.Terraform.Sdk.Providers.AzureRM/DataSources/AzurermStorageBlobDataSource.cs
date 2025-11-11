using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageBlobDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_storage_blob.
/// </summary>
public partial class AzurermStorageBlobDataSource : TerraformDataSource
{
    public AzurermStorageBlobDataSource(string name) : base("azurerm_storage_blob", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Metadata { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    [TerraformProperty("storage_account_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageAccountName { get; set; }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerName is required")]
    [TerraformProperty("storage_container_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageContainerName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStorageBlobDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [TerraformProperty("access_tier")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccessTier { get; }

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    [TerraformProperty("content_md5")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContentMd5 { get; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformProperty("content_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContentType { get; }

    /// <summary>
    /// The encryption_scope attribute.
    /// </summary>
    [TerraformProperty("encryption_scope")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EncryptionScope { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Url { get; }

}
