using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudfront_log_delivery_canonical_user_id Terraform data source.
/// Retrieves information about a aws_cloudfront_log_delivery_canonical_user_id.
/// </summary>
public partial class AwsCloudfrontLogDeliveryCanonicalUserIdDataSource(string name) : TerraformDataSource("aws_cloudfront_log_delivery_canonical_user_id", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}
