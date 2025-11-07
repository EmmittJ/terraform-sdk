using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cosmosdb_mongo_collection resource.
/// </summary>
public class AzurermCosmosdbMongoCollection : TerraformResource
{
    public AzurermCosmosdbMongoCollection(string name) : base("azurerm_cosmosdb_mongo_collection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("system_indexes");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The analytical_storage_ttl attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? AnalyticalStorageTtl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("analytical_storage_ttl");
        set => this.WithProperty("analytical_storage_ttl", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The default_ttl_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DefaultTtlSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("default_ttl_seconds");
        set => this.WithProperty("default_ttl_seconds", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The shard_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ShardKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shard_key");
        set => this.WithProperty("shard_key", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Throughput
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throughput");
        set => this.WithProperty("throughput", value);
    }

    /// <summary>
    /// The system_indexes attribute.
    /// </summary>
    public TerraformExpression SystemIndexes => this["system_indexes"];

}
