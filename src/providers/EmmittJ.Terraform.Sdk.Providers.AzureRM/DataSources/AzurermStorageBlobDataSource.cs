using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageBlobDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_storage_blob.
/// </summary>
public class AzurermStorageBlobDataSource : TerraformDataSource
{
    public AzurermStorageBlobDataSource(string name) : base("azurerm_storage_blob", name)
    {
    }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageBlobDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [TerraformPropertyName("access_tier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessTier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_tier");

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    [TerraformPropertyName("content_md5")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentMd5 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_md5");

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_type");

    /// <summary>
    /// The encryption_scope attribute.
    /// </summary>
    [TerraformPropertyName("encryption_scope")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EncryptionScope => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "encryption_scope");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Url => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "url");

}
