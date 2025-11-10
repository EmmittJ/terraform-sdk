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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("endpoint_arn");
        SetOutput("engine_display_name");
        SetOutput("external_id");
        SetOutput("status");
        SetOutput("add_column_name");
        SetOutput("add_trailing_padding_character");
        SetOutput("bucket_folder");
        SetOutput("bucket_name");
        SetOutput("canned_acl_for_objects");
        SetOutput("cdc_inserts_and_updates");
        SetOutput("cdc_inserts_only");
        SetOutput("cdc_max_batch_interval");
        SetOutput("cdc_min_file_size");
        SetOutput("cdc_path");
        SetOutput("certificate_arn");
        SetOutput("compression_type");
        SetOutput("csv_delimiter");
        SetOutput("csv_no_sup_value");
        SetOutput("csv_null_value");
        SetOutput("csv_row_delimiter");
        SetOutput("data_format");
        SetOutput("data_page_size");
        SetOutput("date_partition_delimiter");
        SetOutput("date_partition_enabled");
        SetOutput("date_partition_sequence");
        SetOutput("date_partition_timezone");
        SetOutput("detach_target_on_lob_lookup_failure_parquet");
        SetOutput("dict_page_size_limit");
        SetOutput("enable_statistics");
        SetOutput("encoding_type");
        SetOutput("encryption_mode");
        SetOutput("endpoint_id");
        SetOutput("endpoint_type");
        SetOutput("expected_bucket_owner");
        SetOutput("external_table_definition");
        SetOutput("glue_catalog_generation");
        SetOutput("id");
        SetOutput("ignore_header_rows");
        SetOutput("include_op_for_full_load");
        SetOutput("kms_key_arn");
        SetOutput("max_file_size");
        SetOutput("parquet_timestamp_in_millisecond");
        SetOutput("parquet_version");
        SetOutput("preserve_transactions");
        SetOutput("region");
        SetOutput("rfc_4180");
        SetOutput("row_group_length");
        SetOutput("server_side_encryption_kms_key_id");
        SetOutput("service_access_role_arn");
        SetOutput("ssl_mode");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("timestamp_column_name");
        SetOutput("use_csv_no_sup_value");
        SetOutput("use_task_start_time_for_full_load_timestamp");
    }

    /// <summary>
    /// The add_column_name attribute.
    /// </summary>
    public TerraformProperty<bool> AddColumnName
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("add_column_name");
        set => SetProperty("add_column_name", value);
    }

    /// <summary>
    /// The add_trailing_padding_character attribute.
    /// </summary>
    public TerraformProperty<bool> AddTrailingPaddingCharacter
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("add_trailing_padding_character");
        set => SetProperty("add_trailing_padding_character", value);
    }

    /// <summary>
    /// The bucket_folder attribute.
    /// </summary>
    public TerraformProperty<string> BucketFolder
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket_folder");
        set => SetProperty("bucket_folder", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformProperty<string> BucketName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket_name");
        set => SetProperty("bucket_name", value);
    }

    /// <summary>
    /// The canned_acl_for_objects attribute.
    /// </summary>
    public TerraformProperty<string> CannedAclForObjects
    {
        get => GetRequiredOutput<TerraformProperty<string>>("canned_acl_for_objects");
        set => SetProperty("canned_acl_for_objects", value);
    }

    /// <summary>
    /// The cdc_inserts_and_updates attribute.
    /// </summary>
    public TerraformProperty<bool> CdcInsertsAndUpdates
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("cdc_inserts_and_updates");
        set => SetProperty("cdc_inserts_and_updates", value);
    }

    /// <summary>
    /// The cdc_inserts_only attribute.
    /// </summary>
    public TerraformProperty<bool> CdcInsertsOnly
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("cdc_inserts_only");
        set => SetProperty("cdc_inserts_only", value);
    }

    /// <summary>
    /// The cdc_max_batch_interval attribute.
    /// </summary>
    public TerraformProperty<double> CdcMaxBatchInterval
    {
        get => GetRequiredOutput<TerraformProperty<double>>("cdc_max_batch_interval");
        set => SetProperty("cdc_max_batch_interval", value);
    }

    /// <summary>
    /// The cdc_min_file_size attribute.
    /// </summary>
    public TerraformProperty<double> CdcMinFileSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("cdc_min_file_size");
        set => SetProperty("cdc_min_file_size", value);
    }

    /// <summary>
    /// The cdc_path attribute.
    /// </summary>
    public TerraformProperty<string> CdcPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cdc_path");
        set => SetProperty("cdc_path", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string> CertificateArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_arn");
        set => SetProperty("certificate_arn", value);
    }

    /// <summary>
    /// The compression_type attribute.
    /// </summary>
    public TerraformProperty<string> CompressionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compression_type");
        set => SetProperty("compression_type", value);
    }

    /// <summary>
    /// The csv_delimiter attribute.
    /// </summary>
    public TerraformProperty<string> CsvDelimiter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("csv_delimiter");
        set => SetProperty("csv_delimiter", value);
    }

    /// <summary>
    /// The csv_no_sup_value attribute.
    /// </summary>
    public TerraformProperty<string> CsvNoSupValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("csv_no_sup_value");
        set => SetProperty("csv_no_sup_value", value);
    }

    /// <summary>
    /// The csv_null_value attribute.
    /// </summary>
    public TerraformProperty<string> CsvNullValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("csv_null_value");
        set => SetProperty("csv_null_value", value);
    }

    /// <summary>
    /// The csv_row_delimiter attribute.
    /// </summary>
    public TerraformProperty<string> CsvRowDelimiter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("csv_row_delimiter");
        set => SetProperty("csv_row_delimiter", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformProperty<string> DataFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_format");
        set => SetProperty("data_format", value);
    }

    /// <summary>
    /// The data_page_size attribute.
    /// </summary>
    public TerraformProperty<double> DataPageSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("data_page_size");
        set => SetProperty("data_page_size", value);
    }

    /// <summary>
    /// The date_partition_delimiter attribute.
    /// </summary>
    public TerraformProperty<string> DatePartitionDelimiter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("date_partition_delimiter");
        set => SetProperty("date_partition_delimiter", value);
    }

    /// <summary>
    /// The date_partition_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DatePartitionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("date_partition_enabled");
        set => SetProperty("date_partition_enabled", value);
    }

    /// <summary>
    /// The date_partition_sequence attribute.
    /// </summary>
    public TerraformProperty<string> DatePartitionSequence
    {
        get => GetRequiredOutput<TerraformProperty<string>>("date_partition_sequence");
        set => SetProperty("date_partition_sequence", value);
    }

    /// <summary>
    /// The date_partition_timezone attribute.
    /// </summary>
    public TerraformProperty<string> DatePartitionTimezone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("date_partition_timezone");
        set => SetProperty("date_partition_timezone", value);
    }

    /// <summary>
    /// The detach_target_on_lob_lookup_failure_parquet attribute.
    /// </summary>
    public TerraformProperty<bool> DetachTargetOnLobLookupFailureParquet
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("detach_target_on_lob_lookup_failure_parquet");
        set => SetProperty("detach_target_on_lob_lookup_failure_parquet", value);
    }

    /// <summary>
    /// The dict_page_size_limit attribute.
    /// </summary>
    public TerraformProperty<double> DictPageSizeLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("dict_page_size_limit");
        set => SetProperty("dict_page_size_limit", value);
    }

    /// <summary>
    /// The enable_statistics attribute.
    /// </summary>
    public TerraformProperty<bool> EnableStatistics
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_statistics");
        set => SetProperty("enable_statistics", value);
    }

    /// <summary>
    /// The encoding_type attribute.
    /// </summary>
    public TerraformProperty<string> EncodingType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encoding_type");
        set => SetProperty("encoding_type", value);
    }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    public TerraformProperty<string> EncryptionMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encryption_mode");
        set => SetProperty("encryption_mode", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointId is required")]
    public required TerraformProperty<string> EndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint_id");
        set => SetProperty("endpoint_id", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    public required TerraformProperty<string> EndpointType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint_type");
        set => SetProperty("endpoint_type", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformProperty<string> ExpectedBucketOwner
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expected_bucket_owner");
        set => SetProperty("expected_bucket_owner", value);
    }

    /// <summary>
    /// The external_table_definition attribute.
    /// </summary>
    public TerraformProperty<string> ExternalTableDefinition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("external_table_definition");
        set => SetProperty("external_table_definition", value);
    }

    /// <summary>
    /// The glue_catalog_generation attribute.
    /// </summary>
    public TerraformProperty<bool> GlueCatalogGeneration
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("glue_catalog_generation");
        set => SetProperty("glue_catalog_generation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ignore_header_rows attribute.
    /// </summary>
    public TerraformProperty<double> IgnoreHeaderRows
    {
        get => GetRequiredOutput<TerraformProperty<double>>("ignore_header_rows");
        set => SetProperty("ignore_header_rows", value);
    }

    /// <summary>
    /// The include_op_for_full_load attribute.
    /// </summary>
    public TerraformProperty<bool> IncludeOpForFullLoad
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_op_for_full_load");
        set => SetProperty("include_op_for_full_load", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_arn");
        set => SetProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    public TerraformProperty<double> MaxFileSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_file_size");
        set => SetProperty("max_file_size", value);
    }

    /// <summary>
    /// The parquet_timestamp_in_millisecond attribute.
    /// </summary>
    public TerraformProperty<bool> ParquetTimestampInMillisecond
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("parquet_timestamp_in_millisecond");
        set => SetProperty("parquet_timestamp_in_millisecond", value);
    }

    /// <summary>
    /// The parquet_version attribute.
    /// </summary>
    public TerraformProperty<string> ParquetVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parquet_version");
        set => SetProperty("parquet_version", value);
    }

    /// <summary>
    /// The preserve_transactions attribute.
    /// </summary>
    public TerraformProperty<bool> PreserveTransactions
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("preserve_transactions");
        set => SetProperty("preserve_transactions", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The rfc_4180 attribute.
    /// </summary>
    public TerraformProperty<bool> Rfc4180
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("rfc_4180");
        set => SetProperty("rfc_4180", value);
    }

    /// <summary>
    /// The row_group_length attribute.
    /// </summary>
    public TerraformProperty<double> RowGroupLength
    {
        get => GetRequiredOutput<TerraformProperty<double>>("row_group_length");
        set => SetProperty("row_group_length", value);
    }

    /// <summary>
    /// The server_side_encryption_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> ServerSideEncryptionKmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_side_encryption_kms_key_id");
        set => SetProperty("server_side_encryption_kms_key_id", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccessRoleArn is required")]
    public required TerraformProperty<string> ServiceAccessRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_access_role_arn");
        set => SetProperty("service_access_role_arn", value);
    }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    public TerraformProperty<string> SslMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ssl_mode");
        set => SetProperty("ssl_mode", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The timestamp_column_name attribute.
    /// </summary>
    public TerraformProperty<string> TimestampColumnName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("timestamp_column_name");
        set => SetProperty("timestamp_column_name", value);
    }

    /// <summary>
    /// The use_csv_no_sup_value attribute.
    /// </summary>
    public TerraformProperty<bool> UseCsvNoSupValue
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_csv_no_sup_value");
        set => SetProperty("use_csv_no_sup_value", value);
    }

    /// <summary>
    /// The use_task_start_time_for_full_load_timestamp attribute.
    /// </summary>
    public TerraformProperty<bool> UseTaskStartTimeForFullLoadTimestamp
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_task_start_time_for_full_load_timestamp");
        set => SetProperty("use_task_start_time_for_full_load_timestamp", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDmsS3EndpointTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
