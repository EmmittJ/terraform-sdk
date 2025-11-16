using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The open_enclave_policy_base64 attribute.
    /// </summary>
    public TerraformValue<string>? OpenEnclavePolicyBase64
    {
        get => new TerraformReference<string>(this, "open_enclave_policy_base64");
        set => SetArgument("open_enclave_policy_base64", value);
    }

    /// <summary>
    /// The policy_signing_certificate_data attribute.
    /// </summary>
    public TerraformValue<string>? PolicySigningCertificateData
    {
        get => new TerraformReference<string>(this, "policy_signing_certificate_data");
        set => SetArgument("policy_signing_certificate_data", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sev_snp_policy_base64 attribute.
    /// </summary>
    public TerraformValue<string>? SevSnpPolicyBase64
    {
        get => new TerraformReference<string>(this, "sev_snp_policy_base64");
        set => SetArgument("sev_snp_policy_base64", value);
    }

    /// <summary>
    /// The sgx_enclave_policy_base64 attribute.
    /// </summary>
    public TerraformValue<string>? SgxEnclavePolicyBase64
    {
        get => new TerraformReference<string>(this, "sgx_enclave_policy_base64");
        set => SetArgument("sgx_enclave_policy_base64", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tpm_policy_base64 attribute.
    /// </summary>
    public TerraformValue<string>? TpmPolicyBase64
    {
        get => new TerraformReference<string>(this, "tpm_policy_base64");
        set => SetArgument("tpm_policy_base64", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAttestationProviderTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAttestationProviderTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
