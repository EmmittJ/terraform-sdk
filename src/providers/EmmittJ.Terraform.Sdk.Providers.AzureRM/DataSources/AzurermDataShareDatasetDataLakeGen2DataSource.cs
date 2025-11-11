using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataShareDatasetDataLakeGen2DataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_data_share_dataset_data_lake_gen2.
/// </summary>
public partial class AzurermDataShareDatasetDataLakeGen2DataSource : TerraformDataSource
{
    public AzurermDataShareDatasetDataLakeGen2DataSource(string name) : base("azurerm_data_share_dataset_data_lake_gen2", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareId is required")]
    [TerraformProperty("share_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ShareId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermDataShareDatasetDataLakeGen2DataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The file_path attribute.
    /// </summary>
    [TerraformProperty("file_path")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FilePath { get; }

    /// <summary>
    /// The file_system_name attribute.
    /// </summary>
    [TerraformProperty("file_system_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FileSystemName { get; }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    [TerraformProperty("folder_path")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FolderPath { get; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StorageAccountId { get; }

}
