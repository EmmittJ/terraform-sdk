using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudAppCosmosdbAssociationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_spring_cloud_app_cosmosdb_association resource.
/// </summary>
public partial class AzurermSpringCloudAppCosmosdbAssociation : TerraformResource
{
    public AzurermSpringCloudAppCosmosdbAssociation(string name) : base("azurerm_spring_cloud_app_cosmosdb_association", name)
    {
    }

    /// <summary>
    /// The api_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiType is required")]
    [TerraformProperty("api_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiType { get; set; }

    /// <summary>
    /// The cosmosdb_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbAccessKey is required")]
    [TerraformProperty("cosmosdb_access_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CosmosdbAccessKey { get; set; }

    /// <summary>
    /// The cosmosdb_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbAccountId is required")]
    [TerraformProperty("cosmosdb_account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CosmosdbAccountId { get; set; }

    /// <summary>
    /// The cosmosdb_cassandra_keyspace_name attribute.
    /// </summary>
    [TerraformProperty("cosmosdb_cassandra_keyspace_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CosmosdbCassandraKeyspaceName { get; set; }

    /// <summary>
    /// The cosmosdb_gremlin_database_name attribute.
    /// </summary>
    [TerraformProperty("cosmosdb_gremlin_database_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CosmosdbGremlinDatabaseName { get; set; }

    /// <summary>
    /// The cosmosdb_gremlin_graph_name attribute.
    /// </summary>
    [TerraformProperty("cosmosdb_gremlin_graph_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CosmosdbGremlinGraphName { get; set; }

    /// <summary>
    /// The cosmosdb_mongo_database_name attribute.
    /// </summary>
    [TerraformProperty("cosmosdb_mongo_database_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CosmosdbMongoDatabaseName { get; set; }

    /// <summary>
    /// The cosmosdb_sql_database_name attribute.
    /// </summary>
    [TerraformProperty("cosmosdb_sql_database_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CosmosdbSqlDatabaseName { get; set; }

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
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    [TerraformProperty("spring_cloud_app_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SpringCloudAppId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSpringCloudAppCosmosdbAssociationTimeoutsBlock>? Timeouts { get; set; }

}
