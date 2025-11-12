using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataShareDatasetDataLakeGen2TimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_data_share_dataset_data_lake_gen2 resource.
/// </summary>
public partial class AzurermDataShareDatasetDataLakeGen2 : TerraformResource
{
    public AzurermDataShareDatasetDataLakeGen2(string name) : base("azurerm_data_share_dataset_data_lake_gen2", name)
    {
    }

    /// <summary>
    /// The file_path attribute.
    /// </summary>
    [TerraformProperty("file_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FilePath { get; set; }

    /// <summary>
    /// The file_system_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemName is required")]
    [TerraformProperty("file_system_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FileSystemName { get; set; }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    [TerraformProperty("folder_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FolderPath { get; set; }

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
    /// The share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareId is required")]
    [TerraformProperty("share_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ShareId { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDataShareDatasetDataLakeGen2TimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

}
