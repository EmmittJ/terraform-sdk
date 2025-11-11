using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_spot_datafeed_subscription.
/// </summary>
public class AwsSpotDatafeedSubscriptionDataSource : TerraformDataSource
{
    public AwsSpotDatafeedSubscriptionDataSource(string name) : base("aws_spot_datafeed_subscription", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [TerraformPropertyName("bucket")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Bucket => new TerraformReference(this, "bucket");

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformPropertyName("prefix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Prefix => new TerraformReference(this, "prefix");

}
