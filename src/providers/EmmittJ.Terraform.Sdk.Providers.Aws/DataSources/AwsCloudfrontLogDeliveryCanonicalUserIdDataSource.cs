using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_log_delivery_canonical_user_id.
/// </summary>
public partial class AwsCloudfrontLogDeliveryCanonicalUserIdDataSource : TerraformDataSource
{
    public AwsCloudfrontLogDeliveryCanonicalUserIdDataSource(string name) : base("aws_cloudfront_log_delivery_canonical_user_id", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

}
