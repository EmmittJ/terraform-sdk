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
    public string? DistributionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("distribution_id")?.Value;
        set => this.WithProperty("distribution_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
