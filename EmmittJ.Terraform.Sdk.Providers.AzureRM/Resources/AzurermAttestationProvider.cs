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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The open_enclave_policy_base64 attribute.
    /// </summary>
    public string? OpenEnclavePolicyBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("open_enclave_policy_base64")?.Value;
        set => this.WithProperty("open_enclave_policy_base64", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_signing_certificate_data attribute.
    /// </summary>
    public string? PolicySigningCertificateData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_signing_certificate_data")?.Value;
        set => this.WithProperty("policy_signing_certificate_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sev_snp_policy_base64 attribute.
    /// </summary>
    public string? SevSnpPolicyBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sev_snp_policy_base64")?.Value;
        set => this.WithProperty("sev_snp_policy_base64", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sgx_enclave_policy_base64 attribute.
    /// </summary>
    public string? SgxEnclavePolicyBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sgx_enclave_policy_base64")?.Value;
        set => this.WithProperty("sgx_enclave_policy_base64", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tpm_policy_base64 attribute.
    /// </summary>
    public string? TpmPolicyBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tpm_policy_base64")?.Value;
        set => this.WithProperty("tpm_policy_base64", value == null ? null : new TerraformLiteralProperty<string>(value));
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
