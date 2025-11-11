using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_origin_access_identities.
/// </summary>
public class AwsCloudfrontOriginAccessIdentitiesDataSource : TerraformDataSource
{
    public AwsCloudfrontOriginAccessIdentitiesDataSource(string name) : base("aws_cloudfront_origin_access_identities", name)
    {
    }

    /// <summary>
    /// The comments attribute.
    /// </summary>
    [TerraformPropertyName("comments")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Comments { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The iam_arns attribute.
    /// </summary>
    [TerraformPropertyName("iam_arns")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> IamArns => new TerraformReference(this, "iam_arns");

    /// <summary>
    /// The ids attribute.
    /// </summary>
    [TerraformPropertyName("ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Ids => new TerraformReference(this, "ids");

    /// <summary>
    /// The s3_canonical_user_ids attribute.
    /// </summary>
    [TerraformPropertyName("s3_canonical_user_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> S3CanonicalUserIds => new TerraformReference(this, "s3_canonical_user_ids");

}
