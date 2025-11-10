using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for elasticsearch_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingInterval
    {
        get => GetProperty<TerraformProperty<double>>("buffering_interval");
        set => WithProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        get => GetProperty<TerraformProperty<double>>("buffering_size");
        set => WithProperty("buffering_size", value);
    }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cluster_endpoint");
        set => WithProperty("cluster_endpoint", value);
    }

    /// <summary>
    /// The domain_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DomainArn
    {
        get => GetProperty<TerraformProperty<string>>("domain_arn");
        set => WithProperty("domain_arn", value);
    }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    public required TerraformProperty<string> IndexName
    {
        get => GetProperty<TerraformProperty<string>>("index_name");
        set => WithProperty("index_name", value);
    }

    /// <summary>
    /// The index_rotation_period attribute.
    /// </summary>
    public TerraformProperty<string>? IndexRotationPeriod
    {
        get => GetProperty<TerraformProperty<string>>("index_rotation_period");
        set => WithProperty("index_rotation_period", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        get => GetProperty<TerraformProperty<double>>("retry_duration");
        set => WithProperty("retry_duration", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        get => GetProperty<TerraformProperty<string>>("s3_backup_mode");
        set => WithProperty("s3_backup_mode", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformProperty<string>? TypeName
    {
        get => GetProperty<TerraformProperty<string>>("type_name");
        set => WithProperty("type_name", value);
    }

}

/// <summary>
/// Block type for extended_s3_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformProperty<string> BucketArn
    {
        get => GetProperty<TerraformProperty<string>>("bucket_arn");
        set => WithProperty("bucket_arn", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingInterval
    {
        get => GetProperty<TerraformProperty<double>>("buffering_interval");
        set => WithProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        get => GetProperty<TerraformProperty<double>>("buffering_size");
        set => WithProperty("buffering_size", value);
    }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    public TerraformProperty<string>? CompressionFormat
    {
        get => GetProperty<TerraformProperty<string>>("compression_format");
        set => WithProperty("compression_format", value);
    }

    /// <summary>
    /// The custom_time_zone attribute.
    /// </summary>
    public TerraformProperty<string>? CustomTimeZone
    {
        get => GetProperty<TerraformProperty<string>>("custom_time_zone");
        set => WithProperty("custom_time_zone", value);
    }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? ErrorOutputPrefix
    {
        get => GetProperty<TerraformProperty<string>>("error_output_prefix");
        set => WithProperty("error_output_prefix", value);
    }

    /// <summary>
    /// The file_extension attribute.
    /// </summary>
    public TerraformProperty<string>? FileExtension
    {
        get => GetProperty<TerraformProperty<string>>("file_extension");
        set => WithProperty("file_extension", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string>? Prefix
    {
        get => GetProperty<TerraformProperty<string>>("prefix");
        set => WithProperty("prefix", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        get => GetProperty<TerraformProperty<string>>("s3_backup_mode");
        set => WithProperty("s3_backup_mode", value);
    }

}

/// <summary>
/// Block type for http_endpoint_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The access_key attribute.
    /// </summary>
    public TerraformProperty<string>? AccessKey
    {
        get => GetProperty<TerraformProperty<string>>("access_key");
        set => WithProperty("access_key", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingInterval
    {
        get => GetProperty<TerraformProperty<double>>("buffering_interval");
        set => WithProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        get => GetProperty<TerraformProperty<double>>("buffering_size");
        set => WithProperty("buffering_size", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        get => GetProperty<TerraformProperty<double>>("retry_duration");
        set => WithProperty("retry_duration", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        get => GetProperty<TerraformProperty<string>>("s3_backup_mode");
        set => WithProperty("s3_backup_mode", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
    }

}

/// <summary>
/// Block type for iceberg_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The append_only attribute.
    /// </summary>
    public TerraformProperty<bool>? AppendOnly
    {
        get => GetProperty<TerraformProperty<bool>>("append_only");
        set => WithProperty("append_only", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingInterval
    {
        get => GetProperty<TerraformProperty<double>>("buffering_interval");
        set => WithProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        get => GetProperty<TerraformProperty<double>>("buffering_size");
        set => WithProperty("buffering_size", value);
    }

    /// <summary>
    /// The catalog_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogArn is required")]
    public required TerraformProperty<string> CatalogArn
    {
        get => GetProperty<TerraformProperty<string>>("catalog_arn");
        set => WithProperty("catalog_arn", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        get => GetProperty<TerraformProperty<double>>("retry_duration");
        set => WithProperty("retry_duration", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        get => GetProperty<TerraformProperty<string>>("s3_backup_mode");
        set => WithProperty("s3_backup_mode", value);
    }

}

/// <summary>
/// Block type for kinesis_source_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamKinesisSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The kinesis_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KinesisStreamArn is required")]
    public required TerraformProperty<string> KinesisStreamArn
    {
        get => GetProperty<TerraformProperty<string>>("kinesis_stream_arn");
        set => WithProperty("kinesis_stream_arn", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

}

/// <summary>
/// Block type for msk_source_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The msk_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MskClusterArn is required")]
    public required TerraformProperty<string> MskClusterArn
    {
        get => GetProperty<TerraformProperty<string>>("msk_cluster_arn");
        set => WithProperty("msk_cluster_arn", value);
    }

    /// <summary>
    /// The read_from_timestamp attribute.
    /// </summary>
    public TerraformProperty<string>? ReadFromTimestamp
    {
        get => GetProperty<TerraformProperty<string>>("read_from_timestamp");
        set => WithProperty("read_from_timestamp", value);
    }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicName is required")]
    public required TerraformProperty<string> TopicName
    {
        get => GetProperty<TerraformProperty<string>>("topic_name");
        set => WithProperty("topic_name", value);
    }

}

/// <summary>
/// Block type for opensearch_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingInterval
    {
        get => GetProperty<TerraformProperty<double>>("buffering_interval");
        set => WithProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        get => GetProperty<TerraformProperty<double>>("buffering_size");
        set => WithProperty("buffering_size", value);
    }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("cluster_endpoint");
        set => WithProperty("cluster_endpoint", value);
    }

    /// <summary>
    /// The domain_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DomainArn
    {
        get => GetProperty<TerraformProperty<string>>("domain_arn");
        set => WithProperty("domain_arn", value);
    }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    public required TerraformProperty<string> IndexName
    {
        get => GetProperty<TerraformProperty<string>>("index_name");
        set => WithProperty("index_name", value);
    }

    /// <summary>
    /// The index_rotation_period attribute.
    /// </summary>
    public TerraformProperty<string>? IndexRotationPeriod
    {
        get => GetProperty<TerraformProperty<string>>("index_rotation_period");
        set => WithProperty("index_rotation_period", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        get => GetProperty<TerraformProperty<double>>("retry_duration");
        set => WithProperty("retry_duration", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        get => GetProperty<TerraformProperty<string>>("s3_backup_mode");
        set => WithProperty("s3_backup_mode", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformProperty<string>? TypeName
    {
        get => GetProperty<TerraformProperty<string>>("type_name");
        set => WithProperty("type_name", value);
    }

}

/// <summary>
/// Block type for opensearchserverless_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingInterval
    {
        get => GetProperty<TerraformProperty<double>>("buffering_interval");
        set => WithProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        get => GetProperty<TerraformProperty<double>>("buffering_size");
        set => WithProperty("buffering_size", value);
    }

    /// <summary>
    /// The collection_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionEndpoint is required")]
    public required TerraformProperty<string> CollectionEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("collection_endpoint");
        set => WithProperty("collection_endpoint", value);
    }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    public required TerraformProperty<string> IndexName
    {
        get => GetProperty<TerraformProperty<string>>("index_name");
        set => WithProperty("index_name", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        get => GetProperty<TerraformProperty<double>>("retry_duration");
        set => WithProperty("retry_duration", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        get => GetProperty<TerraformProperty<string>>("s3_backup_mode");
        set => WithProperty("s3_backup_mode", value);
    }

}

/// <summary>
/// Block type for redshift_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The cluster_jdbcurl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterJdbcurl is required")]
    public required TerraformProperty<string> ClusterJdbcurl
    {
        get => GetProperty<TerraformProperty<string>>("cluster_jdbcurl");
        set => WithProperty("cluster_jdbcurl", value);
    }

    /// <summary>
    /// The copy_options attribute.
    /// </summary>
    public TerraformProperty<string>? CopyOptions
    {
        get => GetProperty<TerraformProperty<string>>("copy_options");
        set => WithProperty("copy_options", value);
    }

    /// <summary>
    /// The data_table_columns attribute.
    /// </summary>
    public TerraformProperty<string>? DataTableColumns
    {
        get => GetProperty<TerraformProperty<string>>("data_table_columns");
        set => WithProperty("data_table_columns", value);
    }

    /// <summary>
    /// The data_table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataTableName is required")]
    public required TerraformProperty<string> DataTableName
    {
        get => GetProperty<TerraformProperty<string>>("data_table_name");
        set => WithProperty("data_table_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        get => GetProperty<TerraformProperty<double>>("retry_duration");
        set => WithProperty("retry_duration", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        get => GetProperty<TerraformProperty<string>>("s3_backup_mode");
        set => WithProperty("s3_backup_mode", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
    }

}

/// <summary>
/// Block type for server_side_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamServerSideEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KeyArn
    {
        get => GetProperty<TerraformProperty<string>>("key_arn");
        set => WithProperty("key_arn", value);
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public TerraformProperty<string>? KeyType
    {
        get => GetProperty<TerraformProperty<string>>("key_type");
        set => WithProperty("key_type", value);
    }

}

/// <summary>
/// Block type for snowflake_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The account_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountUrl is required")]
    public required TerraformProperty<string> AccountUrl
    {
        get => GetProperty<TerraformProperty<string>>("account_url");
        set => WithProperty("account_url", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingInterval
    {
        get => GetProperty<TerraformProperty<double>>("buffering_interval");
        set => WithProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        get => GetProperty<TerraformProperty<double>>("buffering_size");
        set => WithProperty("buffering_size", value);
    }

    /// <summary>
    /// The content_column_name attribute.
    /// </summary>
    public TerraformProperty<string>? ContentColumnName
    {
        get => GetProperty<TerraformProperty<string>>("content_column_name");
        set => WithProperty("content_column_name", value);
    }

    /// <summary>
    /// The data_loading_option attribute.
    /// </summary>
    public TerraformProperty<string>? DataLoadingOption
    {
        get => GetProperty<TerraformProperty<string>>("data_loading_option");
        set => WithProperty("data_loading_option", value);
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformProperty<string> Database
    {
        get => GetProperty<TerraformProperty<string>>("database");
        set => WithProperty("database", value);
    }

    /// <summary>
    /// The key_passphrase attribute.
    /// </summary>
    public TerraformProperty<string>? KeyPassphrase
    {
        get => GetProperty<TerraformProperty<string>>("key_passphrase");
        set => WithProperty("key_passphrase", value);
    }

    /// <summary>
    /// The metadata_column_name attribute.
    /// </summary>
    public TerraformProperty<string>? MetadataColumnName
    {
        get => GetProperty<TerraformProperty<string>>("metadata_column_name");
        set => WithProperty("metadata_column_name", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateKey
    {
        get => GetProperty<TerraformProperty<string>>("private_key");
        set => WithProperty("private_key", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        get => GetProperty<TerraformProperty<double>>("retry_duration");
        set => WithProperty("retry_duration", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        get => GetProperty<TerraformProperty<string>>("s3_backup_mode");
        set => WithProperty("s3_backup_mode", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformProperty<string> Schema
    {
        get => GetProperty<TerraformProperty<string>>("schema");
        set => WithProperty("schema", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformProperty<string> Table
    {
        get => GetProperty<TerraformProperty<string>>("table");
        set => WithProperty("table", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    public TerraformProperty<string>? User
    {
        get => GetProperty<TerraformProperty<string>>("user");
        set => WithProperty("user", value);
    }

}

/// <summary>
/// Block type for splunk_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingInterval
    {
        get => GetProperty<TerraformProperty<double>>("buffering_interval");
        set => WithProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        get => GetProperty<TerraformProperty<double>>("buffering_size");
        set => WithProperty("buffering_size", value);
    }

    /// <summary>
    /// The hec_acknowledgment_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? HecAcknowledgmentTimeout
    {
        get => GetProperty<TerraformProperty<double>>("hec_acknowledgment_timeout");
        set => WithProperty("hec_acknowledgment_timeout", value);
    }

    /// <summary>
    /// The hec_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HecEndpoint is required")]
    public required TerraformProperty<string> HecEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("hec_endpoint");
        set => WithProperty("hec_endpoint", value);
    }

    /// <summary>
    /// The hec_endpoint_type attribute.
    /// </summary>
    public TerraformProperty<string>? HecEndpointType
    {
        get => GetProperty<TerraformProperty<string>>("hec_endpoint_type");
        set => WithProperty("hec_endpoint_type", value);
    }

    /// <summary>
    /// The hec_token attribute.
    /// </summary>
    public TerraformProperty<string>? HecToken
    {
        get => GetProperty<TerraformProperty<string>>("hec_token");
        set => WithProperty("hec_token", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        get => GetProperty<TerraformProperty<double>>("retry_duration");
        set => WithProperty("retry_duration", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        get => GetProperty<TerraformProperty<string>>("s3_backup_mode");
        set => WithProperty("s3_backup_mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_kinesis_firehose_delivery_stream resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsKinesisFirehoseDeliveryStream : TerraformResource
{
    public AwsKinesisFirehoseDeliveryStream(string name) : base("aws_kinesis_firehose_delivery_stream", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformProperty<string> Destination
    {
        get => GetProperty<TerraformProperty<string>>("destination");
        set => this.WithProperty("destination", value);
    }

    /// <summary>
    /// The destination_id attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationId
    {
        get => GetProperty<TerraformProperty<string>>("destination_id");
        set => this.WithProperty("destination_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The version_id attribute.
    /// </summary>
    public TerraformProperty<string>? VersionId
    {
        get => GetProperty<TerraformProperty<string>>("version_id");
        set => this.WithProperty("version_id", value);
    }

    /// <summary>
    /// Block for elasticsearch_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock>? ElasticsearchConfiguration
    {
        get => GetProperty<List<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock>>("elasticsearch_configuration");
        set => this.WithProperty("elasticsearch_configuration", value);
    }

    /// <summary>
    /// Block for extended_s3_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExtendedS3Configuration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock>? ExtendedS3Configuration
    {
        get => GetProperty<List<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock>>("extended_s3_configuration");
        set => this.WithProperty("extended_s3_configuration", value);
    }

    /// <summary>
    /// Block for http_endpoint_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpEndpointConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock>? HttpEndpointConfiguration
    {
        get => GetProperty<List<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock>>("http_endpoint_configuration");
        set => this.WithProperty("http_endpoint_configuration", value);
    }

    /// <summary>
    /// Block for iceberg_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IcebergConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock>? IcebergConfiguration
    {
        get => GetProperty<List<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock>>("iceberg_configuration");
        set => this.WithProperty("iceberg_configuration", value);
    }

    /// <summary>
    /// Block for kinesis_source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisSourceConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamKinesisSourceConfigurationBlock>? KinesisSourceConfiguration
    {
        get => GetProperty<List<AwsKinesisFirehoseDeliveryStreamKinesisSourceConfigurationBlock>>("kinesis_source_configuration");
        set => this.WithProperty("kinesis_source_configuration", value);
    }

    /// <summary>
    /// Block for msk_source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MskSourceConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlock>? MskSourceConfiguration
    {
        get => GetProperty<List<AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlock>>("msk_source_configuration");
        set => this.WithProperty("msk_source_configuration", value);
    }

    /// <summary>
    /// Block for opensearch_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock>? OpensearchConfiguration
    {
        get => GetProperty<List<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock>>("opensearch_configuration");
        set => this.WithProperty("opensearch_configuration", value);
    }

    /// <summary>
    /// Block for opensearchserverless_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchserverlessConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock>? OpensearchserverlessConfiguration
    {
        get => GetProperty<List<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock>>("opensearchserverless_configuration");
        set => this.WithProperty("opensearchserverless_configuration", value);
    }

    /// <summary>
    /// Block for redshift_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock>? RedshiftConfiguration
    {
        get => GetProperty<List<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock>>("redshift_configuration");
        set => this.WithProperty("redshift_configuration", value);
    }

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamServerSideEncryptionBlock>? ServerSideEncryption
    {
        get => GetProperty<List<AwsKinesisFirehoseDeliveryStreamServerSideEncryptionBlock>>("server_side_encryption");
        set => this.WithProperty("server_side_encryption", value);
    }

    /// <summary>
    /// Block for snowflake_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnowflakeConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock>? SnowflakeConfiguration
    {
        get => GetProperty<List<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock>>("snowflake_configuration");
        set => this.WithProperty("snowflake_configuration", value);
    }

    /// <summary>
    /// Block for splunk_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SplunkConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock>? SplunkConfiguration
    {
        get => GetProperty<List<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock>>("splunk_configuration");
        set => this.WithProperty("splunk_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsKinesisFirehoseDeliveryStreamTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsKinesisFirehoseDeliveryStreamTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
