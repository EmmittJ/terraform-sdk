using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_spot_datafeed_subscription.
/// </summary>
public class AwsSpotDatafeedSubscriptionDataSource : TerraformDataSource
{
    public AwsSpotDatafeedSubscriptionDataSource(string name) : base("aws_spot_datafeed_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("bucket");
        this.DeclareOutput("prefix");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformExpression Bucket => this["bucket"];

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformExpression Prefix => this["prefix"];

}
