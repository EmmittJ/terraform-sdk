using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_account_public_access_block.
/// </summary>
public partial class AwsS3AccountPublicAccessBlockDataSource : TerraformDataSource
{
    public AwsS3AccountPublicAccessBlockDataSource(string name) : base("aws_s3_account_public_access_block", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    [TerraformProperty("block_public_acls")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> BlockPublicAcls { get; }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    [TerraformProperty("block_public_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> BlockPublicPolicy { get; }

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    [TerraformProperty("ignore_public_acls")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IgnorePublicAcls { get; }

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    [TerraformProperty("restrict_public_buckets")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> RestrictPublicBuckets { get; }

}
