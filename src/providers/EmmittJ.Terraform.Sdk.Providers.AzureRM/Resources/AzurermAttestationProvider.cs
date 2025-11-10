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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.WithOutput("attestation_uri");
        this.WithOutput("trust_model");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The open_enclave_policy_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? OpenEnclavePolicyBase64
    {
        get => GetProperty<TerraformProperty<string>>("open_enclave_policy_base64");
        set => this.WithProperty("open_enclave_policy_base64", value);
    }

    /// <summary>
    /// The policy_signing_certificate_data attribute.
    /// </summary>
    public TerraformProperty<string>? PolicySigningCertificateData
    {
        get => GetProperty<TerraformProperty<string>>("policy_signing_certificate_data");
        set => this.WithProperty("policy_signing_certificate_data", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sev_snp_policy_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? SevSnpPolicyBase64
    {
        get => GetProperty<TerraformProperty<string>>("sev_snp_policy_base64");
        set => this.WithProperty("sev_snp_policy_base64", value);
    }

    /// <summary>
    /// The sgx_enclave_policy_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? SgxEnclavePolicyBase64
    {
        get => GetProperty<TerraformProperty<string>>("sgx_enclave_policy_base64");
        set => this.WithProperty("sgx_enclave_policy_base64", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tpm_policy_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? TpmPolicyBase64
    {
        get => GetProperty<TerraformProperty<string>>("tpm_policy_base64");
        set => this.WithProperty("tpm_policy_base64", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAttestationProviderTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAttestationProviderTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
