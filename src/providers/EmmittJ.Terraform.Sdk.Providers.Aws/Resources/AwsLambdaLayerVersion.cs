using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_layer_version resource.
/// </summary>
public class AwsLambdaLayerVersion : TerraformResource
{
    public AwsLambdaLayerVersion(string name) : base("aws_lambda_layer_version", name)
    {
    }

    /// <summary>
    /// The compatible_architectures attribute.
    /// </summary>
    [TerraformPropertyName("compatible_architectures")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? CompatibleArchitectures { get; set; }

    /// <summary>
    /// The compatible_runtimes attribute.
    /// </summary>
    [TerraformPropertyName("compatible_runtimes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? CompatibleRuntimes { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [TerraformPropertyName("filename")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Filename { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The layer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LayerName is required")]
    [TerraformPropertyName("layer_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LayerName { get; set; }

    /// <summary>
    /// The license_info attribute.
    /// </summary>
    [TerraformPropertyName("license_info")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LicenseInfo { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [TerraformPropertyName("s3_bucket")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3Bucket { get; set; }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [TerraformPropertyName("s3_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3Key { get; set; }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    [TerraformPropertyName("s3_object_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3ObjectVersion { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformPropertyName("skip_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipDestroy { get; set; }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    [TerraformPropertyName("source_code_hash")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SourceCodeHash { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_code_hash");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    [TerraformPropertyName("code_sha256")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CodeSha256 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "code_sha256");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_date");

    /// <summary>
    /// The layer_arn attribute.
    /// </summary>
    [TerraformPropertyName("layer_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LayerArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "layer_arn");

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    [TerraformPropertyName("signing_job_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SigningJobArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "signing_job_arn");

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    [TerraformPropertyName("signing_profile_version_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SigningProfileVersionArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "signing_profile_version_arn");

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    [TerraformPropertyName("source_code_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SourceCodeSize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "source_code_size");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

}
