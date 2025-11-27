using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for predictive_scaling_policy_configuration in AwsAppautoscalingPolicy.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predictive_scaling_policy_configuration";

    /// <summary>
    /// The max_capacity_breach_behavior attribute.
    /// </summary>
    public TerraformValue<string>? MaxCapacityBreachBehavior
    {
        get => new TerraformReference<string>(this, "max_capacity_breach_behavior");
        set => SetArgument("max_capacity_breach_behavior", value);
    }

    /// <summary>
    /// The max_capacity_buffer attribute.
    /// </summary>
    public TerraformValue<double>? MaxCapacityBuffer
    {
        get => new TerraformReference<double>(this, "max_capacity_buffer");
        set => SetArgument("max_capacity_buffer", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The scheduling_buffer_time attribute.
    /// </summary>
    public TerraformValue<double> SchedulingBufferTime
    {
        get => new TerraformReference<double>(this, "scheduling_buffer_time");
        set => SetArgument("scheduling_buffer_time", value);
    }

    /// <summary>
    /// MetricSpecification block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricSpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetricSpecification block(s) required")]
    public required TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlock> MetricSpecification
    {
        get => GetRequiredArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlock>>("metric_specification");
        set => SetArgument("metric_specification", value);
    }

}

/// <summary>
/// Block type for metric_specification in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_specification";

    /// <summary>
    /// The target_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetValue is required")]
    public required TerraformValue<string> TargetValue
    {
        get => new TerraformReference<string>(this, "target_value");
        set => SetArgument("target_value", value);
    }

    /// <summary>
    /// CustomizedCapacityMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomizedCapacityMetricSpecification block(s) allowed")]
    public TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlock>? CustomizedCapacityMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlock>>("customized_capacity_metric_specification");
        set => SetArgument("customized_capacity_metric_specification", value);
    }

    /// <summary>
    /// CustomizedLoadMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomizedLoadMetricSpecification block(s) allowed")]
    public TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlock>? CustomizedLoadMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlock>>("customized_load_metric_specification");
        set => SetArgument("customized_load_metric_specification", value);
    }

    /// <summary>
    /// CustomizedScalingMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomizedScalingMetricSpecification block(s) allowed")]
    public TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlock>? CustomizedScalingMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlock>>("customized_scaling_metric_specification");
        set => SetArgument("customized_scaling_metric_specification", value);
    }

    /// <summary>
    /// PredefinedLoadMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredefinedLoadMetricSpecification block(s) allowed")]
    public TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockPredefinedLoadMetricSpecificationBlock>? PredefinedLoadMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockPredefinedLoadMetricSpecificationBlock>>("predefined_load_metric_specification");
        set => SetArgument("predefined_load_metric_specification", value);
    }

    /// <summary>
    /// PredefinedMetricPairSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredefinedMetricPairSpecification block(s) allowed")]
    public TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockPredefinedMetricPairSpecificationBlock>? PredefinedMetricPairSpecification
    {
        get => GetArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockPredefinedMetricPairSpecificationBlock>>("predefined_metric_pair_specification");
        set => SetArgument("predefined_metric_pair_specification", value);
    }

    /// <summary>
    /// PredefinedScalingMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredefinedScalingMetricSpecification block(s) allowed")]
    public TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockPredefinedScalingMetricSpecificationBlock>? PredefinedScalingMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockPredefinedScalingMetricSpecificationBlock>>("predefined_scaling_metric_specification");
        set => SetArgument("predefined_scaling_metric_specification", value);
    }

}

/// <summary>
/// Block type for customized_capacity_metric_specification in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customized_capacity_metric_specification";

    /// <summary>
    /// MetricDataQuery block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricDataQuery is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetricDataQuery block(s) required")]
    public required TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueryBlock> MetricDataQuery
    {
        get => GetRequiredArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueryBlock>>("metric_data_query");
        set => SetArgument("metric_data_query", value);
    }

}

