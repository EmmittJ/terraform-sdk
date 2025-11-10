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
    public required TerraformProperty<TerraformProperty<string>> CertificateId { get; set; }

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
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_arn");

    /// <summary>
    /// The certificate_creation_date attribute.
    /// </summary>
    [TerraformPropertyName("certificate_creation_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateCreationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_creation_date");

    /// <summary>
    /// The certificate_owner attribute.
    /// </summary>
    [TerraformPropertyName("certificate_owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateOwner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_owner");

    /// <summary>
    /// The certificate_pem attribute.
    /// </summary>
    [TerraformPropertyName("certificate_pem")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificatePem => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_pem");

    /// <summary>
    /// The certificate_wallet attribute.
    /// </summary>
    [TerraformPropertyName("certificate_wallet")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateWallet => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_wallet");

    /// <summary>
    /// The key_length attribute.
    /// </summary>
    [TerraformPropertyName("key_length")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> KeyLength => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "key_length");

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("signing_algorithm")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SigningAlgorithm => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "signing_algorithm");

    /// <summary>
    /// The valid_from_date attribute.
    /// </summary>
    [TerraformPropertyName("valid_from_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ValidFromDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "valid_from_date");

    /// <summary>
    /// The valid_to_date attribute.
    /// </summary>
    [TerraformPropertyName("valid_to_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ValidToDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "valid_to_date");

}
