using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for application_source in AwsAutoscalingplansScalingPlan.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingplansScalingPlanApplicationSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_source";

    /// <summary>
    /// The cloudformation_stack_arn attribute.
    /// </summary>
    public TerraformValue<string>? CloudformationStackArn
    {
        get => GetArgument<TerraformValue<string>>("cloudformation_stack_arn");
        set => SetArgument("cloudformation_stack_arn", value);
    }

    /// <summary>
    /// TagFilter block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 TagFilter block(s) allowed")]
    public TerraformSet<AwsAutoscalingplansScalingPlanApplicationSourceBlockTagFilterBlock>? TagFilter
    {
        get => GetArgument<TerraformSet<AwsAutoscalingplansScalingPlanApplicationSourceBlockTagFilterBlock>>("tag_filter");
        set => SetArgument("tag_filter", value);
    }

}

/// <summary>
/// Block type for tag_filter in AwsAutoscalingplansScalingPlanApplicationSourceBlock.
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingplansScalingPlanApplicationSourceBlockTagFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_filter";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for scaling_instruction in AwsAutoscalingplansScalingPlan.
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingplansScalingPlanScalingInstructionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scaling_instruction";

    /// <summary>
    /// The disable_dynamic_scaling attribute.
    /// </summary>
    public TerraformValue<bool>? DisableDynamicScaling
    {
        get => GetArgument<TerraformValue<bool>>("disable_dynamic_scaling");
        set => SetArgument("disable_dynamic_scaling", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    public required TerraformValue<double> MaxCapacity
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformValue<double> MinCapacity
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_capacity");
        set => SetArgument("min_capacity", value);
    }

    /// <summary>
    /// The predictive_scaling_max_capacity_behavior attribute.
    /// </summary>
    public TerraformValue<string>? PredictiveScalingMaxCapacityBehavior
    {
        get => GetArgument<TerraformValue<string>>("predictive_scaling_max_capacity_behavior");
        set => SetArgument("predictive_scaling_max_capacity_behavior", value);
    }

    /// <summary>
    /// The predictive_scaling_max_capacity_buffer attribute.
    /// </summary>
    public TerraformValue<double> PredictiveScalingMaxCapacityBuffer
    {
        get => GetArgument<TerraformValue<double>>("predictive_scaling_max_capacity_buffer") ?? CreateReference("predictive_scaling_max_capacity_buffer");
        set => SetArgument("predictive_scaling_max_capacity_buffer", value);
    }

    /// <summary>
    /// The predictive_scaling_mode attribute.
    /// </summary>
    public TerraformValue<string>? PredictiveScalingMode
    {
        get => GetArgument<TerraformValue<string>>("predictive_scaling_mode");
        set => SetArgument("predictive_scaling_mode", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    public required TerraformValue<string> ScalableDimension
    {
        get => GetRequiredArgument<TerraformValue<string>>("scalable_dimension");
        set => SetArgument("scalable_dimension", value);
    }

    /// <summary>
    /// The scaling_policy_update_behavior attribute.
    /// </summary>
    public TerraformValue<string>? ScalingPolicyUpdateBehavior
    {
        get => GetArgument<TerraformValue<string>>("scaling_policy_update_behavior");
        set => SetArgument("scaling_policy_update_behavior", value);
    }

    /// <summary>
    /// The scheduled_action_buffer_time attribute.
    /// </summary>
    public TerraformValue<double>? ScheduledActionBufferTime
    {
        get => GetArgument<TerraformValue<double>>("scheduled_action_buffer_time");
        set => SetArgument("scheduled_action_buffer_time", value);
    }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    public required TerraformValue<string> ServiceNamespace
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_namespace");
        set => SetArgument("service_namespace", value);
    }

    /// <summary>
    /// CustomizedLoadMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomizedLoadMetricSpecification block(s) allowed")]
    public TerraformList<AwsAutoscalingplansScalingPlanScalingInstructionBlockCustomizedLoadMetricSpecificationBlock>? CustomizedLoadMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAutoscalingplansScalingPlanScalingInstructionBlockCustomizedLoadMetricSpecificationBlock>>("customized_load_metric_specification");
        set => SetArgument("customized_load_metric_specification", value);
    }

    /// <summary>
    /// PredefinedLoadMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredefinedLoadMetricSpecification block(s) allowed")]
    public TerraformList<AwsAutoscalingplansScalingPlanScalingInstructionBlockPredefinedLoadMetricSpecificationBlock>? PredefinedLoadMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAutoscalingplansScalingPlanScalingInstructionBlockPredefinedLoadMetricSpecificationBlock>>("predefined_load_metric_specification");
        set => SetArgument("predefined_load_metric_specification", value);
    }

    /// <summary>
    /// TargetTrackingConfiguration block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetTrackingConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetTrackingConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 TargetTrackingConfiguration block(s) allowed")]
    public required TerraformSet<AwsAutoscalingplansScalingPlanScalingInstructionBlockTargetTrackingConfigurationBlock> TargetTrackingConfiguration
    {
        get => GetRequiredArgument<TerraformSet<AwsAutoscalingplansScalingPlanScalingInstructionBlockTargetTrackingConfigurationBlock>>("target_tracking_configuration");
        set => SetArgument("target_tracking_configuration", value);
    }

}

