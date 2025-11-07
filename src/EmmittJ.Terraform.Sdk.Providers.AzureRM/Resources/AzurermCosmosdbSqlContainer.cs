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
    public TerraformProperty<string>? AccountName
    {
        get => GetProperty<TerraformProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The analytical_storage_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? AnalyticalStorageTtl
    {
        get => GetProperty<TerraformProperty<double>>("analytical_storage_ttl");
        set => this.WithProperty("analytical_storage_ttl", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? DefaultTtl
    {
        get => GetProperty<TerraformProperty<double>>("default_ttl");
        set => this.WithProperty("default_ttl", value);
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The partition_key_kind attribute.
    /// </summary>
    public TerraformProperty<string>? PartitionKeyKind
    {
        get => GetProperty<TerraformProperty<string>>("partition_key_kind");
        set => this.WithProperty("partition_key_kind", value);
    }

    /// <summary>
    /// The partition_key_paths attribute.
    /// </summary>
    public TerraformProperty<List<string>>? PartitionKeyPaths
    {
        get => GetProperty<TerraformProperty<List<string>>>("partition_key_paths");
        set => this.WithProperty("partition_key_paths", value);
    }

    /// <summary>
    /// The partition_key_version attribute.
    /// </summary>
    public TerraformProperty<double>? PartitionKeyVersion
    {
        get => GetProperty<TerraformProperty<double>>("partition_key_version");
        set => this.WithProperty("partition_key_version", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double>? Throughput
    {
        get => GetProperty<TerraformProperty<double>>("throughput");
        set => this.WithProperty("throughput", value);
    }

}
