using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageTableEntityDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_storage_table_entity.
/// </summary>
public partial class AzurermStorageTableEntityDataSource : TerraformDataSource
{
    public AzurermStorageTableEntityDataSource(string name) : base("azurerm_storage_table_entity", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKey is required")]
    [TerraformProperty("partition_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PartitionKey { get; set; }

    /// <summary>
    /// The row_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RowKey is required")]
    [TerraformProperty("row_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RowKey { get; set; }

    /// <summary>
    /// The storage_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageTableId is required")]
    [TerraformProperty("storage_table_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageTableId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStorageTableEntityDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The entity attribute.
    /// </summary>
    [TerraformProperty("entity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Entity { get; }

}
