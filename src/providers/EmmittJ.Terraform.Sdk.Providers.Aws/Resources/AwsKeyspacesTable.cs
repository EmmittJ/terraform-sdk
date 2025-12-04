using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_specification in AwsKeyspacesTable.
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableCapacitySpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_specification";

    /// <summary>
    /// The read_capacity_units attribute.
    /// </summary>
    public TerraformValue<double>? ReadCapacityUnits
    {
        get => GetArgument<TerraformValue<double>>("read_capacity_units");
        set => SetArgument("read_capacity_units", value);
    }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    public TerraformValue<string> ThroughputMode
    {
        get => GetArgument<TerraformValue<string>>("throughput_mode") ?? AsReference("throughput_mode");
        set => SetArgument("throughput_mode", value);
    }

    /// <summary>
    /// The write_capacity_units attribute.
    /// </summary>
    public TerraformValue<double>? WriteCapacityUnits
    {
        get => GetArgument<TerraformValue<double>>("write_capacity_units");
        set => SetArgument("write_capacity_units", value);
    }

}


/// <summary>
/// Block type for client_side_timestamps in AwsKeyspacesTable.
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableClientSideTimestampsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_side_timestamps";

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => GetRequiredArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}


/// <summary>
/// Block type for comment in AwsKeyspacesTable.
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableCommentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "comment";

    /// <summary>
    /// The message attribute.
    /// </summary>
    public TerraformValue<string> Message
    {
        get => GetArgument<TerraformValue<string>>("message") ?? AsReference("message");
        set => SetArgument("message", value);
    }

}


/// <summary>
/// Block type for encryption_specification in AwsKeyspacesTable.
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableEncryptionSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_specification";

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyIdentifier
    {
        get => GetArgument<TerraformValue<string>>("kms_key_identifier");
        set => SetArgument("kms_key_identifier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type") ?? AsReference("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for point_in_time_recovery in AwsKeyspacesTable.
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTablePointInTimeRecoveryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "point_in_time_recovery";

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => GetArgument<TerraformValue<string>>("status") ?? AsReference("status");
        set => SetArgument("status", value);
    }

}


/// <summary>
/// Block type for schema_definition in AwsKeyspacesTable.
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableSchemaDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_definition";

    /// <summary>
    /// ClusteringKey block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsKeyspacesTableSchemaDefinitionBlockClusteringKeyBlock>? ClusteringKey
    {
        get => GetArgument<TerraformList<AwsKeyspacesTableSchemaDefinitionBlockClusteringKeyBlock>>("clustering_key");
        set => SetArgument("clustering_key", value);
    }

    /// <summary>
    /// Column block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Column is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Column block(s) required")]
    public required TerraformSet<AwsKeyspacesTableSchemaDefinitionBlockColumnBlock> Column
    {
        get => GetRequiredArgument<TerraformSet<AwsKeyspacesTableSchemaDefinitionBlockColumnBlock>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// PartitionKey block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKey is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PartitionKey block(s) required")]
    public required TerraformList<AwsKeyspacesTableSchemaDefinitionBlockPartitionKeyBlock> PartitionKey
    {
        get => GetRequiredArgument<TerraformList<AwsKeyspacesTableSchemaDefinitionBlockPartitionKeyBlock>>("partition_key");
        set => SetArgument("partition_key", value);
    }

    /// <summary>
    /// StaticColumn block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsKeyspacesTableSchemaDefinitionBlockStaticColumnBlock>? StaticColumn
    {
        get => GetArgument<TerraformSet<AwsKeyspacesTableSchemaDefinitionBlockStaticColumnBlock>>("static_column");
        set => SetArgument("static_column", value);
    }

}

/// <summary>
/// Block type for clustering_key in AwsKeyspacesTableSchemaDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableSchemaDefinitionBlockClusteringKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "clustering_key";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The order_by attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrderBy is required")]
    public required TerraformValue<string> OrderBy
    {
        get => GetRequiredArgument<TerraformValue<string>>("order_by");
        set => SetArgument("order_by", value);
    }

}

