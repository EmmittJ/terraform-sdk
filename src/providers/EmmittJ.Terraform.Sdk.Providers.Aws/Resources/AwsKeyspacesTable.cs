using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_specification in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableCapacitySpecificationBlock
{
    /// <summary>
    /// The read_capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("read_capacity_units")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ReadCapacityUnits { get; set; }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    [TerraformPropertyName("throughput_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ThroughputMode { get; set; } = default!;

    /// <summary>
    /// The write_capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("write_capacity_units")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? WriteCapacityUnits { get; set; }

}

/// <summary>
/// Block type for client_side_timestamps in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableClientSideTimestampsBlock
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    [TerraformPropertyName("status")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Status { get; set; }

}

/// <summary>
/// Block type for comment in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableCommentBlock
{
    /// <summary>
    /// The message attribute.
    /// </summary>
    [TerraformPropertyName("message")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Message { get; set; } = default!;

}

/// <summary>
/// Block type for encryption_specification in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableEncryptionSpecificationBlock
{
    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyIdentifier { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Type { get; set; } = default!;

}

/// <summary>
/// Block type for point_in_time_recovery in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTablePointInTimeRecoveryBlock
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Status { get; set; } = default!;

}

/// <summary>
/// Block type for schema_definition in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableSchemaDefinitionBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKeyspacesTableTimeoutsBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for ttl in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableTtlBlock
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    [TerraformPropertyName("status")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Status { get; set; }

}

/// <summary>
/// Manages a aws_keyspaces_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsKeyspacesTable : TerraformResource
{
    public AwsKeyspacesTable(string name) : base("aws_keyspaces_table", name)
    {
    }

    /// <summary>
    /// The default_time_to_live attribute.
    /// </summary>
    [TerraformPropertyName("default_time_to_live")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DefaultTimeToLive { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The keyspace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyspaceName is required")]
    [TerraformPropertyName("keyspace_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyspaceName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformPropertyName("table_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TableName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for capacity_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacitySpecification block(s) allowed")]
    [TerraformPropertyName("capacity_specification")]
    public TerraformList<TerraformBlock<AwsKeyspacesTableCapacitySpecificationBlock>>? CapacitySpecification { get; set; }

    /// <summary>
    /// Block for client_side_timestamps.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientSideTimestamps block(s) allowed")]
    [TerraformPropertyName("client_side_timestamps")]
    public TerraformList<TerraformBlock<AwsKeyspacesTableClientSideTimestampsBlock>>? ClientSideTimestamps { get; set; }

    /// <summary>
    /// Block for comment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Comment block(s) allowed")]
    [TerraformPropertyName("comment")]
    public TerraformList<TerraformBlock<AwsKeyspacesTableCommentBlock>>? Comment { get; set; }

    /// <summary>
    /// Block for encryption_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpecification block(s) allowed")]
    [TerraformPropertyName("encryption_specification")]
    public TerraformList<TerraformBlock<AwsKeyspacesTableEncryptionSpecificationBlock>>? EncryptionSpecification { get; set; }

    /// <summary>
    /// Block for point_in_time_recovery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRecovery block(s) allowed")]
    [TerraformPropertyName("point_in_time_recovery")]
    public TerraformList<TerraformBlock<AwsKeyspacesTablePointInTimeRecoveryBlock>>? PointInTimeRecovery { get; set; }

    /// <summary>
    /// Block for schema_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SchemaDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaDefinition block(s) allowed")]
    [TerraformPropertyName("schema_definition")]
    public TerraformList<TerraformBlock<AwsKeyspacesTableSchemaDefinitionBlock>>? SchemaDefinition { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsKeyspacesTableTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for ttl.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ttl block(s) allowed")]
    [TerraformPropertyName("ttl")]
    public TerraformList<TerraformBlock<AwsKeyspacesTableTtlBlock>>? Ttl { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
