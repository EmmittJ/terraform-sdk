using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_certificate_manager_certificates.
/// </summary>
public partial class GoogleCertificateManagerCertificatesDataSource : TerraformDataSource
{
    public GoogleCertificateManagerCertificatesDataSource(string name) : base("google_certificate_manager_certificates", name)
    {
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformProperty("filter")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    [TerraformProperty("certificates")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Certificates { get; }

}
