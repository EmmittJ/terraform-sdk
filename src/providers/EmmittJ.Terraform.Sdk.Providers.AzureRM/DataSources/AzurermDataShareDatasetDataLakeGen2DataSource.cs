using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataShareDatasetDataLakeGen2DataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_data_share_dataset_data_lake_gen2.
/// </summary>
public class AzurermDataShareDatasetDataLakeGen2DataSource : TerraformDataSource
{
    public AzurermDataShareDatasetDataLakeGen2DataSource(string name) : base("azurerm_data_share_dataset_data_lake_gen2", name)
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
    /// The share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareId is required")]
    [TerraformPropertyName("share_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ShareId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDataShareDatasetDataLakeGen2DataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

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
    /// The file_system_name attribute.
    /// </summary>
    [TerraformPropertyName("file_system_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FileSystemName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "file_system_name");

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    [TerraformPropertyName("folder_path")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FolderPath => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "folder_path");

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_account_id");

}
