using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsMwaaEnvironmentLoggingConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsMwaaEnvironmentNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMwaaEnvironmentTimeoutsBlock : TerraformBlock
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
/// Manages a aws_mwaa_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMwaaEnvironment : TerraformResource
{
    public AwsMwaaEnvironment(string name) : base("aws_mwaa_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("created_at");
        SetOutput("database_vpc_endpoint_service");
        SetOutput("last_updated");
        SetOutput("service_role_arn");
        SetOutput("status");
        SetOutput("webserver_url");
        SetOutput("webserver_vpc_endpoint_service");
        SetOutput("airflow_configuration_options");
        SetOutput("airflow_version");
        SetOutput("dag_s3_path");
        SetOutput("endpoint_management");
        SetOutput("environment_class");
        SetOutput("execution_role_arn");
        SetOutput("id");
        SetOutput("kms_key");
        SetOutput("max_webservers");
        SetOutput("max_workers");
        SetOutput("min_webservers");
        SetOutput("min_workers");
        SetOutput("name");
        SetOutput("plugins_s3_object_version");
        SetOutput("plugins_s3_path");
        SetOutput("region");
        SetOutput("requirements_s3_object_version");
        SetOutput("requirements_s3_path");
        SetOutput("schedulers");
        SetOutput("source_bucket_arn");
        SetOutput("startup_script_s3_object_version");
        SetOutput("startup_script_s3_path");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("webserver_access_mode");
        SetOutput("weekly_maintenance_window_start");
        SetOutput("worker_replacement_strategy");
    }

    /// <summary>
    /// The airflow_configuration_options attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AirflowConfigurationOptions
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("airflow_configuration_options");
        set => SetProperty("airflow_configuration_options", value);
    }

    /// <summary>
    /// The airflow_version attribute.
    /// </summary>
    public TerraformProperty<string> AirflowVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("airflow_version");
        set => SetProperty("airflow_version", value);
    }

    /// <summary>
    /// The dag_s3_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DagS3Path is required")]
    public required TerraformProperty<string> DagS3Path
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dag_s3_path");
        set => SetProperty("dag_s3_path", value);
    }

    /// <summary>
    /// The endpoint_management attribute.
    /// </summary>
    public TerraformProperty<string> EndpointManagement
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint_management");
        set => SetProperty("endpoint_management", value);
    }

    /// <summary>
    /// The environment_class attribute.
    /// </summary>
    public TerraformProperty<string> EnvironmentClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment_class");
        set => SetProperty("environment_class", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformProperty<string> ExecutionRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("execution_role_arn");
        set => SetProperty("execution_role_arn", value);
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
    /// The kms_key attribute.
    /// </summary>
    public TerraformProperty<string> KmsKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key");
        set => SetProperty("kms_key", value);
    }

    /// <summary>
    /// The max_webservers attribute.
    /// </summary>
    public TerraformProperty<double> MaxWebservers
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_webservers");
        set => SetProperty("max_webservers", value);
    }

    /// <summary>
    /// The max_workers attribute.
    /// </summary>
    public TerraformProperty<double> MaxWorkers
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_workers");
        set => SetProperty("max_workers", value);
    }

    /// <summary>
    /// The min_webservers attribute.
    /// </summary>
    public TerraformProperty<double> MinWebservers
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_webservers");
        set => SetProperty("min_webservers", value);
    }

    /// <summary>
    /// The min_workers attribute.
    /// </summary>
    public TerraformProperty<double> MinWorkers
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_workers");
        set => SetProperty("min_workers", value);
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
    /// The plugins_s3_object_version attribute.
    /// </summary>
    public TerraformProperty<string> PluginsS3ObjectVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("plugins_s3_object_version");
        set => SetProperty("plugins_s3_object_version", value);
    }

    /// <summary>
    /// The plugins_s3_path attribute.
    /// </summary>
    public TerraformProperty<string> PluginsS3Path
    {
        get => GetRequiredOutput<TerraformProperty<string>>("plugins_s3_path");
        set => SetProperty("plugins_s3_path", value);
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
    /// The requirements_s3_object_version attribute.
    /// </summary>
    public TerraformProperty<string> RequirementsS3ObjectVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("requirements_s3_object_version");
        set => SetProperty("requirements_s3_object_version", value);
    }

    /// <summary>
    /// The requirements_s3_path attribute.
    /// </summary>
    public TerraformProperty<string> RequirementsS3Path
    {
        get => GetRequiredOutput<TerraformProperty<string>>("requirements_s3_path");
        set => SetProperty("requirements_s3_path", value);
    }

    /// <summary>
    /// The schedulers attribute.
    /// </summary>
    public TerraformProperty<double> Schedulers
    {
        get => GetRequiredOutput<TerraformProperty<double>>("schedulers");
        set => SetProperty("schedulers", value);
    }

    /// <summary>
    /// The source_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceBucketArn is required")]
    public required TerraformProperty<string> SourceBucketArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_bucket_arn");
        set => SetProperty("source_bucket_arn", value);
    }

    /// <summary>
    /// The startup_script_s3_object_version attribute.
    /// </summary>
    public TerraformProperty<string> StartupScriptS3ObjectVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("startup_script_s3_object_version");
        set => SetProperty("startup_script_s3_object_version", value);
    }

    /// <summary>
    /// The startup_script_s3_path attribute.
    /// </summary>
    public TerraformProperty<string> StartupScriptS3Path
    {
        get => GetRequiredOutput<TerraformProperty<string>>("startup_script_s3_path");
        set => SetProperty("startup_script_s3_path", value);
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
    /// The webserver_access_mode attribute.
    /// </summary>
    public TerraformProperty<string> WebserverAccessMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("webserver_access_mode");
        set => SetProperty("webserver_access_mode", value);
    }

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    public TerraformProperty<string> WeeklyMaintenanceWindowStart
    {
        get => GetRequiredOutput<TerraformProperty<string>>("weekly_maintenance_window_start");
        set => SetProperty("weekly_maintenance_window_start", value);
    }

    /// <summary>
    /// The worker_replacement_strategy attribute.
    /// </summary>
    public TerraformProperty<string> WorkerReplacementStrategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("worker_replacement_strategy");
        set => SetProperty("worker_replacement_strategy", value);
    }

    /// <summary>
    /// Block for logging_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfiguration block(s) allowed")]
    public List<AwsMwaaEnvironmentLoggingConfigurationBlock>? LoggingConfiguration
    {
        set => SetProperty("logging_configuration", value);
    }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public List<AwsMwaaEnvironmentNetworkConfigurationBlock>? NetworkConfiguration
    {
        set => SetProperty("network_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMwaaEnvironmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The database_vpc_endpoint_service attribute.
    /// </summary>
    public TerraformExpression DatabaseVpcEndpointService => this["database_vpc_endpoint_service"];

    /// <summary>
    /// The last_updated attribute.
    /// </summary>
    public TerraformExpression LastUpdated => this["last_updated"];

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    public TerraformExpression ServiceRoleArn => this["service_role_arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The webserver_url attribute.
    /// </summary>
    public TerraformExpression WebserverUrl => this["webserver_url"];

    /// <summary>
    /// The webserver_vpc_endpoint_service attribute.
    /// </summary>
    public TerraformExpression WebserverVpcEndpointService => this["webserver_vpc_endpoint_service"];

}
