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
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

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
    /// The comment attribute.
    /// </summary>
    [TerraformPropertyName("comment")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Comment => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "comment");

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
