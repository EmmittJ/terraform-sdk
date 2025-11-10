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
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudfrontMonitoringSubscription : TerraformResource
{
    public AwsCloudfrontMonitoringSubscription(string name) : base("aws_cloudfront_monitoring_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("distribution_id");
        SetOutput("id");
    }

    /// <summary>
    /// The distribution_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DistributionId is required")]
    public required TerraformProperty<string> DistributionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("distribution_id");
        set => SetProperty("distribution_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Block for monitoring_subscription.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitoringSubscription is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MonitoringSubscription block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringSubscription block(s) allowed")]
    public List<AwsCloudfrontMonitoringSubscriptionMonitoringSubscriptionBlock>? MonitoringSubscription
    {
        set => SetProperty("monitoring_subscription", value);
    }

}
