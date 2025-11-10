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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The python_version attribute.
    /// </summary>
    public TerraformProperty<string>? PythonVersion
    {
        set => SetProperty("python_version", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformProperty<string>? Runtime
    {
        set => SetProperty("runtime", value);
    }

    /// <summary>
    /// The script_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScriptLocation is required")]
    public required TerraformProperty<string> ScriptLocation
    {
        set => SetProperty("script_location", value);
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
        set => SetProperty("max_concurrent_runs", value);
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
        set => SetProperty("notify_delay_after", value);
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
        set => SetProperty("auth_strategy", value);
    }

    /// <summary>
    /// The auth_token attribute.
    /// </summary>
    public TerraformProperty<string>? AuthToken
    {
        set => SetProperty("auth_token", value);
    }

    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformProperty<string>? Branch
    {
        set => SetProperty("branch", value);
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    public TerraformProperty<string>? Folder
    {
        set => SetProperty("folder", value);
    }

    /// <summary>
    /// The last_commit_id attribute.
    /// </summary>
    public TerraformProperty<string>? LastCommitId
    {
        set => SetProperty("last_commit_id", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformProperty<string>? Owner
    {
        set => SetProperty("owner", value);
    }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    public TerraformProperty<string>? Provider
    {
        set => SetProperty("provider", value);
    }

    /// <summary>
    /// The repository attribute.
    /// </summary>
    public TerraformProperty<string>? Repository
    {
        set => SetProperty("repository", value);
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
        SetOutput("arn");
        SetOutput("connections");
        SetOutput("default_arguments");
        SetOutput("description");
        SetOutput("execution_class");
        SetOutput("glue_version");
        SetOutput("id");
        SetOutput("job_mode");
        SetOutput("job_run_queuing_enabled");
        SetOutput("maintenance_window");
        SetOutput("max_capacity");
        SetOutput("max_retries");
        SetOutput("name");
        SetOutput("non_overridable_arguments");
        SetOutput("number_of_workers");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("security_configuration");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("timeout");
        SetOutput("worker_type");
    }

    /// <summary>
    /// The connections attribute.
    /// </summary>
    public List<TerraformProperty<string>> Connections
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("connections");
        set => SetProperty("connections", value);
    }

    /// <summary>
    /// The default_arguments attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> DefaultArguments
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("default_arguments");
        set => SetProperty("default_arguments", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The execution_class attribute.
    /// </summary>
    public TerraformProperty<string> ExecutionClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("execution_class");
        set => SetProperty("execution_class", value);
    }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    public TerraformProperty<string> GlueVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("glue_version");
        set => SetProperty("glue_version", value);
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
    /// The job_mode attribute.
    /// </summary>
    public TerraformProperty<string> JobMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("job_mode");
        set => SetProperty("job_mode", value);
    }

    /// <summary>
    /// The job_run_queuing_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> JobRunQueuingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("job_run_queuing_enabled");
        set => SetProperty("job_run_queuing_enabled", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string> MaintenanceWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maintenance_window");
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformProperty<double> MaxCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_capacity");
        set => SetProperty("max_capacity", value);
    }

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    public TerraformProperty<double> MaxRetries
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_retries");
        set => SetProperty("max_retries", value);
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
    /// The non_overridable_arguments attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> NonOverridableArguments
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("non_overridable_arguments");
        set => SetProperty("non_overridable_arguments", value);
    }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    public TerraformProperty<double> NumberOfWorkers
    {
        get => GetRequiredOutput<TerraformProperty<double>>("number_of_workers");
        set => SetProperty("number_of_workers", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformProperty<string> SecurityConfiguration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_configuration");
        set => SetProperty("security_configuration", value);
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
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<double> Timeout
    {
        get => GetRequiredOutput<TerraformProperty<double>>("timeout");
        set => SetProperty("timeout", value);
    }

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    public TerraformProperty<string> WorkerType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("worker_type");
        set => SetProperty("worker_type", value);
    }

    /// <summary>
    /// Block for command.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Command is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Command block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Command block(s) allowed")]
    public List<AwsGlueJobCommandBlock>? Command
    {
        set => SetProperty("command", value);
    }

    /// <summary>
    /// Block for execution_property.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionProperty block(s) allowed")]
    public List<AwsGlueJobExecutionPropertyBlock>? ExecutionProperty
    {
        set => SetProperty("execution_property", value);
    }

    /// <summary>
    /// Block for notification_property.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationProperty block(s) allowed")]
    public List<AwsGlueJobNotificationPropertyBlock>? NotificationProperty
    {
        set => SetProperty("notification_property", value);
    }

    /// <summary>
    /// Block for source_control_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceControlDetails block(s) allowed")]
    public List<AwsGlueJobSourceControlDetailsBlock>? SourceControlDetails
    {
        set => SetProperty("source_control_details", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
