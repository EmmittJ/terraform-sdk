using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_origin_access_identity.
/// </summary>
public class AwsCloudfrontOriginAccessIdentityDataSource : TerraformDataSource
{
    public AwsCloudfrontOriginAccessIdentityDataSource(string name) : base("aws_cloudfront_origin_access_identity", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

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
    /// The comment attribute.
    /// </summary>
    [TerraformPropertyName("comment")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Comment => new TerraformReference(this, "comment");

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
