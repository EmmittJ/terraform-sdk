using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataShareDatasetKustoDatabaseDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_data_share_dataset_kusto_database.
/// </summary>
public class AzurermDataShareDatasetKustoDatabaseDataSource : TerraformDataSource
{
    public AzurermDataShareDatasetKustoDatabaseDataSource(string name) : base("azurerm_data_share_dataset_kusto_database", name)
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
    public TerraformBlock<AzurermDataShareDatasetKustoDatabaseDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The kusto_cluster_location attribute.
    /// </summary>
    [TerraformPropertyName("kusto_cluster_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KustoClusterLocation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kusto_cluster_location");

    /// <summary>
    /// The kusto_database_id attribute.
    /// </summary>
    [TerraformPropertyName("kusto_database_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KustoDatabaseId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kusto_database_id");

}
