using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for predictive_scaling_configuration in AwsAutoscalingPolicy.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predictive_scaling_configuration";

    /// <summary>
    /// The max_capacity_breach_behavior attribute.
    /// </summary>
    public TerraformValue<string>? MaxCapacityBreachBehavior
    {
        get => GetArgument<TerraformValue<string>>("max_capacity_breach_behavior");
        set => SetArgument("max_capacity_breach_behavior", value);
    }

    /// <summary>
    /// The max_capacity_buffer attribute.
    /// </summary>
    public TerraformValue<string>? MaxCapacityBuffer
    {
        get => GetArgument<TerraformValue<string>>("max_capacity_buffer");
        set => SetArgument("max_capacity_buffer", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The scheduling_buffer_time attribute.
    /// </summary>
    public TerraformValue<string>? SchedulingBufferTime
    {
        get => GetArgument<TerraformValue<string>>("scheduling_buffer_time");
        set => SetArgument("scheduling_buffer_time", value);
    }

    /// <summary>
    /// MetricSpecification block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricSpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetricSpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricSpecification block(s) allowed")]
    public required TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlock> MetricSpecification
    {
        get => GetRequiredArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlock>>("metric_specification");
        set => SetArgument("metric_specification", value);
    }

}

/// <summary>
/// Block type for metric_specification in AwsAutoscalingPolicyPredictiveScalingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_specification";

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
    /// CustomizedCapacityMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomizedCapacityMetricSpecification block(s) allowed")]
    public TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlock>? CustomizedCapacityMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlock>>("customized_capacity_metric_specification");
        set => SetArgument("customized_capacity_metric_specification", value);
    }

    /// <summary>
    /// CustomizedLoadMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomizedLoadMetricSpecification block(s) allowed")]
    public TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlock>? CustomizedLoadMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlock>>("customized_load_metric_specification");
        set => SetArgument("customized_load_metric_specification", value);
    }

    /// <summary>
    /// CustomizedScalingMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomizedScalingMetricSpecification block(s) allowed")]
    public TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlock>? CustomizedScalingMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlock>>("customized_scaling_metric_specification");
        set => SetArgument("customized_scaling_metric_specification", value);
    }

    /// <summary>
    /// PredefinedLoadMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredefinedLoadMetricSpecification block(s) allowed")]
    public TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockPredefinedLoadMetricSpecificationBlock>? PredefinedLoadMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockPredefinedLoadMetricSpecificationBlock>>("predefined_load_metric_specification");
        set => SetArgument("predefined_load_metric_specification", value);
    }

    /// <summary>
    /// PredefinedMetricPairSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredefinedMetricPairSpecification block(s) allowed")]
    public TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockPredefinedMetricPairSpecificationBlock>? PredefinedMetricPairSpecification
    {
        get => GetArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockPredefinedMetricPairSpecificationBlock>>("predefined_metric_pair_specification");
        set => SetArgument("predefined_metric_pair_specification", value);
    }

    /// <summary>
    /// PredefinedScalingMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredefinedScalingMetricSpecification block(s) allowed")]
    public TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockPredefinedScalingMetricSpecificationBlock>? PredefinedScalingMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockPredefinedScalingMetricSpecificationBlock>>("predefined_scaling_metric_specification");
        set => SetArgument("predefined_scaling_metric_specification", value);
    }

}

/// <summary>
/// Block type for customized_capacity_metric_specification in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customized_capacity_metric_specification";

    /// <summary>
    /// MetricDataQueries block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricDataQueries is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetricDataQueries block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 MetricDataQueries block(s) allowed")]
    public required TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueriesBlock> MetricDataQueries
    {
        get => GetRequiredArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueriesBlock>>("metric_data_queries");
        set => SetArgument("metric_data_queries", value);
    }

}

/// <summary>
/// Block type for metric_data_queries in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueriesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_data_queries";

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => GetArgument<TerraformValue<string>>("label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The return_data attribute.
    /// </summary>
    public TerraformValue<bool>? ReturnData
    {
        get => GetArgument<TerraformValue<bool>>("return_data");
        set => SetArgument("return_data", value);
    }

    /// <summary>
    /// MetricStat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricStat block(s) allowed")]
    public TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlock>? MetricStat
    {
        get => GetArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlock>>("metric_stat");
        set => SetArgument("metric_stat", value);
    }

}

