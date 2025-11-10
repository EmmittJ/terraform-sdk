using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for elasticsearch_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointElasticsearchSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointUri is required")]
    public required TerraformProperty<string> EndpointUri
    {
        set => SetProperty("endpoint_uri", value);
    }

    /// <summary>
    /// The error_retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? ErrorRetryDuration
    {
        set => SetProperty("error_retry_duration", value);
    }

    /// <summary>
    /// The full_load_error_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? FullLoadErrorPercentage
    {
        set => SetProperty("full_load_error_percentage", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccessRoleArn is required")]
    public required TerraformProperty<string> ServiceAccessRoleArn
    {
        set => SetProperty("service_access_role_arn", value);
    }

    /// <summary>
    /// The use_new_mapping_type attribute.
    /// </summary>
    public TerraformProperty<bool>? UseNewMappingType
    {
        set => SetProperty("use_new_mapping_type", value);
    }

}

/// <summary>
/// Block type for kafka_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointKafkaSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The broker attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Broker is required")]
    public required TerraformProperty<string> Broker
    {
        set => SetProperty("broker", value);
    }

    /// <summary>
    /// The include_control_details attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeControlDetails
    {
        set => SetProperty("include_control_details", value);
    }

    /// <summary>
    /// The include_null_and_empty attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeNullAndEmpty
    {
        set => SetProperty("include_null_and_empty", value);
    }

    /// <summary>
    /// The include_partition_value attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludePartitionValue
    {
        set => SetProperty("include_partition_value", value);
    }

    /// <summary>
    /// The include_table_alter_operations attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeTableAlterOperations
    {
        set => SetProperty("include_table_alter_operations", value);
    }

    /// <summary>
    /// The include_transaction_details attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeTransactionDetails
    {
        set => SetProperty("include_transaction_details", value);
    }

    /// <summary>
    /// The message_format attribute.
    /// </summary>
    public TerraformProperty<string>? MessageFormat
    {
        set => SetProperty("message_format", value);
    }

    /// <summary>
    /// The message_max_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? MessageMaxBytes
    {
        set => SetProperty("message_max_bytes", value);
    }

    /// <summary>
    /// The no_hex_prefix attribute.
    /// </summary>
    public TerraformProperty<bool>? NoHexPrefix
    {
        set => SetProperty("no_hex_prefix", value);
    }

    /// <summary>
    /// The partition_include_schema_table attribute.
    /// </summary>
    public TerraformProperty<bool>? PartitionIncludeSchemaTable
    {
        set => SetProperty("partition_include_schema_table", value);
    }

    /// <summary>
    /// The sasl_mechanism attribute.
    /// </summary>
    public TerraformProperty<string>? SaslMechanism
    {
        set => SetProperty("sasl_mechanism", value);
    }

    /// <summary>
    /// The sasl_password attribute.
    /// </summary>
    public TerraformProperty<string>? SaslPassword
    {
        set => SetProperty("sasl_password", value);
    }

    /// <summary>
    /// The sasl_username attribute.
    /// </summary>
    public TerraformProperty<string>? SaslUsername
    {
        set => SetProperty("sasl_username", value);
    }

    /// <summary>
    /// The security_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityProtocol
    {
        set => SetProperty("security_protocol", value);
    }

    /// <summary>
    /// The ssl_ca_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SslCaCertificateArn
    {
        set => SetProperty("ssl_ca_certificate_arn", value);
    }

    /// <summary>
    /// The ssl_client_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SslClientCertificateArn
    {
        set => SetProperty("ssl_client_certificate_arn", value);
    }

    /// <summary>
    /// The ssl_client_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SslClientKeyArn
    {
        set => SetProperty("ssl_client_key_arn", value);
    }

    /// <summary>
    /// The ssl_client_key_password attribute.
    /// </summary>
    public TerraformProperty<string>? SslClientKeyPassword
    {
        set => SetProperty("ssl_client_key_password", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    public TerraformProperty<string>? Topic
    {
        set => SetProperty("topic", value);
    }

}

/// <summary>
/// Block type for kinesis_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointKinesisSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The include_control_details attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeControlDetails
    {
        set => SetProperty("include_control_details", value);
    }

    /// <summary>
    /// The include_null_and_empty attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeNullAndEmpty
    {
        set => SetProperty("include_null_and_empty", value);
    }

    /// <summary>
    /// The include_partition_value attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludePartitionValue
    {
        set => SetProperty("include_partition_value", value);
    }

    /// <summary>
    /// The include_table_alter_operations attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeTableAlterOperations
    {
        set => SetProperty("include_table_alter_operations", value);
    }

    /// <summary>
    /// The include_transaction_details attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeTransactionDetails
    {
        set => SetProperty("include_transaction_details", value);
    }

    /// <summary>
    /// The message_format attribute.
    /// </summary>
    public TerraformProperty<string>? MessageFormat
    {
        set => SetProperty("message_format", value);
    }

    /// <summary>
    /// The partition_include_schema_table attribute.
    /// </summary>
    public TerraformProperty<bool>? PartitionIncludeSchemaTable
    {
        set => SetProperty("partition_include_schema_table", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccessRoleArn
    {
        set => SetProperty("service_access_role_arn", value);
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformProperty<string>? StreamArn
    {
        set => SetProperty("stream_arn", value);
    }

    /// <summary>
    /// The use_large_integer_value attribute.
    /// </summary>
    public TerraformProperty<bool>? UseLargeIntegerValue
    {
        set => SetProperty("use_large_integer_value", value);
    }

}

/// <summary>
/// Block type for mongodb_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointMongodbSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The auth_mechanism attribute.
    /// </summary>
    public TerraformProperty<string>? AuthMechanism
    {
        set => SetProperty("auth_mechanism", value);
    }

    /// <summary>
    /// The auth_source attribute.
    /// </summary>
    public TerraformProperty<string>? AuthSource
    {
        set => SetProperty("auth_source", value);
    }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    public TerraformProperty<string>? AuthType
    {
        set => SetProperty("auth_type", value);
    }

    /// <summary>
    /// The docs_to_investigate attribute.
    /// </summary>
    public TerraformProperty<string>? DocsToInvestigate
    {
        set => SetProperty("docs_to_investigate", value);
    }

    /// <summary>
    /// The extract_doc_id attribute.
    /// </summary>
    public TerraformProperty<string>? ExtractDocId
    {
        set => SetProperty("extract_doc_id", value);
    }

    /// <summary>
    /// The nesting_level attribute.
    /// </summary>
    public TerraformProperty<string>? NestingLevel
    {
        set => SetProperty("nesting_level", value);
    }

}

/// <summary>
/// Block type for mysql_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointMysqlSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The after_connect_script attribute.
    /// </summary>
    public TerraformProperty<string>? AfterConnectScript
    {
        set => SetProperty("after_connect_script", value);
    }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationMethod
    {
        set => SetProperty("authentication_method", value);
    }

    /// <summary>
    /// The clean_source_metadata_on_mismatch attribute.
    /// </summary>
    public TerraformProperty<bool>? CleanSourceMetadataOnMismatch
    {
        set => SetProperty("clean_source_metadata_on_mismatch", value);
    }

    /// <summary>
    /// The events_poll_interval attribute.
    /// </summary>
    public TerraformProperty<double>? EventsPollInterval
    {
        set => SetProperty("events_poll_interval", value);
    }

    /// <summary>
    /// The execute_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? ExecuteTimeout
    {
        set => SetProperty("execute_timeout", value);
    }

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    public TerraformProperty<double>? MaxFileSize
    {
        set => SetProperty("max_file_size", value);
    }

    /// <summary>
    /// The parallel_load_threads attribute.
    /// </summary>
    public TerraformProperty<double>? ParallelLoadThreads
    {
        set => SetProperty("parallel_load_threads", value);
    }

    /// <summary>
    /// The server_timezone attribute.
    /// </summary>
    public TerraformProperty<string>? ServerTimezone
    {
        set => SetProperty("server_timezone", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccessRoleArn
    {
        set => SetProperty("service_access_role_arn", value);
    }

    /// <summary>
    /// The target_db_type attribute.
    /// </summary>
    public TerraformProperty<string>? TargetDbType
    {
        set => SetProperty("target_db_type", value);
    }

}

/// <summary>
/// Block type for oracle_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointOracleSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationMethod
    {
        set => SetProperty("authentication_method", value);
    }

}

/// <summary>
/// Block type for postgres_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointPostgresSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The after_connect_script attribute.
    /// </summary>
    public TerraformProperty<string>? AfterConnectScript
    {
        set => SetProperty("after_connect_script", value);
    }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationMethod
    {
        set => SetProperty("authentication_method", value);
    }

    /// <summary>
    /// The babelfish_database_name attribute.
    /// </summary>
    public TerraformProperty<string>? BabelfishDatabaseName
    {
        set => SetProperty("babelfish_database_name", value);
    }

    /// <summary>
    /// The capture_ddls attribute.
    /// </summary>
    public TerraformProperty<bool>? CaptureDdls
    {
        set => SetProperty("capture_ddls", value);
    }

    /// <summary>
    /// The database_mode attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseMode
    {
        set => SetProperty("database_mode", value);
    }

    /// <summary>
    /// The ddl_artifacts_schema attribute.
    /// </summary>
    public TerraformProperty<string>? DdlArtifactsSchema
    {
        set => SetProperty("ddl_artifacts_schema", value);
    }

    /// <summary>
    /// The execute_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? ExecuteTimeout
    {
        set => SetProperty("execute_timeout", value);
    }

    /// <summary>
    /// The fail_tasks_on_lob_truncation attribute.
    /// </summary>
    public TerraformProperty<bool>? FailTasksOnLobTruncation
    {
        set => SetProperty("fail_tasks_on_lob_truncation", value);
    }

    /// <summary>
    /// The heartbeat_enable attribute.
    /// </summary>
    public TerraformProperty<bool>? HeartbeatEnable
    {
        set => SetProperty("heartbeat_enable", value);
    }

    /// <summary>
    /// The heartbeat_frequency attribute.
    /// </summary>
    public TerraformProperty<double>? HeartbeatFrequency
    {
        set => SetProperty("heartbeat_frequency", value);
    }

    /// <summary>
    /// The heartbeat_schema attribute.
    /// </summary>
    public TerraformProperty<string>? HeartbeatSchema
    {
        set => SetProperty("heartbeat_schema", value);
    }

    /// <summary>
    /// The map_boolean_as_boolean attribute.
    /// </summary>
    public TerraformProperty<bool>? MapBooleanAsBoolean
    {
        set => SetProperty("map_boolean_as_boolean", value);
    }

    /// <summary>
    /// The map_jsonb_as_clob attribute.
    /// </summary>
    public TerraformProperty<bool>? MapJsonbAsClob
    {
        set => SetProperty("map_jsonb_as_clob", value);
    }

    /// <summary>
    /// The map_long_varchar_as attribute.
    /// </summary>
    public TerraformProperty<string>? MapLongVarcharAs
    {
        set => SetProperty("map_long_varchar_as", value);
    }

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    public TerraformProperty<double>? MaxFileSize
    {
        set => SetProperty("max_file_size", value);
    }

    /// <summary>
    /// The plugin_name attribute.
    /// </summary>
    public TerraformProperty<string>? PluginName
    {
        set => SetProperty("plugin_name", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccessRoleArn
    {
        set => SetProperty("service_access_role_arn", value);
    }

    /// <summary>
    /// The slot_name attribute.
    /// </summary>
    public TerraformProperty<string>? SlotName
    {
        set => SetProperty("slot_name", value);
    }

}

/// <summary>
/// Block type for redis_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointRedisSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The auth_password attribute.
    /// </summary>
    public TerraformProperty<string>? AuthPassword
    {
        set => SetProperty("auth_password", value);
    }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformProperty<string> AuthType
    {
        set => SetProperty("auth_type", value);
    }

    /// <summary>
    /// The auth_user_name attribute.
    /// </summary>
    public TerraformProperty<string>? AuthUserName
    {
        set => SetProperty("auth_user_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    public required TerraformProperty<string> ServerName
    {
        set => SetProperty("server_name", value);
    }

    /// <summary>
    /// The ssl_ca_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SslCaCertificateArn
    {
        set => SetProperty("ssl_ca_certificate_arn", value);
    }

    /// <summary>
    /// The ssl_security_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? SslSecurityProtocol
    {
        set => SetProperty("ssl_security_protocol", value);
    }

}

/// <summary>
/// Block type for redshift_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointRedshiftSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The bucket_folder attribute.
    /// </summary>
    public TerraformProperty<string>? BucketFolder
    {
        set => SetProperty("bucket_folder", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformProperty<string>? BucketName
    {
        set => SetProperty("bucket_name", value);
    }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionMode
    {
        set => SetProperty("encryption_mode", value);
    }

    /// <summary>
    /// The server_side_encryption_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServerSideEncryptionKmsKeyId
    {
        set => SetProperty("server_side_encryption_kms_key_id", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccessRoleArn
    {
        set => SetProperty("service_access_role_arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDmsEndpointTimeoutsBlock : TerraformBlock
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
/// Manages a aws_dms_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDmsEndpoint : TerraformResource
{
    public AwsDmsEndpoint(string name) : base("aws_dms_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("endpoint_arn");
        SetOutput("certificate_arn");
        SetOutput("database_name");
        SetOutput("endpoint_id");
        SetOutput("endpoint_type");
        SetOutput("engine_name");
        SetOutput("extra_connection_attributes");
        SetOutput("id");
        SetOutput("kms_key_arn");
        SetOutput("password");
        SetOutput("pause_replication_tasks");
        SetOutput("port");
        SetOutput("region");
        SetOutput("secrets_manager_access_role_arn");
        SetOutput("secrets_manager_arn");
        SetOutput("server_name");
        SetOutput("service_access_role");
        SetOutput("ssl_mode");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("username");
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
    /// The database_name attribute.
    /// </summary>
    public TerraformProperty<string> DatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_name");
        set => SetProperty("database_name", value);
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
    /// The engine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineName is required")]
    public required TerraformProperty<string> EngineName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_name");
        set => SetProperty("engine_name", value);
    }

    /// <summary>
    /// The extra_connection_attributes attribute.
    /// </summary>
    public TerraformProperty<string> ExtraConnectionAttributes
    {
        get => GetRequiredOutput<TerraformProperty<string>>("extra_connection_attributes");
        set => SetProperty("extra_connection_attributes", value);
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
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_arn");
        set => SetProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The pause_replication_tasks attribute.
    /// </summary>
    public TerraformProperty<bool> PauseReplicationTasks
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("pause_replication_tasks");
        set => SetProperty("pause_replication_tasks", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
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
    /// The secrets_manager_access_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> SecretsManagerAccessRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secrets_manager_access_role_arn");
        set => SetProperty("secrets_manager_access_role_arn", value);
    }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    public TerraformProperty<string> SecretsManagerArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secrets_manager_arn");
        set => SetProperty("secrets_manager_arn", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public TerraformProperty<string> ServerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_name");
        set => SetProperty("server_name", value);
    }

    /// <summary>
    /// The service_access_role attribute.
    /// </summary>
    public TerraformProperty<string> ServiceAccessRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_access_role");
        set => SetProperty("service_access_role", value);
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
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string> Username
    {
        get => GetRequiredOutput<TerraformProperty<string>>("username");
        set => SetProperty("username", value);
    }

    /// <summary>
    /// Block for elasticsearch_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchSettings block(s) allowed")]
    public List<AwsDmsEndpointElasticsearchSettingsBlock>? ElasticsearchSettings
    {
        set => SetProperty("elasticsearch_settings", value);
    }

    /// <summary>
    /// Block for kafka_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaSettings block(s) allowed")]
    public List<AwsDmsEndpointKafkaSettingsBlock>? KafkaSettings
    {
        set => SetProperty("kafka_settings", value);
    }

    /// <summary>
    /// Block for kinesis_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisSettings block(s) allowed")]
    public List<AwsDmsEndpointKinesisSettingsBlock>? KinesisSettings
    {
        set => SetProperty("kinesis_settings", value);
    }

    /// <summary>
    /// Block for mongodb_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MongodbSettings block(s) allowed")]
    public List<AwsDmsEndpointMongodbSettingsBlock>? MongodbSettings
    {
        set => SetProperty("mongodb_settings", value);
    }

    /// <summary>
    /// Block for mysql_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MysqlSettings block(s) allowed")]
    public List<AwsDmsEndpointMysqlSettingsBlock>? MysqlSettings
    {
        set => SetProperty("mysql_settings", value);
    }

    /// <summary>
    /// Block for oracle_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OracleSettings block(s) allowed")]
    public List<AwsDmsEndpointOracleSettingsBlock>? OracleSettings
    {
        set => SetProperty("oracle_settings", value);
    }

    /// <summary>
    /// Block for postgres_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostgresSettings block(s) allowed")]
    public List<AwsDmsEndpointPostgresSettingsBlock>? PostgresSettings
    {
        set => SetProperty("postgres_settings", value);
    }

    /// <summary>
    /// Block for redis_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedisSettings block(s) allowed")]
    public List<AwsDmsEndpointRedisSettingsBlock>? RedisSettings
    {
        set => SetProperty("redis_settings", value);
    }

    /// <summary>
    /// Block for redshift_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftSettings block(s) allowed")]
    public List<AwsDmsEndpointRedshiftSettingsBlock>? RedshiftSettings
    {
        set => SetProperty("redshift_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDmsEndpointTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    public TerraformExpression EndpointArn => this["endpoint_arn"];

}
