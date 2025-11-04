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
    public Dictionary<string, string>? AirflowConfigurationOptions
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("airflow_configuration_options")?.Value;
        set => this.WithProperty("airflow_configuration_options", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The airflow_version attribute.
    /// </summary>
    public string? AirflowVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("airflow_version")?.Value;
        set => this.WithProperty("airflow_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dag_s3_path attribute.
    /// </summary>
    public string? DagS3Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dag_s3_path")?.Value;
        set => this.WithProperty("dag_s3_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint_management attribute.
    /// </summary>
    public string? EndpointManagement
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_management")?.Value;
        set => this.WithProperty("endpoint_management", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The environment_class attribute.
    /// </summary>
    public string? EnvironmentClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment_class")?.Value;
        set => this.WithProperty("environment_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public string? ExecutionRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_role_arn")?.Value;
        set => this.WithProperty("execution_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public string? KmsKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key")?.Value;
        set => this.WithProperty("kms_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_webservers attribute.
    /// </summary>
    public double? MaxWebservers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_webservers")?.Value;
        set => this.WithProperty("max_webservers", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The max_workers attribute.
    /// </summary>
    public double? MaxWorkers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_workers")?.Value;
        set => this.WithProperty("max_workers", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_webservers attribute.
    /// </summary>
    public double? MinWebservers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_webservers")?.Value;
        set => this.WithProperty("min_webservers", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_workers attribute.
    /// </summary>
    public double? MinWorkers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_workers")?.Value;
        set => this.WithProperty("min_workers", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The plugins_s3_object_version attribute.
    /// </summary>
    public string? PluginsS3ObjectVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plugins_s3_object_version")?.Value;
        set => this.WithProperty("plugins_s3_object_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The plugins_s3_path attribute.
    /// </summary>
    public string? PluginsS3Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plugins_s3_path")?.Value;
        set => this.WithProperty("plugins_s3_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The requirements_s3_object_version attribute.
    /// </summary>
    public string? RequirementsS3ObjectVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("requirements_s3_object_version")?.Value;
        set => this.WithProperty("requirements_s3_object_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The requirements_s3_path attribute.
    /// </summary>
    public string? RequirementsS3Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("requirements_s3_path")?.Value;
        set => this.WithProperty("requirements_s3_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The schedulers attribute.
    /// </summary>
    public double? Schedulers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("schedulers")?.Value;
        set => this.WithProperty("schedulers", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The source_bucket_arn attribute.
    /// </summary>
    public string? SourceBucketArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_bucket_arn")?.Value;
        set => this.WithProperty("source_bucket_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The startup_script_s3_object_version attribute.
    /// </summary>
    public string? StartupScriptS3ObjectVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("startup_script_s3_object_version")?.Value;
        set => this.WithProperty("startup_script_s3_object_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The startup_script_s3_path attribute.
    /// </summary>
    public string? StartupScriptS3Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("startup_script_s3_path")?.Value;
        set => this.WithProperty("startup_script_s3_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The webserver_access_mode attribute.
    /// </summary>
    public string? WebserverAccessMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("webserver_access_mode")?.Value;
        set => this.WithProperty("webserver_access_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    public string? WeeklyMaintenanceWindowStart
    {
        get => GetProperty<TerraformLiteralProperty<string>>("weekly_maintenance_window_start")?.Value;
        set => this.WithProperty("weekly_maintenance_window_start", value == null ? null : new TerraformLiteralProperty<string>(value));
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
