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
        get => GetProperty<TerraformProperty<string>>("default_value");
        set => WithProperty("default_value", value);
    }

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Dimensions
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("dimensions");
        set => WithProperty("dimensions", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    public required TerraformProperty<string> Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => WithProperty("namespace", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformProperty<string>? Unit
    {
        get => GetProperty<TerraformProperty<string>>("unit");
        set => WithProperty("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
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
    }

    /// <summary>
    /// The apply_on_transformed_logs attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplyOnTransformedLogs
    {
        get => GetProperty<TerraformProperty<bool>>("apply_on_transformed_logs");
        set => this.WithProperty("apply_on_transformed_logs", value);
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
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    public required TerraformProperty<string> LogGroupName
    {
        get => GetProperty<TerraformProperty<string>>("log_group_name");
        set => this.WithProperty("log_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformProperty<string> Pattern
    {
        get => GetProperty<TerraformProperty<string>>("pattern");
        set => this.WithProperty("pattern", value);
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
    /// Block for metric_transformation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetricTransformation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricTransformation block(s) allowed")]
    public List<AwsCloudwatchLogMetricFilterMetricTransformationBlock>? MetricTransformation
    {
        get => GetProperty<List<AwsCloudwatchLogMetricFilterMetricTransformationBlock>>("metric_transformation");
        set => this.WithProperty("metric_transformation", value);
    }

}
