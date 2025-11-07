using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<string>? ApiType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_type");
        set => this.WithProperty("api_type", value);
    }

    /// <summary>
    /// The cosmosdb_access_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CosmosdbAccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_access_key");
        set => this.WithProperty("cosmosdb_access_key", value);
    }

    /// <summary>
    /// The cosmosdb_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CosmosdbAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_account_id");
        set => this.WithProperty("cosmosdb_account_id", value);
    }

    /// <summary>
    /// The cosmosdb_cassandra_keyspace_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CosmosdbCassandraKeyspaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_cassandra_keyspace_name");
        set => this.WithProperty("cosmosdb_cassandra_keyspace_name", value);
    }

    /// <summary>
    /// The cosmosdb_gremlin_database_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CosmosdbGremlinDatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_gremlin_database_name");
        set => this.WithProperty("cosmosdb_gremlin_database_name", value);
    }

    /// <summary>
    /// The cosmosdb_gremlin_graph_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CosmosdbGremlinGraphName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_gremlin_graph_name");
        set => this.WithProperty("cosmosdb_gremlin_graph_name", value);
    }

    /// <summary>
    /// The cosmosdb_mongo_database_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CosmosdbMongoDatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_mongo_database_name");
        set => this.WithProperty("cosmosdb_mongo_database_name", value);
    }

    /// <summary>
    /// The cosmosdb_sql_database_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CosmosdbSqlDatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_sql_database_name");
        set => this.WithProperty("cosmosdb_sql_database_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SpringCloudAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_app_id");
        set => this.WithProperty("spring_cloud_app_id", value);
    }

}
