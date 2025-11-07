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
    public TerraformProperty<string>? LogGroupName
    {
        get => GetProperty<TerraformProperty<string>>("log_group_name");
        set => this.WithProperty("log_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    public TerraformProperty<string>? Pattern
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

}
