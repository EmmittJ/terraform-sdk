using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for autoscale_settings in AzurermCosmosdbSqlContainer.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbSqlContainerAutoscaleSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscale_settings";

    /// <summary>
    /// The max_throughput attribute.
    /// </summary>
    public TerraformValue<double>? MaxThroughput
    {
        get => GetArgument<TerraformValue<double>>("max_throughput");
        set => SetArgument("max_throughput", value);
    }

}


/// <summary>
/// Block type for conflict_resolution_policy in AzurermCosmosdbSqlContainer.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbSqlContainerConflictResolutionPolicyBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("conflict_resolution_path");
        set => SetArgument("conflict_resolution_path", value);
    }

    /// <summary>
    /// The conflict_resolution_procedure attribute.
    /// </summary>
    public TerraformValue<string>? ConflictResolutionProcedure
    {
        get => GetArgument<TerraformValue<string>>("conflict_resolution_procedure");
        set => SetArgument("conflict_resolution_procedure", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for indexing_policy in AzurermCosmosdbSqlContainer.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbSqlContainerIndexingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "indexing_policy";

    /// <summary>
    /// The indexing_mode attribute.
    /// </summary>
    public TerraformValue<string>? IndexingMode
    {
        get => GetArgument<TerraformValue<string>>("indexing_mode");
        set => SetArgument("indexing_mode", value);
    }

    /// <summary>
    /// CompositeIndex block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCosmosdbSqlContainerIndexingPolicyBlockCompositeIndexBlock>? CompositeIndex
    {
        get => GetArgument<TerraformList<AzurermCosmosdbSqlContainerIndexingPolicyBlockCompositeIndexBlock>>("composite_index");
        set => SetArgument("composite_index", value);
    }

    /// <summary>
    /// ExcludedPath block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCosmosdbSqlContainerIndexingPolicyBlockExcludedPathBlock>? ExcludedPath
    {
        get => GetArgument<TerraformList<AzurermCosmosdbSqlContainerIndexingPolicyBlockExcludedPathBlock>>("excluded_path");
        set => SetArgument("excluded_path", value);
    }

    /// <summary>
    /// IncludedPath block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCosmosdbSqlContainerIndexingPolicyBlockIncludedPathBlock>? IncludedPath
    {
        get => GetArgument<TerraformList<AzurermCosmosdbSqlContainerIndexingPolicyBlockIncludedPathBlock>>("included_path");
        set => SetArgument("included_path", value);
    }

    /// <summary>
    /// SpatialIndex block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCosmosdbSqlContainerIndexingPolicyBlockSpatialIndexBlock>? SpatialIndex
    {
        get => GetArgument<TerraformList<AzurermCosmosdbSqlContainerIndexingPolicyBlockSpatialIndexBlock>>("spatial_index");
        set => SetArgument("spatial_index", value);
    }

}

/// <summary>
/// Block type for composite_index in AzurermCosmosdbSqlContainerIndexingPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbSqlContainerIndexingPolicyBlockCompositeIndexBlock : TerraformBlock
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
    public required TerraformList<AzurermCosmosdbSqlContainerIndexingPolicyBlockCompositeIndexBlockIndexBlock> Index
    {
        get => GetRequiredArgument<TerraformList<AzurermCosmosdbSqlContainerIndexingPolicyBlockCompositeIndexBlockIndexBlock>>("index");
        set => SetArgument("index", value);
    }

}

/// <summary>
/// Block type for index in AzurermCosmosdbSqlContainerIndexingPolicyBlockCompositeIndexBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbSqlContainerIndexingPolicyBlockCompositeIndexBlockIndexBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for excluded_path in AzurermCosmosdbSqlContainerIndexingPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbSqlContainerIndexingPolicyBlockExcludedPathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "excluded_path";

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for included_path in AzurermCosmosdbSqlContainerIndexingPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbSqlContainerIndexingPolicyBlockIncludedPathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "included_path";

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for spatial_index in AzurermCosmosdbSqlContainerIndexingPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbSqlContainerIndexingPolicyBlockSpatialIndexBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The types attribute.
    /// </summary>
    public TerraformSet<string> Types
        => AsReference("types");

}


/// <summary>
/// Block type for timeouts in AzurermCosmosdbSqlContainer.
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbSqlContainerTimeoutsBlock : TerraformBlock
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
/// Block type for unique_key in AzurermCosmosdbSqlContainer.
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbSqlContainerUniqueKeyBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("paths");
        set => SetArgument("paths", value);
    }

}


/// <summary>
/// Represents a azurerm_cosmosdb_sql_container Terraform resource.
/// Manages a azurerm_cosmosdb_sql_container resource.
/// </summary>
public partial class AzurermCosmosdbSqlContainer(string name) : TerraformResource("azurerm_cosmosdb_sql_container", name)
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => GetArgument<TerraformValue<string>>("account_name");
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
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformValue<double>? DefaultTtl
    {
        get => GetArgument<TerraformValue<double>>("default_ttl");
        set => SetArgument("default_ttl", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The partition_key_kind attribute.
    /// </summary>
    public TerraformValue<string>? PartitionKeyKind
    {
        get => GetArgument<TerraformValue<string>>("partition_key_kind");
        set => SetArgument("partition_key_kind", value);
    }

    /// <summary>
    /// The partition_key_paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKeyPaths is required")]
    public TerraformList<string>? PartitionKeyPaths
    {
        get => GetArgument<TerraformList<string>>("partition_key_paths");
        set => SetArgument("partition_key_paths", value);
    }

    /// <summary>
    /// The partition_key_version attribute.
    /// </summary>
    public TerraformValue<double>? PartitionKeyVersion
    {
        get => GetArgument<TerraformValue<double>>("partition_key_version");
        set => SetArgument("partition_key_version", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double>? Throughput
    {
        get => GetArgument<TerraformValue<double>>("throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// AutoscaleSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleSettings block(s) allowed")]
    public TerraformList<AzurermCosmosdbSqlContainerAutoscaleSettingsBlock>? AutoscaleSettings
    {
        get => GetArgument<TerraformList<AzurermCosmosdbSqlContainerAutoscaleSettingsBlock>>("autoscale_settings");
        set => SetArgument("autoscale_settings", value);
    }

    /// <summary>
    /// ConflictResolutionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConflictResolutionPolicy block(s) allowed")]
    public TerraformList<AzurermCosmosdbSqlContainerConflictResolutionPolicyBlock>? ConflictResolutionPolicy
    {
        get => GetArgument<TerraformList<AzurermCosmosdbSqlContainerConflictResolutionPolicyBlock>>("conflict_resolution_policy");
        set => SetArgument("conflict_resolution_policy", value);
    }

    /// <summary>
    /// IndexingPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexingPolicy block(s) allowed")]
    public TerraformList<AzurermCosmosdbSqlContainerIndexingPolicyBlock>? IndexingPolicy
    {
        get => GetArgument<TerraformList<AzurermCosmosdbSqlContainerIndexingPolicyBlock>>("indexing_policy");
        set => SetArgument("indexing_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCosmosdbSqlContainerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCosmosdbSqlContainerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UniqueKey block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermCosmosdbSqlContainerUniqueKeyBlock>? UniqueKey
    {
        get => GetArgument<TerraformSet<AzurermCosmosdbSqlContainerUniqueKeyBlock>>("unique_key");
        set => SetArgument("unique_key", value);
    }

}
