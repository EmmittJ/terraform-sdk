using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLbTrustStoreRevocationTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_lb_trust_store_revocation resource.
/// </summary>
public class AwsLbTrustStoreRevocation : TerraformResource
{
    public AwsLbTrustStoreRevocation(string name) : base("aws_lb_trust_store_revocation", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The revocations_s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RevocationsS3Bucket is required")]
    [TerraformPropertyName("revocations_s3_bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RevocationsS3Bucket { get; set; }

    /// <summary>
    /// The revocations_s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RevocationsS3Key is required")]
    [TerraformPropertyName("revocations_s3_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RevocationsS3Key { get; set; }

    /// <summary>
    /// The revocations_s3_object_version attribute.
    /// </summary>
    [TerraformPropertyName("revocations_s3_object_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RevocationsS3ObjectVersion { get; set; }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustStoreArn is required")]
    [TerraformPropertyName("trust_store_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TrustStoreArn { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLbTrustStoreRevocationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The revocation_id attribute.
    /// </summary>
    [TerraformPropertyName("revocation_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RevocationId => new TerraformReference(this, "revocation_id");

}
