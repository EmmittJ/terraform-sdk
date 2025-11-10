using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAttestationProviderTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_attestation_provider resource.
/// </summary>
public class AzurermAttestationProvider : TerraformResource
{
    public AzurermAttestationProvider(string name) : base("azurerm_attestation_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("attestation_uri");
        SetOutput("trust_model");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("open_enclave_policy_base64");
        SetOutput("policy_signing_certificate_data");
        SetOutput("resource_group_name");
        SetOutput("sev_snp_policy_base64");
        SetOutput("sgx_enclave_policy_base64");
        SetOutput("tags");
        SetOutput("tpm_policy_base64");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The open_enclave_policy_base64 attribute.
    /// </summary>
    public TerraformProperty<string> OpenEnclavePolicyBase64
    {
        get => GetRequiredOutput<TerraformProperty<string>>("open_enclave_policy_base64");
        set => SetProperty("open_enclave_policy_base64", value);
    }

    /// <summary>
    /// The policy_signing_certificate_data attribute.
    /// </summary>
    public TerraformProperty<string> PolicySigningCertificateData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_signing_certificate_data");
        set => SetProperty("policy_signing_certificate_data", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sev_snp_policy_base64 attribute.
    /// </summary>
    public TerraformProperty<string> SevSnpPolicyBase64
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sev_snp_policy_base64");
        set => SetProperty("sev_snp_policy_base64", value);
    }

    /// <summary>
    /// The sgx_enclave_policy_base64 attribute.
    /// </summary>
    public TerraformProperty<string> SgxEnclavePolicyBase64
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sgx_enclave_policy_base64");
        set => SetProperty("sgx_enclave_policy_base64", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tpm_policy_base64 attribute.
    /// </summary>
    public TerraformProperty<string> TpmPolicyBase64
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tpm_policy_base64");
        set => SetProperty("tpm_policy_base64", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAttestationProviderTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The attestation_uri attribute.
    /// </summary>
    public TerraformExpression AttestationUri => this["attestation_uri"];

    /// <summary>
    /// The trust_model attribute.
    /// </summary>
    public TerraformExpression TrustModel => this["trust_model"];

}
