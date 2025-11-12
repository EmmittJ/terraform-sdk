using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for appsync_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventTargetAppsyncTargetBlock() : TerraformBlock("appsync_target")
{
    /// <summary>
    /// The graphql_operation attribute.
    /// </summary>
    [TerraformProperty("graphql_operation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GraphqlOperation { get; set; }

}

/// <summary>
/// Block type for batch_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventTargetBatchTargetBlock() : TerraformBlock("batch_target")
{
    /// <summary>
    /// The array_size attribute.
    /// </summary>
    [TerraformProperty("array_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ArraySize { get; set; }

    /// <summary>
    /// The job_attempts attribute.
    /// </summary>
    [TerraformProperty("job_attempts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? JobAttempts { get; set; }

    /// <summary>
    /// The job_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobDefinition is required")]
    [TerraformProperty("job_definition")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> JobDefinition { get; set; }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobName is required")]
    [TerraformProperty("job_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> JobName { get; set; }

}

/// <summary>
/// Block type for dead_letter_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventTargetDeadLetterConfigBlock() : TerraformBlock("dead_letter_config")
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Arn { get; set; }

}

/// <summary>
/// Block type for ecs_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventTargetEcsTargetBlock() : TerraformBlock("ecs_target")
{
    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    [TerraformProperty("enable_ecs_managed_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableEcsManagedTags { get; set; }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    [TerraformProperty("enable_execute_command")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableExecuteCommand { get; set; }

    /// <summary>
    /// The group attribute.
    /// </summary>
    [TerraformProperty("group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Group { get; set; }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    [TerraformProperty("launch_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LaunchType { get; set; }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformProperty("platform_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PlatformVersion { get; set; }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    [TerraformProperty("propagate_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PropagateTags { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The task_count attribute.
    /// </summary>
    [TerraformProperty("task_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TaskCount { get; set; }

    /// <summary>
    /// The task_definition_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinitionArn is required")]
    [TerraformProperty("task_definition_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TaskDefinitionArn { get; set; }

}

/// <summary>
/// Block type for http_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventTargetHttpTargetBlock() : TerraformBlock("http_target")
{
    /// <summary>
    /// The header_parameters attribute.
    /// </summary>
    [TerraformProperty("header_parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? HeaderParameters { get; set; }

    /// <summary>
    /// The path_parameter_values attribute.
    /// </summary>
    [TerraformProperty("path_parameter_values")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PathParameterValues { get; set; }

    /// <summary>
    /// The query_string_parameters attribute.
    /// </summary>
    [TerraformProperty("query_string_parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? QueryStringParameters { get; set; }

}

/// <summary>
/// Block type for input_transformer in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventTargetInputTransformerBlock() : TerraformBlock("input_transformer")
{
    /// <summary>
    /// The input_paths attribute.
    /// </summary>
    [TerraformProperty("input_paths")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? InputPaths { get; set; }

    /// <summary>
    /// The input_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputTemplate is required")]
    [TerraformProperty("input_template")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InputTemplate { get; set; }

}

/// <summary>
/// Block type for kinesis_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventTargetKinesisTargetBlock() : TerraformBlock("kinesis_target")
{
    /// <summary>
    /// The partition_key_path attribute.
    /// </summary>
    [TerraformProperty("partition_key_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PartitionKeyPath { get; set; }

}

/// <summary>
/// Block type for redshift_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventTargetRedshiftTargetBlock() : TerraformBlock("redshift_target")
{
    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformProperty("database")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Database { get; set; }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    [TerraformProperty("db_user")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DbUser { get; set; }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    [TerraformProperty("secrets_manager_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecretsManagerArn { get; set; }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    [TerraformProperty("sql")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Sql { get; set; }

    /// <summary>
    /// The statement_name attribute.
    /// </summary>
    [TerraformProperty("statement_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StatementName { get; set; }

    /// <summary>
    /// The with_event attribute.
    /// </summary>
    [TerraformProperty("with_event")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WithEvent { get; set; }

}

/// <summary>
/// Block type for retry_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventTargetRetryPolicyBlock() : TerraformBlock("retry_policy")
{
    /// <summary>
    /// The maximum_event_age_in_seconds attribute.
    /// </summary>
    [TerraformProperty("maximum_event_age_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaximumEventAgeInSeconds { get; set; }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    [TerraformProperty("maximum_retry_attempts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaximumRetryAttempts { get; set; }

}

/// <summary>
/// Block type for run_command_targets in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventTargetRunCommandTargetsBlock() : TerraformBlock("run_command_targets")
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Block type for sagemaker_pipeline_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventTargetSagemakerPipelineTargetBlock() : TerraformBlock("sagemaker_pipeline_target")
{
}

/// <summary>
/// Block type for sqs_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventTargetSqsTargetBlock() : TerraformBlock("sqs_target")
{
    /// <summary>
    /// The message_group_id attribute.
    /// </summary>
    [TerraformProperty("message_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MessageGroupId { get; set; }

}

/// <summary>
/// Manages a aws_cloudwatch_event_target resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudwatchEventTarget : TerraformResource
{
    public AwsCloudwatchEventTarget(string name) : base("aws_cloudwatch_event_target", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The event_bus_name attribute.
    /// </summary>
    [TerraformProperty("event_bus_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventBusName { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The input attribute.
    /// </summary>
    [TerraformProperty("input")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Input { get; set; }

    /// <summary>
    /// The input_path attribute.
    /// </summary>
    [TerraformProperty("input_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InputPath { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoleArn { get; set; }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [TerraformProperty("rule")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Rule { get; set; }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    [TerraformProperty("target_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TargetId { get; set; }

    /// <summary>
    /// Block for appsync_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppsyncTarget block(s) allowed")]
    [TerraformProperty("appsync_target")]
    public TerraformList<AwsCloudwatchEventTargetAppsyncTargetBlock> AppsyncTarget { get; set; } = new();

    /// <summary>
    /// Block for batch_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BatchTarget block(s) allowed")]
    [TerraformProperty("batch_target")]
    public TerraformList<AwsCloudwatchEventTargetBatchTargetBlock> BatchTarget { get; set; } = new();

    /// <summary>
    /// Block for dead_letter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterConfig block(s) allowed")]
    [TerraformProperty("dead_letter_config")]
    public TerraformList<AwsCloudwatchEventTargetDeadLetterConfigBlock> DeadLetterConfig { get; set; } = new();

    /// <summary>
    /// Block for ecs_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EcsTarget block(s) allowed")]
    [TerraformProperty("ecs_target")]
    public TerraformList<AwsCloudwatchEventTargetEcsTargetBlock> EcsTarget { get; set; } = new();

    /// <summary>
    /// Block for http_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpTarget block(s) allowed")]
    [TerraformProperty("http_target")]
    public TerraformList<AwsCloudwatchEventTargetHttpTargetBlock> HttpTarget { get; set; } = new();

    /// <summary>
    /// Block for input_transformer.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputTransformer block(s) allowed")]
    [TerraformProperty("input_transformer")]
    public TerraformList<AwsCloudwatchEventTargetInputTransformerBlock> InputTransformer { get; set; } = new();

    /// <summary>
    /// Block for kinesis_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisTarget block(s) allowed")]
    [TerraformProperty("kinesis_target")]
    public TerraformList<AwsCloudwatchEventTargetKinesisTargetBlock> KinesisTarget { get; set; } = new();

    /// <summary>
    /// Block for redshift_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftTarget block(s) allowed")]
    [TerraformProperty("redshift_target")]
    public TerraformList<AwsCloudwatchEventTargetRedshiftTargetBlock> RedshiftTarget { get; set; } = new();

    /// <summary>
    /// Block for retry_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    [TerraformProperty("retry_policy")]
    public TerraformList<AwsCloudwatchEventTargetRetryPolicyBlock> RetryPolicy { get; set; } = new();

    /// <summary>
    /// Block for run_command_targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 RunCommandTargets block(s) allowed")]
    [TerraformProperty("run_command_targets")]
    public TerraformList<AwsCloudwatchEventTargetRunCommandTargetsBlock> RunCommandTargets { get; set; } = new();

    /// <summary>
    /// Block for sagemaker_pipeline_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SagemakerPipelineTarget block(s) allowed")]
    [TerraformProperty("sagemaker_pipeline_target")]
    public TerraformList<AwsCloudwatchEventTargetSagemakerPipelineTargetBlock> SagemakerPipelineTarget { get; set; } = new();

    /// <summary>
    /// Block for sqs_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqsTarget block(s) allowed")]
    [TerraformProperty("sqs_target")]
    public TerraformList<AwsCloudwatchEventTargetSqsTargetBlock> SqsTarget { get; set; } = new();

}
