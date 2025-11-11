using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for registration_config in .
/// Nesting mode: list
/// </summary>
public class AwsIotCaCertificateRegistrationConfigBlock
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleArn { get; set; }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    [TerraformPropertyName("template_body")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TemplateBody { get; set; }

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    [TerraformPropertyName("template_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TemplateName { get; set; }

}

/// <summary>
/// Manages a aws_iot_ca_certificate resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsIotCaCertificate : TerraformResource
{
    public AwsIotCaCertificate(string name) : base("aws_iot_ca_certificate", name)
    {
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Active is required")]
    [TerraformPropertyName("active")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Active { get; set; }

    /// <summary>
    /// The allow_auto_registration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowAutoRegistration is required")]
    [TerraformPropertyName("allow_auto_registration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> AllowAutoRegistration { get; set; }

    /// <summary>
    /// The ca_certificate_pem attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaCertificatePem is required")]
    [TerraformPropertyName("ca_certificate_pem")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CaCertificatePem { get; set; }

    /// <summary>
    /// The certificate_mode attribute.
    /// </summary>
    [TerraformPropertyName("certificate_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateMode { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The verification_certificate_pem attribute.
    /// </summary>
    [TerraformPropertyName("verification_certificate_pem")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VerificationCertificatePem { get; set; }

    /// <summary>
    /// Block for registration_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistrationConfig block(s) allowed")]
    [TerraformPropertyName("registration_config")]
    public TerraformList<TerraformBlock<AwsIotCaCertificateRegistrationConfigBlock>>? RegistrationConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The customer_version attribute.
    /// </summary>
    [TerraformPropertyName("customer_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CustomerVersion => new TerraformReference(this, "customer_version");

    /// <summary>
    /// The generation_id attribute.
    /// </summary>
    [TerraformPropertyName("generation_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GenerationId => new TerraformReference(this, "generation_id");

    /// <summary>
    /// The validity attribute.
    /// </summary>
    [TerraformPropertyName("validity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Validity => new TerraformReference(this, "validity");

}
