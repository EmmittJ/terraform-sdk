using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lambda_layer_version.
/// </summary>
public partial class AwsLambdaLayerVersionDataSource : TerraformDataSource
{
    public AwsLambdaLayerVersionDataSource(string name) : base("aws_lambda_layer_version", name)
    {
    }

    /// <summary>
    /// The compatible_architecture attribute.
    /// </summary>
    [TerraformProperty("compatible_architecture")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CompatibleArchitecture { get; set; }

    /// <summary>
    /// The compatible_runtime attribute.
    /// </summary>
    [TerraformProperty("compatible_runtime")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CompatibleRuntime { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Version { get; set; }

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
    /// The compatible_architectures attribute.
    /// </summary>
    [TerraformProperty("compatible_architectures")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> CompatibleArchitectures { get; }

    /// <summary>
    /// The compatible_runtimes attribute.
    /// </summary>
    [TerraformProperty("compatible_runtimes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> CompatibleRuntimes { get; }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The layer_arn attribute.
    /// </summary>
    [TerraformProperty("layer_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LayerArn { get; }

    /// <summary>
    /// The license_info attribute.
    /// </summary>
    [TerraformProperty("license_info")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LicenseInfo { get; }

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
    /// The source_code_hash attribute.
    /// </summary>
    [TerraformProperty("source_code_hash")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceCodeHash { get; }

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    [TerraformProperty("source_code_size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> SourceCodeSize { get; }

}
