using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for command in AwsGlueJob.
/// Nesting mode: list
/// </summary>
public class AwsGlueJobCommandBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "command";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The python_version attribute.
    /// </summary>
    public TerraformValue<string>? PythonVersion
    {
        get => GetArgument<TerraformValue<string>>("python_version");
        set => SetArgument("python_version", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformValue<string>? Runtime
    {
        get => GetArgument<TerraformValue<string>>("runtime");
        set => SetArgument("runtime", value);
    }

    /// <summary>
    /// The script_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScriptLocation is required")]
    public required TerraformValue<string> ScriptLocation
    {
        get => GetArgument<TerraformValue<string>>("script_location");
        set => SetArgument("script_location", value);
    }

}


/// <summary>
/// Block type for execution_property in AwsGlueJob.
/// Nesting mode: list
/// </summary>
public class AwsGlueJobExecutionPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "execution_property";

    /// <summary>
    /// The max_concurrent_runs attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentRuns
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_runs");
        set => SetArgument("max_concurrent_runs", value);
    }

}


/// <summary>
/// Block type for notification_property in AwsGlueJob.
/// Nesting mode: list
/// </summary>
public class AwsGlueJobNotificationPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_property";

    /// <summary>
    /// The notify_delay_after attribute.
    /// </summary>
    public TerraformValue<double>? NotifyDelayAfter
    {
        get => GetArgument<TerraformValue<double>>("notify_delay_after");
        set => SetArgument("notify_delay_after", value);
    }

}


/// <summary>
/// Block type for source_control_details in AwsGlueJob.
/// Nesting mode: list
/// </summary>
public class AwsGlueJobSourceControlDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_control_details";

    /// <summary>
    /// The auth_strategy attribute.
    /// </summary>
    public TerraformValue<string>? AuthStrategy
    {
        get => GetArgument<TerraformValue<string>>("auth_strategy");
        set => SetArgument("auth_strategy", value);
    }

    /// <summary>
    /// The auth_token attribute.
    /// </summary>
    public TerraformValue<string>? AuthToken
    {
        get => GetArgument<TerraformValue<string>>("auth_token");
        set => SetArgument("auth_token", value);
    }

    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformValue<string>? Branch
    {
        get => GetArgument<TerraformValue<string>>("branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    public TerraformValue<string>? Folder
    {
        get => GetArgument<TerraformValue<string>>("folder");
        set => SetArgument("folder", value);
    }

    /// <summary>
    /// The last_commit_id attribute.
    /// </summary>
    public TerraformValue<string>? LastCommitId
    {
        get => GetArgument<TerraformValue<string>>("last_commit_id");
        set => SetArgument("last_commit_id", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string>? Owner
    {
        get => GetArgument<TerraformValue<string>>("owner");
        set => SetArgument("owner", value);
    }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    public TerraformValue<string>? ProviderAttribute
    {
        get => GetArgument<TerraformValue<string>>("provider");
        set => SetArgument("provider", value);
    }

    /// <summary>
    /// The repository attribute.
    /// </summary>
    public TerraformValue<string>? Repository
    {
        get => GetArgument<TerraformValue<string>>("repository");
        set => SetArgument("repository", value);
    }

}


/// <summary>
/// Represents a aws_glue_job Terraform resource.
/// Manages a aws_glue_job resource.
/// </summary>
public partial class AwsGlueJob(string name) : TerraformResource("aws_glue_job", name)
{
    /// <summary>
    /// The connections attribute.
    /// </summary>
    public TerraformList<string>? Connections
    {
        get => GetArgument<TerraformList<string>>("connections");
        set => SetArgument("connections", value);
    }

    /// <summary>
    /// The default_arguments attribute.
    /// </summary>
    public TerraformMap<string>? DefaultArguments
    {
        get => GetArgument<TerraformMap<string>>("default_arguments");
        set => SetArgument("default_arguments", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The execution_class attribute.
    /// </summary>
    public TerraformValue<string>? ExecutionClass
    {
        get => GetArgument<TerraformValue<string>>("execution_class");
        set => SetArgument("execution_class", value);
    }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    public TerraformValue<string>? GlueVersion
    {
        get => GetArgument<TerraformValue<string>>("glue_version");
        set => SetArgument("glue_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The job_mode attribute.
    /// </summary>
    public TerraformValue<string>? JobMode
    {
        get => GetArgument<TerraformValue<string>>("job_mode");
        set => SetArgument("job_mode", value);
    }

    /// <summary>
    /// The job_run_queuing_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? JobRunQueuingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("job_run_queuing_enabled");
        set => SetArgument("job_run_queuing_enabled", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string>? MaintenanceWindow
    {
        get => GetArgument<TerraformValue<string>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MaxCapacity
    {
        get => GetArgument<TerraformValue<double>>("max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    public TerraformValue<double>? MaxRetries
    {
        get => GetArgument<TerraformValue<double>>("max_retries");
        set => SetArgument("max_retries", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The non_overridable_arguments attribute.
    /// </summary>
    public TerraformMap<string>? NonOverridableArguments
    {
        get => GetArgument<TerraformMap<string>>("non_overridable_arguments");
        set => SetArgument("non_overridable_arguments", value);
    }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfWorkers
    {
        get => GetArgument<TerraformValue<double>>("number_of_workers");
        set => SetArgument("number_of_workers", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformValue<string>? SecurityConfiguration
    {
        get => GetArgument<TerraformValue<string>>("security_configuration");
        set => SetArgument("security_configuration", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<double>? Timeout
    {
        get => GetArgument<TerraformValue<double>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    public TerraformValue<string>? WorkerType
    {
        get => GetArgument<TerraformValue<string>>("worker_type");
        set => SetArgument("worker_type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Command block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Command is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Command block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Command block(s) allowed")]
    public required TerraformList<AwsGlueJobCommandBlock> Command
    {
        get => GetRequiredArgument<TerraformList<AwsGlueJobCommandBlock>>("command");
        set => SetArgument("command", value);
    }

    /// <summary>
    /// ExecutionProperty block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionProperty block(s) allowed")]
    public TerraformList<AwsGlueJobExecutionPropertyBlock>? ExecutionProperty
    {
        get => GetArgument<TerraformList<AwsGlueJobExecutionPropertyBlock>>("execution_property");
        set => SetArgument("execution_property", value);
    }

    /// <summary>
    /// NotificationProperty block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationProperty block(s) allowed")]
    public TerraformList<AwsGlueJobNotificationPropertyBlock>? NotificationProperty
    {
        get => GetArgument<TerraformList<AwsGlueJobNotificationPropertyBlock>>("notification_property");
        set => SetArgument("notification_property", value);
    }

    /// <summary>
    /// SourceControlDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceControlDetails block(s) allowed")]
    public TerraformList<AwsGlueJobSourceControlDetailsBlock>? SourceControlDetails
    {
        get => GetArgument<TerraformList<AwsGlueJobSourceControlDetailsBlock>>("source_control_details");
        set => SetArgument("source_control_details", value);
    }

}
