using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataShareDatasetBlobStorageDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_data_share_dataset_blob_storage.
/// </summary>
public partial class AzurermDataShareDatasetBlobStorageDataSource : TerraformDataSource
{
    public AzurermDataShareDatasetBlobStorageDataSource(string name) : base("azurerm_data_share_dataset_blob_storage", name)
    {
    }

    /// <summary>
    /// The data_share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataShareId is required")]
    [TerraformProperty("data_share_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataShareId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDataShareDatasetBlobStorageDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [TerraformProperty("container_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ContainerName { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The file_path attribute.
    /// </summary>
    [TerraformProperty("file_path")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FilePath { get; }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    [TerraformProperty("folder_path")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FolderPath { get; }

    /// <summary>
    /// The storage_account attribute.
    /// </summary>
    [TerraformProperty("storage_account")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> StorageAccount { get; }

}
