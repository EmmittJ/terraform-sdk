using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_account_public_access_block.
/// </summary>
public class AwsS3AccountPublicAccessBlockDataSource : TerraformDataSource
{
    public AwsS3AccountPublicAccessBlockDataSource(string name) : base("aws_s3_account_public_access_block", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    [TerraformPropertyName("block_public_acls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> BlockPublicAcls => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "block_public_acls");

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    [TerraformPropertyName("block_public_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> BlockPublicPolicy => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "block_public_policy");

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    [TerraformPropertyName("ignore_public_acls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IgnorePublicAcls => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ignore_public_acls");

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    [TerraformPropertyName("restrict_public_buckets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RestrictPublicBuckets => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "restrict_public_buckets");

}
