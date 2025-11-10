using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for elasticsearch_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingSize { get; set; }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("cluster_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClusterEndpoint { get; set; }

    /// <summary>
    /// The domain_arn attribute.
    /// </summary>
    [TerraformPropertyName("domain_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DomainArn { get; set; }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    [TerraformPropertyName("index_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IndexName { get; set; }

    /// <summary>
    /// The index_rotation_period attribute.
    /// </summary>
    [TerraformPropertyName("index_rotation_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IndexRotationPeriod { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3BackupMode { get; set; }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [TerraformPropertyName("type_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TypeName { get; set; }

}

/// <summary>
/// Block type for extended_s3_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    [TerraformPropertyName("bucket_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BucketArn { get; set; }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingSize { get; set; }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    [TerraformPropertyName("compression_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CompressionFormat { get; set; }

    /// <summary>
    /// The custom_time_zone attribute.
    /// </summary>
    [TerraformPropertyName("custom_time_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomTimeZone { get; set; }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    [TerraformPropertyName("error_output_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ErrorOutputPrefix { get; set; }

    /// <summary>
    /// The file_extension attribute.
    /// </summary>
    [TerraformPropertyName("file_extension")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FileExtension { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyArn { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformPropertyName("prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Prefix { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3BackupMode { get; set; }

}

/// <summary>
/// Block type for http_endpoint_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [TerraformPropertyName("access_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AccessKey { get; set; }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingSize { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3BackupMode { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Url { get; set; }

}

/// <summary>
/// Block type for iceberg_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The append_only attribute.
    /// </summary>
    [TerraformPropertyName("append_only")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AppendOnly { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "append_only");

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingSize { get; set; }

    /// <summary>
    /// The catalog_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogArn is required")]
    [TerraformPropertyName("catalog_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CatalogArn { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3BackupMode { get; set; }

}

/// <summary>
/// Block type for kinesis_source_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamKinesisSourceConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The kinesis_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KinesisStreamArn is required")]
    [TerraformPropertyName("kinesis_stream_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KinesisStreamArn { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

}

/// <summary>
/// Block type for msk_source_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The msk_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MskClusterArn is required")]
    [TerraformPropertyName("msk_cluster_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MskClusterArn { get; set; }

    /// <summary>
    /// The read_from_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("read_from_timestamp")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReadFromTimestamp { get; set; }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicName is required")]
    [TerraformPropertyName("topic_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TopicName { get; set; }

}

/// <summary>
/// Block type for opensearch_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingSize { get; set; }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("cluster_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClusterEndpoint { get; set; }

    /// <summary>
    /// The domain_arn attribute.
    /// </summary>
    [TerraformPropertyName("domain_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DomainArn { get; set; }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    [TerraformPropertyName("index_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IndexName { get; set; }

    /// <summary>
    /// The index_rotation_period attribute.
    /// </summary>
    [TerraformPropertyName("index_rotation_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IndexRotationPeriod { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3BackupMode { get; set; }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [TerraformPropertyName("type_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TypeName { get; set; }

}

/// <summary>
/// Block type for opensearchserverless_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingSize { get; set; }

    /// <summary>
    /// The collection_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionEndpoint is required")]
    [TerraformPropertyName("collection_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CollectionEndpoint { get; set; }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    [TerraformPropertyName("index_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IndexName { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3BackupMode { get; set; }

}

/// <summary>
/// Block type for redshift_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The cluster_jdbcurl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterJdbcurl is required")]
    [TerraformPropertyName("cluster_jdbcurl")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterJdbcurl { get; set; }

    /// <summary>
    /// The copy_options attribute.
    /// </summary>
    [TerraformPropertyName("copy_options")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CopyOptions { get; set; }

    /// <summary>
    /// The data_table_columns attribute.
    /// </summary>
    [TerraformPropertyName("data_table_columns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataTableColumns { get; set; }

    /// <summary>
    /// The data_table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataTableName is required")]
    [TerraformPropertyName("data_table_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataTableName { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3BackupMode { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformPropertyName("username")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Username { get; set; }

}

/// <summary>
/// Block type for server_side_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamServerSideEncryptionBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    [TerraformPropertyName("key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyArn { get; set; }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [TerraformPropertyName("key_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyType { get; set; }

}

/// <summary>
/// Block type for snowflake_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The account_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountUrl is required")]
    [TerraformPropertyName("account_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccountUrl { get; set; }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingSize { get; set; }

    /// <summary>
    /// The content_column_name attribute.
    /// </summary>
    [TerraformPropertyName("content_column_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContentColumnName { get; set; }

    /// <summary>
    /// The data_loading_option attribute.
    /// </summary>
    [TerraformPropertyName("data_loading_option")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataLoadingOption { get; set; }

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformPropertyName("database")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Database { get; set; }

    /// <summary>
    /// The key_passphrase attribute.
    /// </summary>
    [TerraformPropertyName("key_passphrase")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyPassphrase { get; set; }

    /// <summary>
    /// The metadata_column_name attribute.
    /// </summary>
    [TerraformPropertyName("metadata_column_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MetadataColumnName { get; set; }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformPropertyName("private_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateKey { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetryDuration { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3BackupMode { get; set; }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    [TerraformPropertyName("schema")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Schema { get; set; }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    [TerraformPropertyName("table")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Table { get; set; }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [TerraformPropertyName("user")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? User { get; set; }

}

/// <summary>
/// Block type for splunk_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    [TerraformPropertyName("buffering_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingInterval { get; set; }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    [TerraformPropertyName("buffering_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BufferingSize { get; set; }

    /// <summary>
    /// The hec_acknowledgment_timeout attribute.
    /// </summary>
    [TerraformPropertyName("hec_acknowledgment_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HecAcknowledgmentTimeout { get; set; }

    /// <summary>
    /// The hec_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HecEndpoint is required")]
    [TerraformPropertyName("hec_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HecEndpoint { get; set; }

    /// <summary>
    /// The hec_endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("hec_endpoint_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HecEndpointType { get; set; }

    /// <summary>
    /// The hec_token attribute.
    /// </summary>
    [TerraformPropertyName("hec_token")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HecToken { get; set; }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetryDuration { get; set; }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    [TerraformPropertyName("s3_backup_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3BackupMode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamTimeoutsBlock : ITerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Arn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [TerraformPropertyName("destination")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Destination { get; set; }

    /// <summary>
    /// The destination_id attribute.
    /// </summary>
    [TerraformPropertyName("destination_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DestinationId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "destination_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

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
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VersionId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_id");

    /// <summary>
    /// Block for elasticsearch_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchConfiguration block(s) allowed")]
    [TerraformPropertyName("elasticsearch_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock>>? ElasticsearchConfiguration { get; set; } = new();

    /// <summary>
    /// Block for extended_s3_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExtendedS3Configuration block(s) allowed")]
    [TerraformPropertyName("extended_s3_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock>>? ExtendedS3Configuration { get; set; } = new();

    /// <summary>
    /// Block for http_endpoint_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpEndpointConfiguration block(s) allowed")]
    [TerraformPropertyName("http_endpoint_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock>>? HttpEndpointConfiguration { get; set; } = new();

    /// <summary>
    /// Block for iceberg_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IcebergConfiguration block(s) allowed")]
    [TerraformPropertyName("iceberg_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock>>? IcebergConfiguration { get; set; } = new();

    /// <summary>
    /// Block for kinesis_source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisSourceConfiguration block(s) allowed")]
    [TerraformPropertyName("kinesis_source_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamKinesisSourceConfigurationBlock>>? KinesisSourceConfiguration { get; set; } = new();

    /// <summary>
    /// Block for msk_source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MskSourceConfiguration block(s) allowed")]
    [TerraformPropertyName("msk_source_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlock>>? MskSourceConfiguration { get; set; } = new();

    /// <summary>
    /// Block for opensearch_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchConfiguration block(s) allowed")]
    [TerraformPropertyName("opensearch_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock>>? OpensearchConfiguration { get; set; } = new();

    /// <summary>
    /// Block for opensearchserverless_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchserverlessConfiguration block(s) allowed")]
    [TerraformPropertyName("opensearchserverless_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock>>? OpensearchserverlessConfiguration { get; set; } = new();

    /// <summary>
    /// Block for redshift_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftConfiguration block(s) allowed")]
    [TerraformPropertyName("redshift_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock>>? RedshiftConfiguration { get; set; } = new();

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    [TerraformPropertyName("server_side_encryption")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamServerSideEncryptionBlock>>? ServerSideEncryption { get; set; } = new();

    /// <summary>
    /// Block for snowflake_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnowflakeConfiguration block(s) allowed")]
    [TerraformPropertyName("snowflake_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock>>? SnowflakeConfiguration { get; set; } = new();

    /// <summary>
    /// Block for splunk_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SplunkConfiguration block(s) allowed")]
    [TerraformPropertyName("splunk_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock>>? SplunkConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsKinesisFirehoseDeliveryStreamTimeoutsBlock>? Timeouts { get; set; } = new();

}
