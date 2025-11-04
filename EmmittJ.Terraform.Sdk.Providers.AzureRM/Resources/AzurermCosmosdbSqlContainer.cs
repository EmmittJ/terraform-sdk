using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cosmosdb_sql_container resource.
/// </summary>
public class AzurermCosmosdbSqlContainer : TerraformResource
{
    public AzurermCosmosdbSqlContainer(string name) : base("azurerm_cosmosdb_sql_container", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The partition_key_kind attribute.
    /// </summary>
    public string? PartitionKeyKind
    {
        get => GetProperty<TerraformLiteralProperty<string>>("partition_key_kind")?.Value;
        set => this.WithProperty("partition_key_kind", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The partition_key_paths attribute.
    /// </summary>
    public List<string>? PartitionKeyPaths
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("partition_key_paths")?.Value;
        set => this.WithProperty("partition_key_paths", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The partition_key_version attribute.
    /// </summary>
    public double? PartitionKeyVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("partition_key_version")?.Value;
        set => this.WithProperty("partition_key_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The throughput attribute.
    /// </summary>
    public double? Throughput
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throughput")?.Value;
        set => this.WithProperty("throughput", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
