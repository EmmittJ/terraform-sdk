using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for metric_transformation in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchLogMetricFilterMetricTransformationBlock() : TerraformBlock("metric_transformation")
{
    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [TerraformProperty("default_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultValue { get; set; }

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    [TerraformProperty("dimensions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Dimensions { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformProperty("namespace")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Namespace { get; set; }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [TerraformProperty("unit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Unit { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Manages a aws_cloudwatch_log_metric_filter resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudwatchLogMetricFilter : TerraformResource
{
    public AwsCloudwatchLogMetricFilter(string name) : base("aws_cloudwatch_log_metric_filter", name)
    {
    }

    /// <summary>
    /// The apply_on_transformed_logs attribute.
    /// </summary>
    [TerraformProperty("apply_on_transformed_logs")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ApplyOnTransformedLogs { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    [TerraformProperty("log_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogGroupName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    [TerraformProperty("pattern")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Pattern { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for metric_transformation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricTransformation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetricTransformation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricTransformation block(s) allowed")]
    [TerraformProperty("metric_transformation")]
    public required TerraformList<AwsCloudwatchLogMetricFilterMetricTransformationBlock> MetricTransformation { get; set; } = new();

}
