using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_network_performance_metric_subscription resource.
/// </summary>
public class AwsVpcNetworkPerformanceMetricSubscription : TerraformResource
{
    public AwsVpcNetworkPerformanceMetricSubscription(string name) : base("aws_vpc_network_performance_metric_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("period");
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformProperty<string> Destination
    {
        get => GetRequiredProperty<TerraformProperty<string>>("destination");
        set => this.WithProperty("destination", value);
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
    /// The metric attribute.
    /// </summary>
    public TerraformProperty<string>? Metric
    {
        get => GetProperty<TerraformProperty<string>>("metric");
        set => this.WithProperty("metric", value);
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
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The statistic attribute.
    /// </summary>
    public TerraformProperty<string>? Statistic
    {
        get => GetProperty<TerraformProperty<string>>("statistic");
        set => this.WithProperty("statistic", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformExpression Period => this["period"];

}
