using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_network_performance_metric_subscription resource.
/// </summary>
public class AwsVpcNetworkPerformanceMetricSubscription : TerraformResource
{
    public AwsVpcNetworkPerformanceMetricSubscription(string name) : base("aws_vpc_network_performance_metric_subscription", name)
    {
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [TerraformPropertyName("destination")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Destination { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The metric attribute.
    /// </summary>
    [TerraformPropertyName("metric")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Metric { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Source { get; set; }

    /// <summary>
    /// The statistic attribute.
    /// </summary>
    [TerraformPropertyName("statistic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Statistic { get; set; }

    /// <summary>
    /// The period attribute.
    /// </summary>
    [TerraformPropertyName("period")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Period => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "period");

}
