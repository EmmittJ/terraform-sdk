using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageBlobTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_storage_blob resource.
/// </summary>
public class AzurermStorageBlob : TerraformResource
{
    public AzurermStorageBlob(string name) : base("azurerm_storage_blob", name)
    {
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [TerraformPropertyName("access_tier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AccessTier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_tier");

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    [TerraformPropertyName("cache_control")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CacheControl { get; set; }

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    [TerraformPropertyName("content_md5")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContentMd5 { get; set; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContentType { get; set; }

    /// <summary>
    /// The encryption_scope attribute.
    /// </summary>
    [TerraformPropertyName("encryption_scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EncryptionScope { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Metadata { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "metadata");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    [TerraformPropertyName("parallelism")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Parallelism { get; set; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformPropertyName("size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Size { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformPropertyName("source")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Source { get; set; }

    /// <summary>
    /// The source_content attribute.
    /// </summary>
    [TerraformPropertyName("source_content")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceContent { get; set; }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    [TerraformPropertyName("source_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceUri { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    [TerraformPropertyName("storage_account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountName { get; set; }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerName is required")]
    [TerraformPropertyName("storage_container_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageContainerName { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageBlobTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Url => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "url");

}
