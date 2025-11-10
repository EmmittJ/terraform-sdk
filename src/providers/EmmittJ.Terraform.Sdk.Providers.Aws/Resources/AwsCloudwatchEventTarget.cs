using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for appsync_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetAppsyncTargetBlock : TerraformBlock
{
    /// <summary>
    /// The graphql_operation attribute.
    /// </summary>
    public TerraformProperty<string>? GraphqlOperation
    {
        set => SetProperty("graphql_operation", value);
    }

}

/// <summary>
/// Block type for batch_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetBatchTargetBlock : TerraformBlock
{
    /// <summary>
    /// The array_size attribute.
    /// </summary>
    public TerraformProperty<double>? ArraySize
    {
        set => SetProperty("array_size", value);
    }

    /// <summary>
    /// The job_attempts attribute.
    /// </summary>
    public TerraformProperty<double>? JobAttempts
    {
        set => SetProperty("job_attempts", value);
    }

    /// <summary>
    /// The job_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobDefinition is required")]
    public required TerraformProperty<string> JobDefinition
    {
        set => SetProperty("job_definition", value);
    }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobName is required")]
    public required TerraformProperty<string> JobName
    {
        set => SetProperty("job_name", value);
    }

}

/// <summary>
/// Block type for dead_letter_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetDeadLetterConfigBlock : TerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        set => SetProperty("arn", value);
    }

}

