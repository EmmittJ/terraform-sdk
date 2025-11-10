using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for command in .
/// Nesting mode: list
/// </summary>
public class AwsGlueJobCommandBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The python_version attribute.
    /// </summary>
    public TerraformProperty<string>? PythonVersion
    {
        get => GetProperty<TerraformProperty<string>>("python_version");
        set => WithProperty("python_version", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformProperty<string>? Runtime
    {
        get => GetProperty<TerraformProperty<string>>("runtime");
        set => WithProperty("runtime", value);
    }

    /// <summary>
    /// The script_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScriptLocation is required")]
    public required TerraformProperty<string> ScriptLocation
    {
        get => GetRequiredProperty<TerraformProperty<string>>("script_location");
        set => WithProperty("script_location", value);
    }

}

/// <summary>
/// Block type for execution_property in .
/// Nesting mode: list
/// </summary>
public class AwsGlueJobExecutionPropertyBlock : TerraformBlock
{
    /// <summary>
    /// The max_concurrent_runs attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrentRuns
    {
        get => GetProperty<TerraformProperty<double>>("max_concurrent_runs");
        set => WithProperty("max_concurrent_runs", value);
    }

}

/// <summary>
/// Block type for notification_property in .
/// Nesting mode: list
/// </summary>
public class AwsGlueJobNotificationPropertyBlock : TerraformBlock
{
    /// <summary>
    /// The notify_delay_after attribute.
    /// </summary>
    public TerraformProperty<double>? NotifyDelayAfter
    {
        get => GetProperty<TerraformProperty<double>>("notify_delay_after");
        set => WithProperty("notify_delay_after", value);
    }

}

/// <summary>
/// Block type for source_control_details in .
/// Nesting mode: list
/// </summary>
public class AwsGlueJobSourceControlDetailsBlock : TerraformBlock
{
    /// <summary>
    /// The auth_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? AuthStrategy
    {
        get => GetProperty<TerraformProperty<string>>("auth_strategy");
        set => WithProperty("auth_strategy", value);
    }

    /// <summary>
    /// The auth_token attribute.
    /// </summary>
    public TerraformProperty<string>? AuthToken
    {
        get => GetProperty<TerraformProperty<string>>("auth_token");
        set => WithProperty("auth_token", value);
    }

    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformProperty<string>? Branch
    {
        get => GetProperty<TerraformProperty<string>>("branch");
        set => WithProperty("branch", value);
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    public TerraformProperty<string>? Folder
    {
        get => GetProperty<TerraformProperty<string>>("folder");
        set => WithProperty("folder", value);
    }

    /// <summary>
    /// The last_commit_id attribute.
    /// </summary>
    public TerraformProperty<string>? LastCommitId
    {
        get => GetProperty<TerraformProperty<string>>("last_commit_id");
        set => WithProperty("last_commit_id", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformProperty<string>? Owner
    {
        get => GetProperty<TerraformProperty<string>>("owner");
        set => WithProperty("owner", value);
    }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    public TerraformProperty<string>? Provider
    {
        get => GetProperty<TerraformProperty<string>>("provider");
        set => WithProperty("provider", value);
    }

    /// <summary>
    /// The repository attribute.
    /// </summary>
    public TerraformProperty<string>? Repository
    {
        get => GetProperty<TerraformProperty<string>>("repository");
        set => WithProperty("repository", value);
    }

}

/// <summary>
/// Manages a aws_glue_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueJob : TerraformResource
{
    public AwsGlueJob(string name) : base("aws_glue_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The connections attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Connections
    {
        get => GetProperty<List<TerraformProperty<string>>>("connections");
        set => this.WithProperty("connections", value);
    }

    /// <summary>
    /// The default_arguments attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? DefaultArguments
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("default_arguments");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The non_overridable_arguments attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? NonOverridableArguments
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("non_overridable_arguments");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role_arn");
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
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
    /// Block for command.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Command block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Command block(s) allowed")]
    public List<AwsGlueJobCommandBlock>? Command
    {
        get => GetProperty<List<AwsGlueJobCommandBlock>>("command");
        set => this.WithProperty("command", value);
    }

    /// <summary>
    /// Block for execution_property.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionProperty block(s) allowed")]
    public List<AwsGlueJobExecutionPropertyBlock>? ExecutionProperty
    {
        get => GetProperty<List<AwsGlueJobExecutionPropertyBlock>>("execution_property");
        set => this.WithProperty("execution_property", value);
    }

    /// <summary>
    /// Block for notification_property.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationProperty block(s) allowed")]
    public List<AwsGlueJobNotificationPropertyBlock>? NotificationProperty
    {
        get => GetProperty<List<AwsGlueJobNotificationPropertyBlock>>("notification_property");
        set => this.WithProperty("notification_property", value);
    }

    /// <summary>
    /// Block for source_control_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceControlDetails block(s) allowed")]
    public List<AwsGlueJobSourceControlDetailsBlock>? SourceControlDetails
    {
        get => GetProperty<List<AwsGlueJobSourceControlDetailsBlock>>("source_control_details");
        set => this.WithProperty("source_control_details", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
