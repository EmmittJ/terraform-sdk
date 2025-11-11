using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_layer_version resource.
/// </summary>
public partial class AwsLambdaLayerVersion : TerraformResource
{
    public AwsLambdaLayerVersion(string name) : base("aws_lambda_layer_version", name)
    {
    }

    /// <summary>
    /// The compatible_architectures attribute.
    /// </summary>
    [TerraformProperty("compatible_architectures")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? CompatibleArchitectures { get; set; }

    /// <summary>
    /// The compatible_runtimes attribute.
    /// </summary>
    [TerraformProperty("compatible_runtimes")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? CompatibleRuntimes { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [TerraformProperty("filename")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Filename { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The layer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LayerName is required")]
    [TerraformProperty("layer_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LayerName { get; set; }

    /// <summary>
    /// The license_info attribute.
    /// </summary>
    [TerraformProperty("license_info")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LicenseInfo { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [TerraformProperty("s3_bucket")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? S3Bucket { get; set; }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [TerraformProperty("s3_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? S3Key { get; set; }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    [TerraformProperty("s3_object_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? S3ObjectVersion { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformProperty("skip_destroy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SkipDestroy { get; set; }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    [TerraformProperty("source_code_hash")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SourceCodeHash { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    [TerraformProperty("code_sha256")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CodeSha256 { get; }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The layer_arn attribute.
    /// </summary>
    [TerraformProperty("layer_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LayerArn { get; }

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    [TerraformProperty("signing_job_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SigningJobArn { get; }

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    [TerraformProperty("signing_profile_version_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SigningProfileVersionArn { get; }

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    [TerraformProperty("source_code_size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> SourceCodeSize { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

}
