using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsKeyspacesTableCapacitySpecificationBlock() : TerraformBlock("capacity_specification")
{
    /// <summary>
    /// The read_capacity_units attribute.
    /// </summary>
    [TerraformProperty("read_capacity_units")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ReadCapacityUnits { get; set; }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    [TerraformProperty("throughput_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ThroughputMode { get; set; }

    /// <summary>
    /// The write_capacity_units attribute.
    /// </summary>
    [TerraformProperty("write_capacity_units")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? WriteCapacityUnits { get; set; }

}

/// <summary>
/// Block type for client_side_timestamps in .
/// Nesting mode: list
/// </summary>
public partial class AwsKeyspacesTableClientSideTimestampsBlock() : TerraformBlock("client_side_timestamps")
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    [TerraformProperty("status")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Status { get; set; }

}

/// <summary>
/// Block type for comment in .
/// Nesting mode: list
/// </summary>
public partial class AwsKeyspacesTableCommentBlock() : TerraformBlock("comment")
{
    /// <summary>
    /// The message attribute.
    /// </summary>
    [TerraformProperty("message")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Message { get; set; }

}

/// <summary>
/// Block type for encryption_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsKeyspacesTableEncryptionSpecificationBlock() : TerraformBlock("encryption_specification")
{
    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    [TerraformProperty("kms_key_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyIdentifier { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for point_in_time_recovery in .
/// Nesting mode: list
/// </summary>
public partial class AwsKeyspacesTablePointInTimeRecoveryBlock() : TerraformBlock("point_in_time_recovery")
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Status { get; set; }

}

/// <summary>
/// Block type for schema_definition in .
/// Nesting mode: list
/// </summary>
public partial class AwsKeyspacesTableSchemaDefinitionBlock() : TerraformBlock("schema_definition")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsKeyspacesTableTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for ttl in .
/// Nesting mode: list
/// </summary>
public partial class AwsKeyspacesTableTtlBlock() : TerraformBlock("ttl")
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    [TerraformProperty("status")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Status { get; set; }

}

/// <summary>
/// Manages a aws_keyspaces_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsKeyspacesTable : TerraformResource
{
    public AwsKeyspacesTable(string name) : base("aws_keyspaces_table", name)
    {
    }

    /// <summary>
    /// The default_time_to_live attribute.
    /// </summary>
    [TerraformProperty("default_time_to_live")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DefaultTimeToLive { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The keyspace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyspaceName is required")]
    [TerraformProperty("keyspace_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyspaceName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformProperty("table_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for capacity_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacitySpecification block(s) allowed")]
    [TerraformProperty("capacity_specification")]
    public TerraformList<AwsKeyspacesTableCapacitySpecificationBlock> CapacitySpecification { get; set; } = new();

    /// <summary>
    /// Block for client_side_timestamps.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientSideTimestamps block(s) allowed")]
    [TerraformProperty("client_side_timestamps")]
    public TerraformList<AwsKeyspacesTableClientSideTimestampsBlock> ClientSideTimestamps { get; set; } = new();

    /// <summary>
    /// Block for comment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Comment block(s) allowed")]
    [TerraformProperty("comment")]
    public TerraformList<AwsKeyspacesTableCommentBlock> Comment { get; set; } = new();

    /// <summary>
    /// Block for encryption_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpecification block(s) allowed")]
    [TerraformProperty("encryption_specification")]
    public TerraformList<AwsKeyspacesTableEncryptionSpecificationBlock> EncryptionSpecification { get; set; } = new();

    /// <summary>
    /// Block for point_in_time_recovery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRecovery block(s) allowed")]
    [TerraformProperty("point_in_time_recovery")]
    public TerraformList<AwsKeyspacesTablePointInTimeRecoveryBlock> PointInTimeRecovery { get; set; } = new();

    /// <summary>
    /// Block for schema_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SchemaDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaDefinition block(s) allowed")]
    [TerraformProperty("schema_definition")]
    public required TerraformList<AwsKeyspacesTableSchemaDefinitionBlock> SchemaDefinition { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsKeyspacesTableTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for ttl.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ttl block(s) allowed")]
    [TerraformProperty("ttl")]
    public TerraformList<AwsKeyspacesTableTtlBlock> Ttl { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
