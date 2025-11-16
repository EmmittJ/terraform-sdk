using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for autoscale_settings in .
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
    public TerraformValue<double> MaxThroughput
    {
        get => new TerraformReference<double>(this, "max_throughput");
        set => SetArgument("max_throughput", value);
    }

}

/// <summary>
/// Block type for conflict_resolution_policy in .
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
/// Block type for indexing_policy in .
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
        get => new TerraformReference<string>(this, "indexing_mode");
        set => SetArgument("indexing_mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Block type for unique_key in .
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "paths").ResolveNodes(ctx));
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
    /// The partition_key_kind attribute.
    /// </summary>
    public TerraformValue<string>? PartitionKeyKind
    {
        get => new TerraformReference<string>(this, "partition_key_kind");
        set => SetArgument("partition_key_kind", value);
    }

    /// <summary>
    /// The partition_key_paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKeyPaths is required")]
    public TerraformList<string>? PartitionKeyPaths
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "partition_key_paths").ResolveNodes(ctx));
        set => SetArgument("partition_key_paths", value);
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
