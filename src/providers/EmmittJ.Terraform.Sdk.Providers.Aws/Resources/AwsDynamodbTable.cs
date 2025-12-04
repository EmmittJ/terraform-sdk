using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attribute in AwsDynamodbTable.
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attribute";

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
/// Block type for global_secondary_index in AwsDynamodbTable.
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableGlobalSecondaryIndexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "global_secondary_index";

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKey is required")]
    public required TerraformValue<string> HashKey
    {
        get => GetArgument<TerraformValue<string>>("hash_key");
        set => SetArgument("hash_key", value);
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
    /// The non_key_attributes attribute.
    /// </summary>
    public TerraformSet<string>? NonKeyAttributes
    {
        get => GetArgument<TerraformSet<string>>("non_key_attributes");
        set => SetArgument("non_key_attributes", value);
    }

    /// <summary>
    /// The projection_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectionType is required")]
    public required TerraformValue<string> ProjectionType
    {
        get => GetArgument<TerraformValue<string>>("projection_type");
        set => SetArgument("projection_type", value);
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    public TerraformValue<string>? RangeKey
    {
        get => GetArgument<TerraformValue<string>>("range_key");
        set => SetArgument("range_key", value);
    }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    public TerraformValue<double>? ReadCapacity
    {
        get => GetArgument<TerraformValue<double>>("read_capacity");
        set => SetArgument("read_capacity", value);
    }

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    public TerraformValue<double>? WriteCapacity
    {
        get => GetArgument<TerraformValue<double>>("write_capacity");
        set => SetArgument("write_capacity", value);
    }

    /// <summary>
    /// OnDemandThroughput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDemandThroughput block(s) allowed")]
    public TerraformList<AwsDynamodbTableGlobalSecondaryIndexBlockOnDemandThroughputBlock>? OnDemandThroughput
    {
        get => GetArgument<TerraformList<AwsDynamodbTableGlobalSecondaryIndexBlockOnDemandThroughputBlock>>("on_demand_throughput");
        set => SetArgument("on_demand_throughput", value);
    }

    /// <summary>
    /// WarmThroughput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WarmThroughput block(s) allowed")]
    public TerraformList<AwsDynamodbTableGlobalSecondaryIndexBlockWarmThroughputBlock>? WarmThroughput
    {
        get => GetArgument<TerraformList<AwsDynamodbTableGlobalSecondaryIndexBlockWarmThroughputBlock>>("warm_throughput");
        set => SetArgument("warm_throughput", value);
    }

}

/// <summary>
/// Block type for on_demand_throughput in AwsDynamodbTableGlobalSecondaryIndexBlock.
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableGlobalSecondaryIndexBlockOnDemandThroughputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_demand_throughput";

    /// <summary>
    /// The max_read_request_units attribute.
    /// </summary>
    public TerraformValue<double>? MaxReadRequestUnits
    {
        get => GetArgument<TerraformValue<double>>("max_read_request_units");
        set => SetArgument("max_read_request_units", value);
    }

    /// <summary>
    /// The max_write_request_units attribute.
    /// </summary>
    public TerraformValue<double>? MaxWriteRequestUnits
    {
        get => GetArgument<TerraformValue<double>>("max_write_request_units");
        set => SetArgument("max_write_request_units", value);
    }

}

/// <summary>
/// Block type for warm_throughput in AwsDynamodbTableGlobalSecondaryIndexBlock.
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableGlobalSecondaryIndexBlockWarmThroughputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "warm_throughput";

    /// <summary>
    /// The read_units_per_second attribute.
    /// </summary>
    public TerraformValue<double>? ReadUnitsPerSecond
    {
        get => GetArgument<TerraformValue<double>>("read_units_per_second");
        set => SetArgument("read_units_per_second", value);
    }

    /// <summary>
    /// The write_units_per_second attribute.
    /// </summary>
    public TerraformValue<double>? WriteUnitsPerSecond
    {
        get => GetArgument<TerraformValue<double>>("write_units_per_second");
        set => SetArgument("write_units_per_second", value);
    }

}


