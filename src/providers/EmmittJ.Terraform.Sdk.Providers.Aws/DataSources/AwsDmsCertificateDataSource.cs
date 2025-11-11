using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dms_certificate.
/// </summary>
public class AwsDmsCertificateDataSource : TerraformDataSource
{
    public AwsDmsCertificateDataSource(string name) : base("aws_dms_certificate", name)
    {
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateId is required")]
    [TerraformPropertyName("certificate_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CertificateId { get; set; }

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
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateArn => new TerraformReference(this, "certificate_arn");

    /// <summary>
    /// The certificate_creation_date attribute.
    /// </summary>
    [TerraformPropertyName("certificate_creation_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateCreationDate => new TerraformReference(this, "certificate_creation_date");

    /// <summary>
    /// The certificate_owner attribute.
    /// </summary>
    [TerraformPropertyName("certificate_owner")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateOwner => new TerraformReference(this, "certificate_owner");

    /// <summary>
    /// The certificate_pem attribute.
    /// </summary>
    [TerraformPropertyName("certificate_pem")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificatePem => new TerraformReference(this, "certificate_pem");

    /// <summary>
    /// The certificate_wallet attribute.
    /// </summary>
    [TerraformPropertyName("certificate_wallet")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateWallet => new TerraformReference(this, "certificate_wallet");

    /// <summary>
    /// The key_length attribute.
    /// </summary>
    [TerraformPropertyName("key_length")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> KeyLength => new TerraformReference(this, "key_length");

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("signing_algorithm")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SigningAlgorithm => new TerraformReference(this, "signing_algorithm");

    /// <summary>
    /// The valid_from_date attribute.
    /// </summary>
    [TerraformPropertyName("valid_from_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ValidFromDate => new TerraformReference(this, "valid_from_date");

    /// <summary>
    /// The valid_to_date attribute.
    /// </summary>
    [TerraformPropertyName("valid_to_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ValidToDate => new TerraformReference(this, "valid_to_date");

}
