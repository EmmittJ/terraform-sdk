using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for registration_config in .
/// Nesting mode: list
/// </summary>
public class AwsIotCaCertificateRegistrationConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoleArn { get; set; }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    [TerraformPropertyName("template_body")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TemplateBody { get; set; }

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    [TerraformPropertyName("template_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TemplateName { get; set; }

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
    public required TerraformProperty<TerraformProperty<bool>> Active { get; set; }

    /// <summary>
    /// The allow_auto_registration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowAutoRegistration is required")]
    [TerraformPropertyName("allow_auto_registration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> AllowAutoRegistration { get; set; }

    /// <summary>
    /// The ca_certificate_pem attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaCertificatePem is required")]
    [TerraformPropertyName("ca_certificate_pem")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CaCertificatePem { get; set; }

    /// <summary>
    /// The certificate_mode attribute.
    /// </summary>
    [TerraformPropertyName("certificate_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The verification_certificate_pem attribute.
    /// </summary>
    [TerraformPropertyName("verification_certificate_pem")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VerificationCertificatePem { get; set; }

    /// <summary>
    /// Block for registration_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistrationConfig block(s) allowed")]
    [TerraformPropertyName("registration_config")]
    public TerraformList<TerraformBlock<AwsIotCaCertificateRegistrationConfigBlock>>? RegistrationConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The customer_version attribute.
    /// </summary>
    [TerraformPropertyName("customer_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CustomerVersion => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "customer_version");

    /// <summary>
    /// The generation_id attribute.
    /// </summary>
    [TerraformPropertyName("generation_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GenerationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "generation_id");

    /// <summary>
    /// The validity attribute.
    /// </summary>
    [TerraformPropertyName("validity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Validity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "validity");

}
