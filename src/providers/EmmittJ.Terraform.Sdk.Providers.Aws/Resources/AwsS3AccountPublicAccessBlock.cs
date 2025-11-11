using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_account_public_access_block resource.
/// </summary>
public partial class AwsS3AccountPublicAccessBlock : TerraformResource
{
    public AwsS3AccountPublicAccessBlock(string name) : base("aws_s3_account_public_access_block", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccountId { get; set; }

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
    /// The restrict_public_buckets attribute.
    /// </summary>
    [TerraformProperty("restrict_public_buckets")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RestrictPublicBuckets { get; set; }

}
