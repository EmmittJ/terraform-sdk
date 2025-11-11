using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_log_delivery_canonical_user_id.
/// </summary>
public class AwsCloudfrontLogDeliveryCanonicalUserIdDataSource : TerraformDataSource
{
    public AwsCloudfrontLogDeliveryCanonicalUserIdDataSource(string name) : base("aws_cloudfront_log_delivery_canonical_user_id", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Region { get; set; }

}
