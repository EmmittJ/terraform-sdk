using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for autoscale_settings in AzurermCosmosdbGremlinGraph.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbGremlinGraphAutoscaleSettingsBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "max_throughput");
        set => SetArgument("max_throughput", value);
    }

}


/// <summary>
/// Block type for conflict_resolution_policy in AzurermCosmosdbGremlinGraph.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbGremlinGraphConflictResolutionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conflict_resolution_policy";

    /// <summary>
    /// The conflict_resolution_path attribute.
    /// </summary>
    public TerraformValue<string>? ConflictResolutionPath
    {
        get => new TerraformReference<string>(this, "conflict_resolution_path");
        set => SetArgument("conflict_resolution_path", value);
    }

    /// <summary>
    /// The conflict_resolution_procedure attribute.
    /// </summary>
    public TerraformValue<string>? ConflictResolutionProcedure
    {
        get => new TerraformReference<string>(this, "conflict_resolution_procedure");
        set => SetArgument("conflict_resolution_procedure", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for index_policy in AzurermCosmosdbGremlinGraph.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbGremlinGraphIndexPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "index_policy";

    /// <summary>
    /// The automatic attribute.
    /// </summary>
    public TerraformValue<bool>? Automatic
    {
        get => new TerraformReference<bool>(this, "automatic");
        set => SetArgument("automatic", value);
    }

    /// <summary>
    /// The excluded_paths attribute.
    /// </summary>
    public TerraformSet<string> ExcludedPaths
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "excluded_paths").ResolveNodes(ctx));
        set => SetArgument("excluded_paths", value);
    }

    /// <summary>
    /// The included_paths attribute.
    /// </summary>
    public TerraformSet<string> IncludedPaths
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "included_paths").ResolveNodes(ctx));
        set => SetArgument("included_paths", value);
    }

    /// <summary>
    /// The indexing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexingMode is required")]
    public required TerraformValue<string> IndexingMode
    {
        get => new TerraformReference<string>(this, "indexing_mode");
        set => SetArgument("indexing_mode", value);
    }

    /// <summary>
    /// CompositeIndex block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCosmosdbGremlinGraphIndexPolicyBlockCompositeIndexBlock>? CompositeIndex
    {
        get => GetArgument<TerraformList<AzurermCosmosdbGremlinGraphIndexPolicyBlockCompositeIndexBlock>>("composite_index");
        set => SetArgument("composite_index", value);
    }

    /// <summary>
    /// SpatialIndex block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCosmosdbGremlinGraphIndexPolicyBlockSpatialIndexBlock>? SpatialIndex
    {
        get => GetArgument<TerraformList<AzurermCosmosdbGremlinGraphIndexPolicyBlockSpatialIndexBlock>>("spatial_index");
        set => SetArgument("spatial_index", value);
    }

}

/// <summary>
/// Block type for composite_index in AzurermCosmosdbGremlinGraphIndexPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbGremlinGraphIndexPolicyBlockCompositeIndexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "composite_index";

    /// <summary>
    /// Index block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Index is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Index block(s) required")]
    public required TerraformList<AzurermCosmosdbGremlinGraphIndexPolicyBlockCompositeIndexBlockIndexBlock> Index
    {
        get => GetRequiredArgument<TerraformList<AzurermCosmosdbGremlinGraphIndexPolicyBlockCompositeIndexBlockIndexBlock>>("index");
        set => SetArgument("index", value);
    }

}

/// <summary>
/// Block type for index in AzurermCosmosdbGremlinGraphIndexPolicyBlockCompositeIndexBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbGremlinGraphIndexPolicyBlockCompositeIndexBlockIndexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "index";

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformValue<string> Order
    {
        get => new TerraformReference<string>(this, "order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for spatial_index in AzurermCosmosdbGremlinGraphIndexPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbGremlinGraphIndexPolicyBlockSpatialIndexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spatial_index";

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The types attribute.
    /// </summary>
    public TerraformSet<string> Types
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "types").ResolveNodes(ctx));
    }

}


/// <summary>
/// Block type for timeouts in AzurermCosmosdbGremlinGraph.
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbGremlinGraphTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for unique_key in AzurermCosmosdbGremlinGraph.
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbGremlinGraphUniqueKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unique_key";

    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    public required TerraformSet<string> Paths
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "paths").ResolveNodes(ctx));
        set => SetArgument("paths", value);
    }

}


/// <summary>
/// Represents a azurerm_cosmosdb_gremlin_graph Terraform resource.
/// Manages a azurerm_cosmosdb_gremlin_graph resource.
/// </summary>
public partial class AzurermCosmosdbGremlinGraph(string name) : TerraformResource("azurerm_cosmosdb_gremlin_graph", name)
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The analytical_storage_ttl attribute.
    /// </summary>
    public TerraformValue<double>? AnalyticalStorageTtl
    {
        get => new TerraformReference<double>(this, "analytical_storage_ttl");
        set => SetArgument("analytical_storage_ttl", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformValue<double>? DefaultTtl
    {
        get => new TerraformReference<double>(this, "default_ttl");
        set => SetArgument("default_ttl", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The partition_key_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKeyPath is required")]
    public required TerraformValue<string> PartitionKeyPath
    {
        get => new TerraformReference<string>(this, "partition_key_path");
        set => SetArgument("partition_key_path", value);
    }

    /// <summary>
    /// The partition_key_version attribute.
    /// </summary>
    public TerraformValue<double>? PartitionKeyVersion
    {
        get => new TerraformReference<double>(this, "partition_key_version");
        set => SetArgument("partition_key_version", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double> Throughput
    {
        get => new TerraformReference<double>(this, "throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// AutoscaleSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleSettings block(s) allowed")]
    public TerraformList<AzurermCosmosdbGremlinGraphAutoscaleSettingsBlock>? AutoscaleSettings
    {
        get => GetArgument<TerraformList<AzurermCosmosdbGremlinGraphAutoscaleSettingsBlock>>("autoscale_settings");
        set => SetArgument("autoscale_settings", value);
    }

    /// <summary>
    /// ConflictResolutionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConflictResolutionPolicy block(s) allowed")]
    public TerraformList<AzurermCosmosdbGremlinGraphConflictResolutionPolicyBlock>? ConflictResolutionPolicy
    {
        get => GetArgument<TerraformList<AzurermCosmosdbGremlinGraphConflictResolutionPolicyBlock>>("conflict_resolution_policy");
        set => SetArgument("conflict_resolution_policy", value);
    }

    /// <summary>
    /// IndexPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexPolicy block(s) allowed")]
    public TerraformList<AzurermCosmosdbGremlinGraphIndexPolicyBlock>? IndexPolicy
    {
        get => GetArgument<TerraformList<AzurermCosmosdbGremlinGraphIndexPolicyBlock>>("index_policy");
        set => SetArgument("index_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCosmosdbGremlinGraphTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCosmosdbGremlinGraphTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UniqueKey block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermCosmosdbGremlinGraphUniqueKeyBlock>? UniqueKey
    {
        get => GetArgument<TerraformSet<AzurermCosmosdbGremlinGraphUniqueKeyBlock>>("unique_key");
        set => SetArgument("unique_key", value);
    }

}
