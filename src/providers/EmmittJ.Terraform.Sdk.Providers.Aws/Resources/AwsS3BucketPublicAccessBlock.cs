using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_bucket_public_access_block resource.
/// </summary>
public partial class AwsS3BucketPublicAccessBlock : TerraformResource
{
    public AwsS3BucketPublicAccessBlock(string name) : base("aws_s3_bucket_public_access_block", name)
    {
    }

    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    [TerraformProperty("block_public_acls")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BlockPublicAcls { get; set; }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    [TerraformProperty("block_public_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BlockPublicPolicy { get; set; }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    [TerraformProperty("ignore_public_acls")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IgnorePublicAcls { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    [TerraformProperty("restrict_public_buckets")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RestrictPublicBuckets { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformProperty("skip_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipDestroy { get; set; }

}
