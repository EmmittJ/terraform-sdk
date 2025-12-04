using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for flexible_time_window in AwsSchedulerSchedule.
/// Nesting mode: list
/// </summary>
public class AwsSchedulerScheduleFlexibleTimeWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "flexible_time_window";

    /// <summary>
    /// The maximum_window_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? MaximumWindowInMinutes
    {
        get => GetArgument<TerraformValue<double>>("maximum_window_in_minutes");
        set => SetArgument("maximum_window_in_minutes", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for target in AwsSchedulerSchedule.
/// Nesting mode: list
/// </summary>
public class AwsSchedulerScheduleTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetRequiredArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The input attribute.
    /// </summary>
    public TerraformValue<string>? Input
    {
        get => GetArgument<TerraformValue<string>>("input");
        set => SetArgument("input", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// DeadLetterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterConfig block(s) allowed")]
    public TerraformList<AwsSchedulerScheduleTargetBlockDeadLetterConfigBlock>? DeadLetterConfig
    {
        get => GetArgument<TerraformList<AwsSchedulerScheduleTargetBlockDeadLetterConfigBlock>>("dead_letter_config");
        set => SetArgument("dead_letter_config", value);
    }

    /// <summary>
    /// EcsParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EcsParameters block(s) allowed")]
    public TerraformList<AwsSchedulerScheduleTargetBlockEcsParametersBlock>? EcsParameters
    {
        get => GetArgument<TerraformList<AwsSchedulerScheduleTargetBlockEcsParametersBlock>>("ecs_parameters");
        set => SetArgument("ecs_parameters", value);
    }

    /// <summary>
    /// EventbridgeParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventbridgeParameters block(s) allowed")]
    public TerraformList<AwsSchedulerScheduleTargetBlockEventbridgeParametersBlock>? EventbridgeParameters
    {
        get => GetArgument<TerraformList<AwsSchedulerScheduleTargetBlockEventbridgeParametersBlock>>("eventbridge_parameters");
        set => SetArgument("eventbridge_parameters", value);
    }

    /// <summary>
    /// KinesisParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisParameters block(s) allowed")]
    public TerraformList<AwsSchedulerScheduleTargetBlockKinesisParametersBlock>? KinesisParameters
    {
        get => GetArgument<TerraformList<AwsSchedulerScheduleTargetBlockKinesisParametersBlock>>("kinesis_parameters");
        set => SetArgument("kinesis_parameters", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<AwsSchedulerScheduleTargetBlockRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<AwsSchedulerScheduleTargetBlockRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// SagemakerPipelineParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SagemakerPipelineParameters block(s) allowed")]
    public TerraformList<AwsSchedulerScheduleTargetBlockSagemakerPipelineParametersBlock>? SagemakerPipelineParameters
    {
        get => GetArgument<TerraformList<AwsSchedulerScheduleTargetBlockSagemakerPipelineParametersBlock>>("sagemaker_pipeline_parameters");
        set => SetArgument("sagemaker_pipeline_parameters", value);
    }

    /// <summary>
    /// SqsParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqsParameters block(s) allowed")]
    public TerraformList<AwsSchedulerScheduleTargetBlockSqsParametersBlock>? SqsParameters
    {
        get => GetArgument<TerraformList<AwsSchedulerScheduleTargetBlockSqsParametersBlock>>("sqs_parameters");
        set => SetArgument("sqs_parameters", value);
    }

}

/// <summary>
/// Block type for dead_letter_config in AwsSchedulerScheduleTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsSchedulerScheduleTargetBlockDeadLetterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dead_letter_config";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetRequiredArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

}

/// <summary>
/// Block type for ecs_parameters in AwsSchedulerScheduleTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsSchedulerScheduleTargetBlockEcsParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ecs_parameters";

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    public TerraformValue<bool>? EnableEcsManagedTags
    {
        get => GetArgument<TerraformValue<bool>>("enable_ecs_managed_tags");
        set => SetArgument("enable_ecs_managed_tags", value);
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public TerraformValue<bool>? EnableExecuteCommand
    {
        get => GetArgument<TerraformValue<bool>>("enable_execute_command");
        set => SetArgument("enable_execute_command", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformValue<string>? Group
    {
        get => GetArgument<TerraformValue<string>>("group");
        set => SetArgument("group", value);
    }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    public TerraformValue<string>? LaunchType
    {
        get => GetArgument<TerraformValue<string>>("launch_type");
        set => SetArgument("launch_type", value);
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformValue<string>? PlatformVersion
    {
        get => GetArgument<TerraformValue<string>>("platform_version");
        set => SetArgument("platform_version", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformValue<string>? PropagateTags
    {
        get => GetArgument<TerraformValue<string>>("propagate_tags");
        set => SetArgument("propagate_tags", value);
    }

    /// <summary>
    /// The reference_id attribute.
    /// </summary>
    public TerraformValue<string>? ReferenceId
    {
        get => GetArgument<TerraformValue<string>>("reference_id");
        set => SetArgument("reference_id", value);
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
    /// The task_count attribute.
    /// </summary>
    public TerraformValue<double>? TaskCount
    {
        get => GetArgument<TerraformValue<double>>("task_count");
        set => SetArgument("task_count", value);
    }

    /// <summary>
    /// The task_definition_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinitionArn is required")]
    public required TerraformValue<string> TaskDefinitionArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("task_definition_arn");
        set => SetArgument("task_definition_arn", value);
    }

    /// <summary>
    /// CapacityProviderStrategy block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(6, ErrorMessage = "Maximum 6 CapacityProviderStrategy block(s) allowed")]
    public TerraformSet<AwsSchedulerScheduleTargetBlockEcsParametersBlockCapacityProviderStrategyBlock>? CapacityProviderStrategy
    {
        get => GetArgument<TerraformSet<AwsSchedulerScheduleTargetBlockEcsParametersBlockCapacityProviderStrategyBlock>>("capacity_provider_strategy");
        set => SetArgument("capacity_provider_strategy", value);
    }

    /// <summary>
    /// NetworkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public TerraformList<AwsSchedulerScheduleTargetBlockEcsParametersBlockNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetArgument<TerraformList<AwsSchedulerScheduleTargetBlockEcsParametersBlockNetworkConfigurationBlock>>("network_configuration");
        set => SetArgument("network_configuration", value);
    }

    /// <summary>
    /// PlacementConstraints block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    public TerraformSet<AwsSchedulerScheduleTargetBlockEcsParametersBlockPlacementConstraintsBlock>? PlacementConstraints
    {
        get => GetArgument<TerraformSet<AwsSchedulerScheduleTargetBlockEcsParametersBlockPlacementConstraintsBlock>>("placement_constraints");
        set => SetArgument("placement_constraints", value);
    }

    /// <summary>
    /// PlacementStrategy block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 PlacementStrategy block(s) allowed")]
    public TerraformSet<AwsSchedulerScheduleTargetBlockEcsParametersBlockPlacementStrategyBlock>? PlacementStrategy
    {
        get => GetArgument<TerraformSet<AwsSchedulerScheduleTargetBlockEcsParametersBlockPlacementStrategyBlock>>("placement_strategy");
        set => SetArgument("placement_strategy", value);
    }

}

/// <summary>
/// Block type for capacity_provider_strategy in AwsSchedulerScheduleTargetBlockEcsParametersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSchedulerScheduleTargetBlockEcsParametersBlockCapacityProviderStrategyBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("base");
        set => SetArgument("base", value);
    }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    public required TerraformValue<string> CapacityProvider
    {
        get => GetRequiredArgument<TerraformValue<string>>("capacity_provider");
        set => SetArgument("capacity_provider", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => GetArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

}

/// <summary>
/// Block type for network_configuration in AwsSchedulerScheduleTargetBlockEcsParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsSchedulerScheduleTargetBlockEcsParametersBlockNetworkConfigurationBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("assign_public_ip");
        set => SetArgument("assign_public_ip", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroups
    {
        get => GetArgument<TerraformSet<string>>("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public required TerraformSet<string> Subnets
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnets");
        set => SetArgument("subnets", value);
    }

}

/// <summary>
/// Block type for placement_constraints in AwsSchedulerScheduleTargetBlockEcsParametersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSchedulerScheduleTargetBlockEcsParametersBlockPlacementConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "placement_constraints";

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for placement_strategy in AwsSchedulerScheduleTargetBlockEcsParametersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSchedulerScheduleTargetBlockEcsParametersBlockPlacementStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "placement_strategy";

    /// <summary>
    /// The field attribute.
    /// </summary>
    public TerraformValue<string>? Field
    {
        get => GetArgument<TerraformValue<string>>("field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for eventbridge_parameters in AwsSchedulerScheduleTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsSchedulerScheduleTargetBlockEventbridgeParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eventbridge_parameters";

    /// <summary>
    /// The detail_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetailType is required")]
    public required TerraformValue<string> DetailType
    {
        get => GetRequiredArgument<TerraformValue<string>>("detail_type");
        set => SetArgument("detail_type", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetRequiredArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for kinesis_parameters in AwsSchedulerScheduleTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsSchedulerScheduleTargetBlockKinesisParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_parameters";

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKey is required")]
    public required TerraformValue<string> PartitionKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("partition_key");
        set => SetArgument("partition_key", value);
    }

}

/// <summary>
/// Block type for retry_policy in AwsSchedulerScheduleTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsSchedulerScheduleTargetBlockRetryPolicyBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("maximum_event_age_in_seconds");
        set => SetArgument("maximum_event_age_in_seconds", value);
    }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    public TerraformValue<double>? MaximumRetryAttempts
    {
        get => GetArgument<TerraformValue<double>>("maximum_retry_attempts");
        set => SetArgument("maximum_retry_attempts", value);
    }

}

/// <summary>
/// Block type for sagemaker_pipeline_parameters in AwsSchedulerScheduleTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsSchedulerScheduleTargetBlockSagemakerPipelineParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sagemaker_pipeline_parameters";

    /// <summary>
    /// PipelineParameter block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(200, ErrorMessage = "Maximum 200 PipelineParameter block(s) allowed")]
    public TerraformSet<AwsSchedulerScheduleTargetBlockSagemakerPipelineParametersBlockPipelineParameterBlock>? PipelineParameter
    {
        get => GetArgument<TerraformSet<AwsSchedulerScheduleTargetBlockSagemakerPipelineParametersBlockPipelineParameterBlock>>("pipeline_parameter");
        set => SetArgument("pipeline_parameter", value);
    }

}

/// <summary>
/// Block type for pipeline_parameter in AwsSchedulerScheduleTargetBlockSagemakerPipelineParametersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSchedulerScheduleTargetBlockSagemakerPipelineParametersBlockPipelineParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pipeline_parameter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for sqs_parameters in AwsSchedulerScheduleTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsSchedulerScheduleTargetBlockSqsParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sqs_parameters";

    /// <summary>
    /// The message_group_id attribute.
    /// </summary>
    public TerraformValue<string>? MessageGroupId
    {
        get => GetArgument<TerraformValue<string>>("message_group_id");
        set => SetArgument("message_group_id", value);
    }

}


/// <summary>
/// Represents a aws_scheduler_schedule Terraform resource.
/// Manages a aws_scheduler_schedule resource.
/// </summary>
public partial class AwsSchedulerSchedule(string name) : TerraformResource("aws_scheduler_schedule", name)
{
    /// <summary>
    /// The action_after_completion attribute.
    /// </summary>
    public TerraformValue<string> ActionAfterCompletion
    {
        get => GetArgument<TerraformValue<string>>("action_after_completion") ?? AsReference("action_after_completion");
        set => SetArgument("action_after_completion", value);
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
    /// The end_date attribute.
    /// </summary>
    public TerraformValue<string>? EndDate
    {
        get => GetArgument<TerraformValue<string>>("end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public TerraformValue<string> GroupName
    {
        get => GetArgument<TerraformValue<string>>("group_name") ?? AsReference("group_name");
        set => SetArgument("group_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix") ?? AsReference("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformValue<string> ScheduleExpression
    {
        get => GetRequiredArgument<TerraformValue<string>>("schedule_expression");
        set => SetArgument("schedule_expression", value);
    }

    /// <summary>
    /// The schedule_expression_timezone attribute.
    /// </summary>
    public TerraformValue<string>? ScheduleExpressionTimezone
    {
        get => GetArgument<TerraformValue<string>>("schedule_expression_timezone");
        set => SetArgument("schedule_expression_timezone", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformValue<string>? StartDate
    {
        get => GetArgument<TerraformValue<string>>("start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// FlexibleTimeWindow block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlexibleTimeWindow is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FlexibleTimeWindow block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FlexibleTimeWindow block(s) allowed")]
    public required TerraformList<AwsSchedulerScheduleFlexibleTimeWindowBlock> FlexibleTimeWindow
    {
        get => GetRequiredArgument<TerraformList<AwsSchedulerScheduleFlexibleTimeWindowBlock>>("flexible_time_window");
        set => SetArgument("flexible_time_window", value);
    }

    /// <summary>
    /// Target block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public required TerraformList<AwsSchedulerScheduleTargetBlock> Target
    {
        get => GetRequiredArgument<TerraformList<AwsSchedulerScheduleTargetBlock>>("target");
        set => SetArgument("target", value);
    }

}
