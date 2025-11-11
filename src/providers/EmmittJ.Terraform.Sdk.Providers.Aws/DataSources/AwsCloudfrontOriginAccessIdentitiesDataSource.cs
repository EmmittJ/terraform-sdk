using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_origin_access_identities.
/// </summary>
public partial class AwsCloudfrontOriginAccessIdentitiesDataSource : TerraformDataSource
{
    public AwsCloudfrontOriginAccessIdentitiesDataSource(string name) : base("aws_cloudfront_origin_access_identities", name)
    {
    }

    /// <summary>
    /// The comments attribute.
    /// </summary>
    [TerraformProperty("comments")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Comments { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The iam_arns attribute.
    /// </summary>
    [TerraformProperty("iam_arns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> IamArns { get; }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    [TerraformProperty("ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Ids { get; }

    /// <summary>
    /// The s3_canonical_user_ids attribute.
    /// </summary>
    [TerraformProperty("s3_canonical_user_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> S3CanonicalUserIds { get; }

}