/// <summary>
/// Block type for import_table in AwsDynamodbTable.
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableImportTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "import_table";

    /// <summary>
    /// The input_compression_type attribute.
    /// </summary>
    public TerraformValue<string>? InputCompressionType
    {
        get => GetArgument<TerraformValue<string>>("input_compression_type");
        set => SetArgument("input_compression_type", value);
    }

    /// <summary>
    /// The input_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputFormat is required")]
    public required TerraformValue<string> InputFormat
    {
        get => GetArgument<TerraformValue<string>>("input_format");
        set => SetArgument("input_format", value);
    }

    /// <summary>
    /// InputFormatOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputFormatOptions block(s) allowed")]
    public TerraformList<AwsDynamodbTableImportTableBlockInputFormatOptionsBlock>? InputFormatOptions
    {
        get => GetArgument<TerraformList<AwsDynamodbTableImportTableBlockInputFormatOptionsBlock>>("input_format_options");
        set => SetArgument("input_format_options", value);
    }

    /// <summary>
    /// S3BucketSource block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketSource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3BucketSource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3BucketSource block(s) allowed")]
    public required TerraformList<AwsDynamodbTableImportTableBlockS3BucketSourceBlock> S3BucketSource
    {
        get => GetRequiredArgument<TerraformList<AwsDynamodbTableImportTableBlockS3BucketSourceBlock>>("s3_bucket_source");
        set => SetArgument("s3_bucket_source", value);
    }

}

/// <summary>
/// Block type for input_format_options in AwsDynamodbTableImportTableBlock.
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableImportTableBlockInputFormatOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_format_options";

    /// <summary>
    /// Csv block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Csv block(s) allowed")]
    public TerraformList<AwsDynamodbTableImportTableBlockInputFormatOptionsBlockCsvBlock>? Csv
    {
        get => GetArgument<TerraformList<AwsDynamodbTableImportTableBlockInputFormatOptionsBlockCsvBlock>>("csv");
        set => SetArgument("csv", value);
    }

}

/// <summary>
/// Block type for csv in AwsDynamodbTableImportTableBlockInputFormatOptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableImportTableBlockInputFormatOptionsBlockCsvBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "csv";

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    public TerraformValue<string>? Delimiter
    {
        get => GetArgument<TerraformValue<string>>("delimiter");
        set => SetArgument("delimiter", value);
    }

    /// <summary>
    /// The header_list attribute.
    /// </summary>
    public TerraformSet<string>? HeaderList
    {
        get => GetArgument<TerraformSet<string>>("header_list");
        set => SetArgument("header_list", value);
    }

}

/// <summary>
/// Block type for s3_bucket_source in AwsDynamodbTableImportTableBlock.
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableImportTableBlockS3BucketSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_bucket_source";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The bucket_owner attribute.
    /// </summary>
    public TerraformValue<string>? BucketOwner
    {
        get => GetArgument<TerraformValue<string>>("bucket_owner");
        set => SetArgument("bucket_owner", value);
    }

    /// <summary>
    /// The key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? KeyPrefix
    {
        get => GetArgument<TerraformValue<string>>("key_prefix");
        set => SetArgument("key_prefix", value);
    }

}


/// <summary>
/// Block type for local_secondary_index in AwsDynamodbTable.
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableLocalSecondaryIndexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local_secondary_index";

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
    /// The non_key_attributes attribute.
    /// </summary>
    public TerraformList<string>? NonKeyAttributes
    {
        get => GetArgument<TerraformList<string>>("non_key_attributes");
        set => SetArgument("non_key_attributes", value);
    }

    /// <summary>
    /// The projection_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectionType is required")]
    public required TerraformValue<string> ProjectionType
    {
        get => GetArgument<TerraformValue<string>>("projection_type");
        set => SetArgument("projection_type", value);
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeKey is required")]
    public required TerraformValue<string> RangeKey
    {
        get => GetArgument<TerraformValue<string>>("range_key");
        set => SetArgument("range_key", value);
    }

}


/// <summary>
/// Block type for on_demand_throughput in AwsDynamodbTable.
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableOnDemandThroughputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_demand_throughput";

    /// <summary>
    /// The max_read_request_units attribute.
    /// </summary>
    public TerraformValue<double>? MaxReadRequestUnits
    {
        get => GetArgument<TerraformValue<double>>("max_read_request_units");
        set => SetArgument("max_read_request_units", value);
    }

    /// <summary>
    /// The max_write_request_units attribute.
    /// </summary>
    public TerraformValue<double>? MaxWriteRequestUnits
    {
        get => GetArgument<TerraformValue<double>>("max_write_request_units");
        set => SetArgument("max_write_request_units", value);
    }

}


/// <summary>
/// Block type for point_in_time_recovery in AwsDynamodbTable.
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTablePointInTimeRecoveryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "point_in_time_recovery";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The recovery_period_in_days attribute.
    /// </summary>
    public TerraformValue<double>? RecoveryPeriodInDays
    {
        get => GetArgument<TerraformValue<double>>("recovery_period_in_days");
        set => SetArgument("recovery_period_in_days", value);
    }

}


