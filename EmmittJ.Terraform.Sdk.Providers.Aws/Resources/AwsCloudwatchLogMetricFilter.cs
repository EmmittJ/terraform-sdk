using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_metric_filter resource.
/// </summary>
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public string? LogGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_group_name")?.Value;
        set => this.WithProperty("log_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    public string? Pattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pattern")?.Value;
        set => this.WithProperty("pattern", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