/// <summary>
/// Block type for metric_stat in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueriesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("stat");
        set => SetArgument("stat", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => GetArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// Metric block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metric is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Metric block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metric block(s) allowed")]
    public required TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlock> Metric
    {
        get => GetRequiredArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlock>>("metric");
        set => SetArgument("metric", value);
    }

}

/// <summary>
/// Block type for metric in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlock : TerraformBlock
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
    /// Dimensions block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlockDimensionsBlock>? Dimensions
    {
        get => GetArgument<TerraformSet<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlockDimensionsBlock>>("dimensions");
        set => SetArgument("dimensions", value);
    }

}

/// <summary>
/// Block type for dimensions in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlock.
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedCapacityMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlockDimensionsBlock : TerraformBlock
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
/// Block type for customized_load_metric_specification in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customized_load_metric_specification";

    /// <summary>
    /// MetricDataQueries block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricDataQueries is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetricDataQueries block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 MetricDataQueries block(s) allowed")]
    public required TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueriesBlock> MetricDataQueries
    {
        get => GetRequiredArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueriesBlock>>("metric_data_queries");
        set => SetArgument("metric_data_queries", value);
    }

}

/// <summary>
/// Block type for metric_data_queries in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueriesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_data_queries";

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => GetArgument<TerraformValue<string>>("label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The return_data attribute.
    /// </summary>
    public TerraformValue<bool>? ReturnData
    {
        get => GetArgument<TerraformValue<bool>>("return_data");
        set => SetArgument("return_data", value);
    }

    /// <summary>
    /// MetricStat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricStat block(s) allowed")]
    public TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlock>? MetricStat
    {
        get => GetArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlock>>("metric_stat");
        set => SetArgument("metric_stat", value);
    }

}

/// <summary>
/// Block type for metric_stat in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueriesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("stat");
        set => SetArgument("stat", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => GetArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// Metric block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metric is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Metric block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metric block(s) allowed")]
    public required TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlock> Metric
    {
        get => GetRequiredArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlock>>("metric");
        set => SetArgument("metric", value);
    }

}

/// <summary>
/// Block type for metric in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlock : TerraformBlock
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
    /// Dimensions block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlockDimensionsBlock>? Dimensions
    {
        get => GetArgument<TerraformSet<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlockDimensionsBlock>>("dimensions");
        set => SetArgument("dimensions", value);
    }

}

/// <summary>
/// Block type for dimensions in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlock.
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedLoadMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlockDimensionsBlock : TerraformBlock
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
/// Block type for customized_scaling_metric_specification in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customized_scaling_metric_specification";

    /// <summary>
    /// MetricDataQueries block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricDataQueries is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetricDataQueries block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 MetricDataQueries block(s) allowed")]
    public required TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueriesBlock> MetricDataQueries
    {
        get => GetRequiredArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueriesBlock>>("metric_data_queries");
        set => SetArgument("metric_data_queries", value);
    }

}

/// <summary>
/// Block type for metric_data_queries in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueriesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_data_queries";

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => GetArgument<TerraformValue<string>>("label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The return_data attribute.
    /// </summary>
    public TerraformValue<bool>? ReturnData
    {
        get => GetArgument<TerraformValue<bool>>("return_data");
        set => SetArgument("return_data", value);
    }

    /// <summary>
    /// MetricStat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricStat block(s) allowed")]
    public TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlock>? MetricStat
    {
        get => GetArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlock>>("metric_stat");
        set => SetArgument("metric_stat", value);
    }

}

/// <summary>
/// Block type for metric_stat in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueriesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("stat");
        set => SetArgument("stat", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => GetArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// Metric block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metric is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Metric block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metric block(s) allowed")]
    public required TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlock> Metric
    {
        get => GetRequiredArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlock>>("metric");
        set => SetArgument("metric", value);
    }

}

/// <summary>
/// Block type for metric in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlock : TerraformBlock
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
    /// Dimensions block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlockDimensionsBlock>? Dimensions
    {
        get => GetArgument<TerraformSet<AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlockDimensionsBlock>>("dimensions");
        set => SetArgument("dimensions", value);
    }

}

