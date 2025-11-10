using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for autoscale_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbGremlinGraphAutoscaleSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The max_throughput attribute.
    /// </summary>
    [TerraformPropertyName("max_throughput")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxThroughput { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_throughput");

}

/// <summary>
/// Block type for conflict_resolution_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbGremlinGraphConflictResolutionPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The conflict_resolution_path attribute.
    /// </summary>
    [TerraformPropertyName("conflict_resolution_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConflictResolutionPath { get; set; }

    /// <summary>
    /// The conflict_resolution_procedure attribute.
    /// </summary>
    [TerraformPropertyName("conflict_resolution_procedure")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConflictResolutionProcedure { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Mode { get; set; }

}

/// <summary>
/// Block type for index_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbGremlinGraphIndexPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The automatic attribute.
    /// </summary>
    [TerraformPropertyName("automatic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Automatic { get; set; }

    /// <summary>
    /// The excluded_paths attribute.
    /// </summary>
    [TerraformPropertyName("excluded_paths")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> ExcludedPaths { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "excluded_paths");

    /// <summary>
    /// The included_paths attribute.
    /// </summary>
    [TerraformPropertyName("included_paths")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> IncludedPaths { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "included_paths");

    /// <summary>
    /// The indexing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexingMode is required")]
    [TerraformPropertyName("indexing_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IndexingMode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbGremlinGraphTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for unique_key in .
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbGremlinGraphUniqueKeyBlock : ITerraformBlock
{
    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    [TerraformPropertyName("paths")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Paths { get; set; }

}

/// <summary>
/// Manages a azurerm_cosmosdb_gremlin_graph resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCosmosdbGremlinGraph : TerraformResource
{
    public AzurermCosmosdbGremlinGraph(string name) : base("azurerm_cosmosdb_gremlin_graph", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccountName { get; set; }

    /// <summary>
    /// The analytical_storage_ttl attribute.
    /// </summary>
    [TerraformPropertyName("analytical_storage_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AnalyticalStorageTtl { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformPropertyName("database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatabaseName { get; set; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformPropertyName("default_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DefaultTtl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The partition_key_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKeyPath is required")]
    [TerraformPropertyName("partition_key_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PartitionKeyPath { get; set; }

    /// <summary>
    /// The partition_key_version attribute.
    /// </summary>
    [TerraformPropertyName("partition_key_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PartitionKeyVersion { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformPropertyName("throughput")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Throughput { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "throughput");

    /// <summary>
    /// Block for autoscale_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleSettings block(s) allowed")]
    [TerraformPropertyName("autoscale_settings")]
    public TerraformList<TerraformBlock<AzurermCosmosdbGremlinGraphAutoscaleSettingsBlock>>? AutoscaleSettings { get; set; } = new();

    /// <summary>
    /// Block for conflict_resolution_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConflictResolutionPolicy block(s) allowed")]
    [TerraformPropertyName("conflict_resolution_policy")]
    public TerraformList<TerraformBlock<AzurermCosmosdbGremlinGraphConflictResolutionPolicyBlock>>? ConflictResolutionPolicy { get; set; } = new();

    /// <summary>
    /// Block for index_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexPolicy block(s) allowed")]
    [TerraformPropertyName("index_policy")]
    public TerraformList<TerraformBlock<AzurermCosmosdbGremlinGraphIndexPolicyBlock>>? IndexPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCosmosdbGremlinGraphTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for unique_key.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("unique_key")]
    public TerraformSet<TerraformBlock<AzurermCosmosdbGremlinGraphUniqueKeyBlock>>? UniqueKey { get; set; } = new();

}
