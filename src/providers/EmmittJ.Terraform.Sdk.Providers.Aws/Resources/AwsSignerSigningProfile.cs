using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for signature_validity_period in .
/// Nesting mode: list
/// </summary>
public partial class AwsSignerSigningProfileSignatureValidityPeriodBlock : TerraformBlockBase
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Value { get; set; }

}

/// <summary>
/// Block type for signing_material in .
/// Nesting mode: list
/// </summary>
public partial class AwsSignerSigningProfileSigningMaterialBlock : TerraformBlockBase
{
    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateArn is required")]
    [TerraformProperty("certificate_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CertificateArn { get; set; }

}

/// <summary>
/// Manages a aws_signer_signing_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSignerSigningProfile : TerraformResource
{
    public AwsSignerSigningProfile(string name) : base("aws_signer_signing_profile", name)
    {
    }

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
    /// The platform_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformId is required")]
    [TerraformProperty("platform_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PlatformId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The signing_parameters attribute.
    /// </summary>
    [TerraformProperty("signing_parameters")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? SigningParameters { get; set; }

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
    /// Block for signature_validity_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignatureValidityPeriod block(s) allowed")]
    [TerraformProperty("signature_validity_period")]
    public TerraformList<TerraformBlock<AwsSignerSigningProfileSignatureValidityPeriodBlock>>? SignatureValidityPeriod { get; set; }

    /// <summary>
    /// Block for signing_material.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SigningMaterial block(s) allowed")]
    [TerraformProperty("signing_material")]
    public TerraformList<TerraformBlock<AwsSignerSigningProfileSigningMaterialBlock>>? SigningMaterial { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The platform_display_name attribute.
    /// </summary>
    [TerraformProperty("platform_display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PlatformDisplayName { get; }

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    [TerraformProperty("revocation_record")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RevocationRecord { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

    /// <summary>
    /// The version_arn attribute.
    /// </summary>
    [TerraformProperty("version_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VersionArn { get; }

}