/// <summary>
/// Block type for customized_load_metric_specification in AwsAutoscalingplansScalingPlanScalingInstructionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingplansScalingPlanScalingInstructionBlockCustomizedLoadMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customized_load_metric_specification";

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public TerraformMap<string>? Dimensions
    {
        get => GetArgument<TerraformMap<string>>("dimensions");
        set => SetArgument("dimensions", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => GetRequiredArgument<TerraformValue<string>>("metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The statistic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Statistic is required")]
    public required TerraformValue<string> Statistic
    {
        get => GetRequiredArgument<TerraformValue<string>>("statistic");
        set => SetArgument("statistic", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => GetArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

}

/// <summary>
/// Block type for predefined_load_metric_specification in AwsAutoscalingplansScalingPlanScalingInstructionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingplansScalingPlanScalingInstructionBlockPredefinedLoadMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predefined_load_metric_specification";

    /// <summary>
    /// The predefined_load_metric_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PredefinedLoadMetricType is required")]
    public required TerraformValue<string> PredefinedLoadMetricType
    {
        get => GetRequiredArgument<TerraformValue<string>>("predefined_load_metric_type");
        set => SetArgument("predefined_load_metric_type", value);
    }

    /// <summary>
    /// The resource_label attribute.
    /// </summary>
    public TerraformValue<string>? ResourceLabel
    {
        get => GetArgument<TerraformValue<string>>("resource_label");
        set => SetArgument("resource_label", value);
    }

}

/// <summary>
/// Block type for target_tracking_configuration in AwsAutoscalingplansScalingPlanScalingInstructionBlock.
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingplansScalingPlanScalingInstructionBlockTargetTrackingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_tracking_configuration";

    /// <summary>
    /// The disable_scale_in attribute.
    /// </summary>
    public TerraformValue<bool>? DisableScaleIn
    {
        get => GetArgument<TerraformValue<bool>>("disable_scale_in");
        set => SetArgument("disable_scale_in", value);
    }

    /// <summary>
    /// The estimated_instance_warmup attribute.
    /// </summary>
    public TerraformValue<double>? EstimatedInstanceWarmup
    {
        get => GetArgument<TerraformValue<double>>("estimated_instance_warmup");
        set => SetArgument("estimated_instance_warmup", value);
    }

    /// <summary>
    /// The scale_in_cooldown attribute.
    /// </summary>
    public TerraformValue<double>? ScaleInCooldown
    {
        get => GetArgument<TerraformValue<double>>("scale_in_cooldown");
        set => SetArgument("scale_in_cooldown", value);
    }

    /// <summary>
    /// The scale_out_cooldown attribute.
    /// </summary>
    public TerraformValue<double>? ScaleOutCooldown
    {
        get => GetArgument<TerraformValue<double>>("scale_out_cooldown");
        set => SetArgument("scale_out_cooldown", value);
    }

    /// <summary>
    /// The target_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetValue is required")]
    public required TerraformValue<double> TargetValue
    {
        get => GetRequiredArgument<TerraformValue<double>>("target_value");
        set => SetArgument("target_value", value);
    }

    /// <summary>
    /// CustomizedScalingMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomizedScalingMetricSpecification block(s) allowed")]
    public TerraformList<AwsAutoscalingplansScalingPlanScalingInstructionBlockTargetTrackingConfigurationBlockCustomizedScalingMetricSpecificationBlock>? CustomizedScalingMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAutoscalingplansScalingPlanScalingInstructionBlockTargetTrackingConfigurationBlockCustomizedScalingMetricSpecificationBlock>>("customized_scaling_metric_specification");
        set => SetArgument("customized_scaling_metric_specification", value);
    }

    /// <summary>
    /// PredefinedScalingMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredefinedScalingMetricSpecification block(s) allowed")]
    public TerraformList<AwsAutoscalingplansScalingPlanScalingInstructionBlockTargetTrackingConfigurationBlockPredefinedScalingMetricSpecificationBlock>? PredefinedScalingMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAutoscalingplansScalingPlanScalingInstructionBlockTargetTrackingConfigurationBlockPredefinedScalingMetricSpecificationBlock>>("predefined_scaling_metric_specification");
        set => SetArgument("predefined_scaling_metric_specification", value);
    }

}

