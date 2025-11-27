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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
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
        get => new TerraformReference<string>(this, "hash_key");
        set => SetArgument("hash_key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The non_key_attributes attribute.
    /// </summary>
    public TerraformSet<string>? NonKeyAttributes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "non_key_attributes").ResolveNodes(ctx));
        set => SetArgument("non_key_attributes", value);
    }

    /// <summary>
    /// The projection_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectionType is required")]
    public required TerraformValue<string> ProjectionType
    {
        get => new TerraformReference<string>(this, "projection_type");
        set => SetArgument("projection_type", value);
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    public TerraformValue<string>? RangeKey
    {
        get => new TerraformReference<string>(this, "range_key");
        set => SetArgument("range_key", value);
    }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    public TerraformValue<double> ReadCapacity
    {
        get => new TerraformReference<double>(this, "read_capacity");
        set => SetArgument("read_capacity", value);
    }

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    public TerraformValue<double> WriteCapacity
    {
        get => new TerraformReference<double>(this, "write_capacity");
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
    public TerraformValue<double> MaxReadRequestUnits
    {
        get => new TerraformReference<double>(this, "max_read_request_units");
        set => SetArgument("max_read_request_units", value);
    }

    /// <summary>
    /// The max_write_request_units attribute.
    /// </summary>
    public TerraformValue<double> MaxWriteRequestUnits
    {
        get => new TerraformReference<double>(this, "max_write_request_units");
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
    public TerraformValue<double> ReadUnitsPerSecond
    {
        get => new TerraformReference<double>(this, "read_units_per_second");
        set => SetArgument("read_units_per_second", value);
    }

    /// <summary>
    /// The write_units_per_second attribute.
    /// </summary>
    public TerraformValue<double> WriteUnitsPerSecond
    {
        get => new TerraformReference<double>(this, "write_units_per_second");
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
        get => new TerraformReference<string>(this, "input_compression_type");
        set => SetArgument("input_compression_type", value);
    }

    /// <summary>
    /// The input_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputFormat is required")]
    public required TerraformValue<string> InputFormat
    {
        get => new TerraformReference<string>(this, "input_format");
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
        get => new TerraformReference<string>(this, "delimiter");
        set => SetArgument("delimiter", value);
    }

    /// <summary>
    /// The header_list attribute.
    /// </summary>
    public TerraformSet<string>? HeaderList
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "header_list").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The bucket_owner attribute.
    /// </summary>
    public TerraformValue<string>? BucketOwner
    {
        get => new TerraformReference<string>(this, "bucket_owner");
        set => SetArgument("bucket_owner", value);
    }

    /// <summary>
    /// The key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? KeyPrefix
    {
        get => new TerraformReference<string>(this, "key_prefix");
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The non_key_attributes attribute.
    /// </summary>
    public TerraformList<string>? NonKeyAttributes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "non_key_attributes").ResolveNodes(ctx));
        set => SetArgument("non_key_attributes", value);
    }

    /// <summary>
    /// The projection_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectionType is required")]
    public required TerraformValue<string> ProjectionType
    {
        get => new TerraformReference<string>(this, "projection_type");
        set => SetArgument("projection_type", value);
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeKey is required")]
    public required TerraformValue<string> RangeKey
    {
        get => new TerraformReference<string>(this, "range_key");
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
    public TerraformValue<double> MaxReadRequestUnits
    {
        get => new TerraformReference<double>(this, "max_read_request_units");
        set => SetArgument("max_read_request_units", value);
    }

    /// <summary>
    /// The max_write_request_units attribute.
    /// </summary>
    public TerraformValue<double> MaxWriteRequestUnits
    {
        get => new TerraformReference<double>(this, "max_write_request_units");
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
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The recovery_period_in_days attribute.
    /// </summary>
    public TerraformValue<double> RecoveryPeriodInDays
    {
        get => new TerraformReference<double>(this, "recovery_period_in_days");
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
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The consistency_mode attribute.
    /// </summary>
    public TerraformValue<string>? ConsistencyMode
    {
        get => new TerraformReference<string>(this, "consistency_mode");
        set => SetArgument("consistency_mode", value);
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DeletionProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "deletion_protection_enabled");
        set => SetArgument("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The point_in_time_recovery attribute.
    /// </summary>
    public TerraformValue<bool>? PointInTimeRecovery
    {
        get => new TerraformReference<bool>(this, "point_in_time_recovery");
        set => SetArgument("point_in_time_recovery", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformValue<bool>? PropagateTags
    {
        get => new TerraformReference<bool>(this, "propagate_tags");
        set => SetArgument("propagate_tags", value);
    }

    /// <summary>
    /// The region_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    public required TerraformValue<string> RegionName
    {
        get => new TerraformReference<string>(this, "region_name");
        set => SetArgument("region_name", value);
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformValue<string> StreamArn
    {
        get => new TerraformReference<string>(this, "stream_arn");
    }

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    public TerraformValue<string> StreamLabel
    {
        get => new TerraformReference<string>(this, "stream_label");
    }

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
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "attribute_name");
        set => SetArgument("attribute_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
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
    public TerraformValue<double> ReadUnitsPerSecond
    {
        get => new TerraformReference<double>(this, "read_units_per_second");
        set => SetArgument("read_units_per_second", value);
    }

    /// <summary>
    /// The write_units_per_second attribute.
    /// </summary>
    public TerraformValue<double> WriteUnitsPerSecond
    {
        get => new TerraformReference<double>(this, "write_units_per_second");
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
        get => new TerraformReference<string>(this, "billing_mode");
        set => SetArgument("billing_mode", value);
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DeletionProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "deletion_protection_enabled");
        set => SetArgument("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    public TerraformValue<string> HashKey
    {
        get => new TerraformReference<string>(this, "hash_key");
        set => SetArgument("hash_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    public TerraformValue<string>? RangeKey
    {
        get => new TerraformReference<string>(this, "range_key");
        set => SetArgument("range_key", value);
    }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    public TerraformValue<double> ReadCapacity
    {
        get => new TerraformReference<double>(this, "read_capacity");
        set => SetArgument("read_capacity", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The restore_date_time attribute.
    /// </summary>
    public TerraformValue<string>? RestoreDateTime
    {
        get => new TerraformReference<string>(this, "restore_date_time");
        set => SetArgument("restore_date_time", value);
    }

    /// <summary>
    /// The restore_source_name attribute.
    /// </summary>
    public TerraformValue<string>? RestoreSourceName
    {
        get => new TerraformReference<string>(this, "restore_source_name");
        set => SetArgument("restore_source_name", value);
    }

    /// <summary>
    /// The restore_source_table_arn attribute.
    /// </summary>
    public TerraformValue<string>? RestoreSourceTableArn
    {
        get => new TerraformReference<string>(this, "restore_source_table_arn");
        set => SetArgument("restore_source_table_arn", value);
    }

    /// <summary>
    /// The restore_to_latest_time attribute.
    /// </summary>
    public TerraformValue<bool>? RestoreToLatestTime
    {
        get => new TerraformReference<bool>(this, "restore_to_latest_time");
        set => SetArgument("restore_to_latest_time", value);
    }

    /// <summary>
    /// The stream_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StreamEnabled
    {
        get => new TerraformReference<bool>(this, "stream_enabled");
        set => SetArgument("stream_enabled", value);
    }

    /// <summary>
    /// The stream_view_type attribute.
    /// </summary>
    public TerraformValue<string> StreamViewType
    {
        get => new TerraformReference<string>(this, "stream_view_type");
        set => SetArgument("stream_view_type", value);
    }

    /// <summary>
    /// The table_class attribute.
    /// </summary>
    public TerraformValue<string>? TableClass
    {
        get => new TerraformReference<string>(this, "table_class");
        set => SetArgument("table_class", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    public TerraformValue<double> WriteCapacity
    {
        get => new TerraformReference<double>(this, "write_capacity");
        set => SetArgument("write_capacity", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformValue<string> StreamArn
    {
        get => new TerraformReference<string>(this, "stream_arn");
    }

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    public TerraformValue<string> StreamLabel
    {
        get => new TerraformReference<string>(this, "stream_label");
    }

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
