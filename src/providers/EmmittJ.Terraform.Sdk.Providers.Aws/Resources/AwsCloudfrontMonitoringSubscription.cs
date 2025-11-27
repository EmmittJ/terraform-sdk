using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for monitoring_subscription in AwsCloudfrontMonitoringSubscription.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontMonitoringSubscriptionMonitoringSubscriptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitoring_subscription";

    /// <summary>
    /// RealtimeMetricsSubscriptionConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RealtimeMetricsSubscriptionConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RealtimeMetricsSubscriptionConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RealtimeMetricsSubscriptionConfig block(s) allowed")]
    public required TerraformList<AwsCloudfrontMonitoringSubscriptionMonitoringSubscriptionBlockRealtimeMetricsSubscriptionConfigBlock> RealtimeMetricsSubscriptionConfig
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontMonitoringSubscriptionMonitoringSubscriptionBlockRealtimeMetricsSubscriptionConfigBlock>>("realtime_metrics_subscription_config");
        set => SetArgument("realtime_metrics_subscription_config", value);
    }

}

/// <summary>
/// Block type for realtime_metrics_subscription_config in AwsCloudfrontMonitoringSubscriptionMonitoringSubscriptionBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontMonitoringSubscriptionMonitoringSubscriptionBlockRealtimeMetricsSubscriptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "realtime_metrics_subscription_config";

    /// <summary>
    /// The realtime_metrics_subscription_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RealtimeMetricsSubscriptionStatus is required")]
    public required TerraformValue<string> RealtimeMetricsSubscriptionStatus
    {
        get => new TerraformReference<string>(this, "realtime_metrics_subscription_status");
        set => SetArgument("realtime_metrics_subscription_status", value);
    }

}


/// <summary>
/// Represents a aws_cloudfront_monitoring_subscription Terraform resource.
/// Manages a aws_cloudfront_monitoring_subscription resource.
/// </summary>
public partial class AwsCloudfrontMonitoringSubscription(string name) : TerraformResource("aws_cloudfront_monitoring_subscription", name)
{
    /// <summary>
    /// The distribution_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DistributionId is required")]
    public required TerraformValue<string> DistributionId
    {
        get => new TerraformReference<string>(this, "distribution_id");
        set => SetArgument("distribution_id", value);
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
    /// MonitoringSubscription block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitoringSubscription is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MonitoringSubscription block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringSubscription block(s) allowed")]
    public required TerraformList<AwsCloudfrontMonitoringSubscriptionMonitoringSubscriptionBlock> MonitoringSubscription
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontMonitoringSubscriptionMonitoringSubscriptionBlock>>("monitoring_subscription");
        set => SetArgument("monitoring_subscription", value);
    }

}
