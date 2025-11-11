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
    public required TerraformValue<string> Arn { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Certificate => new TerraformReference(this, "certificate");

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformPropertyName("certificate_chain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateChain => new TerraformReference(this, "certificate_chain");

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    [TerraformPropertyName("certificate_signing_request")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateSigningRequest => new TerraformReference(this, "certificate_signing_request");

    /// <summary>
    /// The key_storage_security_standard attribute.
    /// </summary>
    [TerraformPropertyName("key_storage_security_standard")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyStorageSecurityStandard => new TerraformReference(this, "key_storage_security_standard");

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    [TerraformPropertyName("not_after")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NotAfter => new TerraformReference(this, "not_after");

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    [TerraformPropertyName("not_before")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NotBefore => new TerraformReference(this, "not_before");

    /// <summary>
    /// The revocation_configuration attribute.
    /// </summary>
    [TerraformPropertyName("revocation_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RevocationConfiguration => new TerraformReference(this, "revocation_configuration");

    /// <summary>
    /// The serial attribute.
    /// </summary>
    [TerraformPropertyName("serial")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Serial => new TerraformReference(this, "serial");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

    /// <summary>
    /// The usage_mode attribute.
    /// </summary>
    [TerraformPropertyName("usage_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UsageMode => new TerraformReference(this, "usage_mode");

}
