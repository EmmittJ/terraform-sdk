using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for appsync_target in AwsCloudwatchEventTarget.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetAppsyncTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "appsync_target";

    /// <summary>
    /// The graphql_operation attribute.
    /// </summary>
    public TerraformValue<string>? GraphqlOperation
    {
        get => new TerraformReference<string>(this, "graphql_operation");
        set => SetArgument("graphql_operation", value);
    }

}


/// <summary>
/// Block type for batch_target in AwsCloudwatchEventTarget.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetBatchTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "batch_target";

    /// <summary>
    /// The array_size attribute.
    /// </summary>
    public TerraformValue<double>? ArraySize
    {
        get => new TerraformReference<double>(this, "array_size");
        set => SetArgument("array_size", value);
    }

    /// <summary>
    /// The job_attempts attribute.
    /// </summary>
    public TerraformValue<double>? JobAttempts
    {
        get => new TerraformReference<double>(this, "job_attempts");
        set => SetArgument("job_attempts", value);
    }

    /// <summary>
    /// The job_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobDefinition is required")]
    public required TerraformValue<string> JobDefinition
    {
        get => new TerraformReference<string>(this, "job_definition");
        set => SetArgument("job_definition", value);
    }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobName is required")]
    public required TerraformValue<string> JobName
    {
        get => new TerraformReference<string>(this, "job_name");
        set => SetArgument("job_name", value);
    }

}


/// <summary>
/// Block type for dead_letter_config in AwsCloudwatchEventTarget.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetDeadLetterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dead_letter_config";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string>? Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

}


