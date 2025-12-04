using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_spot_datafeed_subscription Terraform data source.
/// Retrieves information about a aws_spot_datafeed_subscription.
/// </summary>
public partial class AwsSpotDatafeedSubscriptionDataSource(string name) : TerraformDataSource("aws_spot_datafeed_subscription", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformValue<string> Bucket
        => AsReference("bucket");

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string> Prefix
        => AsReference("prefix");

}
