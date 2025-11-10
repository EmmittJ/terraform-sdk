using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataShareDatasetBlobStorageDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_data_share_dataset_blob_storage.
/// </summary>
public class AzurermDataShareDatasetBlobStorageDataSource : TerraformDataSource
{
    public AzurermDataShareDatasetBlobStorageDataSource(string name) : base("azurerm_data_share_dataset_blob_storage", name)
    {
    }

    /// <summary>
    /// The data_share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataShareId is required")]
    [TerraformPropertyName("data_share_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataShareId { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDataShareDatasetBlobStorageDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [TerraformPropertyName("container_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContainerName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "container_name");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The file_path attribute.
    /// </summary>
    [TerraformPropertyName("file_path")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FilePath => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "file_path");

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    [TerraformPropertyName("folder_path")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FolderPath => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "folder_path");

    /// <summary>
    /// The storage_account attribute.
    /// </summary>
    [TerraformPropertyName("storage_account")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StorageAccount => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "storage_account");

}
