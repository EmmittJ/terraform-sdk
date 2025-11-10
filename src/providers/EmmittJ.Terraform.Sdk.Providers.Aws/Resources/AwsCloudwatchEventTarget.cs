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
        get => GetProperty<TerraformProperty<string>>("graphql_operation");
        set => WithProperty("graphql_operation", value);
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
        get => GetProperty<TerraformProperty<double>>("array_size");
        set => WithProperty("array_size", value);
    }

    /// <summary>
    /// The job_attempts attribute.
    /// </summary>
    public TerraformProperty<double>? JobAttempts
    {
        get => GetProperty<TerraformProperty<double>>("job_attempts");
        set => WithProperty("job_attempts", value);
    }

    /// <summary>
    /// The job_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobDefinition is required")]
    public required TerraformProperty<string> JobDefinition
    {
        get => GetRequiredProperty<TerraformProperty<string>>("job_definition");
        set => WithProperty("job_definition", value);
    }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobName is required")]
    public required TerraformProperty<string> JobName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("job_name");
        set => WithProperty("job_name", value);
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
        get => GetProperty<TerraformProperty<string>>("arn");
        set => WithProperty("arn", value);
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
        get => GetProperty<TerraformProperty<bool>>("enable_ecs_managed_tags");
        set => WithProperty("enable_ecs_managed_tags", value);
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableExecuteCommand
    {
        get => GetProperty<TerraformProperty<bool>>("enable_execute_command");
        set => WithProperty("enable_execute_command", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformProperty<string>? Group
    {
        get => GetProperty<TerraformProperty<string>>("group");
        set => WithProperty("group", value);
    }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    public TerraformProperty<string>? LaunchType
    {
        get => GetProperty<TerraformProperty<string>>("launch_type");
        set => WithProperty("launch_type", value);
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformProperty<string>? PlatformVersion
    {
        get => GetProperty<TerraformProperty<string>>("platform_version");
        set => WithProperty("platform_version", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformProperty<string>? PropagateTags
    {
        get => GetProperty<TerraformProperty<string>>("propagate_tags");
        set => WithProperty("propagate_tags", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

    /// <summary>
    /// The task_count attribute.
    /// </summary>
    public TerraformProperty<double>? TaskCount
    {
        get => GetProperty<TerraformProperty<double>>("task_count");
        set => WithProperty("task_count", value);
    }

    /// <summary>
    /// The task_definition_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinitionArn is required")]
    public required TerraformProperty<string> TaskDefinitionArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("task_definition_arn");
        set => WithProperty("task_definition_arn", value);
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
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("header_parameters");
        set => WithProperty("header_parameters", value);
    }

    /// <summary>
    /// The path_parameter_values attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PathParameterValues
    {
        get => GetProperty<List<TerraformProperty<string>>>("path_parameter_values");
        set => WithProperty("path_parameter_values", value);
    }

    /// <summary>
    /// The query_string_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? QueryStringParameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("query_string_parameters");
        set => WithProperty("query_string_parameters", value);
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
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("input_paths");
        set => WithProperty("input_paths", value);
    }

    /// <summary>
    /// The input_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputTemplate is required")]
    public required TerraformProperty<string> InputTemplate
    {
        get => GetRequiredProperty<TerraformProperty<string>>("input_template");
        set => WithProperty("input_template", value);
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
        get => GetProperty<TerraformProperty<string>>("partition_key_path");
        set => WithProperty("partition_key_path", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("database");
        set => WithProperty("database", value);
    }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    public TerraformProperty<string>? DbUser
    {
        get => GetProperty<TerraformProperty<string>>("db_user");
        set => WithProperty("db_user", value);
    }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SecretsManagerArn
    {
        get => GetProperty<TerraformProperty<string>>("secrets_manager_arn");
        set => WithProperty("secrets_manager_arn", value);
    }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    public TerraformProperty<string>? Sql
    {
        get => GetProperty<TerraformProperty<string>>("sql");
        set => WithProperty("sql", value);
    }

    /// <summary>
    /// The statement_name attribute.
    /// </summary>
    public TerraformProperty<string>? StatementName
    {
        get => GetProperty<TerraformProperty<string>>("statement_name");
        set => WithProperty("statement_name", value);
    }

    /// <summary>
    /// The with_event attribute.
    /// </summary>
    public TerraformProperty<bool>? WithEvent
    {
        get => GetProperty<TerraformProperty<bool>>("with_event");
        set => WithProperty("with_event", value);
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
        get => GetProperty<TerraformProperty<double>>("maximum_event_age_in_seconds");
        set => WithProperty("maximum_event_age_in_seconds", value);
    }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumRetryAttempts
    {
        get => GetProperty<TerraformProperty<double>>("maximum_retry_attempts");
        set => WithProperty("maximum_retry_attempts", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public List<TerraformProperty<string>>? Values
    {
        get => GetProperty<List<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
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
        get => GetProperty<TerraformProperty<string>>("message_group_id");
        set => WithProperty("message_group_id", value);
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
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The event_bus_name attribute.
    /// </summary>
    public TerraformProperty<string>? EventBusName
    {
        get => GetProperty<TerraformProperty<string>>("event_bus_name");
        set => this.WithProperty("event_bus_name", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
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
    /// The input attribute.
    /// </summary>
    public TerraformProperty<string>? Input
    {
        get => GetProperty<TerraformProperty<string>>("input");
        set => this.WithProperty("input", value);
    }

    /// <summary>
    /// The input_path attribute.
    /// </summary>
    public TerraformProperty<string>? InputPath
    {
        get => GetProperty<TerraformProperty<string>>("input_path");
        set => this.WithProperty("input_path", value);
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
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    public required TerraformProperty<string> Rule
    {
        get => GetRequiredProperty<TerraformProperty<string>>("rule");
        set => this.WithProperty("rule", value);
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetId
    {
        get => GetProperty<TerraformProperty<string>>("target_id");
        set => this.WithProperty("target_id", value);
    }

    /// <summary>
    /// Block for appsync_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppsyncTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetAppsyncTargetBlock>? AppsyncTarget
    {
        get => GetProperty<List<AwsCloudwatchEventTargetAppsyncTargetBlock>>("appsync_target");
        set => this.WithProperty("appsync_target", value);
    }

    /// <summary>
    /// Block for batch_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BatchTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetBatchTargetBlock>? BatchTarget
    {
        get => GetProperty<List<AwsCloudwatchEventTargetBatchTargetBlock>>("batch_target");
        set => this.WithProperty("batch_target", value);
    }

    /// <summary>
    /// Block for dead_letter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterConfig block(s) allowed")]
    public List<AwsCloudwatchEventTargetDeadLetterConfigBlock>? DeadLetterConfig
    {
        get => GetProperty<List<AwsCloudwatchEventTargetDeadLetterConfigBlock>>("dead_letter_config");
        set => this.WithProperty("dead_letter_config", value);
    }

    /// <summary>
    /// Block for ecs_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EcsTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetEcsTargetBlock>? EcsTarget
    {
        get => GetProperty<List<AwsCloudwatchEventTargetEcsTargetBlock>>("ecs_target");
        set => this.WithProperty("ecs_target", value);
    }

    /// <summary>
    /// Block for http_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetHttpTargetBlock>? HttpTarget
    {
        get => GetProperty<List<AwsCloudwatchEventTargetHttpTargetBlock>>("http_target");
        set => this.WithProperty("http_target", value);
    }

    /// <summary>
    /// Block for input_transformer.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputTransformer block(s) allowed")]
    public List<AwsCloudwatchEventTargetInputTransformerBlock>? InputTransformer
    {
        get => GetProperty<List<AwsCloudwatchEventTargetInputTransformerBlock>>("input_transformer");
        set => this.WithProperty("input_transformer", value);
    }

    /// <summary>
    /// Block for kinesis_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetKinesisTargetBlock>? KinesisTarget
    {
        get => GetProperty<List<AwsCloudwatchEventTargetKinesisTargetBlock>>("kinesis_target");
        set => this.WithProperty("kinesis_target", value);
    }

    /// <summary>
    /// Block for redshift_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetRedshiftTargetBlock>? RedshiftTarget
    {
        get => GetProperty<List<AwsCloudwatchEventTargetRedshiftTargetBlock>>("redshift_target");
        set => this.WithProperty("redshift_target", value);
    }

    /// <summary>
    /// Block for retry_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public List<AwsCloudwatchEventTargetRetryPolicyBlock>? RetryPolicy
    {
        get => GetProperty<List<AwsCloudwatchEventTargetRetryPolicyBlock>>("retry_policy");
        set => this.WithProperty("retry_policy", value);
    }

    /// <summary>
    /// Block for run_command_targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 RunCommandTargets block(s) allowed")]
    public List<AwsCloudwatchEventTargetRunCommandTargetsBlock>? RunCommandTargets
    {
        get => GetProperty<List<AwsCloudwatchEventTargetRunCommandTargetsBlock>>("run_command_targets");
        set => this.WithProperty("run_command_targets", value);
    }

    /// <summary>
    /// Block for sagemaker_pipeline_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SagemakerPipelineTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetSagemakerPipelineTargetBlock>? SagemakerPipelineTarget
    {
        get => GetProperty<List<AwsCloudwatchEventTargetSagemakerPipelineTargetBlock>>("sagemaker_pipeline_target");
        set => this.WithProperty("sagemaker_pipeline_target", value);
    }

    /// <summary>
    /// Block for sqs_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqsTarget block(s) allowed")]
    public List<AwsCloudwatchEventTargetSqsTargetBlock>? SqsTarget
    {
        get => GetProperty<List<AwsCloudwatchEventTargetSqsTargetBlock>>("sqs_target");
        set => this.WithProperty("sqs_target", value);
    }

}
