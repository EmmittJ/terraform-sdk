using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStreamAnalyticsOutputCosmosdbTimeoutsBlock() : TerraformBlock("timeouts")
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_stream_analytics_output_cosmosdb resource.
/// </summary>
public partial class AzurermStreamAnalyticsOutputCosmosdb : TerraformResource
{
    public AzurermStreamAnalyticsOutputCosmosdb(string name) : base("azurerm_stream_analytics_output_cosmosdb", name)
    {
    }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    [TerraformProperty("authentication_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthenticationMode { get; set; }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformProperty("container_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerName { get; set; }

    /// <summary>
    /// The cosmosdb_account_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbAccountKey is required")]
    [TerraformProperty("cosmosdb_account_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CosmosdbAccountKey { get; set; }

    /// <summary>
    /// The cosmosdb_sql_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbSqlDatabaseId is required")]
    [TerraformProperty("cosmosdb_sql_database_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CosmosdbSqlDatabaseId { get; set; }

    /// <summary>
    /// The document_id attribute.
    /// </summary>
    [TerraformProperty("document_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DocumentId { get; set; }

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
    /// The partition_key attribute.
    /// </summary>
    [TerraformProperty("partition_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PartitionKey { get; set; }

    /// <summary>
    /// The stream_analytics_job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobId is required")]
    [TerraformProperty("stream_analytics_job_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StreamAnalyticsJobId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermStreamAnalyticsOutputCosmosdbTimeoutsBlock Timeouts { get; set; } = new();

}
