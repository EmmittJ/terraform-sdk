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
        set => SetProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        set => SetProperty("buffering_size", value);
    }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterEndpoint
    {
        set => SetProperty("cluster_endpoint", value);
    }

    /// <summary>
    /// The domain_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DomainArn
    {
        set => SetProperty("domain_arn", value);
    }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    public required TerraformProperty<string> IndexName
    {
        set => SetProperty("index_name", value);
    }

    /// <summary>
    /// The index_rotation_period attribute.
    /// </summary>
    public TerraformProperty<string>? IndexRotationPeriod
    {
        set => SetProperty("index_rotation_period", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        set => SetProperty("retry_duration", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        set => SetProperty("s3_backup_mode", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformProperty<string>? TypeName
    {
        set => SetProperty("type_name", value);
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
        set => SetProperty("bucket_arn", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingInterval
    {
        set => SetProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        set => SetProperty("buffering_size", value);
    }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    public TerraformProperty<string>? CompressionFormat
    {
        set => SetProperty("compression_format", value);
    }

    /// <summary>
    /// The custom_time_zone attribute.
    /// </summary>
    public TerraformProperty<string>? CustomTimeZone
    {
        set => SetProperty("custom_time_zone", value);
    }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? ErrorOutputPrefix
    {
        set => SetProperty("error_output_prefix", value);
    }

    /// <summary>
    /// The file_extension attribute.
    /// </summary>
    public TerraformProperty<string>? FileExtension
    {
        set => SetProperty("file_extension", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        set => SetProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string>? Prefix
    {
        set => SetProperty("prefix", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        set => SetProperty("s3_backup_mode", value);
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
        set => SetProperty("access_key", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingInterval
    {
        set => SetProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        set => SetProperty("buffering_size", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        set => SetProperty("retry_duration", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        set => SetProperty("s3_backup_mode", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        set => SetProperty("url", value);
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
        set => SetProperty("append_only", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingInterval
    {
        set => SetProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        set => SetProperty("buffering_size", value);
    }

    /// <summary>
    /// The catalog_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogArn is required")]
    public required TerraformProperty<string> CatalogArn
    {
        set => SetProperty("catalog_arn", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        set => SetProperty("retry_duration", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        set => SetProperty("s3_backup_mode", value);
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
        set => SetProperty("kinesis_stream_arn", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
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
        set => SetProperty("msk_cluster_arn", value);
    }

    /// <summary>
    /// The read_from_timestamp attribute.
    /// </summary>
    public TerraformProperty<string>? ReadFromTimestamp
    {
        set => SetProperty("read_from_timestamp", value);
    }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicName is required")]
    public required TerraformProperty<string> TopicName
    {
        set => SetProperty("topic_name", value);
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
        set => SetProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        set => SetProperty("buffering_size", value);
    }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterEndpoint
    {
        set => SetProperty("cluster_endpoint", value);
    }

    /// <summary>
    /// The domain_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DomainArn
    {
        set => SetProperty("domain_arn", value);
    }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    public required TerraformProperty<string> IndexName
    {
        set => SetProperty("index_name", value);
    }

    /// <summary>
    /// The index_rotation_period attribute.
    /// </summary>
    public TerraformProperty<string>? IndexRotationPeriod
    {
        set => SetProperty("index_rotation_period", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        set => SetProperty("retry_duration", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        set => SetProperty("s3_backup_mode", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformProperty<string>? TypeName
    {
        set => SetProperty("type_name", value);
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
        set => SetProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        set => SetProperty("buffering_size", value);
    }

    /// <summary>
    /// The collection_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionEndpoint is required")]
    public required TerraformProperty<string> CollectionEndpoint
    {
        set => SetProperty("collection_endpoint", value);
    }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    public required TerraformProperty<string> IndexName
    {
        set => SetProperty("index_name", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        set => SetProperty("retry_duration", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        set => SetProperty("s3_backup_mode", value);
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
        set => SetProperty("cluster_jdbcurl", value);
    }

    /// <summary>
    /// The copy_options attribute.
    /// </summary>
    public TerraformProperty<string>? CopyOptions
    {
        set => SetProperty("copy_options", value);
    }

    /// <summary>
    /// The data_table_columns attribute.
    /// </summary>
    public TerraformProperty<string>? DataTableColumns
    {
        set => SetProperty("data_table_columns", value);
    }

    /// <summary>
    /// The data_table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataTableName is required")]
    public required TerraformProperty<string> DataTableName
    {
        set => SetProperty("data_table_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        set => SetProperty("retry_duration", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        set => SetProperty("s3_backup_mode", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        set => SetProperty("username", value);
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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KeyArn
    {
        set => SetProperty("key_arn", value);
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public TerraformProperty<string>? KeyType
    {
        set => SetProperty("key_type", value);
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
        set => SetProperty("account_url", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingInterval
    {
        set => SetProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        set => SetProperty("buffering_size", value);
    }

    /// <summary>
    /// The content_column_name attribute.
    /// </summary>
    public TerraformProperty<string>? ContentColumnName
    {
        set => SetProperty("content_column_name", value);
    }

    /// <summary>
    /// The data_loading_option attribute.
    /// </summary>
    public TerraformProperty<string>? DataLoadingOption
    {
        set => SetProperty("data_loading_option", value);
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformProperty<string> Database
    {
        set => SetProperty("database", value);
    }

    /// <summary>
    /// The key_passphrase attribute.
    /// </summary>
    public TerraformProperty<string>? KeyPassphrase
    {
        set => SetProperty("key_passphrase", value);
    }

    /// <summary>
    /// The metadata_column_name attribute.
    /// </summary>
    public TerraformProperty<string>? MetadataColumnName
    {
        set => SetProperty("metadata_column_name", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateKey
    {
        set => SetProperty("private_key", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        set => SetProperty("retry_duration", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        set => SetProperty("s3_backup_mode", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformProperty<string> Schema
    {
        set => SetProperty("schema", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformProperty<string> Table
    {
        set => SetProperty("table", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    public TerraformProperty<string>? User
    {
        set => SetProperty("user", value);
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
        set => SetProperty("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformProperty<double>? BufferingSize
    {
        set => SetProperty("buffering_size", value);
    }

    /// <summary>
    /// The hec_acknowledgment_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? HecAcknowledgmentTimeout
    {
        set => SetProperty("hec_acknowledgment_timeout", value);
    }

    /// <summary>
    /// The hec_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HecEndpoint is required")]
    public required TerraformProperty<string> HecEndpoint
    {
        set => SetProperty("hec_endpoint", value);
    }

    /// <summary>
    /// The hec_endpoint_type attribute.
    /// </summary>
    public TerraformProperty<string>? HecEndpointType
    {
        set => SetProperty("hec_endpoint_type", value);
    }

    /// <summary>
    /// The hec_token attribute.
    /// </summary>
    public TerraformProperty<string>? HecToken
    {
        set => SetProperty("hec_token", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? RetryDuration
    {
        set => SetProperty("retry_duration", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformProperty<string>? S3BackupMode
    {
        set => SetProperty("s3_backup_mode", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("destination");
        SetOutput("destination_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("version_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformProperty<string> Destination
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination");
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// The destination_id attribute.
    /// </summary>
    public TerraformProperty<string> DestinationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_id");
        set => SetProperty("destination_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The version_id attribute.
    /// </summary>
    public TerraformProperty<string> VersionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_id");
        set => SetProperty("version_id", value);
    }

    /// <summary>
    /// Block for elasticsearch_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock>? ElasticsearchConfiguration
    {
        set => SetProperty("elasticsearch_configuration", value);
    }

    /// <summary>
    /// Block for extended_s3_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExtendedS3Configuration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock>? ExtendedS3Configuration
    {
        set => SetProperty("extended_s3_configuration", value);
    }

    /// <summary>
    /// Block for http_endpoint_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpEndpointConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock>? HttpEndpointConfiguration
    {
        set => SetProperty("http_endpoint_configuration", value);
    }

    /// <summary>
    /// Block for iceberg_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IcebergConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock>? IcebergConfiguration
    {
        set => SetProperty("iceberg_configuration", value);
    }

    /// <summary>
    /// Block for kinesis_source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisSourceConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamKinesisSourceConfigurationBlock>? KinesisSourceConfiguration
    {
        set => SetProperty("kinesis_source_configuration", value);
    }

    /// <summary>
    /// Block for msk_source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MskSourceConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlock>? MskSourceConfiguration
    {
        set => SetProperty("msk_source_configuration", value);
    }

    /// <summary>
    /// Block for opensearch_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock>? OpensearchConfiguration
    {
        set => SetProperty("opensearch_configuration", value);
    }

    /// <summary>
    /// Block for opensearchserverless_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchserverlessConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock>? OpensearchserverlessConfiguration
    {
        set => SetProperty("opensearchserverless_configuration", value);
    }

    /// <summary>
    /// Block for redshift_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock>? RedshiftConfiguration
    {
        set => SetProperty("redshift_configuration", value);
    }

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamServerSideEncryptionBlock>? ServerSideEncryption
    {
        set => SetProperty("server_side_encryption", value);
    }

    /// <summary>
    /// Block for snowflake_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnowflakeConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock>? SnowflakeConfiguration
    {
        set => SetProperty("snowflake_configuration", value);
    }

    /// <summary>
    /// Block for splunk_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SplunkConfiguration block(s) allowed")]
    public List<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock>? SplunkConfiguration
    {
        set => SetProperty("splunk_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsKinesisFirehoseDeliveryStreamTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
