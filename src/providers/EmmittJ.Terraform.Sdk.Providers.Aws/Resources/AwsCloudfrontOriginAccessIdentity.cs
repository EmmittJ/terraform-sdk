using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfront_origin_access_identity resource.
/// </summary>
public class AwsCloudfrontOriginAccessIdentity : TerraformResource
{
    public AwsCloudfrontOriginAccessIdentity(string name) : base("aws_cloudfront_origin_access_identity", name)
    {
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformPropertyName("comment")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Comment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    [TerraformPropertyName("caller_reference")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CallerReference => new TerraformReference(this, "caller_reference");

    /// <summary>
    /// The cloudfront_access_identity_path attribute.
    /// </summary>
    [TerraformPropertyName("cloudfront_access_identity_path")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CloudfrontAccessIdentityPath => new TerraformReference(this, "cloudfront_access_identity_path");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// The iam_arn attribute.
    /// </summary>
    [TerraformPropertyName("iam_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IamArn => new TerraformReference(this, "iam_arn");

    /// <summary>
    /// The s3_canonical_user_id attribute.
    /// </summary>
    [TerraformPropertyName("s3_canonical_user_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> S3CanonicalUserId => new TerraformReference(this, "s3_canonical_user_id");

}
