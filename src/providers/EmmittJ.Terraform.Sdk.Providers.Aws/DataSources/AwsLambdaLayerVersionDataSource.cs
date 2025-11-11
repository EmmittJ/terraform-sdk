using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lambda_layer_version.
/// </summary>
public class AwsLambdaLayerVersionDataSource : TerraformDataSource
{
    public AwsLambdaLayerVersionDataSource(string name) : base("aws_lambda_layer_version", name)
    {
    }

    /// <summary>
    /// The compatible_architecture attribute.
    /// </summary>
    [TerraformPropertyName("compatible_architecture")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CompatibleArchitecture { get; set; }

    /// <summary>
    /// The compatible_runtime attribute.
    /// </summary>
    [TerraformPropertyName("compatible_runtime")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CompatibleRuntime { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The layer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LayerName is required")]
    [TerraformPropertyName("layer_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LayerName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Version { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    [TerraformPropertyName("code_sha256")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CodeSha256 => new TerraformReference(this, "code_sha256");

    /// <summary>
    /// The compatible_architectures attribute.
    /// </summary>
    [TerraformPropertyName("compatible_architectures")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> CompatibleArchitectures => new TerraformReference(this, "compatible_architectures");

    /// <summary>
    /// The compatible_runtimes attribute.
    /// </summary>
    [TerraformPropertyName("compatible_runtimes")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> CompatibleRuntimes => new TerraformReference(this, "compatible_runtimes");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedDate => new TerraformReference(this, "created_date");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The layer_arn attribute.
    /// </summary>
    [TerraformPropertyName("layer_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LayerArn => new TerraformReference(this, "layer_arn");

    /// <summary>
    /// The license_info attribute.
    /// </summary>
    [TerraformPropertyName("license_info")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LicenseInfo => new TerraformReference(this, "license_info");

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    [TerraformPropertyName("signing_job_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SigningJobArn => new TerraformReference(this, "signing_job_arn");

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    [TerraformPropertyName("signing_profile_version_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SigningProfileVersionArn => new TerraformReference(this, "signing_profile_version_arn");

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    [TerraformPropertyName("source_code_hash")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceCodeHash => new TerraformReference(this, "source_code_hash");

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    [TerraformPropertyName("source_code_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SourceCodeSize => new TerraformReference(this, "source_code_size");

}
