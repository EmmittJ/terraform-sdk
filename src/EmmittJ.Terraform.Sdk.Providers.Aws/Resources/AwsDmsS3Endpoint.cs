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
    public TerraformLiteralProperty<bool>? AddColumnName
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("add_column_name");
        set => this.WithProperty("add_column_name", value);
    }

    /// <summary>
    /// The add_trailing_padding_character attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AddTrailingPaddingCharacter
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("add_trailing_padding_character");
        set => this.WithProperty("add_trailing_padding_character", value);
    }

    /// <summary>
    /// The bucket_folder attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BucketFolder
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_folder");
        set => this.WithProperty("bucket_folder", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_name");
        set => this.WithProperty("bucket_name", value);
    }

    /// <summary>
    /// The canned_acl_for_objects attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CannedAclForObjects
    {
        get => GetProperty<TerraformLiteralProperty<string>>("canned_acl_for_objects");
        set => this.WithProperty("canned_acl_for_objects", value);
    }

    /// <summary>
    /// The cdc_inserts_and_updates attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CdcInsertsAndUpdates
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cdc_inserts_and_updates");
        set => this.WithProperty("cdc_inserts_and_updates", value);
    }

    /// <summary>
    /// The cdc_inserts_only attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CdcInsertsOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cdc_inserts_only");
        set => this.WithProperty("cdc_inserts_only", value);
    }

    /// <summary>
    /// The cdc_max_batch_interval attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? CdcMaxBatchInterval
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cdc_max_batch_interval");
        set => this.WithProperty("cdc_max_batch_interval", value);
    }

    /// <summary>
    /// The cdc_min_file_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? CdcMinFileSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cdc_min_file_size");
        set => this.WithProperty("cdc_min_file_size", value);
    }

    /// <summary>
    /// The cdc_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CdcPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdc_path");
        set => this.WithProperty("cdc_path", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_arn");
        set => this.WithProperty("certificate_arn", value);
    }

    /// <summary>
    /// The compression_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CompressionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compression_type");
        set => this.WithProperty("compression_type", value);
    }

    /// <summary>
    /// The csv_delimiter attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CsvDelimiter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("csv_delimiter");
        set => this.WithProperty("csv_delimiter", value);
    }

    /// <summary>
    /// The csv_no_sup_value attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CsvNoSupValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("csv_no_sup_value");
        set => this.WithProperty("csv_no_sup_value", value);
    }

    /// <summary>
    /// The csv_null_value attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CsvNullValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("csv_null_value");
        set => this.WithProperty("csv_null_value", value);
    }

    /// <summary>
    /// The csv_row_delimiter attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CsvRowDelimiter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("csv_row_delimiter");
        set => this.WithProperty("csv_row_delimiter", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_format");
        set => this.WithProperty("data_format", value);
    }

    /// <summary>
    /// The data_page_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DataPageSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("data_page_size");
        set => this.WithProperty("data_page_size", value);
    }

    /// <summary>
    /// The date_partition_delimiter attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatePartitionDelimiter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("date_partition_delimiter");
        set => this.WithProperty("date_partition_delimiter", value);
    }

    /// <summary>
    /// The date_partition_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DatePartitionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("date_partition_enabled");
        set => this.WithProperty("date_partition_enabled", value);
    }

    /// <summary>
    /// The date_partition_sequence attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatePartitionSequence
    {
        get => GetProperty<TerraformLiteralProperty<string>>("date_partition_sequence");
        set => this.WithProperty("date_partition_sequence", value);
    }

    /// <summary>
    /// The date_partition_timezone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatePartitionTimezone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("date_partition_timezone");
        set => this.WithProperty("date_partition_timezone", value);
    }

    /// <summary>
    /// The detach_target_on_lob_lookup_failure_parquet attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DetachTargetOnLobLookupFailureParquet
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("detach_target_on_lob_lookup_failure_parquet");
        set => this.WithProperty("detach_target_on_lob_lookup_failure_parquet", value);
    }

    /// <summary>
    /// The dict_page_size_limit attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DictPageSizeLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("dict_page_size_limit");
        set => this.WithProperty("dict_page_size_limit", value);
    }

    /// <summary>
    /// The enable_statistics attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableStatistics
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_statistics");
        set => this.WithProperty("enable_statistics", value);
    }

    /// <summary>
    /// The encoding_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EncodingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encoding_type");
        set => this.WithProperty("encoding_type", value);
    }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EncryptionMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_mode");
        set => this.WithProperty("encryption_mode", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_id");
        set => this.WithProperty("endpoint_id", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndpointType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_type");
        set => this.WithProperty("endpoint_type", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExpectedBucketOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expected_bucket_owner");
        set => this.WithProperty("expected_bucket_owner", value);
    }

    /// <summary>
    /// The external_table_definition attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExternalTableDefinition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("external_table_definition");
        set => this.WithProperty("external_table_definition", value);
    }

    /// <summary>
    /// The glue_catalog_generation attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? GlueCatalogGeneration
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("glue_catalog_generation");
        set => this.WithProperty("glue_catalog_generation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ignore_header_rows attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? IgnoreHeaderRows
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ignore_header_rows");
        set => this.WithProperty("ignore_header_rows", value);
    }

    /// <summary>
    /// The include_op_for_full_load attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IncludeOpForFullLoad
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_op_for_full_load");
        set => this.WithProperty("include_op_for_full_load", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxFileSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_file_size");
        set => this.WithProperty("max_file_size", value);
    }

    /// <summary>
    /// The parquet_timestamp_in_millisecond attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ParquetTimestampInMillisecond
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("parquet_timestamp_in_millisecond");
        set => this.WithProperty("parquet_timestamp_in_millisecond", value);
    }

    /// <summary>
    /// The parquet_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ParquetVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parquet_version");
        set => this.WithProperty("parquet_version", value);
    }

    /// <summary>
    /// The preserve_transactions attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PreserveTransactions
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("preserve_transactions");
        set => this.WithProperty("preserve_transactions", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rfc_4180 attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Rfc4180
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("rfc_4180");
        set => this.WithProperty("rfc_4180", value);
    }

    /// <summary>
    /// The row_group_length attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RowGroupLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("row_group_length");
        set => this.WithProperty("row_group_length", value);
    }

    /// <summary>
    /// The server_side_encryption_kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServerSideEncryptionKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_side_encryption_kms_key_id");
        set => this.WithProperty("server_side_encryption_kms_key_id", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceAccessRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_access_role_arn");
        set => this.WithProperty("service_access_role_arn", value);
    }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SslMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssl_mode");
        set => this.WithProperty("ssl_mode", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The timestamp_column_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TimestampColumnName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timestamp_column_name");
        set => this.WithProperty("timestamp_column_name", value);
    }

    /// <summary>
    /// The use_csv_no_sup_value attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UseCsvNoSupValue
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_csv_no_sup_value");
        set => this.WithProperty("use_csv_no_sup_value", value);
    }

    /// <summary>
    /// The use_task_start_time_for_full_load_timestamp attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UseTaskStartTimeForFullLoadTimestamp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_task_start_time_for_full_load_timestamp");
        set => this.WithProperty("use_task_start_time_for_full_load_timestamp", value);
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
