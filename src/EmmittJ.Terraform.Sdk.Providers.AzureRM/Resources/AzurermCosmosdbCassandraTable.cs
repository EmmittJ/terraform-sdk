using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cosmosdb_cassandra_table resource.
/// </summary>
public class AzurermCosmosdbCassandraTable : TerraformResource
{
    public AzurermCosmosdbCassandraTable(string name) : base("azurerm_cosmosdb_cassandra_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The cassandra_keyspace_id attribute.
    /// </summary>
    public string? CassandraKeyspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cassandra_keyspace_id")?.Value;
        set => this.WithProperty("cassandra_keyspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public double? DefaultTtl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("default_ttl")?.Value;
        set => this.WithProperty("default_ttl", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The throughput attribute.
    /// </summary>
    public double? Throughput
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throughput")?.Value;
        set => this.WithProperty("throughput", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
