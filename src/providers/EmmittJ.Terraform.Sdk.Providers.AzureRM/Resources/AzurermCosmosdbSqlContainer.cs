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
public class AzurermCosmosdbSqlContainerAutoscaleSettingsBlock : TerraformBlock
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
    [TerraformArgument("conflict_resolution_path")]
    public TerraformValue<string>? ConflictResolutionPath
    {
        get => new TerraformReference<string>(this, "conflict_resolution_path");
        set => SetArgument("conflict_resolution_path", value);
    }

    /// <summary>
    /// The conflict_resolution_procedure attribute.
    /// </summary>
    [TerraformArgument("conflict_resolution_procedure")]
    public TerraformValue<string>? ConflictResolutionProcedure
    {
        get => new TerraformReference<string>(this, "conflict_resolution_procedure");
        set => SetArgument("conflict_resolution_procedure", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformArgument("mode")]
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
    [TerraformArgument("indexing_mode")]
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
    [TerraformArgument("paths")]
    public required TerraformSet<string> Paths
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "paths").ResolveNodes(ctx));
        set => SetArgument("paths", value);
    }

}

/// <summary>
/// Manages a azurerm_cosmosdb_sql_container resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCosmosdbSqlContainer : TerraformResource
{
    public AzurermCosmosdbSqlContainer(string name) : base("azurerm_cosmosdb_sql_container", name)
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
    /// The default_ttl attribute.
    /// </summary>
    [TerraformArgument("default_ttl")]
    public TerraformValue<double>? DefaultTtl
    {
        get => new TerraformReference<double>(this, "default_ttl");
        set => SetArgument("default_ttl", value);
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
    /// The partition_key_kind attribute.
    /// </summary>
    [TerraformArgument("partition_key_kind")]
    public TerraformValue<string>? PartitionKeyKind
    {
        get => new TerraformReference<string>(this, "partition_key_kind");
        set => SetArgument("partition_key_kind", value);
    }

    /// <summary>
    /// The partition_key_paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKeyPaths is required")]
    [TerraformArgument("partition_key_paths")]
    public TerraformList<string>? PartitionKeyPaths
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "partition_key_paths").ResolveNodes(ctx));
        set => SetArgument("partition_key_paths", value);
    }

    /// <summary>
    /// The partition_key_version attribute.
    /// </summary>
    [TerraformArgument("partition_key_version")]
    public TerraformValue<double>? PartitionKeyVersion
    {
        get => new TerraformReference<double>(this, "partition_key_version");
        set => SetArgument("partition_key_version", value);
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
    public TerraformList<AzurermCosmosdbSqlContainerAutoscaleSettingsBlock> AutoscaleSettings { get; set; } = new();

    /// <summary>
    /// Block for conflict_resolution_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConflictResolutionPolicy block(s) allowed")]
    [TerraformArgument("conflict_resolution_policy")]
    public TerraformList<AzurermCosmosdbSqlContainerConflictResolutionPolicyBlock> ConflictResolutionPolicy { get; set; } = new();

    /// <summary>
    /// Block for indexing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexingPolicy block(s) allowed")]
    [TerraformArgument("indexing_policy")]
    public TerraformList<AzurermCosmosdbSqlContainerIndexingPolicyBlock> IndexingPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCosmosdbSqlContainerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for unique_key.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("unique_key")]
    public TerraformSet<AzurermCosmosdbSqlContainerUniqueKeyBlock> UniqueKey { get; set; } = new();

}