/// <summary>
/// Block type for replica in AwsDynamodbTable.
/// Nesting mode: set
/// </summary>
public class AwsDynamodbTableReplicaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replica";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The consistency_mode attribute.
    /// </summary>
    public TerraformValue<string>? ConsistencyMode
    {
        get => GetArgument<TerraformValue<string>>("consistency_mode");
        set => SetArgument("consistency_mode", value);
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DeletionProtectionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection_enabled");
        set => SetArgument("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The point_in_time_recovery attribute.
    /// </summary>
    public TerraformValue<bool>? PointInTimeRecovery
    {
        get => GetArgument<TerraformValue<bool>>("point_in_time_recovery");
        set => SetArgument("point_in_time_recovery", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformValue<bool>? PropagateTags
    {
        get => GetArgument<TerraformValue<bool>>("propagate_tags");
        set => SetArgument("propagate_tags", value);
    }

    /// <summary>
    /// The region_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    public required TerraformValue<string> RegionName
    {
        get => GetArgument<TerraformValue<string>>("region_name");
        set => SetArgument("region_name", value);
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformValue<string> StreamArn
        => AsReference("stream_arn");

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    public TerraformValue<string> StreamLabel
        => AsReference("stream_label");

}


/// <summary>
/// Block type for server_side_encryption in AwsDynamodbTable.
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableServerSideEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_side_encryption";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDynamodbTable.
/// Nesting mode: single
/// </summary>
public class AwsDynamodbTableTimeoutsBlock : TerraformBlock
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
/// Block type for ttl in AwsDynamodbTable.
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableTtlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ttl";

    /// <summary>
    /// The attribute_name attribute.
    /// </summary>
    public TerraformValue<string>? AttributeName
    {
        get => GetArgument<TerraformValue<string>>("attribute_name");
        set => SetArgument("attribute_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for warm_throughput in AwsDynamodbTable.
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableWarmThroughputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "warm_throughput";

    /// <summary>
    /// The read_units_per_second attribute.
    /// </summary>
    public TerraformValue<double>? ReadUnitsPerSecond
    {
        get => GetArgument<TerraformValue<double>>("read_units_per_second");
        set => SetArgument("read_units_per_second", value);
    }

    /// <summary>
    /// The write_units_per_second attribute.
    /// </summary>
    public TerraformValue<double>? WriteUnitsPerSecond
    {
        get => GetArgument<TerraformValue<double>>("write_units_per_second");
        set => SetArgument("write_units_per_second", value);
    }

}


/// <summary>
/// Represents a aws_dynamodb_table Terraform resource.
/// Manages a aws_dynamodb_table resource.
/// </summary>
public partial class AwsDynamodbTable(string name) : TerraformResource("aws_dynamodb_table", name)
{
    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    public TerraformValue<string>? BillingMode
    {
        get => GetArgument<TerraformValue<string>>("billing_mode");
        set => SetArgument("billing_mode", value);
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DeletionProtectionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection_enabled");
        set => SetArgument("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    public TerraformValue<string>? HashKey
    {
        get => GetArgument<TerraformValue<string>>("hash_key");
        set => SetArgument("hash_key", value);
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
    /// The range_key attribute.
    /// </summary>
    public TerraformValue<string>? RangeKey
    {
        get => GetArgument<TerraformValue<string>>("range_key");
        set => SetArgument("range_key", value);
    }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    public TerraformValue<double>? ReadCapacity
    {
        get => GetArgument<TerraformValue<double>>("read_capacity");
        set => SetArgument("read_capacity", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The restore_date_time attribute.
    /// </summary>
    public TerraformValue<string>? RestoreDateTime
    {
        get => GetArgument<TerraformValue<string>>("restore_date_time");
        set => SetArgument("restore_date_time", value);
    }

    /// <summary>
    /// The restore_source_name attribute.
    /// </summary>
    public TerraformValue<string>? RestoreSourceName
    {
        get => GetArgument<TerraformValue<string>>("restore_source_name");
        set => SetArgument("restore_source_name", value);
    }

    /// <summary>
    /// The restore_source_table_arn attribute.
    /// </summary>
    public TerraformValue<string>? RestoreSourceTableArn
    {
        get => GetArgument<TerraformValue<string>>("restore_source_table_arn");
        set => SetArgument("restore_source_table_arn", value);
    }

    /// <summary>
    /// The restore_to_latest_time attribute.
    /// </summary>
    public TerraformValue<bool>? RestoreToLatestTime
    {
        get => GetArgument<TerraformValue<bool>>("restore_to_latest_time");
        set => SetArgument("restore_to_latest_time", value);
    }

    /// <summary>
    /// The stream_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StreamEnabled
    {
        get => GetArgument<TerraformValue<bool>>("stream_enabled");
        set => SetArgument("stream_enabled", value);
    }

    /// <summary>
    /// The stream_view_type attribute.
    /// </summary>
    public TerraformValue<string>? StreamViewType
    {
        get => GetArgument<TerraformValue<string>>("stream_view_type");
        set => SetArgument("stream_view_type", value);
    }

    /// <summary>
    /// The table_class attribute.
    /// </summary>
    public TerraformValue<string>? TableClass
    {
        get => GetArgument<TerraformValue<string>>("table_class");
        set => SetArgument("table_class", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    public TerraformValue<double>? WriteCapacity
    {
        get => GetArgument<TerraformValue<double>>("write_capacity");
        set => SetArgument("write_capacity", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformValue<string> StreamArn
        => AsReference("stream_arn");

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    public TerraformValue<string> StreamLabel
        => AsReference("stream_label");

    /// <summary>
    /// Attribute block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDynamodbTableAttributeBlock>? Attribute
    {
        get => GetArgument<TerraformSet<AwsDynamodbTableAttributeBlock>>("attribute");
        set => SetArgument("attribute", value);
    }

    /// <summary>
    /// GlobalSecondaryIndex block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDynamodbTableGlobalSecondaryIndexBlock>? GlobalSecondaryIndex
    {
        get => GetArgument<TerraformSet<AwsDynamodbTableGlobalSecondaryIndexBlock>>("global_secondary_index");
        set => SetArgument("global_secondary_index", value);
    }

    /// <summary>
    /// ImportTable block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImportTable block(s) allowed")]
    public TerraformList<AwsDynamodbTableImportTableBlock>? ImportTable
    {
        get => GetArgument<TerraformList<AwsDynamodbTableImportTableBlock>>("import_table");
        set => SetArgument("import_table", value);
    }

    /// <summary>
    /// LocalSecondaryIndex block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDynamodbTableLocalSecondaryIndexBlock>? LocalSecondaryIndex
    {
        get => GetArgument<TerraformSet<AwsDynamodbTableLocalSecondaryIndexBlock>>("local_secondary_index");
        set => SetArgument("local_secondary_index", value);
    }

    /// <summary>
    /// OnDemandThroughput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnDemandThroughput block(s) allowed")]
    public TerraformList<AwsDynamodbTableOnDemandThroughputBlock>? OnDemandThroughput
    {
        get => GetArgument<TerraformList<AwsDynamodbTableOnDemandThroughputBlock>>("on_demand_throughput");
        set => SetArgument("on_demand_throughput", value);
    }

    /// <summary>
    /// PointInTimeRecovery block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PointInTimeRecovery block(s) allowed")]
    public TerraformList<AwsDynamodbTablePointInTimeRecoveryBlock>? PointInTimeRecovery
    {
        get => GetArgument<TerraformList<AwsDynamodbTablePointInTimeRecoveryBlock>>("point_in_time_recovery");
        set => SetArgument("point_in_time_recovery", value);
    }

    /// <summary>
    /// Replica block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDynamodbTableReplicaBlock>? Replica
    {
        get => GetArgument<TerraformSet<AwsDynamodbTableReplicaBlock>>("replica");
        set => SetArgument("replica", value);
    }

    /// <summary>
    /// ServerSideEncryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    public TerraformList<AwsDynamodbTableServerSideEncryptionBlock>? ServerSideEncryption
    {
        get => GetArgument<TerraformList<AwsDynamodbTableServerSideEncryptionBlock>>("server_side_encryption");
        set => SetArgument("server_side_encryption", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDynamodbTableTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDynamodbTableTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Ttl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ttl block(s) allowed")]
    public TerraformList<AwsDynamodbTableTtlBlock>? Ttl
    {
        get => GetArgument<TerraformList<AwsDynamodbTableTtlBlock>>("ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// WarmThroughput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WarmThroughput block(s) allowed")]
    public TerraformList<AwsDynamodbTableWarmThroughputBlock>? WarmThroughput
    {
        get => GetArgument<TerraformList<AwsDynamodbTableWarmThroughputBlock>>("warm_throughput");
        set => SetArgument("warm_throughput", value);
    }

}
