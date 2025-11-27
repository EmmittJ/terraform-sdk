using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for elasticsearch_settings in AwsDmsEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointElasticsearchSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "elasticsearch_settings";

    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointUri is required")]
    public required TerraformValue<string> EndpointUri
    {
        get => new TerraformReference<string>(this, "endpoint_uri");
        set => SetArgument("endpoint_uri", value);
    }

    /// <summary>
    /// The error_retry_duration attribute.
    /// </summary>
    public TerraformValue<double>? ErrorRetryDuration
    {
        get => new TerraformReference<double>(this, "error_retry_duration");
        set => SetArgument("error_retry_duration", value);
    }

    /// <summary>
    /// The full_load_error_percentage attribute.
    /// </summary>
    public TerraformValue<double>? FullLoadErrorPercentage
    {
        get => new TerraformReference<double>(this, "full_load_error_percentage");
        set => SetArgument("full_load_error_percentage", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccessRoleArn is required")]
    public required TerraformValue<string> ServiceAccessRoleArn
    {
        get => new TerraformReference<string>(this, "service_access_role_arn");
        set => SetArgument("service_access_role_arn", value);
    }

    /// <summary>
    /// The use_new_mapping_type attribute.
    /// </summary>
    public TerraformValue<bool>? UseNewMappingType
    {
        get => new TerraformReference<bool>(this, "use_new_mapping_type");
        set => SetArgument("use_new_mapping_type", value);
    }

}


/// <summary>
/// Block type for kafka_settings in AwsDmsEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointKafkaSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kafka_settings";

    /// <summary>
    /// The broker attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Broker is required")]
    public required TerraformValue<string> Broker
    {
        get => new TerraformReference<string>(this, "broker");
        set => SetArgument("broker", value);
    }

    /// <summary>
    /// The include_control_details attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeControlDetails
    {
        get => new TerraformReference<bool>(this, "include_control_details");
        set => SetArgument("include_control_details", value);
    }

    /// <summary>
    /// The include_null_and_empty attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeNullAndEmpty
    {
        get => new TerraformReference<bool>(this, "include_null_and_empty");
        set => SetArgument("include_null_and_empty", value);
    }

    /// <summary>
    /// The include_partition_value attribute.
    /// </summary>
    public TerraformValue<bool>? IncludePartitionValue
    {
        get => new TerraformReference<bool>(this, "include_partition_value");
        set => SetArgument("include_partition_value", value);
    }

    /// <summary>
    /// The include_table_alter_operations attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeTableAlterOperations
    {
        get => new TerraformReference<bool>(this, "include_table_alter_operations");
        set => SetArgument("include_table_alter_operations", value);
    }

    /// <summary>
    /// The include_transaction_details attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeTransactionDetails
    {
        get => new TerraformReference<bool>(this, "include_transaction_details");
        set => SetArgument("include_transaction_details", value);
    }

    /// <summary>
    /// The message_format attribute.
    /// </summary>
    public TerraformValue<string>? MessageFormat
    {
        get => new TerraformReference<string>(this, "message_format");
        set => SetArgument("message_format", value);
    }

    /// <summary>
    /// The message_max_bytes attribute.
    /// </summary>
    public TerraformValue<double>? MessageMaxBytes
    {
        get => new TerraformReference<double>(this, "message_max_bytes");
        set => SetArgument("message_max_bytes", value);
    }

    /// <summary>
    /// The no_hex_prefix attribute.
    /// </summary>
    public TerraformValue<bool>? NoHexPrefix
    {
        get => new TerraformReference<bool>(this, "no_hex_prefix");
        set => SetArgument("no_hex_prefix", value);
    }

    /// <summary>
    /// The partition_include_schema_table attribute.
    /// </summary>
    public TerraformValue<bool>? PartitionIncludeSchemaTable
    {
        get => new TerraformReference<bool>(this, "partition_include_schema_table");
        set => SetArgument("partition_include_schema_table", value);
    }

    /// <summary>
    /// The sasl_mechanism attribute.
    /// </summary>
    public TerraformValue<string>? SaslMechanism
    {
        get => new TerraformReference<string>(this, "sasl_mechanism");
        set => SetArgument("sasl_mechanism", value);
    }

    /// <summary>
    /// The sasl_password attribute.
    /// </summary>
    public TerraformValue<string>? SaslPassword
    {
        get => new TerraformReference<string>(this, "sasl_password");
        set => SetArgument("sasl_password", value);
    }

    /// <summary>
    /// The sasl_username attribute.
    /// </summary>
    public TerraformValue<string>? SaslUsername
    {
        get => new TerraformReference<string>(this, "sasl_username");
        set => SetArgument("sasl_username", value);
    }

    /// <summary>
    /// The security_protocol attribute.
    /// </summary>
    public TerraformValue<string>? SecurityProtocol
    {
        get => new TerraformReference<string>(this, "security_protocol");
        set => SetArgument("security_protocol", value);
    }

    /// <summary>
    /// The ssl_ca_certificate_arn attribute.
    /// </summary>
    public TerraformValue<string>? SslCaCertificateArn
    {
        get => new TerraformReference<string>(this, "ssl_ca_certificate_arn");
        set => SetArgument("ssl_ca_certificate_arn", value);
    }

    /// <summary>
    /// The ssl_client_certificate_arn attribute.
    /// </summary>
    public TerraformValue<string>? SslClientCertificateArn
    {
        get => new TerraformReference<string>(this, "ssl_client_certificate_arn");
        set => SetArgument("ssl_client_certificate_arn", value);
    }

    /// <summary>
    /// The ssl_client_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? SslClientKeyArn
    {
        get => new TerraformReference<string>(this, "ssl_client_key_arn");
        set => SetArgument("ssl_client_key_arn", value);
    }

    /// <summary>
    /// The ssl_client_key_password attribute.
    /// </summary>
    public TerraformValue<string>? SslClientKeyPassword
    {
        get => new TerraformReference<string>(this, "ssl_client_key_password");
        set => SetArgument("ssl_client_key_password", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    public TerraformValue<string>? Topic
    {
        get => new TerraformReference<string>(this, "topic");
        set => SetArgument("topic", value);
    }

}


/// <summary>
/// Block type for kinesis_settings in AwsDmsEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointKinesisSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_settings";

    /// <summary>
    /// The include_control_details attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeControlDetails
    {
        get => new TerraformReference<bool>(this, "include_control_details");
        set => SetArgument("include_control_details", value);
    }

    /// <summary>
    /// The include_null_and_empty attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeNullAndEmpty
    {
        get => new TerraformReference<bool>(this, "include_null_and_empty");
        set => SetArgument("include_null_and_empty", value);
    }

    /// <summary>
    /// The include_partition_value attribute.
    /// </summary>
    public TerraformValue<bool>? IncludePartitionValue
    {
        get => new TerraformReference<bool>(this, "include_partition_value");
        set => SetArgument("include_partition_value", value);
    }

    /// <summary>
    /// The include_table_alter_operations attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeTableAlterOperations
    {
        get => new TerraformReference<bool>(this, "include_table_alter_operations");
        set => SetArgument("include_table_alter_operations", value);
    }

    /// <summary>
    /// The include_transaction_details attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeTransactionDetails
    {
        get => new TerraformReference<bool>(this, "include_transaction_details");
        set => SetArgument("include_transaction_details", value);
    }

    /// <summary>
    /// The message_format attribute.
    /// </summary>
    public TerraformValue<string>? MessageFormat
    {
        get => new TerraformReference<string>(this, "message_format");
        set => SetArgument("message_format", value);
    }

    /// <summary>
    /// The partition_include_schema_table attribute.
    /// </summary>
    public TerraformValue<bool>? PartitionIncludeSchemaTable
    {
        get => new TerraformReference<bool>(this, "partition_include_schema_table");
        set => SetArgument("partition_include_schema_table", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ServiceAccessRoleArn
    {
        get => new TerraformReference<string>(this, "service_access_role_arn");
        set => SetArgument("service_access_role_arn", value);
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformValue<string>? StreamArn
    {
        get => new TerraformReference<string>(this, "stream_arn");
        set => SetArgument("stream_arn", value);
    }

    /// <summary>
    /// The use_large_integer_value attribute.
    /// </summary>
    public TerraformValue<bool>? UseLargeIntegerValue
    {
        get => new TerraformReference<bool>(this, "use_large_integer_value");
        set => SetArgument("use_large_integer_value", value);
    }

}


/// <summary>
/// Block type for mongodb_settings in AwsDmsEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointMongodbSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mongodb_settings";

    /// <summary>
    /// The auth_mechanism attribute.
    /// </summary>
    public TerraformValue<string>? AuthMechanism
    {
        get => new TerraformReference<string>(this, "auth_mechanism");
        set => SetArgument("auth_mechanism", value);
    }

    /// <summary>
    /// The auth_source attribute.
    /// </summary>
    public TerraformValue<string>? AuthSource
    {
        get => new TerraformReference<string>(this, "auth_source");
        set => SetArgument("auth_source", value);
    }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    public TerraformValue<string>? AuthType
    {
        get => new TerraformReference<string>(this, "auth_type");
        set => SetArgument("auth_type", value);
    }

    /// <summary>
    /// The docs_to_investigate attribute.
    /// </summary>
    public TerraformValue<string>? DocsToInvestigate
    {
        get => new TerraformReference<string>(this, "docs_to_investigate");
        set => SetArgument("docs_to_investigate", value);
    }

    /// <summary>
    /// The extract_doc_id attribute.
    /// </summary>
    public TerraformValue<string>? ExtractDocId
    {
        get => new TerraformReference<string>(this, "extract_doc_id");
        set => SetArgument("extract_doc_id", value);
    }

    /// <summary>
    /// The nesting_level attribute.
    /// </summary>
    public TerraformValue<string>? NestingLevel
    {
        get => new TerraformReference<string>(this, "nesting_level");
        set => SetArgument("nesting_level", value);
    }

}


/// <summary>
/// Block type for mysql_settings in AwsDmsEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointMysqlSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mysql_settings";

    /// <summary>
    /// The after_connect_script attribute.
    /// </summary>
    public TerraformValue<string> AfterConnectScript
    {
        get => new TerraformReference<string>(this, "after_connect_script");
        set => SetArgument("after_connect_script", value);
    }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    public TerraformValue<string> AuthenticationMethod
    {
        get => new TerraformReference<string>(this, "authentication_method");
        set => SetArgument("authentication_method", value);
    }

    /// <summary>
    /// The clean_source_metadata_on_mismatch attribute.
    /// </summary>
    public TerraformValue<bool> CleanSourceMetadataOnMismatch
    {
        get => new TerraformReference<bool>(this, "clean_source_metadata_on_mismatch");
        set => SetArgument("clean_source_metadata_on_mismatch", value);
    }

    /// <summary>
    /// The events_poll_interval attribute.
    /// </summary>
    public TerraformValue<double> EventsPollInterval
    {
        get => new TerraformReference<double>(this, "events_poll_interval");
        set => SetArgument("events_poll_interval", value);
    }

    /// <summary>
    /// The execute_timeout attribute.
    /// </summary>
    public TerraformValue<double> ExecuteTimeout
    {
        get => new TerraformReference<double>(this, "execute_timeout");
        set => SetArgument("execute_timeout", value);
    }

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    public TerraformValue<double> MaxFileSize
    {
        get => new TerraformReference<double>(this, "max_file_size");
        set => SetArgument("max_file_size", value);
    }

    /// <summary>
    /// The parallel_load_threads attribute.
    /// </summary>
    public TerraformValue<double> ParallelLoadThreads
    {
        get => new TerraformReference<double>(this, "parallel_load_threads");
        set => SetArgument("parallel_load_threads", value);
    }

    /// <summary>
    /// The server_timezone attribute.
    /// </summary>
    public TerraformValue<string> ServerTimezone
    {
        get => new TerraformReference<string>(this, "server_timezone");
        set => SetArgument("server_timezone", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    public TerraformValue<string> ServiceAccessRoleArn
    {
        get => new TerraformReference<string>(this, "service_access_role_arn");
        set => SetArgument("service_access_role_arn", value);
    }

    /// <summary>
    /// The target_db_type attribute.
    /// </summary>
    public TerraformValue<string> TargetDbType
    {
        get => new TerraformReference<string>(this, "target_db_type");
        set => SetArgument("target_db_type", value);
    }

}


/// <summary>
/// Block type for oracle_settings in AwsDmsEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointOracleSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oracle_settings";

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    public TerraformValue<string> AuthenticationMethod
    {
        get => new TerraformReference<string>(this, "authentication_method");
        set => SetArgument("authentication_method", value);
    }

}


/// <summary>
/// Block type for postgres_settings in AwsDmsEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointPostgresSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgres_settings";

    /// <summary>
    /// The after_connect_script attribute.
    /// </summary>
    public TerraformValue<string>? AfterConnectScript
    {
        get => new TerraformReference<string>(this, "after_connect_script");
        set => SetArgument("after_connect_script", value);
    }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    public TerraformValue<string> AuthenticationMethod
    {
        get => new TerraformReference<string>(this, "authentication_method");
        set => SetArgument("authentication_method", value);
    }

    /// <summary>
    /// The babelfish_database_name attribute.
    /// </summary>
    public TerraformValue<string>? BabelfishDatabaseName
    {
        get => new TerraformReference<string>(this, "babelfish_database_name");
        set => SetArgument("babelfish_database_name", value);
    }

    /// <summary>
    /// The capture_ddls attribute.
    /// </summary>
    public TerraformValue<bool>? CaptureDdls
    {
        get => new TerraformReference<bool>(this, "capture_ddls");
        set => SetArgument("capture_ddls", value);
    }

    /// <summary>
    /// The database_mode attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseMode
    {
        get => new TerraformReference<string>(this, "database_mode");
        set => SetArgument("database_mode", value);
    }

    /// <summary>
    /// The ddl_artifacts_schema attribute.
    /// </summary>
    public TerraformValue<string>? DdlArtifactsSchema
    {
        get => new TerraformReference<string>(this, "ddl_artifacts_schema");
        set => SetArgument("ddl_artifacts_schema", value);
    }

    /// <summary>
    /// The execute_timeout attribute.
    /// </summary>
    public TerraformValue<double>? ExecuteTimeout
    {
        get => new TerraformReference<double>(this, "execute_timeout");
        set => SetArgument("execute_timeout", value);
    }

    /// <summary>
    /// The fail_tasks_on_lob_truncation attribute.
    /// </summary>
    public TerraformValue<bool>? FailTasksOnLobTruncation
    {
        get => new TerraformReference<bool>(this, "fail_tasks_on_lob_truncation");
        set => SetArgument("fail_tasks_on_lob_truncation", value);
    }

    /// <summary>
    /// The heartbeat_enable attribute.
    /// </summary>
    public TerraformValue<bool>? HeartbeatEnable
    {
        get => new TerraformReference<bool>(this, "heartbeat_enable");
        set => SetArgument("heartbeat_enable", value);
    }

    /// <summary>
    /// The heartbeat_frequency attribute.
    /// </summary>
    public TerraformValue<double>? HeartbeatFrequency
    {
        get => new TerraformReference<double>(this, "heartbeat_frequency");
        set => SetArgument("heartbeat_frequency", value);
    }

    /// <summary>
    /// The heartbeat_schema attribute.
    /// </summary>
    public TerraformValue<string>? HeartbeatSchema
    {
        get => new TerraformReference<string>(this, "heartbeat_schema");
        set => SetArgument("heartbeat_schema", value);
    }

    /// <summary>
    /// The map_boolean_as_boolean attribute.
    /// </summary>
    public TerraformValue<bool>? MapBooleanAsBoolean
    {
        get => new TerraformReference<bool>(this, "map_boolean_as_boolean");
        set => SetArgument("map_boolean_as_boolean", value);
    }

    /// <summary>
    /// The map_jsonb_as_clob attribute.
    /// </summary>
    public TerraformValue<bool>? MapJsonbAsClob
    {
        get => new TerraformReference<bool>(this, "map_jsonb_as_clob");
        set => SetArgument("map_jsonb_as_clob", value);
    }

    /// <summary>
    /// The map_long_varchar_as attribute.
    /// </summary>
    public TerraformValue<string>? MapLongVarcharAs
    {
        get => new TerraformReference<string>(this, "map_long_varchar_as");
        set => SetArgument("map_long_varchar_as", value);
    }

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    public TerraformValue<double>? MaxFileSize
    {
        get => new TerraformReference<double>(this, "max_file_size");
        set => SetArgument("max_file_size", value);
    }

    /// <summary>
    /// The plugin_name attribute.
    /// </summary>
    public TerraformValue<string>? PluginName
    {
        get => new TerraformReference<string>(this, "plugin_name");
        set => SetArgument("plugin_name", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ServiceAccessRoleArn
    {
        get => new TerraformReference<string>(this, "service_access_role_arn");
        set => SetArgument("service_access_role_arn", value);
    }

    /// <summary>
    /// The slot_name attribute.
    /// </summary>
    public TerraformValue<string>? SlotName
    {
        get => new TerraformReference<string>(this, "slot_name");
        set => SetArgument("slot_name", value);
    }

}


/// <summary>
/// Block type for redis_settings in AwsDmsEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointRedisSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redis_settings";

    /// <summary>
    /// The auth_password attribute.
    /// </summary>
    public TerraformValue<string>? AuthPassword
    {
        get => new TerraformReference<string>(this, "auth_password");
        set => SetArgument("auth_password", value);
    }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformValue<string> AuthType
    {
        get => new TerraformReference<string>(this, "auth_type");
        set => SetArgument("auth_type", value);
    }

    /// <summary>
    /// The auth_user_name attribute.
    /// </summary>
    public TerraformValue<string>? AuthUserName
    {
        get => new TerraformReference<string>(this, "auth_user_name");
        set => SetArgument("auth_user_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    public required TerraformValue<string> ServerName
    {
        get => new TerraformReference<string>(this, "server_name");
        set => SetArgument("server_name", value);
    }

    /// <summary>
    /// The ssl_ca_certificate_arn attribute.
    /// </summary>
    public TerraformValue<string>? SslCaCertificateArn
    {
        get => new TerraformReference<string>(this, "ssl_ca_certificate_arn");
        set => SetArgument("ssl_ca_certificate_arn", value);
    }

    /// <summary>
    /// The ssl_security_protocol attribute.
    /// </summary>
    public TerraformValue<string>? SslSecurityProtocol
    {
        get => new TerraformReference<string>(this, "ssl_security_protocol");
        set => SetArgument("ssl_security_protocol", value);
    }

}


/// <summary>
/// Block type for redshift_settings in AwsDmsEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointRedshiftSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redshift_settings";

    /// <summary>
    /// The bucket_folder attribute.
    /// </summary>
    public TerraformValue<string>? BucketFolder
    {
        get => new TerraformReference<string>(this, "bucket_folder");
        set => SetArgument("bucket_folder", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => new TerraformReference<string>(this, "bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionMode
    {
        get => new TerraformReference<string>(this, "encryption_mode");
        set => SetArgument("encryption_mode", value);
    }

    /// <summary>
    /// The server_side_encryption_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? ServerSideEncryptionKmsKeyId
    {
        get => new TerraformReference<string>(this, "server_side_encryption_kms_key_id");
        set => SetArgument("server_side_encryption_kms_key_id", value);
    }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ServiceAccessRoleArn
    {
        get => new TerraformReference<string>(this, "service_access_role_arn");
        set => SetArgument("service_access_role_arn", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDmsEndpoint.
/// Nesting mode: single
/// </summary>
public class AwsDmsEndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_dms_endpoint Terraform resource.
/// Manages a aws_dms_endpoint resource.
/// </summary>
public partial class AwsDmsEndpoint(string name) : TerraformResource("aws_dms_endpoint", name)
{
    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> CertificateArn
    {
        get => new TerraformReference<string>(this, "certificate_arn");
        set => SetArgument("certificate_arn", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointId is required")]
    public required TerraformValue<string> EndpointId
    {
        get => new TerraformReference<string>(this, "endpoint_id");
        set => SetArgument("endpoint_id", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    public required TerraformValue<string> EndpointType
    {
        get => new TerraformReference<string>(this, "endpoint_type");
        set => SetArgument("endpoint_type", value);
    }

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineName is required")]
    public required TerraformValue<string> EngineName
    {
        get => new TerraformReference<string>(this, "engine_name");
        set => SetArgument("engine_name", value);
    }

    /// <summary>
    /// The extra_connection_attributes attribute.
    /// </summary>
    public TerraformValue<string> ExtraConnectionAttributes
    {
        get => new TerraformReference<string>(this, "extra_connection_attributes");
        set => SetArgument("extra_connection_attributes", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The pause_replication_tasks attribute.
    /// </summary>
    public TerraformValue<bool>? PauseReplicationTasks
    {
        get => new TerraformReference<bool>(this, "pause_replication_tasks");
        set => SetArgument("pause_replication_tasks", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The secrets_manager_access_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? SecretsManagerAccessRoleArn
    {
        get => new TerraformReference<string>(this, "secrets_manager_access_role_arn");
        set => SetArgument("secrets_manager_access_role_arn", value);
    }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    public TerraformValue<string>? SecretsManagerArn
    {
        get => new TerraformReference<string>(this, "secrets_manager_arn");
        set => SetArgument("secrets_manager_arn", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public TerraformValue<string>? ServerName
    {
        get => new TerraformReference<string>(this, "server_name");
        set => SetArgument("server_name", value);
    }

    /// <summary>
    /// The service_access_role attribute.
    /// </summary>
    public TerraformValue<string>? ServiceAccessRole
    {
        get => new TerraformReference<string>(this, "service_access_role");
        set => SetArgument("service_access_role", value);
    }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    public TerraformValue<string> SslMode
    {
        get => new TerraformReference<string>(this, "ssl_mode");
        set => SetArgument("ssl_mode", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    public TerraformValue<string> EndpointArn
    {
        get => new TerraformReference<string>(this, "endpoint_arn");
    }

    /// <summary>
    /// ElasticsearchSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchSettings block(s) allowed")]
    public TerraformList<AwsDmsEndpointElasticsearchSettingsBlock>? ElasticsearchSettings
    {
        get => GetArgument<TerraformList<AwsDmsEndpointElasticsearchSettingsBlock>>("elasticsearch_settings");
        set => SetArgument("elasticsearch_settings", value);
    }

    /// <summary>
    /// KafkaSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaSettings block(s) allowed")]
    public TerraformList<AwsDmsEndpointKafkaSettingsBlock>? KafkaSettings
    {
        get => GetArgument<TerraformList<AwsDmsEndpointKafkaSettingsBlock>>("kafka_settings");
        set => SetArgument("kafka_settings", value);
    }

    /// <summary>
    /// KinesisSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisSettings block(s) allowed")]
    public TerraformList<AwsDmsEndpointKinesisSettingsBlock>? KinesisSettings
    {
        get => GetArgument<TerraformList<AwsDmsEndpointKinesisSettingsBlock>>("kinesis_settings");
        set => SetArgument("kinesis_settings", value);
    }

    /// <summary>
    /// MongodbSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MongodbSettings block(s) allowed")]
    public TerraformList<AwsDmsEndpointMongodbSettingsBlock>? MongodbSettings
    {
        get => GetArgument<TerraformList<AwsDmsEndpointMongodbSettingsBlock>>("mongodb_settings");
        set => SetArgument("mongodb_settings", value);
    }

    /// <summary>
    /// MysqlSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MysqlSettings block(s) allowed")]
    public TerraformList<AwsDmsEndpointMysqlSettingsBlock>? MysqlSettings
    {
        get => GetArgument<TerraformList<AwsDmsEndpointMysqlSettingsBlock>>("mysql_settings");
        set => SetArgument("mysql_settings", value);
    }

    /// <summary>
    /// OracleSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OracleSettings block(s) allowed")]
    public TerraformList<AwsDmsEndpointOracleSettingsBlock>? OracleSettings
    {
        get => GetArgument<TerraformList<AwsDmsEndpointOracleSettingsBlock>>("oracle_settings");
        set => SetArgument("oracle_settings", value);
    }

    /// <summary>
    /// PostgresSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostgresSettings block(s) allowed")]
    public TerraformList<AwsDmsEndpointPostgresSettingsBlock>? PostgresSettings
    {
        get => GetArgument<TerraformList<AwsDmsEndpointPostgresSettingsBlock>>("postgres_settings");
        set => SetArgument("postgres_settings", value);
    }

    /// <summary>
    /// RedisSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedisSettings block(s) allowed")]
    public TerraformList<AwsDmsEndpointRedisSettingsBlock>? RedisSettings
    {
        get => GetArgument<TerraformList<AwsDmsEndpointRedisSettingsBlock>>("redis_settings");
        set => SetArgument("redis_settings", value);
    }

    /// <summary>
    /// RedshiftSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftSettings block(s) allowed")]
    public TerraformList<AwsDmsEndpointRedshiftSettingsBlock>? RedshiftSettings
    {
        get => GetArgument<TerraformList<AwsDmsEndpointRedshiftSettingsBlock>>("redshift_settings");
        set => SetArgument("redshift_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDmsEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDmsEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