/// <summary>
/// Block type for metric_data_query in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_data_query";

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The return_data attribute.
    /// </summary>
    public TerraformValue<bool>? ReturnData
    {
        get => new TerraformReference<bool>(this, "return_data");
        set => SetArgument("return_data", value);
    }

    /// <summary>
    /// MetricStat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricStat block(s) allowed")]
    public TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueryBlockMetricStatBlock>? MetricStat
    {
        get => GetArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueryBlockMetricStatBlock>>("metric_stat");
        set => SetArgument("metric_stat", value);
    }

}

/// <summary>
/// Block type for metric_stat in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueryBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueryBlockMetricStatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_stat";

    /// <summary>
    /// The stat attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stat is required")]
    public required TerraformValue<string> Stat
    {
        get => new TerraformReference<string>(this, "stat");
        set => SetArgument("stat", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// Metric block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metric is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Metric block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metric block(s) allowed")]
    public required TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlock> Metric
    {
        get => GetRequiredArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlock>>("metric");
        set => SetArgument("metric", value);
    }

}

/// <summary>
/// Block type for metric in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueryBlockMetricStatBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric";

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    public TerraformValue<string>? MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformSet<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

}

/// <summary>
/// Block type for dimension in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

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
/// Block type for customized_load_metric_specification in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customized_load_metric_specification";

    /// <summary>
    /// MetricDataQuery block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricDataQuery is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetricDataQuery block(s) required")]
    public required TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueryBlock> MetricDataQuery
    {
        get => GetRequiredArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueryBlock>>("metric_data_query");
        set => SetArgument("metric_data_query", value);
    }

}

/// <summary>
/// Block type for metric_data_query in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_data_query";

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The return_data attribute.
    /// </summary>
    public TerraformValue<bool>? ReturnData
    {
        get => new TerraformReference<bool>(this, "return_data");
        set => SetArgument("return_data", value);
    }

    /// <summary>
    /// MetricStat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricStat block(s) allowed")]
    public TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueryBlockMetricStatBlock>? MetricStat
    {
        get => GetArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueryBlockMetricStatBlock>>("metric_stat");
        set => SetArgument("metric_stat", value);
    }

}

/// <summary>
/// Block type for metric_stat in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueryBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueryBlockMetricStatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_stat";

    /// <summary>
    /// The stat attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stat is required")]
    public required TerraformValue<string> Stat
    {
        get => new TerraformReference<string>(this, "stat");
        set => SetArgument("stat", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// Metric block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metric is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Metric block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metric block(s) allowed")]
    public required TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlock> Metric
    {
        get => GetRequiredArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlock>>("metric");
        set => SetArgument("metric", value);
    }

}

/// <summary>
/// Block type for metric in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueryBlockMetricStatBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric";

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    public TerraformValue<string>? MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformSet<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

}

/// <summary>
/// Block type for dimension in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

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
/// Block type for customized_scaling_metric_specification in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customized_scaling_metric_specification";

    /// <summary>
    /// MetricDataQuery block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricDataQuery is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetricDataQuery block(s) required")]
    public required TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueryBlock> MetricDataQuery
    {
        get => GetRequiredArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueryBlock>>("metric_data_query");
        set => SetArgument("metric_data_query", value);
    }

}

/// <summary>
/// Block type for metric_data_query in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_data_query";

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The return_data attribute.
    /// </summary>
    public TerraformValue<bool>? ReturnData
    {
        get => new TerraformReference<bool>(this, "return_data");
        set => SetArgument("return_data", value);
    }

    /// <summary>
    /// MetricStat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricStat block(s) allowed")]
    public TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueryBlockMetricStatBlock>? MetricStat
    {
        get => GetArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueryBlockMetricStatBlock>>("metric_stat");
        set => SetArgument("metric_stat", value);
    }

}

/// <summary>
/// Block type for metric_stat in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueryBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueryBlockMetricStatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_stat";

    /// <summary>
    /// The stat attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stat is required")]
    public required TerraformValue<string> Stat
    {
        get => new TerraformReference<string>(this, "stat");
        set => SetArgument("stat", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// Metric block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metric is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Metric block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metric block(s) allowed")]
    public required TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlock> Metric
    {
        get => GetRequiredArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlock>>("metric");
        set => SetArgument("metric", value);
    }

}

/// <summary>
/// Block type for metric in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueryBlockMetricStatBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric";

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    public TerraformValue<string>? MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformSet<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

}

