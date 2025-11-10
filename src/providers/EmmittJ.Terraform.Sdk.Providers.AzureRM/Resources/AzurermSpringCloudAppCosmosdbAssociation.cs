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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("api_type");
        SetOutput("cosmosdb_access_key");
        SetOutput("cosmosdb_account_id");
        SetOutput("cosmosdb_cassandra_keyspace_name");
        SetOutput("cosmosdb_gremlin_database_name");
        SetOutput("cosmosdb_gremlin_graph_name");
        SetOutput("cosmosdb_mongo_database_name");
        SetOutput("cosmosdb_sql_database_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("spring_cloud_app_id");
    }

    /// <summary>
    /// The api_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiType is required")]
    public required TerraformProperty<string> ApiType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_type");
        set => SetProperty("api_type", value);
    }

    /// <summary>
    /// The cosmosdb_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbAccessKey is required")]
    public required TerraformProperty<string> CosmosdbAccessKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cosmosdb_access_key");
        set => SetProperty("cosmosdb_access_key", value);
    }

    /// <summary>
    /// The cosmosdb_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbAccountId is required")]
    public required TerraformProperty<string> CosmosdbAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cosmosdb_account_id");
        set => SetProperty("cosmosdb_account_id", value);
    }

    /// <summary>
    /// The cosmosdb_cassandra_keyspace_name attribute.
    /// </summary>
    public TerraformProperty<string> CosmosdbCassandraKeyspaceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cosmosdb_cassandra_keyspace_name");
        set => SetProperty("cosmosdb_cassandra_keyspace_name", value);
    }

    /// <summary>
    /// The cosmosdb_gremlin_database_name attribute.
    /// </summary>
    public TerraformProperty<string> CosmosdbGremlinDatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cosmosdb_gremlin_database_name");
        set => SetProperty("cosmosdb_gremlin_database_name", value);
    }

    /// <summary>
    /// The cosmosdb_gremlin_graph_name attribute.
    /// </summary>
    public TerraformProperty<string> CosmosdbGremlinGraphName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cosmosdb_gremlin_graph_name");
        set => SetProperty("cosmosdb_gremlin_graph_name", value);
    }

    /// <summary>
    /// The cosmosdb_mongo_database_name attribute.
    /// </summary>
    public TerraformProperty<string> CosmosdbMongoDatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cosmosdb_mongo_database_name");
        set => SetProperty("cosmosdb_mongo_database_name", value);
    }

    /// <summary>
    /// The cosmosdb_sql_database_name attribute.
    /// </summary>
    public TerraformProperty<string> CosmosdbSqlDatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cosmosdb_sql_database_name");
        set => SetProperty("cosmosdb_sql_database_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    public required TerraformProperty<string> SpringCloudAppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spring_cloud_app_id");
        set => SetProperty("spring_cloud_app_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudAppCosmosdbAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
