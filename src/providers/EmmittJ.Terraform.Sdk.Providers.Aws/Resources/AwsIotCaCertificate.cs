using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for registration_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsIotCaCertificateRegistrationConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RoleArn { get; set; }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    [TerraformProperty("template_body")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TemplateBody { get; set; }

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    [TerraformProperty("template_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TemplateName { get; set; }

}

/// <summary>
/// Manages a aws_iot_ca_certificate resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsIotCaCertificate : TerraformResource
{
    public AwsIotCaCertificate(string name) : base("aws_iot_ca_certificate", name)
    {
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Active is required")]
    [TerraformProperty("active")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Active { get; set; }

    /// <summary>
    /// The allow_auto_registration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowAutoRegistration is required")]
    [TerraformProperty("allow_auto_registration")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> AllowAutoRegistration { get; set; }

    /// <summary>
    /// The ca_certificate_pem attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaCertificatePem is required")]
    [TerraformProperty("ca_certificate_pem")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CaCertificatePem { get; set; }

    /// <summary>
    /// The certificate_mode attribute.
    /// </summary>
    [TerraformProperty("certificate_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CertificateMode { get; set; }

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
    /// The verification_certificate_pem attribute.
    /// </summary>
    [TerraformProperty("verification_certificate_pem")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VerificationCertificatePem { get; set; }

    /// <summary>
    /// Block for registration_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistrationConfig block(s) allowed")]
    [TerraformProperty("registration_config")]
    public TerraformList<TerraformBlock<AwsIotCaCertificateRegistrationConfigBlock>>? RegistrationConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The customer_version attribute.
    /// </summary>
    [TerraformProperty("customer_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> CustomerVersion { get; }

    /// <summary>
    /// The generation_id attribute.
    /// </summary>
    [TerraformProperty("generation_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GenerationId { get; }

    /// <summary>
    /// The validity attribute.
    /// </summary>
    [TerraformProperty("validity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Validity { get; }

}
