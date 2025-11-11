using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsLbTrustStoreTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_lb_trust_store resource.
/// </summary>
public partial class AwsLbTrustStore : TerraformResource
{
    public AwsLbTrustStore(string name) : base("aws_lb_trust_store", name)
    {
    }

    /// <summary>
    /// The ca_certificates_bundle_s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaCertificatesBundleS3Bucket is required")]
    [TerraformProperty("ca_certificates_bundle_s3_bucket")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CaCertificatesBundleS3Bucket { get; set; }

    /// <summary>
    /// The ca_certificates_bundle_s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaCertificatesBundleS3Key is required")]
    [TerraformProperty("ca_certificates_bundle_s3_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CaCertificatesBundleS3Key { get; set; }

    /// <summary>
    /// The ca_certificates_bundle_s3_object_version attribute.
    /// </summary>
    [TerraformProperty("ca_certificates_bundle_s3_object_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CaCertificatesBundleS3ObjectVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsLbTrustStoreTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    [TerraformProperty("arn_suffix")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ArnSuffix { get; }

}
