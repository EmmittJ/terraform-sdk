using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_certificate resource.
/// </summary>
public class AwsIotCertificate : TerraformResource
{
    public AwsIotCertificate(string name) : base("aws_iot_certificate", name)
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
    /// The ca_pem attribute.
    /// </summary>
    [TerraformPropertyName("ca_pem")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CaPem { get; set; }

    /// <summary>
    /// The certificate_pem attribute.
    /// </summary>
    [TerraformPropertyName("certificate_pem")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CertificatePem { get; set; } = default!;

    /// <summary>
    /// The csr attribute.
    /// </summary>
    [TerraformPropertyName("csr")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Csr { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The ca_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("ca_certificate_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CaCertificateId => new TerraformReference(this, "ca_certificate_id");

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformPropertyName("private_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateKey => new TerraformReference(this, "private_key");

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformPropertyName("public_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicKey => new TerraformReference(this, "public_key");

}
