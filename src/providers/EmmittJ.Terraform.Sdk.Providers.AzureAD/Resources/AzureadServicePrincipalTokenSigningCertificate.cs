using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadServicePrincipalTokenSigningCertificateTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azuread_service_principal_token_signing_certificate resource.
/// </summary>
public partial class AzureadServicePrincipalTokenSigningCertificate : TerraformResource
{
    public AzureadServicePrincipalTokenSigningCertificate(string name) : base("azuread_service_principal_token_signing_certificate", name)
    {
    }

    /// <summary>
    /// A friendly name for the certificate
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). Default is 3 years from current date.
    /// </summary>
    [TerraformProperty("end_date")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EndDate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the service principal for which this certificate should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    [TerraformProperty("service_principal_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServicePrincipalId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzureadServicePrincipalTokenSigningCertificateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// A UUID used to uniquely identify the verify certificate.
    /// </summary>
    [TerraformProperty("key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyId { get; }

    /// <summary>
    /// The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).
    /// </summary>
    [TerraformProperty("start_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StartDate { get; }

    /// <summary>
    /// The thumbprint of the certificate.
    /// </summary>
    [TerraformProperty("thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Thumbprint { get; }

    /// <summary>
    /// The certificate data, which is PEM encoded but does not include the header/footer
    /// </summary>
    [TerraformProperty("value")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Value { get; }

}