/// <summary>
/// Block type for dimensions in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlock.
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockCustomizedScalingMetricSpecificationBlockMetricDataQueriesBlockMetricStatBlockMetricBlockDimensionsBlock : TerraformBlock
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
/// Block type for predefined_load_metric_specification in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockPredefinedLoadMetricSpecificationBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("predefined_metric_type");
        set => SetArgument("predefined_metric_type", value);
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
/// Block type for predefined_metric_pair_specification in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockPredefinedMetricPairSpecificationBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("predefined_metric_type");
        set => SetArgument("predefined_metric_type", value);
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
/// Block type for predefined_scaling_metric_specification in AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyPredictiveScalingConfigurationBlockMetricSpecificationBlockPredefinedScalingMetricSpecificationBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("predefined_metric_type");
        set => SetArgument("predefined_metric_type", value);
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
/// Block type for step_adjustment in AwsAutoscalingPolicy.
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingPolicyStepAdjustmentBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("metric_interval_lower_bound");
        set => SetArgument("metric_interval_lower_bound", value);
    }

    /// <summary>
    /// The metric_interval_upper_bound attribute.
    /// </summary>
    public TerraformValue<string>? MetricIntervalUpperBound
    {
        get => GetArgument<TerraformValue<string>>("metric_interval_upper_bound");
        set => SetArgument("metric_interval_upper_bound", value);
    }

    /// <summary>
    /// The scaling_adjustment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingAdjustment is required")]
    public required TerraformValue<double> ScalingAdjustment
    {
        get => GetRequiredArgument<TerraformValue<double>>("scaling_adjustment");
        set => SetArgument("scaling_adjustment", value);
    }

}


/// <summary>
/// Block type for target_tracking_configuration in AwsAutoscalingPolicy.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyTargetTrackingConfigurationBlock : TerraformBlock
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
    /// The target_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetValue is required")]
    public required TerraformValue<double> TargetValue
    {
        get => GetRequiredArgument<TerraformValue<double>>("target_value");
        set => SetArgument("target_value", value);
    }

    /// <summary>
    /// CustomizedMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomizedMetricSpecification block(s) allowed")]
    public TerraformList<AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlock>? CustomizedMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlock>>("customized_metric_specification");
        set => SetArgument("customized_metric_specification", value);
    }

    /// <summary>
    /// PredefinedMetricSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredefinedMetricSpecification block(s) allowed")]
    public TerraformList<AwsAutoscalingPolicyTargetTrackingConfigurationBlockPredefinedMetricSpecificationBlock>? PredefinedMetricSpecification
    {
        get => GetArgument<TerraformList<AwsAutoscalingPolicyTargetTrackingConfigurationBlockPredefinedMetricSpecificationBlock>>("predefined_metric_specification");
        set => SetArgument("predefined_metric_specification", value);
    }

}

/// <summary>
/// Block type for customized_metric_specification in AwsAutoscalingPolicyTargetTrackingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformValue<double>? Period
    {
        get => GetArgument<TerraformValue<double>>("period");
        set => SetArgument("period", value);
    }

    /// <summary>
    /// The statistic attribute.
    /// </summary>
    public TerraformValue<string>? Statistic
    {
        get => GetArgument<TerraformValue<string>>("statistic");
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

    /// <summary>
    /// MetricDimension block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricDimensionBlock>? MetricDimension
    {
        get => GetArgument<TerraformList<AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricDimensionBlock>>("metric_dimension");
        set => SetArgument("metric_dimension", value);
    }

    /// <summary>
    /// Metrics block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlock>? Metrics
    {
        get => GetArgument<TerraformSet<AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlock>>("metrics");
        set => SetArgument("metrics", value);
    }

}

/// <summary>
/// Block type for metric_dimension in AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_dimension";

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
/// Block type for metrics in AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlock.
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => GetArgument<TerraformValue<string>>("label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The return_data attribute.
    /// </summary>
    public TerraformValue<bool>? ReturnData
    {
        get => GetArgument<TerraformValue<bool>>("return_data");
        set => SetArgument("return_data", value);
    }

    /// <summary>
    /// MetricStat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricStat block(s) allowed")]
    public TerraformList<AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlock>? MetricStat
    {
        get => GetArgument<TerraformList<AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlock>>("metric_stat");
        set => SetArgument("metric_stat", value);
    }

}

