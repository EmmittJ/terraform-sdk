using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for elasticsearch_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsDmsEndpointElasticsearchSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointUri is required")]
    [TerraformProperty("endpoint_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EndpointUri { get; set; }

    /// <summary>
    /// The error_retry_duration attribute.
    /// </summary>
    [TerraformProperty("error_retry_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ErrorRetryDuration { get; set; }

    /// <summary>
    /// The full_load_error_percentage attribute.
    /// </summary>
    [TerraformProperty("full_load_error_percentage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FullLoadErrorPercentage { get; set; }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccessRoleArn is required")]
    [TerraformProperty("service_access_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceAccessRoleArn { get; set; }

    /// <summary>
    /// The use_new_mapping_type attribute.
    /// </summary>
    [TerraformProperty("use_new_mapping_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseNewMappingType { get; set; }

}

/// <summary>
/// Block type for kafka_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsDmsEndpointKafkaSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The broker attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Broker is required")]
    [TerraformProperty("broker")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Broker { get; set; }

    /// <summary>
    /// The include_control_details attribute.
    /// </summary>
    [TerraformProperty("include_control_details")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeControlDetails { get; set; }

    /// <summary>
    /// The include_null_and_empty attribute.
    /// </summary>
    [TerraformProperty("include_null_and_empty")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeNullAndEmpty { get; set; }

    /// <summary>
    /// The include_partition_value attribute.
    /// </summary>
    [TerraformProperty("include_partition_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludePartitionValue { get; set; }

    /// <summary>
    /// The include_table_alter_operations attribute.
    /// </summary>
    [TerraformProperty("include_table_alter_operations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeTableAlterOperations { get; set; }

    /// <summary>
    /// The include_transaction_details attribute.
    /// </summary>
    [TerraformProperty("include_transaction_details")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeTransactionDetails { get; set; }

    /// <summary>
    /// The message_format attribute.
    /// </summary>
    [TerraformProperty("message_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MessageFormat { get; set; }

    /// <summary>
    /// The message_max_bytes attribute.
    /// </summary>
    [TerraformProperty("message_max_bytes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MessageMaxBytes { get; set; }

    /// <summary>
    /// The no_hex_prefix attribute.
    /// </summary>
    [TerraformProperty("no_hex_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NoHexPrefix { get; set; }

    /// <summary>
    /// The partition_include_schema_table attribute.
    /// </summary>
    [TerraformProperty("partition_include_schema_table")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PartitionIncludeSchemaTable { get; set; }

    /// <summary>
    /// The sasl_mechanism attribute.
    /// </summary>
    [TerraformProperty("sasl_mechanism")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SaslMechanism { get; set; }

    /// <summary>
    /// The sasl_password attribute.
    /// </summary>
    [TerraformProperty("sasl_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SaslPassword { get; set; }

    /// <summary>
    /// The sasl_username attribute.
    /// </summary>
    [TerraformProperty("sasl_username")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SaslUsername { get; set; }

    /// <summary>
    /// The security_protocol attribute.
    /// </summary>
    [TerraformProperty("security_protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecurityProtocol { get; set; }

    /// <summary>
    /// The ssl_ca_certificate_arn attribute.
    /// </summary>
    [TerraformProperty("ssl_ca_certificate_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslCaCertificateArn { get; set; }

    /// <summary>
    /// The ssl_client_certificate_arn attribute.
    /// </summary>
    [TerraformProperty("ssl_client_certificate_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslClientCertificateArn { get; set; }

    /// <summary>
    /// The ssl_client_key_arn attribute.
    /// </summary>
    [TerraformProperty("ssl_client_key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslClientKeyArn { get; set; }

    /// <summary>
    /// The ssl_client_key_password attribute.
    /// </summary>
    [TerraformProperty("ssl_client_key_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslClientKeyPassword { get; set; }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [TerraformProperty("topic")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Topic { get; set; }

}

/// <summary>
/// Block type for kinesis_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsDmsEndpointKinesisSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The include_control_details attribute.
    /// </summary>
    [TerraformProperty("include_control_details")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeControlDetails { get; set; }

    /// <summary>
    /// The include_null_and_empty attribute.
    /// </summary>
    [TerraformProperty("include_null_and_empty")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeNullAndEmpty { get; set; }

    /// <summary>
    /// The include_partition_value attribute.
    /// </summary>
    [TerraformProperty("include_partition_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludePartitionValue { get; set; }

    /// <summary>
    /// The include_table_alter_operations attribute.
    /// </summary>
    [TerraformProperty("include_table_alter_operations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeTableAlterOperations { get; set; }

    /// <summary>
    /// The include_transaction_details attribute.
    /// </summary>
    [TerraformProperty("include_transaction_details")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeTransactionDetails { get; set; }

    /// <summary>
    /// The message_format attribute.
    /// </summary>
    [TerraformProperty("message_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MessageFormat { get; set; }

    /// <summary>
    /// The partition_include_schema_table attribute.
    /// </summary>
    [TerraformProperty("partition_include_schema_table")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PartitionIncludeSchemaTable { get; set; }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [TerraformProperty("service_access_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceAccessRoleArn { get; set; }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [TerraformProperty("stream_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StreamArn { get; set; }

    /// <summary>
    /// The use_large_integer_value attribute.
    /// </summary>
    [TerraformProperty("use_large_integer_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseLargeIntegerValue { get; set; }

}

/// <summary>
/// Block type for mongodb_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsDmsEndpointMongodbSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The auth_mechanism attribute.
    /// </summary>
    [TerraformProperty("auth_mechanism")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthMechanism { get; set; }

    /// <summary>
    /// The auth_source attribute.
    /// </summary>
    [TerraformProperty("auth_source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthSource { get; set; }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [TerraformProperty("auth_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthType { get; set; }

    /// <summary>
    /// The docs_to_investigate attribute.
    /// </summary>
    [TerraformProperty("docs_to_investigate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DocsToInvestigate { get; set; }

    /// <summary>
    /// The extract_doc_id attribute.
    /// </summary>
    [TerraformProperty("extract_doc_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExtractDocId { get; set; }

    /// <summary>
    /// The nesting_level attribute.
    /// </summary>
    [TerraformProperty("nesting_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NestingLevel { get; set; }

}

/// <summary>
/// Block type for mysql_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsDmsEndpointMysqlSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The after_connect_script attribute.
    /// </summary>
    [TerraformProperty("after_connect_script")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AfterConnectScript { get; set; }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [TerraformProperty("authentication_method")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AuthenticationMethod { get; set; }

    /// <summary>
    /// The clean_source_metadata_on_mismatch attribute.
    /// </summary>
    [TerraformProperty("clean_source_metadata_on_mismatch")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> CleanSourceMetadataOnMismatch { get; set; }

    /// <summary>
    /// The events_poll_interval attribute.
    /// </summary>
    [TerraformProperty("events_poll_interval")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> EventsPollInterval { get; set; }

    /// <summary>
    /// The execute_timeout attribute.
    /// </summary>
    [TerraformProperty("execute_timeout")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ExecuteTimeout { get; set; }

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    [TerraformProperty("max_file_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxFileSize { get; set; }

    /// <summary>
    /// The parallel_load_threads attribute.
    /// </summary>
    [TerraformProperty("parallel_load_threads")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ParallelLoadThreads { get; set; }

    /// <summary>
    /// The server_timezone attribute.
    /// </summary>
    [TerraformProperty("server_timezone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServerTimezone { get; set; }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [TerraformProperty("service_access_role_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceAccessRoleArn { get; set; }

    /// <summary>
    /// The target_db_type attribute.
    /// </summary>
    [TerraformProperty("target_db_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TargetDbType { get; set; }

}

/// <summary>
/// Block type for oracle_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsDmsEndpointOracleSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [TerraformProperty("authentication_method")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AuthenticationMethod { get; set; }

}

/// <summary>
/// Block type for postgres_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsDmsEndpointPostgresSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The after_connect_script attribute.
    /// </summary>
    [TerraformProperty("after_connect_script")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AfterConnectScript { get; set; }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [TerraformProperty("authentication_method")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AuthenticationMethod { get; set; }

    /// <summary>
    /// The babelfish_database_name attribute.
    /// </summary>
    [TerraformProperty("babelfish_database_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BabelfishDatabaseName { get; set; }

    /// <summary>
    /// The capture_ddls attribute.
    /// </summary>
    [TerraformProperty("capture_ddls")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CaptureDdls { get; set; }

    /// <summary>
    /// The database_mode attribute.
    /// </summary>
    [TerraformProperty("database_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DatabaseMode { get; set; }

    /// <summary>
    /// The ddl_artifacts_schema attribute.
    /// </summary>
    [TerraformProperty("ddl_artifacts_schema")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DdlArtifactsSchema { get; set; }

    /// <summary>
    /// The execute_timeout attribute.
    /// </summary>
    [TerraformProperty("execute_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ExecuteTimeout { get; set; }

    /// <summary>
    /// The fail_tasks_on_lob_truncation attribute.
    /// </summary>
    [TerraformProperty("fail_tasks_on_lob_truncation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FailTasksOnLobTruncation { get; set; }

    /// <summary>
    /// The heartbeat_enable attribute.
    /// </summary>
    [TerraformProperty("heartbeat_enable")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HeartbeatEnable { get; set; }

    /// <summary>
    /// The heartbeat_frequency attribute.
    /// </summary>
    [TerraformProperty("heartbeat_frequency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HeartbeatFrequency { get; set; }

    /// <summary>
    /// The heartbeat_schema attribute.
    /// </summary>
    [TerraformProperty("heartbeat_schema")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HeartbeatSchema { get; set; }

    /// <summary>
    /// The map_boolean_as_boolean attribute.
    /// </summary>
    [TerraformProperty("map_boolean_as_boolean")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MapBooleanAsBoolean { get; set; }

    /// <summary>
    /// The map_jsonb_as_clob attribute.
    /// </summary>
    [TerraformProperty("map_jsonb_as_clob")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MapJsonbAsClob { get; set; }

    /// <summary>
    /// The map_long_varchar_as attribute.
    /// </summary>
    [TerraformProperty("map_long_varchar_as")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MapLongVarcharAs { get; set; }

    /// <summary>
    /// The max_file_size attribute.
    /// </summary>
    [TerraformProperty("max_file_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxFileSize { get; set; }

    /// <summary>
    /// The plugin_name attribute.
    /// </summary>
    [TerraformProperty("plugin_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PluginName { get; set; }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [TerraformProperty("service_access_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceAccessRoleArn { get; set; }

    /// <summary>
    /// The slot_name attribute.
    /// </summary>
    [TerraformProperty("slot_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SlotName { get; set; }

}

/// <summary>
/// Block type for redis_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsDmsEndpointRedisSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The auth_password attribute.
    /// </summary>
    [TerraformProperty("auth_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthPassword { get; set; }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    [TerraformProperty("auth_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthType { get; set; }

    /// <summary>
    /// The auth_user_name attribute.
    /// </summary>
    [TerraformProperty("auth_user_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthUserName { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformProperty("port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    [TerraformProperty("server_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerName { get; set; }

    /// <summary>
    /// The ssl_ca_certificate_arn attribute.
    /// </summary>
    [TerraformProperty("ssl_ca_certificate_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslCaCertificateArn { get; set; }

    /// <summary>
    /// The ssl_security_protocol attribute.
    /// </summary>
    [TerraformProperty("ssl_security_protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslSecurityProtocol { get; set; }

}

/// <summary>
/// Block type for redshift_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsDmsEndpointRedshiftSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The bucket_folder attribute.
    /// </summary>
    [TerraformProperty("bucket_folder")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BucketFolder { get; set; }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [TerraformProperty("bucket_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BucketName { get; set; }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    [TerraformProperty("encryption_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EncryptionMode { get; set; }

    /// <summary>
    /// The server_side_encryption_kms_key_id attribute.
    /// </summary>
    [TerraformProperty("server_side_encryption_kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServerSideEncryptionKmsKeyId { get; set; }

    /// <summary>
    /// The service_access_role_arn attribute.
    /// </summary>
    [TerraformProperty("service_access_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceAccessRoleArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDmsEndpointTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a aws_dms_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDmsEndpoint : TerraformResource
{
    public AwsDmsEndpoint(string name) : base("aws_dms_endpoint", name)
    {
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CertificateArn { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformProperty("database_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DatabaseName { get; set; }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointId is required")]
    [TerraformProperty("endpoint_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EndpointId { get; set; }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    [TerraformProperty("endpoint_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EndpointType { get; set; }

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineName is required")]
    [TerraformProperty("engine_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EngineName { get; set; }

    /// <summary>
    /// The extra_connection_attributes attribute.
    /// </summary>
    [TerraformProperty("extra_connection_attributes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ExtraConnectionAttributes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyArn { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The pause_replication_tasks attribute.
    /// </summary>
    [TerraformProperty("pause_replication_tasks")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PauseReplicationTasks { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The secrets_manager_access_role_arn attribute.
    /// </summary>
    [TerraformProperty("secrets_manager_access_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecretsManagerAccessRoleArn { get; set; }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    [TerraformProperty("secrets_manager_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecretsManagerArn { get; set; }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [TerraformProperty("server_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServerName { get; set; }

    /// <summary>
    /// The service_access_role attribute.
    /// </summary>
    [TerraformProperty("service_access_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceAccessRole { get; set; }

    /// <summary>
    /// The ssl_mode attribute.
    /// </summary>
    [TerraformProperty("ssl_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SslMode { get; set; }

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
    /// The username attribute.
    /// </summary>
    [TerraformProperty("username")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Username { get; set; }

    /// <summary>
    /// Block for elasticsearch_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchSettings block(s) allowed")]
    [TerraformProperty("elasticsearch_settings")]
    public partial TerraformList<TerraformBlock<AwsDmsEndpointElasticsearchSettingsBlock>>? ElasticsearchSettings { get; set; }

    /// <summary>
    /// Block for kafka_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaSettings block(s) allowed")]
    [TerraformProperty("kafka_settings")]
    public partial TerraformList<TerraformBlock<AwsDmsEndpointKafkaSettingsBlock>>? KafkaSettings { get; set; }

    /// <summary>
    /// Block for kinesis_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisSettings block(s) allowed")]
    [TerraformProperty("kinesis_settings")]
    public partial TerraformList<TerraformBlock<AwsDmsEndpointKinesisSettingsBlock>>? KinesisSettings { get; set; }

    /// <summary>
    /// Block for mongodb_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MongodbSettings block(s) allowed")]
    [TerraformProperty("mongodb_settings")]
    public partial TerraformList<TerraformBlock<AwsDmsEndpointMongodbSettingsBlock>>? MongodbSettings { get; set; }

    /// <summary>
    /// Block for mysql_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MysqlSettings block(s) allowed")]
    [TerraformProperty("mysql_settings")]
    public partial TerraformList<TerraformBlock<AwsDmsEndpointMysqlSettingsBlock>>? MysqlSettings { get; set; }

    /// <summary>
    /// Block for oracle_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OracleSettings block(s) allowed")]
    [TerraformProperty("oracle_settings")]
    public partial TerraformList<TerraformBlock<AwsDmsEndpointOracleSettingsBlock>>? OracleSettings { get; set; }

    /// <summary>
    /// Block for postgres_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostgresSettings block(s) allowed")]
    [TerraformProperty("postgres_settings")]
    public partial TerraformList<TerraformBlock<AwsDmsEndpointPostgresSettingsBlock>>? PostgresSettings { get; set; }

    /// <summary>
    /// Block for redis_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedisSettings block(s) allowed")]
    [TerraformProperty("redis_settings")]
    public partial TerraformList<TerraformBlock<AwsDmsEndpointRedisSettingsBlock>>? RedisSettings { get; set; }

    /// <summary>
    /// Block for redshift_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftSettings block(s) allowed")]
    [TerraformProperty("redshift_settings")]
    public partial TerraformList<TerraformBlock<AwsDmsEndpointRedshiftSettingsBlock>>? RedshiftSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsDmsEndpointTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The endpoint_arn attribute.
    /// </summary>
    [TerraformProperty("endpoint_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndpointArn { get; }

}
