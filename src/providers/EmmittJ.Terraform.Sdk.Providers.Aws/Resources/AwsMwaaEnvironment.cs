using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsMwaaEnvironmentLoggingConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsMwaaEnvironmentNetworkConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformProperty("security_group_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SubnetIds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsMwaaEnvironmentTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_mwaa_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsMwaaEnvironment : TerraformResource
{
    public AwsMwaaEnvironment(string name) : base("aws_mwaa_environment", name)
    {
    }

    /// <summary>
    /// The airflow_configuration_options attribute.
    /// </summary>
    [TerraformProperty("airflow_configuration_options")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? AirflowConfigurationOptions { get; set; }

    /// <summary>
    /// The airflow_version attribute.
    /// </summary>
    [TerraformProperty("airflow_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AirflowVersion { get; set; }

    /// <summary>
    /// The dag_s3_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DagS3Path is required")]
    [TerraformProperty("dag_s3_path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DagS3Path { get; set; }

    /// <summary>
    /// The endpoint_management attribute.
    /// </summary>
    [TerraformProperty("endpoint_management")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EndpointManagement { get; set; }

    /// <summary>
    /// The environment_class attribute.
    /// </summary>
    [TerraformProperty("environment_class")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EnvironmentClass { get; set; }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    [TerraformProperty("execution_role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ExecutionRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [TerraformProperty("kms_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKey { get; set; }

    /// <summary>
    /// The max_webservers attribute.
    /// </summary>
    [TerraformProperty("max_webservers")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaxWebservers { get; set; }

    /// <summary>
    /// The max_workers attribute.
    /// </summary>
    [TerraformProperty("max_workers")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaxWorkers { get; set; }

    /// <summary>
    /// The min_webservers attribute.
    /// </summary>
    [TerraformProperty("min_webservers")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MinWebservers { get; set; }

    /// <summary>
    /// The min_workers attribute.
    /// </summary>
    [TerraformProperty("min_workers")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MinWorkers { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The plugins_s3_object_version attribute.
    /// </summary>
    [TerraformProperty("plugins_s3_object_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PluginsS3ObjectVersion { get; set; }

    /// <summary>
    /// The plugins_s3_path attribute.
    /// </summary>
    [TerraformProperty("plugins_s3_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PluginsS3Path { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The requirements_s3_object_version attribute.
    /// </summary>
    [TerraformProperty("requirements_s3_object_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> RequirementsS3ObjectVersion { get; set; }

    /// <summary>
    /// The requirements_s3_path attribute.
    /// </summary>
    [TerraformProperty("requirements_s3_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RequirementsS3Path { get; set; }

    /// <summary>
    /// The schedulers attribute.
    /// </summary>
    [TerraformProperty("schedulers")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Schedulers { get; set; }

    /// <summary>
    /// The source_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceBucketArn is required")]
    [TerraformProperty("source_bucket_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceBucketArn { get; set; }

    /// <summary>
    /// The startup_script_s3_object_version attribute.
    /// </summary>
    [TerraformProperty("startup_script_s3_object_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> StartupScriptS3ObjectVersion { get; set; }

    /// <summary>
    /// The startup_script_s3_path attribute.
    /// </summary>
    [TerraformProperty("startup_script_s3_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StartupScriptS3Path { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The webserver_access_mode attribute.
    /// </summary>
    [TerraformProperty("webserver_access_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> WebserverAccessMode { get; set; }

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    [TerraformProperty("weekly_maintenance_window_start")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> WeeklyMaintenanceWindowStart { get; set; }

    /// <summary>
    /// The worker_replacement_strategy attribute.
    /// </summary>
    [TerraformProperty("worker_replacement_strategy")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> WorkerReplacementStrategy { get; set; }

    /// <summary>
    /// Block for logging_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfiguration block(s) allowed")]
    [TerraformProperty("logging_configuration")]
    public TerraformList<TerraformBlock<AwsMwaaEnvironmentLoggingConfigurationBlock>>? LoggingConfiguration { get; set; }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformProperty("network_configuration")]
    public TerraformList<TerraformBlock<AwsMwaaEnvironmentNetworkConfigurationBlock>>? NetworkConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsMwaaEnvironmentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The database_vpc_endpoint_service attribute.
    /// </summary>
    [TerraformProperty("database_vpc_endpoint_service")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DatabaseVpcEndpointService { get; }

    /// <summary>
    /// The last_updated attribute.
    /// </summary>
    [TerraformProperty("last_updated")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> LastUpdated { get; }

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    [TerraformProperty("service_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceRoleArn { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The webserver_url attribute.
    /// </summary>
    [TerraformProperty("webserver_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WebserverUrl { get; }

    /// <summary>
    /// The webserver_vpc_endpoint_service attribute.
    /// </summary>
    [TerraformProperty("webserver_vpc_endpoint_service")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WebserverVpcEndpointService { get; }

}
