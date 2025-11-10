using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_specification in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableCapacitySpecificationBlock : ITerraformBlock
{
    /// <summary>
    /// The read_capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("read_capacity_units")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ReadCapacityUnits { get; set; }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    [TerraformPropertyName("throughput_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ThroughputMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "throughput_mode");

    /// <summary>
    /// The write_capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("write_capacity_units")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? WriteCapacityUnits { get; set; }

}

/// <summary>
/// Block type for client_side_timestamps in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableClientSideTimestampsBlock : ITerraformBlock
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    [TerraformPropertyName("status")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Status { get; set; }

}

/// <summary>
/// Block type for comment in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableCommentBlock : ITerraformBlock
{
    /// <summary>
    /// The message attribute.
    /// </summary>
    [TerraformPropertyName("message")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Message { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "message");

}

/// <summary>
/// Block type for encryption_specification in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableEncryptionSpecificationBlock : ITerraformBlock
{
    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyIdentifier { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Type { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "type");

}

/// <summary>
/// Block type for point_in_time_recovery in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTablePointInTimeRecoveryBlock : ITerraformBlock
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Status { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "status");

}

/// <summary>
/// Block type for schema_definition in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableSchemaDefinitionBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKeyspacesTableTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for ttl in .
/// Nesting mode: list
/// </summary>
public class AwsKeyspacesTableTtlBlock : ITerraformBlock
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    [TerraformPropertyName("status")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Status { get; set; }

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
    public TerraformProperty<TerraformProperty<double>>? DefaultTimeToLive { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The keyspace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyspaceName is required")]
    [TerraformPropertyName("keyspace_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyspaceName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformPropertyName("table_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TableName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for capacity_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacitySpecification block(s) allowed")]
    [TerraformPropertyName("capacity_specification")]
    public TerraformList<TerraformBlock<AwsKeyspacesTableCapacitySpecificationBlock>>? CapacitySpecification { get; set; } = new();

    /// <summary>
    /// Block for client_side_timestamps.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientSideTimestamps block(s) allowed")]
    [TerraformPropertyName("client_side_timestamps")]
    public TerraformList<TerraformBlock<AwsKeyspacesTableClientSideTimestampsBlock>>? ClientSideTimestamps { get; set; } = new();

    /// <summary>
    /// Block for comment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Comment block(s) allowed")]
    [TerraformPropertyName("comment")]
    public TerraformList<TerraformBlock<AwsKeyspacesTableCommentBlock>>? Comment { get; set; } = new();

    /// <summary>
    /// Block for encryption_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpecification block(s) allowed")]
    [TerraformPropertyName("encryption_specification")]
    public TerraformList<TerraformBlock<AwsKeyspacesTableEncryptionSpecificationBlock>>? EncryptionSpecification { get; set; } = new();

    /// <summary>
    /// Block for point_in_time_recovery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRecovery block(s) allowed")]
    [TerraformPropertyName("point_in_time_recovery")]
    public TerraformList<TerraformBlock<AwsKeyspacesTablePointInTimeRecoveryBlock>>? PointInTimeRecovery { get; set; } = new();

    /// <summary>
    /// Block for schema_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SchemaDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaDefinition block(s) allowed")]
    [TerraformPropertyName("schema_definition")]
    public TerraformList<TerraformBlock<AwsKeyspacesTableSchemaDefinitionBlock>>? SchemaDefinition { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsKeyspacesTableTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for ttl.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ttl block(s) allowed")]
    [TerraformPropertyName("ttl")]
    public TerraformList<TerraformBlock<AwsKeyspacesTableTtlBlock>>? Ttl { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
