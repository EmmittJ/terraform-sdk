using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for elasticsearch_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("cluster_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClusterEndpoint { get; set; }

    /// <summary>
    /// The domain_arn attribute.
    /// </summary>
    [TerraformPropertyName("domain_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DomainArn { get; set; }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    [TerraformPropertyName("index_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IndexName { get; set; }

    /// <summary>
    /// The index_rotation_period attribute.
    /// </summary>
    [TerraformPropertyName("index_rotation_period")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IndexRotationPeriod { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3BackupMode { get; set; }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [TerraformPropertyName("type_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TypeName { get; set; }

}

/// <summary>
/// Block type for extended_s3_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock
{
    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    [TerraformPropertyName("bucket_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BucketArn { get; set; }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    [TerraformPropertyName("compression_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CompressionFormat { get; set; }

    /// <summary>
    /// The custom_time_zone attribute.
    /// </summary>
    [TerraformPropertyName("custom_time_zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomTimeZone { get; set; }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    [TerraformPropertyName("error_output_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ErrorOutputPrefix { get; set; }

    /// <summary>
    /// The file_extension attribute.
    /// </summary>
    [TerraformPropertyName("file_extension")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FileExtension { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformPropertyName("prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Prefix { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3BackupMode { get; set; }

}

/// <summary>
/// Block type for http_endpoint_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock
{
    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [TerraformPropertyName("access_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccessKey { get; set; }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3BackupMode { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for iceberg_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock
{
    /// <summary>
    /// The append_only attribute.
    /// </summary>
    [TerraformPropertyName("append_only")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> AppendOnly { get; set; } = default!;

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The catalog_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogArn is required")]
    [TerraformPropertyName("catalog_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CatalogArn { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3BackupMode { get; set; }

}

/// <summary>
/// Block type for kinesis_source_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamKinesisSourceConfigurationBlock
{
    /// <summary>
    /// The kinesis_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KinesisStreamArn is required")]
    [TerraformPropertyName("kinesis_stream_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KinesisStreamArn { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Block type for msk_source_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlock
{
    /// <summary>
    /// The msk_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MskClusterArn is required")]
    [TerraformPropertyName("msk_cluster_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MskClusterArn { get; set; }

    /// <summary>
    /// The read_from_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("read_from_timestamp")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReadFromTimestamp { get; set; }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicName is required")]
    [TerraformPropertyName("topic_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TopicName { get; set; }

}

/// <summary>
/// Block type for opensearch_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("cluster_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClusterEndpoint { get; set; }

    /// <summary>
    /// The domain_arn attribute.
    /// </summary>
    [TerraformPropertyName("domain_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DomainArn { get; set; }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    [TerraformPropertyName("index_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IndexName { get; set; }

    /// <summary>
    /// The index_rotation_period attribute.
    /// </summary>
    [TerraformPropertyName("index_rotation_period")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IndexRotationPeriod { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3BackupMode { get; set; }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [TerraformPropertyName("type_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TypeName { get; set; }

}

/// <summary>
/// Block type for opensearchserverless_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The collection_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionEndpoint is required")]
    [TerraformPropertyName("collection_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CollectionEndpoint { get; set; }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    [TerraformPropertyName("index_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IndexName { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3BackupMode { get; set; }

}

/// <summary>
/// Block type for redshift_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock
{
    /// <summary>
    /// The cluster_jdbcurl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterJdbcurl is required")]
    [TerraformPropertyName("cluster_jdbcurl")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterJdbcurl { get; set; }

    /// <summary>
    /// The copy_options attribute.
    /// </summary>
    [TerraformPropertyName("copy_options")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CopyOptions { get; set; }

    /// <summary>
    /// The data_table_columns attribute.
    /// </summary>
    [TerraformPropertyName("data_table_columns")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DataTableColumns { get; set; }

    /// <summary>
    /// The data_table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataTableName is required")]
    [TerraformPropertyName("data_table_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DataTableName { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3BackupMode { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformPropertyName("username")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Username { get; set; }

}

/// <summary>
/// Block type for server_side_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamServerSideEncryptionBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    [TerraformPropertyName("key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyArn { get; set; }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [TerraformPropertyName("key_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyType { get; set; }

}

/// <summary>
/// Block type for snowflake_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock
{
    /// <summary>
    /// The account_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountUrl is required")]
    [TerraformPropertyName("account_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountUrl { get; set; }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The content_column_name attribute.
    /// </summary>
    [TerraformPropertyName("content_column_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentColumnName { get; set; }

    /// <summary>
    /// The data_loading_option attribute.
    /// </summary>
    [TerraformPropertyName("data_loading_option")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DataLoadingOption { get; set; }

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformPropertyName("database")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Database { get; set; }

    /// <summary>
    /// The key_passphrase attribute.
    /// </summary>
    [TerraformPropertyName("key_passphrase")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyPassphrase { get; set; }

    /// <summary>
    /// The metadata_column_name attribute.
    /// </summary>
    [TerraformPropertyName("metadata_column_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MetadataColumnName { get; set; }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformPropertyName("private_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateKey { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3BackupMode { get; set; }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    [TerraformPropertyName("schema")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Schema { get; set; }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    [TerraformPropertyName("table")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Table { get; set; }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [TerraformPropertyName("user")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? User { get; set; }

}

/// <summary>
/// Block type for splunk_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BufferingSize { get; set; }

    /// <summary>
    /// The hec_acknowledgment_timeout attribute.
    /// </summary>
    [TerraformPropertyName("hec_acknowledgment_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? HecAcknowledgmentTimeout { get; set; }

    /// <summary>
    /// The hec_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HecEndpoint is required")]
    [TerraformPropertyName("hec_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HecEndpoint { get; set; }

    /// <summary>
    /// The hec_endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("hec_endpoint_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HecEndpointType { get; set; }

    /// <summary>
    /// The hec_token attribute.
    /// </summary>
    [TerraformPropertyName("hec_token")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HecToken { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetryDuration { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3BackupMode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_kinesis_firehose_delivery_stream resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsKinesisFirehoseDeliveryStream : TerraformResource
{
    public AwsKinesisFirehoseDeliveryStream(string name) : base("aws_kinesis_firehose_delivery_stream", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Arn { get; set; } = default!;

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [TerraformPropertyName("destination")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Destination { get; set; }

    /// <summary>
    /// The destination_id attribute.
    /// </summary>
    [TerraformPropertyName("destination_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DestinationId { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VersionId { get; set; } = default!;

    /// <summary>
    /// Block for elasticsearch_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchConfiguration block(s) allowed")]
    [TerraformPropertyName("elasticsearch_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock>>? ElasticsearchConfiguration { get; set; }

    /// <summary>
    /// Block for extended_s3_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExtendedS3Configuration block(s) allowed")]
    [TerraformPropertyName("extended_s3_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock>>? ExtendedS3Configuration { get; set; }

    /// <summary>
    /// Block for http_endpoint_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpEndpointConfiguration block(s) allowed")]
    [TerraformPropertyName("http_endpoint_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock>>? HttpEndpointConfiguration { get; set; }

    /// <summary>
    /// Block for iceberg_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IcebergConfiguration block(s) allowed")]
    [TerraformPropertyName("iceberg_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock>>? IcebergConfiguration { get; set; }

    /// <summary>
    /// Block for kinesis_source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisSourceConfiguration block(s) allowed")]
    [TerraformPropertyName("kinesis_source_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamKinesisSourceConfigurationBlock>>? KinesisSourceConfiguration { get; set; }

    /// <summary>
    /// Block for msk_source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MskSourceConfiguration block(s) allowed")]
    [TerraformPropertyName("msk_source_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlock>>? MskSourceConfiguration { get; set; }

    /// <summary>
    /// Block for opensearch_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchConfiguration block(s) allowed")]
    [TerraformPropertyName("opensearch_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock>>? OpensearchConfiguration { get; set; }

    /// <summary>
    /// Block for opensearchserverless_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchserverlessConfiguration block(s) allowed")]
    [TerraformPropertyName("opensearchserverless_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock>>? OpensearchserverlessConfiguration { get; set; }

    /// <summary>
    /// Block for redshift_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftConfiguration block(s) allowed")]
    [TerraformPropertyName("redshift_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock>>? RedshiftConfiguration { get; set; }

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    [TerraformPropertyName("server_side_encryption")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamServerSideEncryptionBlock>>? ServerSideEncryption { get; set; }

    /// <summary>
    /// Block for snowflake_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnowflakeConfiguration block(s) allowed")]
    [TerraformPropertyName("snowflake_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock>>? SnowflakeConfiguration { get; set; }

    /// <summary>
    /// Block for splunk_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SplunkConfiguration block(s) allowed")]
    [TerraformPropertyName("splunk_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock>>? SplunkConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsKinesisFirehoseDeliveryStreamTimeoutsBlock>? Timeouts { get; set; }

}
