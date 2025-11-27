using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDmsS3Endpoint.
/// Nesting mode: single
/// </summary>
public class AwsDmsS3EndpointTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_dms_s3_endpoint Terraform resource.
/// Manages a aws_dms_s3_endpoint resource.
/// </summary>
public partial class AwsDmsS3Endpoint(string name) : TerraformResource("aws_dms_s3_endpoint", name)
{
    /// <summary>
    /// The add_column_name attribute.
    /// </summary>
    public TerraformValue<bool>? AddColumnName
    {
        get => new TerraformReference<bool>(this, "add_column_name");
        set => SetArgument("add_column_name", value);
    }

    /// <summary>
    /// The add_trailing_padding_character attribute.
    /// </summary>
    public TerraformValue<bool>? AddTrailingPaddingCharacter
    {
        get => new TerraformReference<bool>(this, "add_trailing_padding_character");
        set => SetArgument("add_trailing_padding_character", value);
    }

    /// <summary>
    /// The bucket_folder attribute.
    /// </summary>
    public TerraformValue<string>? BucketFolder
    {
        get => new TerraformReference<string>(this, "bucket_folder");
        set => SetArgument("bucket_folder", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => new TerraformReference<string>(this, "bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The canned_acl_for_objects attribute.
    /// </summary>
    public TerraformValue<string>? CannedAclForObjects
    {
        get => new TerraformReference<string>(this, "canned_acl_for_objects");
        set => SetArgument("canned_acl_for_objects", value);
    }

    /// <summary>
    /// The cdc_inserts_and_updates attribute.
    /// </summary>
    public TerraformValue<bool>? CdcInsertsAndUpdates
    {
        get => new TerraformReference<bool>(this, "cdc_inserts_and_updates");
        set => SetArgument("cdc_inserts_and_updates", value);
    }

    /// <summary>
    /// The cdc_inserts_only attribute.
    /// </summary>
    public TerraformValue<bool>? CdcInsertsOnly
    {
        get => new TerraformReference<bool>(this, "cdc_inserts_only");
        set => SetArgument("cdc_inserts_only", value);
    }

    /// <summary>
    /// The cdc_max_batch_interval attribute.
    /// </summary>
    public TerraformValue<double>? CdcMaxBatchInterval
    {
        get => new TerraformReference<double>(this, "cdc_max_batch_interval");
        set => SetArgument("cdc_max_batch_interval", value);
    }

    /// <summary>
    /// The cdc_min_file_size attribute.
    /// </summary>
    public TerraformValue<double>? CdcMinFileSize
    {
        get => new TerraformReference<double>(this, "cdc_min_file_size");
        set => SetArgument("cdc_min_file_size", value);
    }

    /// <summary>
    /// The cdc_path attribute.
    /// </summary>
    public TerraformValue<string>? CdcPath
    {
        get => new TerraformReference<string>(this, "cdc_path");
        set => SetArgument("cdc_path", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> CertificateArn
    {
        get => new TerraformReference<string>(this, "certificate_arn");
        set => SetArgument("certificate_arn", value);
    }

    /// <summary>
    /// The compression_type attribute.
    /// </summary>
    public TerraformValue<string>? CompressionType
    {
        get => new TerraformReference<string>(this, "compression_type");
        set => SetArgument("compression_type", value);
    }

    /// <summary>
    /// The csv_delimiter attribute.
    /// </summary>
    public TerraformValue<string>? CsvDelimiter
    {
        get => new TerraformReference<string>(this, "csv_delimiter");
        set => SetArgument("csv_delimiter", value);
    }

    /// <summary>
    /// The csv_no_sup_value attribute.
    /// </summary>
    public TerraformValue<string>? CsvNoSupValue
    {
        get => new TerraformReference<string>(this, "csv_no_sup_value");
        set => SetArgument("csv_no_sup_value", value);
    }

    /// <summary>
    /// The csv_null_value attribute.
    /// </summary>
    public TerraformValue<string>? CsvNullValue
    {
        get => new TerraformReference<string>(this, "csv_null_value");
        set => SetArgument("csv_null_value", value);
    }

    /// <summary>
    /// The csv_row_delimiter attribute.
    /// </summary>
    public TerraformValue<string>? CsvRowDelimiter
    {
        get => new TerraformReference<string>(this, "csv_row_delimiter");
        set => SetArgument("csv_row_delimiter", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformValue<string>? DataFormat
    {
        get => new TerraformReference<string>(this, "data_format");
        set => SetArgument("data_format", value);
    }

    /// <summary>
    /// The data_page_size attribute.
    /// </summary>
    public TerraformValue<double>? DataPageSize
    {
        get => new TerraformReference<double>(this, "data_page_size");
        set => SetArgument("data_page_size", value);
    }

    /// <summary>
    /// The date_partition_delimiter attribute.
    /// </summary>
    public TerraformValue<string>? DatePartitionDelimiter
    {
        get => new TerraformReference<string>(this, "date_partition_delimiter");
        set => SetArgument("date_partition_delimiter", value);
    }

    /// <summary>
    /// The date_partition_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DatePartitionEnabled
    {
        get => new TerraformReference<bool>(this, "date_partition_enabled");
        set => SetArgument("date_partition_enabled", value);
    }

    /// <summary>
    /// The date_partition_sequence attribute.
    /// </summary>
    public TerraformValue<string>? DatePartitionSequence
    {
        get => new TerraformReference<string>(this, "date_partition_sequence");
        set => SetArgument("date_partition_sequence", value);
    }

    /// <summary>
    /// The date_partition_timezone attribute.
    /// </summary>
    public TerraformValue<string>? DatePartitionTimezone
    {
        get => new TerraformReference<string>(this, "date_partition_timezone");
        set => SetArgument("date_partition_timezone", value);
    }

    /// <summary>
    /// The detach_target_on_lob_lookup_failure_parquet attribute.
    /// </summary>
    public TerraformValue<bool>? DetachTargetOnLobLookupFailureParquet
    {
        get => new TerraformReference<bool>(this, "detach_target_on_lob_lookup_failure_parquet");
        set => SetArgument("detach_target_on_lob_lookup_failure_parquet", value);
    }

    /// <summary>
    /// The dict_page_size_limit attribute.
    /// </summary>
    public TerraformValue<double>? DictPageSizeLimit
    {
        get => new TerraformReference<double>(this, "dict_page_size_limit");
        set => SetArgument("dict_page_size_limit", value);
    }

    /// <summary>
    /// The enable_statistics attribute.
    /// </summary>
    public TerraformValue<bool>? EnableStatistics
    {
        get => new TerraformReference<bool>(this, "enable_statistics");
        set => SetArgument("enable_statistics", value);
    }

    /// <summary>
    /// The encoding_type attribute.
    /// </summary>
    public TerraformValue<string>? EncodingType
    {
        get => new TerraformReference<string>(this, "encoding_type");
        set => SetArgument("encoding_type", value);
    }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionMode
    {
        get => new TerraformReference<string>(this, "encryption_mode");
        set => SetArgument("encryption_mode", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointId is required")]
    public required TerraformValue<string> EndpointId
    {
        get => new TerraformReference<string>(this, "endpoint_id");
        set => SetArgument("endpoint_id", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    public required TerraformValue<string> EndpointType
    {
        get => new TerraformReference<string>(this, "endpoint_type");
        set => SetArgument("endpoint_type", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformValue<string>? ExpectedBucketOwner
    {
        get => new TerraformReference<string>(this, "expected_bucket_owner");
        set => SetArgument("expected_bucket_owner", value);
    }

    /// <summary>
    /// The external_table_definition attribute.
    /// </summary>
    public TerraformValue<string>? ExternalTableDefinition
    {
        get => new TerraformReference<string>(this, "external_table_definition");
        set => SetArgument("external_table_definition", value);
    }

    /// <summary>
    /// The glue_catalog_generation attribute.
    /// </summary>
    public TerraformValue<bool>? GlueCatalogGeneration
    {
        get => new TerraformReference<bool>(this, "glue_catalog_generation");
        set => SetArgument("glue_catalog_generation", value);
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
    /// The ignore_header_rows attribute.
    /// </summary>
    public TerraformValue<double>? IgnoreHeaderRows
    {
        get => new TerraformReference<double>(this, "ignore_header_rows");
        set => SetArgument("ignore_header_rows", value);
    }

    /// <summary>
    /// The include_op_for_full_load attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeOpForFullLoad
    {
        get => new TerraformReference<bool>(this, "include_op_for_full_load");
        set => SetArgument("include_op_for_full_load", value);
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
    /// The max_file_size attribute.
    /// </summary>
    public TerraformValue<double>? MaxFileSize
    {
        get => new TerraformReference<double>(this, "max_file_size");
        set => SetArgument("max_file_size", value);
    }

    /// <summary>
    /// The parquet_timestamp_in_millisecond attribute.
    /// </summary>
    public TerraformValue<bool>? ParquetTimestampInMillisecond
    {
        get => new TerraformReference<bool>(this, "parquet_timestamp_in_millisecond");
        set => SetArgument("parquet_timestamp_in_millisecond", value);
    }

    /// <summary>
    /// The parquet_version attribute.
    /// </summary>
    public TerraformValue<string>? ParquetVersion
    {
        get => new TerraformReference<string>(this, "parquet_version");
        set => SetArgument("parquet_version", value);
    }

    /// <summary>
    /// The preserve_transactions attribute.
    /// </summary>
    public TerraformValue<bool>? PreserveTransactions
    {
        get => new TerraformReference<bool>(this, "preserve_transactions");
        set => SetArgument("preserve_transactions", value);
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
    /// The rfc_4180 attribute.
    /// </summary>
    public TerraformValue<bool>? Rfc4180
    {
        get => new TerraformReference<bool>(this, "rfc_4180");
        set => SetArgument("rfc_4180", value);
    }

    /// <summary>
    /// The row_group_length attribute.
    /// </summary>
    public TerraformValue<double>? RowGroupLength
    {
        get => new TerraformReference<double>(this, "row_group_length");
        set => SetArgument("row_group_length", value);
    }

    /// <summary>
    /// The server_side_encryption_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? ServerSideEncryptionKmsKeyId
    {
        get => new TerraformReference<string>(this, "server_side_encryption_kms_key_id");
        set => SetArgument("server_side_encryption_kms_key_id", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccessRoleArn is required")]
    public required TerraformValue<string> ServiceAccessRoleArn
    {
        get => new TerraformReference<string>(this, "service_access_role_arn");
        set => SetArgument("service_access_role_arn", value);
    }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    public TerraformValue<string> SslMode
    {
        get => new TerraformReference<string>(this, "ssl_mode");
        set => SetArgument("ssl_mode", value);
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
    /// The timestamp_column_name attribute.
    /// </summary>
    public TerraformValue<string>? TimestampColumnName
    {
        get => new TerraformReference<string>(this, "timestamp_column_name");
        set => SetArgument("timestamp_column_name", value);
    }

    /// <summary>
    /// The use_csv_no_sup_value attribute.
    /// </summary>
    public TerraformValue<bool>? UseCsvNoSupValue
    {
        get => new TerraformReference<bool>(this, "use_csv_no_sup_value");
        set => SetArgument("use_csv_no_sup_value", value);
    }

    /// <summary>
    /// The use_task_start_time_for_full_load_timestamp attribute.
    /// </summary>
    public TerraformValue<bool>? UseTaskStartTimeForFullLoadTimestamp
    {
        get => new TerraformReference<bool>(this, "use_task_start_time_for_full_load_timestamp");
        set => SetArgument("use_task_start_time_for_full_load_timestamp", value);
    }

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    public TerraformValue<string> EndpointArn
    {
        get => new TerraformReference<string>(this, "endpoint_arn");
    }

    /// <summary>
    /// The engine_display_name attribute.
    /// </summary>
    public TerraformValue<string> EngineDisplayName
    {
        get => new TerraformReference<string>(this, "engine_display_name");
    }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    public TerraformValue<string> ExternalId
    {
        get => new TerraformReference<string>(this, "external_id");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDmsS3EndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDmsS3EndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
