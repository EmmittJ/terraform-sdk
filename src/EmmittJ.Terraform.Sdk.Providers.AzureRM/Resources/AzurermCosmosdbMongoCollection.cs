using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for autoscale_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbMongoCollectionAutoscaleSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The max_throughput attribute.
    /// </summary>
    public TerraformProperty<double>? MaxThroughput
    {
        get => GetProperty<TerraformProperty<double>>("max_throughput");
        set => WithProperty("max_throughput", value);
    }

}

/// <summary>
/// Block type for index in .
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbMongoCollectionIndexBlock : TerraformBlock
{
    /// <summary>
    /// The keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keys is required")]
    public List<TerraformProperty<string>>? Keys
    {
        get => GetProperty<List<TerraformProperty<string>>>("keys");
        set => WithProperty("keys", value);
    }

    /// <summary>
    /// The unique attribute.
    /// </summary>
    public TerraformProperty<bool>? Unique
    {
        get => GetProperty<TerraformProperty<bool>>("unique");
        set => WithProperty("unique", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbMongoCollectionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_cosmosdb_mongo_collection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The default_ttl_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? DefaultTtlSeconds
    {
        get => GetProperty<TerraformProperty<double>>("default_ttl_seconds");
        set => this.WithProperty("default_ttl_seconds", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The shard_key attribute.
    /// </summary>
    public TerraformProperty<string>? ShardKey
    {
        get => GetProperty<TerraformProperty<string>>("shard_key");
        set => this.WithProperty("shard_key", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double>? Throughput
    {
        get => GetProperty<TerraformProperty<double>>("throughput");
        set => this.WithProperty("throughput", value);
    }

    /// <summary>
    /// Block for autoscale_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleSettings block(s) allowed")]
    public List<AzurermCosmosdbMongoCollectionAutoscaleSettingsBlock>? AutoscaleSettings
    {
        get => GetProperty<List<AzurermCosmosdbMongoCollectionAutoscaleSettingsBlock>>("autoscale_settings");
        set => this.WithProperty("autoscale_settings", value);
    }

    /// <summary>
    /// Block for index.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermCosmosdbMongoCollectionIndexBlock>? Index
    {
        get => GetProperty<HashSet<AzurermCosmosdbMongoCollectionIndexBlock>>("index");
        set => this.WithProperty("index", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCosmosdbMongoCollectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCosmosdbMongoCollectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The system_indexes attribute.
    /// </summary>
    public TerraformExpression SystemIndexes => this["system_indexes"];

}
