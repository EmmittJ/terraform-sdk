using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudAppCosmosdbAssociationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_spring_cloud_app_cosmosdb_association resource.
/// </summary>
public class AzurermSpringCloudAppCosmosdbAssociation : TerraformResource
{
    public AzurermSpringCloudAppCosmosdbAssociation(string name) : base("azurerm_spring_cloud_app_cosmosdb_association", name)
    {
    }

    /// <summary>
    /// The api_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiType is required")]
    [TerraformPropertyName("api_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApiType { get; set; }

    /// <summary>
    /// The cosmosdb_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbAccessKey is required")]
    [TerraformPropertyName("cosmosdb_access_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CosmosdbAccessKey { get; set; }

    /// <summary>
    /// The cosmosdb_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbAccountId is required")]
    [TerraformPropertyName("cosmosdb_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CosmosdbAccountId { get; set; }

    /// <summary>
    /// The cosmosdb_cassandra_keyspace_name attribute.
    /// </summary>
    [TerraformPropertyName("cosmosdb_cassandra_keyspace_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CosmosdbCassandraKeyspaceName { get; set; }

    /// <summary>
    /// The cosmosdb_gremlin_database_name attribute.
    /// </summary>
    [TerraformPropertyName("cosmosdb_gremlin_database_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CosmosdbGremlinDatabaseName { get; set; }

    /// <summary>
    /// The cosmosdb_gremlin_graph_name attribute.
    /// </summary>
    [TerraformPropertyName("cosmosdb_gremlin_graph_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CosmosdbGremlinGraphName { get; set; }

    /// <summary>
    /// The cosmosdb_mongo_database_name attribute.
    /// </summary>
    [TerraformPropertyName("cosmosdb_mongo_database_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CosmosdbMongoDatabaseName { get; set; }

    /// <summary>
    /// The cosmosdb_sql_database_name attribute.
    /// </summary>
    [TerraformPropertyName("cosmosdb_sql_database_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CosmosdbSqlDatabaseName { get; set; }

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
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    [TerraformPropertyName("spring_cloud_app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SpringCloudAppId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSpringCloudAppCosmosdbAssociationTimeoutsBlock>? Timeouts { get; set; } = new();

}
