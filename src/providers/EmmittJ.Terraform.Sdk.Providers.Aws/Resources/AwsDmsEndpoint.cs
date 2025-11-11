using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for elasticsearch_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointElasticsearchSettingsBlock
{
    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointUri is required")]
    [TerraformPropertyName("endpoint_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EndpointUri { get; set; }

    /// <summary>
    /// The error_retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("error_retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ErrorRetryDuration { get; set; }

    /// <summary>
    /// The full_load_error_percentage attribute.
    /// </summary>
    [TerraformPropertyName("full_load_error_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? FullLoadErrorPercentage { get; set; }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccessRoleArn is required")]
    [TerraformPropertyName("service_access_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceAccessRoleArn { get; set; }

    /// <summary>
    /// The use_new_mapping_type attribute.
    /// </summary>
    [TerraformPropertyName("use_new_mapping_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseNewMappingType { get; set; }

}

/// <summary>
/// Block type for kafka_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointKafkaSettingsBlock
{
    /// <summary>
    /// The broker attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Broker is required")]
    [TerraformPropertyName("broker")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Broker { get; set; }

    /// <summary>
    /// The include_control_details attribute.
    /// </summary>
    [TerraformPropertyName("include_control_details")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeControlDetails { get; set; }

    /// <summary>
    /// The include_null_and_empty attribute.
    /// </summary>
    [TerraformPropertyName("include_null_and_empty")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeNullAndEmpty { get; set; }

    /// <summary>
    /// The include_partition_value attribute.
    /// </summary>
    [TerraformPropertyName("include_partition_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludePartitionValue { get; set; }

    /// <summary>
    /// The include_table_alter_operations attribute.
    /// </summary>
    [TerraformPropertyName("include_table_alter_operations")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeTableAlterOperations { get; set; }

    /// <summary>
    /// The include_transaction_details attribute.
    /// </summary>
    [TerraformPropertyName("include_transaction_details")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeTransactionDetails { get; set; }

    /// <summary>
    /// The message_format attribute.
    /// </summary>
    [TerraformPropertyName("message_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MessageFormat { get; set; }

    /// <summary>
    /// The message_max_bytes attribute.
    /// </summary>
    [TerraformPropertyName("message_max_bytes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MessageMaxBytes { get; set; }

    /// <summary>
    /// The no_hex_prefix attribute.
    /// </summary>
    [TerraformPropertyName("no_hex_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NoHexPrefix { get; set; }

    /// <summary>
    /// The partition_include_schema_table attribute.
    /// </summary>
    [TerraformPropertyName("partition_include_schema_table")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PartitionIncludeSchemaTable { get; set; }

    /// <summary>
    /// The sasl_mechanism attribute.
    /// </summary>
    [TerraformPropertyName("sasl_mechanism")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SaslMechanism { get; set; }

    /// <summary>
    /// The sasl_password attribute.
    /// </summary>
    [TerraformPropertyName("sasl_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SaslPassword { get; set; }

    /// <summary>
    /// The sasl_username attribute.
    /// </summary>
    [TerraformPropertyName("sasl_username")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SaslUsername { get; set; }

    /// <summary>
    /// The security_protocol attribute.
    /// </summary>
    [TerraformPropertyName("security_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecurityProtocol { get; set; }

    /// <summary>
    /// The ssl_ca_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("ssl_ca_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslCaCertificateArn { get; set; }

    /// <summary>
    /// The ssl_client_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("ssl_client_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslClientCertificateArn { get; set; }

    /// <summary>
    /// The ssl_client_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("ssl_client_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslClientKeyArn { get; set; }

    /// <summary>
    /// The ssl_client_key_password attribute.
    /// </summary>
    [TerraformPropertyName("ssl_client_key_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslClientKeyPassword { get; set; }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [TerraformPropertyName("topic")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Topic { get; set; }

}

/// <summary>
/// Block type for kinesis_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointKinesisSettingsBlock
{
    /// <summary>
    /// The include_control_details attribute.
    /// </summary>
    [TerraformPropertyName("include_control_details")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeControlDetails { get; set; }

    /// <summary>
    /// The include_null_and_empty attribute.
    /// </summary>
    [TerraformPropertyName("include_null_and_empty")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeNullAndEmpty { get; set; }

    /// <summary>
    /// The include_partition_value attribute.
    /// </summary>
    [TerraformPropertyName("include_partition_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludePartitionValue { get; set; }

    /// <summary>
    /// The include_table_alter_operations attribute.
    /// </summary>
    [TerraformPropertyName("include_table_alter_operations")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeTableAlterOperations { get; set; }

    /// <summary>
    /// The include_transaction_details attribute.
    /// </summary>
    [TerraformPropertyName("include_transaction_details")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeTransactionDetails { get; set; }

    /// <summary>
    /// The message_format attribute.
    /// </summary>
    [TerraformPropertyName("message_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MessageFormat { get; set; }

    /// <summary>
    /// The partition_include_schema_table attribute.
    /// </summary>
    [TerraformPropertyName("partition_include_schema_table")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PartitionIncludeSchemaTable { get; set; }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_access_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceAccessRoleArn { get; set; }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [TerraformPropertyName("stream_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StreamArn { get; set; }

    /// <summary>
    /// The use_large_integer_value attribute.
    /// </summary>
    [TerraformPropertyName("use_large_integer_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseLargeIntegerValue { get; set; }

}

/// <summary>
/// Block type for mongodb_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointMongodbSettingsBlock
{
    /// <summary>
    /// The auth_mechanism attribute.
    /// </summary>
    [TerraformPropertyName("auth_mechanism")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthMechanism { get; set; }

    /// <summary>
    /// The auth_source attribute.
    /// </summary>
    [TerraformPropertyName("auth_source")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthSource { get; set; }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [TerraformPropertyName("auth_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthType { get; set; }

    /// <summary>
    /// The docs_to_investigate attribute.
    /// </summary>
    [TerraformPropertyName("docs_to_investigate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DocsToInvestigate { get; set; }

    /// <summary>
    /// The extract_doc_id attribute.
    /// </summary>
    [TerraformPropertyName("extract_doc_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExtractDocId { get; set; }

    /// <summary>
    /// The nesting_level attribute.
    /// </summary>
    [TerraformPropertyName("nesting_level")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NestingLevel { get; set; }

}

/// <summary>
/// Block type for mysql_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointMysqlSettingsBlock
{
    /// <summary>
    /// The after_connect_script attribute.
    /// </summary>
    [TerraformPropertyName("after_connect_script")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AfterConnectScript { get; set; } = default!;

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [TerraformPropertyName("authentication_method")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AuthenticationMethod { get; set; } = default!;

    /// <summary>
    /// The clean_source_metadata_on_mismatch attribute.
    /// </summary>
    [TerraformPropertyName("clean_source_metadata_on_mismatch")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> CleanSourceMetadataOnMismatch { get; set; } = default!;

    /// <summary>
    /// The events_poll_interval attribute.
    /// </summary>
    [TerraformPropertyName("events_poll_interval")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> EventsPollInterval { get; set; } = default!;

    /// <summary>
    /// The execute_timeout attribute.
    /// </summary>
    [TerraformPropertyName("execute_timeout")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ExecuteTimeout { get; set; } = default!;

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    [TerraformPropertyName("max_file_size")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxFileSize { get; set; } = default!;

    /// <summary>
    /// The parallel_load_threads attribute.
    /// </summary>
    [TerraformPropertyName("parallel_load_threads")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ParallelLoadThreads { get; set; } = default!;

    /// <summary>
    /// The server_timezone attribute.
    /// </summary>
    [TerraformPropertyName("server_timezone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServerTimezone { get; set; } = default!;

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_access_role_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceAccessRoleArn { get; set; } = default!;

    /// <summary>
    /// The target_db_type attribute.
    /// </summary>
    [TerraformPropertyName("target_db_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TargetDbType { get; set; } = default!;

}

/// <summary>
/// Block type for oracle_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointOracleSettingsBlock
{
    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [TerraformPropertyName("authentication_method")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AuthenticationMethod { get; set; } = default!;

}

/// <summary>
/// Block type for postgres_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointPostgresSettingsBlock
{
    /// <summary>
    /// The after_connect_script attribute.
    /// </summary>
    [TerraformPropertyName("after_connect_script")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AfterConnectScript { get; set; }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [TerraformPropertyName("authentication_method")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AuthenticationMethod { get; set; } = default!;

    /// <summary>
    /// The babelfish_database_name attribute.
    /// </summary>
    [TerraformPropertyName("babelfish_database_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BabelfishDatabaseName { get; set; }

    /// <summary>
    /// The capture_ddls attribute.
    /// </summary>
    [TerraformPropertyName("capture_ddls")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CaptureDdls { get; set; }

    /// <summary>
    /// The database_mode attribute.
    /// </summary>
    [TerraformPropertyName("database_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DatabaseMode { get; set; }

    /// <summary>
    /// The ddl_artifacts_schema attribute.
    /// </summary>
    [TerraformPropertyName("ddl_artifacts_schema")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DdlArtifactsSchema { get; set; }

    /// <summary>
    /// The execute_timeout attribute.
    /// </summary>
    [TerraformPropertyName("execute_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ExecuteTimeout { get; set; }

    /// <summary>
    /// The fail_tasks_on_lob_truncation attribute.
    /// </summary>
    [TerraformPropertyName("fail_tasks_on_lob_truncation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FailTasksOnLobTruncation { get; set; }

    /// <summary>
    /// The heartbeat_enable attribute.
    /// </summary>
    [TerraformPropertyName("heartbeat_enable")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HeartbeatEnable { get; set; }

    /// <summary>
    /// The heartbeat_frequency attribute.
    /// </summary>
    [TerraformPropertyName("heartbeat_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? HeartbeatFrequency { get; set; }

    /// <summary>
    /// The heartbeat_schema attribute.
    /// </summary>
    [TerraformPropertyName("heartbeat_schema")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HeartbeatSchema { get; set; }

    /// <summary>
    /// The map_boolean_as_boolean attribute.
    /// </summary>
    [TerraformPropertyName("map_boolean_as_boolean")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MapBooleanAsBoolean { get; set; }

    /// <summary>
    /// The map_jsonb_as_clob attribute.
    /// </summary>
    [TerraformPropertyName("map_jsonb_as_clob")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MapJsonbAsClob { get; set; }

    /// <summary>
    /// The map_long_varchar_as attribute.
    /// </summary>
    [TerraformPropertyName("map_long_varchar_as")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MapLongVarcharAs { get; set; }

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    [TerraformPropertyName("max_file_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxFileSize { get; set; }

    /// <summary>
    /// The plugin_name attribute.
    /// </summary>
    [TerraformPropertyName("plugin_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PluginName { get; set; }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_access_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceAccessRoleArn { get; set; }

    /// <summary>
    /// The slot_name attribute.
    /// </summary>
    [TerraformPropertyName("slot_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SlotName { get; set; }

}

/// <summary>
/// Block type for redis_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointRedisSettingsBlock
{
    /// <summary>
    /// The auth_password attribute.
    /// </summary>
    [TerraformPropertyName("auth_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthPassword { get; set; }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    [TerraformPropertyName("auth_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AuthType { get; set; }

    /// <summary>
    /// The auth_user_name attribute.
    /// </summary>
    [TerraformPropertyName("auth_user_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthUserName { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformPropertyName("port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    [TerraformPropertyName("server_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServerName { get; set; }

    /// <summary>
    /// The ssl_ca_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("ssl_ca_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslCaCertificateArn { get; set; }

    /// <summary>
    /// The ssl_security_protocol attribute.
    /// </summary>
    [TerraformPropertyName("ssl_security_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslSecurityProtocol { get; set; }

}

/// <summary>
/// Block type for redshift_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointRedshiftSettingsBlock
{
    /// <summary>
    /// The bucket_folder attribute.
    /// </summary>
    [TerraformPropertyName("bucket_folder")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BucketFolder { get; set; }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [TerraformPropertyName("bucket_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BucketName { get; set; }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    [TerraformPropertyName("encryption_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EncryptionMode { get; set; }

    /// <summary>
    /// The server_side_encryption_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("server_side_encryption_kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServerSideEncryptionKmsKeyId { get; set; }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_access_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceAccessRoleArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDmsEndpointTimeoutsBlock
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

}

/// <summary>
/// Manages a aws_dms_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDmsEndpoint : TerraformResource
{
    public AwsDmsEndpoint(string name) : base("aws_dms_endpoint", name)
    {
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CertificateArn { get; set; } = default!;

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformPropertyName("database_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DatabaseName { get; set; }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointId is required")]
    [TerraformPropertyName("endpoint_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EndpointId { get; set; }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    [TerraformPropertyName("endpoint_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EndpointType { get; set; }

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineName is required")]
    [TerraformPropertyName("engine_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EngineName { get; set; }

    /// <summary>
    /// The extra_connection_attributes attribute.
    /// </summary>
    [TerraformPropertyName("extra_connection_attributes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ExtraConnectionAttributes { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyArn { get; set; } = default!;

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The pause_replication_tasks attribute.
    /// </summary>
    [TerraformPropertyName("pause_replication_tasks")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PauseReplicationTasks { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The secrets_manager_access_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("secrets_manager_access_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecretsManagerAccessRoleArn { get; set; }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    [TerraformPropertyName("secrets_manager_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecretsManagerArn { get; set; }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [TerraformPropertyName("server_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServerName { get; set; }

    /// <summary>
    /// The service_access_role attribute.
    /// </summary>
    [TerraformPropertyName("service_access_role")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceAccessRole { get; set; }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    [TerraformPropertyName("ssl_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SslMode { get; set; } = default!;

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
    /// The username attribute.
    /// </summary>
    [TerraformPropertyName("username")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Username { get; set; }

    /// <summary>
    /// Block for elasticsearch_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchSettings block(s) allowed")]
    [TerraformPropertyName("elasticsearch_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointElasticsearchSettingsBlock>>? ElasticsearchSettings { get; set; }

    /// <summary>
    /// Block for kafka_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaSettings block(s) allowed")]
    [TerraformPropertyName("kafka_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointKafkaSettingsBlock>>? KafkaSettings { get; set; }

    /// <summary>
    /// Block for kinesis_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisSettings block(s) allowed")]
    [TerraformPropertyName("kinesis_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointKinesisSettingsBlock>>? KinesisSettings { get; set; }

    /// <summary>
    /// Block for mongodb_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MongodbSettings block(s) allowed")]
    [TerraformPropertyName("mongodb_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointMongodbSettingsBlock>>? MongodbSettings { get; set; }

    /// <summary>
    /// Block for mysql_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MysqlSettings block(s) allowed")]
    [TerraformPropertyName("mysql_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointMysqlSettingsBlock>>? MysqlSettings { get; set; }

    /// <summary>
    /// Block for oracle_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OracleSettings block(s) allowed")]
    [TerraformPropertyName("oracle_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointOracleSettingsBlock>>? OracleSettings { get; set; }

    /// <summary>
    /// Block for postgres_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostgresSettings block(s) allowed")]
    [TerraformPropertyName("postgres_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointPostgresSettingsBlock>>? PostgresSettings { get; set; }

    /// <summary>
    /// Block for redis_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedisSettings block(s) allowed")]
    [TerraformPropertyName("redis_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointRedisSettingsBlock>>? RedisSettings { get; set; }

    /// <summary>
    /// Block for redshift_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftSettings block(s) allowed")]
    [TerraformPropertyName("redshift_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointRedshiftSettingsBlock>>? RedshiftSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDmsEndpointTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EndpointArn => new TerraformReference(this, "endpoint_arn");

}
