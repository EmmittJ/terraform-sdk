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
    public string? ApiType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_type")?.Value;
        set => this.WithProperty("api_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cosmosdb_access_key attribute.
    /// </summary>
    public string? CosmosdbAccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_access_key")?.Value;
        set => this.WithProperty("cosmosdb_access_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cosmosdb_account_id attribute.
    /// </summary>
    public string? CosmosdbAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_account_id")?.Value;
        set => this.WithProperty("cosmosdb_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cosmosdb_cassandra_keyspace_name attribute.
    /// </summary>
    public string? CosmosdbCassandraKeyspaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_cassandra_keyspace_name")?.Value;
        set => this.WithProperty("cosmosdb_cassandra_keyspace_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cosmosdb_gremlin_database_name attribute.
    /// </summary>
    public string? CosmosdbGremlinDatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_gremlin_database_name")?.Value;
        set => this.WithProperty("cosmosdb_gremlin_database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cosmosdb_gremlin_graph_name attribute.
    /// </summary>
    public string? CosmosdbGremlinGraphName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_gremlin_graph_name")?.Value;
        set => this.WithProperty("cosmosdb_gremlin_graph_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cosmosdb_mongo_database_name attribute.
    /// </summary>
    public string? CosmosdbMongoDatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_mongo_database_name")?.Value;
        set => this.WithProperty("cosmosdb_mongo_database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cosmosdb_sql_database_name attribute.
    /// </summary>
    public string? CosmosdbSqlDatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_sql_database_name")?.Value;
        set => this.WithProperty("cosmosdb_sql_database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    public string? SpringCloudAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_app_id")?.Value;
        set => this.WithProperty("spring_cloud_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