/// <summary>
/// Block type for ecs_target in AwsCloudwatchEventTarget.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetEcsTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ecs_target";

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    public TerraformValue<bool>? EnableEcsManagedTags
    {
        get => new TerraformReference<bool>(this, "enable_ecs_managed_tags");
        set => SetArgument("enable_ecs_managed_tags", value);
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public TerraformValue<bool>? EnableExecuteCommand
    {
        get => new TerraformReference<bool>(this, "enable_execute_command");
        set => SetArgument("enable_execute_command", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformValue<string>? Group
    {
        get => new TerraformReference<string>(this, "group");
        set => SetArgument("group", value);
    }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    public TerraformValue<string>? LaunchType
    {
        get => new TerraformReference<string>(this, "launch_type");
        set => SetArgument("launch_type", value);
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformValue<string>? PlatformVersion
    {
        get => new TerraformReference<string>(this, "platform_version");
        set => SetArgument("platform_version", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformValue<string>? PropagateTags
    {
        get => new TerraformReference<string>(this, "propagate_tags");
        set => SetArgument("propagate_tags", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The task_count attribute.
    /// </summary>
    public TerraformValue<double>? TaskCount
    {
        get => new TerraformReference<double>(this, "task_count");
        set => SetArgument("task_count", value);
    }

    /// <summary>
    /// The task_definition_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinitionArn is required")]
    public required TerraformValue<string> TaskDefinitionArn
    {
        get => new TerraformReference<string>(this, "task_definition_arn");
        set => SetArgument("task_definition_arn", value);
    }

    /// <summary>
    /// CapacityProviderStrategy block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudwatchEventTargetEcsTargetBlockCapacityProviderStrategyBlock>? CapacityProviderStrategy
    {
        get => GetArgument<TerraformSet<AwsCloudwatchEventTargetEcsTargetBlockCapacityProviderStrategyBlock>>("capacity_provider_strategy");
        set => SetArgument("capacity_provider_strategy", value);
    }

    /// <summary>
    /// NetworkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public TerraformList<AwsCloudwatchEventTargetEcsTargetBlockNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventTargetEcsTargetBlockNetworkConfigurationBlock>>("network_configuration");
        set => SetArgument("network_configuration", value);
    }

    /// <summary>
    /// OrderedPlacementStrategy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 OrderedPlacementStrategy block(s) allowed")]
    public TerraformList<AwsCloudwatchEventTargetEcsTargetBlockOrderedPlacementStrategyBlock>? OrderedPlacementStrategy
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventTargetEcsTargetBlockOrderedPlacementStrategyBlock>>("ordered_placement_strategy");
        set => SetArgument("ordered_placement_strategy", value);
    }

    /// <summary>
    /// PlacementConstraint block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraint block(s) allowed")]
    public TerraformSet<AwsCloudwatchEventTargetEcsTargetBlockPlacementConstraintBlock>? PlacementConstraint
    {
        get => GetArgument<TerraformSet<AwsCloudwatchEventTargetEcsTargetBlockPlacementConstraintBlock>>("placement_constraint");
        set => SetArgument("placement_constraint", value);
    }

}

/// <summary>
/// Block type for capacity_provider_strategy in AwsCloudwatchEventTargetEcsTargetBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudwatchEventTargetEcsTargetBlockCapacityProviderStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_provider_strategy";

    /// <summary>
    /// The base attribute.
    /// </summary>
    public TerraformValue<double>? BaseAttribute
    {
        get => new TerraformReference<double>(this, "base");
        set => SetArgument("base", value);
    }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    public required TerraformValue<string> CapacityProvider
    {
        get => new TerraformReference<string>(this, "capacity_provider");
        set => SetArgument("capacity_provider", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

}

/// <summary>
/// Block type for network_configuration in AwsCloudwatchEventTargetEcsTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetEcsTargetBlockNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_configuration";

    /// <summary>
    /// The assign_public_ip attribute.
    /// </summary>
    public TerraformValue<bool>? AssignPublicIp
    {
        get => new TerraformReference<bool>(this, "assign_public_ip");
        set => SetArgument("assign_public_ip", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_groups").ResolveNodes(ctx));
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public required TerraformSet<string> Subnets
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnets").ResolveNodes(ctx));
        set => SetArgument("subnets", value);
    }

}

/// <summary>
/// Block type for ordered_placement_strategy in AwsCloudwatchEventTargetEcsTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetEcsTargetBlockOrderedPlacementStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ordered_placement_strategy";

    /// <summary>
    /// The field attribute.
    /// </summary>
    public TerraformValue<string>? Field
    {
        get => new TerraformReference<string>(this, "field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for placement_constraint in AwsCloudwatchEventTargetEcsTargetBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudwatchEventTargetEcsTargetBlockPlacementConstraintBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "placement_constraint";

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for http_target in AwsCloudwatchEventTarget.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetHttpTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_target";

    /// <summary>
    /// The header_parameters attribute.
    /// </summary>
    public TerraformMap<string>? HeaderParameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "header_parameters").ResolveNodes(ctx));
        set => SetArgument("header_parameters", value);
    }

    /// <summary>
    /// The path_parameter_values attribute.
    /// </summary>
    public TerraformList<string>? PathParameterValues
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "path_parameter_values").ResolveNodes(ctx));
        set => SetArgument("path_parameter_values", value);
    }

    /// <summary>
    /// The query_string_parameters attribute.
    /// </summary>
    public TerraformMap<string>? QueryStringParameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "query_string_parameters").ResolveNodes(ctx));
        set => SetArgument("query_string_parameters", value);
    }

}


/// <summary>
/// Block type for input_transformer in AwsCloudwatchEventTarget.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetInputTransformerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_transformer";

    /// <summary>
    /// The input_paths attribute.
    /// </summary>
    public TerraformMap<string>? InputPaths
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "input_paths").ResolveNodes(ctx));
        set => SetArgument("input_paths", value);
    }

    /// <summary>
    /// The input_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputTemplate is required")]
    public required TerraformValue<string> InputTemplate
    {
        get => new TerraformReference<string>(this, "input_template");
        set => SetArgument("input_template", value);
    }

}


/// <summary>
/// Block type for kinesis_target in AwsCloudwatchEventTarget.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetKinesisTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_target";

    /// <summary>
    /// The partition_key_path attribute.
    /// </summary>
    public TerraformValue<string>? PartitionKeyPath
    {
        get => new TerraformReference<string>(this, "partition_key_path");
        set => SetArgument("partition_key_path", value);
    }

}


