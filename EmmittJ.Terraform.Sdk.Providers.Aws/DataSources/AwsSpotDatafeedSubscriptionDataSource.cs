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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