/// <summary>
/// Block type for dimension in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueryBlockMetricStatBlockMetricBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

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
/// Block type for predefined_load_metric_specification in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockPredefinedLoadMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predefined_load_metric_specification";

    /// <summary>
    /// The predefined_metric_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PredefinedMetricType is required")]
    public required TerraformValue<string> PredefinedMetricType
    {
        get => new TerraformReference<string>(this, "predefined_metric_type");
        set => SetArgument("predefined_metric_type", value);
    }

    /// <summary>
    /// The resource_label attribute.
    /// </summary>
    public TerraformValue<string>? ResourceLabel
    {
        get => new TerraformReference<string>(this, "resource_label");
        set => SetArgument("resource_label", value);
    }

}

/// <summary>
/// Block type for predefined_metric_pair_specification in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockPredefinedMetricPairSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predefined_metric_pair_specification";

    /// <summary>
    /// The predefined_metric_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PredefinedMetricType is required")]
    public required TerraformValue<string> PredefinedMetricType
    {
        get => new TerraformReference<string>(this, "predefined_metric_type");
        set => SetArgument("predefined_metric_type", value);
    }

    /// <summary>
    /// The resource_label attribute.
    /// </summary>
    public TerraformValue<string>? ResourceLabel
    {
        get => new TerraformReference<string>(this, "resource_label");
        set => SetArgument("resource_label", value);
    }

}

/// <summary>
/// Block type for predefined_scaling_metric_specification in AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlockMetricSpecificationBlockPredefinedScalingMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predefined_scaling_metric_specification";

    /// <summary>
    /// The predefined_metric_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PredefinedMetricType is required")]
    public required TerraformValue<string> PredefinedMetricType
    {
        get => new TerraformReference<string>(this, "predefined_metric_type");
        set => SetArgument("predefined_metric_type", value);
    }

    /// <summary>
    /// The resource_label attribute.
    /// </summary>
    public TerraformValue<string>? ResourceLabel
    {
        get => new TerraformReference<string>(this, "resource_label");
        set => SetArgument("resource_label", value);
    }

}


/// <summary>
/// Block type for step_scaling_policy_configuration in AwsAppautoscalingPolicy.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyStepScalingPolicyConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "step_scaling_policy_configuration";

    /// <summary>
    /// The adjustment_type attribute.
    /// </summary>
    public TerraformValue<string>? AdjustmentType
    {
        get => new TerraformReference<string>(this, "adjustment_type");
        set => SetArgument("adjustment_type", value);
    }

    /// <summary>
    /// The cooldown attribute.
    /// </summary>
    public TerraformValue<double>? Cooldown
    {
        get => new TerraformReference<double>(this, "cooldown");
        set => SetArgument("cooldown", value);
    }

    /// <summary>
    /// The metric_aggregation_type attribute.
    /// </summary>
    public TerraformValue<string>? MetricAggregationType
    {
        get => new TerraformReference<string>(this, "metric_aggregation_type");
        set => SetArgument("metric_aggregation_type", value);
    }

    /// <summary>
    /// The min_adjustment_magnitude attribute.
    /// </summary>
    public TerraformValue<double>? MinAdjustmentMagnitude
    {
        get => new TerraformReference<double>(this, "min_adjustment_magnitude");
        set => SetArgument("min_adjustment_magnitude", value);
    }

    /// <summary>
    /// StepAdjustment block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAppautoscalingPolicyStepScalingPolicyConfigurationBlockStepAdjustmentBlock>? StepAdjustment
    {
        get => GetArgument<TerraformSet<AwsAppautoscalingPolicyStepScalingPolicyConfigurationBlockStepAdjustmentBlock>>("step_adjustment");
        set => SetArgument("step_adjustment", value);
    }

}

