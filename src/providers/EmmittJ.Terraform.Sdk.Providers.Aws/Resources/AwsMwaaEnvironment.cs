using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsMwaaEnvironmentLoggingConfigurationBlock
{
}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsMwaaEnvironmentNetworkConfigurationBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformPropertyName("security_group_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> SubnetIds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMwaaEnvironmentTimeoutsBlock
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
/// Manages a aws_mwaa_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMwaaEnvironment : TerraformResource
{
    public AwsMwaaEnvironment(string name) : base("aws_mwaa_environment", name)
    {
    }

    /// <summary>
    /// The airflow_configuration_options attribute.
    /// </summary>
    [TerraformPropertyName("airflow_configuration_options")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? AirflowConfigurationOptions { get; set; }

    /// <summary>
    /// The airflow_version attribute.
    /// </summary>
    [TerraformPropertyName("airflow_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AirflowVersion { get; set; } = default!;

    /// <summary>
    /// The dag_s3_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DagS3Path is required")]
    [TerraformPropertyName("dag_s3_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DagS3Path { get; set; }

    /// <summary>
    /// The endpoint_management attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_management")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EndpointManagement { get; set; } = default!;

    /// <summary>
    /// The environment_class attribute.
    /// </summary>
    [TerraformPropertyName("environment_class")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EnvironmentClass { get; set; } = default!;

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    [TerraformPropertyName("execution_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ExecutionRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [TerraformPropertyName("kms_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKey { get; set; }

    /// <summary>
    /// The max_webservers attribute.
    /// </summary>
    [TerraformPropertyName("max_webservers")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxWebservers { get; set; } = default!;

    /// <summary>
    /// The max_workers attribute.
    /// </summary>
    [TerraformPropertyName("max_workers")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxWorkers { get; set; } = default!;

    /// <summary>
    /// The min_webservers attribute.
    /// </summary>
    [TerraformPropertyName("min_webservers")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MinWebservers { get; set; } = default!;

    /// <summary>
    /// The min_workers attribute.
    /// </summary>
    [TerraformPropertyName("min_workers")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MinWorkers { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The plugins_s3_object_version attribute.
    /// </summary>
    [TerraformPropertyName("plugins_s3_object_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PluginsS3ObjectVersion { get; set; } = default!;

    /// <summary>
    /// The plugins_s3_path attribute.
    /// </summary>
    [TerraformPropertyName("plugins_s3_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PluginsS3Path { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The requirements_s3_object_version attribute.
    /// </summary>
    [TerraformPropertyName("requirements_s3_object_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RequirementsS3ObjectVersion { get; set; } = default!;

    /// <summary>
    /// The requirements_s3_path attribute.
    /// </summary>
    [TerraformPropertyName("requirements_s3_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RequirementsS3Path { get; set; }

    /// <summary>
    /// The schedulers attribute.
    /// </summary>
    [TerraformPropertyName("schedulers")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Schedulers { get; set; } = default!;

    /// <summary>
    /// The source_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceBucketArn is required")]
    [TerraformPropertyName("source_bucket_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceBucketArn { get; set; }

    /// <summary>
    /// The startup_script_s3_object_version attribute.
    /// </summary>
    [TerraformPropertyName("startup_script_s3_object_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StartupScriptS3ObjectVersion { get; set; } = default!;

    /// <summary>
    /// The startup_script_s3_path attribute.
    /// </summary>
    [TerraformPropertyName("startup_script_s3_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StartupScriptS3Path { get; set; }

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
    /// The webserver_access_mode attribute.
    /// </summary>
    [TerraformPropertyName("webserver_access_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> WebserverAccessMode { get; set; } = default!;

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    [TerraformPropertyName("weekly_maintenance_window_start")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> WeeklyMaintenanceWindowStart { get; set; } = default!;

    /// <summary>
    /// The worker_replacement_strategy attribute.
    /// </summary>
    [TerraformPropertyName("worker_replacement_strategy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> WorkerReplacementStrategy { get; set; } = default!;

    /// <summary>
    /// Block for logging_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfiguration block(s) allowed")]
    [TerraformPropertyName("logging_configuration")]
    public TerraformList<TerraformBlock<AwsMwaaEnvironmentLoggingConfigurationBlock>>? LoggingConfiguration { get; set; }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformPropertyName("network_configuration")]
    public TerraformList<TerraformBlock<AwsMwaaEnvironmentNetworkConfigurationBlock>>? NetworkConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMwaaEnvironmentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The database_vpc_endpoint_service attribute.
    /// </summary>
    [TerraformPropertyName("database_vpc_endpoint_service")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatabaseVpcEndpointService => new TerraformReference(this, "database_vpc_endpoint_service");

    /// <summary>
    /// The last_updated attribute.
    /// </summary>
    [TerraformPropertyName("last_updated")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LastUpdated => new TerraformReference(this, "last_updated");

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceRoleArn => new TerraformReference(this, "service_role_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The webserver_url attribute.
    /// </summary>
    [TerraformPropertyName("webserver_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WebserverUrl => new TerraformReference(this, "webserver_url");

    /// <summary>
    /// The webserver_vpc_endpoint_service attribute.
    /// </summary>
    [TerraformPropertyName("webserver_vpc_endpoint_service")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WebserverVpcEndpointService => new TerraformReference(this, "webserver_vpc_endpoint_service");

}
