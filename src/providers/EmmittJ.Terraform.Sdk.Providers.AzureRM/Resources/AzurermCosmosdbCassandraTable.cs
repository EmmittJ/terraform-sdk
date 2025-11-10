using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for autoscale_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbCassandraTableAutoscaleSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The max_throughput attribute.
    /// </summary>
    [TerraformPropertyName("max_throughput")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxThroughput { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_throughput");

}

/// <summary>
/// Block type for schema in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbCassandraTableSchemaBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbCassandraTableTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_cosmosdb_cassandra_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCosmosdbCassandraTable : TerraformResource
{
    public AzurermCosmosdbCassandraTable(string name) : base("azurerm_cosmosdb_cassandra_table", name)
    {
    }

    /// <summary>
    /// The analytical_storage_ttl attribute.
    /// </summary>
    [TerraformPropertyName("analytical_storage_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AnalyticalStorageTtl { get; set; }

    /// <summary>
    /// The cassandra_keyspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CassandraKeyspaceId is required")]
    [TerraformPropertyName("cassandra_keyspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CassandraKeyspaceId { get; set; }

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
    public TerraformList<TerraformBlock<AzurermCosmosdbCassandraTableAutoscaleSettingsBlock>>? AutoscaleSettings { get; set; } = new();

    /// <summary>
    /// Block for schema.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schema block(s) allowed")]
    [TerraformPropertyName("schema")]
    public TerraformList<TerraformBlock<AzurermCosmosdbCassandraTableSchemaBlock>>? Schema { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCosmosdbCassandraTableTimeoutsBlock>? Timeouts { get; set; } = new();

}
