using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbSqlDatabaseDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_cosmosdb_sql_database.
/// </summary>
public class AzurermCosmosdbSqlDatabaseDataSource : TerraformDataSource
{
    public AzurermCosmosdbSqlDatabaseDataSource(string name) : base("azurerm_cosmosdb_sql_database", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccountName { get; set; }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCosmosdbSqlDatabaseDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The autoscale_settings attribute.
    /// </summary>
    [TerraformPropertyName("autoscale_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AutoscaleSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "autoscale_settings");

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformPropertyName("throughput")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Throughput => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "throughput");

}
