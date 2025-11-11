using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for appsync_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetAppsyncTargetBlock
{
    /// <summary>
    /// The graphql_operation attribute.
    /// </summary>
    [TerraformPropertyName("graphql_operation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GraphqlOperation { get; set; }

}

/// <summary>
/// Block type for batch_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetBatchTargetBlock
{
    /// <summary>
    /// The array_size attribute.
    /// </summary>
    [TerraformPropertyName("array_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ArraySize { get; set; }

    /// <summary>
    /// The job_attempts attribute.
    /// </summary>
    [TerraformPropertyName("job_attempts")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? JobAttempts { get; set; }

    /// <summary>
    /// The job_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobDefinition is required")]
    [TerraformPropertyName("job_definition")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> JobDefinition { get; set; }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobName is required")]
    [TerraformPropertyName("job_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> JobName { get; set; }

}

/// <summary>
/// Block type for dead_letter_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetDeadLetterConfigBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Arn { get; set; }

}

/// <summary>
/// Block type for ecs_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetEcsTargetBlock
{
    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    [TerraformPropertyName("enable_ecs_managed_tags")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableEcsManagedTags { get; set; }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    [TerraformPropertyName("enable_execute_command")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableExecuteCommand { get; set; }

    /// <summary>
    /// The group attribute.
    /// </summary>
    [TerraformPropertyName("group")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Group { get; set; }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    [TerraformPropertyName("launch_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LaunchType { get; set; }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformPropertyName("platform_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PlatformVersion { get; set; }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    [TerraformPropertyName("propagate_tags")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PropagateTags { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The task_count attribute.
    /// </summary>
    [TerraformPropertyName("task_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TaskCount { get; set; }

    /// <summary>
    /// The task_definition_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinitionArn is required")]
    [TerraformPropertyName("task_definition_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TaskDefinitionArn { get; set; }

}

/// <summary>
/// Block type for http_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetHttpTargetBlock
{
    /// <summary>
    /// The header_parameters attribute.
    /// </summary>
    [TerraformPropertyName("header_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? HeaderParameters { get; set; }

    /// <summary>
    /// The path_parameter_values attribute.
    /// </summary>
    [TerraformPropertyName("path_parameter_values")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? PathParameterValues { get; set; }

    /// <summary>
    /// The query_string_parameters attribute.
    /// </summary>
    [TerraformPropertyName("query_string_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? QueryStringParameters { get; set; }

}

/// <summary>
/// Block type for input_transformer in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetInputTransformerBlock
{
    /// <summary>
    /// The input_paths attribute.
    /// </summary>
    [TerraformPropertyName("input_paths")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? InputPaths { get; set; }

    /// <summary>
    /// The input_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputTemplate is required")]
    [TerraformPropertyName("input_template")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InputTemplate { get; set; }

}

/// <summary>
/// Block type for kinesis_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetKinesisTargetBlock
{
    /// <summary>
    /// The partition_key_path attribute.
    /// </summary>
    [TerraformPropertyName("partition_key_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PartitionKeyPath { get; set; }

}

/// <summary>
/// Block type for redshift_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetRedshiftTargetBlock
{
    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformPropertyName("database")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Database { get; set; }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    [TerraformPropertyName("db_user")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DbUser { get; set; }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    [TerraformPropertyName("secrets_manager_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecretsManagerArn { get; set; }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    [TerraformPropertyName("sql")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Sql { get; set; }

    /// <summary>
    /// The statement_name attribute.
    /// </summary>
    [TerraformPropertyName("statement_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StatementName { get; set; }

    /// <summary>
    /// The with_event attribute.
    /// </summary>
    [TerraformPropertyName("with_event")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WithEvent { get; set; }

}

/// <summary>
/// Block type for retry_policy in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetRetryPolicyBlock
{
    /// <summary>
    /// The maximum_event_age_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("maximum_event_age_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaximumEventAgeInSeconds { get; set; }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    [TerraformPropertyName("maximum_retry_attempts")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaximumRetryAttempts { get; set; }

}

/// <summary>
/// Block type for run_command_targets in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetRunCommandTargetsBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Block type for sagemaker_pipeline_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetSagemakerPipelineTargetBlock
{
}

/// <summary>
/// Block type for sqs_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetSqsTargetBlock
{
    /// <summary>
    /// The message_group_id attribute.
    /// </summary>
    [TerraformPropertyName("message_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MessageGroupId { get; set; }

}

/// <summary>
/// Manages a aws_cloudwatch_event_target resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudwatchEventTarget : TerraformResource
{
    public AwsCloudwatchEventTarget(string name) : base("aws_cloudwatch_event_target", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The event_bus_name attribute.
    /// </summary>
    [TerraformPropertyName("event_bus_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventBusName { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The input attribute.
    /// </summary>
    [TerraformPropertyName("input")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Input { get; set; }

    /// <summary>
    /// The input_path attribute.
    /// </summary>
    [TerraformPropertyName("input_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InputPath { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleArn { get; set; }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [TerraformPropertyName("rule")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Rule { get; set; }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    [TerraformPropertyName("target_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TargetId { get; set; } = default!;

    /// <summary>
    /// Block for appsync_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppsyncTarget block(s) allowed")]
    [TerraformPropertyName("appsync_target")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventTargetAppsyncTargetBlock>>? AppsyncTarget { get; set; }

    /// <summary>
    /// Block for batch_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BatchTarget block(s) allowed")]
    [TerraformPropertyName("batch_target")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventTargetBatchTargetBlock>>? BatchTarget { get; set; }

    /// <summary>
    /// Block for dead_letter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterConfig block(s) allowed")]
    [TerraformPropertyName("dead_letter_config")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventTargetDeadLetterConfigBlock>>? DeadLetterConfig { get; set; }

    /// <summary>
    /// Block for ecs_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EcsTarget block(s) allowed")]
    [TerraformPropertyName("ecs_target")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventTargetEcsTargetBlock>>? EcsTarget { get; set; }

    /// <summary>
    /// Block for http_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpTarget block(s) allowed")]
    [TerraformPropertyName("http_target")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventTargetHttpTargetBlock>>? HttpTarget { get; set; }

    /// <summary>
    /// Block for input_transformer.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputTransformer block(s) allowed")]
    [TerraformPropertyName("input_transformer")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventTargetInputTransformerBlock>>? InputTransformer { get; set; }

    /// <summary>
    /// Block for kinesis_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisTarget block(s) allowed")]
    [TerraformPropertyName("kinesis_target")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventTargetKinesisTargetBlock>>? KinesisTarget { get; set; }

    /// <summary>
    /// Block for redshift_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftTarget block(s) allowed")]
    [TerraformPropertyName("redshift_target")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventTargetRedshiftTargetBlock>>? RedshiftTarget { get; set; }

    /// <summary>
    /// Block for retry_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    [TerraformPropertyName("retry_policy")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventTargetRetryPolicyBlock>>? RetryPolicy { get; set; }

    /// <summary>
    /// Block for run_command_targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 RunCommandTargets block(s) allowed")]
    [TerraformPropertyName("run_command_targets")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventTargetRunCommandTargetsBlock>>? RunCommandTargets { get; set; }

    /// <summary>
    /// Block for sagemaker_pipeline_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SagemakerPipelineTarget block(s) allowed")]
    [TerraformPropertyName("sagemaker_pipeline_target")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventTargetSagemakerPipelineTargetBlock>>? SagemakerPipelineTarget { get; set; }

    /// <summary>
    /// Block for sqs_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqsTarget block(s) allowed")]
    [TerraformPropertyName("sqs_target")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventTargetSqsTargetBlock>>? SqsTarget { get; set; }

}