/// <summary>
/// Block type for step_adjustment in AwsAppautoscalingPolicyStepScalingPolicyConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppautoscalingPolicyStepScalingPolicyConfigurationBlockStepAdjustmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "step_adjustment";

    /// <summary>
    /// The metric_interval_lower_bound attribute.
    /// </summary>
    public TerraformValue<string>? MetricIntervalLowerBound
    {
        get => new TerraformReference<string>(this, "metric_interval_lower_bound");
        set => SetArgument("metric_interval_lower_bound", value);
    }

    /// <summary>
    /// The metric_interval_upper_bound attribute.
    /// </summary>
    public TerraformValue<string>? MetricIntervalUpperBound
    {
        get => new TerraformReference<string>(this, "metric_interval_upper_bound");
        set => SetArgument("metric_interval_upper_bound", value);
    }

    /// <summary>
    /// The scaling_adjustment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingAdjustment is required")]
    public required TerraformValue<double> ScalingAdjustment
    {
        get => new TerraformReference<double>(this, "scaling_adjustment");
        set => SetArgument("scaling_adjustment", value);
    }

}


/// <summary>
/// Block type for target_tracking_scaling_policy_configuration in AwsAppautoscalingPolicy.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_tracking_scaling_policy_configuration";

    /// <summary>
    /// The disable_scale_in attribute.
    /// </summary>
    public TerraformValue<bool>? DisableScaleIn
    {
        get => new TerraformReference<bool>(this, "disable_scale_in");
        set => SetArgument("disable_scale_in", value);
    }

    /// <summary>
    /// The scale_in_cooldown attribute.
    /// </summary>
    public TerraformValue<double>? ScaleInCooldown
    {
        get => new TerraformReference<double>(this, "scale_in_cooldown");
        set => SetArgument("scale_in_cooldown", value);
    }

    /// <summary>
    /// The scale_out_cooldown attribute.
    /// </summary>
    public TerraformValue<double>? ScaleOutCooldown
    {
        get => new TerraformReference<double>(this, "scale_out_cooldown");
        set => SetArgument("scale_out_cooldown", value);
    }

    /// <summary>
    /// The target_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetValue is required")]
    public required TerraformValue<double> TargetValue
    {
        get => new TerraformReference<double>(this, "target_value");
        set => SetArgument("target_value", value);
    }

    /// <summary>
    /// CustomizedMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomizedMetricSpecification block(s) allowed")]
    public TerraformList<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlock>? CustomizedMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlock>>("customized_metric_specification");
        set => SetArgument("customized_metric_specification", value);
    }

    /// <summary>
    /// PredefinedMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredefinedMetricSpecification block(s) allowed")]
    public TerraformList<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockPredefinedMetricSpecificationBlock>? PredefinedMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockPredefinedMetricSpecificationBlock>>("predefined_metric_specification");
        set => SetArgument("predefined_metric_specification", value);
    }

}

/// <summary>
/// Block type for customized_metric_specification in AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customized_metric_specification";

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    public TerraformValue<string>? MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The statistic attribute.
    /// </summary>
    public TerraformValue<string>? Statistic
    {
        get => new TerraformReference<string>(this, "statistic");
        set => SetArgument("statistic", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// Dimensions block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockDimensionsBlock>? Dimensions
    {
        get => GetArgument<TerraformSet<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockDimensionsBlock>>("dimensions");
        set => SetArgument("dimensions", value);
    }

    /// <summary>
    /// Metrics block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlock>? Metrics
    {
        get => GetArgument<TerraformSet<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlock>>("metrics");
        set => SetArgument("metrics", value);
    }

}

/// <summary>
/// Block type for dimensions in AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockDimensionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimensions";

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
/// Block type for metrics in AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metrics";

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The return_data attribute.
    /// </summary>
    public TerraformValue<bool>? ReturnData
    {
        get => new TerraformReference<bool>(this, "return_data");
        set => SetArgument("return_data", value);
    }

    /// <summary>
    /// MetricStat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricStat block(s) allowed")]
    public TerraformList<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlock>? MetricStat
    {
        get => GetArgument<TerraformList<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlock>>("metric_stat");
        set => SetArgument("metric_stat", value);
    }

}

