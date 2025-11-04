using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("endpoint_arn");
        this.DeclareOutput("engine_display_name");
        this.DeclareOutput("external_id");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The add_column_name attribute.
    /// </summary>
    public bool? AddColumnName
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("add_column_name")?.Value;
        set => this.WithProperty("add_column_name", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The add_trailing_padding_character attribute.
    /// </summary>
    public bool? AddTrailingPaddingCharacter
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("add_trailing_padding_character")?.Value;
        set => this.WithProperty("add_trailing_padding_character", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The bucket_folder attribute.
    /// </summary>
    public string? BucketFolder
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_folder")?.Value;
        set => this.WithProperty("bucket_folder", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public string? BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_name")?.Value;
        set => this.WithProperty("bucket_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The canned_acl_for_objects attribute.
    /// </summary>
    public string? CannedAclForObjects
    {
        get => GetProperty<TerraformLiteralProperty<string>>("canned_acl_for_objects")?.Value;
        set => this.WithProperty("canned_acl_for_objects", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cdc_inserts_and_updates attribute.
    /// </summary>
    public bool? CdcInsertsAndUpdates
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cdc_inserts_and_updates")?.Value;
        set => this.WithProperty("cdc_inserts_and_updates", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The cdc_inserts_only attribute.
    /// </summary>
    public bool? CdcInsertsOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cdc_inserts_only")?.Value;
        set => this.WithProperty("cdc_inserts_only", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The cdc_max_batch_interval attribute.
    /// </summary>
    public double? CdcMaxBatchInterval
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cdc_max_batch_interval")?.Value;
        set => this.WithProperty("cdc_max_batch_interval", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The cdc_min_file_size attribute.
    /// </summary>
    public double? CdcMinFileSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cdc_min_file_size")?.Value;
        set => this.WithProperty("cdc_min_file_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The cdc_path attribute.
    /// </summary>
    public string? CdcPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdc_path")?.Value;
        set => this.WithProperty("cdc_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public string? CertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_arn")?.Value;
        set => this.WithProperty("certificate_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The compression_type attribute.
    /// </summary>
    public string? CompressionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compression_type")?.Value;
        set => this.WithProperty("compression_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The csv_delimiter attribute.
    /// </summary>
    public string? CsvDelimiter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("csv_delimiter")?.Value;
        set => this.WithProperty("csv_delimiter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The csv_no_sup_value attribute.
    /// </summary>
    public string? CsvNoSupValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("csv_no_sup_value")?.Value;
        set => this.WithProperty("csv_no_sup_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The csv_null_value attribute.
    /// </summary>
    public string? CsvNullValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("csv_null_value")?.Value;
        set => this.WithProperty("csv_null_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The csv_row_delimiter attribute.
    /// </summary>
    public string? CsvRowDelimiter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("csv_row_delimiter")?.Value;
        set => this.WithProperty("csv_row_delimiter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public string? DataFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_format")?.Value;
        set => this.WithProperty("data_format", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_page_size attribute.
    /// </summary>
    public double? DataPageSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("data_page_size")?.Value;
        set => this.WithProperty("data_page_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The date_partition_delimiter attribute.
    /// </summary>
    public string? DatePartitionDelimiter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("date_partition_delimiter")?.Value;
        set => this.WithProperty("date_partition_delimiter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The date_partition_enabled attribute.
    /// </summary>
    public bool? DatePartitionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("date_partition_enabled")?.Value;
        set => this.WithProperty("date_partition_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The date_partition_sequence attribute.
    /// </summary>
    public string? DatePartitionSequence
    {
        get => GetProperty<TerraformLiteralProperty<string>>("date_partition_sequence")?.Value;
        set => this.WithProperty("date_partition_sequence", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The date_partition_timezone attribute.
    /// </summary>
    public string? DatePartitionTimezone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("date_partition_timezone")?.Value;
        set => this.WithProperty("date_partition_timezone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The detach_target_on_lob_lookup_failure_parquet attribute.
    /// </summary>
    public bool? DetachTargetOnLobLookupFailureParquet
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("detach_target_on_lob_lookup_failure_parquet")?.Value;
        set => this.WithProperty("detach_target_on_lob_lookup_failure_parquet", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The dict_page_size_limit attribute.
    /// </summary>
    public double? DictPageSizeLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("dict_page_size_limit")?.Value;
        set => this.WithProperty("dict_page_size_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The enable_statistics attribute.
    /// </summary>
    public bool? EnableStatistics
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_statistics")?.Value;
        set => this.WithProperty("enable_statistics", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The encoding_type attribute.
    /// </summary>
    public string? EncodingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encoding_type")?.Value;
        set => this.WithProperty("encoding_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    public string? EncryptionMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_mode")?.Value;
        set => this.WithProperty("encryption_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    public string? EndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_id")?.Value;
        set => this.WithProperty("endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public string? EndpointType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_type")?.Value;
        set => this.WithProperty("endpoint_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public string? ExpectedBucketOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expected_bucket_owner")?.Value;
        set => this.WithProperty("expected_bucket_owner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The external_table_definition attribute.
    /// </summary>
    public string? ExternalTableDefinition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("external_table_definition")?.Value;
        set => this.WithProperty("external_table_definition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The glue_catalog_generation attribute.
    /// </summary>
    public bool? GlueCatalogGeneration
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("glue_catalog_generation")?.Value;
        set => this.WithProperty("glue_catalog_generation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ignore_header_rows attribute.
    /// </summary>
    public double? IgnoreHeaderRows
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ignore_header_rows")?.Value;
        set => this.WithProperty("ignore_header_rows", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The include_op_for_full_load attribute.
    /// </summary>
    public bool? IncludeOpForFullLoad
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_op_for_full_load")?.Value;
        set => this.WithProperty("include_op_for_full_load", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public string? KmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_arn")?.Value;
        set => this.WithProperty("kms_key_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    public double? MaxFileSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_file_size")?.Value;
        set => this.WithProperty("max_file_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The parquet_timestamp_in_millisecond attribute.
    /// </summary>
    public bool? ParquetTimestampInMillisecond
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("parquet_timestamp_in_millisecond")?.Value;
        set => this.WithProperty("parquet_timestamp_in_millisecond", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The parquet_version attribute.
    /// </summary>
    public string? ParquetVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parquet_version")?.Value;
        set => this.WithProperty("parquet_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preserve_transactions attribute.
    /// </summary>
    public bool? PreserveTransactions
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("preserve_transactions")?.Value;
        set => this.WithProperty("preserve_transactions", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The rfc_4180 attribute.
    /// </summary>
    public bool? Rfc4180
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("rfc_4180")?.Value;
        set => this.WithProperty("rfc_4180", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The row_group_length attribute.
    /// </summary>
    public double? RowGroupLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("row_group_length")?.Value;
        set => this.WithProperty("row_group_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The server_side_encryption_kms_key_id attribute.
    /// </summary>
    public string? ServerSideEncryptionKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_side_encryption_kms_key_id")?.Value;
        set => this.WithProperty("server_side_encryption_kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    public string? ServiceAccessRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_access_role_arn")?.Value;
        set => this.WithProperty("service_access_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    public string? SslMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssl_mode")?.Value;
        set => this.WithProperty("ssl_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The timestamp_column_name attribute.
    /// </summary>
    public string? TimestampColumnName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timestamp_column_name")?.Value;
        set => this.WithProperty("timestamp_column_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The use_csv_no_sup_value attribute.
    /// </summary>
    public bool? UseCsvNoSupValue
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_csv_no_sup_value")?.Value;
        set => this.WithProperty("use_csv_no_sup_value", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The use_task_start_time_for_full_load_timestamp attribute.
    /// </summary>
    public bool? UseTaskStartTimeForFullLoadTimestamp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_task_start_time_for_full_load_timestamp")?.Value;
        set => this.WithProperty("use_task_start_time_for_full_load_timestamp", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
