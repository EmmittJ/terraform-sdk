using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAttestationProviderTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The open_enclave_policy_base64 attribute.
    /// </summary>
    [TerraformPropertyName("open_enclave_policy_base64")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OpenEnclavePolicyBase64 { get; set; }

    /// <summary>
    /// The policy_signing_certificate_data attribute.
    /// </summary>
    [TerraformPropertyName("policy_signing_certificate_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PolicySigningCertificateData { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The sev_snp_policy_base64 attribute.
    /// </summary>
    [TerraformPropertyName("sev_snp_policy_base64")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SevSnpPolicyBase64 { get; set; }

    /// <summary>
    /// The sgx_enclave_policy_base64 attribute.
    /// </summary>
    [TerraformPropertyName("sgx_enclave_policy_base64")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SgxEnclavePolicyBase64 { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tpm_policy_base64 attribute.
    /// </summary>
    [TerraformPropertyName("tpm_policy_base64")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TpmPolicyBase64 { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAttestationProviderTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The attestation_uri attribute.
    /// </summary>
    [TerraformPropertyName("attestation_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AttestationUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "attestation_uri");

    /// <summary>
    /// The trust_model attribute.
    /// </summary>
    [TerraformPropertyName("trust_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TrustModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "trust_model");

}
