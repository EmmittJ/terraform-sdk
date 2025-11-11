using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfront_origin_access_identity resource.
/// </summary>
public partial class AwsCloudfrontOriginAccessIdentity : TerraformResource
{
    public AwsCloudfrontOriginAccessIdentity(string name) : base("aws_cloudfront_origin_access_identity", name)
    {
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Comment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    [TerraformProperty("caller_reference")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CallerReference { get; }

    /// <summary>
    /// The cloudfront_access_identity_path attribute.
    /// </summary>
    [TerraformProperty("cloudfront_access_identity_path")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CloudfrontAccessIdentityPath { get; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// The iam_arn attribute.
    /// </summary>
    [TerraformProperty("iam_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IamArn { get; }

    /// <summary>
    /// The s3_canonical_user_id attribute.
    /// </summary>
    [TerraformProperty("s3_canonical_user_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> S3CanonicalUserId { get; }

}
