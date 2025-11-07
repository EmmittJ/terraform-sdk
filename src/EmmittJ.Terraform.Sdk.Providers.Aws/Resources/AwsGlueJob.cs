using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_glue_job resource.
/// </summary>
public class AwsGlueJob : TerraformResource
{
    public AwsGlueJob(string name) : base("aws_glue_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The connections attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Connections
    {
        get => GetProperty<TerraformProperty<List<string>>>("connections");
        set => this.WithProperty("connections", value);
    }

    /// <summary>
    /// The default_arguments attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? DefaultArguments
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("default_arguments");
        set => this.WithProperty("default_arguments", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The execution_class attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionClass
    {
        get => GetProperty<TerraformProperty<string>>("execution_class");
        set => this.WithProperty("execution_class", value);
    }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    public TerraformProperty<string>? GlueVersion
    {
        get => GetProperty<TerraformProperty<string>>("glue_version");
        set => this.WithProperty("glue_version", value);
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
    /// The job_mode attribute.
    /// </summary>
    public TerraformProperty<string>? JobMode
    {
        get => GetProperty<TerraformProperty<string>>("job_mode");
        set => this.WithProperty("job_mode", value);
    }

    /// <summary>
    /// The job_run_queuing_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? JobRunQueuingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("job_run_queuing_enabled");
        set => this.WithProperty("job_run_queuing_enabled", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? MaintenanceWindow
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_window");
        set => this.WithProperty("maintenance_window", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCapacity
    {
        get => GetProperty<TerraformProperty<double>>("max_capacity");
        set => this.WithProperty("max_capacity", value);
    }

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    public TerraformProperty<double>? MaxRetries
    {
        get => GetProperty<TerraformProperty<double>>("max_retries");
        set => this.WithProperty("max_retries", value);
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
    /// The non_overridable_arguments attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? NonOverridableArguments
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("non_overridable_arguments");
        set => this.WithProperty("non_overridable_arguments", value);
    }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    public TerraformProperty<double>? NumberOfWorkers
    {
        get => GetProperty<TerraformProperty<double>>("number_of_workers");
        set => this.WithProperty("number_of_workers", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityConfiguration
    {
        get => GetProperty<TerraformProperty<string>>("security_configuration");
        set => this.WithProperty("security_configuration", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<double>? Timeout
    {
        get => GetProperty<TerraformProperty<double>>("timeout");
        set => this.WithProperty("timeout", value);
    }

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    public TerraformProperty<string>? WorkerType
    {
        get => GetProperty<TerraformProperty<string>>("worker_type");
        set => this.WithProperty("worker_type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
