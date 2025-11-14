using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The open_enclave_policy_base64 attribute.
    /// </summary>
    [TerraformArgument("open_enclave_policy_base64")]
    public TerraformValue<string>? OpenEnclavePolicyBase64
    {
        get => new TerraformReference<string>(this, "open_enclave_policy_base64");
        set => SetArgument("open_enclave_policy_base64", value);
    }

    /// <summary>
    /// The policy_signing_certificate_data attribute.
    /// </summary>
    [TerraformArgument("policy_signing_certificate_data")]
    public TerraformValue<string>? PolicySigningCertificateData
    {
        get => new TerraformReference<string>(this, "policy_signing_certificate_data");
        set => SetArgument("policy_signing_certificate_data", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sev_snp_policy_base64 attribute.
    /// </summary>
    [TerraformArgument("sev_snp_policy_base64")]
    public TerraformValue<string>? SevSnpPolicyBase64
    {
        get => new TerraformReference<string>(this, "sev_snp_policy_base64");
        set => SetArgument("sev_snp_policy_base64", value);
    }

    /// <summary>
    /// The sgx_enclave_policy_base64 attribute.
    /// </summary>
    [TerraformArgument("sgx_enclave_policy_base64")]
    public TerraformValue<string>? SgxEnclavePolicyBase64
    {
        get => new TerraformReference<string>(this, "sgx_enclave_policy_base64");
        set => SetArgument("sgx_enclave_policy_base64", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tpm_policy_base64 attribute.
    /// </summary>
    [TerraformArgument("tpm_policy_base64")]
    public TerraformValue<string>? TpmPolicyBase64
    {
        get => new TerraformReference<string>(this, "tpm_policy_base64");
        set => SetArgument("tpm_policy_base64", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAttestationProviderTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The attestation_uri attribute.
    /// </summary>
    [TerraformArgument("attestation_uri")]
    public TerraformValue<string> AttestationUri
    {
        get => new TerraformReference<string>(this, "attestation_uri");
    }

    /// <summary>
    /// The trust_model attribute.
    /// </summary>
    [TerraformArgument("trust_model")]
    public TerraformValue<string> TrustModel
    {
        get => new TerraformReference<string>(this, "trust_model");
    }

}
