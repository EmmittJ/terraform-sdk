using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAttestationProviderTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_attestation_provider resource.
/// </summary>
public class AzurermAttestationProvider : TerraformResource
{
    public AzurermAttestationProvider(string name) : base("azurerm_attestation_provider", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The open_enclave_policy_base64 attribute.
    /// </summary>
    [TerraformPropertyName("open_enclave_policy_base64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OpenEnclavePolicyBase64 { get; set; }

    /// <summary>
    /// The policy_signing_certificate_data attribute.
    /// </summary>
    [TerraformPropertyName("policy_signing_certificate_data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PolicySigningCertificateData { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sev_snp_policy_base64 attribute.
    /// </summary>
    [TerraformPropertyName("sev_snp_policy_base64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SevSnpPolicyBase64 { get; set; }

    /// <summary>
    /// The sgx_enclave_policy_base64 attribute.
    /// </summary>
    [TerraformPropertyName("sgx_enclave_policy_base64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SgxEnclavePolicyBase64 { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tpm_policy_base64 attribute.
    /// </summary>
    [TerraformPropertyName("tpm_policy_base64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TpmPolicyBase64 { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAttestationProviderTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The attestation_uri attribute.
    /// </summary>
    [TerraformPropertyName("attestation_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AttestationUri => new TerraformReference(this, "attestation_uri");

    /// <summary>
    /// The trust_model attribute.
    /// </summary>
    [TerraformPropertyName("trust_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TrustModel => new TerraformReference(this, "trust_model");

}