/// <summary>
/// Block type for ecs_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetEcsTargetBlock : TerraformBlock
{
    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableEcsManagedTags
    {
        set => SetProperty("enable_ecs_managed_tags", value);
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableExecuteCommand
    {
        set => SetProperty("enable_execute_command", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformProperty<string>? Group
    {
        set => SetProperty("group", value);
    }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    public TerraformProperty<string>? LaunchType
    {
        set => SetProperty("launch_type", value);
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformProperty<string>? PlatformVersion
    {
        set => SetProperty("platform_version", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformProperty<string>? PropagateTags
    {
        set => SetProperty("propagate_tags", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The task_count attribute.
    /// </summary>
    public TerraformProperty<double>? TaskCount
    {
        set => SetProperty("task_count", value);
    }

    /// <summary>
    /// The task_definition_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinitionArn is required")]
    public required TerraformProperty<string> TaskDefinitionArn
    {
        set => SetProperty("task_definition_arn", value);
    }

}

/// <summary>
/// Block type for http_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetHttpTargetBlock : TerraformBlock
{
    /// <summary>
    /// The header_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? HeaderParameters
    {
        set => SetProperty("header_parameters", value);
    }

    /// <summary>
    /// The path_parameter_values attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PathParameterValues
    {
        set => SetProperty("path_parameter_values", value);
    }

    /// <summary>
    /// The query_string_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? QueryStringParameters
    {
        set => SetProperty("query_string_parameters", value);
    }

}

/// <summary>
/// Block type for input_transformer in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetInputTransformerBlock : TerraformBlock
{
    /// <summary>
    /// The input_paths attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? InputPaths
    {
        set => SetProperty("input_paths", value);
    }

    /// <summary>
    /// The input_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputTemplate is required")]
    public required TerraformProperty<string> InputTemplate
    {
        set => SetProperty("input_template", value);
    }

}

/// <summary>
/// Block type for kinesis_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetKinesisTargetBlock : TerraformBlock
{
    /// <summary>
    /// The partition_key_path attribute.
    /// </summary>
    public TerraformProperty<string>? PartitionKeyPath
    {
        set => SetProperty("partition_key_path", value);
    }

}

/// <summary>
/// Block type for redshift_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetRedshiftTargetBlock : TerraformBlock
{
    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformProperty<string> Database
    {
        set => SetProperty("database", value);
    }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    public TerraformProperty<string>? DbUser
    {
        set => SetProperty("db_user", value);
    }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SecretsManagerArn
    {
        set => SetProperty("secrets_manager_arn", value);
    }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    public TerraformProperty<string>? Sql
    {
        set => SetProperty("sql", value);
    }

    /// <summary>
    /// The statement_name attribute.
    /// </summary>
    public TerraformProperty<string>? StatementName
    {
        set => SetProperty("statement_name", value);
    }

    /// <summary>
    /// The with_event attribute.
    /// </summary>
    public TerraformProperty<bool>? WithEvent
    {
        set => SetProperty("with_event", value);
    }

}

/// <summary>
/// Block type for retry_policy in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The maximum_event_age_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumEventAgeInSeconds
    {
        set => SetProperty("maximum_event_age_in_seconds", value);
    }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumRetryAttempts
    {
        set => SetProperty("maximum_retry_attempts", value);
    }

}

/// <summary>
/// Block type for run_command_targets in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetRunCommandTargetsBlock : TerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public List<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Block type for sagemaker_pipeline_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetSagemakerPipelineTargetBlock : TerraformBlock
{
}

/// <summary>
/// Block type for sqs_target in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetSqsTargetBlock : TerraformBlock
{
    /// <summary>
    /// The message_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? MessageGroupId
    {
        set => SetProperty("message_group_id", value);
    }

}

/// <summary>
/// Manages a aws_cloudwatch_event_target resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudwatchEventTarget : TerraformResource
{
    public AwsCloudwatchEventTarget(string name) : base("aws_cloudwatch_event_target", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("event_bus_name");
        SetOutput("force_destroy");
        SetOutput("id");
        SetOutput("input");
        SetOutput("input_path");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("rule");
        SetOutput("target_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The event_bus_name attribute.
    /// </summary>
    public TerraformProperty<string> EventBusName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("event_bus_name");
        set => SetProperty("event_bus_name", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
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
    /// The input attribute.
    /// </summary>
    public TerraformProperty<string> Input
    {
        get => GetRequiredOutput<TerraformProperty<string>>("input");
        set => SetProperty("input", value);
    }

    /// <summary>
    /// The input_path attribute.
    /// </summary>
    public TerraformProperty<string> InputPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("input_path");
        set => SetProperty("input_path", value);
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
    public TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    public required TerraformProperty<string> Rule
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule");
        set => SetProperty("rule", value);
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    public TerraformProperty<string> TargetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_id");
        set => SetProperty("target_id", value);
    }

    /// <summary>
    /// Block for appsync_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppsyncTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetAppsyncTargetBlock>? AppsyncTarget
    {
        set => SetProperty("appsync_target", value);
    }

    /// <summary>
    /// Block for batch_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BatchTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetBatchTargetBlock>? BatchTarget
    {
        set => SetProperty("batch_target", value);
    }

    /// <summary>
    /// Block for dead_letter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterConfig block(s) allowed")]
    public List<AwsCloudwatchEventTargetDeadLetterConfigBlock>? DeadLetterConfig
    {
        set => SetProperty("dead_letter_config", value);
    }

    /// <summary>
    /// Block for ecs_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EcsTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetEcsTargetBlock>? EcsTarget
    {
        set => SetProperty("ecs_target", value);
    }

    /// <summary>
    /// Block for http_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetHttpTargetBlock>? HttpTarget
    {
        set => SetProperty("http_target", value);
    }

    /// <summary>
    /// Block for input_transformer.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputTransformer block(s) allowed")]
    public List<AwsCloudwatchEventTargetInputTransformerBlock>? InputTransformer
    {
        set => SetProperty("input_transformer", value);
    }

    /// <summary>
    /// Block for kinesis_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetKinesisTargetBlock>? KinesisTarget
    {
        set => SetProperty("kinesis_target", value);
    }

    /// <summary>
    /// Block for redshift_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetRedshiftTargetBlock>? RedshiftTarget
    {
        set => SetProperty("redshift_target", value);
    }

    /// <summary>
    /// Block for retry_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public List<AwsCloudwatchEventTargetRetryPolicyBlock>? RetryPolicy
    {
        set => SetProperty("retry_policy", value);
    }

    /// <summary>
    /// Block for run_command_targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 RunCommandTargets block(s) allowed")]
    public List<AwsCloudwatchEventTargetRunCommandTargetsBlock>? RunCommandTargets
    {
        set => SetProperty("run_command_targets", value);
    }

    /// <summary>
    /// Block for sagemaker_pipeline_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SagemakerPipelineTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetSagemakerPipelineTargetBlock>? SagemakerPipelineTarget
    {
        set => SetProperty("sagemaker_pipeline_target", value);
    }

    /// <summary>
    /// Block for sqs_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqsTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetSqsTargetBlock>? SqsTarget
    {
        set => SetProperty("sqs_target", value);
    }

}
