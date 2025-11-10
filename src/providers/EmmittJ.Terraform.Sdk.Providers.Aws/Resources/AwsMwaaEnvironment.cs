using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsMwaaEnvironmentLoggingConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsMwaaEnvironmentNetworkConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformPropertyName("security_group_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMwaaEnvironmentTimeoutsBlock : ITerraformBlock
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
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AirflowConfigurationOptions { get; set; }

    /// <summary>
    /// The airflow_version attribute.
    /// </summary>
    [TerraformPropertyName("airflow_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AirflowVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "airflow_version");

    /// <summary>
    /// The dag_s3_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DagS3Path is required")]
    [TerraformPropertyName("dag_s3_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DagS3Path { get; set; }

    /// <summary>
    /// The endpoint_management attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_management")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EndpointManagement { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_management");

    /// <summary>
    /// The environment_class attribute.
    /// </summary>
    [TerraformPropertyName("environment_class")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EnvironmentClass { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "environment_class");

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    [TerraformPropertyName("execution_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ExecutionRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [TerraformPropertyName("kms_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKey { get; set; }

    /// <summary>
    /// The max_webservers attribute.
    /// </summary>
    [TerraformPropertyName("max_webservers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxWebservers { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_webservers");

    /// <summary>
    /// The max_workers attribute.
    /// </summary>
    [TerraformPropertyName("max_workers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxWorkers { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_workers");

    /// <summary>
    /// The min_webservers attribute.
    /// </summary>
    [TerraformPropertyName("min_webservers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MinWebservers { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_webservers");

    /// <summary>
    /// The min_workers attribute.
    /// </summary>
    [TerraformPropertyName("min_workers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MinWorkers { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_workers");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The plugins_s3_object_version attribute.
    /// </summary>
    [TerraformPropertyName("plugins_s3_object_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PluginsS3ObjectVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "plugins_s3_object_version");

    /// <summary>
    /// The plugins_s3_path attribute.
    /// </summary>
    [TerraformPropertyName("plugins_s3_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PluginsS3Path { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The requirements_s3_object_version attribute.
    /// </summary>
    [TerraformPropertyName("requirements_s3_object_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RequirementsS3ObjectVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "requirements_s3_object_version");

    /// <summary>
    /// The requirements_s3_path attribute.
    /// </summary>
    [TerraformPropertyName("requirements_s3_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RequirementsS3Path { get; set; }

    /// <summary>
    /// The schedulers attribute.
    /// </summary>
    [TerraformPropertyName("schedulers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Schedulers { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "schedulers");

    /// <summary>
    /// The source_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceBucketArn is required")]
    [TerraformPropertyName("source_bucket_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceBucketArn { get; set; }

    /// <summary>
    /// The startup_script_s3_object_version attribute.
    /// </summary>
    [TerraformPropertyName("startup_script_s3_object_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StartupScriptS3ObjectVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "startup_script_s3_object_version");

    /// <summary>
    /// The startup_script_s3_path attribute.
    /// </summary>
    [TerraformPropertyName("startup_script_s3_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StartupScriptS3Path { get; set; }

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
    /// The webserver_access_mode attribute.
    /// </summary>
    [TerraformPropertyName("webserver_access_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WebserverAccessMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "webserver_access_mode");

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    [TerraformPropertyName("weekly_maintenance_window_start")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WeeklyMaintenanceWindowStart { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "weekly_maintenance_window_start");

    /// <summary>
    /// The worker_replacement_strategy attribute.
    /// </summary>
    [TerraformPropertyName("worker_replacement_strategy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WorkerReplacementStrategy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "worker_replacement_strategy");

    /// <summary>
    /// Block for logging_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfiguration block(s) allowed")]
    [TerraformPropertyName("logging_configuration")]
    public TerraformList<TerraformBlock<AwsMwaaEnvironmentLoggingConfigurationBlock>>? LoggingConfiguration { get; set; } = new();

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformPropertyName("network_configuration")]
    public TerraformList<TerraformBlock<AwsMwaaEnvironmentNetworkConfigurationBlock>>? NetworkConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMwaaEnvironmentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The database_vpc_endpoint_service attribute.
    /// </summary>
    [TerraformPropertyName("database_vpc_endpoint_service")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatabaseVpcEndpointService => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_vpc_endpoint_service");

    /// <summary>
    /// The last_updated attribute.
    /// </summary>
    [TerraformPropertyName("last_updated")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LastUpdated => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "last_updated");

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_role_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The webserver_url attribute.
    /// </summary>
    [TerraformPropertyName("webserver_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WebserverUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "webserver_url");

    /// <summary>
    /// The webserver_vpc_endpoint_service attribute.
    /// </summary>
    [TerraformPropertyName("webserver_vpc_endpoint_service")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WebserverVpcEndpointService => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "webserver_vpc_endpoint_service");

}
