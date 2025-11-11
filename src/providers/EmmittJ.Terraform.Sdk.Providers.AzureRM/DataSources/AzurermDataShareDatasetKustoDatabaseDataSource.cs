using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataShareDatasetKustoDatabaseDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_data_share_dataset_kusto_database.
/// </summary>
public partial class AzurermDataShareDatasetKustoDatabaseDataSource : TerraformDataSource
{
    public AzurermDataShareDatasetKustoDatabaseDataSource(string name) : base("azurerm_data_share_dataset_kusto_database", name)
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
    public TerraformBlock<AzurermDataShareDatasetKustoDatabaseDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The kusto_cluster_location attribute.
    /// </summary>
    [TerraformProperty("kusto_cluster_location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KustoClusterLocation { get; }

    /// <summary>
    /// The kusto_database_id attribute.
    /// </summary>
    [TerraformProperty("kusto_database_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KustoDatabaseId { get; }

}
