using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for autoscale_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbSqlContainerAutoscaleSettingsBlock
{
    /// <summary>
    /// The max_throughput attribute.
    /// </summary>
    [TerraformPropertyName("max_throughput")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxThroughput { get; set; } = default!;

}

/// <summary>
/// Block type for conflict_resolution_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbSqlContainerConflictResolutionPolicyBlock
{
    /// <summary>
    /// The conflict_resolution_path attribute.
    /// </summary>
    [TerraformPropertyName("conflict_resolution_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConflictResolutionPath { get; set; }

    /// <summary>
    /// The conflict_resolution_procedure attribute.
    /// </summary>
    [TerraformPropertyName("conflict_resolution_procedure")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConflictResolutionProcedure { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for indexing_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbSqlContainerIndexingPolicyBlock
{
    /// <summary>
    /// The indexing_mode attribute.
    /// </summary>
    [TerraformPropertyName("indexing_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IndexingMode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbSqlContainerTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for unique_key in .
/// Nesting mode: set
/// </summary>
public class AzurermCosmosdbSqlContainerUniqueKeyBlock
{
    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    [TerraformPropertyName("paths")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Paths { get; set; }

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
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The analytical_storage_ttl attribute.
    /// </summary>
    [TerraformPropertyName("analytical_storage_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AnalyticalStorageTtl { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformPropertyName("database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformPropertyName("default_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DefaultTtl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The partition_key_kind attribute.
    /// </summary>
    [TerraformPropertyName("partition_key_kind")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PartitionKeyKind { get; set; }

    /// <summary>
    /// The partition_key_paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKeyPaths is required")]
    [TerraformPropertyName("partition_key_paths")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? PartitionKeyPaths { get; set; }

    /// <summary>
    /// The partition_key_version attribute.
    /// </summary>
    [TerraformPropertyName("partition_key_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PartitionKeyVersion { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformPropertyName("throughput")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Throughput { get; set; } = default!;

    /// <summary>
    /// Block for autoscale_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleSettings block(s) allowed")]
    [TerraformPropertyName("autoscale_settings")]
    public TerraformList<TerraformBlock<AzurermCosmosdbSqlContainerAutoscaleSettingsBlock>>? AutoscaleSettings { get; set; }

    /// <summary>
    /// Block for conflict_resolution_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConflictResolutionPolicy block(s) allowed")]
    [TerraformPropertyName("conflict_resolution_policy")]
    public TerraformList<TerraformBlock<AzurermCosmosdbSqlContainerConflictResolutionPolicyBlock>>? ConflictResolutionPolicy { get; set; }

    /// <summary>
    /// Block for indexing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexingPolicy block(s) allowed")]
    [TerraformPropertyName("indexing_policy")]
    public TerraformList<TerraformBlock<AzurermCosmosdbSqlContainerIndexingPolicyBlock>>? IndexingPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCosmosdbSqlContainerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for unique_key.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("unique_key")]
    public TerraformSet<TerraformBlock<AzurermCosmosdbSqlContainerUniqueKeyBlock>>? UniqueKey { get; set; }

}
