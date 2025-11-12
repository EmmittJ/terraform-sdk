using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for elasticsearch_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock() : TerraformBlock("elasticsearch_configuration")
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformProperty("buffering_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformProperty("buffering_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    [TerraformProperty("cluster_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClusterEndpoint { get; set; }

    /// <summary>
    /// The domain_arn attribute.
    /// </summary>
    [TerraformProperty("domain_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DomainArn { get; set; }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    [TerraformProperty("index_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IndexName { get; set; }

    /// <summary>
    /// The index_rotation_period attribute.
    /// </summary>
    [TerraformProperty("index_rotation_period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IndexRotationPeriod { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformProperty("retry_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformProperty("s3_backup_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3BackupMode { get; set; }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [TerraformProperty("type_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TypeName { get; set; }

}

/// <summary>
/// Block type for extended_s3_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock() : TerraformBlock("extended_s3_configuration")
{
    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    [TerraformProperty("bucket_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BucketArn { get; set; }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformProperty("buffering_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformProperty("buffering_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    [TerraformProperty("compression_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CompressionFormat { get; set; }

    /// <summary>
    /// The custom_time_zone attribute.
    /// </summary>
    [TerraformProperty("custom_time_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomTimeZone { get; set; }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    [TerraformProperty("error_output_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ErrorOutputPrefix { get; set; }

    /// <summary>
    /// The file_extension attribute.
    /// </summary>
    [TerraformProperty("file_extension")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FileExtension { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformProperty("prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Prefix { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformProperty("s3_backup_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3BackupMode { get; set; }

}

/// <summary>
/// Block type for http_endpoint_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock() : TerraformBlock("http_endpoint_configuration")
{
    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [TerraformProperty("access_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccessKey { get; set; }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformProperty("buffering_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformProperty("buffering_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformProperty("retry_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformProperty("s3_backup_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3BackupMode { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for iceberg_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock() : TerraformBlock("iceberg_configuration")
{
    /// <summary>
    /// The append_only attribute.
    /// </summary>
    [TerraformProperty("append_only")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> AppendOnly { get; set; }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformProperty("buffering_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformProperty("buffering_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The catalog_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogArn is required")]
    [TerraformProperty("catalog_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CatalogArn { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformProperty("retry_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformProperty("s3_backup_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3BackupMode { get; set; }

}

/// <summary>
/// Block type for kinesis_source_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisFirehoseDeliveryStreamKinesisSourceConfigurationBlock() : TerraformBlock("kinesis_source_configuration")
{
    /// <summary>
    /// The kinesis_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KinesisStreamArn is required")]
    [TerraformProperty("kinesis_stream_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KinesisStreamArn { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Block type for msk_source_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlock() : TerraformBlock("msk_source_configuration")
{
    /// <summary>
    /// The msk_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MskClusterArn is required")]
    [TerraformProperty("msk_cluster_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MskClusterArn { get; set; }

    /// <summary>
    /// The read_from_timestamp attribute.
    /// </summary>
    [TerraformProperty("read_from_timestamp")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReadFromTimestamp { get; set; }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicName is required")]
    [TerraformProperty("topic_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TopicName { get; set; }

}

/// <summary>
/// Block type for opensearch_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock() : TerraformBlock("opensearch_configuration")
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformProperty("buffering_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformProperty("buffering_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    [TerraformProperty("cluster_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClusterEndpoint { get; set; }

    /// <summary>
    /// The domain_arn attribute.
    /// </summary>
    [TerraformProperty("domain_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DomainArn { get; set; }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    [TerraformProperty("index_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IndexName { get; set; }

    /// <summary>
    /// The index_rotation_period attribute.
    /// </summary>
    [TerraformProperty("index_rotation_period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IndexRotationPeriod { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformProperty("retry_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformProperty("s3_backup_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3BackupMode { get; set; }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [TerraformProperty("type_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TypeName { get; set; }

}

/// <summary>
/// Block type for opensearchserverless_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock() : TerraformBlock("opensearchserverless_configuration")
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformProperty("buffering_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformProperty("buffering_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The collection_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionEndpoint is required")]
    [TerraformProperty("collection_endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CollectionEndpoint { get; set; }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    [TerraformProperty("index_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IndexName { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformProperty("retry_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformProperty("s3_backup_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3BackupMode { get; set; }

}

/// <summary>
/// Block type for redshift_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock() : TerraformBlock("redshift_configuration")
{
    /// <summary>
    /// The cluster_jdbcurl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterJdbcurl is required")]
    [TerraformProperty("cluster_jdbcurl")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterJdbcurl { get; set; }

    /// <summary>
    /// The copy_options attribute.
    /// </summary>
    [TerraformProperty("copy_options")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CopyOptions { get; set; }

    /// <summary>
    /// The data_table_columns attribute.
    /// </summary>
    [TerraformProperty("data_table_columns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataTableColumns { get; set; }

    /// <summary>
    /// The data_table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataTableName is required")]
    [TerraformProperty("data_table_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataTableName { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformProperty("retry_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformProperty("s3_backup_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3BackupMode { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformProperty("username")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Username { get; set; }

}

/// <summary>
/// Block type for server_side_encryption in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisFirehoseDeliveryStreamServerSideEncryptionBlock() : TerraformBlock("server_side_encryption")
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    [TerraformProperty("key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyArn { get; set; }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [TerraformProperty("key_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyType { get; set; }

}

/// <summary>
/// Block type for snowflake_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock() : TerraformBlock("snowflake_configuration")
{
    /// <summary>
    /// The account_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountUrl is required")]
    [TerraformProperty("account_url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountUrl { get; set; }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformProperty("buffering_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformProperty("buffering_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The content_column_name attribute.
    /// </summary>
    [TerraformProperty("content_column_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentColumnName { get; set; }

    /// <summary>
    /// The data_loading_option attribute.
    /// </summary>
    [TerraformProperty("data_loading_option")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataLoadingOption { get; set; }

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformProperty("database")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Database { get; set; }

    /// <summary>
    /// The key_passphrase attribute.
    /// </summary>
    [TerraformProperty("key_passphrase")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyPassphrase { get; set; }

    /// <summary>
    /// The metadata_column_name attribute.
    /// </summary>
    [TerraformProperty("metadata_column_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MetadataColumnName { get; set; }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformProperty("private_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateKey { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformProperty("retry_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformProperty("s3_backup_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3BackupMode { get; set; }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    [TerraformProperty("schema")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Schema { get; set; }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    [TerraformProperty("table")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Table { get; set; }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [TerraformProperty("user")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? User { get; set; }

}

/// <summary>
/// Block type for splunk_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock() : TerraformBlock("splunk_configuration")
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformProperty("buffering_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformProperty("buffering_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The hec_acknowledgment_timeout attribute.
    /// </summary>
    [TerraformProperty("hec_acknowledgment_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HecAcknowledgmentTimeout { get; set; }

    /// <summary>
    /// The hec_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HecEndpoint is required")]
    [TerraformProperty("hec_endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HecEndpoint { get; set; }

    /// <summary>
    /// The hec_endpoint_type attribute.
    /// </summary>
    [TerraformProperty("hec_endpoint_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HecEndpointType { get; set; }

    /// <summary>
    /// The hec_token attribute.
    /// </summary>
    [TerraformProperty("hec_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HecToken { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformProperty("retry_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformProperty("s3_backup_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3BackupMode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsKinesisFirehoseDeliveryStreamTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a aws_kinesis_firehose_delivery_stream resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsKinesisFirehoseDeliveryStream : TerraformResource
{
    public AwsKinesisFirehoseDeliveryStream(string name) : base("aws_kinesis_firehose_delivery_stream", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [TerraformProperty("destination")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Destination { get; set; }

    /// <summary>
    /// The destination_id attribute.
    /// </summary>
    [TerraformProperty("destination_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DestinationId { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

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
    /// The version_id attribute.
    /// </summary>
    [TerraformProperty("version_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VersionId { get; set; }

    /// <summary>
    /// Block for elasticsearch_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchConfiguration block(s) allowed")]
    [TerraformProperty("elasticsearch_configuration")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock> ElasticsearchConfiguration { get; set; } = new();

    /// <summary>
    /// Block for extended_s3_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExtendedS3Configuration block(s) allowed")]
    [TerraformProperty("extended_s3_configuration")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock> ExtendedS3Configuration { get; set; } = new();

    /// <summary>
    /// Block for http_endpoint_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpEndpointConfiguration block(s) allowed")]
    [TerraformProperty("http_endpoint_configuration")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock> HttpEndpointConfiguration { get; set; } = new();

    /// <summary>
    /// Block for iceberg_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IcebergConfiguration block(s) allowed")]
    [TerraformProperty("iceberg_configuration")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock> IcebergConfiguration { get; set; } = new();

    /// <summary>
    /// Block for kinesis_source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisSourceConfiguration block(s) allowed")]
    [TerraformProperty("kinesis_source_configuration")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamKinesisSourceConfigurationBlock> KinesisSourceConfiguration { get; set; } = new();

    /// <summary>
    /// Block for msk_source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MskSourceConfiguration block(s) allowed")]
    [TerraformProperty("msk_source_configuration")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlock> MskSourceConfiguration { get; set; } = new();

    /// <summary>
    /// Block for opensearch_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchConfiguration block(s) allowed")]
    [TerraformProperty("opensearch_configuration")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock> OpensearchConfiguration { get; set; } = new();

    /// <summary>
    /// Block for opensearchserverless_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchserverlessConfiguration block(s) allowed")]
    [TerraformProperty("opensearchserverless_configuration")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock> OpensearchserverlessConfiguration { get; set; } = new();

    /// <summary>
    /// Block for redshift_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftConfiguration block(s) allowed")]
    [TerraformProperty("redshift_configuration")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock> RedshiftConfiguration { get; set; } = new();

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    [TerraformProperty("server_side_encryption")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamServerSideEncryptionBlock> ServerSideEncryption { get; set; } = new();

    /// <summary>
    /// Block for snowflake_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnowflakeConfiguration block(s) allowed")]
    [TerraformProperty("snowflake_configuration")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock> SnowflakeConfiguration { get; set; } = new();

    /// <summary>
    /// Block for splunk_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SplunkConfiguration block(s) allowed")]
    [TerraformProperty("splunk_configuration")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock> SplunkConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsKinesisFirehoseDeliveryStreamTimeoutsBlock Timeouts { get; set; } = new();

}
