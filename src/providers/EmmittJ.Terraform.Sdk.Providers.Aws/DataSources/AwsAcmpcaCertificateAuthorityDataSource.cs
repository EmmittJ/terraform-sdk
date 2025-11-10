using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_acmpca_certificate_authority.
/// </summary>
public class AwsAcmpcaCertificateAuthorityDataSource : TerraformDataSource
{
    public AwsAcmpcaCertificateAuthorityDataSource(string name) : base("aws_acmpca_certificate_authority", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Arn { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Certificate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate");

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformPropertyName("certificate_chain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateChain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_chain");

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    [TerraformPropertyName("certificate_signing_request")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateSigningRequest => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_signing_request");

    /// <summary>
    /// The key_storage_security_standard attribute.
    /// </summary>
    [TerraformPropertyName("key_storage_security_standard")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyStorageSecurityStandard => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_storage_security_standard");

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    [TerraformPropertyName("not_after")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotAfter => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "not_after");

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    [TerraformPropertyName("not_before")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotBefore => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "not_before");

    /// <summary>
    /// The revocation_configuration attribute.
    /// </summary>
    [TerraformPropertyName("revocation_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RevocationConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "revocation_configuration");

    /// <summary>
    /// The serial attribute.
    /// </summary>
    [TerraformPropertyName("serial")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Serial => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "serial");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The usage_mode attribute.
    /// </summary>
    [TerraformPropertyName("usage_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UsageMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "usage_mode");

}
