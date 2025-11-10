using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for monitoring_subscription in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontMonitoringSubscriptionMonitoringSubscriptionBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_cloudfront_monitoring_subscription resource.
/// </summary>
public class AwsCloudfrontMonitoringSubscription : TerraformResource
{
    public AwsCloudfrontMonitoringSubscription(string name) : base("aws_cloudfront_monitoring_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The distribution_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DistributionId is required")]
    public required TerraformProperty<string> DistributionId
    {
        get => GetProperty<TerraformProperty<string>>("distribution_id");
        set => this.WithProperty("distribution_id", value);
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
    /// Block for monitoring_subscription.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MonitoringSubscription block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringSubscription block(s) allowed")]
    public List<AwsCloudfrontMonitoringSubscriptionMonitoringSubscriptionBlock>? MonitoringSubscription
    {
        get => GetProperty<List<AwsCloudfrontMonitoringSubscriptionMonitoringSubscriptionBlock>>("monitoring_subscription");
        set => this.WithProperty("monitoring_subscription", value);
    }

}
