using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDmsS3EndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_dms_s3_endpoint resource.
/// </summary>
public class AwsDmsS3Endpoint : TerraformResource
{
    public AwsDmsS3Endpoint(string name) : base("aws_dms_s3_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("endpoint_arn");
        this.WithOutput("engine_display_name");
        this.WithOutput("external_id");
        this.WithOutput("status");
    }

    /// <summary>
    /// The add_column_name attribute.
    /// </summary>
    public TerraformProperty<bool>? AddColumnName
    {
        get => GetProperty<TerraformProperty<bool>>("add_column_name");
        set => this.WithProperty("add_column_name", value);
    }

    /// <summary>
    /// The add_trailing_padding_character attribute.
    /// </summary>
    public TerraformProperty<bool>? AddTrailingPaddingCharacter
    {
        get => GetProperty<TerraformProperty<bool>>("add_trailing_padding_character");
        set => this.WithProperty("add_trailing_padding_character", value);
    }

    /// <summary>
    /// The bucket_folder attribute.
    /// </summary>
    public TerraformProperty<string>? BucketFolder
    {
        get => GetProperty<TerraformProperty<string>>("bucket_folder");
        set => this.WithProperty("bucket_folder", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformProperty<string> BucketName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bucket_name");
        set => this.WithProperty("bucket_name", value);
    }

    /// <summary>
    /// The canned_acl_for_objects attribute.
    /// </summary>
    public TerraformProperty<string>? CannedAclForObjects
    {
        get => GetProperty<TerraformProperty<string>>("canned_acl_for_objects");
        set => this.WithProperty("canned_acl_for_objects", value);
    }

    /// <summary>
    /// The cdc_inserts_and_updates attribute.
    /// </summary>
    public TerraformProperty<bool>? CdcInsertsAndUpdates
    {
        get => GetProperty<TerraformProperty<bool>>("cdc_inserts_and_updates");
        set => this.WithProperty("cdc_inserts_and_updates", value);
    }

    /// <summary>
    /// The cdc_inserts_only attribute.
    /// </summary>
    public TerraformProperty<bool>? CdcInsertsOnly
    {
        get => GetProperty<TerraformProperty<bool>>("cdc_inserts_only");
        set => this.WithProperty("cdc_inserts_only", value);
    }

    /// <summary>
    /// The cdc_max_batch_interval attribute.
    /// </summary>
    public TerraformProperty<double>? CdcMaxBatchInterval
    {
        get => GetProperty<TerraformProperty<double>>("cdc_max_batch_interval");
        set => this.WithProperty("cdc_max_batch_interval", value);
    }

    /// <summary>
    /// The cdc_min_file_size attribute.
    /// </summary>
    public TerraformProperty<double>? CdcMinFileSize
    {
        get => GetProperty<TerraformProperty<double>>("cdc_min_file_size");
        set => this.WithProperty("cdc_min_file_size", value);
    }

    /// <summary>
    /// The cdc_path attribute.
    /// </summary>
    public TerraformProperty<string>? CdcPath
    {
        get => GetProperty<TerraformProperty<string>>("cdc_path");
        set => this.WithProperty("cdc_path", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("certificate_arn");
        set => this.WithProperty("certificate_arn", value);
    }

    /// <summary>
    /// The compression_type attribute.
    /// </summary>
    public TerraformProperty<string>? CompressionType
    {
        get => GetProperty<TerraformProperty<string>>("compression_type");
        set => this.WithProperty("compression_type", value);
    }

    /// <summary>
    /// The csv_delimiter attribute.
    /// </summary>
    public TerraformProperty<string>? CsvDelimiter
    {
        get => GetProperty<TerraformProperty<string>>("csv_delimiter");
        set => this.WithProperty("csv_delimiter", value);
    }

    /// <summary>
    /// The csv_no_sup_value attribute.
    /// </summary>
    public TerraformProperty<string>? CsvNoSupValue
    {
        get => GetProperty<TerraformProperty<string>>("csv_no_sup_value");
        set => this.WithProperty("csv_no_sup_value", value);
    }

    /// <summary>
    /// The csv_null_value attribute.
    /// </summary>
    public TerraformProperty<string>? CsvNullValue
    {
        get => GetProperty<TerraformProperty<string>>("csv_null_value");
        set => this.WithProperty("csv_null_value", value);
    }

    /// <summary>
    /// The csv_row_delimiter attribute.
    /// </summary>
    public TerraformProperty<string>? CsvRowDelimiter
    {
        get => GetProperty<TerraformProperty<string>>("csv_row_delimiter");
        set => this.WithProperty("csv_row_delimiter", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformProperty<string>? DataFormat
    {
        get => GetProperty<TerraformProperty<string>>("data_format");
        set => this.WithProperty("data_format", value);
    }

    /// <summary>
    /// The data_page_size attribute.
    /// </summary>
    public TerraformProperty<double>? DataPageSize
    {
        get => GetProperty<TerraformProperty<double>>("data_page_size");
        set => this.WithProperty("data_page_size", value);
    }

    /// <summary>
    /// The date_partition_delimiter attribute.
    /// </summary>
    public TerraformProperty<string>? DatePartitionDelimiter
    {
        get => GetProperty<TerraformProperty<string>>("date_partition_delimiter");
        set => this.WithProperty("date_partition_delimiter", value);
    }

    /// <summary>
    /// The date_partition_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DatePartitionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("date_partition_enabled");
        set => this.WithProperty("date_partition_enabled", value);
    }

    /// <summary>
    /// The date_partition_sequence attribute.
    /// </summary>
    public TerraformProperty<string>? DatePartitionSequence
    {
        get => GetProperty<TerraformProperty<string>>("date_partition_sequence");
        set => this.WithProperty("date_partition_sequence", value);
    }

    /// <summary>
    /// The date_partition_timezone attribute.
    /// </summary>
    public TerraformProperty<string>? DatePartitionTimezone
    {
        get => GetProperty<TerraformProperty<string>>("date_partition_timezone");
        set => this.WithProperty("date_partition_timezone", value);
    }

    /// <summary>
    /// The detach_target_on_lob_lookup_failure_parquet attribute.
    /// </summary>
    public TerraformProperty<bool>? DetachTargetOnLobLookupFailureParquet
    {
        get => GetProperty<TerraformProperty<bool>>("detach_target_on_lob_lookup_failure_parquet");
        set => this.WithProperty("detach_target_on_lob_lookup_failure_parquet", value);
    }

    /// <summary>
    /// The dict_page_size_limit attribute.
    /// </summary>
    public TerraformProperty<double>? DictPageSizeLimit
    {
        get => GetProperty<TerraformProperty<double>>("dict_page_size_limit");
        set => this.WithProperty("dict_page_size_limit", value);
    }

    /// <summary>
    /// The enable_statistics attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableStatistics
    {
        get => GetProperty<TerraformProperty<bool>>("enable_statistics");
        set => this.WithProperty("enable_statistics", value);
    }

    /// <summary>
    /// The encoding_type attribute.
    /// </summary>
    public TerraformProperty<string>? EncodingType
    {
        get => GetProperty<TerraformProperty<string>>("encoding_type");
        set => this.WithProperty("encoding_type", value);
    }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionMode
    {
        get => GetProperty<TerraformProperty<string>>("encryption_mode");
        set => this.WithProperty("encryption_mode", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointId is required")]
    public required TerraformProperty<string> EndpointId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("endpoint_id");
        set => this.WithProperty("endpoint_id", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    public required TerraformProperty<string> EndpointType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("endpoint_type");
        set => this.WithProperty("endpoint_type", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformProperty<string>? ExpectedBucketOwner
    {
        get => GetProperty<TerraformProperty<string>>("expected_bucket_owner");
        set => this.WithProperty("expected_bucket_owner", value);
    }

    /// <summary>
    /// The external_table_definition attribute.
    /// </summary>
    public TerraformProperty<string>? ExternalTableDefinition
    {
        get => GetProperty<TerraformProperty<string>>("external_table_definition");
        set => this.WithProperty("external_table_definition", value);
    }

    /// <summary>
    /// The glue_catalog_generation attribute.
    /// </summary>
    public TerraformProperty<bool>? GlueCatalogGeneration
    {
        get => GetProperty<TerraformProperty<bool>>("glue_catalog_generation");
        set => this.WithProperty("glue_catalog_generation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ignore_header_rows attribute.
    /// </summary>
    public TerraformProperty<double>? IgnoreHeaderRows
    {
        get => GetProperty<TerraformProperty<double>>("ignore_header_rows");
        set => this.WithProperty("ignore_header_rows", value);
    }

    /// <summary>
    /// The include_op_for_full_load attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeOpForFullLoad
    {
        get => GetProperty<TerraformProperty<bool>>("include_op_for_full_load");
        set => this.WithProperty("include_op_for_full_load", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    public TerraformProperty<double>? MaxFileSize
    {
        get => GetProperty<TerraformProperty<double>>("max_file_size");
        set => this.WithProperty("max_file_size", value);
    }

    /// <summary>
    /// The parquet_timestamp_in_millisecond attribute.
    /// </summary>
    public TerraformProperty<bool>? ParquetTimestampInMillisecond
    {
        get => GetProperty<TerraformProperty<bool>>("parquet_timestamp_in_millisecond");
        set => this.WithProperty("parquet_timestamp_in_millisecond", value);
    }

    /// <summary>
    /// The parquet_version attribute.
    /// </summary>
    public TerraformProperty<string>? ParquetVersion
    {
        get => GetProperty<TerraformProperty<string>>("parquet_version");
        set => this.WithProperty("parquet_version", value);
    }

    /// <summary>
    /// The preserve_transactions attribute.
    /// </summary>
    public TerraformProperty<bool>? PreserveTransactions
    {
        get => GetProperty<TerraformProperty<bool>>("preserve_transactions");
        set => this.WithProperty("preserve_transactions", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rfc_4180 attribute.
    /// </summary>
    public TerraformProperty<bool>? Rfc4180
    {
        get => GetProperty<TerraformProperty<bool>>("rfc_4180");
        set => this.WithProperty("rfc_4180", value);
    }

    /// <summary>
    /// The row_group_length attribute.
    /// </summary>
    public TerraformProperty<double>? RowGroupLength
    {
        get => GetProperty<TerraformProperty<double>>("row_group_length");
        set => this.WithProperty("row_group_length", value);
    }

    /// <summary>
    /// The server_side_encryption_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServerSideEncryptionKmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("server_side_encryption_kms_key_id");
        set => this.WithProperty("server_side_encryption_kms_key_id", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccessRoleArn is required")]
    public required TerraformProperty<string> ServiceAccessRoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_access_role_arn");
        set => this.WithProperty("service_access_role_arn", value);
    }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    public TerraformProperty<string>? SslMode
    {
        get => GetProperty<TerraformProperty<string>>("ssl_mode");
        set => this.WithProperty("ssl_mode", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The timestamp_column_name attribute.
    /// </summary>
    public TerraformProperty<string>? TimestampColumnName
    {
        get => GetProperty<TerraformProperty<string>>("timestamp_column_name");
        set => this.WithProperty("timestamp_column_name", value);
    }

    /// <summary>
    /// The use_csv_no_sup_value attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCsvNoSupValue
    {
        get => GetProperty<TerraformProperty<bool>>("use_csv_no_sup_value");
        set => this.WithProperty("use_csv_no_sup_value", value);
    }

    /// <summary>
    /// The use_task_start_time_for_full_load_timestamp attribute.
    /// </summary>
    public TerraformProperty<bool>? UseTaskStartTimeForFullLoadTimestamp
    {
        get => GetProperty<TerraformProperty<bool>>("use_task_start_time_for_full_load_timestamp");
        set => this.WithProperty("use_task_start_time_for_full_load_timestamp", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDmsS3EndpointTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDmsS3EndpointTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    public TerraformExpression EndpointArn => this["endpoint_arn"];

    /// <summary>
    /// The engine_display_name attribute.
    /// </summary>
    public TerraformExpression EngineDisplayName => this["engine_display_name"];

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    public TerraformExpression ExternalId => this["external_id"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
