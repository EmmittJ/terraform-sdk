using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for autoscale_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCosmosdbCassandraTableAutoscaleSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_throughput attribute.
    /// </summary>
    [TerraformProperty("max_throughput")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaxThroughput { get; set; }

}

/// <summary>
/// Block type for schema in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCosmosdbCassandraTableSchemaBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCosmosdbCassandraTableTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_cosmosdb_cassandra_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermCosmosdbCassandraTable : TerraformResource
{
    public AzurermCosmosdbCassandraTable(string name) : base("azurerm_cosmosdb_cassandra_table", name)
    {
    }

    /// <summary>
    /// The analytical_storage_ttl attribute.
    /// </summary>
    [TerraformProperty("analytical_storage_ttl")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? AnalyticalStorageTtl { get; set; }

    /// <summary>
    /// The cassandra_keyspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CassandraKeyspaceId is required")]
    [TerraformProperty("cassandra_keyspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CassandraKeyspaceId { get; set; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformProperty("default_ttl")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DefaultTtl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformProperty("throughput")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Throughput { get; set; }

    /// <summary>
    /// Block for autoscale_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscaleSettings block(s) allowed")]
    [TerraformProperty("autoscale_settings")]
    public TerraformList<TerraformBlock<AzurermCosmosdbCassandraTableAutoscaleSettingsBlock>>? AutoscaleSettings { get; set; }

    /// <summary>
    /// Block for schema.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schema block(s) allowed")]
    [TerraformProperty("schema")]
    public TerraformList<TerraformBlock<AzurermCosmosdbCassandraTableSchemaBlock>>? Schema { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermCosmosdbCassandraTableTimeoutsBlock>? Timeouts { get; set; }

}
