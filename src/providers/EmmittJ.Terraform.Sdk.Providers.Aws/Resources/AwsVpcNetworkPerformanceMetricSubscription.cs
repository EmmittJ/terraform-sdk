using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_network_performance_metric_subscription resource.
/// </summary>
public partial class AwsVpcNetworkPerformanceMetricSubscription : TerraformResource
{
    public AwsVpcNetworkPerformanceMetricSubscription(string name) : base("aws_vpc_network_performance_metric_subscription", name)
    {
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [TerraformProperty("destination")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Destination { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The metric attribute.
    /// </summary>
    [TerraformProperty("metric")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Metric { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The statistic attribute.
    /// </summary>
    [TerraformProperty("statistic")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Statistic { get; set; }

    /// <summary>
    /// The period attribute.
    /// </summary>
    [TerraformProperty("period")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Period { get; }

}
