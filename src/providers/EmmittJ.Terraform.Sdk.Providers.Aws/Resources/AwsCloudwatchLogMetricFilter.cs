using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for metric_transformation in AwsCloudwatchLogMetricFilter.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogMetricFilterMetricTransformationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_transformation";

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformValue<string>? DefaultValue
    {
        get => GetArgument<TerraformValue<string>>("default_value");
        set => SetArgument("default_value", value);
    }

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public TerraformMap<string>? Dimensions
    {
        get => GetArgument<TerraformMap<string>>("dimensions");
        set => SetArgument("dimensions", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_cloudwatch_log_metric_filter Terraform resource.
/// Manages a aws_cloudwatch_log_metric_filter resource.
/// </summary>
public partial class AwsCloudwatchLogMetricFilter(string name) : TerraformResource("aws_cloudwatch_log_metric_filter", name)
{
    /// <summary>
    /// The apply_on_transformed_logs attribute.
    /// </summary>
    public TerraformValue<bool>? ApplyOnTransformedLogs
    {
        get => GetArgument<TerraformValue<bool>>("apply_on_transformed_logs");
        set => SetArgument("apply_on_transformed_logs", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    public required TerraformValue<string> LogGroupName
    {
        get => GetArgument<TerraformValue<string>>("log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => GetArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// MetricTransformation block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricTransformation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetricTransformation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricTransformation block(s) allowed")]
    public required TerraformList<AwsCloudwatchLogMetricFilterMetricTransformationBlock> MetricTransformation
    {
        get => GetRequiredArgument<TerraformList<AwsCloudwatchLogMetricFilterMetricTransformationBlock>>("metric_transformation");
        set => SetArgument("metric_transformation", value);
    }

}
