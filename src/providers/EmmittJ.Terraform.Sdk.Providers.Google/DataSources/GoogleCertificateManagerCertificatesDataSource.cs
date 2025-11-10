using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_certificate_manager_certificates.
/// </summary>
public class GoogleCertificateManagerCertificatesDataSource : TerraformDataSource
{
    public GoogleCertificateManagerCertificatesDataSource(string name) : base("google_certificate_manager_certificates", name)
    {
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    [TerraformPropertyName("certificates")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Certificates => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "certificates");

}
