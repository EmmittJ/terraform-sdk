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
    public TerraformLiteralProperty<Dictionary<string, string>>? AirflowConfigurationOptions
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("airflow_configuration_options");
        set => this.WithProperty("airflow_configuration_options", value);
    }

    /// <summary>
    /// The airflow_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AirflowVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("airflow_version");
        set => this.WithProperty("airflow_version", value);
    }

    /// <summary>
    /// The dag_s3_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DagS3Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dag_s3_path");
        set => this.WithProperty("dag_s3_path", value);
    }

    /// <summary>
    /// The endpoint_management attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndpointManagement
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_management");
        set => this.WithProperty("endpoint_management", value);
    }

    /// <summary>
    /// The environment_class attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EnvironmentClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment_class");
        set => this.WithProperty("environment_class", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExecutionRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_role_arn");
        set => this.WithProperty("execution_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key");
        set => this.WithProperty("kms_key", value);
    }

    /// <summary>
    /// The max_webservers attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxWebservers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_webservers");
        set => this.WithProperty("max_webservers", value);
    }

    /// <summary>
    /// The max_workers attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxWorkers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_workers");
        set => this.WithProperty("max_workers", value);
    }

    /// <summary>
    /// The min_webservers attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MinWebservers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_webservers");
        set => this.WithProperty("min_webservers", value);
    }

    /// <summary>
    /// The min_workers attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MinWorkers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_workers");
        set => this.WithProperty("min_workers", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The plugins_s3_object_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PluginsS3ObjectVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plugins_s3_object_version");
        set => this.WithProperty("plugins_s3_object_version", value);
    }

    /// <summary>
    /// The plugins_s3_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PluginsS3Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plugins_s3_path");
        set => this.WithProperty("plugins_s3_path", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The requirements_s3_object_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RequirementsS3ObjectVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("requirements_s3_object_version");
        set => this.WithProperty("requirements_s3_object_version", value);
    }

    /// <summary>
    /// The requirements_s3_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RequirementsS3Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("requirements_s3_path");
        set => this.WithProperty("requirements_s3_path", value);
    }

    /// <summary>
    /// The schedulers attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Schedulers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("schedulers");
        set => this.WithProperty("schedulers", value);
    }

    /// <summary>
    /// The source_bucket_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceBucketArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_bucket_arn");
        set => this.WithProperty("source_bucket_arn", value);
    }

    /// <summary>
    /// The startup_script_s3_object_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartupScriptS3ObjectVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("startup_script_s3_object_version");
        set => this.WithProperty("startup_script_s3_object_version", value);
    }

    /// <summary>
    /// The startup_script_s3_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartupScriptS3Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("startup_script_s3_path");
        set => this.WithProperty("startup_script_s3_path", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The webserver_access_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WebserverAccessMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("webserver_access_mode");
        set => this.WithProperty("webserver_access_mode", value);
    }

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WeeklyMaintenanceWindowStart
    {
        get => GetProperty<TerraformLiteralProperty<string>>("weekly_maintenance_window_start");
        set => this.WithProperty("weekly_maintenance_window_start", value);
    }

    /// <summary>
    /// The worker_replacement_strategy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkerReplacementStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("worker_replacement_strategy");
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
