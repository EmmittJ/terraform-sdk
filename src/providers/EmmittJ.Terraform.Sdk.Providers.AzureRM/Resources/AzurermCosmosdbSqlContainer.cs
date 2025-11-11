using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for autoscale_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCosmosdbSqlContainerAutoscaleSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_throughput attribute.
    /// </summary>
    [TerraformProperty("max_throughput")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxThroughput { get; set; }

}

/// <summary>
/// Block type for conflict_resolution_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCosmosdbSqlContainerConflictResolutionPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The conflict_resolution_path attribute.
    /// </summary>
    [TerraformProperty("conflict_resolution_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConflictResolutionPath { get; set; }

    /// <summary>
    /// The conflict_resolution_procedure attribute.
    /// </summary>
    [TerraformProperty("conflict_resolution_procedure")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConflictResolutionProcedure { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for indexing_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCosmosdbSqlContainerIndexingPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The indexing_mode attribute.
    /// </summary>
    [TerraformProperty("indexing_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IndexingMode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCosmosdbSqlContainerTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for unique_key in .
/// Nesting mode: set
/// </summary>
public partial class AzurermCosmosdbSqlContainerUniqueKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    [TerraformProperty("paths")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Paths { get; set; }

}

/// <summary>
/// Manages a azurerm_cosmosdb_sql_container resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermCosmosdbSqlContainer : TerraformResource
{
    public AzurermCosmosdbSqlContainer(string name) : base("azurerm_cosmosdb_sql_container", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The analytical_storage_ttl attribute.
    /// </summary>
    [TerraformProperty("analytical_storage_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AnalyticalStorageTtl { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformProperty("default_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DefaultTtl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The partition_key_kind attribute.
    /// </summary>
    [TerraformProperty("partition_key_kind")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PartitionKeyKind { get; set; }

    /// <summary>
    /// The partition_key_paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKeyPaths is required")]
    [TerraformProperty("partition_key_paths")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? PartitionKeyPaths { get; set; }

    /// <summary>
    /// The partition_key_version attribute.
    /// </summary>
    [TerraformProperty("partition_key_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PartitionKeyVersion { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformProperty("throughput")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Throughput { get; set; }

    /// <summary>
    /// Block for autoscale_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleSettings block(s) allowed")]
    [TerraformProperty("autoscale_settings")]
    public partial TerraformList<TerraformBlock<AzurermCosmosdbSqlContainerAutoscaleSettingsBlock>>? AutoscaleSettings { get; set; }

    /// <summary>
    /// Block for conflict_resolution_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConflictResolutionPolicy block(s) allowed")]
    [TerraformProperty("conflict_resolution_policy")]
    public partial TerraformList<TerraformBlock<AzurermCosmosdbSqlContainerConflictResolutionPolicyBlock>>? ConflictResolutionPolicy { get; set; }

    /// <summary>
    /// Block for indexing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexingPolicy block(s) allowed")]
    [TerraformProperty("indexing_policy")]
    public partial TerraformList<TerraformBlock<AzurermCosmosdbSqlContainerIndexingPolicyBlock>>? IndexingPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermCosmosdbSqlContainerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for unique_key.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("unique_key")]
    public partial TerraformSet<TerraformBlock<AzurermCosmosdbSqlContainerUniqueKeyBlock>>? UniqueKey { get; set; }

}
