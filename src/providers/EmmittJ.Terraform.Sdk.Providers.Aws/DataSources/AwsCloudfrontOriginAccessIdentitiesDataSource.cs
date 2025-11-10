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
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Comments { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The iam_arns attribute.
    /// </summary>
    [TerraformPropertyName("iam_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> IamArns => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "iam_arns");

    /// <summary>
    /// The ids attribute.
    /// </summary>
    [TerraformPropertyName("ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Ids => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "ids");

    /// <summary>
    /// The s3_canonical_user_ids attribute.
    /// </summary>
    [TerraformPropertyName("s3_canonical_user_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> S3CanonicalUserIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "s3_canonical_user_ids");

}