/// <summary>
/// Block type for column in AwsKeyspacesTableSchemaDefinitionBlock.
/// Nesting mode: set
/// </summary>
public class AwsKeyspacesTableSchemaDefinitionBlockColumnBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for partition_key in AwsKeyspacesTableSchemaDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableSchemaDefinitionBlockPartitionKeyBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for static_column in AwsKeyspacesTableSchemaDefinitionBlock.
/// Nesting mode: set
/// </summary>
public class AwsKeyspacesTableSchemaDefinitionBlockStaticColumnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "static_column";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsKeyspacesTable.
/// Nesting mode: single
/// </summary>
public class AwsKeyspacesTableTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for ttl in AwsKeyspacesTable.
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableTtlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ttl";

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => GetRequiredArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}


/// <summary>
/// Represents a aws_keyspaces_table Terraform resource.
/// Manages a aws_keyspaces_table resource.
/// </summary>
public partial class AwsKeyspacesTable(string name) : TerraformResource("aws_keyspaces_table", name)
{
    /// <summary>
    /// The default_time_to_live attribute.
    /// </summary>
    public TerraformValue<double>? DefaultTimeToLive
    {
        get => GetArgument<TerraformValue<double>>("default_time_to_live");
        set => SetArgument("default_time_to_live", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The keyspace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyspaceName is required")]
    public required TerraformValue<string> KeyspaceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("keyspace_name");
        set => SetArgument("keyspace_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// CapacitySpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacitySpecification block(s) allowed")]
    public TerraformList<AwsKeyspacesTableCapacitySpecificationBlock>? CapacitySpecification
    {
        get => GetArgument<TerraformList<AwsKeyspacesTableCapacitySpecificationBlock>>("capacity_specification");
        set => SetArgument("capacity_specification", value);
    }

    /// <summary>
    /// ClientSideTimestamps block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientSideTimestamps block(s) allowed")]
    public TerraformList<AwsKeyspacesTableClientSideTimestampsBlock>? ClientSideTimestamps
    {
        get => GetArgument<TerraformList<AwsKeyspacesTableClientSideTimestampsBlock>>("client_side_timestamps");
        set => SetArgument("client_side_timestamps", value);
    }

    /// <summary>
    /// Comment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Comment block(s) allowed")]
    public TerraformList<AwsKeyspacesTableCommentBlock>? Comment
    {
        get => GetArgument<TerraformList<AwsKeyspacesTableCommentBlock>>("comment");
        set => SetArgument("comment", value);
    }

    /// <summary>
    /// EncryptionSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpecification block(s) allowed")]
    public TerraformList<AwsKeyspacesTableEncryptionSpecificationBlock>? EncryptionSpecification
    {
        get => GetArgument<TerraformList<AwsKeyspacesTableEncryptionSpecificationBlock>>("encryption_specification");
        set => SetArgument("encryption_specification", value);
    }

    /// <summary>
    /// PointInTimeRecovery block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRecovery block(s) allowed")]
    public TerraformList<AwsKeyspacesTablePointInTimeRecoveryBlock>? PointInTimeRecovery
    {
        get => GetArgument<TerraformList<AwsKeyspacesTablePointInTimeRecoveryBlock>>("point_in_time_recovery");
        set => SetArgument("point_in_time_recovery", value);
    }

    /// <summary>
    /// SchemaDefinition block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SchemaDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaDefinition block(s) allowed")]
    public required TerraformList<AwsKeyspacesTableSchemaDefinitionBlock> SchemaDefinition
    {
        get => GetRequiredArgument<TerraformList<AwsKeyspacesTableSchemaDefinitionBlock>>("schema_definition");
        set => SetArgument("schema_definition", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsKeyspacesTableTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsKeyspacesTableTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Ttl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ttl block(s) allowed")]
    public TerraformList<AwsKeyspacesTableTtlBlock>? Ttl
    {
        get => GetArgument<TerraformList<AwsKeyspacesTableTtlBlock>>("ttl");
        set => SetArgument("ttl", value);
    }

}
