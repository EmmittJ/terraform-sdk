using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attribute in .
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableAttributeBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for global_secondary_index in .
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableGlobalSecondaryIndexBlock
{
    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKey is required")]
    [TerraformPropertyName("hash_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HashKey { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The non_key_attributes attribute.
    /// </summary>
    [TerraformPropertyName("non_key_attributes")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? NonKeyAttributes { get; set; }

    /// <summary>
    /// The projection_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectionType is required")]
    [TerraformPropertyName("projection_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ProjectionType { get; set; }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    [TerraformPropertyName("range_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RangeKey { get; set; }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    [TerraformPropertyName("read_capacity")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ReadCapacity { get; set; } = default!;

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    [TerraformPropertyName("write_capacity")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> WriteCapacity { get; set; } = default!;

}

/// <summary>
/// Block type for import_table in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableImportTableBlock
{
    /// <summary>
    /// The input_compression_type attribute.
    /// </summary>
    [TerraformPropertyName("input_compression_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InputCompressionType { get; set; }

    /// <summary>
    /// The input_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputFormat is required")]
    [TerraformPropertyName("input_format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InputFormat { get; set; }

}

/// <summary>
/// Block type for local_secondary_index in .
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableLocalSecondaryIndexBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The non_key_attributes attribute.
    /// </summary>
    [TerraformPropertyName("non_key_attributes")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? NonKeyAttributes { get; set; }

    /// <summary>
    /// The projection_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectionType is required")]
    [TerraformPropertyName("projection_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ProjectionType { get; set; }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeKey is required")]
    [TerraformPropertyName("range_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RangeKey { get; set; }

}

/// <summary>
/// Block type for on_demand_throughput in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableOnDemandThroughputBlock
{
    /// <summary>
    /// The max_read_request_units attribute.
    /// </summary>
    [TerraformPropertyName("max_read_request_units")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxReadRequestUnits { get; set; } = default!;

    /// <summary>
    /// The max_write_request_units attribute.
    /// </summary>
    [TerraformPropertyName("max_write_request_units")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxWriteRequestUnits { get; set; } = default!;

}

/// <summary>
/// Block type for point_in_time_recovery in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTablePointInTimeRecoveryBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The recovery_period_in_days attribute.
    /// </summary>
    [TerraformPropertyName("recovery_period_in_days")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> RecoveryPeriodInDays { get; set; } = default!;

}

/// <summary>
/// Block type for replica in .
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableReplicaBlock
{

    /// <summary>
    /// The consistency_mode attribute.
    /// </summary>
    [TerraformPropertyName("consistency_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConsistencyMode { get; set; }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> DeletionProtectionEnabled { get; set; } = default!;

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyArn { get; set; } = default!;

    /// <summary>
    /// The point_in_time_recovery attribute.
    /// </summary>
    [TerraformPropertyName("point_in_time_recovery")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PointInTimeRecovery { get; set; }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    [TerraformPropertyName("propagate_tags")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PropagateTags { get; set; }

    /// <summary>
    /// The region_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    [TerraformPropertyName("region_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RegionName { get; set; }



}

/// <summary>
/// Block type for server_side_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableServerSideEncryptionBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyArn { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDynamodbTableTimeoutsBlock
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
public class AwsDynamodbTableTtlBlock
{
    /// <summary>
    /// The attribute_name attribute.
    /// </summary>
    [TerraformPropertyName("attribute_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AttributeName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for warm_throughput in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableWarmThroughputBlock
{
    /// <summary>
    /// The read_units_per_second attribute.
    /// </summary>
    [TerraformPropertyName("read_units_per_second")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ReadUnitsPerSecond { get; set; } = default!;

    /// <summary>
    /// The write_units_per_second attribute.
    /// </summary>
    [TerraformPropertyName("write_units_per_second")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> WriteUnitsPerSecond { get; set; } = default!;

}

/// <summary>
/// Manages a aws_dynamodb_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDynamodbTable : TerraformResource
{
    public AwsDynamodbTable(string name) : base("aws_dynamodb_table", name)
    {
    }

    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    [TerraformPropertyName("billing_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BillingMode { get; set; }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    [TerraformPropertyName("hash_key")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> HashKey { get; set; } = default!;

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
    /// The range_key attribute.
    /// </summary>
    [TerraformPropertyName("range_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RangeKey { get; set; }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    [TerraformPropertyName("read_capacity")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ReadCapacity { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The restore_date_time attribute.
    /// </summary>
    [TerraformPropertyName("restore_date_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RestoreDateTime { get; set; }

    /// <summary>
    /// The restore_source_name attribute.
    /// </summary>
    [TerraformPropertyName("restore_source_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RestoreSourceName { get; set; }

    /// <summary>
    /// The restore_source_table_arn attribute.
    /// </summary>
    [TerraformPropertyName("restore_source_table_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RestoreSourceTableArn { get; set; }

    /// <summary>
    /// The restore_to_latest_time attribute.
    /// </summary>
    [TerraformPropertyName("restore_to_latest_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RestoreToLatestTime { get; set; }

    /// <summary>
    /// The stream_enabled attribute.
    /// </summary>
    [TerraformPropertyName("stream_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? StreamEnabled { get; set; }

    /// <summary>
    /// The stream_view_type attribute.
    /// </summary>
    [TerraformPropertyName("stream_view_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StreamViewType { get; set; } = default!;

    /// <summary>
    /// The table_class attribute.
    /// </summary>
    [TerraformPropertyName("table_class")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TableClass { get; set; }

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
    /// The write_capacity attribute.
    /// </summary>
    [TerraformPropertyName("write_capacity")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> WriteCapacity { get; set; } = default!;

    /// <summary>
    /// Block for attribute.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("attribute")]
    public TerraformSet<TerraformBlock<AwsDynamodbTableAttributeBlock>>? Attribute { get; set; }

    /// <summary>
    /// Block for global_secondary_index.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("global_secondary_index")]
    public TerraformSet<TerraformBlock<AwsDynamodbTableGlobalSecondaryIndexBlock>>? GlobalSecondaryIndex { get; set; }

    /// <summary>
    /// Block for import_table.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImportTable block(s) allowed")]
    [TerraformPropertyName("import_table")]
    public TerraformList<TerraformBlock<AwsDynamodbTableImportTableBlock>>? ImportTable { get; set; }

    /// <summary>
    /// Block for local_secondary_index.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("local_secondary_index")]
    public TerraformSet<TerraformBlock<AwsDynamodbTableLocalSecondaryIndexBlock>>? LocalSecondaryIndex { get; set; }

    /// <summary>
    /// Block for on_demand_throughput.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDemandThroughput block(s) allowed")]
    [TerraformPropertyName("on_demand_throughput")]
    public TerraformList<TerraformBlock<AwsDynamodbTableOnDemandThroughputBlock>>? OnDemandThroughput { get; set; }

    /// <summary>
    /// Block for point_in_time_recovery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRecovery block(s) allowed")]
    [TerraformPropertyName("point_in_time_recovery")]
    public TerraformList<TerraformBlock<AwsDynamodbTablePointInTimeRecoveryBlock>>? PointInTimeRecovery { get; set; }

    /// <summary>
    /// Block for replica.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("replica")]
    public TerraformSet<TerraformBlock<AwsDynamodbTableReplicaBlock>>? Replica { get; set; }

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    [TerraformPropertyName("server_side_encryption")]
    public TerraformList<TerraformBlock<AwsDynamodbTableServerSideEncryptionBlock>>? ServerSideEncryption { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDynamodbTableTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for ttl.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ttl block(s) allowed")]
    [TerraformPropertyName("ttl")]
    public TerraformList<TerraformBlock<AwsDynamodbTableTtlBlock>>? Ttl { get; set; }

    /// <summary>
    /// Block for warm_throughput.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WarmThroughput block(s) allowed")]
    [TerraformPropertyName("warm_throughput")]
    public TerraformList<TerraformBlock<AwsDynamodbTableWarmThroughputBlock>>? WarmThroughput { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [TerraformPropertyName("stream_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StreamArn => new TerraformReference(this, "stream_arn");

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    [TerraformPropertyName("stream_label")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StreamLabel => new TerraformReference(this, "stream_label");

}
