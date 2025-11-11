using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for monitoring_subscription in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontMonitoringSubscriptionMonitoringSubscriptionBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_cloudfront_monitoring_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudfrontMonitoringSubscription : TerraformResource
{
    public AwsCloudfrontMonitoringSubscription(string name) : base("aws_cloudfront_monitoring_subscription", name)
    {
    }

    /// <summary>
    /// The distribution_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DistributionId is required")]
    [TerraformProperty("distribution_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DistributionId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for monitoring_subscription.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitoringSubscription is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MonitoringSubscription block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringSubscription block(s) allowed")]
    [TerraformProperty("monitoring_subscription")]
    public partial TerraformList<TerraformBlock<AwsCloudfrontMonitoringSubscriptionMonitoringSubscriptionBlock>>? MonitoringSubscription { get; set; }

}
