using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for autoscale_settings in AzurermCosmosdbMongoCollection.
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
    public TerraformValue<double> MaxThroughput
    {
        get => GetArgument<TerraformValue<double>>("max_throughput") ?? CreateReference("max_throughput");
        set => SetArgument("max_throughput", value);
    }

}


/// <summary>
/// Block type for index in AzurermCosmosdbMongoCollection.
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeysAttribute is required")]
    public TerraformList<string>? KeysAttribute
    {
        get => GetArgument<TerraformList<string>>("keys");
        set => SetArgument("keys", value);
    }

    /// <summary>
    /// The unique attribute.
    /// </summary>
    public TerraformValue<bool>? Unique
    {
        get => GetArgument<TerraformValue<bool>>("unique");
        set => SetArgument("unique", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermCosmosdbMongoCollection.
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
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_cosmosdb_mongo_collection Terraform resource.
/// Manages a azurerm_cosmosdb_mongo_collection resource.
/// </summary>
public partial class AzurermCosmosdbMongoCollection(string name) : TerraformResource("azurerm_cosmosdb_mongo_collection", name)
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The analytical_storage_ttl attribute.
    /// </summary>
    public TerraformValue<double>? AnalyticalStorageTtl
    {
        get => GetArgument<TerraformValue<double>>("analytical_storage_ttl");
        set => SetArgument("analytical_storage_ttl", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetRequiredArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The default_ttl_seconds attribute.
    /// </summary>
    public TerraformValue<double>? DefaultTtlSeconds
    {
        get => GetArgument<TerraformValue<double>>("default_ttl_seconds");
        set => SetArgument("default_ttl_seconds", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The shard_key attribute.
    /// </summary>
    public TerraformValue<string>? ShardKey
    {
        get => GetArgument<TerraformValue<string>>("shard_key");
        set => SetArgument("shard_key", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double> Throughput
    {
        get => GetArgument<TerraformValue<double>>("throughput") ?? CreateReference("throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// The system_indexes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SystemIndexes
        => CreateReference("system_indexes");

    /// <summary>
    /// AutoscaleSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleSettings block(s) allowed")]
    public TerraformList<AzurermCosmosdbMongoCollectionAutoscaleSettingsBlock>? AutoscaleSettings
    {
        get => GetArgument<TerraformList<AzurermCosmosdbMongoCollectionAutoscaleSettingsBlock>>("autoscale_settings");
        set => SetArgument("autoscale_settings", value);
    }

    /// <summary>
    /// Index block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermCosmosdbMongoCollectionIndexBlock>? Index
    {
        get => GetArgument<TerraformSet<AzurermCosmosdbMongoCollectionIndexBlock>>("index");
        set => SetArgument("index", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCosmosdbMongoCollectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCosmosdbMongoCollectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
