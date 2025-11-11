using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_control_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3BucketAclAccessControlPolicyBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_s3_bucket_acl resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsS3BucketAcl : TerraformResource
{
    public AwsS3BucketAcl(string name) : base("aws_s3_bucket_acl", name)
    {
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    [TerraformProperty("acl")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Acl { get; set; }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    [TerraformProperty("expected_bucket_owner")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExpectedBucketOwner { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for access_control_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessControlPolicy block(s) allowed")]
    [TerraformProperty("access_control_policy")]
    public TerraformList<TerraformBlock<AwsS3BucketAclAccessControlPolicyBlock>>? AccessControlPolicy { get; set; }

}
