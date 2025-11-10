using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for elasticsearch_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointElasticsearchSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointUri is required")]
    [TerraformPropertyName("endpoint_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EndpointUri { get; set; }

    /// <summary>
    /// The error_retry_duration attribute.
    /// </summary>
    [TerraformPropertyName("error_retry_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ErrorRetryDuration { get; set; }

    /// <summary>
    /// The full_load_error_percentage attribute.
    /// </summary>
    [TerraformPropertyName("full_load_error_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FullLoadErrorPercentage { get; set; }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccessRoleArn is required")]
    [TerraformPropertyName("service_access_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceAccessRoleArn { get; set; }

    /// <summary>
    /// The use_new_mapping_type attribute.
    /// </summary>
    [TerraformPropertyName("use_new_mapping_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseNewMappingType { get; set; }

}

/// <summary>
/// Block type for kafka_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointKafkaSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The broker attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Broker is required")]
    [TerraformPropertyName("broker")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Broker { get; set; }

    /// <summary>
    /// The include_control_details attribute.
    /// </summary>
    [TerraformPropertyName("include_control_details")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeControlDetails { get; set; }

    /// <summary>
    /// The include_null_and_empty attribute.
    /// </summary>
    [TerraformPropertyName("include_null_and_empty")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeNullAndEmpty { get; set; }

    /// <summary>
    /// The include_partition_value attribute.
    /// </summary>
    [TerraformPropertyName("include_partition_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludePartitionValue { get; set; }

    /// <summary>
    /// The include_table_alter_operations attribute.
    /// </summary>
    [TerraformPropertyName("include_table_alter_operations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeTableAlterOperations { get; set; }

    /// <summary>
    /// The include_transaction_details attribute.
    /// </summary>
    [TerraformPropertyName("include_transaction_details")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeTransactionDetails { get; set; }

    /// <summary>
    /// The message_format attribute.
    /// </summary>
    [TerraformPropertyName("message_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MessageFormat { get; set; }

    /// <summary>
    /// The message_max_bytes attribute.
    /// </summary>
    [TerraformPropertyName("message_max_bytes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MessageMaxBytes { get; set; }

    /// <summary>
    /// The no_hex_prefix attribute.
    /// </summary>
    [TerraformPropertyName("no_hex_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NoHexPrefix { get; set; }

    /// <summary>
    /// The partition_include_schema_table attribute.
    /// </summary>
    [TerraformPropertyName("partition_include_schema_table")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PartitionIncludeSchemaTable { get; set; }

    /// <summary>
    /// The sasl_mechanism attribute.
    /// </summary>
    [TerraformPropertyName("sasl_mechanism")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SaslMechanism { get; set; }

    /// <summary>
    /// The sasl_password attribute.
    /// </summary>
    [TerraformPropertyName("sasl_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SaslPassword { get; set; }

    /// <summary>
    /// The sasl_username attribute.
    /// </summary>
    [TerraformPropertyName("sasl_username")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SaslUsername { get; set; }

    /// <summary>
    /// The security_protocol attribute.
    /// </summary>
    [TerraformPropertyName("security_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecurityProtocol { get; set; }

    /// <summary>
    /// The ssl_ca_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("ssl_ca_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslCaCertificateArn { get; set; }

    /// <summary>
    /// The ssl_client_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("ssl_client_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslClientCertificateArn { get; set; }

    /// <summary>
    /// The ssl_client_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("ssl_client_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslClientKeyArn { get; set; }

    /// <summary>
    /// The ssl_client_key_password attribute.
    /// </summary>
    [TerraformPropertyName("ssl_client_key_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslClientKeyPassword { get; set; }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [TerraformPropertyName("topic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Topic { get; set; }

}

/// <summary>
/// Block type for kinesis_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointKinesisSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The include_control_details attribute.
    /// </summary>
    [TerraformPropertyName("include_control_details")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeControlDetails { get; set; }

    /// <summary>
    /// The include_null_and_empty attribute.
    /// </summary>
    [TerraformPropertyName("include_null_and_empty")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeNullAndEmpty { get; set; }

    /// <summary>
    /// The include_partition_value attribute.
    /// </summary>
    [TerraformPropertyName("include_partition_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludePartitionValue { get; set; }

    /// <summary>
    /// The include_table_alter_operations attribute.
    /// </summary>
    [TerraformPropertyName("include_table_alter_operations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeTableAlterOperations { get; set; }

    /// <summary>
    /// The include_transaction_details attribute.
    /// </summary>
    [TerraformPropertyName("include_transaction_details")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeTransactionDetails { get; set; }

    /// <summary>
    /// The message_format attribute.
    /// </summary>
    [TerraformPropertyName("message_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MessageFormat { get; set; }

    /// <summary>
    /// The partition_include_schema_table attribute.
    /// </summary>
    [TerraformPropertyName("partition_include_schema_table")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PartitionIncludeSchemaTable { get; set; }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_access_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceAccessRoleArn { get; set; }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [TerraformPropertyName("stream_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StreamArn { get; set; }

    /// <summary>
    /// The use_large_integer_value attribute.
    /// </summary>
    [TerraformPropertyName("use_large_integer_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseLargeIntegerValue { get; set; }

}

/// <summary>
/// Block type for mongodb_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointMongodbSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The auth_mechanism attribute.
    /// </summary>
    [TerraformPropertyName("auth_mechanism")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthMechanism { get; set; }

    /// <summary>
    /// The auth_source attribute.
    /// </summary>
    [TerraformPropertyName("auth_source")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthSource { get; set; }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [TerraformPropertyName("auth_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthType { get; set; }

    /// <summary>
    /// The docs_to_investigate attribute.
    /// </summary>
    [TerraformPropertyName("docs_to_investigate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DocsToInvestigate { get; set; }

    /// <summary>
    /// The extract_doc_id attribute.
    /// </summary>
    [TerraformPropertyName("extract_doc_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExtractDocId { get; set; }

    /// <summary>
    /// The nesting_level attribute.
    /// </summary>
    [TerraformPropertyName("nesting_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NestingLevel { get; set; }

}

/// <summary>
/// Block type for mysql_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointMysqlSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The after_connect_script attribute.
    /// </summary>
    [TerraformPropertyName("after_connect_script")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AfterConnectScript { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "after_connect_script");

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [TerraformPropertyName("authentication_method")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AuthenticationMethod { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "authentication_method");

    /// <summary>
    /// The clean_source_metadata_on_mismatch attribute.
    /// </summary>
    [TerraformPropertyName("clean_source_metadata_on_mismatch")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> CleanSourceMetadataOnMismatch { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "clean_source_metadata_on_mismatch");

    /// <summary>
    /// The events_poll_interval attribute.
    /// </summary>
    [TerraformPropertyName("events_poll_interval")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> EventsPollInterval { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "events_poll_interval");

    /// <summary>
    /// The execute_timeout attribute.
    /// </summary>
    [TerraformPropertyName("execute_timeout")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ExecuteTimeout { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "execute_timeout");

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    [TerraformPropertyName("max_file_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxFileSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_file_size");

    /// <summary>
    /// The parallel_load_threads attribute.
    /// </summary>
    [TerraformPropertyName("parallel_load_threads")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ParallelLoadThreads { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "parallel_load_threads");

    /// <summary>
    /// The server_timezone attribute.
    /// </summary>
    [TerraformPropertyName("server_timezone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServerTimezone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "server_timezone");

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_access_role_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceAccessRoleArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "service_access_role_arn");

    /// <summary>
    /// The target_db_type attribute.
    /// </summary>
    [TerraformPropertyName("target_db_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TargetDbType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "target_db_type");

}

/// <summary>
/// Block type for oracle_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointOracleSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [TerraformPropertyName("authentication_method")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AuthenticationMethod { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "authentication_method");

}

/// <summary>
/// Block type for postgres_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointPostgresSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The after_connect_script attribute.
    /// </summary>
    [TerraformPropertyName("after_connect_script")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AfterConnectScript { get; set; }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [TerraformPropertyName("authentication_method")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AuthenticationMethod { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "authentication_method");

    /// <summary>
    /// The babelfish_database_name attribute.
    /// </summary>
    [TerraformPropertyName("babelfish_database_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BabelfishDatabaseName { get; set; }

    /// <summary>
    /// The capture_ddls attribute.
    /// </summary>
    [TerraformPropertyName("capture_ddls")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CaptureDdls { get; set; }

    /// <summary>
    /// The database_mode attribute.
    /// </summary>
    [TerraformPropertyName("database_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DatabaseMode { get; set; }

    /// <summary>
    /// The ddl_artifacts_schema attribute.
    /// </summary>
    [TerraformPropertyName("ddl_artifacts_schema")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DdlArtifactsSchema { get; set; }

    /// <summary>
    /// The execute_timeout attribute.
    /// </summary>
    [TerraformPropertyName("execute_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ExecuteTimeout { get; set; }

    /// <summary>
    /// The fail_tasks_on_lob_truncation attribute.
    /// </summary>
    [TerraformPropertyName("fail_tasks_on_lob_truncation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FailTasksOnLobTruncation { get; set; }

    /// <summary>
    /// The heartbeat_enable attribute.
    /// </summary>
    [TerraformPropertyName("heartbeat_enable")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HeartbeatEnable { get; set; }

    /// <summary>
    /// The heartbeat_frequency attribute.
    /// </summary>
    [TerraformPropertyName("heartbeat_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HeartbeatFrequency { get; set; }

    /// <summary>
    /// The heartbeat_schema attribute.
    /// </summary>
    [TerraformPropertyName("heartbeat_schema")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HeartbeatSchema { get; set; }

    /// <summary>
    /// The map_boolean_as_boolean attribute.
    /// </summary>
    [TerraformPropertyName("map_boolean_as_boolean")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MapBooleanAsBoolean { get; set; }

    /// <summary>
    /// The map_jsonb_as_clob attribute.
    /// </summary>
    [TerraformPropertyName("map_jsonb_as_clob")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MapJsonbAsClob { get; set; }

    /// <summary>
    /// The map_long_varchar_as attribute.
    /// </summary>
    [TerraformPropertyName("map_long_varchar_as")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MapLongVarcharAs { get; set; }

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    [TerraformPropertyName("max_file_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxFileSize { get; set; }

    /// <summary>
    /// The plugin_name attribute.
    /// </summary>
    [TerraformPropertyName("plugin_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PluginName { get; set; }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_access_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceAccessRoleArn { get; set; }

    /// <summary>
    /// The slot_name attribute.
    /// </summary>
    [TerraformPropertyName("slot_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SlotName { get; set; }

}

/// <summary>
/// Block type for redis_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointRedisSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The auth_password attribute.
    /// </summary>
    [TerraformPropertyName("auth_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthPassword { get; set; }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    [TerraformPropertyName("auth_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AuthType { get; set; }

    /// <summary>
    /// The auth_user_name attribute.
    /// </summary>
    [TerraformPropertyName("auth_user_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthUserName { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformPropertyName("port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Port { get; set; }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    [TerraformPropertyName("server_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServerName { get; set; }

    /// <summary>
    /// The ssl_ca_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("ssl_ca_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslCaCertificateArn { get; set; }

    /// <summary>
    /// The ssl_security_protocol attribute.
    /// </summary>
    [TerraformPropertyName("ssl_security_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslSecurityProtocol { get; set; }

}

/// <summary>
/// Block type for redshift_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDmsEndpointRedshiftSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The bucket_folder attribute.
    /// </summary>
    [TerraformPropertyName("bucket_folder")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BucketFolder { get; set; }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [TerraformPropertyName("bucket_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BucketName { get; set; }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    [TerraformPropertyName("encryption_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EncryptionMode { get; set; }

    /// <summary>
    /// The server_side_encryption_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("server_side_encryption_kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServerSideEncryptionKmsKeyId { get; set; }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_access_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceAccessRoleArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDmsEndpointTimeoutsBlock : ITerraformBlock
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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CertificateArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_arn");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformPropertyName("database_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DatabaseName { get; set; }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointId is required")]
    [TerraformPropertyName("endpoint_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EndpointId { get; set; }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    [TerraformPropertyName("endpoint_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EndpointType { get; set; }

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineName is required")]
    [TerraformPropertyName("engine_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EngineName { get; set; }

    /// <summary>
    /// The extra_connection_attributes attribute.
    /// </summary>
    [TerraformPropertyName("extra_connection_attributes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ExtraConnectionAttributes { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "extra_connection_attributes");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_arn");

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// The pause_replication_tasks attribute.
    /// </summary>
    [TerraformPropertyName("pause_replication_tasks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PauseReplicationTasks { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The secrets_manager_access_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("secrets_manager_access_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecretsManagerAccessRoleArn { get; set; }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    [TerraformPropertyName("secrets_manager_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecretsManagerArn { get; set; }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [TerraformPropertyName("server_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServerName { get; set; }

    /// <summary>
    /// The service_access_role attribute.
    /// </summary>
    [TerraformPropertyName("service_access_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceAccessRole { get; set; }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    [TerraformPropertyName("ssl_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SslMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ssl_mode");

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
    /// The username attribute.
    /// </summary>
    [TerraformPropertyName("username")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Username { get; set; }

    /// <summary>
    /// Block for elasticsearch_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchSettings block(s) allowed")]
    [TerraformPropertyName("elasticsearch_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointElasticsearchSettingsBlock>>? ElasticsearchSettings { get; set; } = new();

    /// <summary>
    /// Block for kafka_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaSettings block(s) allowed")]
    [TerraformPropertyName("kafka_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointKafkaSettingsBlock>>? KafkaSettings { get; set; } = new();

    /// <summary>
    /// Block for kinesis_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisSettings block(s) allowed")]
    [TerraformPropertyName("kinesis_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointKinesisSettingsBlock>>? KinesisSettings { get; set; } = new();

    /// <summary>
    /// Block for mongodb_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MongodbSettings block(s) allowed")]
    [TerraformPropertyName("mongodb_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointMongodbSettingsBlock>>? MongodbSettings { get; set; } = new();

    /// <summary>
    /// Block for mysql_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MysqlSettings block(s) allowed")]
    [TerraformPropertyName("mysql_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointMysqlSettingsBlock>>? MysqlSettings { get; set; } = new();

    /// <summary>
    /// Block for oracle_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OracleSettings block(s) allowed")]
    [TerraformPropertyName("oracle_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointOracleSettingsBlock>>? OracleSettings { get; set; } = new();

    /// <summary>
    /// Block for postgres_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostgresSettings block(s) allowed")]
    [TerraformPropertyName("postgres_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointPostgresSettingsBlock>>? PostgresSettings { get; set; } = new();

    /// <summary>
    /// Block for redis_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedisSettings block(s) allowed")]
    [TerraformPropertyName("redis_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointRedisSettingsBlock>>? RedisSettings { get; set; } = new();

    /// <summary>
    /// Block for redshift_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftSettings block(s) allowed")]
    [TerraformPropertyName("redshift_settings")]
    public TerraformList<TerraformBlock<AwsDmsEndpointRedshiftSettingsBlock>>? RedshiftSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDmsEndpointTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_arn");

}
