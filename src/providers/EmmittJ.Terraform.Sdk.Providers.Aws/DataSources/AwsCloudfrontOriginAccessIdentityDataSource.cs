using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_origin_access_identity.
/// </summary>
public partial class AwsCloudfrontOriginAccessIdentityDataSource : TerraformDataSource
{
    public AwsCloudfrontOriginAccessIdentityDataSource(string name) : base("aws_cloudfront_origin_access_identity", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Id { get; set; }

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
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Comment { get; }

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
