using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudAppCosmosdbAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("api_type")]
    public required TerraformValue<string> ApiType
    {
        get => new TerraformReference<string>(this, "api_type");
        set => SetArgument("api_type", value);
    }

    /// <summary>
    /// The cosmosdb_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbAccessKey is required")]
    [TerraformArgument("cosmosdb_access_key")]
    public required TerraformValue<string> CosmosdbAccessKey
    {
        get => new TerraformReference<string>(this, "cosmosdb_access_key");
        set => SetArgument("cosmosdb_access_key", value);
    }

    /// <summary>
    /// The cosmosdb_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbAccountId is required")]
    [TerraformArgument("cosmosdb_account_id")]
    public required TerraformValue<string> CosmosdbAccountId
    {
        get => new TerraformReference<string>(this, "cosmosdb_account_id");
        set => SetArgument("cosmosdb_account_id", value);
    }

    /// <summary>
    /// The cosmosdb_cassandra_keyspace_name attribute.
    /// </summary>
    [TerraformArgument("cosmosdb_cassandra_keyspace_name")]
    public TerraformValue<string>? CosmosdbCassandraKeyspaceName
    {
        get => new TerraformReference<string>(this, "cosmosdb_cassandra_keyspace_name");
        set => SetArgument("cosmosdb_cassandra_keyspace_name", value);
    }

    /// <summary>
    /// The cosmosdb_gremlin_database_name attribute.
    /// </summary>
    [TerraformArgument("cosmosdb_gremlin_database_name")]
    public TerraformValue<string>? CosmosdbGremlinDatabaseName
    {
        get => new TerraformReference<string>(this, "cosmosdb_gremlin_database_name");
        set => SetArgument("cosmosdb_gremlin_database_name", value);
    }

    /// <summary>
    /// The cosmosdb_gremlin_graph_name attribute.
    /// </summary>
    [TerraformArgument("cosmosdb_gremlin_graph_name")]
    public TerraformValue<string>? CosmosdbGremlinGraphName
    {
        get => new TerraformReference<string>(this, "cosmosdb_gremlin_graph_name");
        set => SetArgument("cosmosdb_gremlin_graph_name", value);
    }

    /// <summary>
    /// The cosmosdb_mongo_database_name attribute.
    /// </summary>
    [TerraformArgument("cosmosdb_mongo_database_name")]
    public TerraformValue<string>? CosmosdbMongoDatabaseName
    {
        get => new TerraformReference<string>(this, "cosmosdb_mongo_database_name");
        set => SetArgument("cosmosdb_mongo_database_name", value);
    }

    /// <summary>
    /// The cosmosdb_sql_database_name attribute.
    /// </summary>
    [TerraformArgument("cosmosdb_sql_database_name")]
    public TerraformValue<string>? CosmosdbSqlDatabaseName
    {
        get => new TerraformReference<string>(this, "cosmosdb_sql_database_name");
        set => SetArgument("cosmosdb_sql_database_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    [TerraformArgument("spring_cloud_app_id")]
    public required TerraformValue<string> SpringCloudAppId
    {
        get => new TerraformReference<string>(this, "spring_cloud_app_id");
        set => SetArgument("spring_cloud_app_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSpringCloudAppCosmosdbAssociationTimeoutsBlock Timeouts { get; set; } = new();

}