/// <summary>
/// Block type for metric_stat in AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_stat";

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformValue<double>? Period
    {
        get => GetArgument<TerraformValue<double>>("period");
        set => SetArgument("period", value);
    }

    /// <summary>
    /// The stat attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stat is required")]
    public required TerraformValue<string> Stat
    {
        get => GetRequiredArgument<TerraformValue<string>>("stat");
        set => SetArgument("stat", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => GetArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// Metric block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metric is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Metric block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metric block(s) allowed")]
    public required TerraformList<AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlockMetricBlock> Metric
    {
        get => GetRequiredArgument<TerraformList<AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlockMetricBlock>>("metric");
        set => SetArgument("metric", value);
    }

}

/// <summary>
/// Block type for metric in AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlockMetricBlock : TerraformBlock
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
    /// Dimensions block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlockMetricBlockDimensionsBlock>? Dimensions
    {
        get => GetArgument<TerraformSet<AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlockMetricBlockDimensionsBlock>>("dimensions");
        set => SetArgument("dimensions", value);
    }

}

/// <summary>
/// Block type for dimensions in AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlockMetricBlock.
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingPolicyTargetTrackingConfigurationBlockCustomizedMetricSpecificationBlockMetricsBlockMetricStatBlockMetricBlockDimensionsBlock : TerraformBlock
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
/// Block type for predefined_metric_specification in AwsAutoscalingPolicyTargetTrackingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingPolicyTargetTrackingConfigurationBlockPredefinedMetricSpecificationBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("predefined_metric_type");
        set => SetArgument("predefined_metric_type", value);
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
/// Represents a aws_autoscaling_policy Terraform resource.
/// Manages a aws_autoscaling_policy resource.
/// </summary>
public partial class AwsAutoscalingPolicy(string name) : TerraformResource("aws_autoscaling_policy", name)
{
    /// <summary>
    /// The adjustment_type attribute.
    /// </summary>
    public TerraformValue<string>? AdjustmentType
    {
        get => GetArgument<TerraformValue<string>>("adjustment_type");
        set => SetArgument("adjustment_type", value);
    }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    public required TerraformValue<string> AutoscalingGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("autoscaling_group_name");
        set => SetArgument("autoscaling_group_name", value);
    }

    /// <summary>
    /// The cooldown attribute.
    /// </summary>
    public TerraformValue<double>? Cooldown
    {
        get => GetArgument<TerraformValue<double>>("cooldown");
        set => SetArgument("cooldown", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The metric_aggregation_type attribute.
    /// </summary>
    public TerraformValue<string> MetricAggregationType
    {
        get => GetArgument<TerraformValue<string>>("metric_aggregation_type") ?? AsReference("metric_aggregation_type");
        set => SetArgument("metric_aggregation_type", value);
    }

    /// <summary>
    /// The min_adjustment_magnitude attribute.
    /// </summary>
    public TerraformValue<double>? MinAdjustmentMagnitude
    {
        get => GetArgument<TerraformValue<double>>("min_adjustment_magnitude");
        set => SetArgument("min_adjustment_magnitude", value);
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
    /// The policy_type attribute.
    /// </summary>
    public TerraformValue<string>? PolicyType
    {
        get => GetArgument<TerraformValue<string>>("policy_type");
        set => SetArgument("policy_type", value);
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
    /// The scaling_adjustment attribute.
    /// </summary>
    public TerraformValue<double>? ScalingAdjustment
    {
        get => GetArgument<TerraformValue<double>>("scaling_adjustment");
        set => SetArgument("scaling_adjustment", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// PredictiveScalingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredictiveScalingConfiguration block(s) allowed")]
    public TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlock>? PredictiveScalingConfiguration
    {
        get => GetArgument<TerraformList<AwsAutoscalingPolicyPredictiveScalingConfigurationBlock>>("predictive_scaling_configuration");
        set => SetArgument("predictive_scaling_configuration", value);
    }

    /// <summary>
    /// StepAdjustment block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAutoscalingPolicyStepAdjustmentBlock>? StepAdjustment
    {
        get => GetArgument<TerraformSet<AwsAutoscalingPolicyStepAdjustmentBlock>>("step_adjustment");
        set => SetArgument("step_adjustment", value);
    }

    /// <summary>
    /// TargetTrackingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTrackingConfiguration block(s) allowed")]
    public TerraformList<AwsAutoscalingPolicyTargetTrackingConfigurationBlock>? TargetTrackingConfiguration
    {
        get => GetArgument<TerraformList<AwsAutoscalingPolicyTargetTrackingConfigurationBlock>>("target_tracking_configuration");
        set => SetArgument("target_tracking_configuration", value);
    }

}
