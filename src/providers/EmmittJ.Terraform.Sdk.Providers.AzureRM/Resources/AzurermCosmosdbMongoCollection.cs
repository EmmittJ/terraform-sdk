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
        set => SetProperty("max_throughput", value);
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
        set => SetProperty("keys", value);
    }

    /// <summary>
    /// The unique attribute.
    /// </summary>
    public TerraformProperty<bool>? Unique
    {
        set => SetProperty("unique", value);
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
        SetOutput("system_indexes");
        SetOutput("account_name");
        SetOutput("analytical_storage_ttl");
        SetOutput("database_name");
        SetOutput("default_ttl_seconds");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("shard_key");
        SetOutput("throughput");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_name");
        set => SetProperty("account_name", value);
    }

    /// <summary>
    /// The analytical_storage_ttl attribute.
    /// </summary>
    public TerraformProperty<double> AnalyticalStorageTtl
    {
        get => GetRequiredOutput<TerraformProperty<double>>("analytical_storage_ttl");
        set => SetProperty("analytical_storage_ttl", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_name");
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The default_ttl_seconds attribute.
    /// </summary>
    public TerraformProperty<double> DefaultTtlSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("default_ttl_seconds");
        set => SetProperty("default_ttl_seconds", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The shard_key attribute.
    /// </summary>
    public TerraformProperty<string> ShardKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("shard_key");
        set => SetProperty("shard_key", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double> Throughput
    {
        get => GetRequiredOutput<TerraformProperty<double>>("throughput");
        set => SetProperty("throughput", value);
    }

    /// <summary>
    /// Block for autoscale_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleSettings block(s) allowed")]
    public List<AzurermCosmosdbMongoCollectionAutoscaleSettingsBlock>? AutoscaleSettings
    {
        set => SetProperty("autoscale_settings", value);
    }

    /// <summary>
    /// Block for index.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermCosmosdbMongoCollectionIndexBlock>? Index
    {
        set => SetProperty("index", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCosmosdbMongoCollectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The system_indexes attribute.
    /// </summary>
    public TerraformExpression SystemIndexes => this["system_indexes"];

}
