using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDmsS3EndpointTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a aws_dms_s3_endpoint resource.
/// </summary>
public class AwsDmsS3Endpoint : TerraformResource
{
    public AwsDmsS3Endpoint(string name) : base("aws_dms_s3_endpoint", name)
    {
    }

    /// <summary>
    /// The add_column_name attribute.
    /// </summary>
    [TerraformPropertyName("add_column_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AddColumnName { get; set; }

    /// <summary>
    /// The add_trailing_padding_character attribute.
    /// </summary>
    [TerraformPropertyName("add_trailing_padding_character")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AddTrailingPaddingCharacter { get; set; }

    /// <summary>
    /// The bucket_folder attribute.
    /// </summary>
    [TerraformPropertyName("bucket_folder")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BucketFolder { get; set; }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformPropertyName("bucket_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BucketName { get; set; }

    /// <summary>
    /// The canned_acl_for_objects attribute.
    /// </summary>
    [TerraformPropertyName("canned_acl_for_objects")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CannedAclForObjects { get; set; }

    /// <summary>
    /// The cdc_inserts_and_updates attribute.
    /// </summary>
    [TerraformPropertyName("cdc_inserts_and_updates")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CdcInsertsAndUpdates { get; set; }

    /// <summary>
    /// The cdc_inserts_only attribute.
    /// </summary>
    [TerraformPropertyName("cdc_inserts_only")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CdcInsertsOnly { get; set; }

    /// <summary>
    /// The cdc_max_batch_interval attribute.
    /// </summary>
    [TerraformPropertyName("cdc_max_batch_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? CdcMaxBatchInterval { get; set; }

    /// <summary>
    /// The cdc_min_file_size attribute.
    /// </summary>
    [TerraformPropertyName("cdc_min_file_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? CdcMinFileSize { get; set; }

    /// <summary>
    /// The cdc_path attribute.
    /// </summary>
    [TerraformPropertyName("cdc_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CdcPath { get; set; }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CertificateArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_arn");

    /// <summary>
    /// The compression_type attribute.
    /// </summary>
    [TerraformPropertyName("compression_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CompressionType { get; set; }

    /// <summary>
    /// The csv_delimiter attribute.
    /// </summary>
    [TerraformPropertyName("csv_delimiter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CsvDelimiter { get; set; }

    /// <summary>
    /// The csv_no_sup_value attribute.
    /// </summary>
    [TerraformPropertyName("csv_no_sup_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CsvNoSupValue { get; set; }

    /// <summary>
    /// The csv_null_value attribute.
    /// </summary>
    [TerraformPropertyName("csv_null_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CsvNullValue { get; set; }

    /// <summary>
    /// The csv_row_delimiter attribute.
    /// </summary>
    [TerraformPropertyName("csv_row_delimiter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CsvRowDelimiter { get; set; }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    [TerraformPropertyName("data_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataFormat { get; set; }

    /// <summary>
    /// The data_page_size attribute.
    /// </summary>
    [TerraformPropertyName("data_page_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DataPageSize { get; set; }

    /// <summary>
    /// The date_partition_delimiter attribute.
    /// </summary>
    [TerraformPropertyName("date_partition_delimiter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DatePartitionDelimiter { get; set; }

    /// <summary>
    /// The date_partition_enabled attribute.
    /// </summary>
    [TerraformPropertyName("date_partition_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DatePartitionEnabled { get; set; }

    /// <summary>
    /// The date_partition_sequence attribute.
    /// </summary>
    [TerraformPropertyName("date_partition_sequence")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DatePartitionSequence { get; set; }

    /// <summary>
    /// The date_partition_timezone attribute.
    /// </summary>
    [TerraformPropertyName("date_partition_timezone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DatePartitionTimezone { get; set; }

    /// <summary>
    /// The detach_target_on_lob_lookup_failure_parquet attribute.
    /// </summary>
    [TerraformPropertyName("detach_target_on_lob_lookup_failure_parquet")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DetachTargetOnLobLookupFailureParquet { get; set; }

    /// <summary>
    /// The dict_page_size_limit attribute.
    /// </summary>
    [TerraformPropertyName("dict_page_size_limit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DictPageSizeLimit { get; set; }

    /// <summary>
    /// The enable_statistics attribute.
    /// </summary>
    [TerraformPropertyName("enable_statistics")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableStatistics { get; set; }

    /// <summary>
    /// The encoding_type attribute.
    /// </summary>
    [TerraformPropertyName("encoding_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EncodingType { get; set; }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    [TerraformPropertyName("encryption_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EncryptionMode { get; set; }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointId is required")]
    [TerraformPropertyName("endpoint_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EndpointId { get; set; }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    [TerraformPropertyName("endpoint_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EndpointType { get; set; }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    [TerraformPropertyName("expected_bucket_owner")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExpectedBucketOwner { get; set; }

    /// <summary>
    /// The external_table_definition attribute.
    /// </summary>
    [TerraformPropertyName("external_table_definition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExternalTableDefinition { get; set; }

    /// <summary>
    /// The glue_catalog_generation attribute.
    /// </summary>
    [TerraformPropertyName("glue_catalog_generation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? GlueCatalogGeneration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ignore_header_rows attribute.
    /// </summary>
    [TerraformPropertyName("ignore_header_rows")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? IgnoreHeaderRows { get; set; }

    /// <summary>
    /// The include_op_for_full_load attribute.
    /// </summary>
    [TerraformPropertyName("include_op_for_full_load")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeOpForFullLoad { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_arn");

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    [TerraformPropertyName("max_file_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxFileSize { get; set; }

    /// <summary>
    /// The parquet_timestamp_in_millisecond attribute.
    /// </summary>
    [TerraformPropertyName("parquet_timestamp_in_millisecond")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ParquetTimestampInMillisecond { get; set; }

    /// <summary>
    /// The parquet_version attribute.
    /// </summary>
    [TerraformPropertyName("parquet_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ParquetVersion { get; set; }

    /// <summary>
    /// The preserve_transactions attribute.
    /// </summary>
    [TerraformPropertyName("preserve_transactions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PreserveTransactions { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The rfc_4180 attribute.
    /// </summary>
    [TerraformPropertyName("rfc_4180")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Rfc4180 { get; set; }

    /// <summary>
    /// The row_group_length attribute.
    /// </summary>
    [TerraformPropertyName("row_group_length")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RowGroupLength { get; set; }

    /// <summary>
    /// The server_side_encryption_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("server_side_encryption_kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServerSideEncryptionKmsKeyId { get; set; }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccessRoleArn is required")]
    [TerraformPropertyName("service_access_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceAccessRoleArn { get; set; }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    [TerraformPropertyName("ssl_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SslMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ssl_mode");

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
    /// The timestamp_column_name attribute.
    /// </summary>
    [TerraformPropertyName("timestamp_column_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TimestampColumnName { get; set; }

    /// <summary>
    /// The use_csv_no_sup_value attribute.
    /// </summary>
    [TerraformPropertyName("use_csv_no_sup_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseCsvNoSupValue { get; set; }

    /// <summary>
    /// The use_task_start_time_for_full_load_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("use_task_start_time_for_full_load_timestamp")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseTaskStartTimeForFullLoadTimestamp { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDmsS3EndpointTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_arn");

    /// <summary>
    /// The engine_display_name attribute.
    /// </summary>
    [TerraformPropertyName("engine_display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineDisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_display_name");

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [TerraformPropertyName("external_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExternalId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "external_id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
