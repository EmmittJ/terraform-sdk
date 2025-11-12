using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for command in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueJobCommandBlock() : TerraformBlock("command")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The python_version attribute.
    /// </summary>
    [TerraformProperty("python_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PythonVersion { get; set; }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [TerraformProperty("runtime")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Runtime { get; set; }

    /// <summary>
    /// The script_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScriptLocation is required")]
    [TerraformProperty("script_location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScriptLocation { get; set; }

}

/// <summary>
/// Block type for execution_property in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueJobExecutionPropertyBlock() : TerraformBlock("execution_property")
{
    /// <summary>
    /// The max_concurrent_runs attribute.
    /// </summary>
    [TerraformProperty("max_concurrent_runs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxConcurrentRuns { get; set; }

}

/// <summary>
/// Block type for notification_property in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueJobNotificationPropertyBlock() : TerraformBlock("notification_property")
{
    /// <summary>
    /// The notify_delay_after attribute.
    /// </summary>
    [TerraformProperty("notify_delay_after")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NotifyDelayAfter { get; set; }

}

/// <summary>
/// Block type for source_control_details in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueJobSourceControlDetailsBlock() : TerraformBlock("source_control_details")
{
    /// <summary>
    /// The auth_strategy attribute.
    /// </summary>
    [TerraformProperty("auth_strategy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthStrategy { get; set; }

    /// <summary>
    /// The auth_token attribute.
    /// </summary>
    [TerraformProperty("auth_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthToken { get; set; }

    /// <summary>
    /// The branch attribute.
    /// </summary>
    [TerraformProperty("branch")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Branch { get; set; }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    [TerraformProperty("folder")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Folder { get; set; }

    /// <summary>
    /// The last_commit_id attribute.
    /// </summary>
    [TerraformProperty("last_commit_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LastCommitId { get; set; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Owner { get; set; }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    [TerraformProperty("provider")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Provider { get; set; }

    /// <summary>
    /// The repository attribute.
    /// </summary>
    [TerraformProperty("repository")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Repository { get; set; }

}

/// <summary>
/// Manages a aws_glue_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGlueJob : TerraformResource
{
    public AwsGlueJob(string name) : base("aws_glue_job", name)
    {
    }

    /// <summary>
    /// The connections attribute.
    /// </summary>
    [TerraformProperty("connections")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Connections { get; set; }

    /// <summary>
    /// The default_arguments attribute.
    /// </summary>
    [TerraformProperty("default_arguments")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? DefaultArguments { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The execution_class attribute.
    /// </summary>
    [TerraformProperty("execution_class")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExecutionClass { get; set; }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    [TerraformProperty("glue_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> GlueVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The job_mode attribute.
    /// </summary>
    [TerraformProperty("job_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> JobMode { get; set; }

    /// <summary>
    /// The job_run_queuing_enabled attribute.
    /// </summary>
    [TerraformProperty("job_run_queuing_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? JobRunQueuingEnabled { get; set; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformProperty("maintenance_window")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaintenanceWindow { get; set; }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformProperty("max_capacity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxCapacity { get; set; }

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    [TerraformProperty("max_retries")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxRetries { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The non_overridable_arguments attribute.
    /// </summary>
    [TerraformProperty("non_overridable_arguments")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? NonOverridableArguments { get; set; }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    [TerraformProperty("number_of_workers")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> NumberOfWorkers { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    [TerraformProperty("security_configuration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecurityConfiguration { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Timeout { get; set; }

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    [TerraformProperty("worker_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> WorkerType { get; set; }

    /// <summary>
    /// Block for command.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Command is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Command block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Command block(s) allowed")]
    [TerraformProperty("command")]
    public required TerraformList<AwsGlueJobCommandBlock> Command { get; set; } = new();

    /// <summary>
    /// Block for execution_property.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionProperty block(s) allowed")]
    [TerraformProperty("execution_property")]
    public TerraformList<AwsGlueJobExecutionPropertyBlock> ExecutionProperty { get; set; } = new();

    /// <summary>
    /// Block for notification_property.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationProperty block(s) allowed")]
    [TerraformProperty("notification_property")]
    public TerraformList<AwsGlueJobNotificationPropertyBlock> NotificationProperty { get; set; } = new();

    /// <summary>
    /// Block for source_control_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceControlDetails block(s) allowed")]
    [TerraformProperty("source_control_details")]
    public TerraformList<AwsGlueJobSourceControlDetailsBlock> SourceControlDetails { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
