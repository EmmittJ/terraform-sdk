using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCosmosdbSqlDatabaseDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_cosmosdb_sql_database.
/// </summary>
public partial class AzurermCosmosdbSqlDatabaseDataSource : TerraformDataSource
{
    public AzurermCosmosdbSqlDatabaseDataSource(string name) : base("azurerm_cosmosdb_sql_database", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccountName { get; set; }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermCosmosdbSqlDatabaseDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The autoscale_settings attribute.
    /// </summary>
    [TerraformProperty("autoscale_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AutoscaleSettings { get; }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformProperty("throughput")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Throughput { get; }

}
