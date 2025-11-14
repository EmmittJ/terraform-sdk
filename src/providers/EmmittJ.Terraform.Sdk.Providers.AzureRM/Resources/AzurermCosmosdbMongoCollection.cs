using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for autoscale_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbMongoCollectionAutoscaleSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscale_settings";

    /// <summary>
    /// The max_throughput attribute.
    /// </summary>
    [TerraformArgument("max_throughput")]
    public TerraformValue<double> MaxThroughput
    {
        get => new TerraformReference<double>(this, "max_throughput");
        set => SetArgument("max_throughput", value);
    }

}

/// <summary>
/// Block type for index in .
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbMongoCollectionIndexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "index";

    /// <summary>
    /// The keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keys is required")]
    [TerraformArgument("keys")]
    public TerraformList<string>? Keys
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "keys").ResolveNodes(ctx));
        set => SetArgument("keys", value);
    }

    /// <summary>
    /// The unique attribute.
    /// </summary>
    [TerraformArgument("unique")]
    public TerraformValue<bool>? Unique
    {
        get => new TerraformReference<bool>(this, "unique");
        set => SetArgument("unique", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbMongoCollectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformArgument("account_name")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The analytical_storage_ttl attribute.
    /// </summary>
    [TerraformArgument("analytical_storage_ttl")]
    public TerraformValue<double>? AnalyticalStorageTtl
    {
        get => new TerraformReference<double>(this, "analytical_storage_ttl");
        set => SetArgument("analytical_storage_ttl", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformArgument("database_name")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The default_ttl_seconds attribute.
    /// </summary>
    [TerraformArgument("default_ttl_seconds")]
    public TerraformValue<double>? DefaultTtlSeconds
    {
        get => new TerraformReference<double>(this, "default_ttl_seconds");
        set => SetArgument("default_ttl_seconds", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The shard_key attribute.
    /// </summary>
    [TerraformArgument("shard_key")]
    public TerraformValue<string>? ShardKey
    {
        get => new TerraformReference<string>(this, "shard_key");
        set => SetArgument("shard_key", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformArgument("throughput")]
    public TerraformValue<double> Throughput
    {
        get => new TerraformReference<double>(this, "throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// Block for autoscale_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleSettings block(s) allowed")]
    [TerraformArgument("autoscale_settings")]
    public TerraformList<AzurermCosmosdbMongoCollectionAutoscaleSettingsBlock> AutoscaleSettings { get; set; } = new();

    /// <summary>
    /// Block for index.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("index")]
    public TerraformSet<AzurermCosmosdbMongoCollectionIndexBlock> Index { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCosmosdbMongoCollectionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The system_indexes attribute.
    /// </summary>
    [TerraformArgument("system_indexes")]
    public TerraformList<object> SystemIndexes
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "system_indexes").ResolveNodes(ctx));
    }

}