/// <summary>
/// Block type for redshift_target in AwsCloudwatchEventTarget.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetRedshiftTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redshift_target";

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => new TerraformReference<string>(this, "database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    public TerraformValue<string>? DbUser
    {
        get => new TerraformReference<string>(this, "db_user");
        set => SetArgument("db_user", value);
    }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    public TerraformValue<string>? SecretsManagerArn
    {
        get => new TerraformReference<string>(this, "secrets_manager_arn");
        set => SetArgument("secrets_manager_arn", value);
    }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    public TerraformValue<string>? Sql
    {
        get => new TerraformReference<string>(this, "sql");
        set => SetArgument("sql", value);
    }

    /// <summary>
    /// The statement_name attribute.
    /// </summary>
    public TerraformValue<string>? StatementName
    {
        get => new TerraformReference<string>(this, "statement_name");
        set => SetArgument("statement_name", value);
    }

    /// <summary>
    /// The with_event attribute.
    /// </summary>
    public TerraformValue<bool>? WithEvent
    {
        get => new TerraformReference<bool>(this, "with_event");
        set => SetArgument("with_event", value);
    }

}


/// <summary>
/// Block type for retry_policy in AwsCloudwatchEventTarget.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_policy";

    /// <summary>
    /// The maximum_event_age_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaximumEventAgeInSeconds
    {
        get => new TerraformReference<double>(this, "maximum_event_age_in_seconds");
        set => SetArgument("maximum_event_age_in_seconds", value);
    }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    public TerraformValue<double>? MaximumRetryAttempts
    {
        get => new TerraformReference<double>(this, "maximum_retry_attempts");
        set => SetArgument("maximum_retry_attempts", value);
    }

}


/// <summary>
/// Block type for run_command_targets in AwsCloudwatchEventTarget.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetRunCommandTargetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "run_command_targets";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for sagemaker_pipeline_target in AwsCloudwatchEventTarget.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetSagemakerPipelineTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sagemaker_pipeline_target";

    /// <summary>
    /// PipelineParameterList block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(200, ErrorMessage = "Maximum 200 PipelineParameterList block(s) allowed")]
    public TerraformSet<AwsCloudwatchEventTargetSagemakerPipelineTargetBlockPipelineParameterListBlock>? PipelineParameterList
    {
        get => GetArgument<TerraformSet<AwsCloudwatchEventTargetSagemakerPipelineTargetBlockPipelineParameterListBlock>>("pipeline_parameter_list");
        set => SetArgument("pipeline_parameter_list", value);
    }

}

/// <summary>
/// Block type for pipeline_parameter_list in AwsCloudwatchEventTargetSagemakerPipelineTargetBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudwatchEventTargetSagemakerPipelineTargetBlockPipelineParameterListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pipeline_parameter_list";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for sqs_target in AwsCloudwatchEventTarget.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventTargetSqsTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sqs_target";

    /// <summary>
    /// The message_group_id attribute.
    /// </summary>
    public TerraformValue<string>? MessageGroupId
    {
        get => new TerraformReference<string>(this, "message_group_id");
        set => SetArgument("message_group_id", value);
    }

}


