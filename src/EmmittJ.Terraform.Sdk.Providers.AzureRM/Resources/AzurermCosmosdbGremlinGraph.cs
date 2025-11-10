using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for autoscale_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbGremlinGraphAutoscaleSettingsBlock : TerraformBlock
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
/// Block type for conflict_resolution_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbGremlinGraphConflictResolutionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The conflict_resolution_path attribute.
    /// </summary>
    public TerraformProperty<string>? ConflictResolutionPath
    {
        get => GetProperty<TerraformProperty<string>>("conflict_resolution_path");
        set => WithProperty("conflict_resolution_path", value);
    }

    /// <summary>
    /// The conflict_resolution_procedure attribute.
    /// </summary>
    public TerraformProperty<string>? ConflictResolutionProcedure
    {
        get => GetProperty<TerraformProperty<string>>("conflict_resolution_procedure");
        set => WithProperty("conflict_resolution_procedure", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

}

/// <summary>
/// Block type for index_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbGremlinGraphIndexPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The automatic attribute.
    /// </summary>
    public TerraformProperty<bool>? Automatic
    {
        get => GetProperty<TerraformProperty<bool>>("automatic");
        set => WithProperty("automatic", value);
    }

    /// <summary>
    /// The excluded_paths attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExcludedPaths
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("excluded_paths");
        set => WithProperty("excluded_paths", value);
    }

    /// <summary>
    /// The included_paths attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IncludedPaths
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("included_paths");
        set => WithProperty("included_paths", value);
    }

    /// <summary>
    /// The indexing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexingMode is required")]
    public required TerraformProperty<string> IndexingMode
    {
        get => GetProperty<TerraformProperty<string>>("indexing_mode");
        set => WithProperty("indexing_mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbGremlinGraphTimeoutsBlock : TerraformBlock
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
/// Block type for unique_key in .
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbGremlinGraphUniqueKeyBlock : TerraformBlock
{
    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    public HashSet<TerraformProperty<string>>? Paths
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("paths");
        set => WithProperty("paths", value);
    }

}

/// <summary>
/// Manages a azurerm_cosmosdb_gremlin_graph resource.
/// </summary>
public class AzurermCosmosdbGremlinGraph : TerraformResource
{
    public AzurermCosmosdbGremlinGraph(string name) : base("azurerm_cosmosdb_gremlin_graph", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The partition_key_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKeyPath is required")]
    public required TerraformProperty<string> PartitionKeyPath
    {
        get => GetProperty<TerraformProperty<string>>("partition_key_path");
        set => this.WithProperty("partition_key_path", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
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

    /// <summary>
    /// Block for autoscale_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleSettings block(s) allowed")]
    public List<AzurermCosmosdbGremlinGraphAutoscaleSettingsBlock>? AutoscaleSettings
    {
        get => GetProperty<List<AzurermCosmosdbGremlinGraphAutoscaleSettingsBlock>>("autoscale_settings");
        set => this.WithProperty("autoscale_settings", value);
    }

    /// <summary>
    /// Block for conflict_resolution_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConflictResolutionPolicy block(s) allowed")]
    public List<AzurermCosmosdbGremlinGraphConflictResolutionPolicyBlock>? ConflictResolutionPolicy
    {
        get => GetProperty<List<AzurermCosmosdbGremlinGraphConflictResolutionPolicyBlock>>("conflict_resolution_policy");
        set => this.WithProperty("conflict_resolution_policy", value);
    }

    /// <summary>
    /// Block for index_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexPolicy block(s) allowed")]
    public List<AzurermCosmosdbGremlinGraphIndexPolicyBlock>? IndexPolicy
    {
        get => GetProperty<List<AzurermCosmosdbGremlinGraphIndexPolicyBlock>>("index_policy");
        set => this.WithProperty("index_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCosmosdbGremlinGraphTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCosmosdbGremlinGraphTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for unique_key.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermCosmosdbGremlinGraphUniqueKeyBlock>? UniqueKey
    {
        get => GetProperty<HashSet<AzurermCosmosdbGremlinGraphUniqueKeyBlock>>("unique_key");
        set => this.WithProperty("unique_key", value);
    }

}
