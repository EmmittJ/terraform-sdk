using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for command in .
/// Nesting mode: list
/// </summary>
public class AwsGlueJobCommandBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The python_version attribute.
    /// </summary>
    [TerraformPropertyName("python_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PythonVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "python_version");

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [TerraformPropertyName("runtime")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Runtime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "runtime");

    /// <summary>
    /// The script_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScriptLocation is required")]
    [TerraformPropertyName("script_location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ScriptLocation { get; set; }

}

/// <summary>
/// Block type for execution_property in .
/// Nesting mode: list
/// </summary>
public class AwsGlueJobExecutionPropertyBlock : ITerraformBlock
{
    /// <summary>
    /// The max_concurrent_runs attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrent_runs")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxConcurrentRuns { get; set; }

}

/// <summary>
/// Block type for notification_property in .
/// Nesting mode: list
/// </summary>
public class AwsGlueJobNotificationPropertyBlock : ITerraformBlock
{
    /// <summary>
    /// The notify_delay_after attribute.
    /// </summary>
    [TerraformPropertyName("notify_delay_after")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? NotifyDelayAfter { get; set; }

}

/// <summary>
/// Block type for source_control_details in .
/// Nesting mode: list
/// </summary>
public class AwsGlueJobSourceControlDetailsBlock : ITerraformBlock
{
    /// <summary>
    /// The auth_strategy attribute.
    /// </summary>
    [TerraformPropertyName("auth_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthStrategy { get; set; }

    /// <summary>
    /// The auth_token attribute.
    /// </summary>
    [TerraformPropertyName("auth_token")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthToken { get; set; }

    /// <summary>
    /// The branch attribute.
    /// </summary>
    [TerraformPropertyName("branch")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Branch { get; set; }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    [TerraformPropertyName("folder")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Folder { get; set; }

    /// <summary>
    /// The last_commit_id attribute.
    /// </summary>
    [TerraformPropertyName("last_commit_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LastCommitId { get; set; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Owner { get; set; }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    [TerraformPropertyName("provider")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Provider { get; set; }

    /// <summary>
    /// The repository attribute.
    /// </summary>
    [TerraformPropertyName("repository")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Repository { get; set; }

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
    public TerraformProperty<List<TerraformProperty<string>>>? Connections { get; set; }

    /// <summary>
    /// The default_arguments attribute.
    /// </summary>
    [TerraformPropertyName("default_arguments")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? DefaultArguments { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The execution_class attribute.
    /// </summary>
    [TerraformPropertyName("execution_class")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExecutionClass { get; set; }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    [TerraformPropertyName("glue_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> GlueVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "glue_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The job_mode attribute.
    /// </summary>
    [TerraformPropertyName("job_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> JobMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "job_mode");

    /// <summary>
    /// The job_run_queuing_enabled attribute.
    /// </summary>
    [TerraformPropertyName("job_run_queuing_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? JobRunQueuingEnabled { get; set; }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformPropertyName("max_capacity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxCapacity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_capacity");

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    [TerraformPropertyName("max_retries")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxRetries { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The non_overridable_arguments attribute.
    /// </summary>
    [TerraformPropertyName("non_overridable_arguments")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? NonOverridableArguments { get; set; }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    [TerraformPropertyName("number_of_workers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NumberOfWorkers { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "number_of_workers");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    [TerraformPropertyName("security_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecurityConfiguration { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Timeout { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "timeout");

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    [TerraformPropertyName("worker_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WorkerType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "worker_type");

    /// <summary>
    /// Block for command.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Command is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Command block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Command block(s) allowed")]
    [TerraformPropertyName("command")]
    public TerraformList<TerraformBlock<AwsGlueJobCommandBlock>>? Command { get; set; } = new();

    /// <summary>
    /// Block for execution_property.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionProperty block(s) allowed")]
    [TerraformPropertyName("execution_property")]
    public TerraformList<TerraformBlock<AwsGlueJobExecutionPropertyBlock>>? ExecutionProperty { get; set; } = new();

    /// <summary>
    /// Block for notification_property.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationProperty block(s) allowed")]
    [TerraformPropertyName("notification_property")]
    public TerraformList<TerraformBlock<AwsGlueJobNotificationPropertyBlock>>? NotificationProperty { get; set; } = new();

    /// <summary>
    /// Block for source_control_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceControlDetails block(s) allowed")]
    [TerraformPropertyName("source_control_details")]
    public TerraformList<TerraformBlock<AwsGlueJobSourceControlDetailsBlock>>? SourceControlDetails { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