/// <summary>
/// Block type for metric_stat in AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_stat";

    /// <summary>
    /// The stat attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stat is required")]
    public required TerraformValue<string> Stat
    {
        get => new TerraformReference<string>(this, "stat");
        set => SetArgument("stat", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// Metric block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metric is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Metric block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metric block(s) allowed")]
    public required TerraformList<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlockMetricBlock> Metric
    {
        get => GetRequiredArgument<TerraformList<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlockMetricBlock>>("metric");
        set => SetArgument("metric", value);
    }

}

/// <summary>
/// Block type for metric in AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlockMetricBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric";

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// Dimensions block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlockMetricBlockDimensionsBlock>? Dimensions
    {
        get => GetArgument<TerraformSet<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlockMetricBlockDimensionsBlock>>("dimensions");
        set => SetArgument("dimensions", value);
    }

}

/// <summary>
/// Block type for dimensions in AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlockMetricBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlockMetricBlockDimensionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimensions";

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
/// Block type for predefined_metric_specification in AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlockPredefinedMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predefined_metric_specification";

    /// <summary>
    /// The predefined_metric_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PredefinedMetricType is required")]
    public required TerraformValue<string> PredefinedMetricType
    {
        get => new TerraformReference<string>(this, "predefined_metric_type");
        set => SetArgument("predefined_metric_type", value);
    }

    /// <summary>
    /// The resource_label attribute.
    /// </summary>
    public TerraformValue<string>? ResourceLabel
    {
        get => new TerraformReference<string>(this, "resource_label");
        set => SetArgument("resource_label", value);
    }

}


/// <summary>
/// Represents a aws_appautoscaling_policy Terraform resource.
/// Manages a aws_appautoscaling_policy resource.
/// </summary>
public partial class AwsAppautoscalingPolicy(string name) : TerraformResource("aws_appautoscaling_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

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
    /// The policy_type attribute.
    /// </summary>
    public TerraformValue<string>? PolicyType
    {
        get => new TerraformReference<string>(this, "policy_type");
        set => SetArgument("policy_type", value);
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
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    public required TerraformValue<string> ScalableDimension
    {
        get => new TerraformReference<string>(this, "scalable_dimension");
        set => SetArgument("scalable_dimension", value);
    }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    public required TerraformValue<string> ServiceNamespace
    {
        get => new TerraformReference<string>(this, "service_namespace");
        set => SetArgument("service_namespace", value);
    }

    /// <summary>
    /// The alarm_arns attribute.
    /// </summary>
    public TerraformList<string> AlarmArns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "alarm_arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// PredictiveScalingPolicyConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredictiveScalingPolicyConfiguration block(s) allowed")]
    public TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlock>? PredictiveScalingPolicyConfiguration
    {
        get => GetArgument<TerraformList<AwsAppautoscalingPolicyPredictiveScalingPolicyConfigurationBlock>>("predictive_scaling_policy_configuration");
        set => SetArgument("predictive_scaling_policy_configuration", value);
    }

    /// <summary>
    /// StepScalingPolicyConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StepScalingPolicyConfiguration block(s) allowed")]
    public TerraformList<AwsAppautoscalingPolicyStepScalingPolicyConfigurationBlock>? StepScalingPolicyConfiguration
    {
        get => GetArgument<TerraformList<AwsAppautoscalingPolicyStepScalingPolicyConfigurationBlock>>("step_scaling_policy_configuration");
        set => SetArgument("step_scaling_policy_configuration", value);
    }

    /// <summary>
    /// TargetTrackingScalingPolicyConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTrackingScalingPolicyConfiguration block(s) allowed")]
    public TerraformList<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlock>? TargetTrackingScalingPolicyConfiguration
    {
        get => GetArgument<TerraformList<AwsAppautoscalingPolicyTargetTrackingScalingPolicyConfigurationBlock>>("target_tracking_scaling_policy_configuration");
        set => SetArgument("target_tracking_scaling_policy_configuration", value);
    }

}