/// <summary>
/// Block type for customized_scaling_metric_specification in AwsAutoscalingplansScalingPlanScalingInstructionBlockTargetTrackingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingplansScalingPlanScalingInstructionBlockTargetTrackingConfigurationBlockCustomizedScalingMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customized_scaling_metric_specification";

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public TerraformMap<string>? Dimensions
    {
        get => GetArgument<TerraformMap<string>>("dimensions");
        set => SetArgument("dimensions", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => GetRequiredArgument<TerraformValue<string>>("metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The statistic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Statistic is required")]
    public required TerraformValue<string> Statistic
    {
        get => GetRequiredArgument<TerraformValue<string>>("statistic");
        set => SetArgument("statistic", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => GetArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

}

/// <summary>
/// Block type for predefined_scaling_metric_specification in AwsAutoscalingplansScalingPlanScalingInstructionBlockTargetTrackingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingplansScalingPlanScalingInstructionBlockTargetTrackingConfigurationBlockPredefinedScalingMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predefined_scaling_metric_specification";

    /// <summary>
    /// The predefined_scaling_metric_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PredefinedScalingMetricType is required")]
    public required TerraformValue<string> PredefinedScalingMetricType
    {
        get => GetRequiredArgument<TerraformValue<string>>("predefined_scaling_metric_type");
        set => SetArgument("predefined_scaling_metric_type", value);
    }

    /// <summary>
    /// The resource_label attribute.
    /// </summary>
    public TerraformValue<string>? ResourceLabel
    {
        get => GetArgument<TerraformValue<string>>("resource_label");
        set => SetArgument("resource_label", value);
    }

}


/// <summary>
/// Represents a aws_autoscalingplans_scaling_plan Terraform resource.
/// Manages a aws_autoscalingplans_scaling_plan resource.
/// </summary>
public partial class AwsAutoscalingplansScalingPlan(string name) : TerraformResource("aws_autoscalingplans_scaling_plan", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The scaling_plan_version attribute.
    /// </summary>
    public TerraformValue<double> ScalingPlanVersion
        => CreateReference("scaling_plan_version");

    /// <summary>
    /// ApplicationSource block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationSource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApplicationSource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationSource block(s) allowed")]
    public required TerraformList<AwsAutoscalingplansScalingPlanApplicationSourceBlock> ApplicationSource
    {
        get => GetRequiredArgument<TerraformList<AwsAutoscalingplansScalingPlanApplicationSourceBlock>>("application_source");
        set => SetArgument("application_source", value);
    }

    /// <summary>
    /// ScalingInstruction block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingInstruction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScalingInstruction block(s) required")]
    public required TerraformSet<AwsAutoscalingplansScalingPlanScalingInstructionBlock> ScalingInstruction
    {
        get => GetRequiredArgument<TerraformSet<AwsAutoscalingplansScalingPlanScalingInstructionBlock>>("scaling_instruction");
        set => SetArgument("scaling_instruction", value);
    }

}
