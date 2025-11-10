using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_acm_certificate.
/// </summary>
public class AwsAcmCertificateDataSource : TerraformDataSource
{
    public AwsAcmCertificateDataSource(string name) : base("aws_acm_certificate", name)
    {
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Domain { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key_types attribute.
    /// </summary>
    [TerraformPropertyName("key_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? KeyTypes { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformPropertyName("most_recent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MostRecent { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The statuses attribute.
    /// </summary>
    [TerraformPropertyName("statuses")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Statuses { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The types attribute.
    /// </summary>
    [TerraformPropertyName("types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Types { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

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
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
