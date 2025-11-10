using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudAppCosmosdbAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_spring_cloud_app_cosmosdb_association resource.
/// </summary>
public class AzurermSpringCloudAppCosmosdbAssociation : TerraformResource
{
    public AzurermSpringCloudAppCosmosdbAssociation(string name) : base("azurerm_spring_cloud_app_cosmosdb_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiType is required")]
    public required TerraformProperty<string> ApiType
    {
        get => GetProperty<TerraformProperty<string>>("api_type");
        set => this.WithProperty("api_type", value);
    }

    /// <summary>
    /// The cosmosdb_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbAccessKey is required")]
    public required TerraformProperty<string> CosmosdbAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("cosmosdb_access_key");
        set => this.WithProperty("cosmosdb_access_key", value);
    }

    /// <summary>
    /// The cosmosdb_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbAccountId is required")]
    public required TerraformProperty<string> CosmosdbAccountId
    {
        get => GetProperty<TerraformProperty<string>>("cosmosdb_account_id");
        set => this.WithProperty("cosmosdb_account_id", value);
    }

    /// <summary>
    /// The cosmosdb_cassandra_keyspace_name attribute.
    /// </summary>
    public TerraformProperty<string>? CosmosdbCassandraKeyspaceName
    {
        get => GetProperty<TerraformProperty<string>>("cosmosdb_cassandra_keyspace_name");
        set => this.WithProperty("cosmosdb_cassandra_keyspace_name", value);
    }

    /// <summary>
    /// The cosmosdb_gremlin_database_name attribute.
    /// </summary>
    public TerraformProperty<string>? CosmosdbGremlinDatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("cosmosdb_gremlin_database_name");
        set => this.WithProperty("cosmosdb_gremlin_database_name", value);
    }

    /// <summary>
    /// The cosmosdb_gremlin_graph_name attribute.
    /// </summary>
    public TerraformProperty<string>? CosmosdbGremlinGraphName
    {
        get => GetProperty<TerraformProperty<string>>("cosmosdb_gremlin_graph_name");
        set => this.WithProperty("cosmosdb_gremlin_graph_name", value);
    }

    /// <summary>
    /// The cosmosdb_mongo_database_name attribute.
    /// </summary>
    public TerraformProperty<string>? CosmosdbMongoDatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("cosmosdb_mongo_database_name");
        set => this.WithProperty("cosmosdb_mongo_database_name", value);
    }

    /// <summary>
    /// The cosmosdb_sql_database_name attribute.
    /// </summary>
    public TerraformProperty<string>? CosmosdbSqlDatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("cosmosdb_sql_database_name");
        set => this.WithProperty("cosmosdb_sql_database_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    public required TerraformProperty<string> SpringCloudAppId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_app_id");
        set => this.WithProperty("spring_cloud_app_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudAppCosmosdbAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSpringCloudAppCosmosdbAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
