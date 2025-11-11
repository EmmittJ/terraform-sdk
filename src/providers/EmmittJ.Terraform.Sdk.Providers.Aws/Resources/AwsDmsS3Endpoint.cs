using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDmsS3EndpointTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a aws_dms_s3_endpoint resource.
/// </summary>
public partial class AwsDmsS3Endpoint : TerraformResource
{
    public AwsDmsS3Endpoint(string name) : base("aws_dms_s3_endpoint", name)
    {
    }

    /// <summary>
    /// The add_column_name attribute.
    /// </summary>
    [TerraformProperty("add_column_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AddColumnName { get; set; }

    /// <summary>
    /// The add_trailing_padding_character attribute.
    /// </summary>
    [TerraformProperty("add_trailing_padding_character")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AddTrailingPaddingCharacter { get; set; }

    /// <summary>
    /// The bucket_folder attribute.
    /// </summary>
    [TerraformProperty("bucket_folder")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BucketFolder { get; set; }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformProperty("bucket_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BucketName { get; set; }

    /// <summary>
    /// The canned_acl_for_objects attribute.
    /// </summary>
    [TerraformProperty("canned_acl_for_objects")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CannedAclForObjects { get; set; }

    /// <summary>
    /// The cdc_inserts_and_updates attribute.
    /// </summary>
    [TerraformProperty("cdc_inserts_and_updates")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CdcInsertsAndUpdates { get; set; }

    /// <summary>
    /// The cdc_inserts_only attribute.
    /// </summary>
    [TerraformProperty("cdc_inserts_only")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CdcInsertsOnly { get; set; }

    /// <summary>
    /// The cdc_max_batch_interval attribute.
    /// </summary>
    [TerraformProperty("cdc_max_batch_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CdcMaxBatchInterval { get; set; }

    /// <summary>
    /// The cdc_min_file_size attribute.
    /// </summary>
    [TerraformProperty("cdc_min_file_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CdcMinFileSize { get; set; }

    /// <summary>
    /// The cdc_path attribute.
    /// </summary>
    [TerraformProperty("cdc_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CdcPath { get; set; }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CertificateArn { get; set; }

    /// <summary>
    /// The compression_type attribute.
    /// </summary>
    [TerraformProperty("compression_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CompressionType { get; set; }

    /// <summary>
    /// The csv_delimiter attribute.
    /// </summary>
    [TerraformProperty("csv_delimiter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CsvDelimiter { get; set; }

    /// <summary>
    /// The csv_no_sup_value attribute.
    /// </summary>
    [TerraformProperty("csv_no_sup_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CsvNoSupValue { get; set; }

    /// <summary>
    /// The csv_null_value attribute.
    /// </summary>
    [TerraformProperty("csv_null_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CsvNullValue { get; set; }

    /// <summary>
    /// The csv_row_delimiter attribute.
    /// </summary>
    [TerraformProperty("csv_row_delimiter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CsvRowDelimiter { get; set; }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    [TerraformProperty("data_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataFormat { get; set; }

    /// <summary>
    /// The data_page_size attribute.
    /// </summary>
    [TerraformProperty("data_page_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DataPageSize { get; set; }

    /// <summary>
    /// The date_partition_delimiter attribute.
    /// </summary>
    [TerraformProperty("date_partition_delimiter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DatePartitionDelimiter { get; set; }

    /// <summary>
    /// The date_partition_enabled attribute.
    /// </summary>
    [TerraformProperty("date_partition_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DatePartitionEnabled { get; set; }

    /// <summary>
    /// The date_partition_sequence attribute.
    /// </summary>
    [TerraformProperty("date_partition_sequence")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DatePartitionSequence { get; set; }

    /// <summary>
    /// The date_partition_timezone attribute.
    /// </summary>
    [TerraformProperty("date_partition_timezone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DatePartitionTimezone { get; set; }

    /// <summary>
    /// The detach_target_on_lob_lookup_failure_parquet attribute.
    /// </summary>
    [TerraformProperty("detach_target_on_lob_lookup_failure_parquet")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DetachTargetOnLobLookupFailureParquet { get; set; }

    /// <summary>
    /// The dict_page_size_limit attribute.
    /// </summary>
    [TerraformProperty("dict_page_size_limit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DictPageSizeLimit { get; set; }

    /// <summary>
    /// The enable_statistics attribute.
    /// </summary>
    [TerraformProperty("enable_statistics")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableStatistics { get; set; }

    /// <summary>
    /// The encoding_type attribute.
    /// </summary>
    [TerraformProperty("encoding_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EncodingType { get; set; }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    [TerraformProperty("encryption_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EncryptionMode { get; set; }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointId is required")]
    [TerraformProperty("endpoint_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EndpointId { get; set; }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    [TerraformProperty("endpoint_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EndpointType { get; set; }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    [TerraformProperty("expected_bucket_owner")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExpectedBucketOwner { get; set; }

    /// <summary>
    /// The external_table_definition attribute.
    /// </summary>
    [TerraformProperty("external_table_definition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExternalTableDefinition { get; set; }

    /// <summary>
    /// The glue_catalog_generation attribute.
    /// </summary>
    [TerraformProperty("glue_catalog_generation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? GlueCatalogGeneration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ignore_header_rows attribute.
    /// </summary>
    [TerraformProperty("ignore_header_rows")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IgnoreHeaderRows { get; set; }

    /// <summary>
    /// The include_op_for_full_load attribute.
    /// </summary>
    [TerraformProperty("include_op_for_full_load")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeOpForFullLoad { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyArn { get; set; }

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    [TerraformProperty("max_file_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxFileSize { get; set; }

    /// <summary>
    /// The parquet_timestamp_in_millisecond attribute.
    /// </summary>
    [TerraformProperty("parquet_timestamp_in_millisecond")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ParquetTimestampInMillisecond { get; set; }

    /// <summary>
    /// The parquet_version attribute.
    /// </summary>
    [TerraformProperty("parquet_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ParquetVersion { get; set; }

    /// <summary>
    /// The preserve_transactions attribute.
    /// </summary>
    [TerraformProperty("preserve_transactions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PreserveTransactions { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rfc_4180 attribute.
    /// </summary>
    [TerraformProperty("rfc_4180")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Rfc4180 { get; set; }

    /// <summary>
    /// The row_group_length attribute.
    /// </summary>
    [TerraformProperty("row_group_length")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RowGroupLength { get; set; }

    /// <summary>
    /// The server_side_encryption_kms_key_id attribute.
    /// </summary>
    [TerraformProperty("server_side_encryption_kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServerSideEncryptionKmsKeyId { get; set; }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccessRoleArn is required")]
    [TerraformProperty("service_access_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceAccessRoleArn { get; set; }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    [TerraformProperty("ssl_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SslMode { get; set; }

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
    /// The timestamp_column_name attribute.
    /// </summary>
    [TerraformProperty("timestamp_column_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TimestampColumnName { get; set; }

    /// <summary>
    /// The use_csv_no_sup_value attribute.
    /// </summary>
    [TerraformProperty("use_csv_no_sup_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseCsvNoSupValue { get; set; }

    /// <summary>
    /// The use_task_start_time_for_full_load_timestamp attribute.
    /// </summary>
    [TerraformProperty("use_task_start_time_for_full_load_timestamp")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseTaskStartTimeForFullLoadTimestamp { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsDmsS3EndpointTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    [TerraformProperty("endpoint_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndpointArn { get; }

    /// <summary>
    /// The engine_display_name attribute.
    /// </summary>
    [TerraformProperty("engine_display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EngineDisplayName { get; }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [TerraformProperty("external_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExternalId { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
