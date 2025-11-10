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
        get => GetProperty<TerraformProperty<string>>("endpoint_uri");
        set => WithProperty("endpoint_uri", value);
    }

    /// <summary>
    /// The error_retry_duration attribute.
    /// </summary>
    public TerraformProperty<double>? ErrorRetryDuration
    {
        get => GetProperty<TerraformProperty<double>>("error_retry_duration");
        set => WithProperty("error_retry_duration", value);
    }

    /// <summary>
    /// The full_load_error_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? FullLoadErrorPercentage
    {
        get => GetProperty<TerraformProperty<double>>("full_load_error_percentage");
        set => WithProperty("full_load_error_percentage", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccessRoleArn is required")]
    public required TerraformProperty<string> ServiceAccessRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("service_access_role_arn");
        set => WithProperty("service_access_role_arn", value);
    }

    /// <summary>
    /// The use_new_mapping_type attribute.
    /// </summary>
    public TerraformProperty<bool>? UseNewMappingType
    {
        get => GetProperty<TerraformProperty<bool>>("use_new_mapping_type");
        set => WithProperty("use_new_mapping_type", value);
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
        get => GetProperty<TerraformProperty<string>>("broker");
        set => WithProperty("broker", value);
    }

    /// <summary>
    /// The include_control_details attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeControlDetails
    {
        get => GetProperty<TerraformProperty<bool>>("include_control_details");
        set => WithProperty("include_control_details", value);
    }

    /// <summary>
    /// The include_null_and_empty attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeNullAndEmpty
    {
        get => GetProperty<TerraformProperty<bool>>("include_null_and_empty");
        set => WithProperty("include_null_and_empty", value);
    }

    /// <summary>
    /// The include_partition_value attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludePartitionValue
    {
        get => GetProperty<TerraformProperty<bool>>("include_partition_value");
        set => WithProperty("include_partition_value", value);
    }

    /// <summary>
    /// The include_table_alter_operations attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeTableAlterOperations
    {
        get => GetProperty<TerraformProperty<bool>>("include_table_alter_operations");
        set => WithProperty("include_table_alter_operations", value);
    }

    /// <summary>
    /// The include_transaction_details attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeTransactionDetails
    {
        get => GetProperty<TerraformProperty<bool>>("include_transaction_details");
        set => WithProperty("include_transaction_details", value);
    }

    /// <summary>
    /// The message_format attribute.
    /// </summary>
    public TerraformProperty<string>? MessageFormat
    {
        get => GetProperty<TerraformProperty<string>>("message_format");
        set => WithProperty("message_format", value);
    }

    /// <summary>
    /// The message_max_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? MessageMaxBytes
    {
        get => GetProperty<TerraformProperty<double>>("message_max_bytes");
        set => WithProperty("message_max_bytes", value);
    }

    /// <summary>
    /// The no_hex_prefix attribute.
    /// </summary>
    public TerraformProperty<bool>? NoHexPrefix
    {
        get => GetProperty<TerraformProperty<bool>>("no_hex_prefix");
        set => WithProperty("no_hex_prefix", value);
    }

    /// <summary>
    /// The partition_include_schema_table attribute.
    /// </summary>
    public TerraformProperty<bool>? PartitionIncludeSchemaTable
    {
        get => GetProperty<TerraformProperty<bool>>("partition_include_schema_table");
        set => WithProperty("partition_include_schema_table", value);
    }

    /// <summary>
    /// The sasl_mechanism attribute.
    /// </summary>
    public TerraformProperty<string>? SaslMechanism
    {
        get => GetProperty<TerraformProperty<string>>("sasl_mechanism");
        set => WithProperty("sasl_mechanism", value);
    }

    /// <summary>
    /// The sasl_password attribute.
    /// </summary>
    public TerraformProperty<string>? SaslPassword
    {
        get => GetProperty<TerraformProperty<string>>("sasl_password");
        set => WithProperty("sasl_password", value);
    }

    /// <summary>
    /// The sasl_username attribute.
    /// </summary>
    public TerraformProperty<string>? SaslUsername
    {
        get => GetProperty<TerraformProperty<string>>("sasl_username");
        set => WithProperty("sasl_username", value);
    }

    /// <summary>
    /// The security_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityProtocol
    {
        get => GetProperty<TerraformProperty<string>>("security_protocol");
        set => WithProperty("security_protocol", value);
    }

    /// <summary>
    /// The ssl_ca_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SslCaCertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("ssl_ca_certificate_arn");
        set => WithProperty("ssl_ca_certificate_arn", value);
    }

    /// <summary>
    /// The ssl_client_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SslClientCertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("ssl_client_certificate_arn");
        set => WithProperty("ssl_client_certificate_arn", value);
    }

    /// <summary>
    /// The ssl_client_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SslClientKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("ssl_client_key_arn");
        set => WithProperty("ssl_client_key_arn", value);
    }

    /// <summary>
    /// The ssl_client_key_password attribute.
    /// </summary>
    public TerraformProperty<string>? SslClientKeyPassword
    {
        get => GetProperty<TerraformProperty<string>>("ssl_client_key_password");
        set => WithProperty("ssl_client_key_password", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    public TerraformProperty<string>? Topic
    {
        get => GetProperty<TerraformProperty<string>>("topic");
        set => WithProperty("topic", value);
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
        get => GetProperty<TerraformProperty<bool>>("include_control_details");
        set => WithProperty("include_control_details", value);
    }

    /// <summary>
    /// The include_null_and_empty attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeNullAndEmpty
    {
        get => GetProperty<TerraformProperty<bool>>("include_null_and_empty");
        set => WithProperty("include_null_and_empty", value);
    }

    /// <summary>
    /// The include_partition_value attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludePartitionValue
    {
        get => GetProperty<TerraformProperty<bool>>("include_partition_value");
        set => WithProperty("include_partition_value", value);
    }

    /// <summary>
    /// The include_table_alter_operations attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeTableAlterOperations
    {
        get => GetProperty<TerraformProperty<bool>>("include_table_alter_operations");
        set => WithProperty("include_table_alter_operations", value);
    }

    /// <summary>
    /// The include_transaction_details attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeTransactionDetails
    {
        get => GetProperty<TerraformProperty<bool>>("include_transaction_details");
        set => WithProperty("include_transaction_details", value);
    }

    /// <summary>
    /// The message_format attribute.
    /// </summary>
    public TerraformProperty<string>? MessageFormat
    {
        get => GetProperty<TerraformProperty<string>>("message_format");
        set => WithProperty("message_format", value);
    }

    /// <summary>
    /// The partition_include_schema_table attribute.
    /// </summary>
    public TerraformProperty<bool>? PartitionIncludeSchemaTable
    {
        get => GetProperty<TerraformProperty<bool>>("partition_include_schema_table");
        set => WithProperty("partition_include_schema_table", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccessRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("service_access_role_arn");
        set => WithProperty("service_access_role_arn", value);
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformProperty<string>? StreamArn
    {
        get => GetProperty<TerraformProperty<string>>("stream_arn");
        set => WithProperty("stream_arn", value);
    }

    /// <summary>
    /// The use_large_integer_value attribute.
    /// </summary>
    public TerraformProperty<bool>? UseLargeIntegerValue
    {
        get => GetProperty<TerraformProperty<bool>>("use_large_integer_value");
        set => WithProperty("use_large_integer_value", value);
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
        get => GetProperty<TerraformProperty<string>>("auth_mechanism");
        set => WithProperty("auth_mechanism", value);
    }

    /// <summary>
    /// The auth_source attribute.
    /// </summary>
    public TerraformProperty<string>? AuthSource
    {
        get => GetProperty<TerraformProperty<string>>("auth_source");
        set => WithProperty("auth_source", value);
    }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    public TerraformProperty<string>? AuthType
    {
        get => GetProperty<TerraformProperty<string>>("auth_type");
        set => WithProperty("auth_type", value);
    }

    /// <summary>
    /// The docs_to_investigate attribute.
    /// </summary>
    public TerraformProperty<string>? DocsToInvestigate
    {
        get => GetProperty<TerraformProperty<string>>("docs_to_investigate");
        set => WithProperty("docs_to_investigate", value);
    }

    /// <summary>
    /// The extract_doc_id attribute.
    /// </summary>
    public TerraformProperty<string>? ExtractDocId
    {
        get => GetProperty<TerraformProperty<string>>("extract_doc_id");
        set => WithProperty("extract_doc_id", value);
    }

    /// <summary>
    /// The nesting_level attribute.
    /// </summary>
    public TerraformProperty<string>? NestingLevel
    {
        get => GetProperty<TerraformProperty<string>>("nesting_level");
        set => WithProperty("nesting_level", value);
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
        get => GetProperty<TerraformProperty<string>>("after_connect_script");
        set => WithProperty("after_connect_script", value);
    }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationMethod
    {
        get => GetProperty<TerraformProperty<string>>("authentication_method");
        set => WithProperty("authentication_method", value);
    }

    /// <summary>
    /// The clean_source_metadata_on_mismatch attribute.
    /// </summary>
    public TerraformProperty<bool>? CleanSourceMetadataOnMismatch
    {
        get => GetProperty<TerraformProperty<bool>>("clean_source_metadata_on_mismatch");
        set => WithProperty("clean_source_metadata_on_mismatch", value);
    }

    /// <summary>
    /// The events_poll_interval attribute.
    /// </summary>
    public TerraformProperty<double>? EventsPollInterval
    {
        get => GetProperty<TerraformProperty<double>>("events_poll_interval");
        set => WithProperty("events_poll_interval", value);
    }

    /// <summary>
    /// The execute_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? ExecuteTimeout
    {
        get => GetProperty<TerraformProperty<double>>("execute_timeout");
        set => WithProperty("execute_timeout", value);
    }

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    public TerraformProperty<double>? MaxFileSize
    {
        get => GetProperty<TerraformProperty<double>>("max_file_size");
        set => WithProperty("max_file_size", value);
    }

    /// <summary>
    /// The parallel_load_threads attribute.
    /// </summary>
    public TerraformProperty<double>? ParallelLoadThreads
    {
        get => GetProperty<TerraformProperty<double>>("parallel_load_threads");
        set => WithProperty("parallel_load_threads", value);
    }

    /// <summary>
    /// The server_timezone attribute.
    /// </summary>
    public TerraformProperty<string>? ServerTimezone
    {
        get => GetProperty<TerraformProperty<string>>("server_timezone");
        set => WithProperty("server_timezone", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccessRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("service_access_role_arn");
        set => WithProperty("service_access_role_arn", value);
    }

    /// <summary>
    /// The target_db_type attribute.
    /// </summary>
    public TerraformProperty<string>? TargetDbType
    {
        get => GetProperty<TerraformProperty<string>>("target_db_type");
        set => WithProperty("target_db_type", value);
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
        get => GetProperty<TerraformProperty<string>>("authentication_method");
        set => WithProperty("authentication_method", value);
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
        get => GetProperty<TerraformProperty<string>>("after_connect_script");
        set => WithProperty("after_connect_script", value);
    }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationMethod
    {
        get => GetProperty<TerraformProperty<string>>("authentication_method");
        set => WithProperty("authentication_method", value);
    }

    /// <summary>
    /// The babelfish_database_name attribute.
    /// </summary>
    public TerraformProperty<string>? BabelfishDatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("babelfish_database_name");
        set => WithProperty("babelfish_database_name", value);
    }

    /// <summary>
    /// The capture_ddls attribute.
    /// </summary>
    public TerraformProperty<bool>? CaptureDdls
    {
        get => GetProperty<TerraformProperty<bool>>("capture_ddls");
        set => WithProperty("capture_ddls", value);
    }

    /// <summary>
    /// The database_mode attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseMode
    {
        get => GetProperty<TerraformProperty<string>>("database_mode");
        set => WithProperty("database_mode", value);
    }

    /// <summary>
    /// The ddl_artifacts_schema attribute.
    /// </summary>
    public TerraformProperty<string>? DdlArtifactsSchema
    {
        get => GetProperty<TerraformProperty<string>>("ddl_artifacts_schema");
        set => WithProperty("ddl_artifacts_schema", value);
    }

    /// <summary>
    /// The execute_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? ExecuteTimeout
    {
        get => GetProperty<TerraformProperty<double>>("execute_timeout");
        set => WithProperty("execute_timeout", value);
    }

    /// <summary>
    /// The fail_tasks_on_lob_truncation attribute.
    /// </summary>
    public TerraformProperty<bool>? FailTasksOnLobTruncation
    {
        get => GetProperty<TerraformProperty<bool>>("fail_tasks_on_lob_truncation");
        set => WithProperty("fail_tasks_on_lob_truncation", value);
    }

    /// <summary>
    /// The heartbeat_enable attribute.
    /// </summary>
    public TerraformProperty<bool>? HeartbeatEnable
    {
        get => GetProperty<TerraformProperty<bool>>("heartbeat_enable");
        set => WithProperty("heartbeat_enable", value);
    }

    /// <summary>
    /// The heartbeat_frequency attribute.
    /// </summary>
    public TerraformProperty<double>? HeartbeatFrequency
    {
        get => GetProperty<TerraformProperty<double>>("heartbeat_frequency");
        set => WithProperty("heartbeat_frequency", value);
    }

    /// <summary>
    /// The heartbeat_schema attribute.
    /// </summary>
    public TerraformProperty<string>? HeartbeatSchema
    {
        get => GetProperty<TerraformProperty<string>>("heartbeat_schema");
        set => WithProperty("heartbeat_schema", value);
    }

    /// <summary>
    /// The map_boolean_as_boolean attribute.
    /// </summary>
    public TerraformProperty<bool>? MapBooleanAsBoolean
    {
        get => GetProperty<TerraformProperty<bool>>("map_boolean_as_boolean");
        set => WithProperty("map_boolean_as_boolean", value);
    }

    /// <summary>
    /// The map_jsonb_as_clob attribute.
    /// </summary>
    public TerraformProperty<bool>? MapJsonbAsClob
    {
        get => GetProperty<TerraformProperty<bool>>("map_jsonb_as_clob");
        set => WithProperty("map_jsonb_as_clob", value);
    }

    /// <summary>
    /// The map_long_varchar_as attribute.
    /// </summary>
    public TerraformProperty<string>? MapLongVarcharAs
    {
        get => GetProperty<TerraformProperty<string>>("map_long_varchar_as");
        set => WithProperty("map_long_varchar_as", value);
    }

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    public TerraformProperty<double>? MaxFileSize
    {
        get => GetProperty<TerraformProperty<double>>("max_file_size");
        set => WithProperty("max_file_size", value);
    }

    /// <summary>
    /// The plugin_name attribute.
    /// </summary>
    public TerraformProperty<string>? PluginName
    {
        get => GetProperty<TerraformProperty<string>>("plugin_name");
        set => WithProperty("plugin_name", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccessRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("service_access_role_arn");
        set => WithProperty("service_access_role_arn", value);
    }

    /// <summary>
    /// The slot_name attribute.
    /// </summary>
    public TerraformProperty<string>? SlotName
    {
        get => GetProperty<TerraformProperty<string>>("slot_name");
        set => WithProperty("slot_name", value);
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
        get => GetProperty<TerraformProperty<string>>("auth_password");
        set => WithProperty("auth_password", value);
    }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformProperty<string> AuthType
    {
        get => GetProperty<TerraformProperty<string>>("auth_type");
        set => WithProperty("auth_type", value);
    }

    /// <summary>
    /// The auth_user_name attribute.
    /// </summary>
    public TerraformProperty<string>? AuthUserName
    {
        get => GetProperty<TerraformProperty<string>>("auth_user_name");
        set => WithProperty("auth_user_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    public required TerraformProperty<string> ServerName
    {
        get => GetProperty<TerraformProperty<string>>("server_name");
        set => WithProperty("server_name", value);
    }

    /// <summary>
    /// The ssl_ca_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SslCaCertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("ssl_ca_certificate_arn");
        set => WithProperty("ssl_ca_certificate_arn", value);
    }

    /// <summary>
    /// The ssl_security_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? SslSecurityProtocol
    {
        get => GetProperty<TerraformProperty<string>>("ssl_security_protocol");
        set => WithProperty("ssl_security_protocol", value);
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
        get => GetProperty<TerraformProperty<string>>("bucket_folder");
        set => WithProperty("bucket_folder", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformProperty<string>? BucketName
    {
        get => GetProperty<TerraformProperty<string>>("bucket_name");
        set => WithProperty("bucket_name", value);
    }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionMode
    {
        get => GetProperty<TerraformProperty<string>>("encryption_mode");
        set => WithProperty("encryption_mode", value);
    }

    /// <summary>
    /// The server_side_encryption_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServerSideEncryptionKmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("server_side_encryption_kms_key_id");
        set => WithProperty("server_side_encryption_kms_key_id", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccessRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("service_access_role_arn");
        set => WithProperty("service_access_role_arn", value);
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
        this.DeclareOutput("endpoint_arn");
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("certificate_arn");
        set => this.WithProperty("certificate_arn", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointId is required")]
    public required TerraformProperty<string> EndpointId
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_id");
        set => this.WithProperty("endpoint_id", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    public required TerraformProperty<string> EndpointType
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_type");
        set => this.WithProperty("endpoint_type", value);
    }

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineName is required")]
    public required TerraformProperty<string> EngineName
    {
        get => GetProperty<TerraformProperty<string>>("engine_name");
        set => this.WithProperty("engine_name", value);
    }

    /// <summary>
    /// The extra_connection_attributes attribute.
    /// </summary>
    public TerraformProperty<string>? ExtraConnectionAttributes
    {
        get => GetProperty<TerraformProperty<string>>("extra_connection_attributes");
        set => this.WithProperty("extra_connection_attributes", value);
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
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The pause_replication_tasks attribute.
    /// </summary>
    public TerraformProperty<bool>? PauseReplicationTasks
    {
        get => GetProperty<TerraformProperty<bool>>("pause_replication_tasks");
        set => this.WithProperty("pause_replication_tasks", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
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
    /// The secrets_manager_access_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SecretsManagerAccessRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("secrets_manager_access_role_arn");
        set => this.WithProperty("secrets_manager_access_role_arn", value);
    }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SecretsManagerArn
    {
        get => GetProperty<TerraformProperty<string>>("secrets_manager_arn");
        set => this.WithProperty("secrets_manager_arn", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public TerraformProperty<string>? ServerName
    {
        get => GetProperty<TerraformProperty<string>>("server_name");
        set => this.WithProperty("server_name", value);
    }

    /// <summary>
    /// The service_access_role attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccessRole
    {
        get => GetProperty<TerraformProperty<string>>("service_access_role");
        set => this.WithProperty("service_access_role", value);
    }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    public TerraformProperty<string>? SslMode
    {
        get => GetProperty<TerraformProperty<string>>("ssl_mode");
        set => this.WithProperty("ssl_mode", value);
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
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

    /// <summary>
    /// Block for elasticsearch_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchSettings block(s) allowed")]
    public List<AwsDmsEndpointElasticsearchSettingsBlock>? ElasticsearchSettings
    {
        get => GetProperty<List<AwsDmsEndpointElasticsearchSettingsBlock>>("elasticsearch_settings");
        set => this.WithProperty("elasticsearch_settings", value);
    }

    /// <summary>
    /// Block for kafka_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaSettings block(s) allowed")]
    public List<AwsDmsEndpointKafkaSettingsBlock>? KafkaSettings
    {
        get => GetProperty<List<AwsDmsEndpointKafkaSettingsBlock>>("kafka_settings");
        set => this.WithProperty("kafka_settings", value);
    }

    /// <summary>
    /// Block for kinesis_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisSettings block(s) allowed")]
    public List<AwsDmsEndpointKinesisSettingsBlock>? KinesisSettings
    {
        get => GetProperty<List<AwsDmsEndpointKinesisSettingsBlock>>("kinesis_settings");
        set => this.WithProperty("kinesis_settings", value);
    }

    /// <summary>
    /// Block for mongodb_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MongodbSettings block(s) allowed")]
    public List<AwsDmsEndpointMongodbSettingsBlock>? MongodbSettings
    {
        get => GetProperty<List<AwsDmsEndpointMongodbSettingsBlock>>("mongodb_settings");
        set => this.WithProperty("mongodb_settings", value);
    }

    /// <summary>
    /// Block for mysql_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MysqlSettings block(s) allowed")]
    public List<AwsDmsEndpointMysqlSettingsBlock>? MysqlSettings
    {
        get => GetProperty<List<AwsDmsEndpointMysqlSettingsBlock>>("mysql_settings");
        set => this.WithProperty("mysql_settings", value);
    }

    /// <summary>
    /// Block for oracle_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OracleSettings block(s) allowed")]
    public List<AwsDmsEndpointOracleSettingsBlock>? OracleSettings
    {
        get => GetProperty<List<AwsDmsEndpointOracleSettingsBlock>>("oracle_settings");
        set => this.WithProperty("oracle_settings", value);
    }

    /// <summary>
    /// Block for postgres_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostgresSettings block(s) allowed")]
    public List<AwsDmsEndpointPostgresSettingsBlock>? PostgresSettings
    {
        get => GetProperty<List<AwsDmsEndpointPostgresSettingsBlock>>("postgres_settings");
        set => this.WithProperty("postgres_settings", value);
    }

    /// <summary>
    /// Block for redis_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedisSettings block(s) allowed")]
    public List<AwsDmsEndpointRedisSettingsBlock>? RedisSettings
    {
        get => GetProperty<List<AwsDmsEndpointRedisSettingsBlock>>("redis_settings");
        set => this.WithProperty("redis_settings", value);
    }

    /// <summary>
    /// Block for redshift_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftSettings block(s) allowed")]
    public List<AwsDmsEndpointRedshiftSettingsBlock>? RedshiftSettings
    {
        get => GetProperty<List<AwsDmsEndpointRedshiftSettingsBlock>>("redshift_settings");
        set => this.WithProperty("redshift_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDmsEndpointTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDmsEndpointTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    public TerraformExpression EndpointArn => this["endpoint_arn"];

}
