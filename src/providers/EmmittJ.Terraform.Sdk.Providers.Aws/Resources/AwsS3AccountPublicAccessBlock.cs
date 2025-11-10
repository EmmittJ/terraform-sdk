using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_account_public_access_block resource.
/// </summary>
public class AwsS3AccountPublicAccessBlock : TerraformResource
{
    public AwsS3AccountPublicAccessBlock(string name) : base("aws_s3_account_public_access_block", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_id");

    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    [TerraformPropertyName("block_public_acls")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BlockPublicAcls { get; set; }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    [TerraformPropertyName("block_public_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BlockPublicPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    [TerraformPropertyName("ignore_public_acls")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnorePublicAcls { get; set; }

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    [TerraformPropertyName("restrict_public_buckets")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RestrictPublicBuckets { get; set; }

}
