using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataShareDatasetKustoClusterDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_data_share_dataset_kusto_cluster.
/// </summary>
public class AzurermDataShareDatasetKustoClusterDataSource : TerraformDataSource
{
    public AzurermDataShareDatasetKustoClusterDataSource(string name) : base("azurerm_data_share_dataset_kusto_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareId is required")]
    [TerraformPropertyName("share_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ShareId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDataShareDatasetKustoClusterDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The kusto_cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("kusto_cluster_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KustoClusterId => new TerraformReference(this, "kusto_cluster_id");

    /// <summary>
    /// The kusto_cluster_location attribute.
    /// </summary>
    [TerraformPropertyName("kusto_cluster_location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KustoClusterLocation => new TerraformReference(this, "kusto_cluster_location");

}
