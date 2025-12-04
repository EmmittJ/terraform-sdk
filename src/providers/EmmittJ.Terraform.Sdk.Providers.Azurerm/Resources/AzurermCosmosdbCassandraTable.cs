using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for autoscale_settings in AzurermCosmosdbCassandraTable.
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
    public TerraformValue<double>? MaxThroughput
    {
        get => GetArgument<TerraformValue<double>>("max_throughput");
        set => SetArgument("max_throughput", value);
    }

}


/// <summary>
/// Block type for schema in AzurermCosmosdbCassandraTable.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbCassandraTableSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema";

    /// <summary>
    /// ClusterKey block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCosmosdbCassandraTableSchemaBlockClusterKeyBlock>? ClusterKey
    {
        get => GetArgument<TerraformList<AzurermCosmosdbCassandraTableSchemaBlockClusterKeyBlock>>("cluster_key");
        set => SetArgument("cluster_key", value);
    }

    /// <summary>
    /// Column block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Column is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Column block(s) required")]
    public required TerraformList<AzurermCosmosdbCassandraTableSchemaBlockColumnBlock> Column
    {
        get => GetRequiredArgument<TerraformList<AzurermCosmosdbCassandraTableSchemaBlockColumnBlock>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// PartitionKey block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKey is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PartitionKey block(s) required")]
    public required TerraformList<AzurermCosmosdbCassandraTableSchemaBlockPartitionKeyBlock> PartitionKey
    {
        get => GetRequiredArgument<TerraformList<AzurermCosmosdbCassandraTableSchemaBlockPartitionKeyBlock>>("partition_key");
        set => SetArgument("partition_key", value);
    }

}

/// <summary>
/// Block type for cluster_key in AzurermCosmosdbCassandraTableSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbCassandraTableSchemaBlockClusterKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cluster_key";

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
    /// The order_by attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrderBy is required")]
    public required TerraformValue<string> OrderBy
    {
        get => GetArgument<TerraformValue<string>>("order_by");
        set => SetArgument("order_by", value);
    }

}

/// <summary>
/// Block type for column in AzurermCosmosdbCassandraTableSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbCassandraTableSchemaBlockColumnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "column";

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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for partition_key in AzurermCosmosdbCassandraTableSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbCassandraTableSchemaBlockPartitionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "partition_key";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermCosmosdbCassandraTable.
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
/// Represents a azurerm_cosmosdb_cassandra_table Terraform resource.
/// Manages a azurerm_cosmosdb_cassandra_table resource.
/// </summary>
public partial class AzurermCosmosdbCassandraTable(string name) : TerraformResource("azurerm_cosmosdb_cassandra_table", name)
{
    /// <summary>
    /// The analytical_storage_ttl attribute.
    /// </summary>
    public TerraformValue<double>? AnalyticalStorageTtl
    {
        get => GetArgument<TerraformValue<double>>("analytical_storage_ttl");
        set => SetArgument("analytical_storage_ttl", value);
    }

    /// <summary>
    /// The cassandra_keyspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CassandraKeyspaceId is required")]
    public required TerraformValue<string> CassandraKeyspaceId
    {
        get => GetArgument<TerraformValue<string>>("cassandra_keyspace_id");
        set => SetArgument("cassandra_keyspace_id", value);
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
    public TerraformList<AzurermCosmosdbCassandraTableAutoscaleSettingsBlock>? AutoscaleSettings
    {
        get => GetArgument<TerraformList<AzurermCosmosdbCassandraTableAutoscaleSettingsBlock>>("autoscale_settings");
        set => SetArgument("autoscale_settings", value);
    }

    /// <summary>
    /// Schema block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schema block(s) allowed")]
    public required TerraformList<AzurermCosmosdbCassandraTableSchemaBlock> Schema
    {
        get => GetRequiredArgument<TerraformList<AzurermCosmosdbCassandraTableSchemaBlock>>("schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCosmosdbCassandraTableTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCosmosdbCassandraTableTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
