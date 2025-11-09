using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_mwaa_environment resource.
/// </summary>
public class AwsMwaaEnvironment : TerraformResource
{
    public AwsMwaaEnvironment(string name) : base("aws_mwaa_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_at");
        this.DeclareOutput("database_vpc_endpoint_service");
        this.DeclareOutput("last_updated");
        this.DeclareOutput("service_role_arn");
        this.DeclareOutput("status");
        this.DeclareOutput("webserver_url");
        this.DeclareOutput("webserver_vpc_endpoint_service");
    }

    /// <summary>
    /// The airflow_configuration_options attribute.
    /// </summary>
    public TerraformMapProperty<string>? AirflowConfigurationOptions
    {
        get => GetProperty<TerraformMapProperty<string>>("airflow_configuration_options");
        set => this.WithProperty("airflow_configuration_options", value);
    }

    /// <summary>
    /// The airflow_version attribute.
    /// </summary>
    public TerraformProperty<string>? AirflowVersion
    {
        get => GetProperty<TerraformProperty<string>>("airflow_version");
        set => this.WithProperty("airflow_version", value);
    }

    /// <summary>
    /// The dag_s3_path attribute.
    /// </summary>
    public TerraformProperty<string>? DagS3Path
    {
        get => GetProperty<TerraformProperty<string>>("dag_s3_path");
        set => this.WithProperty("dag_s3_path", value);
    }

    /// <summary>
    /// The endpoint_management attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointManagement
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_management");
        set => this.WithProperty("endpoint_management", value);
    }

    /// <summary>
    /// The environment_class attribute.
    /// </summary>
    public TerraformProperty<string>? EnvironmentClass
    {
        get => GetProperty<TerraformProperty<string>>("environment_class");
        set => this.WithProperty("environment_class", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("execution_role_arn");
        set => this.WithProperty("execution_role_arn", value);
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
    /// The kms_key attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        get => GetProperty<TerraformProperty<string>>("kms_key");
        set => this.WithProperty("kms_key", value);
    }

    /// <summary>
    /// The max_webservers attribute.
    /// </summary>
    public TerraformProperty<double>? MaxWebservers
    {
        get => GetProperty<TerraformProperty<double>>("max_webservers");
        set => this.WithProperty("max_webservers", value);
    }

    /// <summary>
    /// The max_workers attribute.
    /// </summary>
    public TerraformProperty<double>? MaxWorkers
    {
        get => GetProperty<TerraformProperty<double>>("max_workers");
        set => this.WithProperty("max_workers", value);
    }

    /// <summary>
    /// The min_webservers attribute.
    /// </summary>
    public TerraformProperty<double>? MinWebservers
    {
        get => GetProperty<TerraformProperty<double>>("min_webservers");
        set => this.WithProperty("min_webservers", value);
    }

    /// <summary>
    /// The min_workers attribute.
    /// </summary>
    public TerraformProperty<double>? MinWorkers
    {
        get => GetProperty<TerraformProperty<double>>("min_workers");
        set => this.WithProperty("min_workers", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The plugins_s3_object_version attribute.
    /// </summary>
    public TerraformProperty<string>? PluginsS3ObjectVersion
    {
        get => GetProperty<TerraformProperty<string>>("plugins_s3_object_version");
        set => this.WithProperty("plugins_s3_object_version", value);
    }

    /// <summary>
    /// The plugins_s3_path attribute.
    /// </summary>
    public TerraformProperty<string>? PluginsS3Path
    {
        get => GetProperty<TerraformProperty<string>>("plugins_s3_path");
        set => this.WithProperty("plugins_s3_path", value);
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
    /// The requirements_s3_object_version attribute.
    /// </summary>
    public TerraformProperty<string>? RequirementsS3ObjectVersion
    {
        get => GetProperty<TerraformProperty<string>>("requirements_s3_object_version");
        set => this.WithProperty("requirements_s3_object_version", value);
    }

    /// <summary>
    /// The requirements_s3_path attribute.
    /// </summary>
    public TerraformProperty<string>? RequirementsS3Path
    {
        get => GetProperty<TerraformProperty<string>>("requirements_s3_path");
        set => this.WithProperty("requirements_s3_path", value);
    }

    /// <summary>
    /// The schedulers attribute.
    /// </summary>
    public TerraformProperty<double>? Schedulers
    {
        get => GetProperty<TerraformProperty<double>>("schedulers");
        set => this.WithProperty("schedulers", value);
    }

    /// <summary>
    /// The source_bucket_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SourceBucketArn
    {
        get => GetProperty<TerraformProperty<string>>("source_bucket_arn");
        set => this.WithProperty("source_bucket_arn", value);
    }

    /// <summary>
    /// The startup_script_s3_object_version attribute.
    /// </summary>
    public TerraformProperty<string>? StartupScriptS3ObjectVersion
    {
        get => GetProperty<TerraformProperty<string>>("startup_script_s3_object_version");
        set => this.WithProperty("startup_script_s3_object_version", value);
    }

    /// <summary>
    /// The startup_script_s3_path attribute.
    /// </summary>
    public TerraformProperty<string>? StartupScriptS3Path
    {
        get => GetProperty<TerraformProperty<string>>("startup_script_s3_path");
        set => this.WithProperty("startup_script_s3_path", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The webserver_access_mode attribute.
    /// </summary>
    public TerraformProperty<string>? WebserverAccessMode
    {
        get => GetProperty<TerraformProperty<string>>("webserver_access_mode");
        set => this.WithProperty("webserver_access_mode", value);
    }

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    public TerraformProperty<string>? WeeklyMaintenanceWindowStart
    {
        get => GetProperty<TerraformProperty<string>>("weekly_maintenance_window_start");
        set => this.WithProperty("weekly_maintenance_window_start", value);
    }

    /// <summary>
    /// The worker_replacement_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? WorkerReplacementStrategy
    {
        get => GetProperty<TerraformProperty<string>>("worker_replacement_strategy");
        set => this.WithProperty("worker_replacement_strategy", value);
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
