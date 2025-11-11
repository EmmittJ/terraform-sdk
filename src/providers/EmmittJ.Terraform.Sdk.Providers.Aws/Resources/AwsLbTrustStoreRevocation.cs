using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsLbTrustStoreRevocationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_lb_trust_store_revocation resource.
/// </summary>
public partial class AwsLbTrustStoreRevocation : TerraformResource
{
    public AwsLbTrustStoreRevocation(string name) : base("aws_lb_trust_store_revocation", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The revocations_s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RevocationsS3Bucket is required")]
    [TerraformProperty("revocations_s3_bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RevocationsS3Bucket { get; set; }

    /// <summary>
    /// The revocations_s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RevocationsS3Key is required")]
    [TerraformProperty("revocations_s3_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RevocationsS3Key { get; set; }

    /// <summary>
    /// The revocations_s3_object_version attribute.
    /// </summary>
    [TerraformProperty("revocations_s3_object_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RevocationsS3ObjectVersion { get; set; }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustStoreArn is required")]
    [TerraformProperty("trust_store_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TrustStoreArn { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsLbTrustStoreRevocationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The revocation_id attribute.
    /// </summary>
    [TerraformProperty("revocation_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> RevocationId { get; }

}
