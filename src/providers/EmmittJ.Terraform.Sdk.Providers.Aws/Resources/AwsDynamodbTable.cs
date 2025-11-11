using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attribute in .
/// Nesting mode: set
/// </summary>
public partial class AwsDynamodbTableAttributeBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for global_secondary_index in .
/// Nesting mode: set
/// </summary>
public partial class AwsDynamodbTableGlobalSecondaryIndexBlock : TerraformBlockBase
{
    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKey is required")]
    [TerraformProperty("hash_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HashKey { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The non_key_attributes attribute.
    /// </summary>
    [TerraformProperty("non_key_attributes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? NonKeyAttributes { get; set; }

    /// <summary>
    /// The projection_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectionType is required")]
    [TerraformProperty("projection_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProjectionType { get; set; }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    [TerraformProperty("range_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RangeKey { get; set; }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    [TerraformProperty("read_capacity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ReadCapacity { get; set; }

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    [TerraformProperty("write_capacity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> WriteCapacity { get; set; }

}

/// <summary>
/// Block type for import_table in .
/// Nesting mode: list
/// </summary>
public partial class AwsDynamodbTableImportTableBlock : TerraformBlockBase
{
    /// <summary>
    /// The input_compression_type attribute.
    /// </summary>
    [TerraformProperty("input_compression_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InputCompressionType { get; set; }

    /// <summary>
    /// The input_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputFormat is required")]
    [TerraformProperty("input_format")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InputFormat { get; set; }

}

/// <summary>
/// Block type for local_secondary_index in .
/// Nesting mode: set
/// </summary>
public partial class AwsDynamodbTableLocalSecondaryIndexBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The non_key_attributes attribute.
    /// </summary>
    [TerraformProperty("non_key_attributes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? NonKeyAttributes { get; set; }

    /// <summary>
    /// The projection_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectionType is required")]
    [TerraformProperty("projection_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProjectionType { get; set; }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeKey is required")]
    [TerraformProperty("range_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RangeKey { get; set; }

}

/// <summary>
/// Block type for on_demand_throughput in .
/// Nesting mode: list
/// </summary>
public partial class AwsDynamodbTableOnDemandThroughputBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_read_request_units attribute.
    /// </summary>
    [TerraformProperty("max_read_request_units")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxReadRequestUnits { get; set; }

    /// <summary>
    /// The max_write_request_units attribute.
    /// </summary>
    [TerraformProperty("max_write_request_units")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxWriteRequestUnits { get; set; }

}

/// <summary>
/// Block type for point_in_time_recovery in .
/// Nesting mode: list
/// </summary>
public partial class AwsDynamodbTablePointInTimeRecoveryBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The recovery_period_in_days attribute.
    /// </summary>
    [TerraformProperty("recovery_period_in_days")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> RecoveryPeriodInDays { get; set; }

}

/// <summary>
/// Block type for replica in .
/// Nesting mode: set
/// </summary>
public partial class AwsDynamodbTableReplicaBlock : TerraformBlockBase
{

    /// <summary>
    /// The consistency_mode attribute.
    /// </summary>
    [TerraformProperty("consistency_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConsistencyMode { get; set; }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("deletion_protection_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyArn { get; set; }

    /// <summary>
    /// The point_in_time_recovery attribute.
    /// </summary>
    [TerraformProperty("point_in_time_recovery")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PointInTimeRecovery { get; set; }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    [TerraformProperty("propagate_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PropagateTags { get; set; }

    /// <summary>
    /// The region_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    [TerraformProperty("region_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RegionName { get; set; }



}

/// <summary>
/// Block type for server_side_encryption in .
/// Nesting mode: list
/// </summary>
public partial class AwsDynamodbTableServerSideEncryptionBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDynamodbTableTimeoutsBlock : TerraformBlockBase
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
public partial class AwsDynamodbTableTtlBlock : TerraformBlockBase
{
    /// <summary>
    /// The attribute_name attribute.
    /// </summary>
    [TerraformProperty("attribute_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AttributeName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for warm_throughput in .
/// Nesting mode: list
/// </summary>
public partial class AwsDynamodbTableWarmThroughputBlock : TerraformBlockBase
{
    /// <summary>
    /// The read_units_per_second attribute.
    /// </summary>
    [TerraformProperty("read_units_per_second")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ReadUnitsPerSecond { get; set; }

    /// <summary>
    /// The write_units_per_second attribute.
    /// </summary>
    [TerraformProperty("write_units_per_second")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> WriteUnitsPerSecond { get; set; }

}

/// <summary>
/// Manages a aws_dynamodb_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDynamodbTable : TerraformResource
{
    public AwsDynamodbTable(string name) : base("aws_dynamodb_table", name)
    {
    }

    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    [TerraformProperty("billing_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BillingMode { get; set; }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("deletion_protection_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    [TerraformProperty("hash_key")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HashKey { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    [TerraformProperty("range_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RangeKey { get; set; }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    [TerraformProperty("read_capacity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ReadCapacity { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The restore_date_time attribute.
    /// </summary>
    [TerraformProperty("restore_date_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RestoreDateTime { get; set; }

    /// <summary>
    /// The restore_source_name attribute.
    /// </summary>
    [TerraformProperty("restore_source_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RestoreSourceName { get; set; }

    /// <summary>
    /// The restore_source_table_arn attribute.
    /// </summary>
    [TerraformProperty("restore_source_table_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RestoreSourceTableArn { get; set; }

    /// <summary>
    /// The restore_to_latest_time attribute.
    /// </summary>
    [TerraformProperty("restore_to_latest_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RestoreToLatestTime { get; set; }

    /// <summary>
    /// The stream_enabled attribute.
    /// </summary>
    [TerraformProperty("stream_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StreamEnabled { get; set; }

    /// <summary>
    /// The stream_view_type attribute.
    /// </summary>
    [TerraformProperty("stream_view_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StreamViewType { get; set; }

    /// <summary>
    /// The table_class attribute.
    /// </summary>
    [TerraformProperty("table_class")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TableClass { get; set; }

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
    /// The write_capacity attribute.
    /// </summary>
    [TerraformProperty("write_capacity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> WriteCapacity { get; set; }

    /// <summary>
    /// Block for attribute.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("attribute")]
    public partial TerraformSet<TerraformBlock<AwsDynamodbTableAttributeBlock>>? Attribute { get; set; }

    /// <summary>
    /// Block for global_secondary_index.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("global_secondary_index")]
    public partial TerraformSet<TerraformBlock<AwsDynamodbTableGlobalSecondaryIndexBlock>>? GlobalSecondaryIndex { get; set; }

    /// <summary>
    /// Block for import_table.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImportTable block(s) allowed")]
    [TerraformProperty("import_table")]
    public partial TerraformList<TerraformBlock<AwsDynamodbTableImportTableBlock>>? ImportTable { get; set; }

    /// <summary>
    /// Block for local_secondary_index.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("local_secondary_index")]
    public partial TerraformSet<TerraformBlock<AwsDynamodbTableLocalSecondaryIndexBlock>>? LocalSecondaryIndex { get; set; }

    /// <summary>
    /// Block for on_demand_throughput.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDemandThroughput block(s) allowed")]
    [TerraformProperty("on_demand_throughput")]
    public partial TerraformList<TerraformBlock<AwsDynamodbTableOnDemandThroughputBlock>>? OnDemandThroughput { get; set; }

    /// <summary>
    /// Block for point_in_time_recovery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRecovery block(s) allowed")]
    [TerraformProperty("point_in_time_recovery")]
    public partial TerraformList<TerraformBlock<AwsDynamodbTablePointInTimeRecoveryBlock>>? PointInTimeRecovery { get; set; }

    /// <summary>
    /// Block for replica.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("replica")]
    public partial TerraformSet<TerraformBlock<AwsDynamodbTableReplicaBlock>>? Replica { get; set; }

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    [TerraformProperty("server_side_encryption")]
    public partial TerraformList<TerraformBlock<AwsDynamodbTableServerSideEncryptionBlock>>? ServerSideEncryption { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsDynamodbTableTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for ttl.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ttl block(s) allowed")]
    [TerraformProperty("ttl")]
    public partial TerraformList<TerraformBlock<AwsDynamodbTableTtlBlock>>? Ttl { get; set; }

    /// <summary>
    /// Block for warm_throughput.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WarmThroughput block(s) allowed")]
    [TerraformProperty("warm_throughput")]
    public partial TerraformList<TerraformBlock<AwsDynamodbTableWarmThroughputBlock>>? WarmThroughput { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [TerraformProperty("stream_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StreamArn { get; }

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    [TerraformProperty("stream_label")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StreamLabel { get; }

}