/// <summary>
/// Represents a aws_cloudwatch_event_target Terraform resource.
/// Manages a aws_cloudwatch_event_target resource.
/// </summary>
public partial class AwsCloudwatchEventTarget(string name) : TerraformResource("aws_cloudwatch_event_target", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The event_bus_name attribute.
    /// </summary>
    public TerraformValue<string>? EventBusName
    {
        get => new TerraformReference<string>(this, "event_bus_name");
        set => SetArgument("event_bus_name", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => new TerraformReference<bool>(this, "force_destroy");
        set => SetArgument("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The input attribute.
    /// </summary>
    public TerraformValue<string>? Input
    {
        get => new TerraformReference<string>(this, "input");
        set => SetArgument("input", value);
    }

    /// <summary>
    /// The input_path attribute.
    /// </summary>
    public TerraformValue<string>? InputPath
    {
        get => new TerraformReference<string>(this, "input_path");
        set => SetArgument("input_path", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    public required TerraformValue<string> Rule
    {
        get => new TerraformReference<string>(this, "rule");
        set => SetArgument("rule", value);
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    public TerraformValue<string> TargetId
    {
        get => new TerraformReference<string>(this, "target_id");
        set => SetArgument("target_id", value);
    }

    /// <summary>
    /// AppsyncTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppsyncTarget block(s) allowed")]
    public TerraformList<AwsCloudwatchEventTargetAppsyncTargetBlock>? AppsyncTarget
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventTargetAppsyncTargetBlock>>("appsync_target");
        set => SetArgument("appsync_target", value);
    }

    /// <summary>
    /// BatchTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BatchTarget block(s) allowed")]
    public TerraformList<AwsCloudwatchEventTargetBatchTargetBlock>? BatchTarget
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventTargetBatchTargetBlock>>("batch_target");
        set => SetArgument("batch_target", value);
    }

    /// <summary>
    /// DeadLetterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterConfig block(s) allowed")]
    public TerraformList<AwsCloudwatchEventTargetDeadLetterConfigBlock>? DeadLetterConfig
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventTargetDeadLetterConfigBlock>>("dead_letter_config");
        set => SetArgument("dead_letter_config", value);
    }

    /// <summary>
    /// EcsTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EcsTarget block(s) allowed")]
    public TerraformList<AwsCloudwatchEventTargetEcsTargetBlock>? EcsTarget
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventTargetEcsTargetBlock>>("ecs_target");
        set => SetArgument("ecs_target", value);
    }

    /// <summary>
    /// HttpTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpTarget block(s) allowed")]
    public TerraformList<AwsCloudwatchEventTargetHttpTargetBlock>? HttpTarget
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventTargetHttpTargetBlock>>("http_target");
        set => SetArgument("http_target", value);
    }

    /// <summary>
    /// InputTransformer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputTransformer block(s) allowed")]
    public TerraformList<AwsCloudwatchEventTargetInputTransformerBlock>? InputTransformer
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventTargetInputTransformerBlock>>("input_transformer");
        set => SetArgument("input_transformer", value);
    }

    /// <summary>
    /// KinesisTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisTarget block(s) allowed")]
    public TerraformList<AwsCloudwatchEventTargetKinesisTargetBlock>? KinesisTarget
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventTargetKinesisTargetBlock>>("kinesis_target");
        set => SetArgument("kinesis_target", value);
    }

    /// <summary>
    /// RedshiftTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftTarget block(s) allowed")]
    public TerraformList<AwsCloudwatchEventTargetRedshiftTargetBlock>? RedshiftTarget
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventTargetRedshiftTargetBlock>>("redshift_target");
        set => SetArgument("redshift_target", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<AwsCloudwatchEventTargetRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventTargetRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// RunCommandTargets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 RunCommandTargets block(s) allowed")]
    public TerraformList<AwsCloudwatchEventTargetRunCommandTargetsBlock>? RunCommandTargets
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventTargetRunCommandTargetsBlock>>("run_command_targets");
        set => SetArgument("run_command_targets", value);
    }

    /// <summary>
    /// SagemakerPipelineTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SagemakerPipelineTarget block(s) allowed")]
    public TerraformList<AwsCloudwatchEventTargetSagemakerPipelineTargetBlock>? SagemakerPipelineTarget
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventTargetSagemakerPipelineTargetBlock>>("sagemaker_pipeline_target");
        set => SetArgument("sagemaker_pipeline_target", value);
    }

    /// <summary>
    /// SqsTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqsTarget block(s) allowed")]
    public TerraformList<AwsCloudwatchEventTargetSqsTargetBlock>? SqsTarget
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventTargetSqsTargetBlock>>("sqs_target");
        set => SetArgument("sqs_target", value);
    }

}
