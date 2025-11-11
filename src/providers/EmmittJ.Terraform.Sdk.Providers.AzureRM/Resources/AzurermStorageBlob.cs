using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageBlobTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_storage_blob resource.
/// </summary>
public partial class AzurermStorageBlob : TerraformResource
{
    public AzurermStorageBlob(string name) : base("azurerm_storage_blob", name)
    {
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [TerraformProperty("access_tier")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AccessTier { get; set; }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    [TerraformProperty("cache_control")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CacheControl { get; set; }

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    [TerraformProperty("content_md5")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContentMd5 { get; set; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformProperty("content_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContentType { get; set; }

    /// <summary>
    /// The encryption_scope attribute.
    /// </summary>
    [TerraformProperty("encryption_scope")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EncryptionScope { get; set; }

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
    /// The parallelism attribute.
    /// </summary>
    [TerraformProperty("parallelism")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Parallelism { get; set; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformProperty("size")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Size { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformProperty("source")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Source { get; set; }

    /// <summary>
    /// The source_content attribute.
    /// </summary>
    [TerraformProperty("source_content")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceContent { get; set; }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    [TerraformProperty("source_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceUri { get; set; }

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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStorageBlobTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Url { get; }

}
