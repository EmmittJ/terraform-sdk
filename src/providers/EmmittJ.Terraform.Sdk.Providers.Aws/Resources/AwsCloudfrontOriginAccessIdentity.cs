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
    public TerraformProperty<TerraformProperty<string>>? Comment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    [TerraformPropertyName("caller_reference")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CallerReference => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "caller_reference");

    /// <summary>
    /// The cloudfront_access_identity_path attribute.
    /// </summary>
    [TerraformPropertyName("cloudfront_access_identity_path")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CloudfrontAccessIdentityPath => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cloudfront_access_identity_path");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// The iam_arn attribute.
    /// </summary>
    [TerraformPropertyName("iam_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IamArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "iam_arn");

    /// <summary>
    /// The s3_canonical_user_id attribute.
    /// </summary>
    [TerraformPropertyName("s3_canonical_user_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> S3CanonicalUserId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "s3_canonical_user_id");

}
