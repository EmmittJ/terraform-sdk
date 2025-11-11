using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageTableEntitiesDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_storage_table_entities.
/// </summary>
public partial class AzurermStorageTableEntitiesDataSource : TerraformDataSource
{
    public AzurermStorageTableEntitiesDataSource(string name) : base("azurerm_storage_table_entities", name)
    {
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformProperty("filter")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The select attribute.
    /// </summary>
    [TerraformProperty("select")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Select { get; set; }

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
    public TerraformBlock<AzurermStorageTableEntitiesDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The items attribute.
    /// </summary>
    [TerraformProperty("items")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Items { get; }

}
