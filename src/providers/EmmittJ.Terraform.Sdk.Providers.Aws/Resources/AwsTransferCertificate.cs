using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_certificate resource.
/// </summary>
public class AwsTransferCertificate : TerraformResource
{
    public AwsTransferCertificate(string name) : base("aws_transfer_certificate", name)
    {
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Certificate is required")]
    [TerraformPropertyName("certificate")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Certificate { get; set; }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformPropertyName("certificate_chain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateChain { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformPropertyName("private_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateKey { get; set; }

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
    /// The usage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Usage is required")]
    [TerraformPropertyName("usage")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Usage { get; set; }

    /// <summary>
    /// The active_date attribute.
    /// </summary>
    [TerraformPropertyName("active_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ActiveDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "active_date");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("certificate_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_id");

    /// <summary>
    /// The inactive_date attribute.
    /// </summary>
    [TerraformPropertyName("inactive_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InactiveDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "inactive_date");

}
