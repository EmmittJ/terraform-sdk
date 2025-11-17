using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSpringCloudAppCosmosdbAssociation.
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_spring_cloud_app_cosmosdb_association Terraform resource.
/// Manages a azurerm_spring_cloud_app_cosmosdb_association resource.
/// </summary>
public partial class AzurermSpringCloudAppCosmosdbAssociation(string name) : TerraformResource("azurerm_spring_cloud_app_cosmosdb_association", name)
{
    /// <summary>
    /// The api_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiType is required")]
    public required TerraformValue<string> ApiType
    {
        get => new TerraformReference<string>(this, "api_type");
        set => SetArgument("api_type", value);
    }

    /// <summary>
    /// The cosmosdb_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbAccessKey is required")]
    public required TerraformValue<string> CosmosdbAccessKey
    {
        get => new TerraformReference<string>(this, "cosmosdb_access_key");
        set => SetArgument("cosmosdb_access_key", value);
    }

    /// <summary>
    /// The cosmosdb_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbAccountId is required")]
    public required TerraformValue<string> CosmosdbAccountId
    {
        get => new TerraformReference<string>(this, "cosmosdb_account_id");
        set => SetArgument("cosmosdb_account_id", value);
    }

    /// <summary>
    /// The cosmosdb_cassandra_keyspace_name attribute.
    /// </summary>
    public TerraformValue<string>? CosmosdbCassandraKeyspaceName
    {
        get => new TerraformReference<string>(this, "cosmosdb_cassandra_keyspace_name");
        set => SetArgument("cosmosdb_cassandra_keyspace_name", value);
    }

    /// <summary>
    /// The cosmosdb_gremlin_database_name attribute.
    /// </summary>
    public TerraformValue<string>? CosmosdbGremlinDatabaseName
    {
        get => new TerraformReference<string>(this, "cosmosdb_gremlin_database_name");
        set => SetArgument("cosmosdb_gremlin_database_name", value);
    }

    /// <summary>
    /// The cosmosdb_gremlin_graph_name attribute.
    /// </summary>
    public TerraformValue<string>? CosmosdbGremlinGraphName
    {
        get => new TerraformReference<string>(this, "cosmosdb_gremlin_graph_name");
        set => SetArgument("cosmosdb_gremlin_graph_name", value);
    }

    /// <summary>
    /// The cosmosdb_mongo_database_name attribute.
    /// </summary>
    public TerraformValue<string>? CosmosdbMongoDatabaseName
    {
        get => new TerraformReference<string>(this, "cosmosdb_mongo_database_name");
        set => SetArgument("cosmosdb_mongo_database_name", value);
    }

    /// <summary>
    /// The cosmosdb_sql_database_name attribute.
    /// </summary>
    public TerraformValue<string>? CosmosdbSqlDatabaseName
    {
        get => new TerraformReference<string>(this, "cosmosdb_sql_database_name");
        set => SetArgument("cosmosdb_sql_database_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    public required TerraformValue<string> SpringCloudAppId
    {
        get => new TerraformReference<string>(this, "spring_cloud_app_id");
        set => SetArgument("spring_cloud_app_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudAppCosmosdbAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudAppCosmosdbAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
