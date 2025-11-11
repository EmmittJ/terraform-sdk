using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataShareDatasetKustoClusterDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_data_share_dataset_kusto_cluster.
/// </summary>
public partial class AzurermDataShareDatasetKustoClusterDataSource : TerraformDataSource
{
    public AzurermDataShareDatasetKustoClusterDataSource(string name) : base("azurerm_data_share_dataset_kusto_cluster", name)
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
    public TerraformBlock<AzurermDataShareDatasetKustoClusterDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The kusto_cluster_id attribute.
    /// </summary>
    [TerraformProperty("kusto_cluster_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KustoClusterId { get; }

    /// <summary>
    /// The kusto_cluster_location attribute.
    /// </summary>
    [TerraformProperty("kusto_cluster_location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KustoClusterLocation { get; }

}
