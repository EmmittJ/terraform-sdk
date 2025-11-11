using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for command in .
/// Nesting mode: list
/// </summary>
public class AwsGlueJobCommandBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The python_version attribute.
    /// </summary>
    [TerraformPropertyName("python_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PythonVersion { get; set; } = default!;

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [TerraformPropertyName("runtime")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Runtime { get; set; } = default!;

    /// <summary>
    /// The script_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScriptLocation is required")]
    [TerraformPropertyName("script_location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ScriptLocation { get; set; }

}

/// <summary>
/// Block type for execution_property in .
/// Nesting mode: list
/// </summary>
public class AwsGlueJobExecutionPropertyBlock
{
    /// <summary>
    /// The max_concurrent_runs attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrent_runs")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxConcurrentRuns { get; set; }

}

/// <summary>
/// Block type for notification_property in .
/// Nesting mode: list
/// </summary>
public class AwsGlueJobNotificationPropertyBlock
{
    /// <summary>
    /// The notify_delay_after attribute.
    /// </summary>
    [TerraformPropertyName("notify_delay_after")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? NotifyDelayAfter { get; set; }

}

/// <summary>
/// Block type for source_control_details in .
/// Nesting mode: list
/// </summary>
public class AwsGlueJobSourceControlDetailsBlock
{
    /// <summary>
    /// The auth_strategy attribute.
    /// </summary>
    [TerraformPropertyName("auth_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthStrategy { get; set; }

    /// <summary>
    /// The auth_token attribute.
    /// </summary>
    [TerraformPropertyName("auth_token")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthToken { get; set; }

    /// <summary>
    /// The branch attribute.
    /// </summary>
    [TerraformPropertyName("branch")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Branch { get; set; }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    [TerraformPropertyName("folder")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Folder { get; set; }

    /// <summary>
    /// The last_commit_id attribute.
    /// </summary>
    [TerraformPropertyName("last_commit_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LastCommitId { get; set; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Owner { get; set; }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    [TerraformPropertyName("provider")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Provider { get; set; }

    /// <summary>
    /// The repository attribute.
    /// </summary>
    [TerraformPropertyName("repository")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Repository { get; set; }

}

/// <summary>
/// Manages a aws_glue_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueJob : TerraformResource
{
    public AwsGlueJob(string name) : base("aws_glue_job", name)
    {
    }

    /// <summary>
    /// The connections attribute.
    /// </summary>
    [TerraformPropertyName("connections")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Connections { get; set; }

    /// <summary>
    /// The default_arguments attribute.
    /// </summary>
    [TerraformPropertyName("default_arguments")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? DefaultArguments { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The execution_class attribute.
    /// </summary>
    [TerraformPropertyName("execution_class")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExecutionClass { get; set; }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    [TerraformPropertyName("glue_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> GlueVersion { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The job_mode attribute.
    /// </summary>
    [TerraformPropertyName("job_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> JobMode { get; set; } = default!;

    /// <summary>
    /// The job_run_queuing_enabled attribute.
    /// </summary>
    [TerraformPropertyName("job_run_queuing_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? JobRunQueuingEnabled { get; set; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaintenanceWindow { get; set; }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformPropertyName("max_capacity")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxCapacity { get; set; } = default!;

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    [TerraformPropertyName("max_retries")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxRetries { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The non_overridable_arguments attribute.
    /// </summary>
    [TerraformPropertyName("non_overridable_arguments")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? NonOverridableArguments { get; set; }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    [TerraformPropertyName("number_of_workers")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> NumberOfWorkers { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    [TerraformPropertyName("security_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecurityConfiguration { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Timeout { get; set; } = default!;

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    [TerraformPropertyName("worker_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> WorkerType { get; set; } = default!;

    /// <summary>
    /// Block for command.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Command is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Command block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Command block(s) allowed")]
    [TerraformPropertyName("command")]
    public TerraformList<TerraformBlock<AwsGlueJobCommandBlock>>? Command { get; set; }

    /// <summary>
    /// Block for execution_property.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionProperty block(s) allowed")]
    [TerraformPropertyName("execution_property")]
    public TerraformList<TerraformBlock<AwsGlueJobExecutionPropertyBlock>>? ExecutionProperty { get; set; }

    /// <summary>
    /// Block for notification_property.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationProperty block(s) allowed")]
    [TerraformPropertyName("notification_property")]
    public TerraformList<TerraformBlock<AwsGlueJobNotificationPropertyBlock>>? NotificationProperty { get; set; }

    /// <summary>
    /// Block for source_control_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceControlDetails block(s) allowed")]
    [TerraformPropertyName("source_control_details")]
    public TerraformList<TerraformBlock<AwsGlueJobSourceControlDetailsBlock>>? SourceControlDetails { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
