using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAttestationProvider.
/// Nesting mode: single
/// </summary>
public class AzurermAttestationProviderTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_attestation_provider Terraform resource.
/// Manages a azurerm_attestation_provider resource.
/// </summary>
public partial class AzurermAttestationProvider(string name) : TerraformResource("azurerm_attestation_provider", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The open_enclave_policy_base64 attribute.
    /// </summary>
    public TerraformValue<string>? OpenEnclavePolicyBase64
    {
        get => GetArgument<TerraformValue<string>>("open_enclave_policy_base64");
        set => SetArgument("open_enclave_policy_base64", value);
    }

    /// <summary>
    /// The policy_signing_certificate_data attribute.
    /// </summary>
    public TerraformValue<string>? PolicySigningCertificateData
    {
        get => GetArgument<TerraformValue<string>>("policy_signing_certificate_data");
        set => SetArgument("policy_signing_certificate_data", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sev_snp_policy_base64 attribute.
    /// </summary>
    public TerraformValue<string>? SevSnpPolicyBase64
    {
        get => GetArgument<TerraformValue<string>>("sev_snp_policy_base64");
        set => SetArgument("sev_snp_policy_base64", value);
    }

    /// <summary>
    /// The sgx_enclave_policy_base64 attribute.
    /// </summary>
    public TerraformValue<string>? SgxEnclavePolicyBase64
    {
        get => GetArgument<TerraformValue<string>>("sgx_enclave_policy_base64");
        set => SetArgument("sgx_enclave_policy_base64", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tpm_policy_base64 attribute.
    /// </summary>
    public TerraformValue<string>? TpmPolicyBase64
    {
        get => GetArgument<TerraformValue<string>>("tpm_policy_base64");
        set => SetArgument("tpm_policy_base64", value);
    }

    /// <summary>
    /// The attestation_uri attribute.
    /// </summary>
    public TerraformValue<string> AttestationUri
        => AsReference("attestation_uri");

    /// <summary>
    /// The trust_model attribute.
    /// </summary>
    public TerraformValue<string> TrustModel
        => AsReference("trust_model");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAttestationProviderTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAttestationProviderTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
