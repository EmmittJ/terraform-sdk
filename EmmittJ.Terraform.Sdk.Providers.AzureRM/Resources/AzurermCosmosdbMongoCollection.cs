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
    public string? AccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_name")?.Value;
        set => this.WithProperty("account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The analytical_storage_ttl attribute.
    /// </summary>
    public double? AnalyticalStorageTtl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("analytical_storage_ttl")?.Value;
        set => this.WithProperty("analytical_storage_ttl", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public string? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name")?.Value;
        set => this.WithProperty("database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_ttl_seconds attribute.
    /// </summary>
    public double? DefaultTtlSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("default_ttl_seconds")?.Value;
        set => this.WithProperty("default_ttl_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The shard_key attribute.
    /// </summary>
    public string? ShardKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shard_key")?.Value;
        set => this.WithProperty("shard_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public double? Throughput
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throughput")?.Value;
        set => this.WithProperty("throughput", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The system_indexes attribute.
    /// </summary>
    public TerraformExpression SystemIndexes => this["system_indexes"];

}
