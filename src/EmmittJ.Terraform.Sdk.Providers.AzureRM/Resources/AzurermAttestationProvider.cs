using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("attestation_uri");
        this.DeclareOutput("trust_model");
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
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
    /// The attestation_uri attribute.
    /// </summary>
    public TerraformExpression AttestationUri => this["attestation_uri"];

    /// <summary>
    /// The trust_model attribute.
    /// </summary>
    public TerraformExpression TrustModel => this["trust_model"];

}
