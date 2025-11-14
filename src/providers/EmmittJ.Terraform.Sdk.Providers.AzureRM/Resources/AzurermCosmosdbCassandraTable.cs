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
public class AzurermCosmosdbCassandraTableAutoscaleSettingsBlock : TerraformBlock
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
/// Block type for schema in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbCassandraTableSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema";

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbCassandraTableTimeoutsBlock : TerraformBlock
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
    [TerraformArgument("analytical_storage_ttl")]
    public TerraformValue<double>? AnalyticalStorageTtl
    {
        get => new TerraformReference<double>(this, "analytical_storage_ttl");
        set => SetArgument("analytical_storage_ttl", value);
    }

    /// <summary>
    /// The cassandra_keyspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CassandraKeyspaceId is required")]
    [TerraformArgument("cassandra_keyspace_id")]
    public required TerraformValue<string> CassandraKeyspaceId
    {
        get => new TerraformReference<string>(this, "cassandra_keyspace_id");
        set => SetArgument("cassandra_keyspace_id", value);
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
    public TerraformList<AzurermCosmosdbCassandraTableAutoscaleSettingsBlock> AutoscaleSettings { get; set; } = new();

    /// <summary>
    /// Block for schema.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schema block(s) allowed")]
    [TerraformArgument("schema")]
    public required TerraformList<AzurermCosmosdbCassandraTableSchemaBlock> Schema { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCosmosdbCassandraTableTimeoutsBlock Timeouts { get; set; } = new();

}
