using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for metric_transformation in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogMetricFilterMetricTransformationBlock : TerraformBlock
{
    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultValue
    {
        set => SetProperty("default_value", value);
    }

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Dimensions
    {
        set => SetProperty("dimensions", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    public required TerraformProperty<string> Namespace
    {
        set => SetProperty("namespace", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformProperty<string>? Unit
    {
        set => SetProperty("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Manages a aws_cloudwatch_log_metric_filter resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudwatchLogMetricFilter : TerraformResource
{
    public AwsCloudwatchLogMetricFilter(string name) : base("aws_cloudwatch_log_metric_filter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("apply_on_transformed_logs");
        SetOutput("id");
        SetOutput("log_group_name");
        SetOutput("name");
        SetOutput("pattern");
        SetOutput("region");
    }

    /// <summary>
    /// The apply_on_transformed_logs attribute.
    /// </summary>
    public TerraformProperty<bool> ApplyOnTransformedLogs
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("apply_on_transformed_logs");
        set => SetProperty("apply_on_transformed_logs", value);
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
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    public required TerraformProperty<string> LogGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_group_name");
        set => SetProperty("log_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformProperty<string> Pattern
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pattern");
        set => SetProperty("pattern", value);
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
    /// Block for metric_transformation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricTransformation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetricTransformation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricTransformation block(s) allowed")]
    public List<AwsCloudwatchLogMetricFilterMetricTransformationBlock>? MetricTransformation
    {
        set => SetProperty("metric_transformation", value);
    }

}
