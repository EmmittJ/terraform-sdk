using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAttestationProviderTimeoutsBlock() : TerraformBlock("timeouts")
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_attestation_provider resource.
/// </summary>
public partial class AzurermAttestationProvider : TerraformResource
{
    public AzurermAttestationProvider(string name) : base("azurerm_attestation_provider", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The open_enclave_policy_base64 attribute.
    /// </summary>
    [TerraformProperty("open_enclave_policy_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OpenEnclavePolicyBase64 { get; set; }

    /// <summary>
    /// The policy_signing_certificate_data attribute.
    /// </summary>
    [TerraformProperty("policy_signing_certificate_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PolicySigningCertificateData { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sev_snp_policy_base64 attribute.
    /// </summary>
    [TerraformProperty("sev_snp_policy_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SevSnpPolicyBase64 { get; set; }

    /// <summary>
    /// The sgx_enclave_policy_base64 attribute.
    /// </summary>
    [TerraformProperty("sgx_enclave_policy_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SgxEnclavePolicyBase64 { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tpm_policy_base64 attribute.
    /// </summary>
    [TerraformProperty("tpm_policy_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TpmPolicyBase64 { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermAttestationProviderTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The attestation_uri attribute.
    /// </summary>
    [TerraformProperty("attestation_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AttestationUri { get; }

    /// <summary>
    /// The trust_model attribute.
    /// </summary>
    [TerraformProperty("trust_model")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TrustModel { get; }

}
