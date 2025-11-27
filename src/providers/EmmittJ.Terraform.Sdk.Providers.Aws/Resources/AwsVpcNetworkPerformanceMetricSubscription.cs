using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpc_network_performance_metric_subscription Terraform resource.
/// Manages a aws_vpc_network_performance_metric_subscription resource.
/// </summary>
public partial class AwsVpcNetworkPerformanceMetricSubscription(string name) : TerraformResource("aws_vpc_network_performance_metric_subscription", name)
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformValue<string> Destination
    {
        get => new TerraformReference<string>(this, "destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The metric attribute.
    /// </summary>
    public TerraformValue<string>? Metric
    {
        get => new TerraformReference<string>(this, "metric");
        set => SetArgument("metric", value);
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
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => new TerraformReference<string>(this, "source");
        set => SetArgument("source", value);
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
    /// The period attribute.
    /// </summary>
    public TerraformValue<string> Period
    {
        get => new TerraformReference<string>(this, "period");
    }

}
