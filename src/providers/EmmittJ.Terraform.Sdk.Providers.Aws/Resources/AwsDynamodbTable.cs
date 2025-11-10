using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attribute in .
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableAttributeBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for global_secondary_index in .
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableGlobalSecondaryIndexBlock : ITerraformBlock
{
    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKey is required")]
    [TerraformPropertyName("hash_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HashKey { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The non_key_attributes attribute.
    /// </summary>
    [TerraformPropertyName("non_key_attributes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? NonKeyAttributes { get; set; }

    /// <summary>
    /// The projection_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectionType is required")]
    [TerraformPropertyName("projection_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProjectionType { get; set; }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    [TerraformPropertyName("range_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RangeKey { get; set; }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    [TerraformPropertyName("read_capacity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ReadCapacity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "read_capacity");

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    [TerraformPropertyName("write_capacity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> WriteCapacity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "write_capacity");

}

/// <summary>
/// Block type for import_table in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableImportTableBlock : ITerraformBlock
{
    /// <summary>
    /// The input_compression_type attribute.
    /// </summary>
    [TerraformPropertyName("input_compression_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InputCompressionType { get; set; }

    /// <summary>
    /// The input_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputFormat is required")]
    [TerraformPropertyName("input_format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InputFormat { get; set; }

}

/// <summary>
/// Block type for local_secondary_index in .
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableLocalSecondaryIndexBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The non_key_attributes attribute.
    /// </summary>
    [TerraformPropertyName("non_key_attributes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? NonKeyAttributes { get; set; }

    /// <summary>
    /// The projection_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectionType is required")]
    [TerraformPropertyName("projection_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProjectionType { get; set; }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeKey is required")]
    [TerraformPropertyName("range_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RangeKey { get; set; }

}

/// <summary>
/// Block type for on_demand_throughput in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableOnDemandThroughputBlock : ITerraformBlock
{
    /// <summary>
    /// The max_read_request_units attribute.
    /// </summary>
    [TerraformPropertyName("max_read_request_units")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxReadRequestUnits { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_read_request_units");

    /// <summary>
    /// The max_write_request_units attribute.
    /// </summary>
    [TerraformPropertyName("max_write_request_units")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxWriteRequestUnits { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_write_request_units");

}

/// <summary>
/// Block type for point_in_time_recovery in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTablePointInTimeRecoveryBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The recovery_period_in_days attribute.
    /// </summary>
    [TerraformPropertyName("recovery_period_in_days")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> RecoveryPeriodInDays { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "recovery_period_in_days");

}

/// <summary>
/// Block type for replica in .
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableReplicaBlock : ITerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>("", "arn");

    /// <summary>
    /// The consistency_mode attribute.
    /// </summary>
    [TerraformPropertyName("consistency_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConsistencyMode { get; set; }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DeletionProtectionEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "deletion_protection_enabled");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_arn");

    /// <summary>
    /// The point_in_time_recovery attribute.
    /// </summary>
    [TerraformPropertyName("point_in_time_recovery")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PointInTimeRecovery { get; set; }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    [TerraformPropertyName("propagate_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PropagateTags { get; set; }

    /// <summary>
    /// The region_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    [TerraformPropertyName("region_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RegionName { get; set; }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [TerraformPropertyName("stream_arn")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StreamArn => new TerraformReferenceProperty<TerraformProperty<string>>("", "stream_arn");

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    [TerraformPropertyName("stream_label")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StreamLabel => new TerraformReferenceProperty<TerraformProperty<string>>("", "stream_label");

}

/// <summary>
/// Block type for server_side_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableServerSideEncryptionBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_arn");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDynamodbTableTimeoutsBlock : ITerraformBlock
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
public class AwsDynamodbTableTtlBlock : ITerraformBlock
{
    /// <summary>
    /// The attribute_name attribute.
    /// </summary>
    [TerraformPropertyName("attribute_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AttributeName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

}

/// <summary>
/// Block type for warm_throughput in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableWarmThroughputBlock : ITerraformBlock
{
    /// <summary>
    /// The read_units_per_second attribute.
    /// </summary>
    [TerraformPropertyName("read_units_per_second")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ReadUnitsPerSecond { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "read_units_per_second");

    /// <summary>
    /// The write_units_per_second attribute.
    /// </summary>
    [TerraformPropertyName("write_units_per_second")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> WriteUnitsPerSecond { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "write_units_per_second");

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
    public TerraformProperty<TerraformProperty<string>>? BillingMode { get; set; }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    [TerraformPropertyName("hash_key")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HashKey { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hash_key");

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
    /// The range_key attribute.
    /// </summary>
    [TerraformPropertyName("range_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RangeKey { get; set; }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    [TerraformPropertyName("read_capacity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ReadCapacity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "read_capacity");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The restore_date_time attribute.
    /// </summary>
    [TerraformPropertyName("restore_date_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RestoreDateTime { get; set; }

    /// <summary>
    /// The restore_source_name attribute.
    /// </summary>
    [TerraformPropertyName("restore_source_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RestoreSourceName { get; set; }

    /// <summary>
    /// The restore_source_table_arn attribute.
    /// </summary>
    [TerraformPropertyName("restore_source_table_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RestoreSourceTableArn { get; set; }

    /// <summary>
    /// The restore_to_latest_time attribute.
    /// </summary>
    [TerraformPropertyName("restore_to_latest_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RestoreToLatestTime { get; set; }

    /// <summary>
    /// The stream_enabled attribute.
    /// </summary>
    [TerraformPropertyName("stream_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? StreamEnabled { get; set; }

    /// <summary>
    /// The stream_view_type attribute.
    /// </summary>
    [TerraformPropertyName("stream_view_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StreamViewType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "stream_view_type");

    /// <summary>
    /// The table_class attribute.
    /// </summary>
    [TerraformPropertyName("table_class")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TableClass { get; set; }

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
    /// The write_capacity attribute.
    /// </summary>
    [TerraformPropertyName("write_capacity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> WriteCapacity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "write_capacity");

    /// <summary>
    /// Block for attribute.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("attribute")]
    public TerraformSet<TerraformBlock<AwsDynamodbTableAttributeBlock>>? Attribute { get; set; } = new();

    /// <summary>
    /// Block for global_secondary_index.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("global_secondary_index")]
    public TerraformSet<TerraformBlock<AwsDynamodbTableGlobalSecondaryIndexBlock>>? GlobalSecondaryIndex { get; set; } = new();

    /// <summary>
    /// Block for import_table.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImportTable block(s) allowed")]
    [TerraformPropertyName("import_table")]
    public TerraformList<TerraformBlock<AwsDynamodbTableImportTableBlock>>? ImportTable { get; set; } = new();

    /// <summary>
    /// Block for local_secondary_index.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("local_secondary_index")]
    public TerraformSet<TerraformBlock<AwsDynamodbTableLocalSecondaryIndexBlock>>? LocalSecondaryIndex { get; set; } = new();

    /// <summary>
    /// Block for on_demand_throughput.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDemandThroughput block(s) allowed")]
    [TerraformPropertyName("on_demand_throughput")]
    public TerraformList<TerraformBlock<AwsDynamodbTableOnDemandThroughputBlock>>? OnDemandThroughput { get; set; } = new();

    /// <summary>
    /// Block for point_in_time_recovery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRecovery block(s) allowed")]
    [TerraformPropertyName("point_in_time_recovery")]
    public TerraformList<TerraformBlock<AwsDynamodbTablePointInTimeRecoveryBlock>>? PointInTimeRecovery { get; set; } = new();

    /// <summary>
    /// Block for replica.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("replica")]
    public TerraformSet<TerraformBlock<AwsDynamodbTableReplicaBlock>>? Replica { get; set; } = new();

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    [TerraformPropertyName("server_side_encryption")]
    public TerraformList<TerraformBlock<AwsDynamodbTableServerSideEncryptionBlock>>? ServerSideEncryption { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDynamodbTableTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for ttl.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ttl block(s) allowed")]
    [TerraformPropertyName("ttl")]
    public TerraformList<TerraformBlock<AwsDynamodbTableTtlBlock>>? Ttl { get; set; } = new();

    /// <summary>
    /// Block for warm_throughput.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WarmThroughput block(s) allowed")]
    [TerraformPropertyName("warm_throughput")]
    public TerraformList<TerraformBlock<AwsDynamodbTableWarmThroughputBlock>>? WarmThroughput { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [TerraformPropertyName("stream_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StreamArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "stream_arn");

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    [TerraformPropertyName("stream_label")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StreamLabel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "stream_label");

}
