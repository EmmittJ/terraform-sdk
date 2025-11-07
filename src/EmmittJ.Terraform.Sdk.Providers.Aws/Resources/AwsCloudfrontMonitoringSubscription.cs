using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public TerraformProperty<string>? DistributionId
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

}
