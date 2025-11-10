using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_bucket_public_access_block resource.
/// </summary>
public class AwsS3BucketPublicAccessBlock : TerraformResource
{
    public AwsS3BucketPublicAccessBlock(string name) : base("aws_s3_bucket_public_access_block", name)
    {
    }

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
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    [TerraformPropertyName("restrict_public_buckets")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RestrictPublicBuckets { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformPropertyName("skip_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipDestroy { get; set; }

}
