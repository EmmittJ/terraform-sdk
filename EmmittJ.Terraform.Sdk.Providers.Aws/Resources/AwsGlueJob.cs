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
    public List<string>? Connections
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("connections")?.Value;
        set => this.WithProperty("connections", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The default_arguments attribute.
    /// </summary>
    public Dictionary<string, string>? DefaultArguments
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("default_arguments")?.Value;
        set => this.WithProperty("default_arguments", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The execution_class attribute.
    /// </summary>
    public string? ExecutionClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_class")?.Value;
        set => this.WithProperty("execution_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    public string? GlueVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("glue_version")?.Value;
        set => this.WithProperty("glue_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The job_run_queuing_enabled attribute.
    /// </summary>
    public bool? JobRunQueuingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("job_run_queuing_enabled")?.Value;
        set => this.WithProperty("job_run_queuing_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public string? MaintenanceWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_window")?.Value;
        set => this.WithProperty("maintenance_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public double? MaxCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_capacity")?.Value;
        set => this.WithProperty("max_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    public double? MaxRetries
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_retries")?.Value;
        set => this.WithProperty("max_retries", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The non_overridable_arguments attribute.
    /// </summary>
    public Dictionary<string, string>? NonOverridableArguments
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("non_overridable_arguments")?.Value;
        set => this.WithProperty("non_overridable_arguments", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    public double? NumberOfWorkers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("number_of_workers")?.Value;
        set => this.WithProperty("number_of_workers", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public string? SecurityConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_configuration")?.Value;
        set => this.WithProperty("security_configuration", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The timeout attribute.
    /// </summary>
    public double? Timeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("timeout")?.Value;
        set => this.WithProperty("timeout", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    public string? WorkerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("worker_type")?.Value;
        set => this.WithProperty("worker_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
